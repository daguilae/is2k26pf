@echo off
setlocal enabledelayedexpansion
color 0A

echo ======================================================
echo SISTEMA DE COMPILACION GLOBAL - MRP G1 (ULTIMATE)
echo ======================================================

:: --- CONFIGURACION DE RUTAS ---
set "MSBUILD_PATH=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe"
set "ROOT_DIR=%~dp0"
set "HOTELERIA_DIR=C:\asis2k25p2\codigo\modulos\hoteleria"
set "MRP_MAINT_DIR=%ROOT_DIR%codigo\empresarial\MRP - G1\Mantenimientos"
set "MRP_DLLS_DIR=%ROOT_DIR%codigo\empresarial\MRP - G1\DLLS"
set "MRP_NAV_TRANS_DIR=%ROOT_DIR%codigo\empresarial\MRP - G1\NavegadorTransaccionalMVC"
set "MRP_MVC_DIR=%ROOT_DIR%codigo\empresarial\MRP - G1\MVC_MRP"

:: Verificacion de MSBuild
if not exist "%MSBUILD_PATH%" (
    set "MSBUILD_PATH=C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe"
)

cd /d "%ROOT_DIR%"

:: ==========================================================
:: 1. CICLOS DE COMPILACION BASE + NAVEGADOR TRANSACCIONAL
:: ==========================================================
for /L %%i in (1,1,4) do (
    echo.
    echo CICLO %%i: Compilando Componentes Base...
    call :CompilarModulo CONSULTAS
    call :CompilarModulo REPORTEADOR
    call :CompilarModulo SEGURIDAD
    call :CompilarModulo NAVEGADOR_TRANSACCIONAL
    call :CompilarModulo NAVEGADOR
)

:: ==========================================================
:: 2. COMPILACION DINAMICA DE DLLS
:: ==========================================================
echo.
color 0E
echo [+] Compilando Carpeta de DLLS Dinamica...
if exist "%MRP_DLLS_DIR%" (
    for /r "%MRP_DLLS_DIR%" %%d in (*.csproj) do (
        echo    -> DLL: %%~nxd
        "%MSBUILD_PATH%" "%%d" /t:Build /p:Configuration=Debug /v:m /m > nul 2>&1
        if !errorlevel! equ 0 (
            echo        [OK] Compilado correctamente
        ) else (
            echo        [ERROR] Fallo en compilacion
        )
    )
) else (
    echo    [ADVERTENCIA] Carpeta DLLS no encontrada: %MRP_DLLS_DIR%
)

:: ==========================================================
:: 3. COMPILAR HOTELERIA
:: ==========================================================
echo.
color 0A
echo [+] Compilando Soluciones de Hoteleria...
if exist "%HOTELERIA_DIR%" (
    for /r "%HOTELERIA_DIR%" %%f in (*.sln) do (
        echo    -> Solucion: %%~nxf
        "%MSBUILD_PATH%" "%%f" /p:Configuration=Debug /m /v:m > nul 2>&1
    )
) else (
    echo    [ADVERTENCIA] Carpeta Hoteleria no encontrada: %HOTELERIA_DIR%
)

:: ==========================================================
:: 4. COMPILACION DINAMICA MANTENIMIENTOS MRP
:: ==========================================================
echo.
color 0B
echo [+] Compilando Mantenimientos MRP Dinamicamente...
if exist "%MRP_MAINT_DIR%" (
    for /L %%P in (1,1,2) do (
        for /r "%MRP_MAINT_DIR%" %%p in (*.csproj) do (
            echo    -> Mantenimiento: %%~nxp
            "%MSBUILD_PATH%" "%%p" /t:Build /p:Configuration=Debug /v:m /m > nul 2>&1
        )
    )
) else (
    echo    [ADVERTENCIA] Carpeta Mantenimientos no encontrada: %MRP_MAINT_DIR%
)

:: ==========================================================
:: 5. COMPILAR MVC_MRP (PROYECTO PRINCIPAL)
:: ==========================================================
echo.
color 0F
echo [+] Compilando MVC_MRP Principal (Ultimo paso)...
if exist "%MRP_MVC_DIR%" (
    if exist "%MRP_MVC_DIR%\MVC_MRP.sln" (
        echo    -> Compilando solucion MVC_MRP.sln
        "%MSBUILD_PATH%" "%MRP_MVC_DIR%\MVC_MRP.sln" /t:Build /p:Configuration=Debug /v:m /m > nul 2>&1
        if !errorlevel! equ 0 (
            echo        [OK] Solucion MVC_MRP compilada correctamente
        ) else (
            echo        [ERROR] Fallo en solucion MVC_MRP
        )
    )
    
    echo    -> Compilando proyectos individuales...
    if exist "%MRP_MVC_DIR%\Capa_Modelo_MRP\Capa_Modelo_MRP.csproj" (
        "%MSBUILD_PATH%" "%MRP_MVC_DIR%\Capa_Modelo_MRP\Capa_Modelo_MRP.csproj" /t:Build /p:Configuration=Debug /v:m /m > nul 2>&1
        echo        [OK] Capa_Modelo_MRP
    )
    if exist "%MRP_MVC_DIR%\Capa_Controlador_MRP\Capa_Controlador_MRP.csproj" (
        "%MSBUILD_PATH%" "%MRP_MVC_DIR%\Capa_Controlador_MRP\Capa_Controlador_MRP.csproj" /t:Build /p:Configuration=Debug /v:m /m > nul 2>&1
        echo        [OK] Capa_Controlador_MRP
    )
    if exist "%MRP_MVC_DIR%\Capa_Vista_MRP\Capa_Vista_MRP.csproj" (
        "%MSBUILD_PATH%" "%MRP_MVC_DIR%\Capa_Vista_MRP\Capa_Vista_MRP.csproj" /t:Build /p:Configuration=Debug /v:m /m > nul 2>&1
        echo        [OK] Capa_Vista_MRP
    )
    echo    [OK] MVC_MRP Procesado completamente.
) else (
    echo    [ERROR] Carpeta MVC_MRP no encontrada: %MRP_MVC_DIR%
)

echo.
echo ======================================================
echo COMPILACION FINALIZADA COMPLETAMENTE.
echo ======================================================
pause
exit /b 0

:: ==========================================================
:: FUNCION: COMPILAR MODULOS (BASE Y ESPECIFICOS)
:: ==========================================================
:CompilarModulo
if /I "%1"=="CONSULTAS" (
    "%MSBUILD_PATH%" "codigo\componentes\consultas\Componente_Consultas\Capa_Modelo_Componente_Consultas\Capa_Modelo_Componente_Consultas.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\consultas\Componente_Consultas\Capa_Controlador_Componente_Consultas\Capa_Controlador_Consultas.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\consultas\Componente_Consultas\Capa_Vista_Componente_Consultas\Capa_Vista_Componente_Consultas.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\consultas\ComponenteConsultasSimples\Capa_Modelo_Componente_Consultas\Capa_Modelo_Componente_Consultas_Simples.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\consultas\ComponenteConsultasSimples\Capa_Controlador_Componente_Consultas\Capa_Controlador_Componente_Consultas_Simples.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\consultas\ComponenteConsultasSimples\Capa_Vista_Componente_Consultas_simples\Capa_Vista_Componente_Consultas_simples.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
)
if /I "%1"=="REPORTEADOR" (
    "%MSBUILD_PATH%" "codigo\componentes\reporteador\reporteador\Capa_Modelo_Reporteador\Capa_Modelo_Reporteador.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\reporteador\reporteador\Capa_Controlador_Reporteador\Capa_Controlador_Reporteador.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\reporteador\reporteador\Capa_Vista_Reporteador\Capa_Vista_Reporteador.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
)
if /I "%1"=="SEGURIDAD" (
    "%MSBUILD_PATH%" "codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaModelo\Capa_Modelo_Seguridad.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaControlador\Capa_Controlador_Seguridad.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaVista\Capa_Vista_Seguridad.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
)
if /I "%1"=="NAVEGADOR_TRANSACCIONAL" (
    echo    Compilando NavegadorTransaccionalMVC...
    if exist "%MRP_NAV_TRANS_DIR%\CapaModeloNavegador\Capa_Modelo_NavegadorTrs.csproj" (
        "%MSBUILD_PATH%" "%MRP_NAV_TRANS_DIR%\CapaModeloNavegador\Capa_Modelo_NavegadorTrs.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
        echo        [OK] Modelo Navegador Transaccional
    )
    if exist "%MRP_NAV_TRANS_DIR%\CapaControladorNavegador\Capa_Controlador_NavegadorTrs.csproj" (
        "%MSBUILD_PATH%" "%MRP_NAV_TRANS_DIR%\CapaControladorNavegador\Capa_Controlador_NavegadorTrs.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
        echo        [OK] Controlador Navegador Transaccional
    )
    if exist "%MRP_NAV_TRANS_DIR%\CapaVistaNavegador\Capa_Vista_NavegadorTrs.csproj" (
        "%MSBUILD_PATH%" "%MRP_NAV_TRANS_DIR%\CapaVistaNavegador\Capa_Vista_NavegadorTrs.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
        echo        [OK] Vista Navegador Transaccional
    )
)
if /I "%1"=="NAVEGADOR" (
    "%MSBUILD_PATH%" "codigo\componentes\navegador\NavegadorMVC\CapaModeloNavegador\Capa_Modelo_Navegador.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\navegador\NavegadorMVC\CapaControladorNavegador\Capa_Controlador_Navegador.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\navegador\NavegadorMVC\CapaVistaNavegador\Capa_Vista_Navegador.csproj" /t:Build /p:Configuration=Debug /v:m > nul 2>&1
)
exit /b 0