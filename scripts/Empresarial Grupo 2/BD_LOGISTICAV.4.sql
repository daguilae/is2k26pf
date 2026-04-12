-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_logistica
-- ------------------------------------------------------
-- Server version	8.0.40

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_aplicacion`
--

DROP TABLE IF EXISTS `tbl_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_aplicacion` (
  `Pk_Id_Aplicacion` int NOT NULL,
  `Fk_Id_Reporte_Aplicacion` int DEFAULT NULL,
  `Cmp_Nombre_Aplicacion` varchar(50) DEFAULT NULL,
  `Cmp_Descripcion_Aplicacion` varchar(50) DEFAULT NULL,
  `Cmp_Estado_Aplicacion` bit(1) NOT NULL,
  PRIMARY KEY (`Pk_Id_Aplicacion`),
  KEY `Fk_Aplicacion_Reporte` (`Fk_Id_Reporte_Aplicacion`),
  CONSTRAINT `Fk_Aplicacion_Reporte` FOREIGN KEY (`Fk_Id_Reporte_Aplicacion`) REFERENCES `tbl_reportes` (`Pk_Id_Reporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_aplicacion`
--

LOCK TABLES `tbl_aplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_aplicacion` DISABLE KEYS */;
INSERT INTO `tbl_aplicacion` VALUES (1,NULL,'Registros','Registro de acciones en el sistema',_binary ''),(301,NULL,'Empleados','Control de empleados de la hoteleria',_binary ''),(302,NULL,'Usuarios','Control de usuarios de empleados',_binary ''),(303,NULL,'Perfiles','Perfiles que se asignan a usuarios',_binary ''),(304,NULL,'Modulos','Mantenimiento de modulos',_binary ''),(305,NULL,'Aplicacion','Mantenimiento de aplicaciones',_binary ''),(306,NULL,'Asig Aplicacion Usuario','Asigna permisos a usuarios',_binary ''),(307,NULL,'Asig aplicacion Perfil','Asigna permisos a perfiles',_binary ''),(308,NULL,'Asig Perfiles','Asigna los perfiles a usuarios',_binary ''),(309,NULL,'Bitacora','Da acceso a bitacora',_binary ''),(700,NULL,'Marca','Marca de Productos',_binary ''),(701,4,'Vendedores','Vendedores',_binary ''),(702,3,'Clientes','Clientes',_binary ''),(703,5,'Proveedores','Proveedor',_binary ''),(704,6,'Linea de Productos','Lineas',_binary ''),(705,7,'Bodega','Bodegas',_binary ''),(706,9,'Transportes','Transportes',_binary ''),(707,10,'Tipo de Movimiento Inventario','Mov Inv Tipo',_binary ''),(708,8,'Tipo Operación Cuentas Por pagar','Cuentas por pagar',_binary ''),(709,2,'Tipo_Operacion_Cuentas_Por_Cobrar','Cuentas por cobrar',_binary '');
/*!40000 ALTER TABLE `tbl_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacion_modulo_aplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacion_modulo_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacion_modulo_aplicacion` (
  `Fk_Id_Modulo` int NOT NULL,
  `Fk_Id_Aplicacion` int NOT NULL,
  PRIMARY KEY (`Fk_Id_Modulo`,`Fk_Id_Aplicacion`),
  KEY `Fk_AsigAplicacion` (`Fk_Id_Aplicacion`),
  CONSTRAINT `Fk_AsigAplicacion` FOREIGN KEY (`Fk_Id_Aplicacion`) REFERENCES `tbl_aplicacion` (`Pk_Id_Aplicacion`),
  CONSTRAINT `Fk_AsigModulo` FOREIGN KEY (`Fk_Id_Modulo`) REFERENCES `tbl_modulo` (`Pk_Id_Modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacion_modulo_aplicacion`
--

LOCK TABLES `tbl_asignacion_modulo_aplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacion_modulo_aplicacion` DISABLE KEYS */;
INSERT INTO `tbl_asignacion_modulo_aplicacion` VALUES (4,301),(4,302),(4,303),(4,304),(4,305),(4,306),(4,307),(4,308),(4,309),(44,700),(44,701),(44,702),(44,703),(44,704),(44,705),(44,706),(44,707),(44,708),(44,709);
/*!40000 ALTER TABLE `tbl_asignacion_modulo_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignar_perfil_cliente`
--

DROP TABLE IF EXISTS `tbl_asignar_perfil_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignar_perfil_cliente` (
  `Fk_Id_Perfil` int NOT NULL,
  `Fk_Id_Cliente` int NOT NULL,
  PRIMARY KEY (`Fk_Id_Perfil`,`Fk_Id_Cliente`),
  KEY `Fk_AsigCliente` (`Fk_Id_Cliente`),
  CONSTRAINT `Fk_AsigCliente` FOREIGN KEY (`Fk_Id_Cliente`) REFERENCES `tbl_cliente` (`Pk_Id_Cliente`),
  CONSTRAINT `Fk_AsigPerfil` FOREIGN KEY (`Fk_Id_Perfil`) REFERENCES `tbl_perfil` (`Pk_Id_Perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignar_perfil_cliente`
--

LOCK TABLES `tbl_asignar_perfil_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_asignar_perfil_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_asignar_perfil_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacora` (
  `Pk_Id_Bitacora` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Usuario` int DEFAULT NULL,
  `Fk_Id_Aplicacion` int DEFAULT NULL,
  `Cmp_Fecha` datetime DEFAULT NULL,
  `Cmp_Accion` varchar(255) DEFAULT NULL,
  `Cmp_Ip` varchar(50) DEFAULT NULL,
  `Cmp_Nombre_Pc` varchar(50) DEFAULT NULL,
  `Cmp_Login_Estado` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Bitacora`),
  KEY `Fk_Bitacora_Usuario` (`Fk_Id_Usuario`),
  KEY `Fk_Bitacora_Aplicacion` (`Fk_Id_Aplicacion`),
  CONSTRAINT `Fk_Bitacora_Aplicacion` FOREIGN KEY (`Fk_Id_Aplicacion`) REFERENCES `tbl_aplicacion` (`Pk_Id_Aplicacion`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `Fk_Bitacora_Usuario` FOREIGN KEY (`Fk_Id_Usuario`) REFERENCES `tbl_usuario` (`Pk_Id_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacora`
--

LOCK TABLES `tbl_bitacora` WRITE;
/*!40000 ALTER TABLE `tbl_bitacora` DISABLE KEYS */;
INSERT INTO `tbl_bitacora` VALUES (1,4,NULL,'2026-03-26 16:26:15','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(2,4,304,'2026-03-26 16:26:46','Insertó un nuevo registro en la tabla \'tbl_modulo\' con llave: 44','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(3,4,306,'2026-03-26 16:28:15','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Perfiles\'\': Consultar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(4,4,306,'2026-03-26 16:28:15','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Modulos\'\': Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(5,4,304,'2026-03-26 16:28:47','Actualizo un registro en la tabla \'tbl_modulo\' Con la llave \'44\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(6,4,304,'2026-03-26 16:28:56','Actualizo un registro en la tabla \'tbl_modulo\' Con la llave \'44\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(7,4,304,'2026-03-26 16:29:06','Insertó un nuevo registro en la tabla \'tbl_modulo\' con llave: 11','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(8,4,304,'2026-03-26 16:29:23','Eliminó un registro en la tabla \'tbl_modulo\' Con la llave \'11\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(9,4,1,'2026-03-26 16:30:44','Guardó aplicación: Tipo_Operacion_Cuentas_Por_Cobrar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(10,4,1,'2026-03-26 16:32:11','Modificó aplicación: Tipo_Operacion_Cuentas_Por_Cobrar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(11,4,306,'2026-03-26 16:32:56','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipo_Operacion_Cuentas_Por_Cobrar\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(12,4,NULL,'2026-03-26 16:33:13','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(13,4,NULL,'2026-03-26 16:48:47','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(14,4,NULL,'2026-03-26 16:56:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(15,4,NULL,'2026-03-28 19:37:33','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(16,4,1,'2026-03-28 19:38:11','Modificó aplicación: Tipo_Operacion_Cuentas_Por_Cobrar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(17,4,NULL,'2026-03-28 19:38:43','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(18,4,NULL,'2026-03-28 19:39:02','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(19,4,NULL,'2026-03-28 22:24:52','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(20,4,NULL,'2026-03-28 22:25:32','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(21,4,NULL,'2026-03-28 22:30:11','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(22,4,NULL,'2026-03-28 22:54:34','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(23,4,NULL,'2026-03-29 09:32:16','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(24,4,NULL,'2026-03-29 12:06:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(25,4,NULL,'2026-03-29 12:15:54','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(26,4,1,'2026-03-29 12:22:15','Guardó aplicación: Marca','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(27,4,1,'2026-03-29 12:22:47','Guardó aplicación: Vendedores','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(28,4,1,'2026-03-29 12:23:07','Guardó aplicación: Clientes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(29,4,1,'2026-03-29 12:23:30','Guardó aplicación: Proveedores','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(30,4,1,'2026-03-29 12:24:02','Guardó aplicación: Linea de Productos','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(31,4,1,'2026-03-29 12:24:34','Guardó aplicación: Bodega','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(32,4,1,'2026-03-29 12:24:56','Guardó aplicación: Transportes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(33,4,1,'2026-03-29 12:25:32','Guardó aplicación: Tipo de Movimiento Inventario','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(34,4,1,'2026-03-29 12:26:08','Guardó aplicación: Tipo Operación Cuentas Por pagar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(35,4,306,'2026-03-29 12:29:19','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Marca\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(36,4,306,'2026-03-29 12:29:19','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Vendedores\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(37,4,306,'2026-03-29 12:29:19','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Clientes\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(38,4,306,'2026-03-29 12:29:20','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Proveedores\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(39,4,306,'2026-03-29 12:29:20','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Linea de Productos\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(40,4,306,'2026-03-29 12:29:21','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Bodega\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(41,4,306,'2026-03-29 12:29:21','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Transportes\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(42,4,306,'2026-03-29 12:29:21','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipo de Movimiento Inventario\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(43,4,306,'2026-03-29 12:29:22','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipo Operación Cuentas Por pagar\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(44,4,NULL,'2026-03-29 12:30:00','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(45,4,NULL,'2026-03-29 13:42:22','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(46,4,1,'2026-03-29 13:44:15','Modificó aplicación: Bodega','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(47,4,NULL,'2026-03-29 14:42:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(48,4,NULL,'2026-03-29 15:42:55','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(49,4,1,'2026-03-29 15:44:19','Modificó aplicación: Tipo Operación Cuentas Por pagar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(50,4,NULL,'2026-03-29 15:44:25','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(51,4,NULL,'2026-03-29 15:44:44','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(52,4,NULL,'2026-03-29 15:47:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(53,4,NULL,'2026-03-29 16:07:15','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(54,4,NULL,'2026-03-29 16:15:23','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(55,4,NULL,'2026-03-29 16:16:18','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(56,4,NULL,'2026-03-29 16:26:27','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(57,4,NULL,'2026-03-29 16:33:17','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(58,4,NULL,'2026-03-29 16:37:06','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(59,4,1,'2026-03-29 16:38:47','Modificó aplicación: Transportes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(60,4,NULL,'2026-03-29 16:39:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(61,4,NULL,'2026-03-29 16:41:40','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(62,4,NULL,'2026-03-29 16:43:24','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(63,4,NULL,'2026-03-29 17:14:42','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(64,4,NULL,'2026-03-29 17:19:56','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(65,4,NULL,'2026-03-29 19:57:12','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(66,4,NULL,'2026-03-29 19:58:31','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(67,4,NULL,'2026-03-29 20:39:09','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(68,4,709,'2026-03-29 20:41:52','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(69,4,709,'2026-03-29 20:42:23','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 2','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(70,4,709,'2026-03-29 20:45:10','Actualizo un registro en la tabla \'tbl_tipo_operacion_cxc\' Con la llave \'1\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(71,4,709,'2026-03-29 20:45:19','Actualizo un registro en la tabla \'tbl_tipo_operacion_cxc\' Con la llave \'2\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(72,4,709,'2026-03-29 20:45:40','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 3','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(73,4,NULL,'2026-04-07 07:56:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(74,4,NULL,'2026-04-07 08:04:16','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(75,4,NULL,'2026-04-07 08:24:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(76,4,NULL,'2026-04-07 08:25:00','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(77,4,NULL,'2026-04-07 08:25:11','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(78,4,NULL,'2026-04-07 09:21:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(79,4,NULL,'2026-04-07 09:56:58','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(80,4,709,'2026-04-07 09:59:03','Actualizo un registro en la tabla \'tbl_tipo_operacion_cxc\' Con la llave \'3\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(81,4,NULL,'2026-04-07 10:01:13','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(82,4,NULL,'2026-04-07 10:01:47','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(83,4,NULL,'2026-04-07 10:03:10','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(84,4,NULL,'2026-04-07 17:20:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(85,4,NULL,'2026-04-07 17:24:16','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(86,4,NULL,'2026-04-07 17:30:54','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(87,4,NULL,'2026-04-07 21:49:12','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(88,4,NULL,'2026-04-08 18:07:31','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(89,4,1,'2026-04-08 18:08:50','Modificó aplicación: Tipo de Movimiento Inventario','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(90,4,NULL,'2026-04-08 18:09:04','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(91,4,NULL,'2026-04-09 08:17:06','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(92,4,NULL,'2026-04-09 08:41:36','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(93,4,709,'2026-04-09 08:59:07','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 4','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(94,4,306,'2026-04-09 09:05:58','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Bitacora\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(95,4,NULL,'2026-04-09 09:06:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(96,4,NULL,'2026-04-09 09:07:30','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(97,4,705,'2026-04-09 09:09:02','Insertó un nuevo registro en la tabla \'tbl_bodega\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(98,4,702,'2026-04-09 09:15:18','Insertó un nuevo registro en la tabla \'Tbl_Clientes\' con llave: 201','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(99,4,NULL,'2026-04-09 09:16:44','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(100,4,701,'2026-04-09 09:19:14','Insertó un nuevo registro en la tabla \'Tbl_Vendedor\' con llave: 502','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(101,4,700,'2026-04-09 09:21:41','Insertó un nuevo registro en la tabla \'Tbl_Marca\' con llave: 2','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(102,4,707,'2026-04-09 09:28:43','Insertó un nuevo registro en la tabla \'tbl_tipo_movimiento_inventario\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(103,4,707,'2026-04-09 09:29:14','Actualizo un registro en la tabla \'tbl_tipo_movimiento_inventario\' Con la llave \'1\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(104,4,NULL,'2026-04-09 09:53:35','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(105,4,NULL,'2026-04-10 15:42:47','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(106,4,NULL,'2026-04-10 15:44:18','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(107,4,NULL,'2026-04-10 15:46:24','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(108,4,NULL,'2026-04-10 15:51:01','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(109,4,NULL,'2026-04-10 15:58:32','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(110,4,NULL,'2026-04-10 16:03:19','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(111,4,NULL,'2026-04-10 16:05:17','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(112,4,NULL,'2026-04-10 16:35:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary '');
/*!40000 ALTER TABLE `tbl_bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bloqueo_usuario`
--

DROP TABLE IF EXISTS `tbl_bloqueo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bloqueo_usuario` (
  `Pk_Id_Bloqueo` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Usuario` int DEFAULT NULL,
  `Fk_Id_Bitacora` int DEFAULT NULL,
  `Cmp_Fecha_Inicio_Bloqueo_Usuario` datetime DEFAULT NULL,
  `Cmp_Fecha_Fin_Bloqueo_Usuario` datetime DEFAULT NULL,
  `Cmp_Motivo__Bloqueo_Usuario` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Bloqueo`),
  KEY `Fk_Bloqueo_Usuario` (`Fk_Id_Usuario`),
  KEY `Fk_Bloqueo_Bitacora` (`Fk_Id_Bitacora`),
  CONSTRAINT `Fk_Bloqueo_Bitacora` FOREIGN KEY (`Fk_Id_Bitacora`) REFERENCES `tbl_bitacora` (`Pk_Id_Bitacora`),
  CONSTRAINT `Fk_Bloqueo_Usuario` FOREIGN KEY (`Fk_Id_Usuario`) REFERENCES `tbl_usuario` (`Pk_Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bloqueo_usuario`
--

LOCK TABLES `tbl_bloqueo_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_bloqueo_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bloqueo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bodega`
--

DROP TABLE IF EXISTS `tbl_bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bodega` (
  `Pk_Id_Bodega` int NOT NULL AUTO_INCREMENT,
  `Cmp_Nombre_Bodega` varchar(100) NOT NULL,
  `Cmp_Descripcion_Bodega` varchar(150) NOT NULL,
  `Cmp_Estado_Bodega` enum('Activo','Inactivo') NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Bodega`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bodega`
--

LOCK TABLES `tbl_bodega` WRITE;
/*!40000 ALTER TABLE `tbl_bodega` DISABLE KEYS */;
INSERT INTO `tbl_bodega` VALUES (1,'Zona 18','suministros','Activo'),(2,'Bodega Central','Almacén principal de productos','Activo'),(3,'Bodega Norte','Sucursal zona norte','Activo'),(4,'Bodega Sur','Sucursal zona sur','Activo'),(5,'Bodega Este','Sucursal zona este','Activo'),(6,'Bodega Oeste','Sucursal zona oeste','Activo');
/*!40000 ALTER TABLE `tbl_bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cliente` (
  `Pk_Id_Cliente` int NOT NULL,
  `Cmp_Nombres_Cliente` varchar(50) DEFAULT NULL,
  `Cmp_Apellidos_Cliente` varchar(50) DEFAULT NULL,
  `Cmp_Dni_Cliente` bigint DEFAULT NULL,
  `Cmp_Fecha_Registro_Cliente` datetime DEFAULT NULL,
  `Cmp_Estado_Cliente` bit(1) DEFAULT NULL,
  `Cmp_Nacionalidad_Cliente` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (1,'Cliente','Prueba',9876543210101,'2025-09-21 23:00:51',_binary '','Guatemalteco');
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes`
--

DROP TABLE IF EXISTS `tbl_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_clientes` (
  `Pk_Id_Cliente` int NOT NULL AUTO_INCREMENT,
  `Cmp_CuioNit` varchar(20) NOT NULL,
  `Cmp_Nombre` varchar(50) NOT NULL,
  `Cmp_Apellido` varchar(50) NOT NULL,
  `Cmp_Telefono` varchar(20) NOT NULL,
  `Cmp_Correo` varchar(100) NOT NULL,
  `Cmp_Saldo_Total` float DEFAULT NULL,
  `Cmp_Direccion` varchar(150) NOT NULL,
  `Cmp_Estado` enum('Activo','Inactivo') DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Cliente`),
  UNIQUE KEY `Cmp_CuioNit` (`Cmp_CuioNit`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_clientes`
--

LOCK TABLES `tbl_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_clientes` DISABLE KEYS */;
INSERT INTO `tbl_clientes` VALUES (1,'20196709','Ernesto','Samayoa','41017988','ernesto1@miumg.edu.gt',500,'zona 18','Activo');
/*!40000 ALTER TABLE `tbl_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_correo_cliente`
--

DROP TABLE IF EXISTS `tbl_correo_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_correo_cliente` (
  `Pk_Id_Correo` int NOT NULL,
  `Fk_Id_Cliente` int DEFAULT NULL,
  `Cmp_Correo_Cliente` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Correo`),
  KEY `Fk_Correo_Cliente` (`Fk_Id_Cliente`),
  CONSTRAINT `Fk_Correo_Cliente` FOREIGN KEY (`Fk_Id_Cliente`) REFERENCES `tbl_cliente` (`Pk_Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_correo_cliente`
--

LOCK TABLES `tbl_correo_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_correo_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_correo_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentas_por_pagar`
--

DROP TABLE IF EXISTS `tbl_cuentas_por_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas_por_pagar` (
  `pk_id_cuenta_por_pagar` int NOT NULL AUTO_INCREMENT,
  `fk_id_factura` int NOT NULL,
  `cmp_fecha_deuda` datetime NOT NULL,
  `cmp_fecha_vencimiento` datetime DEFAULT NULL,
  `cmp_monto_total` float NOT NULL,
  `cmp_estado` enum('pendiente','pagado','parcial') DEFAULT 'pendiente',
  PRIMARY KEY (`pk_id_cuenta_por_pagar`),
  KEY `fk_id_factura` (`fk_id_factura`),
  CONSTRAINT `tbl_cuentas_por_pagar_ibfk_1` FOREIGN KEY (`fk_id_factura`) REFERENCES `tbl_factura` (`pk_id_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas_por_pagar`
--

LOCK TABLES `tbl_cuentas_por_pagar` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentas_por_pagar_detalle`
--

DROP TABLE IF EXISTS `tbl_cuentas_por_pagar_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas_por_pagar_detalle` (
  `pk_id_cuenta_por_pagar_detalle` int NOT NULL AUTO_INCREMENT,
  `fk_id_cuenta_por_pagar` int NOT NULL,
  `cmp_tipo_operacion` enum('abono','pago_total') NOT NULL,
  `cmp_no_documento` varchar(50) DEFAULT NULL,
  `cmp_fecha` date NOT NULL,
  `cmp_monto_pagado` float NOT NULL,
  `cmp_saldo_pendiente` float DEFAULT NULL,
  PRIMARY KEY (`pk_id_cuenta_por_pagar_detalle`),
  KEY `fk_id_cuenta_por_pagar` (`fk_id_cuenta_por_pagar`),
  CONSTRAINT `tbl_cuentas_por_pagar_detalle_ibfk_1` FOREIGN KEY (`fk_id_cuenta_por_pagar`) REFERENCES `tbl_cuentas_por_pagar` (`pk_id_cuenta_por_pagar`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas_por_pagar_detalle`
--

LOCK TABLES `tbl_cuentas_por_pagar_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_factura`
--

DROP TABLE IF EXISTS `tbl_detalle_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_factura` (
  `pk_id_detalle_factura` int NOT NULL AUTO_INCREMENT,
  `fk_id_factura` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `cmp_cantidad` int NOT NULL,
  `cpm_precio_unitario` float NOT NULL,
  `cmp_subtotal` float NOT NULL,
  PRIMARY KEY (`pk_id_detalle_factura`),
  KEY `fk_id_factura` (`fk_id_factura`),
  CONSTRAINT `tbl_detalle_factura_ibfk_1` FOREIGN KEY (`fk_id_factura`) REFERENCES `tbl_factura` (`pk_id_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_factura`
--

LOCK TABLES `tbl_detalle_factura` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalle_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_empleado`
--

DROP TABLE IF EXISTS `tbl_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_empleado` (
  `Pk_Id_Empleado` int NOT NULL AUTO_INCREMENT,
  `Cmp_Nombres_Empleado` varchar(50) DEFAULT NULL,
  `Cmp_Apellidos_Empleado` varchar(50) DEFAULT NULL,
  `Cmp_Dpi_Empleado` bigint DEFAULT NULL,
  `Cmp_Nit_Empleado` bigint DEFAULT NULL,
  `Cmp_Correo_Empleado` varchar(50) DEFAULT NULL,
  `Cmp_Telefono_Empleado` varchar(15) DEFAULT NULL,
  `Cmp_Genero_Empleado` bit(1) DEFAULT NULL,
  `Cmp_Fecha_Nacimiento_Empleado` date DEFAULT NULL,
  `Cmp_Fecha_Contratacion__Empleado` date DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=5001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_empleado`
--

LOCK TABLES `tbl_empleado` WRITE;
/*!40000 ALTER TABLE `tbl_empleado` DISABLE KEYS */;
INSERT INTO `tbl_empleado` VALUES (2,'Juan','Pérez López',1234567890101,9876542,'juan.perez@example.com','5555-1234',_binary '','1995-08-20','2025-09-21'),(3,'Juan','pruebas',1234,123,'@pruebas','1234',_binary '','2025-09-26','2025-09-26');
/*!40000 ALTER TABLE `tbl_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_empresa_transporte`
--

DROP TABLE IF EXISTS `tbl_empresa_transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_empresa_transporte` (
  `pk_id_empresa` int NOT NULL AUTO_INCREMENT,
  `cmp_nombre_empresa` varchar(50) NOT NULL,
  `cmp_telefono_empresa` varchar(15) NOT NULL,
  `cmp_correo_empresa` varchar(50) NOT NULL,
  `cmp_estado_empresa` enum('ACTIVO','INACTIVO') DEFAULT 'ACTIVO',
  PRIMARY KEY (`pk_id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_empresa_transporte`
--

LOCK TABLES `tbl_empresa_transporte` WRITE;
/*!40000 ALTER TABLE `tbl_empresa_transporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_empresa_transporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_existencias`
--

DROP TABLE IF EXISTS `tbl_existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_existencias` (
  `fk_inventario_id` int NOT NULL,
  `fk_bodega_id` int NOT NULL,
  `stock` float NOT NULL,
  PRIMARY KEY (`fk_inventario_id`,`fk_bodega_id`),
  KEY `fk_bodegas_inventario` (`fk_bodega_id`),
  CONSTRAINT `fk_bodegas_inventario` FOREIGN KEY (`fk_bodega_id`) REFERENCES `tbl_bodega` (`Pk_Id_Bodega`),
  CONSTRAINT `fk_existencias_inventario` FOREIGN KEY (`fk_inventario_id`) REFERENCES `tbl_inventario` (`pk_inventario_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_existencias`
--

LOCK TABLES `tbl_existencias` WRITE;
/*!40000 ALTER TABLE `tbl_existencias` DISABLE KEYS */;
INSERT INTO `tbl_existencias` VALUES (1,1,150),(2,1,200),(3,2,500),(4,3,80),(5,4,120);
/*!40000 ALTER TABLE `tbl_existencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_factura`
--

DROP TABLE IF EXISTS `tbl_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_factura` (
  `pk_id_factura` int NOT NULL AUTO_INCREMENT,
  `cmp_numero_factura` varchar(50) NOT NULL,
  `cmp_fecha_factura` date NOT NULL,
  `fk_id_proveedor` int NOT NULL,
  `fk_id_orden_compra` int DEFAULT NULL,
  `cmp_total` float NOT NULL,
  PRIMARY KEY (`pk_id_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_factura`
--

LOCK TABLES `tbl_factura` WRITE;
/*!40000 ALTER TABLE `tbl_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_inventario`
--

DROP TABLE IF EXISTS `tbl_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_inventario` (
  `pk_inventario_id` int NOT NULL AUTO_INCREMENT,
  `fk_linea_id` int DEFAULT NULL,
  `fk_marca_id` int DEFAULT NULL,
  `nombre_prod` varchar(150) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `precio_unitario` float NOT NULL,
  `tipo_producto` enum('MP','PF') NOT NULL,
  `estado_producto` enum('ACTIVO','INACTIVO') NOT NULL,
  PRIMARY KEY (`pk_inventario_id`),
  KEY `fk_inventario_linea` (`fk_linea_id`),
  KEY `fk_inventario_marca` (`fk_marca_id`),
  CONSTRAINT `fk_inventario_linea` FOREIGN KEY (`fk_linea_id`) REFERENCES `tbl_linea_producto` (`pk_id_linea`),
  CONSTRAINT `fk_inventario_marca` FOREIGN KEY (`fk_marca_id`) REFERENCES `tbl_marca` (`ID_Marca`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_inventario`
--

LOCK TABLES `tbl_inventario` WRITE;
/*!40000 ALTER TABLE `tbl_inventario` DISABLE KEYS */;
INSERT INTO `tbl_inventario` VALUES (1,1,3,'Leche entera 1L','Leche entera pasteurizada Lala',18.5,'PF','ACTIVO'),(2,2,2,'Coca-Cola 600ml','Refresco carbonatado sabor cola',14,'PF','ACTIVO'),(3,3,1,'Arroz 5kg','Arroz blanco grano largo Nestlé',45,'MP','ACTIVO'),(4,4,4,'Ariel 1kg','Detergente en polvo con aroma',32,'PF','ACTIVO'),(5,5,5,'Pan blanco','Pan de caja blanco Bimbo 680g',28,'PF','ACTIVO');
/*!40000 ALTER TABLE `tbl_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_linea_producto`
--

DROP TABLE IF EXISTS `tbl_linea_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_linea_producto` (
  `pk_id_linea` int NOT NULL AUTO_INCREMENT,
  `cmp_nombre_linea` varchar(50) NOT NULL,
  `cmp_descripcion` varchar(80) NOT NULL,
  `cmp_estado_linea` enum('activo','inactivo','descontinuado') DEFAULT NULL,
  PRIMARY KEY (`pk_id_linea`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_linea_producto`
--

LOCK TABLES `tbl_linea_producto` WRITE;
/*!40000 ALTER TABLE `tbl_linea_producto` DISABLE KEYS */;
INSERT INTO `tbl_linea_producto` VALUES (1,'Lácteos','Productos derivados de la leche','activo'),(2,'Bebidas','Jugos, aguas y refrescos','activo'),(3,'Granos','Arroz, frijol y similares','activo'),(4,'Limpieza','Productos de higiene del hogar','activo'),(5,'Panadería','Pan y productos horneados','activo');
/*!40000 ALTER TABLE `tbl_linea_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_marca`
--

DROP TABLE IF EXISTS `tbl_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_marca` (
  `ID_Marca` int NOT NULL AUTO_INCREMENT,
  `Nombre_Marca` varchar(100) NOT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  `Estado_Marca` enum('Activo','Inactivo') NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`ID_Marca`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_marca`
--

LOCK TABLES `tbl_marca` WRITE;
/*!40000 ALTER TABLE `tbl_marca` DISABLE KEYS */;
INSERT INTO `tbl_marca` VALUES (1,'Adidas','Zapatos de futbol','Activo'),(2,'Nestlé','Multinacional de alimentos','Activo'),(3,'Coca-Cola','Bebidas carbonatadas','Activo'),(4,'Lala','Productos lácteos','Activo'),(5,'Ariel','Detergentes y limpieza','Activo'),(6,'Bimbo','Productos de panadería','Activo');
/*!40000 ALTER TABLE `tbl_marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_modulo`
--

DROP TABLE IF EXISTS `tbl_modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulo` (
  `Pk_Id_Modulo` int NOT NULL,
  `Cmp_Nombre_Modulo` varchar(50) DEFAULT NULL,
  `Cmp_Descripcion_Modulo` varchar(50) DEFAULT NULL,
  `Cmp_Estado_Modulo` bit(1) NOT NULL,
  PRIMARY KEY (`Pk_Id_Modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_modulo`
--

LOCK TABLES `tbl_modulo` WRITE;
/*!40000 ALTER TABLE `tbl_modulo` DISABLE KEYS */;
INSERT INTO `tbl_modulo` VALUES (4,'Seguridad','Modulo de seguridad de la hoteleria',_binary ''),(44,'Logistica','Modulo del sistema de logistica',_binary '');
/*!40000 ALTER TABLE `tbl_modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimiento_inventario_detalle`
--

DROP TABLE IF EXISTS `tbl_movimiento_inventario_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimiento_inventario_detalle` (
  `fk_movimiento_id` int NOT NULL,
  `fk_inventario_id` int NOT NULL,
  `cantidad_transaccionada` float NOT NULL,
  PRIMARY KEY (`fk_movimiento_id`,`fk_inventario_id`),
  KEY `fk_detalle_inventario` (`fk_inventario_id`),
  CONSTRAINT `fk_detalle_inventario` FOREIGN KEY (`fk_inventario_id`) REFERENCES `tbl_inventario` (`pk_inventario_id`),
  CONSTRAINT `fk_detalle_movimiento` FOREIGN KEY (`fk_movimiento_id`) REFERENCES `tbl_movimiento_inventario_encabezado` (`pk_movimiento_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimiento_inventario_detalle`
--

LOCK TABLES `tbl_movimiento_inventario_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_movimiento_inventario_detalle` DISABLE KEYS */;
INSERT INTO `tbl_movimiento_inventario_detalle` VALUES (1,1,50),(2,2,30),(3,3,100),(4,4,10),(5,5,5);
/*!40000 ALTER TABLE `tbl_movimiento_inventario_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimiento_inventario_encabezado`
--

DROP TABLE IF EXISTS `tbl_movimiento_inventario_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimiento_inventario_encabezado` (
  `pk_movimiento_id` int NOT NULL AUTO_INCREMENT,
  `fk_tipo_movimiento_id` int NOT NULL,
  `fecha_transaccion` datetime NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`pk_movimiento_id`),
  KEY `fk_movimiento_tipo` (`fk_tipo_movimiento_id`),
  CONSTRAINT `fk_movimiento_tipo` FOREIGN KEY (`fk_tipo_movimiento_id`) REFERENCES `tbl_tipo_movimiento_inventario` (`pk_tipo_movimiento_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimiento_inventario_encabezado`
--

LOCK TABLES `tbl_movimiento_inventario_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_movimiento_inventario_encabezado` DISABLE KEYS */;
INSERT INTO `tbl_movimiento_inventario_encabezado` VALUES (1,1,'2025-01-10 08:00:00','Compra inicial de inventario'),(2,2,'2025-01-11 10:30:00','Venta a cliente mayorista'),(3,1,'2025-01-12 09:15:00','Reabastecimiento bodega norte'),(4,3,'2025-01-13 14:00:00','Devolución de producto dañado'),(5,5,'2025-01-14 16:45:00','Ajuste por merma');
/*!40000 ALTER TABLE `tbl_movimiento_inventario_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nit_cliente`
--

DROP TABLE IF EXISTS `tbl_nit_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_nit_cliente` (
  `Pk_Id_Nit` int NOT NULL,
  `Fk_Id_Cliente` int DEFAULT NULL,
  `Cmp_Nit_Cliente` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Nit`),
  KEY `Fk_Nit_Cliente` (`Fk_Id_Cliente`),
  CONSTRAINT `Fk_Nit_Cliente` FOREIGN KEY (`Fk_Id_Cliente`) REFERENCES `tbl_cliente` (`Pk_Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_nit_cliente`
--

LOCK TABLES `tbl_nit_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_nit_cliente` DISABLE KEYS */;
INSERT INTO `tbl_nit_cliente` VALUES (1,1,'0901-22-2929');
/*!40000 ALTER TABLE `tbl_nit_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_numero_cliente`
--

DROP TABLE IF EXISTS `tbl_numero_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_numero_cliente` (
  `Pk_Id_Numero` int NOT NULL,
  `Fk_Id_Cliente` int DEFAULT NULL,
  `Cmp_Telefono_Cliente` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Numero`),
  KEY `Fk_Numero_Cliente` (`Fk_Id_Cliente`),
  CONSTRAINT `Fk_Numero_Cliente` FOREIGN KEY (`Fk_Id_Cliente`) REFERENCES `tbl_cliente` (`Pk_Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_numero_cliente`
--

LOCK TABLES `tbl_numero_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_numero_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_numero_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_perfil`
--

DROP TABLE IF EXISTS `tbl_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfil` (
  `Pk_Id_Perfil` int NOT NULL AUTO_INCREMENT,
  `Cmp_Puesto_Perfil` varchar(50) DEFAULT NULL,
  `Cmp_Descripcion_Perfil` varchar(50) DEFAULT NULL,
  `Cmp_Estado_Perfil` bit(1) NOT NULL,
  `Cmp_Tipo_Perfil` int DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_perfil`
--

LOCK TABLES `tbl_perfil` WRITE;
/*!40000 ALTER TABLE `tbl_perfil` DISABLE KEYS */;
INSERT INTO `tbl_perfil` VALUES (1,'Administrador','Perfil con todos los permisos',_binary '',1),(12,'Probador','Persona que prueba codigo',_binary '',1),(22,'Pruebadef','pufa',_binary '',1),(33,'tester','provee',_binary '',1);
/*!40000 ALTER TABLE `tbl_perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_permiso_perfil_aplicacion`
--

DROP TABLE IF EXISTS `tbl_permiso_perfil_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permiso_perfil_aplicacion` (
  `Fk_Id_Perfil` int NOT NULL,
  `Fk_Id_Modulo` int NOT NULL,
  `Fk_Id_Aplicacion` int NOT NULL,
  `Cmp_Ingresar_Permisos_Aplicacion_Perfil` bit(1) DEFAULT NULL,
  `Cmp_Consultar_Permisos_Aplicacion_Perfil` bit(1) DEFAULT NULL,
  `Cmp_Modificar_Permisos_Aplicacion_Perfil` bit(1) DEFAULT NULL,
  `Cmp_Eliminar_Permisos_Aplicacion_Perfil` bit(1) DEFAULT NULL,
  `Cmp_Imprimir_Permisos_Aplicacion_Perfil` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Fk_Id_Perfil`,`Fk_Id_Modulo`,`Fk_Id_Aplicacion`),
  KEY `Fk_PermisoPerfil_ModuloAplicacion` (`Fk_Id_Modulo`,`Fk_Id_Aplicacion`),
  CONSTRAINT `Fk_PermisoPerfil` FOREIGN KEY (`Fk_Id_Perfil`) REFERENCES `tbl_perfil` (`Pk_Id_Perfil`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `Fk_PermisoPerfil_ModuloAplicacion` FOREIGN KEY (`Fk_Id_Modulo`, `Fk_Id_Aplicacion`) REFERENCES `tbl_asignacion_modulo_aplicacion` (`Fk_Id_Modulo`, `Fk_Id_Aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permiso_perfil_aplicacion`
--

LOCK TABLES `tbl_permiso_perfil_aplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_permiso_perfil_aplicacion` DISABLE KEYS */;
INSERT INTO `tbl_permiso_perfil_aplicacion` VALUES (12,4,303,_binary '',_binary '\0',_binary '',_binary '\0',_binary '\0'),(12,4,306,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,301,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,302,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,303,_binary '\0',_binary '\0',_binary '',_binary '\0',_binary '\0'),(22,4,304,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,305,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,306,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,307,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,308,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0'),(22,4,309,_binary '\0',_binary '\0',_binary '\0',_binary '\0',_binary '\0');
/*!40000 ALTER TABLE `tbl_permiso_perfil_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_permiso_usuario_aplicacion`
--

DROP TABLE IF EXISTS `tbl_permiso_usuario_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permiso_usuario_aplicacion` (
  `Fk_Id_Usuario` int NOT NULL,
  `Fk_Id_Modulo` int NOT NULL,
  `Fk_Id_Aplicacion` int NOT NULL,
  `Cmp_Ingresar_Permiso_Aplicacion_Usuario` bit(1) DEFAULT NULL,
  `Cmp_Consultar_Permiso_Aplicacion_Usuario` bit(1) DEFAULT NULL,
  `Cmp_Modificar_Permiso_Aplicacion_Usuario` bit(1) DEFAULT NULL,
  `Cmp_Eliminar_Permiso_Aplicacion_Usuario` bit(1) DEFAULT NULL,
  `Cmp_Imprimir_Permiso_Aplicacion_Usuario` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Fk_Id_Usuario`,`Fk_Id_Modulo`,`Fk_Id_Aplicacion`),
  KEY `Fk_Permiso_Modulo_Aplicacion` (`Fk_Id_Modulo`,`Fk_Id_Aplicacion`),
  CONSTRAINT `Fk_Permiso_Modulo_Aplicacion` FOREIGN KEY (`Fk_Id_Modulo`, `Fk_Id_Aplicacion`) REFERENCES `tbl_asignacion_modulo_aplicacion` (`Fk_Id_Modulo`, `Fk_Id_Aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `Fk_Permiso_Usuario` FOREIGN KEY (`Fk_Id_Usuario`) REFERENCES `tbl_usuario` (`Pk_Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permiso_usuario_aplicacion`
--

LOCK TABLES `tbl_permiso_usuario_aplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_permiso_usuario_aplicacion` DISABLE KEYS */;
INSERT INTO `tbl_permiso_usuario_aplicacion` VALUES (4,4,301,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,302,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,303,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,304,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,305,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,306,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,307,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,308,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,309,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,700,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,701,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,702,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,703,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,704,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,705,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,706,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,707,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,708,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,709,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,301,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,302,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,303,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,304,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,305,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,306,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,307,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,308,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,309,_binary '',_binary '',_binary '',_binary '',_binary '');
/*!40000 ALTER TABLE `tbl_permiso_usuario_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proveedores`
--

DROP TABLE IF EXISTS `tbl_proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proveedores` (
  `pk_id_proveedor` int NOT NULL AUTO_INCREMENT,
  `cmp_Nombre_Proveedor` varchar(50) NOT NULL,
  `cmp_Direccion` varchar(50) NOT NULL,
  `cmp_Telefono` varchar(15) NOT NULL,
  `cmp_Correo` varchar(50) NOT NULL,
  `cmp_descripcion` varchar(50) NOT NULL,
  `cmp_Estado` enum('activo','inactivo') DEFAULT 'activo',
  PRIMARY KEY (`pk_id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedores`
--

LOCK TABLES `tbl_proveedores` WRITE;
/*!40000 ALTER TABLE `tbl_proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reportes`
--

DROP TABLE IF EXISTS `tbl_reportes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_reportes` (
  `Pk_Id_Reporte` int NOT NULL AUTO_INCREMENT,
  `Cmp_Titulo_Reporte` varchar(50) DEFAULT NULL,
  `Cmp_Ruta_Reporte` varchar(500) DEFAULT NULL,
  `Cmp_Fecha_Reporte` date DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Reporte`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reportes`
--

LOCK TABLES `tbl_reportes` WRITE;
/*!40000 ALTER TABLE `tbl_reportes` DISABLE KEYS */;
INSERT INTO `tbl_reportes` VALUES (1,'Reporte Inicial','ruta/reporte.pdf','2025-01-01'),(2,'Reporte_Tipo_Operacion','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\INVENTARIO\\Proceso 5 Transacciones de Inventario Pedro Ibañez\\P5MovInvPedroIbañez\\Capa_Vista_Mov_Inv\\Rpt_Tipo_Op_CxC.rpt','2026-03-28'),(3,'Reporte Clientes','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\VENTAS\\Proceso 1Ventas-Ernesto Samayoa y Brandon Hernandez\\VentasMvc\\Capa_Vista_Ventas\\Rpt_Clientes.rpt','2026-03-29'),(4,'Reporte Vendedores','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\VENTAS\\Proceso 1Ventas-Ernesto Samayoa y Brandon Hernandez\\VentasMvc\\Capa_Vista_Ventas\\Rpt_Vendedores.rpt','2026-03-29'),(5,'Reporte Proveedores','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\COMPRAS\\Proceso 2 Proveesores Macos velásquez\\Mantenimiento Proveedores\\Mantenimiento Proveedores\\Reporte Proveedores.rpt','2026-03-29'),(6,'Report Linea','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\PRODUCCION\\Proceso 5-MantenimientoLineaProducto\\P5KenphLunaMantLinea\\Capa_Vista_LineaProd\\Rpt_LineaProducto.rpt','2026-03-29'),(7,'Reporte Bodega','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\DISTRIBUCION\\Proceso4-Bodega-Richard-de-Leon\\P4BodegaRichardDeLeon\\Capa_Vista_Bodegaa\\Rpt_Bodega.rpt','2026-03-29'),(8,'Reporte Cuentas por pagar','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\COMPRAS\\proseso 2 mantenimiento cuentas por  pagar Danilo\\Mantenimiento_cuentas_por_pagar\\Mantenimiento_cuentas_por_pagar\\Rpt_cuentas_por_pagar.rpt','2026-03-29'),(9,'Reporte Transporte','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\DISTRIBUCION\\Proceso4 Mantenimiento Transporte Sergio Izeppi\\Capa_Vista_Empresa_Transporte\\Capa_Vista_Empresa_Transporte\\Reporte_Empresas_Transporte.rpt','2026-03-29'),(10,'Reporte Tipo movimiento inventario','C:\\is2k26pf\\codigo\\empresarial\\Equipo 2\\INVENTARIO\\Proceso 5 Mantenimiento Movimiento Intentario\\Mantenimiento_tipo_MOV_inv\\Mantenimiento_tipo_MOV_inv\\rpt_mantenimiento_mov_inv.rpt','2026-04-08');
/*!40000 ALTER TABLE `tbl_reportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_salario_empleado`
--

DROP TABLE IF EXISTS `tbl_salario_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_salario_empleado` (
  `Pk_Id_Salario` int NOT NULL,
  `Fk_Id_Empleado` int DEFAULT NULL,
  `Cmp_Monto_Salario_Empleado` float DEFAULT NULL,
  `Cmp_Fecha_Inicio_Salario_Empleado` datetime DEFAULT NULL,
  `Cmp_Fecha_Fin_Salario_Empleado` datetime DEFAULT NULL,
  `Cmp_Estado_Salario_Empleado` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Salario`),
  KEY `Fk_Salario_Empleado` (`Fk_Id_Empleado`),
  CONSTRAINT `Fk_Salario_Empleado` FOREIGN KEY (`Fk_Id_Empleado`) REFERENCES `tbl_empleado` (`Pk_Id_Empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_salario_empleado`
--

LOCK TABLES `tbl_salario_empleado` WRITE;
/*!40000 ALTER TABLE `tbl_salario_empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_salario_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_movimiento_inventario`
--

DROP TABLE IF EXISTS `tbl_tipo_movimiento_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_movimiento_inventario` (
  `pk_tipo_movimiento_id` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_inv` varchar(45) DEFAULT NULL,
  `efecto` enum('ENTRADA','SALIDA') NOT NULL,
  `estado` enum('ACTIVO','INACTIVO') NOT NULL,
  PRIMARY KEY (`pk_tipo_movimiento_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_movimiento_inventario`
--

LOCK TABLES `tbl_tipo_movimiento_inventario` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_movimiento_inventario` DISABLE KEYS */;
INSERT INTO `tbl_tipo_movimiento_inventario` VALUES (1,'BONIFICACION','ENTRADA','ACTIVO'),(2,'Compra','ENTRADA','ACTIVO'),(3,'Venta','SALIDA','ACTIVO'),(4,'Devolución','ENTRADA','ACTIVO'),(5,'Ajuste entrada','ENTRADA','ACTIVO'),(6,'Ajuste salida','SALIDA','ACTIVO');
/*!40000 ALTER TABLE `tbl_tipo_movimiento_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_operacion_cxc`
--

DROP TABLE IF EXISTS `tbl_tipo_operacion_cxc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_operacion_cxc` (
  `pk_tipo_operacion_cxc_id` int NOT NULL,
  `cmp_operacion` varchar(100) NOT NULL,
  `cmp_efecto` enum('ENTRADA','SALIDA') NOT NULL,
  `cmp_estado_tipo_operacion_cxc` enum('ACTIVO','INACTIVO') DEFAULT 'ACTIVO',
  PRIMARY KEY (`pk_tipo_operacion_cxc_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_operacion_cxc`
--

LOCK TABLES `tbl_tipo_operacion_cxc` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_operacion_cxc` DISABLE KEYS */;
INSERT INTO `tbl_tipo_operacion_cxc` VALUES (1,'Pago Tarjeta','ENTRADA','ACTIVO'),(2,'Pago Bitcoin','ENTRADA','ACTIVO'),(3,'Cheque','ENTRADA','INACTIVO'),(4,'Prueba','SALIDA','ACTIVO');
/*!40000 ALTER TABLE `tbl_tipo_operacion_cxc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_token_restaurarcontrasena`
--

DROP TABLE IF EXISTS `tbl_token_restaurarcontrasena`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_token_restaurarcontrasena` (
  `Pk_Id_Token` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Usuario` int DEFAULT NULL,
  `Cmp_Token` varchar(50) DEFAULT NULL,
  `Cmp_Fecha_Creacion_Restaurar_Contrasenea` datetime DEFAULT NULL,
  `Cmp_Expiracion_Restaurar_Contrasenea` datetime DEFAULT NULL,
  `Cmp_Utilizado_Restaurar_Contrasenea` bit(1) DEFAULT NULL,
  `Cmp_Fecha_Uso_Restaurar_Contrasenea` datetime DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Token`),
  KEY `Fk_Token_Usuario` (`Fk_Id_Usuario`),
  CONSTRAINT `Fk_Token_Usuario` FOREIGN KEY (`Fk_Id_Usuario`) REFERENCES `tbl_usuario` (`Pk_Id_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_token_restaurarcontrasena`
--

LOCK TABLES `tbl_token_restaurarcontrasena` WRITE;
/*!40000 ALTER TABLE `tbl_token_restaurarcontrasena` DISABLE KEYS */;
INSERT INTO `tbl_token_restaurarcontrasena` VALUES (23,4,'B07EF449','2025-10-18 12:07:34','2025-10-18 12:12:34',_binary '','2025-10-18 12:08:27'),(24,4,'0C76A696','2025-10-18 17:08:53','2025-10-18 17:13:53',_binary '','2025-10-18 17:09:11');
/*!40000 ALTER TABLE `tbl_token_restaurarcontrasena` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuario`
--

DROP TABLE IF EXISTS `tbl_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuario` (
  `Pk_Id_Usuario` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Empleado` int DEFAULT NULL,
  `Cmp_Nombre_Usuario` varchar(50) DEFAULT NULL,
  `Cmp_Contrasena_Usuario` varchar(65) DEFAULT NULL,
  `Cmp_Intentos_Fallidos_Usuario` int DEFAULT NULL,
  `Cmp_Estado_Usuario` bit(1) DEFAULT NULL,
  `Cmp_FechaCreacion_Usuario` datetime DEFAULT NULL,
  `Cmp_Ultimo_Cambio_Contrasenea` datetime DEFAULT NULL,
  `Cmp_Pidio_Cambio_Contrasenea` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Usuario`),
  KEY `Fk_Usuario_Empleado` (`Fk_Id_Empleado`),
  CONSTRAINT `Fk_Usuario_Empleado` FOREIGN KEY (`Fk_Id_Empleado`) REFERENCES `tbl_empleado` (`Pk_Id_Empleado`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuario`
--

LOCK TABLES `tbl_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
INSERT INTO `tbl_usuario` VALUES (4,2,'brandon','45297c633d331e6ac35169ebaaf75bc7fafd206ebb59ba4efd80566936e46eb0',0,_binary '','2025-09-21 20:49:54','2025-10-18 17:09:11',_binary '\0'),(23,3,'admin','240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9',0,_binary '','2025-09-26 20:45:53','2025-09-26 20:45:53',_binary '\0');
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuario_perfil`
--

DROP TABLE IF EXISTS `tbl_usuario_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuario_perfil` (
  `Fk_Id_Usuario` int NOT NULL,
  `Fk_Id_Perfil` int NOT NULL,
  PRIMARY KEY (`Fk_Id_Usuario`,`Fk_Id_Perfil`),
  KEY `Fk_UsuarioPerfil_Perfil` (`Fk_Id_Perfil`),
  CONSTRAINT `Fk_UsuarioPerfil_Perfil` FOREIGN KEY (`Fk_Id_Perfil`) REFERENCES `tbl_perfil` (`Pk_Id_Perfil`),
  CONSTRAINT `Fk_UsuarioPerfil_Usuario` FOREIGN KEY (`Fk_Id_Usuario`) REFERENCES `tbl_usuario` (`Pk_Id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuario_perfil`
--

LOCK TABLES `tbl_usuario_perfil` WRITE;
/*!40000 ALTER TABLE `tbl_usuario_perfil` DISABLE KEYS */;
INSERT INTO `tbl_usuario_perfil` VALUES (4,1);
/*!40000 ALTER TABLE `tbl_usuario_perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_vendedor`
--

DROP TABLE IF EXISTS `tbl_vendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_vendedor` (
  `Pk_Id_Vendedor` int NOT NULL AUTO_INCREMENT,
  `Cmp_CuioNit` varchar(20) NOT NULL,
  `Cmp_Nombre` varchar(50) NOT NULL,
  `Cmp_Apellido` varchar(50) NOT NULL,
  `Cmp_Telefono` varchar(20) NOT NULL,
  `Cmp_Correo` varchar(100) NOT NULL,
  `Cmp_Direccion` varchar(150) NOT NULL,
  `Cmp_Estado` enum('Activo','Inactivo') DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Vendedor`),
  UNIQUE KEY `Cmp_CuioNit` (`Cmp_CuioNit`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_vendedor`
--

LOCK TABLES `tbl_vendedor` WRITE;
/*!40000 ALTER TABLE `tbl_vendedor` DISABLE KEYS */;
INSERT INTO `tbl_vendedor` VALUES (1,'2345642434','manuel','Herrera','40472425','mherra@gmail.com','zona 2 ','Activo');
/*!40000 ALTER TABLE `tbl_vendedor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-04-11 12:15:17
