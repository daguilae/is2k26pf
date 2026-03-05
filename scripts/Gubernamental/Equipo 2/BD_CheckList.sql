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

    pk_checklist_id INT AUTO_INCREMENT,
    
    fk_solicitante_id INT NOT NULL,
    
    Cmp_Fecha_Entrevista DATE NOT NULL,
    
    Cmp_Cantidad_Preguntas INT NOT NULL DEFAULT 0,
    
    Cmp_Estado_Entrevista TINYINT(1) NOT NULL DEFAULT 0,
    
    CONSTRAINT pk_tbl_checklist_entrevista
        PRIMARY KEY (pk_checklist_id),

    CONSTRAINT fk_tbl_checklist_solicitante
        FOREIGN KEY (fk_solicitante_id)
        REFERENCES tbl_solicitante(pk_solicitante_id)
        ON UPDATE CASCADE
        ON DELETE RESTRICT

);

-- ============================================
-- Tabla: tbl_preguntas_alertas
-- ============================================

CREATE TABLE tbl_preguntas (

    pk_pregunta_id INT AUTO_INCREMENT PRIMARY KEY,
    
    Cmp_Enunciado_Pregunta VARCHAR(255),
    
    Cmp_Nivel INT

);

-- ============================================
-- Tabla: tbl_checklist_detalle_entrevista
-- ============================================

CREATE TABLE tbl_checklist_detalle_entrevista (

    fk_pregunta_id INT NOT NULL,
    fk_checklist_id INT NOT NULL,
    
    Cmp_Respuesta_Pregunta BOOLEAN NOT NULL DEFAULT 0,
    
    CONSTRAINT pk_tbl_checklist_detalle_entrevista
    PRIMARY KEY (fk_pregunta_id, fk_checklist_id),

    CONSTRAINT fk_tbl_detalle_pregunta
    FOREIGN KEY (fk_pregunta_id)
    REFERENCES tbl_preguntas(pk_pregunta_id)
    ON UPDATE CASCADE
    ON DELETE CASCADE,

    CONSTRAINT fk_tbl_detalle_checklist
    FOREIGN KEY (fk_checklist_id)
    REFERENCES tbl_checklist_entrevista(pk_checklist_id)
    ON UPDATE CASCADE
    ON DELETE CASCADE

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

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Presenta su DPI original en buen estado?', 1);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Presenta fotocopia legible de ambos lados del DPI?', 1);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Realizó el pago correspondiente al trámite de pasaporte?', 1);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Presenta el comprobante de pago original?', 1);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Cuenta con cita programada para el trámite?', 1);


INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Los datos personales coinciden con el DPI presentado?', 2);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿El solicitante es mayor de edad?', 2);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Presenta pasaporte anterior en caso de renovación?', 2);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿La documentación está completa según los requisitos establecidos?', 2);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿La fotografía cumple con los requisitos oficiales?', 2);


INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Se verificó la autenticidad del DPI?', 3);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Se validó el pago en el sistema?', 3);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Se registraron correctamente los datos biométricos?', 3);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿El trámite fue aprobado por el responsable?', 3);

INSERT INTO tbl_preguntas (Cmp_Enunciado_Pregunta, Cmp_Nivel) VALUES ('¿Se entregó el comprobante de finalización del trámite?', 3);
