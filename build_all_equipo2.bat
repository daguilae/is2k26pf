:INICIO
@echo off
setlocal enabledelayedexpansion
color 0A

echo ============================================
echo COMPILACION COMPLETA GLOBAL - VISUAL 2019
echo ============================================

:: Ruta de MSBuild
set "MSBUILD_PATH=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe"

:: Ruta de COMPONENTES BASE (NO CAMBIA)
set "COMPONENTES_DIR=C:\is2k26pf\codigo\componentes"

:: Ruta de PROYECTOS DEL EQUIPO 2
set "BASE_DIR=C:\is2k26pf\codigo\empresarial\Equipo 2"

:: Carpeta del script
set "ROOT_DIR=%~dp0"

cd /d "%ROOT_DIR%"
if not exist "logs" mkdir logs

:: ==========================================================
:: CICLOS DE COMPILACION BASE
:: ==========================================================
for /L %%i in (1,1,4) do (
    echo.
    echo ============================================
    echo CICLO %%i DE COMPILACION BASE
    echo ============================================

    call :CompilarModulo REPORTEADOR || echo Error en REPORTEADOR ciclo %%i
    call :CompilarModulo CONSULTAS   || echo Error en CONSULTAS ciclo %%i
    call :CompilarModulo SEGURIDAD   || echo Error en SEGURIDAD ciclo %%i
    call :CompilarModulo NAVEGADOR   || echo Error en NAVEGADOR ciclo %%i
)

echo.
echo ============================================
echo CICLOS BASE FINALIZADOS
echo ============================================


:: ==========================================================
:: COPIAR DLLs BASE (Debug -> Release)
:: ==========================================================
echo.
echo ============================================
echo COPIANDO DLLs BASE DE DEBUG A RELEASE
echo ============================================

for /r "%COMPONENTES_DIR%" %%d in (*.dll) do (
    if exist "%%d" (
        if not exist "%%~dpd..\Release" mkdir "%%~dpd..\Release"
        copy /Y "%%d" "%%~dpd..\Release\" >nul
    )
)

echo DLLs base copiadas correctamente.


:: ==========================================================
:: COMPILAR TODOS LOS PROYECTOS .SLN EN EQUIPO 2
:: ==========================================================
echo.
echo ============================================
echo BUSCANDO Y COMPILANDO PROYECTOS .SLN EN EQUIPO 2 (DEBUG)
echo ============================================

set /a total=0
set /a ok=0
set /a fail=0

for /r "%BASE_DIR%" %%f in (*.sln) do (
    set /a total+=1
    echo -------------------------------------------
    echo Compilando: %%f
    echo -------------------------------------------
    "%MSBUILD_PATH%" "%%f" /p:Configuration=Debug /m /verbosity:minimal >> "logs\build_all_log.txt" 2>&1

    if !errorlevel! == 0 (
        echo Compilado correctamente: %%f
        echo [OK] %%f >> "logs\build_all_log.txt"
        set /a ok+=1
    ) else (
        echo Error al compilar: %%f
        echo [ERROR] %%f >> "logs\build_all_log.txt"
        set /a fail+=1
    )
)

echo.
echo ============================================
echo COMPILACION GLOBAL FINALIZADA
echo Total proyectos: %total%
echo Correctos: %ok%
echo Errores: %fail%
echo Logs en: logs\build_all_log.txt
echo ============================================


:: ==========================================================
:: VERIFICAR DLLs DE COMPONENTES BASE
:: ==========================================================
echo.
echo ============================================
echo VERIFICANDO DLLs DE COMPONENTES BASE
echo ============================================

set "dlls="
set "dlls=%dlls% %COMPONENTES_DIR%\navegador\NavegadorMVC\CapaModeloNavegador\bin\Debug\Capa_Modelo_Navegador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\navegador\NavegadorMVC\CapaControladorNavegador\bin\Debug\Capa_Controlador_Navegador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\navegador\NavegadorMVC\CapaVistaNavegador\bin\Debug\Capa_Vista_Navegador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\reporteador\reporteador\Capa_Modelo_Reporteador\bin\Debug\Capa_Modelo_Reporteador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\reporteador\reporteador\Capa_Controlador_Reporteador\bin\Debug\Capa_Controlador_Reporteador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\reporteador\reporteador\Capa_Vista_Reporteador\bin\Debug\Capa_Vista_Reporteador.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\seguridad\SeguridadMVC\SeguridadMVC\CapaModelo\bin\Debug\Capa_Modelo_Seguridad.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\seguridad\SeguridadMVC\SeguridadMVC\CapaControlador\bin\Debug\Capa_Controlador_Seguridad.dll"
set "dlls=%dlls% %COMPONENTES_DIR%\seguridad\SeguridadMVC\SeguridadMVC\CapaVista\bin\Debug\Capa_Vista_Seguridad.dll"

for %%d in (%dlls%) do (
    if exist "%%d" (
        echo [OK] %%d
    ) else (
        echo [FALTA] %%d
    )
)

echo.
echo ============================================
echo VERIFICANDO DLLs DE CONSULTAS
echo ============================================

if exist "%COMPONENTES_DIR%\consultas\ComponenteConsultasSimples\Capa_Modelo_Componente_Consultas\bin\Debug\*.dll" (
    echo [OK] ComponenteConsultasSimples - Capa Modelo
) else (
    echo [FALTA] ComponenteConsultasSimples - Capa Modelo
)

if exist "%COMPONENTES_DIR%\consultas\ComponenteConsultasSimples\Capa_Controlador_Componente_Consultas\bin\Debug\*.dll" (
    echo [OK] ComponenteConsultasSimples - Capa Controlador
) else (
    echo [FALTA] ComponenteConsultasSimples - Capa Controlador
)

if exist "%COMPONENTES_DIR%\consultas\ComponenteConsultasSimples\Capa_Vista_Componente_Consultas_*\bin\Debug\*.dll" (
    echo [OK] ComponenteConsultasSimples - Capa Vista
) else (
    echo [FALTA] ComponenteConsultasSimples - Capa Vista
)

if exist "%COMPONENTES_DIR%\consultas\Componente_Consultas\Capa_Modelo_Componente_Consultas\bin\Debug\*.dll" (
    echo [OK] Componente_Consultas - Capa Modelo
) else (
    echo [FALTA] Componente_Consultas - Capa Modelo
)

if exist "%COMPONENTES_DIR%\consultas\Componente_Consultas\Capa_Controlador_Componente_Consultas\bin\Debug\*.dll" (
    echo [OK] Componente_Consultas - Capa Controlador
) else (
    echo [FALTA] Componente_Consultas - Capa Controlador
)

if exist "%COMPONENTES_DIR%\consultas\Componente_Consultas\Capa_Vista_Componente_Consultas\bin\Debug\*.dll" (
    echo [OK] Componente_Consultas - Capa Vista
) else (
    echo [FALTA] Componente_Consultas - Capa Vista
)

echo.
echo ============================================
echo COMPILACION FINALIZADA COMPLETAMENTE
echo ============================================
echo.
echo ============================================
echo Presiona una opcion:
echo [R] Recompilar
echo [S] Salir
echo ============================================

choice /c RS /n /m "Seleccion: "

if errorlevel 2 goto FIN
if errorlevel 1 goto INICIO

:FIN
exit /b 0
exit /b 0


:: ==========================================================
:: FUNCION: COMPILAR MODULOS BASE
:: ==========================================================
:CompilarModulo
echo ============================================
echo COMPILANDO MODULO: %1
echo ============================================

if /I "%1"=="REPORTEADOR" (
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\reporteador\reporteador\Capa_Modelo_Reporteador\Capa_Modelo_Reporteador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\reporteador\reporteador\Capa_Controlador_Reporteador\Capa_Controlador_Reporteador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\reporteador\reporteador\Capa_Vista_Reporteador\Capa_Vista_Reporteador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
)

if /I "%1"=="CONSULTAS" (
    echo ============================================
    echo COMPILANDO COMPONENTE: ComponenteConsultasSimples
    echo ============================================

    for %%p in ("%COMPONENTES_DIR%\consultas\ComponenteConsultasSimples\Capa_Modelo_Componente_Consultas\*.csproj") do (
        "%MSBUILD_PATH%" "%%~fp" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    )

    for %%p in ("%COMPONENTES_DIR%\consultas\ComponenteConsultasSimples\Capa_Controlador_Componente_Consultas\*.csproj") do (
        "%MSBUILD_PATH%" "%%~fp" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    )

    for /d %%d in ("%COMPONENTES_DIR%\consultas\ComponenteConsultasSimples\Capa_Vista_Componente_Consultas_*") do (
        for %%p in ("%%~fd\*.csproj") do (
            "%MSBUILD_PATH%" "%%~fp" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
        )
    )

    echo ============================================
    echo COMPILANDO COMPONENTE: Componente_Consultas
    echo ============================================

    for %%p in ("%COMPONENTES_DIR%\consultas\Componente_Consultas\Capa_Modelo_Componente_Consultas\*.csproj") do (
        "%MSBUILD_PATH%" "%%~fp" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    )

    for %%p in ("%COMPONENTES_DIR%\consultas\Componente_Consultas\Capa_Controlador_Componente_Consultas\*.csproj") do (
        "%MSBUILD_PATH%" "%%~fp" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    )

    for %%p in ("%COMPONENTES_DIR%\consultas\Componente_Consultas\Capa_Vista_Componente_Consultas\*.csproj") do (
        "%MSBUILD_PATH%" "%%~fp" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    )
)

if /I "%1"=="SEGURIDAD" (
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\seguridad\SeguridadMVC\SeguridadMVC\CapaModelo\Capa_Modelo_Seguridad.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\seguridad\SeguridadMVC\SeguridadMVC\CapaControlador\Capa_Controlador_Seguridad.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\seguridad\SeguridadMVC\SeguridadMVC\CapaVista\Capa_Vista_Seguridad.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
)

if /I "%1"=="NAVEGADOR" (
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\navegador\NavegadorMVC\CapaModeloNavegador\Capa_Modelo_Navegador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\navegador\NavegadorMVC\CapaControladorNavegador\Capa_Controlador_Navegador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "%COMPONENTES_DIR%\navegador\NavegadorMVC\CapaVistaNavegador\Capa_Vista_Navegador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
)

exit /b 0


