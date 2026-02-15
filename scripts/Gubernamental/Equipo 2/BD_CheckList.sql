CREATE DATABASE BD_Migracion;
USE BD_Migracion;

-- ============================================
-- Tabla: tbl_solicitante
-- ============================================

CREATE TABLE tbl_solicitante (
    pk_solicitante_id INT AUTO_INCREMENT PRIMARY KEY,
    Cmp_DPI VARCHAR(13) NOT NULL UNIQUE,
    Cmp_Nombre VARCHAR(50) NOT NULL,
    Cmp_Apellido VARCHAR(50) NOT NULL,
    Cmp_Sexo ENUM('M','F') NOT NULL,
    Cmp_Departamento VARCHAR(50),
    Cmp_Estado_Civil ENUM('Soltero','Casado','Divorciado','Viudo'),
    Cmp_Fecha_Nacimiento DATE
);

-- ============================================
-- Tabla: tbl_checklist_entrevista
-- ============================================

CREATE TABLE tbl_checklist_entrevista (
    pk_checklist_id INT AUTO_INCREMENT PRIMARY KEY,
    
    fk_solicitante_id INT NOT NULL,
    
    Cmp_Fecha_Entrevista DATE,
    Cmp_Cantidad_Preguntas INT,
    
    Cmp_Estado_Entrevista ENUM('Pendiente','Completado'),
    
    CONSTRAINT fk_checklist_solicitante
    FOREIGN KEY (fk_solicitante_id)
    REFERENCES tbl_solicitante(pk_solicitante_id)
);

-- ============================================
-- Tabla: tbl_preguntas_alertas
-- ============================================

CREATE TABLE tbl_preguntas_alertas (

    pk_pregunta_id INT AUTO_INCREMENT PRIMARY KEY,
    
    Cmp_Enunciado_Pregunta VARCHAR(255),
    
    Cmp_Nivel INT

);

-- ============================================
-- Tabla: tbl_checklist_detalle_entrevista
-- ============================================

CREATE TABLE tbl_checklist_detalle_entrevista (

    pk_detalle_id INT AUTO_INCREMENT PRIMARY KEY,
    
    fk_pregunta_id INT,
    fk_checklist_id INT,
    
    Cmp_Respuesta_Pregunta BOOLEAN,
    
    CONSTRAINT fk_detalle_pregunta
    FOREIGN KEY (fk_pregunta_id)
    REFERENCES tbl_preguntas_alertas(pk_pregunta_id),
    
    CONSTRAINT fk_detalle_checklist
    FOREIGN KEY (fk_checklist_id)
    REFERENCES tbl_checklist_entrevista(pk_checklist_id)

);

-- ============================================
-- Tabla: tbl_alertas_encabezado
-- ============================================

CREATE TABLE tbl_alertas_encabezado (

    pk_alerta_id INT AUTO_INCREMENT PRIMARY KEY,
    
    fk_solicitante_id INT,
    
    Cmp_Numero_Alertas INT,
    
    CONSTRAINT fk_alerta_solicitante
    FOREIGN KEY (fk_solicitante_id)
    REFERENCES tbl_solicitante(pk_solicitante_id)

);

-- ============================================
-- Tabla: tbl_detalle_alertas
-- ============================================

CREATE TABLE tbl_detalle_alertas (

    pk_detalle_alerta_id INT AUTO_INCREMENT PRIMARY KEY,
    
    fk_pregunta_id INT,
    fk_alerta_id INT,
    
    Cmp_Respuesta_Alerta BOOLEAN,
    
    CONSTRAINT fk_detallealerta_pregunta
    FOREIGN KEY (fk_pregunta_id)
    REFERENCES tbl_preguntas_alertas(pk_pregunta_id),
    
    CONSTRAINT fk_detallealerta_alerta
    FOREIGN KEY (fk_alerta_id)
    REFERENCES tbl_alertas_encabezado(pk_alerta_id)

);
