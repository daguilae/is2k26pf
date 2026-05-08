-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_logistica
-- ------------------------------------------------------
-- Server version	8.0.41

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
INSERT INTO `tbl_aplicacion` VALUES (1,NULL,'Registros','Registro de acciones en el sistema',_binary ''),(301,NULL,'Empleados','Control de empleados de la hoteleria',_binary ''),(302,NULL,'Usuarios','Control de usuarios de empleados',_binary ''),(303,NULL,'Perfiles','Perfiles que se asignan a usuarios',_binary ''),(304,NULL,'Modulos','Mantenimiento de modulos',_binary ''),(305,NULL,'Aplicacion','Mantenimiento de aplicaciones',_binary ''),(306,NULL,'Asig Aplicacion Usuario','Asigna permisos a usuarios',_binary ''),(307,NULL,'Asig aplicacion Perfil','Asigna permisos a perfiles',_binary ''),(308,NULL,'Asig Perfiles','Asigna los perfiles a usuarios',_binary ''),(309,NULL,'Bitacora','Da acceso a bitacora',_binary ''),(700,NULL,'Marca','Marca de Productos',_binary ''),(701,4,'Vendedores','Vendedores',_binary ''),(702,3,'Clientes','Clientes',_binary ''),(703,5,'Proveedores','Proveedor',_binary ''),(704,6,'Linea de Productos','Lineas',_binary ''),(705,7,'Bodega','Bodegas',_binary ''),(706,9,'Transportes','Transportes',_binary ''),(707,10,'Tipo de Movimiento Inventario','Mov Inv Tipo',_binary ''),(708,8,'Tipo Operación Cuentas Por pagar','Cuentas por pagar',_binary ''),(709,2,'Tipo_Operacion_Cuentas_Por_Cobrar','Cuentas por cobrar',_binary ''),(710,NULL,'Ventas','información sobre las ventas',_binary ''),(711,NULL,'Cuentas Por Cobrar','Informacion sobre CXC',_binary ''),(712,NULL,'orden prod','orden prod',_binary ''),(713,NULL,'Devoluciones','Crear una devolución',_binary ''),(714,NULL,'Compras','compras',_binary ''),(715,NULL,'Cuentas por pagar','cuentas por pagar',_binary ''),(716,NULL,'Detalle Orden prod','Detail',_binary ''),(717,NULL,'Comprobante de Compra','Comprobante',_binary ''),(718,NULL,'Comprobante de Venta','Comprobante',_binary ''),(719,NULL,'Comprobante Prod','Comprobante',_binary ''),(720,NULL,'Entrega Prod','Entrega Prod',_binary ''),(721,NULL,'Entrega Venta','Entrega Venta',_binary ''),(722,NULL,'Entrega Compra','entrega compra',_binary ''),(723,NULL,'Transporte','Transporte',_binary ''),(724,NULL,'Mantenimiento Unidad medida','Unidad medida',_binary ''),(726,NULL,'Inventario','Inv',_binary ''),(727,NULL,'Sucursales','Sucursales',_binary ''),(728,NULL,'MovInventario','MovIn',_binary ''),(729,NULL,'Factura','fact',_binary ''),(730,NULL,'Tipos de clientes','typeshit',_binary ''),(731,NULL,'Politicas de descuento','Politicas de descuento',_binary '');
/*!40000 ALTER TABLE `tbl_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacion_clientes`
--

DROP TABLE IF EXISTS `tbl_asignacion_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacion_clientes` (
  `Fk_Id_Vendedor` int NOT NULL,
  `Fk_Id_Cliente` int NOT NULL,
  PRIMARY KEY (`Fk_Id_Vendedor`,`Fk_Id_Cliente`),
  KEY `Fk_AsigVendedor` (`Fk_Id_Vendedor`),
  KEY `Fk_AsigClientes` (`Fk_Id_Cliente`),
  CONSTRAINT `Fk_AsigClientes` FOREIGN KEY (`Fk_Id_Cliente`) REFERENCES `tbl_clientes` (`Pk_Id_Cliente`),
  CONSTRAINT `Fk_AsigVendedor` FOREIGN KEY (`Fk_Id_Vendedor`) REFERENCES `tbl_vendedor` (`Pk_Id_Vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacion_clientes`
--

LOCK TABLES `tbl_asignacion_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_asignacion_clientes` DISABLE KEYS */;
INSERT INTO `tbl_asignacion_clientes` VALUES (1,1),(1,2);
/*!40000 ALTER TABLE `tbl_asignacion_clientes` ENABLE KEYS */;
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
INSERT INTO `tbl_asignacion_modulo_aplicacion` VALUES (4,301),(4,302),(4,303),(4,304),(4,305),(4,306),(4,307),(4,308),(4,309),(44,700),(44,701),(44,702),(44,703),(44,704),(44,705),(44,706),(44,707),(44,708),(44,709),(44,710),(44,711),(44,712),(44,713),(44,714),(44,715),(44,716),(44,717),(44,718),(44,719),(44,720),(44,721),(44,722),(44,723),(44,724),(44,726),(44,727),(44,728),(44,729),(44,730),(44,731);
/*!40000 ALTER TABLE `tbl_asignacion_modulo_aplicacion` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=236 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacora`
--

LOCK TABLES `tbl_bitacora` WRITE;
/*!40000 ALTER TABLE `tbl_bitacora` DISABLE KEYS */;
INSERT INTO `tbl_bitacora` VALUES (1,4,NULL,'2026-03-26 16:26:15','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(2,4,304,'2026-03-26 16:26:46','Insertó un nuevo registro en la tabla \'tbl_modulo\' con llave: 44','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(3,4,306,'2026-03-26 16:28:15','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Perfiles\'\': Consultar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(4,4,306,'2026-03-26 16:28:15','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Modulos\'\': Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(5,4,304,'2026-03-26 16:28:47','Actualizo un registro en la tabla \'tbl_modulo\' Con la llave \'44\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(6,4,304,'2026-03-26 16:28:56','Actualizo un registro en la tabla \'tbl_modulo\' Con la llave \'44\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(7,4,304,'2026-03-26 16:29:06','Insertó un nuevo registro en la tabla \'tbl_modulo\' con llave: 11','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(8,4,304,'2026-03-26 16:29:23','Eliminó un registro en la tabla \'tbl_modulo\' Con la llave \'11\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(9,4,1,'2026-03-26 16:30:44','Guardó aplicación: Tipo_Operacion_Cuentas_Por_Cobrar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(10,4,1,'2026-03-26 16:32:11','Modificó aplicación: Tipo_Operacion_Cuentas_Por_Cobrar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(11,4,306,'2026-03-26 16:32:56','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipo_Operacion_Cuentas_Por_Cobrar\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(12,4,NULL,'2026-03-26 16:33:13','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(13,4,NULL,'2026-03-26 16:48:47','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(14,4,NULL,'2026-03-26 16:56:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(15,4,NULL,'2026-03-28 19:37:33','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(16,4,1,'2026-03-28 19:38:11','Modificó aplicación: Tipo_Operacion_Cuentas_Por_Cobrar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(17,4,NULL,'2026-03-28 19:38:43','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(18,4,NULL,'2026-03-28 19:39:02','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(19,4,NULL,'2026-03-28 22:24:52','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(20,4,NULL,'2026-03-28 22:25:32','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(21,4,NULL,'2026-03-28 22:30:11','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(22,4,NULL,'2026-03-28 22:54:34','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(23,4,NULL,'2026-03-29 09:32:16','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(24,4,NULL,'2026-03-29 12:06:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(25,4,NULL,'2026-03-29 12:15:54','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(26,4,1,'2026-03-29 12:22:15','Guardó aplicación: Marca','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(27,4,1,'2026-03-29 12:22:47','Guardó aplicación: Vendedores','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(28,4,1,'2026-03-29 12:23:07','Guardó aplicación: Clientes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(29,4,1,'2026-03-29 12:23:30','Guardó aplicación: Proveedores','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(30,4,1,'2026-03-29 12:24:02','Guardó aplicación: Linea de Productos','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(31,4,1,'2026-03-29 12:24:34','Guardó aplicación: Bodega','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(32,4,1,'2026-03-29 12:24:56','Guardó aplicación: Transportes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(33,4,1,'2026-03-29 12:25:32','Guardó aplicación: Tipo de Movimiento Inventario','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(34,4,1,'2026-03-29 12:26:08','Guardó aplicación: Tipo Operación Cuentas Por pagar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(35,4,306,'2026-03-29 12:29:19','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Marca\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(36,4,306,'2026-03-29 12:29:19','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Vendedores\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(37,4,306,'2026-03-29 12:29:19','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Clientes\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(38,4,306,'2026-03-29 12:29:20','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Proveedores\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(39,4,306,'2026-03-29 12:29:20','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Linea de Productos\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(40,4,306,'2026-03-29 12:29:21','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Bodega\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(41,4,306,'2026-03-29 12:29:21','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Transportes\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(42,4,306,'2026-03-29 12:29:21','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipo de Movimiento Inventario\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(43,4,306,'2026-03-29 12:29:22','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipo Operación Cuentas Por pagar\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(44,4,NULL,'2026-03-29 12:30:00','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(45,4,NULL,'2026-03-29 13:42:22','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(46,4,1,'2026-03-29 13:44:15','Modificó aplicación: Bodega','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(47,4,NULL,'2026-03-29 14:42:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(48,4,NULL,'2026-03-29 15:42:55','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(49,4,1,'2026-03-29 15:44:19','Modificó aplicación: Tipo Operación Cuentas Por pagar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(50,4,NULL,'2026-03-29 15:44:25','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(51,4,NULL,'2026-03-29 15:44:44','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(52,4,NULL,'2026-03-29 15:47:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(53,4,NULL,'2026-03-29 16:07:15','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(54,4,NULL,'2026-03-29 16:15:23','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(55,4,NULL,'2026-03-29 16:16:18','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(56,4,NULL,'2026-03-29 16:26:27','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(57,4,NULL,'2026-03-29 16:33:17','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(58,4,NULL,'2026-03-29 16:37:06','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(59,4,1,'2026-03-29 16:38:47','Modificó aplicación: Transportes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(60,4,NULL,'2026-03-29 16:39:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(61,4,NULL,'2026-03-29 16:41:40','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(62,4,NULL,'2026-03-29 16:43:24','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(63,4,NULL,'2026-03-29 17:14:42','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(64,4,NULL,'2026-03-29 17:19:56','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(65,4,NULL,'2026-03-29 19:57:12','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(66,4,NULL,'2026-03-29 19:58:31','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(67,4,NULL,'2026-03-29 20:39:09','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(68,4,709,'2026-03-29 20:41:52','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(69,4,709,'2026-03-29 20:42:23','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 2','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(70,4,709,'2026-03-29 20:45:10','Actualizo un registro en la tabla \'tbl_tipo_operacion_cxc\' Con la llave \'1\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(71,4,709,'2026-03-29 20:45:19','Actualizo un registro en la tabla \'tbl_tipo_operacion_cxc\' Con la llave \'2\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(72,4,709,'2026-03-29 20:45:40','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 3','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(73,4,NULL,'2026-04-07 07:56:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(74,4,NULL,'2026-04-07 08:04:16','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(75,4,NULL,'2026-04-07 08:24:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(76,4,NULL,'2026-04-07 08:25:00','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(77,4,NULL,'2026-04-07 08:25:11','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(78,4,NULL,'2026-04-07 09:21:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(79,4,NULL,'2026-04-07 09:56:58','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(80,4,709,'2026-04-07 09:59:03','Actualizo un registro en la tabla \'tbl_tipo_operacion_cxc\' Con la llave \'3\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(81,4,NULL,'2026-04-07 10:01:13','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(82,4,NULL,'2026-04-07 10:01:47','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(83,4,NULL,'2026-04-07 10:03:10','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(84,4,NULL,'2026-04-07 17:20:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(85,4,NULL,'2026-04-07 17:24:16','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(86,4,NULL,'2026-04-07 17:30:54','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(87,4,NULL,'2026-04-07 21:49:12','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(88,4,NULL,'2026-04-08 18:07:31','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(89,4,1,'2026-04-08 18:08:50','Modificó aplicación: Tipo de Movimiento Inventario','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(90,4,NULL,'2026-04-08 18:09:04','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(91,4,NULL,'2026-04-09 08:17:06','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(92,4,NULL,'2026-04-09 08:41:36','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(93,4,709,'2026-04-09 08:59:07','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 4','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(94,4,306,'2026-04-09 09:05:58','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Bitacora\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(95,4,NULL,'2026-04-09 09:06:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(96,4,NULL,'2026-04-09 09:07:30','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(97,4,705,'2026-04-09 09:09:02','Insertó un nuevo registro en la tabla \'tbl_bodega\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(98,4,702,'2026-04-09 09:15:18','Insertó un nuevo registro en la tabla \'Tbl_Clientes\' con llave: 201','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(99,4,NULL,'2026-04-09 09:16:44','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(100,4,701,'2026-04-09 09:19:14','Insertó un nuevo registro en la tabla \'Tbl_Vendedor\' con llave: 502','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(101,4,700,'2026-04-09 09:21:41','Insertó un nuevo registro en la tabla \'Tbl_Marca\' con llave: 2','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(102,4,707,'2026-04-09 09:28:43','Insertó un nuevo registro en la tabla \'tbl_tipo_movimiento_inventario\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(103,4,707,'2026-04-09 09:29:14','Actualizo un registro en la tabla \'tbl_tipo_movimiento_inventario\' Con la llave \'1\' ','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(104,4,NULL,'2026-04-09 09:53:35','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(105,4,NULL,'2026-04-10 15:42:47','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(106,4,NULL,'2026-04-10 15:44:18','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(107,4,NULL,'2026-04-10 15:46:24','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(108,4,NULL,'2026-04-10 15:51:01','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(109,4,NULL,'2026-04-10 15:58:32','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(110,4,NULL,'2026-04-10 16:03:19','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(111,4,NULL,'2026-04-10 16:05:17','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(112,4,NULL,'2026-04-10 16:35:38','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(113,4,NULL,'2026-04-18 20:40:28','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(114,4,NULL,'2026-04-18 20:41:37','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(115,4,NULL,'2026-04-18 20:48:34','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(116,4,NULL,'2026-04-18 20:49:48','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(117,4,1,'2026-04-18 20:50:17','Guardó aplicación: Ventas','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(118,4,1,'2026-04-18 20:50:53','Guardó aplicación: Cuentas Por Cobrar','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(119,4,1,'2026-04-18 20:51:24','Guardó aplicación: Devoluciones','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(120,4,306,'2026-04-18 20:52:11','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Cuentas Por Cobrar\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(121,4,306,'2026-04-18 20:52:11','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Ventas\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(122,4,306,'2026-04-18 20:52:11','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Devoluciones\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(123,4,NULL,'2026-04-18 20:52:25','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(124,4,NULL,'2026-04-18 20:52:37','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(125,4,NULL,'2026-04-18 20:53:34','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(126,4,NULL,'2026-04-18 20:55:36','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(127,4,NULL,'2026-04-18 21:00:14','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(128,4,NULL,'2026-04-18 21:04:00','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(129,4,NULL,'2026-04-18 21:04:26','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(130,4,NULL,'2026-04-18 21:04:49','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(131,4,NULL,'2026-04-18 21:06:53','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(132,4,NULL,'2026-04-18 21:07:35','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(133,4,NULL,'2026-04-18 21:10:30','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(134,4,NULL,'2026-04-18 21:17:14','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(135,4,NULL,'2026-04-18 21:18:19','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(136,4,NULL,'2026-04-18 21:18:34','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(137,4,NULL,'2026-04-18 21:20:00','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(138,4,NULL,'2026-04-18 21:25:35','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(139,4,NULL,'2026-04-21 08:45:31','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(140,4,1,'2026-04-21 08:46:23','Guardó aplicación: MovInventario','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(141,4,1,'2026-04-21 08:46:53','Guardó aplicación: Inventario','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(142,4,306,'2026-04-21 08:47:38','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Inventario\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(143,4,306,'2026-04-21 08:47:40','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'MovInventario\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(144,4,NULL,'2026-04-21 08:47:46','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(145,4,NULL,'2026-04-21 08:49:34','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(146,4,NULL,'2026-04-21 08:51:09','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(147,4,1,'2026-04-21 08:52:12','Guardó aplicación: orden prod','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(148,4,1,'2026-04-21 08:53:38','Guardó aplicación: Factura','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(149,4,1,'2026-04-21 08:54:15','Guardó aplicación: Compras','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(150,4,1,'2026-04-21 08:55:02','Guardó aplicación: Cuentas por pagar','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(151,4,1,'2026-04-21 08:55:43','Guardó aplicación: Detalle Orden prod','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(152,4,1,'2026-04-21 08:57:14','Guardó aplicación: Comprobante de Compra','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(153,4,1,'2026-04-21 08:57:48','Guardó aplicación: Comprobante de Venta','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(154,4,1,'2026-04-21 08:58:17','Guardó aplicación: Comprobante Prod','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(155,4,1,'2026-04-21 08:58:47','Guardó aplicación: Entrega Prod','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(156,4,1,'2026-04-21 08:59:19','Guardó aplicación: Entrega Venta','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(157,4,1,'2026-04-21 09:00:08','Guardó aplicación: Entrega Compra','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(158,4,1,'2026-04-21 09:00:40','Guardó aplicación: Transporte','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(159,4,1,'2026-04-21 09:01:27','Guardó aplicación: Sucursales','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(160,4,306,'2026-04-21 09:06:41','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'orden prod\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(161,4,306,'2026-04-21 09:06:41','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Compras\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(162,4,306,'2026-04-21 09:06:41','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Cuentas por pagar\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(163,4,306,'2026-04-21 09:06:42','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Detalle Orden prod\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(164,4,306,'2026-04-21 09:06:42','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Comprobante de Compra\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(165,4,306,'2026-04-21 09:06:42','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Comprobante de Venta\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(166,4,306,'2026-04-21 09:06:42','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Comprobante Prod\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(167,4,306,'2026-04-21 09:06:42','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Entrega Prod\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(168,4,306,'2026-04-21 09:06:43','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Entrega Venta\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(169,4,306,'2026-04-21 09:06:43','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Entrega Compra\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(170,4,306,'2026-04-21 09:06:43','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Transporte\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(171,4,306,'2026-04-21 09:06:43','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Sucursales\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(172,4,306,'2026-04-21 09:06:43','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Factura\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(173,4,NULL,'2026-04-21 09:06:51','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(174,4,NULL,'2026-04-21 09:07:32','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(175,4,NULL,'2026-04-21 09:12:41','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(176,4,NULL,'2026-04-21 09:28:54','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(177,4,NULL,'2026-04-21 09:31:18','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(178,4,NULL,'2026-04-21 17:18:32','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(179,4,NULL,'2026-04-21 17:31:12','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(180,4,NULL,'2026-04-28 08:29:58','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(181,4,NULL,'2026-04-28 08:31:08','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(182,4,NULL,'2026-04-28 08:46:20','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(183,4,NULL,'2026-04-28 09:04:21','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(184,4,NULL,'2026-04-28 09:31:48','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(185,4,727,'2026-04-28 09:50:36','Insertó un nuevo registro en la tabla \'Tbl_sucursales\' con llave: 1','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(186,4,NULL,'2026-04-28 11:15:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(187,4,NULL,'2026-05-01 17:22:29','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(188,4,NULL,'2026-05-01 17:24:39','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(189,4,NULL,'2026-05-01 17:29:38','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(190,4,NULL,'2026-05-01 17:30:44','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(191,4,NULL,'2026-05-01 17:31:05','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(192,4,NULL,'2026-05-01 17:31:47','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(193,4,NULL,'2026-05-01 17:32:25','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(194,4,NULL,'2026-05-01 17:35:05','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(195,4,NULL,'2026-05-01 17:38:34','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(196,4,NULL,'2026-05-01 17:43:17','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(197,4,NULL,'2026-05-01 17:56:54','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(198,4,702,'2026-05-01 17:58:19','Insertó un nuevo registro en la tabla \'Tbl_Clientes\' con llave: 1','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(199,4,NULL,'2026-05-01 18:00:33','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(200,4,NULL,'2026-05-01 18:07:05','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(201,4,NULL,'2026-05-01 18:12:38','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(202,4,NULL,'2026-05-01 18:20:32','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(203,4,NULL,'2026-05-01 18:31:36','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(204,4,306,'2026-05-01 18:32:08','Al usuario \'\'brandon\'\' se le removieron permisos en la aplicación \'\'Cuentas Por Cobrar\'\': Ingresar, Modificar, Eliminar','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(205,4,NULL,'2026-05-05 07:38:14','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(206,4,NULL,'2026-05-05 07:44:14','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(207,4,NULL,'2026-05-05 08:37:46','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(208,4,NULL,'2026-05-05 08:44:19','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(209,4,NULL,'2026-05-05 08:46:33','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(210,4,NULL,'2026-05-05 08:47:43','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(211,4,NULL,'2026-05-05 09:05:14','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(212,4,1,'2026-05-05 09:05:46','Modificó aplicación: Tipos de clientes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(213,4,1,'2026-05-05 09:06:04','Modificó aplicación: Tipos de clientes','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(214,4,NULL,'2026-05-05 09:06:59','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(215,4,NULL,'2026-05-05 09:08:05','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(216,4,306,'2026-05-05 09:09:36','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Mantenimiento Unidad medida\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(217,4,306,'2026-05-05 09:09:37','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Tipos de clientes\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(218,4,306,'2026-05-05 09:09:37','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Politicas de descuento\'\': Ingresar, Consultar, Modificar, Eliminar, Imprimir','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(219,4,NULL,'2026-05-05 09:09:42','Cierre de sesión','192.168.56.1','DESKTOP-BVMTMU2',_binary '\0'),(220,4,NULL,'2026-05-05 09:10:17','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(221,4,NULL,'2026-05-05 09:52:45','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(222,4,NULL,'2026-05-05 14:33:25','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(223,4,NULL,'2026-05-05 14:35:07','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(224,4,NULL,'2026-05-05 16:07:51','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(225,4,NULL,'2026-05-05 20:22:29','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(226,4,NULL,'2026-05-05 20:31:11','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(227,4,NULL,'2026-05-05 20:35:39','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(228,4,NULL,'2026-05-05 20:44:14','Ingreso','192.168.56.1','DESKTOP-BVMTMU2',_binary ''),(229,4,NULL,'2026-05-07 20:25:42','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(230,4,702,'2026-05-07 20:26:32','Insertó un nuevo registro en la tabla \'Tbl_Clientes\' con llave: 2','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(231,4,709,'2026-05-07 20:27:01','Insertó un nuevo registro en la tabla \'tbl_tipo_operacion_cxc\' con llave: 5','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(232,4,NULL,'2026-05-07 20:32:55','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(233,4,NULL,'2026-05-07 20:34:40','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(234,4,306,'2026-05-07 20:35:05','Al usuario \'\'brandon\'\' se le asignaron permisos en la aplicación \'\'Cuentas Por Cobrar\'\': Ingresar, Modificar','169.254.187.46','DESKTOP-01DDSQ2',_binary ''),(235,4,NULL,'2026-05-07 20:35:41','Ingreso','169.254.187.46','DESKTOP-01DDSQ2',_binary '');
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
  `Cmp_Saldo_Total` float DEFAULT '0',
  `Cmp_Direccion` varchar(150) NOT NULL,
  `Fk_Id_Tipo_Cliente` int NOT NULL,
  `Cmp_Estado` enum('Activo','Inactivo') DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Cliente`),
  UNIQUE KEY `Cmp_CuioNit` (`Cmp_CuioNit`),
  KEY `fk_cliente_tipo_idx` (`Fk_Id_Tipo_Cliente`),
  CONSTRAINT `fk_cliente_tipo` FOREIGN KEY (`Fk_Id_Tipo_Cliente`) REFERENCES `tbl_tipo_cliente` (`Pk_Id_Tipo_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_clientes`
--

LOCK TABLES `tbl_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_clientes` DISABLE KEYS */;
INSERT INTO `tbl_clientes` VALUES (1,'96459641964','armando ','Barrera','61616161','armando@mail.com',118456,'zona 2',1,'Activo'),(2,'334344','Ruben','luch','3434344','rlopez@mail.com',118456,'zona 2',1,'Activo');
/*!40000 ALTER TABLE `tbl_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_compra`
--

DROP TABLE IF EXISTS `tbl_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_compra` (
  `pk_id_compra` int NOT NULL AUTO_INCREMENT,
  `fk_id_proveedor` int NOT NULL,
  `fk_id_orden_compra` int DEFAULT NULL,
  `fk_id_bodega` int NOT NULL,
  `cmp_serie_factura` varchar(20) DEFAULT NULL,
  `cmp_numero_factura` varchar(50) NOT NULL,
  `cmp_fecha` datetime NOT NULL,
  `cmp_dias_credito` int DEFAULT '0',
  `cmp_fecha_vencimiento` datetime DEFAULT NULL,
  `cmp_tipo_compra` enum('contado','credito') NOT NULL,
  `cmp_subtotal` decimal(12,2) NOT NULL,
  `cmp_total` decimal(12,2) NOT NULL,
  `cmp_estado` enum('pendiente','parcial','pagado','devuelto') DEFAULT 'pendiente',
  PRIMARY KEY (`pk_id_compra`),
  UNIQUE KEY `uq_factura_proveedor` (`cmp_serie_factura`,`cmp_numero_factura`,`fk_id_proveedor`),
  KEY `fk_id_proveedor` (`fk_id_proveedor`),
  KEY `fk_id_orden_compra` (`fk_id_orden_compra`),
  KEY `fk_id_bodega` (`fk_id_bodega`),
  CONSTRAINT `Tbl_compra_ibfk_1` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `tbl_proveedores` (`pk_id_proveedor`),
  CONSTRAINT `Tbl_compra_ibfk_2` FOREIGN KEY (`fk_id_orden_compra`) REFERENCES `tbl_orden_compra` (`pk_id_orden_compra`),
  CONSTRAINT `Tbl_compra_ibfk_3` FOREIGN KEY (`fk_id_bodega`) REFERENCES `tbl_bodega` (`Pk_Id_Bodega`)
) ENGINE=InnoDB AUTO_INCREMENT=2007 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_compra`
--

LOCK TABLES `tbl_compra` WRITE;
/*!40000 ALTER TABLE `tbl_compra` DISABLE KEYS */;
INSERT INTO `tbl_compra` VALUES (2001,1001,NULL,1,'A','FAC-001','2026-04-01 10:00:00',30,'2026-05-01 00:00:00','credito',1500.00,1500.00,'parcial'),(2002,1002,NULL,1,'A','FAC-002','2026-04-05 11:30:00',15,'2026-04-20 00:00:00','credito',850.00,850.00,'parcial'),(2003,1003,NULL,2,'B','FAC-003','2026-04-10 09:15:00',0,NULL,'contado',2300.00,2300.00,'pagado'),(2004,1001,NULL,2,'C','FAC-004','2026-04-15 14:00:00',45,'2026-05-30 00:00:00','credito',3200.00,3200.00,'pagado'),(2005,1001,5,3,'ABC','123','2026-05-05 09:56:21',NULL,NULL,'contado',120.00,120.00,'pendiente');
/*!40000 ALTER TABLE `tbl_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_comprobante_compra`
--

DROP TABLE IF EXISTS `tbl_comprobante_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_comprobante_compra` (
  `Pk_ID_Comprobante_Compra` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_Entrega_Compra` int NOT NULL,
  `Fk_ID_Cliente` int NOT NULL,
  `Cmp_Nombre_Receptor` varchar(100) NOT NULL,
  `Cmp_Fecha_Hora_Entrega` datetime NOT NULL,
  `Cmp_Observaciones` varchar(255) DEFAULT NULL,
  `Cmp_Estado` enum('Pendiente','Entregado','Cancelado') DEFAULT 'Pendiente',
  PRIMARY KEY (`Pk_ID_Comprobante_Compra`),
  KEY `Fk_ID_Entrega_Compra` (`Fk_ID_Entrega_Compra`),
  KEY `Fk_ID_Cliente` (`Fk_ID_Cliente`),
  CONSTRAINT `fk_comprobante_cliente` FOREIGN KEY (`Fk_ID_Cliente`) REFERENCES `tbl_clientes` (`Pk_Id_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_comprobante_entrega` FOREIGN KEY (`Fk_ID_Entrega_Compra`) REFERENCES `tbl_entrega_compra` (`Pk_Id_Entrega_Compra`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_comprobante_compra`
--

LOCK TABLES `tbl_comprobante_compra` WRITE;
/*!40000 ALTER TABLE `tbl_comprobante_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_comprobante_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_comprobante_produccion`
--

DROP TABLE IF EXISTS `tbl_comprobante_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_comprobante_produccion` (
  `Pk_ID_Comprobante_Produccion` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_Entrega_Produccion` int NOT NULL,
  `Fk_ID_Cliente` int NOT NULL,
  `Cmp_Nombre_Receptor` varchar(100) NOT NULL,
  `Cmp_Fecha_Hora_Entrega` datetime NOT NULL,
  `Cmp_Observaciones` varchar(255) DEFAULT NULL,
  `Cmp_Estado` enum('Pendiente','Entregado','Cancelado') DEFAULT 'Pendiente',
  PRIMARY KEY (`Pk_ID_Comprobante_Produccion`),
  KEY `Fk_ID_Entrega_Produccion` (`Fk_ID_Entrega_Produccion`),
  KEY `Fk_ID_Cliente` (`Fk_ID_Cliente`),
  CONSTRAINT `fk_comprobante_produccion_cliente` FOREIGN KEY (`Fk_ID_Cliente`) REFERENCES `tbl_clientes` (`Pk_Id_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_comprobante_produccion_entrega` FOREIGN KEY (`Fk_ID_Entrega_Produccion`) REFERENCES `tbl_entrega_produccion` (`Pk_Id_Entrega_Produccion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_comprobante_produccion`
--

LOCK TABLES `tbl_comprobante_produccion` WRITE;
/*!40000 ALTER TABLE `tbl_comprobante_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_comprobante_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_comprobante_venta`
--

DROP TABLE IF EXISTS `tbl_comprobante_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_comprobante_venta` (
  `Pk_ID_Comprobante_Venta` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_Entrega_Venta` int NOT NULL,
  `Fk_ID_Cliente` int NOT NULL,
  `Cmp_Nombre_Receptor` varchar(100) NOT NULL,
  `Cmp_Fecha_Hora_Entrega` datetime NOT NULL,
  `Cmp_Observaciones` varchar(255) DEFAULT NULL,
  `Cmp_Estado` enum('Pendiente','Entregado','Cancelado') DEFAULT 'Pendiente',
  PRIMARY KEY (`Pk_ID_Comprobante_Venta`),
  KEY `Fk_ID_Entrega_Venta` (`Fk_ID_Entrega_Venta`),
  KEY `Fk_ID_Cliente` (`Fk_ID_Cliente`),
  CONSTRAINT `fk_comprobante_venta_cliente` FOREIGN KEY (`Fk_ID_Cliente`) REFERENCES `tbl_clientes` (`Pk_Id_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_comprobante_venta_entrega` FOREIGN KEY (`Fk_ID_Entrega_Venta`) REFERENCES `tbl_entrega_venta` (`Pk_Id_Entrega_Venta`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_comprobante_venta`
--

LOCK TABLES `tbl_comprobante_venta` WRITE;
/*!40000 ALTER TABLE `tbl_comprobante_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_comprobante_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentas_por_cobrar`
--

DROP TABLE IF EXISTS `tbl_cuentas_por_cobrar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas_por_cobrar` (
  `Pk_Id_Cuenta_Por_Cobrar` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Venta` int NOT NULL,
  `FK_Id_Cliente` int NOT NULL,
  `Cmp_Fecha_De_Deuda` datetime NOT NULL,
  `Cmp_Fecha_Vencimiento` datetime NOT NULL,
  `Cmp_Monto_Total` float NOT NULL DEFAULT '0',
  `Cmp_Estado` enum('Activo','Inactivo') NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Cuenta_Por_Cobrar`),
  KEY `Fk_Id_Venta` (`Fk_Id_Venta`),
  KEY `FK_Id_Cliente` (`FK_Id_Cliente`),
  CONSTRAINT `tbl_cuentas_por_cobrar_ibfk_1` FOREIGN KEY (`Fk_Id_Venta`) REFERENCES `tbl_ventas` (`Pk_Id_Ventas`),
  CONSTRAINT `tbl_cuentas_por_cobrar_ibfk_2` FOREIGN KEY (`FK_Id_Cliente`) REFERENCES `tbl_clientes` (`Pk_Id_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas_por_cobrar`
--

LOCK TABLES `tbl_cuentas_por_cobrar` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas_por_cobrar` DISABLE KEYS */;
INSERT INTO `tbl_cuentas_por_cobrar` VALUES (1,2,1,'2026-04-30 23:38:02','2026-05-30 23:38:02',18.5,'Activo'),(2,5,1,'2026-04-30 23:38:02','2026-05-30 23:38:02',90,'Activo'),(3,9,1,'2026-04-30 23:38:02','2026-05-30 23:38:02',56,'Activo'),(4,10,1,'2026-05-01 00:00:00','2026-05-31 00:00:00',1400,'Activo'),(5,11,1,'2026-05-01 00:00:00','2026-05-31 00:00:00',22500,'Activo'),(6,12,1,'2026-05-01 00:00:00','2026-05-31 00:00:00',40500,'Activo'),(7,13,1,'2026-05-01 00:00:00','2026-05-31 00:00:00',27000,'Activo'),(8,14,1,'2026-05-01 00:00:00','2026-05-31 00:00:00',27000,'Activo'),(9,15,2,'2026-05-01 00:00:00','2026-05-31 00:00:00',0,'Inactivo'),(10,16,1,'2026-05-01 00:00:00','2026-05-31 00:00:00',45,'Inactivo');
/*!40000 ALTER TABLE `tbl_cuentas_por_cobrar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentas_por_cobrar_detalle`
--

DROP TABLE IF EXISTS `tbl_cuentas_por_cobrar_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas_por_cobrar_detalle` (
  `Pk_Id_Cuenta_Por_Cobrar_Detalle` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Cuenta_Por_Cobrar` int NOT NULL,
  `Fk_Id_Tipo_Operacion` int NOT NULL,
  `Cmp_No_Documento` varchar(50) NOT NULL,
  `Cmp_Fecha_Pago` date NOT NULL,
  `Cmp_Tipo_Pago` varchar(50) NOT NULL,
  `Cmp_Monto_Pagado` float NOT NULL DEFAULT '0',
  `Cmp_Saldo_Pendiente` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`Pk_Id_Cuenta_Por_Cobrar_Detalle`),
  KEY `Fk_Id_Cuenta_Por_Cobrar` (`Fk_Id_Cuenta_Por_Cobrar`),
  KEY `Fk_Id_Tipo_Operacion` (`Fk_Id_Tipo_Operacion`),
  CONSTRAINT `tbl_cuentas_por_cobrar_detalle_ibfk_1` FOREIGN KEY (`Fk_Id_Cuenta_Por_Cobrar`) REFERENCES `tbl_cuentas_por_cobrar` (`Pk_Id_Cuenta_Por_Cobrar`),
  CONSTRAINT `tbl_cuentas_por_cobrar_detalle_ibfk_2` FOREIGN KEY (`Fk_Id_Tipo_Operacion`) REFERENCES `tbl_tipo_operacion_cxc` (`pk_tipo_operacion_cxc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas_por_cobrar_detalle`
--

LOCK TABLES `tbl_cuentas_por_cobrar_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas_por_cobrar_detalle` DISABLE KEYS */;
INSERT INTO `tbl_cuentas_por_cobrar_detalle` VALUES (1,9,5,'RCP-20260507-I9A0NP','2026-05-07','Efectivo',45,0),(2,10,5,'RCP-20260507-RR3NJB','2026-05-07','Efectivo',45,0);
/*!40000 ALTER TABLE `tbl_cuentas_por_cobrar_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuentas_por_pagar`
--

DROP TABLE IF EXISTS `tbl_cuentas_por_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas_por_pagar` (
  `pk_id_cuenta_por_pagar` int NOT NULL AUTO_INCREMENT,
  `fk_id_compra` int NOT NULL,
  `cmp_fecha_deuda` datetime NOT NULL,
  `cmp_fecha_vencimiento` datetime DEFAULT NULL,
  `cmp_monto_total` float NOT NULL,
  `cmp_estado` enum('pendiente','parcial','pagado','devuelto') DEFAULT 'pendiente',
  PRIMARY KEY (`pk_id_cuenta_por_pagar`),
  UNIQUE KEY `uk_fk_id_compra` (`fk_id_compra`),
  KEY `fk_id_compra` (`fk_id_compra`),
  CONSTRAINT `tbl_cuentas_por_pagar_ibfk_1` FOREIGN KEY (`fk_id_compra`) REFERENCES `tbl_compra` (`pk_id_compra`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=3005 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas_por_pagar`
--

LOCK TABLES `tbl_cuentas_por_pagar` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar` DISABLE KEYS */;
INSERT INTO `tbl_cuentas_por_pagar` VALUES (3001,2001,'2026-04-01 10:00:00','2026-05-01 00:00:00',1500,'parcial'),(3002,2002,'2026-04-05 11:30:00','2026-04-20 00:00:00',850,'parcial'),(3003,2003,'2026-04-10 09:15:00',NULL,2300,'pagado'),(3004,2004,'2026-04-15 14:00:00','2026-05-30 00:00:00',3200,'pagado');
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas_por_pagar_detalle`
--

LOCK TABLES `tbl_cuentas_por_pagar_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar_detalle` DISABLE KEYS */;
INSERT INTO `tbl_cuentas_por_pagar_detalle` VALUES (1,3002,'abono','AB-001','2026-04-10',300,550),(2,3003,'pago_total','PG-001','2026-04-10',2300,0),(3,3001,'abono','123131','2026-04-28',443,1057),(4,3004,'abono','PAGO-CXP-20260428094318','2026-04-28',200,3000),(5,3004,'pago_total','PAGO-CXP-20260428094442','2026-04-28',3000,0),(6,3001,'abono','PAGO-CXP-20260428094509','2026-04-28',100,957);
/*!40000 ALTER TABLE `tbl_cuentas_por_pagar_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_compra`
--

DROP TABLE IF EXISTS `tbl_detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_compra` (
  `pk_id_detalle_compra` int NOT NULL AUTO_INCREMENT,
  `fk_id_compra` int NOT NULL,
  `fk_inventario_id` int NOT NULL,
  `fk_id_unidad` int NOT NULL,
  `cmp_cantidad` float NOT NULL,
  `cmp_precio` decimal(10,2) NOT NULL,
  PRIMARY KEY (`pk_id_detalle_compra`),
  KEY `fk_id_compra` (`fk_id_compra`),
  KEY `fk_inventario_id` (`fk_inventario_id`),
  KEY `fk_detalle_compra_unidad` (`fk_id_unidad`),
  CONSTRAINT `fk_detalle_compra_compra` FOREIGN KEY (`fk_id_compra`) REFERENCES `tbl_compra` (`pk_id_compra`) ON DELETE CASCADE,
  CONSTRAINT `fk_detalle_compra_inventario` FOREIGN KEY (`fk_inventario_id`) REFERENCES `tbl_inventario` (`pk_inventario_id`),
  CONSTRAINT `fk_detalle_compra_unidad` FOREIGN KEY (`fk_id_unidad`) REFERENCES `tbl_unidad_de_medida` (`ID_Unidad`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_compra`
--

LOCK TABLES `tbl_detalle_compra` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_compra` DISABLE KEYS */;
INSERT INTO `tbl_detalle_compra` VALUES (1,2001,1,1,4,12.23);
/*!40000 ALTER TABLE `tbl_detalle_compra` ENABLE KEYS */;
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
-- Table structure for table `tbl_detalle_orden_compra`
--

DROP TABLE IF EXISTS `tbl_detalle_orden_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_orden_compra` (
  `pk_id_detalle_orden_compra` int NOT NULL AUTO_INCREMENT,
  `fk_id_orden_compra` int NOT NULL,
  `fk_inventario_id` int NOT NULL,
  `fk_id_unidad` int NOT NULL,
  `cmp_cantidad` float NOT NULL,
  `cmp_precio` decimal(10,2) NOT NULL,
  PRIMARY KEY (`pk_id_detalle_orden_compra`),
  KEY `fk_id_orden_compra` (`fk_id_orden_compra`),
  KEY `fk_inventario_id` (`fk_inventario_id`),
  KEY `fk_detalle_orden_unidad` (`fk_id_unidad`),
  CONSTRAINT `fk_detalle_orden_compra` FOREIGN KEY (`fk_id_orden_compra`) REFERENCES `tbl_orden_compra` (`pk_id_orden_compra`) ON DELETE CASCADE,
  CONSTRAINT `fk_detalle_orden_inventario` FOREIGN KEY (`fk_inventario_id`) REFERENCES `tbl_inventario` (`pk_inventario_id`),
  CONSTRAINT `fk_detalle_orden_unidad` FOREIGN KEY (`fk_id_unidad`) REFERENCES `tbl_unidad_de_medida` (`ID_Unidad`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_orden_compra`
--

LOCK TABLES `tbl_detalle_orden_compra` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_orden_compra` DISABLE KEYS */;
INSERT INTO `tbl_detalle_orden_compra` VALUES (1,5,2,1,12,10.00);
/*!40000 ALTER TABLE `tbl_detalle_orden_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_ventas`
--

DROP TABLE IF EXISTS `tbl_detalle_ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_ventas` (
  `Fk_Id_Ventas` int NOT NULL,
  `Fk_Id_Inventario` int NOT NULL,
  `Cmp_Cantidad_Producto` float NOT NULL,
  `Cmp_Precio_Subtotal` float NOT NULL,
  `Cmp_Costo_Subtotal` float NOT NULL,
  PRIMARY KEY (`Fk_Id_Ventas`,`Fk_Id_Inventario`),
  KEY `Fk_Id_Inventario` (`Fk_Id_Inventario`),
  CONSTRAINT `fk_detalle_ventas_inventario` FOREIGN KEY (`Fk_Id_Inventario`) REFERENCES `tbl_inventario` (`pk_inventario_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_detalle_ventas_ventas` FOREIGN KEY (`Fk_Id_Ventas`) REFERENCES `tbl_ventas` (`Pk_Id_Ventas`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_ventas`
--

LOCK TABLES `tbl_detalle_ventas` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_ventas` DISABLE KEYS */;
INSERT INTO `tbl_detalle_ventas` VALUES (2,1,1,18.5,0),(3,2,1,14,0),(4,2,1,14,0),(5,3,2,90,0),(6,4,2,64,0),(7,4,2,64,0),(8,5,1,28,0),(9,5,2,56,0),(10,2,100,1400,0),(11,3,500,22500,0),(12,3,900,40500,0),(13,3,600,27000,0),(14,3,600,27000,0),(15,3,1,45,0),(16,3,1,45,0);
/*!40000 ALTER TABLE `tbl_detalle_ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_devoluciones`
--

DROP TABLE IF EXISTS `tbl_devoluciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_devoluciones` (
  `pk_id_devolucion` int NOT NULL AUTO_INCREMENT,
  `fk_id_compra` int NOT NULL,
  `fk_id_proveedor` int NOT NULL,
  `fk_id_cuenta_por_pagar` int DEFAULT NULL,
  `cmp_fecha_devolucion` datetime NOT NULL,
  `cmp_motivo` varchar(150) NOT NULL,
  `cmp_tipo_devolucion` enum('efectivo','credito','producto','ajuste') NOT NULL,
  `cmp_valor_monetario` decimal(12,2) NOT NULL DEFAULT '0.00',
  `cmp_estado` enum('pendiente','aplicada','anulada') NOT NULL DEFAULT 'pendiente',
  `cmp_observaciones` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`pk_id_devolucion`),
  KEY `fk_devolucion_compra` (`fk_id_compra`),
  KEY `fk_devolucion_proveedor` (`fk_id_proveedor`),
  KEY `fk_devolucion_cxp` (`fk_id_cuenta_por_pagar`),
  CONSTRAINT `fk_devolucion_compra` FOREIGN KEY (`fk_id_compra`) REFERENCES `tbl_compra` (`pk_id_compra`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_devolucion_cxp` FOREIGN KEY (`fk_id_cuenta_por_pagar`) REFERENCES `tbl_cuentas_por_pagar` (`pk_id_cuenta_por_pagar`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_devolucion_proveedor` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `tbl_proveedores` (`pk_id_proveedor`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_devoluciones`
--

LOCK TABLES `tbl_devoluciones` WRITE;
/*!40000 ALTER TABLE `tbl_devoluciones` DISABLE KEYS */;
INSERT INTO `tbl_devoluciones` VALUES (1,2001,1001,3001,'2026-04-20 10:30:00','Producto dañado en transporte','credito',300.00,'aplicada','Se aplicó crédito a la cuenta'),(2,2003,1003,3003,'2026-04-22 09:00:00','Producto defectuoso','efectivo',2300.00,'aplicada','Reembolso completo'),(3,2002,1002,3002,'2026-04-25 14:15:00','Error en cantidad enviada','ajuste',150.00,'pendiente','Pendiente de aplicar en sistema'),(4,2004,1001,3004,'2026-04-26 11:00:00','Producto equivocado','producto',500.00,'aplicada','Se reemplazó por producto correcto');
/*!40000 ALTER TABLE `tbl_devoluciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_devoluciones_detalle`
--

DROP TABLE IF EXISTS `tbl_devoluciones_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_devoluciones_detalle` (
  `pk_id_devolucion_detalle` int NOT NULL AUTO_INCREMENT,
  `fk_id_devolucion` int NOT NULL,
  `fk_id_detalle_compra` int NOT NULL,
  `fk_inventario_id` int NOT NULL,
  `cmp_cantidad_devuelta` int NOT NULL,
  `cmp_precio_unitario` decimal(12,2) NOT NULL,
  `cmp_subtotal` decimal(12,2) NOT NULL,
  `cmp_observacion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`pk_id_devolucion_detalle`),
  KEY `fk_dev_det_devolucion` (`fk_id_devolucion`),
  KEY `fk_dev_det_detalle_compra` (`fk_id_detalle_compra`),
  KEY `fk_dev_det_inventario` (`fk_inventario_id`),
  CONSTRAINT `fk_dev_det_detalle_compra` FOREIGN KEY (`fk_id_detalle_compra`) REFERENCES `tbl_detalle_compra` (`pk_id_detalle_compra`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_dev_det_devolucion` FOREIGN KEY (`fk_id_devolucion`) REFERENCES `tbl_devoluciones` (`pk_id_devolucion`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_dev_det_inventario` FOREIGN KEY (`fk_inventario_id`) REFERENCES `tbl_inventario` (`pk_inventario_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_devoluciones_detalle`
--

LOCK TABLES `tbl_devoluciones_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_devoluciones_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_devoluciones_detalle` ENABLE KEYS */;
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
-- Table structure for table `tbl_entrega_compra`
--

DROP TABLE IF EXISTS `tbl_entrega_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_entrega_compra` (
  `Pk_Id_Entrega_Compra` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Compra` int DEFAULT NULL,
  `Fk_Id_Transporte` int DEFAULT NULL,
  `Cmp_Direccion` varchar(100) DEFAULT NULL,
  `Cmp_Fecha` datetime DEFAULT NULL,
  `Cmp_Estado_Entrega` enum('Pendiente','En_Camino','Entregado') DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Entrega_Compra`),
  UNIQUE KEY `Unique_OrdenCompra` (`Fk_Id_Compra`),
  KEY `Fk_EntregaCompra_Transporte` (`Fk_Id_Transporte`),
  CONSTRAINT `Fk_EntregaCompra` FOREIGN KEY (`Fk_Id_Compra`) REFERENCES `tbl_compra` (`pk_id_compra`),
  CONSTRAINT `Fk_EntregaCompra_Transporte` FOREIGN KEY (`Fk_Id_Transporte`) REFERENCES `tbl_tipo_transporte` (`Pk_Id_Transporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_entrega_compra`
--

LOCK TABLES `tbl_entrega_compra` WRITE;
/*!40000 ALTER TABLE `tbl_entrega_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_entrega_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_entrega_produccion`
--

DROP TABLE IF EXISTS `tbl_entrega_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_entrega_produccion` (
  `Pk_Id_Entrega_Produccion` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_OrdenP` int DEFAULT NULL,
  `Fk_Id_Transporte` int DEFAULT NULL,
  `Cmp_Direccion` varchar(100) DEFAULT NULL,
  `Cmp_Fecha` datetime DEFAULT NULL,
  `Cmp_Estado_Entrega` enum('Pendiente','En_Camino','Entregado') DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Entrega_Produccion`),
  UNIQUE KEY `Unique_OrdenProduccion` (`Fk_Id_OrdenP`),
  KEY `Fk_EntregaProduccion_Transporte` (`Fk_Id_Transporte`),
  CONSTRAINT `Fk_EntregaProduccion_Orden` FOREIGN KEY (`Fk_Id_OrdenP`) REFERENCES `tbl_orden_produccion_encabezado` (`Pk_ID_OrdenProduccion`),
  CONSTRAINT `Fk_EntregaProduccion_Transporte` FOREIGN KEY (`Fk_Id_Transporte`) REFERENCES `tbl_tipo_transporte` (`Pk_Id_Transporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_entrega_produccion`
--

LOCK TABLES `tbl_entrega_produccion` WRITE;
/*!40000 ALTER TABLE `tbl_entrega_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_entrega_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_entrega_venta`
--

DROP TABLE IF EXISTS `tbl_entrega_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_entrega_venta` (
  `Pk_Id_Entrega_Venta` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Venta` int DEFAULT NULL,
  `Fk_Id_Transporte` int DEFAULT NULL,
  `Cmp_Direccion` varchar(100) DEFAULT NULL,
  `Cmp_Fecha` datetime DEFAULT NULL,
  `Cmp_Estado_Entrega` enum('Pendiente','En_Camino','Entregado') DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Entrega_Venta`),
  UNIQUE KEY `Unique_Venta` (`Fk_Id_Venta`),
  KEY `Fk_EntregaVenta_Transporte` (`Fk_Id_Transporte`),
  CONSTRAINT `Fk_EntregaVenta_Transporte` FOREIGN KEY (`Fk_Id_Transporte`) REFERENCES `tbl_tipo_transporte` (`Pk_Id_Transporte`),
  CONSTRAINT `Fk_EntregaVenta_Venta` FOREIGN KEY (`Fk_Id_Venta`) REFERENCES `tbl_ventas` (`Pk_Id_Ventas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_entrega_venta`
--

LOCK TABLES `tbl_entrega_venta` WRITE;
/*!40000 ALTER TABLE `tbl_entrega_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_entrega_venta` ENABLE KEYS */;
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
  `Stock_Apartado` float DEFAULT NULL,
  `estado_existencia` int DEFAULT NULL,
  `fk_id_unidad_medida` int DEFAULT NULL,
  PRIMARY KEY (`fk_inventario_id`,`fk_bodega_id`),
  KEY `fk_bodegas_inventario` (`fk_bodega_id`),
  KEY `FK_existencias_unidad` (`fk_id_unidad_medida`),
  CONSTRAINT `fk_bodegas_inventario` FOREIGN KEY (`fk_bodega_id`) REFERENCES `tbl_bodega` (`Pk_Id_Bodega`),
  CONSTRAINT `fk_existencias_inventario` FOREIGN KEY (`fk_inventario_id`) REFERENCES `tbl_inventario` (`pk_inventario_id`),
  CONSTRAINT `FK_existencias_unidad` FOREIGN KEY (`fk_id_unidad_medida`) REFERENCES `tbl_unidad_de_medida` (`ID_Unidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_existencias`
--

LOCK TABLES `tbl_existencias` WRITE;
/*!40000 ALTER TABLE `tbl_existencias` DISABLE KEYS */;
INSERT INTO `tbl_existencias` VALUES (1,1,150,NULL,1,3),(2,1,100,NULL,1,3),(3,2,0,NULL,2,4),(3,3,345,153,1,4),(4,3,80,NULL,1,4),(5,4,0,98,1,2);
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
INSERT INTO `tbl_movimiento_inventario_detalle` VALUES (1,1,50),(2,2,30),(3,3,100),(4,4,10),(5,5,5),(6,3,3),(6,4,5),(7,2,6),(7,3,2),(10,3,500),(11,2,100),(12,3,500),(13,3,900),(14,3,600),(15,3,600),(16,3,600),(17,4,900),(18,4,900),(19,4,900),(20,4,900),(21,3,300),(21,4,900),(22,4,600),(23,4,600),(24,4,600),(25,4,600),(26,2,600),(27,5,22),(29,3,153),(29,5,98),(30,3,1),(31,3,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimiento_inventario_encabezado`
--

LOCK TABLES `tbl_movimiento_inventario_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_movimiento_inventario_encabezado` DISABLE KEYS */;
INSERT INTO `tbl_movimiento_inventario_encabezado` VALUES (1,1,'2025-01-10 08:00:00','Compra inicial de inventario'),(2,2,'2025-01-11 10:30:00','Venta a cliente mayorista'),(3,1,'2025-01-12 09:15:00','Reabastecimiento bodega norte'),(4,3,'2025-01-13 14:00:00','Devolución de producto dañado'),(5,5,'2025-01-14 16:45:00','Ajuste por merma'),(6,4,'2026-04-21 09:07:34','Inserción'),(7,3,'2026-04-21 09:35:07','Descripcion'),(10,2,'2026-04-28 10:03:32','movimiento'),(11,3,'2026-05-01 00:00:00','Venta'),(12,3,'2026-05-01 00:00:00','Venta'),(13,3,'2026-05-01 00:00:00','Venta'),(14,3,'2026-05-01 00:00:00','Venta'),(15,3,'2026-05-01 00:00:00','Venta'),(16,3,'2026-05-01 00:00:00','Venta'),(17,1,'2026-05-05 20:22:43','Apartado'),(18,1,'2026-05-05 20:22:43','Apartado'),(19,1,'2026-05-05 20:22:43','Apartado'),(20,1,'2026-05-05 20:22:43','Apartado'),(21,2,'2026-05-21 20:22:43','Apartado'),(22,2,'2026-05-05 20:31:21','Apartado'),(23,2,'2026-05-05 20:31:21','Apartado'),(24,2,'2026-05-05 20:31:21','Apartado'),(25,2,'2026-05-05 20:31:21','Apartado'),(26,2,'2026-05-05 20:35:44','prueba apartado'),(27,2,'2026-05-05 20:44:18','Prueba entrada 8:45'),(29,2,'2026-05-05 00:00:00','prueba apartado'),(30,3,'2026-05-01 00:00:00','Venta'),(31,3,'2026-05-01 00:00:00','Venta');
/*!40000 ALTER TABLE `tbl_movimiento_inventario_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_orden_compra`
--

DROP TABLE IF EXISTS `tbl_orden_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_orden_compra` (
  `pk_id_orden_compra` int NOT NULL AUTO_INCREMENT,
  `fk_id_proveedor` int NOT NULL,
  `fk_id_bodega` int NOT NULL,
  `cmp_numero` varchar(50) NOT NULL,
  `cmp_fecha` datetime NOT NULL,
  `cmp_fecha_entrega` datetime DEFAULT NULL,
  `cmp_tipo_pago` enum('contado','credito') NOT NULL,
  `cmp_dias_credito` int DEFAULT '0',
  `cmp_subtotal` decimal(12,2) NOT NULL,
  `cmp_total` decimal(12,2) NOT NULL,
  `cmp_estado` enum('pendiente','aprobada','recibida','cancelada') DEFAULT 'pendiente',
  PRIMARY KEY (`pk_id_orden_compra`),
  KEY `fk_id_proveedor` (`fk_id_proveedor`),
  KEY `fk_id_bodega` (`fk_id_bodega`),
  CONSTRAINT `fk_orden_bodega` FOREIGN KEY (`fk_id_bodega`) REFERENCES `tbl_bodega` (`Pk_Id_Bodega`),
  CONSTRAINT `Tbl_orden_compra_ibfk_1` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `tbl_proveedores` (`pk_id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_orden_compra`
--

LOCK TABLES `tbl_orden_compra` WRITE;
/*!40000 ALTER TABLE `tbl_orden_compra` DISABLE KEYS */;
INSERT INTO `tbl_orden_compra` VALUES (1,1001,1,'OC-001','2026-03-25 08:00:00','2026-04-01 00:00:00','credito',30,1500.00,1500.00,'recibida'),(2,1002,1,'OC-002','2026-03-30 09:00:00','2026-04-05 00:00:00','credito',15,850.00,850.00,'recibida'),(3,1003,2,'OC-003','2026-04-05 10:00:00','2026-04-10 00:00:00','contado',0,2300.00,2300.00,'recibida'),(4,1001,2,'OC-004','2026-04-10 11:00:00','2026-04-15 00:00:00','credito',45,3200.00,3200.00,'recibida'),(5,1002,3,'OC-005','2026-05-05 09:54:22','2026-05-05 09:54:22','contado',0,120.00,120.00,'pendiente');
/*!40000 ALTER TABLE `tbl_orden_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_orden_produccion_detalle`
--

DROP TABLE IF EXISTS `tbl_orden_produccion_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_orden_produccion_detalle` (
  `Pk_ID_DetalleProduccion` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_OrdenProduccion` int NOT NULL,
  `Fk_ID_Producto` int NOT NULL,
  `Cmp_Cantidad_Solicitada` int NOT NULL,
  `Cmp_Cantidad_Recibida` int DEFAULT '0',
  PRIMARY KEY (`Pk_ID_DetalleProduccion`),
  KEY `Fk_ID_OrdenProduccion` (`Fk_ID_OrdenProduccion`),
  KEY `Fk_ID_Producto` (`Fk_ID_Producto`),
  CONSTRAINT `tbl_orden_produccion_detalle_ibfk_1` FOREIGN KEY (`Fk_ID_OrdenProduccion`) REFERENCES `tbl_orden_produccion_encabezado` (`Pk_ID_OrdenProduccion`),
  CONSTRAINT `tbl_orden_produccion_detalle_ibfk_2` FOREIGN KEY (`Fk_ID_Producto`) REFERENCES `tbl_inventario` (`pk_inventario_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_orden_produccion_detalle`
--

LOCK TABLES `tbl_orden_produccion_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_orden_produccion_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_orden_produccion_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_orden_produccion_encabezado`
--

DROP TABLE IF EXISTS `tbl_orden_produccion_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_orden_produccion_encabezado` (
  `Pk_ID_OrdenProduccion` int NOT NULL AUTO_INCREMENT,
  `Fk_ID_Vendedor` int NOT NULL,
  `Cmp_Fecha_Emision` date NOT NULL,
  `Cmp_Estado` enum('Emitida','En Proceso','Finalizada','Recibida','Cancelada') NOT NULL DEFAULT 'Emitida',
  `Cmp_Fecha_Estimada_Entrega` date NOT NULL,
  PRIMARY KEY (`Pk_ID_OrdenProduccion`),
  KEY `Fk_ID_Vendedor` (`Fk_ID_Vendedor`),
  CONSTRAINT `tbl_orden_produccion_encabezado_ibfk_1` FOREIGN KEY (`Fk_ID_Vendedor`) REFERENCES `tbl_vendedor` (`Pk_Id_Vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_orden_produccion_encabezado`
--

LOCK TABLES `tbl_orden_produccion_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_orden_produccion_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_orden_produccion_encabezado` ENABLE KEYS */;
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
INSERT INTO `tbl_permiso_usuario_aplicacion` VALUES (4,4,301,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,302,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,303,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,304,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,305,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,306,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,307,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,308,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,4,309,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,700,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,701,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,702,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,703,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,704,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,705,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,706,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,707,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,708,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,709,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,710,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,711,_binary '',_binary '',_binary '',_binary '\0',_binary ''),(4,44,712,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,713,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,714,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,715,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,716,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,717,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,718,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,719,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,720,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,721,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,722,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,723,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,724,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,726,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,727,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,728,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,729,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,730,_binary '',_binary '',_binary '',_binary '',_binary ''),(4,44,731,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,301,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,302,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,303,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,304,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,305,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,306,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,307,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,308,_binary '',_binary '',_binary '',_binary '',_binary ''),(23,4,309,_binary '',_binary '',_binary '',_binary '',_binary '');
/*!40000 ALTER TABLE `tbl_permiso_usuario_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_politicas_descuento`
--

DROP TABLE IF EXISTS `tbl_politicas_descuento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_politicas_descuento` (
  `Pk_Id_Politica` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Tipo_Cliente` int NOT NULL,
  `Cmp_Cantidad_Min` int NOT NULL,
  `Cmp_Cantidad_Max` int NOT NULL,
  `Cmp_Descuento` float NOT NULL,
  `Cmp_Estado_politicas_Desc` enum('Activo','Inactivo') NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Politica`),
  KEY `fk_politica_tipo_idx` (`Fk_Id_Tipo_Cliente`),
  CONSTRAINT `fk_politica_tipo` FOREIGN KEY (`Fk_Id_Tipo_Cliente`) REFERENCES `tbl_tipo_cliente` (`Pk_Id_Tipo_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_politicas_descuento`
--

LOCK TABLES `tbl_politicas_descuento` WRITE;
/*!40000 ALTER TABLE `tbl_politicas_descuento` DISABLE KEYS */;
INSERT INTO `tbl_politicas_descuento` VALUES (1,1,1,11,0,'Activo'),(2,2,12,47,0.15,'Activo'),(3,3,48,9999,0.25,'Activo');
/*!40000 ALTER TABLE `tbl_politicas_descuento` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=1004 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedores`
--

LOCK TABLES `tbl_proveedores` WRITE;
/*!40000 ALTER TABLE `tbl_proveedores` DISABLE KEYS */;
INSERT INTO `tbl_proveedores` VALUES (1001,'Distribuidora Central GT','Zona 1 Guatemala','5555-1111','centralgt@correo.com','Proveedor de abarrotes','activo'),(1002,'Suministros Industriales S.A.','Mixco','5555-2222','suministros@correo.com','Proveedor industrial','activo'),(1003,'Tecnología y Servicios GT','Zona 10 Guatemala','5555-3333','tecnologia@correo.com','Proveedor tecnológico','activo');
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
-- Table structure for table `tbl_sucursales`
--

DROP TABLE IF EXISTS `tbl_sucursales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_sucursales` (
  `Pk_Id_Sucursal` int NOT NULL AUTO_INCREMENT,
  `Cmp_Numero_Serie` varchar(50) NOT NULL,
  `Cmp_Direccion` varchar(150) NOT NULL,
  `Cmp_Estado_Sucursal` enum('Activo','Inactivo') DEFAULT 'Activo',
  PRIMARY KEY (`Pk_Id_Sucursal`),
  UNIQUE KEY `Cmp_Numero_Serie` (`Cmp_Numero_Serie`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_sucursales`
--

LOCK TABLES `tbl_sucursales` WRITE;
/*!40000 ALTER TABLE `tbl_sucursales` DISABLE KEYS */;
INSERT INTO `tbl_sucursales` VALUES (1,'102120','zona 18 ','Activo');
/*!40000 ALTER TABLE `tbl_sucursales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_cliente`
--

DROP TABLE IF EXISTS `tbl_tipo_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_cliente` (
  `Pk_Id_Tipo_Cliente` int NOT NULL AUTO_INCREMENT,
  `Cmp_Tipo` varchar(50) NOT NULL,
  `Cmp_Descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Tipo_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_cliente`
--

LOCK TABLES `tbl_tipo_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_cliente` DISABLE KEYS */;
INSERT INTO `tbl_tipo_cliente` VALUES (1,'Público','Cliente ocasional de venta al detalle'),(2,'Mayorista','Cliente con precios especiales por volumen'),(3,'Distribuidor','Cliente de alto volumen con precios de fábrica');
/*!40000 ALTER TABLE `tbl_tipo_cliente` ENABLE KEYS */;
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
INSERT INTO `tbl_tipo_operacion_cxc` VALUES (1,'Pago Tarjeta','ENTRADA','ACTIVO'),(2,'Pago Bitcoin','ENTRADA','ACTIVO'),(3,'Cheque','ENTRADA','INACTIVO'),(4,'Prueba','SALIDA','ACTIVO'),(5,'Efectivo','ENTRADA','ACTIVO');
/*!40000 ALTER TABLE `tbl_tipo_operacion_cxc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipo_transporte`
--

DROP TABLE IF EXISTS `tbl_tipo_transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tipo_transporte` (
  `Pk_Id_Transporte` int NOT NULL AUTO_INCREMENT,
  `Fk_Id_Empresa` int DEFAULT NULL,
  `Cmp_Tipo_Transporte` varchar(50) DEFAULT NULL,
  `Cmp_Placa` varchar(15) DEFAULT NULL,
  `Cmp_Nombre_Piloto` varchar(100) DEFAULT NULL,
  `Cmp_Capacidad` int DEFAULT NULL,
  `Cmp_Estado_Transporte` enum('Disponible','Ocupado','Mantenimiento') DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Transporte`),
  KEY `Fk_Transporte_Empresa` (`Fk_Id_Empresa`),
  CONSTRAINT `Fk_Transporte_Empresa` FOREIGN KEY (`Fk_Id_Empresa`) REFERENCES `tbl_empresa_transporte` (`pk_id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tipo_transporte`
--

LOCK TABLES `tbl_tipo_transporte` WRITE;
/*!40000 ALTER TABLE `tbl_tipo_transporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tipo_transporte` ENABLE KEYS */;
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
-- Table structure for table `tbl_unidad_de_medida`
--

DROP TABLE IF EXISTS `tbl_unidad_de_medida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_unidad_de_medida` (
  `ID_Unidad` int NOT NULL AUTO_INCREMENT,
  `Nombre_Unidad` varchar(100) NOT NULL,
  `Abreviacion_Medida` varchar(20) NOT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  `Estado_Medida` enum('Activo','Inactivo') NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`ID_Unidad`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_unidad_de_medida`
--

LOCK TABLES `tbl_unidad_de_medida` WRITE;
/*!40000 ALTER TABLE `tbl_unidad_de_medida` DISABLE KEYS */;
INSERT INTO `tbl_unidad_de_medida` VALUES (1,'Galon','GL','Galon','Activo'),(2,'Libra','LB','Libra','Activo'),(3,'Litro','LT','Litro','Activo'),(4,'Kilogramo','KG','Kilogramo','Activo');
/*!40000 ALTER TABLE `tbl_unidad_de_medida` ENABLE KEYS */;
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

--
-- Table structure for table `tbl_ventas`
--

DROP TABLE IF EXISTS `tbl_ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_ventas` (
  `Pk_Id_Ventas` int NOT NULL AUTO_INCREMENT,
  `Cmp_Fecha_Venta` datetime NOT NULL,
  `Fk_Id_Cliente` int NOT NULL,
  `Fk_Id_Sucursal` int NOT NULL,
  `Cmp_Estado_Venta` varchar(50) NOT NULL DEFAULT 'Activo',
  `Cmp_Saldo_Total` float NOT NULL DEFAULT '0',
  `Cmp_Tipo_Operacion` enum('Venta','Cotizacion','Pedido') NOT NULL DEFAULT 'Cotizacion',
  `Cmp_Fecha_Vencimiento` datetime DEFAULT NULL,
  `Cmp_Fecha_Entrega` datetime DEFAULT NULL,
  PRIMARY KEY (`Pk_Id_Ventas`),
  KEY `Fk_Id_Cliente` (`Fk_Id_Cliente`),
  KEY `Fk_Id_Sucursal` (`Fk_Id_Sucursal`),
  CONSTRAINT `fk_ventas_cliente` FOREIGN KEY (`Fk_Id_Cliente`) REFERENCES `tbl_clientes` (`Pk_Id_Cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ventas_sucursal` FOREIGN KEY (`Fk_Id_Sucursal`) REFERENCES `tbl_sucursales` (`Pk_Id_Sucursal`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ventas`
--

LOCK TABLES `tbl_ventas` WRITE;
/*!40000 ALTER TABLE `tbl_ventas` DISABLE KEYS */;
INSERT INTO `tbl_ventas` VALUES (2,'2026-04-30 23:38:02',1,1,'Activo',18.5,'Venta',NULL,NULL),(3,'2026-04-24 23:38:02',1,1,'Activo',14,'Cotizacion',NULL,NULL),(4,'2026-04-30 23:38:02',1,1,'Activo',14,'Cotizacion',NULL,NULL),(5,'2026-04-30 23:38:02',1,1,'Activo',90,'Venta',NULL,NULL),(6,'2026-04-30 23:38:02',1,1,'Activo',64,'Cotizacion',NULL,'2026-05-02 23:38:02'),(7,'2026-04-30 23:38:02',1,1,'Activo',64,'Cotizacion','2026-10-16 23:38:02',NULL),(8,'2026-04-30 23:38:02',1,1,'Activo',28,'Pedido',NULL,'2026-10-16 23:38:02'),(9,'2026-04-30 23:38:02',1,1,'Activo',56,'Venta',NULL,NULL),(10,'2026-05-01 00:00:00',1,1,'Activo',1400,'Venta',NULL,NULL),(11,'2026-05-01 00:00:00',1,1,'Activo',22500,'Venta',NULL,NULL),(12,'2026-05-01 00:00:00',1,1,'Activo',40500,'Venta',NULL,NULL),(13,'2026-05-01 00:00:00',1,1,'Activo',27000,'Venta',NULL,NULL),(14,'2026-05-01 00:00:00',1,1,'Activo',27000,'Venta',NULL,NULL),(15,'2026-05-01 00:00:00',2,1,'0',45,'Venta',NULL,NULL),(16,'2026-05-01 00:00:00',1,1,'0',45,'Venta',NULL,NULL);
/*!40000 ALTER TABLE `tbl_ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-07 20:36:50
