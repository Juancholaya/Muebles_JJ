CREATE DATABASE  IF NOT EXISTS `muebles_jj` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `muebles_jj`;
-- MariaDB dump 10.17  Distrib 10.4.14-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: muebles_jj
-- ------------------------------------------------------
-- Server version	10.4.14-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cantidad_insumo`
--

DROP TABLE IF EXISTS `cantidad_insumo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cantidad_insumo` (
  `ID_Cantidad` int(2) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(30) DEFAULT NULL,
  `Cantidad` int(10) DEFAULT NULL,
  PRIMARY KEY (`ID_Cantidad`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cantidad_insumo`
--

LOCK TABLES `cantidad_insumo` WRITE;
/*!40000 ALTER TABLE `cantidad_insumo` DISABLE KEYS */;
INSERT INTO `cantidad_insumo` VALUES (1,'Centimetros',1),(2,'Centimetros',10),(3,'Centimetros',100),(4,'Centimetros',1000),(5,'Metros',1),(6,'Metros',10),(7,'Metros',100),(8,'Mililitros',1),(9,'Mililitros',10),(10,'Mililitros',100),(11,'Mililitros',1000),(12,'Litros',1),(13,'Litros',10),(14,'Cajas',1),(15,'Cajas',5),(16,'Cajas',10),(17,'Cajas',15),(18,'Cajas',20),(19,'Cajas',25),(20,'Kilos',1),(21,'Kilos',10),(22,'Kilos',100),(23,'Unidad',1),(24,'Unidad',2),(25,'Unidad',3),(26,'Unidad',4),(27,'Unidad',5),(28,'Unidad',10),(29,'Unidad',100),(30,'Unidad',1000);
/*!40000 ALTER TABLE `cantidad_insumo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `color_producto`
--

DROP TABLE IF EXISTS `color_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `color_producto` (
  `ID_Color` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Color`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `color_producto`
--

LOCK TABLES `color_producto` WRITE;
/*!40000 ALTER TABLE `color_producto` DISABLE KEYS */;
INSERT INTO `color_producto` VALUES (1,'Negro'),(2,'Blanco'),(3,'Rojo'),(4,'Amarillo'),(5,'Azul'),(6,'Café'),(7,'Gris'),(8,'Verde'),(9,'Rosado'),(10,'Violeta');
/*!40000 ALTER TABLE `color_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comprobante_pago`
--

DROP TABLE IF EXISTS `comprobante_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comprobante_pago` (
  `ID_Comprobante` int(2) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  `ID_Venta_FK` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_Comprobante`),
  KEY `ID_Venta_FK` (`ID_Venta_FK`),
  CONSTRAINT `comprobante_pago_ibfk_1` FOREIGN KEY (`ID_Venta_FK`) REFERENCES `venta` (`ID_Venta`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comprobante_pago`
--

LOCK TABLES `comprobante_pago` WRITE;
/*!40000 ALTER TABLE `comprobante_pago` DISABLE KEYS */;
INSERT INTO `comprobante_pago` VALUES (1,'2020-11-05 00:00:00',100),(2,'2020-11-06 00:00:00',99),(3,'2020-11-07 00:00:00',98),(4,'2020-11-08 00:00:00',97),(5,'2020-11-09 00:00:00',96),(6,'2020-11-10 00:00:00',95),(7,'2020-11-11 00:00:00',94),(8,'2020-11-12 00:00:00',93),(9,'2020-11-13 00:00:00',92),(10,'2020-11-14 00:00:00',91),(11,'2020-11-15 00:00:00',90),(12,'2020-11-16 00:00:00',89),(13,'2020-11-17 00:00:00',88),(14,'2020-11-18 00:00:00',87),(15,'2020-11-19 00:00:00',86),(16,'2020-11-20 00:00:00',85),(17,'2020-11-21 00:00:00',84),(18,'2020-11-22 00:00:00',83),(19,'2020-11-23 00:00:00',82),(20,'2020-11-24 00:00:00',81),(21,'2020-11-25 00:00:00',80),(22,'2020-11-26 00:00:00',79),(23,'2020-11-27 00:00:00',78),(24,'2020-11-28 00:00:00',77),(25,'2020-11-29 00:00:00',76),(26,'2020-11-30 00:00:00',75),(27,'2020-12-01 00:00:00',74),(28,'2020-12-02 00:00:00',73),(29,'2020-12-03 00:00:00',72),(30,'2020-12-04 00:00:00',71),(31,'2020-12-05 00:00:00',70),(32,'2020-12-06 00:00:00',69),(33,'2020-12-07 00:00:00',68),(34,'2020-12-08 00:00:00',67),(35,'2020-12-09 00:00:00',66),(36,'2020-12-10 00:00:00',65),(37,'2020-12-11 00:00:00',64),(38,'2020-12-12 00:00:00',63),(39,'2020-12-13 00:00:00',62),(40,'2020-12-14 00:00:00',61),(41,'2020-12-15 00:00:00',60),(42,'2020-12-16 00:00:00',59),(43,'2020-12-17 00:00:00',58),(44,'2020-12-18 00:00:00',57),(45,'2020-12-19 00:00:00',56),(46,'2020-12-20 00:00:00',55),(47,'2020-12-21 00:00:00',54),(48,'2020-12-22 00:00:00',53),(49,'2020-12-23 00:00:00',52),(50,'2020-12-24 00:00:00',51),(51,'2020-12-25 00:00:00',50),(52,'2020-12-26 00:00:00',49),(53,'2020-12-27 00:00:00',48),(54,'2020-12-28 00:00:00',47),(55,'2020-12-29 00:00:00',46),(56,'2020-12-30 00:00:00',45),(57,'2020-12-31 00:00:00',44),(58,'2021-01-01 00:00:00',43),(59,'2021-01-02 00:00:00',42),(60,'2021-01-03 00:00:00',41),(61,'2021-01-04 00:00:00',40),(62,'2021-01-05 00:00:00',39),(63,'2021-01-06 00:00:00',38),(64,'2021-01-07 00:00:00',37),(65,'2021-01-08 00:00:00',36),(66,'2021-01-09 00:00:00',35),(67,'2021-01-10 00:00:00',34),(68,'2021-01-11 00:00:00',33),(69,'2021-01-12 00:00:00',32),(70,'2021-01-13 00:00:00',31),(71,'2021-01-14 00:00:00',30),(72,'2021-01-15 00:00:00',29),(73,'2021-01-16 00:00:00',28),(74,'2021-01-17 00:00:00',27),(75,'2021-01-18 00:00:00',26),(76,'2021-01-19 00:00:00',25),(77,'2021-01-20 00:00:00',24),(78,'2021-01-21 00:00:00',23),(79,'2021-01-22 00:00:00',22),(80,'2021-01-23 00:00:00',21),(81,'2021-01-24 00:00:00',20),(82,'2021-01-25 00:00:00',19),(83,'2021-01-26 00:00:00',18),(84,'2021-01-27 00:00:00',17),(85,'2021-01-28 00:00:00',16),(86,'2021-01-29 00:00:00',15),(87,'2021-01-30 00:00:00',14),(88,'2021-02-01 00:00:00',13),(89,'2021-02-02 00:00:00',12),(90,'2021-02-03 00:00:00',11),(91,'2021-02-04 00:00:00',10),(92,'2021-02-05 00:00:00',9),(93,'2021-02-06 00:00:00',8),(94,'2021-02-07 00:00:00',7),(95,'2021-02-08 00:00:00',6),(96,'2021-02-09 00:00:00',5),(97,'2021-02-10 00:00:00',4),(98,'2021-02-11 00:00:00',3),(99,'2021-02-12 00:00:00',2),(100,'2021-02-13 00:00:00',1);
/*!40000 ALTER TABLE `comprobante_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documento`
--

DROP TABLE IF EXISTS `documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `documento` (
  `ID_Documento` int(1) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Documento`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documento`
--

LOCK TABLES `documento` WRITE;
/*!40000 ALTER TABLE `documento` DISABLE KEYS */;
INSERT INTO `documento` VALUES (1,'Cedula Ciudadania'),(2,'Cedula Extranjeria'),(3,'Pasaporte'),(4,'NIT'),(5,'Tarjeta Identidad');
/*!40000 ALTER TABLE `documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `insumo`
--

DROP TABLE IF EXISTS `insumo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `insumo` (
  `ID_Insumo` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) DEFAULT NULL,
  `ID_Cantidad_FK` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_Insumo`),
  KEY `ID_Cantidad_FK` (`ID_Cantidad_FK`),
  CONSTRAINT `insumo_ibfk_1` FOREIGN KEY (`ID_Cantidad_FK`) REFERENCES `cantidad_insumo` (`ID_Cantidad`)
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insumo`
--

LOCK TABLES `insumo` WRITE;
/*!40000 ALTER TABLE `insumo` DISABLE KEYS */;
INSERT INTO `insumo` VALUES (1,'Cuero',1),(2,'Cuero',2),(3,'Cuero',3),(4,'Cuero',4),(5,'Cuero',5),(6,'Cuero',6),(7,'Cuero',7),(8,'Tela',1),(9,'Tela',2),(10,'Tela',3),(11,'Tela',4),(12,'Tela',5),(13,'Tela',6),(14,'Tela',7),(15,'Brione',1),(16,'Brione',2),(17,'Brione',3),(18,'Brione',4),(19,'Brione',5),(20,'Brione',6),(21,'Brione',7),(22,'Acolchado',1),(23,'Acolchado',2),(24,'Acolchado',3),(25,'Acolchado',4),(26,'Acolchado',5),(27,'Acolchado',6),(28,'Acolchado',7),(29,'Pegante',8),(30,'Pegante',9),(31,'Pegante',10),(32,'Pegante',11),(33,'Pegante',12),(34,'Pegante',13),(35,'Carton',20),(36,'Carton',21),(37,'Carton',22),(38,'Cuero de Espuma',20),(39,'Cuero de Espuma',21),(40,'Cuero de Espuma',22),(41,'Espuma Continua',20),(42,'Espuma Continua',21),(43,'Espuma Continua',22),(44,'Cañamo',20),(45,'Cañamo',21),(46,'Cañamo',22),(47,'Grapas Esqueletero',14),(48,'Grapas Esqueletero',15),(49,'Grapas Esqueletero',16),(50,'Grapas Esqueletero',17),(51,'Grapas Esqueletero',18),(52,'Grapas Esqueletero',19),(53,'Grapas Tapicero',14),(54,'Grapas Tapicero',15),(55,'Grapas Tapicero',16),(56,'Grapas Tapicero',17),(57,'Grapas Tapicero',18),(58,'Grapas Tapicero',19),(59,'Tablas',23),(60,'Tablas',24),(61,'Tablas',25),(62,'Tablas',26),(63,'Tablas',27),(64,'Tablas',28),(65,'Tablas',29),(66,'Tablas',30),(67,'Patas Plasticas',23),(68,'Patas Plasticas',24),(69,'Patas Plasticas',25),(70,'Patas Plasticas',26),(71,'Patas Plasticas',27),(72,'Patas Plasticas',28),(73,'Patas Plasticas',29),(74,'Patas Plasticas',30),(75,'Tornillos',23),(76,'Tornillos',24),(77,'Tornillos',25),(78,'Tornillos',26),(79,'Tornillos',27),(80,'Tornillos',28),(81,'Tornillos',29),(82,'Tornillos',30),(83,'Casquetes',23),(84,'Casquetes',24),(85,'Casquetes',25),(86,'Casquetes',26),(87,'Casquetes',27),(88,'Casquetes',28),(89,'Casquetes',29),(90,'Casquetes',30);
/*!40000 ALTER TABLE `insumo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventario` (
  `ID_Inventario` int(2) NOT NULL AUTO_INCREMENT,
  `Fecha_Entrada` datetime DEFAULT NULL,
  `Fecha_Salida` datetime DEFAULT NULL,
  `ID_Insumo_FK` int(2) DEFAULT NULL,
  `ID_Producto_FK` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_Inventario`),
  KEY `ID_Insumo_FK` (`ID_Insumo_FK`),
  KEY `ID_Producto_FK` (`ID_Producto_FK`),
  CONSTRAINT `inventario_ibfk_1` FOREIGN KEY (`ID_Insumo_FK`) REFERENCES `insumo` (`ID_Insumo`),
  CONSTRAINT `inventario_ibfk_2` FOREIGN KEY (`ID_Producto_FK`) REFERENCES `producto` (`ID_Producto`)
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
INSERT INTO `inventario` VALUES (1,'2020-11-06 00:00:00','2020-12-08 00:00:00',1,1),(2,'2020-11-07 00:00:00','2020-12-09 00:00:00',2,2),(3,'2020-11-08 00:00:00','2020-12-10 00:00:00',3,3),(4,'2020-11-09 00:00:00','2020-12-11 00:00:00',4,4),(5,'2020-11-10 00:00:00','2020-12-12 00:00:00',5,5),(6,'2020-11-11 00:00:00','2020-12-13 00:00:00',6,6),(7,'2020-11-12 00:00:00','2020-12-14 00:00:00',7,7),(8,'2020-11-13 00:00:00','2020-12-15 00:00:00',8,8),(9,'2020-11-14 00:00:00','2020-12-16 00:00:00',9,9),(10,'2020-11-15 00:00:00','2020-12-17 00:00:00',10,10),(11,'2020-11-16 00:00:00','2020-12-18 00:00:00',11,11),(12,'2020-11-17 00:00:00','2020-12-19 00:00:00',12,12),(13,'2020-11-18 00:00:00','2020-12-20 00:00:00',13,13),(14,'2020-11-19 00:00:00','2020-12-21 00:00:00',14,14),(15,'2020-11-20 00:00:00','2020-12-22 00:00:00',15,15),(16,'2020-11-21 00:00:00','2020-12-23 00:00:00',16,16),(17,'2020-11-22 00:00:00','2020-12-24 00:00:00',17,17),(18,'2020-11-23 00:00:00','2020-12-25 00:00:00',18,18),(19,'2020-11-24 00:00:00','2020-12-26 00:00:00',19,19),(20,'2020-11-25 00:00:00','2020-12-27 00:00:00',20,20),(21,'2020-11-26 00:00:00','2020-12-28 00:00:00',21,21),(22,'2020-11-27 00:00:00','2020-12-29 00:00:00',22,22),(23,'2020-11-28 00:00:00','2020-12-30 00:00:00',23,23),(24,'2020-11-29 00:00:00','2020-12-31 00:00:00',24,24),(25,'2020-11-30 00:00:00','2021-01-01 00:00:00',25,25),(26,'2020-12-01 00:00:00','2021-01-02 00:00:00',26,26),(27,'2020-12-02 00:00:00','2021-01-03 00:00:00',27,27),(28,'2020-12-03 00:00:00','2021-01-04 00:00:00',28,28),(29,'2020-12-04 00:00:00','2021-01-05 00:00:00',29,29),(30,'2020-12-05 00:00:00','2021-01-06 00:00:00',30,30),(31,'2020-12-06 00:00:00','2021-01-07 00:00:00',31,31),(32,'2020-12-07 00:00:00','2021-01-08 00:00:00',32,32),(33,'2020-12-08 00:00:00','2021-01-09 00:00:00',33,33),(34,'2020-12-09 00:00:00','2021-01-10 00:00:00',34,34),(35,'2020-12-10 00:00:00','2021-01-11 00:00:00',35,35),(36,'2020-12-11 00:00:00','2021-01-12 00:00:00',36,36),(37,'2020-12-12 00:00:00','2021-01-13 00:00:00',37,1),(38,'2020-12-13 00:00:00','2021-01-14 00:00:00',38,2),(39,'2020-12-14 00:00:00','2021-01-15 00:00:00',39,3),(40,'2020-12-15 00:00:00','2021-01-16 00:00:00',40,4),(41,'2020-12-16 00:00:00','2021-01-17 00:00:00',41,5),(42,'2020-12-17 00:00:00','2021-01-18 00:00:00',42,6),(43,'2020-12-18 00:00:00','2021-01-19 00:00:00',43,7),(44,'2020-12-19 00:00:00','2021-01-20 00:00:00',44,8),(45,'2020-12-20 00:00:00','2021-01-21 00:00:00',45,9),(46,'2020-12-21 00:00:00','2021-01-22 00:00:00',46,10),(47,'2020-12-22 00:00:00','2021-01-23 00:00:00',47,11),(48,'2020-12-23 00:00:00','2021-01-24 00:00:00',48,12),(49,'2020-12-24 00:00:00','2021-01-25 00:00:00',49,13),(50,'2020-12-25 00:00:00','2021-01-26 00:00:00',50,14),(51,'2020-12-26 00:00:00','2021-01-27 00:00:00',51,15),(52,'2020-12-27 00:00:00','2021-01-28 00:00:00',52,16),(53,'2020-12-28 00:00:00','2021-01-29 00:00:00',53,17),(54,'2020-12-29 00:00:00','2021-01-30 00:00:00',54,18),(55,'2020-12-30 00:00:00','2021-01-31 00:00:00',55,19),(56,'2020-12-31 00:00:00','2021-02-01 00:00:00',56,20),(57,'2021-01-01 00:00:00','2021-02-02 00:00:00',57,21),(58,'2021-01-02 00:00:00','2021-02-03 00:00:00',58,22),(59,'2021-01-03 00:00:00','2021-02-04 00:00:00',59,23),(60,'2021-01-04 00:00:00','2021-02-05 00:00:00',60,24),(61,'2021-01-05 00:00:00','2021-02-06 00:00:00',61,25),(62,'2021-01-06 00:00:00','2021-02-07 00:00:00',62,26),(63,'2021-01-07 00:00:00','2021-02-08 00:00:00',63,27),(64,'2021-01-08 00:00:00','2021-02-09 00:00:00',64,28),(65,'2021-01-09 00:00:00','2021-02-10 00:00:00',65,29),(66,'2021-01-10 00:00:00','2021-02-11 00:00:00',66,30),(67,'2021-01-11 00:00:00','2021-02-12 00:00:00',67,31),(68,'2021-01-12 00:00:00','2021-02-13 00:00:00',68,32),(69,'2021-01-13 00:00:00','2021-02-14 00:00:00',69,33),(70,'2021-01-14 00:00:00','2021-02-15 00:00:00',70,34),(71,'2021-01-15 00:00:00','2021-02-16 00:00:00',71,35),(72,'2021-01-16 00:00:00','2021-02-17 00:00:00',72,36),(73,'2021-01-17 00:00:00','2021-02-18 00:00:00',73,1),(74,'2021-01-18 00:00:00','2021-02-19 00:00:00',74,2),(75,'2021-01-19 00:00:00','2021-02-20 00:00:00',75,3),(76,'2021-01-20 00:00:00','2021-02-21 00:00:00',76,4),(77,'2021-01-21 00:00:00','2021-02-22 00:00:00',77,5),(78,'2021-01-22 00:00:00','2021-02-23 00:00:00',78,6),(79,'2021-01-23 00:00:00','2021-02-24 00:00:00',79,7),(80,'2021-01-24 00:00:00','2021-02-25 00:00:00',80,8),(81,'2021-01-25 00:00:00','2021-02-26 00:00:00',81,9),(82,'2021-01-26 00:00:00','2021-02-27 00:00:00',82,10),(83,'2021-01-27 00:00:00','2021-02-28 00:00:00',83,11),(84,'2021-01-28 00:00:00','2021-03-01 00:00:00',84,12),(85,'2021-01-29 00:00:00','2021-03-02 00:00:00',85,13),(86,'2021-01-30 00:00:00','2021-03-03 00:00:00',86,14),(87,'2021-01-31 00:00:00','2021-03-04 00:00:00',87,15),(88,'2021-02-01 00:00:00','2021-03-05 00:00:00',88,16),(89,'2021-02-02 00:00:00','2021-03-06 00:00:00',89,17),(90,'2021-02-03 00:00:00','2021-03-07 00:00:00',90,18);
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material_producto`
--

DROP TABLE IF EXISTS `material_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `material_producto` (
  `ID_Material` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Material`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material_producto`
--

LOCK TABLES `material_producto` WRITE;
/*!40000 ALTER TABLE `material_producto` DISABLE KEYS */;
INSERT INTO `material_producto` VALUES (1,'Cuero Corso'),(2,'Cuero Sinterico'),(3,'Tela Bolean'),(4,'Tela Economica');
/*!40000 ALTER TABLE `material_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medida_producto`
--

DROP TABLE IF EXISTS `medida_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medida_producto` (
  `ID_Medida` int(2) NOT NULL AUTO_INCREMENT,
  `Cantidad_Centimetros` int(10) DEFAULT NULL,
  PRIMARY KEY (`ID_Medida`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medida_producto`
--

LOCK TABLES `medida_producto` WRITE;
/*!40000 ALTER TABLE `medida_producto` DISABLE KEYS */;
INSERT INTO `medida_producto` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,15),(12,20),(13,25),(14,30),(15,35),(16,40),(17,45),(18,50),(19,100),(20,150),(21,200),(22,250),(23,300),(24,350),(25,400),(26,450),(27,500),(28,1000),(29,1500),(30,2000),(31,2500),(32,3000),(33,3500),(34,4000),(35,4500),(36,5000);
/*!40000 ALTER TABLE `medida_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido` (
  `ID_Pedido` int(2) NOT NULL AUTO_INCREMENT,
  `Fecha_Entrega` datetime DEFAULT NULL,
  `Direccion_Entrega` varchar(30) DEFAULT NULL,
  `ID_Venta_FK` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_Pedido`),
  KEY `ID_Venta_FK` (`ID_Venta_FK`),
  CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`ID_Venta_FK`) REFERENCES `venta` (`ID_Venta`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,'2020-11-05 00:00:00','Calle 14 # 12-01',1),(2,'2020-11-06 00:00:00','Calle 14 # 12-02',2),(3,'2020-11-07 00:00:00','Calle 14 # 12-03',3),(4,'2020-11-08 00:00:00','Calle 14 # 12-04',4),(5,'2020-11-09 00:00:00','Calle 14 # 12-05',5),(6,'2020-11-10 00:00:00','Calle 14 # 12-06',6),(7,'2020-11-11 00:00:00','Calle 14 # 12-07',7),(8,'2020-11-12 00:00:00','Calle 14 # 12-08',8),(9,'2020-11-13 00:00:00','Calle 14 # 12-09',9),(10,'2020-11-14 00:00:00','Calle 14 # 12-10',10),(11,'2020-11-15 00:00:00','Calle 14 # 12-11',11),(12,'2020-11-16 00:00:00','Calle 14 # 12-12',12),(13,'2020-11-17 00:00:00','Calle 14 # 12-13',13),(14,'2020-11-18 00:00:00','Calle 14 # 12-14',14),(15,'2020-11-19 00:00:00','Calle 14 # 12-15',15),(16,'2020-11-20 00:00:00','Calle 14 # 12-16',16),(17,'2020-11-21 00:00:00','Calle 14 # 12-17',17),(18,'2020-11-22 00:00:00','Calle 14 # 12-18',18),(19,'2020-11-23 00:00:00','Calle 14 # 12-19',19),(20,'2020-11-24 00:00:00','Calle 14 # 12-20',20),(21,'2020-11-25 00:00:00','Calle 14 # 12-21',21),(22,'2020-11-26 00:00:00','Calle 14 # 12-22',22),(23,'2020-11-27 00:00:00','Calle 14 # 12-23',23),(24,'2020-11-28 00:00:00','Calle 14 # 12-24',24),(25,'2020-11-29 00:00:00','Calle 14 # 12-25',25),(26,'2020-11-30 00:00:00','Calle 14 # 12-26',26),(27,'2020-12-01 00:00:00','Calle 14 # 12-27',27),(28,'2020-12-02 00:00:00','Calle 14 # 12-28',28),(29,'2020-12-03 00:00:00','Calle 14 # 12-29',29),(30,'2020-12-04 00:00:00','Calle 14 # 12-30',30),(31,'2020-12-05 00:00:00','Calle 14 # 12-31',31),(32,'2020-12-06 00:00:00','Calle 14 # 12-32',32),(33,'2020-12-07 00:00:00','Calle 14 # 12-33',33),(34,'2020-12-08 00:00:00','Calle 14 # 12-34',34),(35,'2020-12-09 00:00:00','Calle 14 # 12-35',35),(36,'2020-12-10 00:00:00','Calle 14 # 12-36',36),(37,'2020-12-11 00:00:00','Calle 14 # 12-37',37),(38,'2020-12-12 00:00:00','Calle 14 # 12-38',38),(39,'2020-12-13 00:00:00','Calle 14 # 12-39',39),(40,'2020-12-14 00:00:00','Calle 14 # 12-40',40),(41,'2020-12-15 00:00:00','Calle 14 # 12-41',41),(42,'2020-12-16 00:00:00','Calle 14 # 12-42',42),(43,'2020-12-17 00:00:00','Calle 14 # 12-43',43),(44,'2020-12-18 00:00:00','Calle 14 # 12-44',44),(45,'2020-12-19 00:00:00','Calle 14 # 12-45',45),(46,'2020-12-20 00:00:00','Calle 14 # 12-46',46),(47,'2020-12-21 00:00:00','Calle 14 # 12-47',47),(48,'2020-12-22 00:00:00','Calle 14 # 12-48',48),(49,'2020-12-23 00:00:00','Calle 14 # 12-49',49),(50,'2020-12-24 00:00:00','Calle 14 # 12-50',50),(51,'2020-12-25 00:00:00','Calle 14 # 12-51',51),(52,'2020-12-26 00:00:00','Calle 14 # 12-52',52),(53,'2020-12-27 00:00:00','Calle 14 # 12-53',53),(54,'2020-12-28 00:00:00','Calle 14 # 12-54',54),(55,'2020-12-29 00:00:00','Calle 14 # 12-55',55),(56,'2020-12-30 00:00:00','Calle 14 # 12-56',56),(57,'2020-12-31 00:00:00','Calle 14 # 12-57',57),(58,'2021-01-01 00:00:00','Calle 14 # 12-58',58),(59,'2021-01-02 00:00:00','Calle 14 # 12-59',59),(60,'2021-01-03 00:00:00','Calle 14 # 12-60',60),(61,'2021-01-04 00:00:00','Calle 14 # 12-61',61),(62,'2021-01-05 00:00:00','Calle 14 # 12-62',62),(63,'2021-01-06 00:00:00','Calle 14 # 12-63',63),(64,'2021-01-07 00:00:00','Calle 14 # 12-64',64),(65,'2021-01-08 00:00:00','Calle 14 # 12-65',65),(66,'2021-01-09 00:00:00','Calle 14 # 12-66',66),(67,'2021-01-10 00:00:00','Calle 14 # 12-67',67),(68,'2021-01-11 00:00:00','Calle 14 # 12-68',68),(69,'2021-01-12 00:00:00','Calle 14 # 12-69',69),(70,'2021-01-13 00:00:00','Calle 14 # 12-70',70),(71,'2021-01-14 00:00:00','Calle 14 # 12-71',71),(72,'2021-01-15 00:00:00','Calle 14 # 12-72',72),(73,'2021-01-16 00:00:00','Calle 14 # 12-73',73),(74,'2021-01-17 00:00:00','Calle 14 # 12-74',74),(75,'2021-01-18 00:00:00','Calle 14 # 12-75',75),(76,'2021-01-19 00:00:00','Calle 14 # 12-76',76),(77,'2021-01-20 00:00:00','Calle 14 # 12-77',77),(78,'2021-01-21 00:00:00','Calle 14 # 12-78',78),(79,'2021-01-22 00:00:00','Calle 14 # 12-79',79),(80,'2021-01-23 00:00:00','Calle 14 # 12-80',80),(81,'2021-01-24 00:00:00','Calle 14 # 12-81',81),(82,'2021-01-25 00:00:00','Calle 14 # 12-82',82),(83,'2021-01-26 00:00:00','Calle 14 # 12-83',83),(84,'2021-01-27 00:00:00','Calle 14 # 12-84',84),(85,'2021-01-28 00:00:00','Calle 14 # 12-85',85),(86,'2021-01-29 00:00:00','Calle 14 # 12-86',86),(87,'2021-01-30 00:00:00','Calle 14 # 12-87',87),(88,'2021-02-01 00:00:00','Calle 14 # 12-88',88),(89,'2021-02-02 00:00:00','Calle 14 # 12-89',89),(90,'2021-02-03 00:00:00','Calle 14 # 12-90',90),(91,'2021-02-04 00:00:00','Calle 14 # 12-91',91),(92,'2021-02-05 00:00:00','Calle 14 # 12-92',92),(93,'2021-02-06 00:00:00','Calle 14 # 12-93',93),(94,'2021-02-07 00:00:00','Calle 14 # 12-94',94),(95,'2021-02-08 00:00:00','Calle 14 # 12-95',95),(96,'2021-02-09 00:00:00','Calle 14 # 12-96',96),(97,'2021-02-10 00:00:00','Calle 14 # 12-97',97),(98,'2021-02-11 00:00:00','Calle 14 # 12-98',98),(99,'2021-02-12 00:00:00','Calle 14 # 12-99',99),(100,'2021-02-13 00:00:00','Calle 14 # 12-100',100);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `ID_Persona` int(10) NOT NULL AUTO_INCREMENT,
  `Primer_Nombre` varchar(20) DEFAULT NULL,
  `Segundo_Nombre` varchar(20) DEFAULT NULL,
  `Primer_Apellido` varchar(20) DEFAULT NULL,
  `Segundo_Apellido` varchar(20) DEFAULT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Numero_Documento` bigint(20) DEFAULT NULL,
  `ID_Documento_FK` int(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Persona`),
  KEY `ID_Documento_FK` (`ID_Documento_FK`),
  CONSTRAINT `persona_ibfk_1` FOREIGN KEY (`ID_Documento_FK`) REFERENCES `documento` (`ID_Documento`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'Juan','David','Acosta','Acuña','Calle 54 # 12-51',123456789,1),(2,'Juan','Diego','Aguilar','Aguirre','Calle 55 # 13-52',234567890,2),(3,'Camilo','Deiver','Agustin','Ahumada','Calle 56 # 14-53',345678991,3),(4,'Camilla','Andrea','Alanis','Baca','Calle 54 # 12-52',456790092,4),(5,'Joel','Camilo','Alarcon','Baez','Calle 55 # 13-53',567901193,5),(6,'Emanuel','Jesus','Alayon','Baños','Calle 56 # 14-54',679012294,1),(7,'Maira','Alejandra','Alcazar','Barba','Calle 54 # 12-53',790123395,2),(8,'John','Roberto','Alcocer','Barrera','Calle 55 # 13-54',901234496,3),(9,'Cristian','Armando','Alfaro','Barrientos','Calle 56 # 14-55',1012345597,4),(10,'Yuli','Camila','Almendarez','Barriga','Calle 54 # 12-54',1123456698,5),(11,'Saray','Adriana','Altamirano','Bastida','Calle 55 # 13-55',1234567799,1),(12,'Yusleini','Sandra','Alvarez','Batalla','Calle 56 # 14-56',1345678900,2),(13,'Roberto','Celio','Alzate','Bautista','Calle 54 # 12-55',1456790001,3),(14,'Clemencia','Maria','Amador','Bazan','Calle 55 # 13-56',1567901102,4),(15,'Rodrigo','Alberto','Anara','Becerra','Calle 56 # 14-57',1679012203,5),(16,'Andres','Edwin','Arguelles','Becerril','Calle 54 # 12-56',1790123304,1),(17,'Felipe ','Andres','Arjona','Bello','Calle 55 # 13-57',1901234405,2),(18,'Maria','Jose','Arriaga','Beltran','Calle 56 # 14-58',2012345506,3),(19,'Jose ','Maria','Arrollo','Benitez','Calle 54 # 12-57',2123456607,4),(20,'Sebastian','Juan','Ayala','Bernal','Calle 55 # 13-58',2234567708,5),(21,'David','Juan','Baca','Bolaños','Calle 56 # 14-59',2345678809,1),(22,'Cristian','Camilo','Baez','Bonilla','Calle 54 # 12-58',2456789910,2),(23,'Johana','Camilla','Baños','Borgues','Calle 55 # 13-59',2567901011,3),(24,'Damian','Joel','Barba','Bustamante','Calle 56 # 14-60',2679012112,4),(25,'Brayan','Emanuel','Barrera','Busto','Calle 54 # 12-59',2790123213,5),(26,'Alejandra','Maira','Barrientos','Caballero','Calle 55 # 13-60',2901234314,1),(27,'John','John','Barriga','Cabeza','Calle 56 # 14-61',3012345415,2),(28,'Cristian','Cristian','Bastida','Cabrera','Calle 54 # 12-60',3123456516,3),(29,'Yuli','Yuli','Batalla','Cadenas','Calle 55 # 13-61',3234567617,4),(30,'Saray','Saray','Bautista','Cladera','Calle 56 # 14-62',3345678718,5),(31,'Yusleini','Yusleini','Bazan','Calleja','Calle 54 # 12-61',3456789819,1),(32,'Roberto','Roberto','Becerra','Calles','Calle 55 # 13-62',3567900920,2),(33,'Clemencia','Clemencia','Becerril','Camacho','Calle 56 # 14-63',3679012021,3),(34,'Rodrigo','Rodrigo','Bello','Camareno','Calle 54 # 12-62',3790123122,4),(35,'Andres','Andres','Beltran','Camarillo','Calle 55 # 13-63',3901234223,5),(36,'Felipe ','Felipe ','Benitez','Campos','Calle 56 # 14-64',4012345324,1),(37,'Maria','Maria','Bernal','Cardenas','Calle 54 # 12-63',4123456425,2),(38,'Jose ','Jose ','Bolaños','Cardoso','Calle 55 # 13-64',4234567526,3),(39,'Juan','David','Bonilla','Carranza','Calle 56 # 14-65',4345678627,4),(40,'Juan','Diego','Borgues','Carrillo','Calle 54 # 12-64',4456789728,5),(41,'Camilo','Deiver','Bustamante','Carvajal','Calle 55 # 13-65',4567900829,1),(42,'Camilla','Andrea','Busto','Carvallo','Calle 56 # 14-66',4679011930,2),(43,'Joel','Camilo','Caballero','Casas','Calle 54 # 12-65',4790123031,3),(44,'Emanuel','Jesus','Cabeza','Castellanos','Calle 55 # 13-66',4901234132,4),(45,'Maira','Alejandra','Cabrera','Castañeda','Calle 56 # 14-67',5012345233,5),(46,'John','Roberto','Cadenas','Cepeda','Calle 54 # 12-66',5123456334,1),(47,'Cristian','Armando','Cladera','Cerda','Calle 55 # 13-67',5234567435,2),(48,'Yuli','Camila','Calleja','Cervantes','Calle 56 # 14-68',5345678536,3),(49,'Saray','Adriana','Calles','Cespedes','Calle 54 # 12-67',5456789637,4),(50,'Yusleini','Sandra','Camacho','cavallos','Calle 55 # 13-68',5567900738,5),(51,'Roberto','Celio','Camareno','Cevedo','Calle 56 # 14-69',5679011839,1),(52,'Clemencia','Maria','Camarillo','Chavez','Calle 54 # 12-68',5790122940,2),(53,'Rodrigo','Alberto','Campos','Chaviria','Calle 55 # 13-69',5901234041,3),(54,'Andres','Edwin','Cardenas','Cisneros','Calle 56 # 14-70',6012345142,4),(55,'Felipe ','Andres','Cardoso','Collado','Calle 54 # 12-69',6123456243,5),(56,'Maria','Jose','Carranza','Cordado','Calle 55 # 13-70',6234567344,1),(57,'Jose ','Maria','Carrillo','Cornejo','Calle 56 # 14-71',6345678445,2),(58,'Sebastian','Juan','Carvajal','Correa','Calle 54 # 12-70',6456789546,3),(59,'David','Juan','Carvallo','Corro','Calle 55 # 13-71',6567900647,4),(60,'Cristian','Camilo','Casas','Cuellar Cuervo','Calle 56 # 14-72',6679011748,5),(61,'Johana','Camilla','Castellanos','Cuesta','Calle 54 # 12-71',6790122849,1),(62,'Damian','Joel','Castañeda','Cuevas','Calle 55 # 13-72',6901233950,2),(63,'Brayan','Emanuel','Cepeda','Echeverria','Calle 56 # 14-73',7012345051,3),(64,'Alejandra','Maira','Cerda','Elizondo','Calle 54 # 12-72',7123456152,4),(65,'Juan','David','Cervantes','Enriquez','Calle 55 # 13-73',7234567253,5),(66,'Juan','Diego','Cespedes','Escalante','Calle 56 # 14-74',7345678354,1),(67,'Camilo','Deiver','cavallos','Escamilla','Calle 54 # 12-73',7456789455,2),(68,'Camilla','Andrea','Cevedo','Escobar','Calle 55 # 13-74',7567900556,3),(69,'Joel','Camilo','Chavez','Escobedo','Calle 56 # 14-75',7679011657,4),(70,'Emanuel','Jesus','Chaviria','Escoto','Calle 54 # 12-74',7790122758,5),(71,'Maira','Alejandra','Cisneros','Escovar','Calle 55 # 13-75',7901233859,1),(72,'John','Roberto','Collado','Espino','Calle 56 # 14-76',8012344960,2),(73,'Cristian','Armando','Cordado','Esquivel','Calle 54 # 12-75',8123456061,3),(74,'Yuli','Camila','Cornejo','Estrada','Calle 55 # 13-76',8234567162,4),(75,'Saray','Adriana','Correa','Estrella','Calle 56 # 14-77',8345678263,5),(76,'Yusleini','Sandra','Corro','Fabregas','Calle 54 # 12-76',8456789364,1),(77,'Roberto','Celio','Cuellar Cuervo','Falcon','Calle 55 # 13-77',8567900465,2),(78,'Clemencia','Maria','Cuesta','Farias','Calle 56 # 14-78',8679011566,3),(79,'Rodrigo','Alberto','Cuevas','Fernandez','Calle 54 # 12-77',8790122667,4),(80,'Andres','Edwin','Echeverria','Ferreira','Calle 55 # 13-78',8901233768,5),(81,'Felipe ','Andres','Elizondo','Ferrer','Calle 56 # 14-79',9012344869,1),(82,'Maria','Jose','Enriquez','Fierro','Calle 54 # 12-78',9123455970,2),(83,'Jose ','Maria','Escalante','Figueras','Calle 55 # 13-79',9234567071,3),(84,'Sebastian','Juan','Escamilla','Acosta','Calle 56 # 14-80',9345678172,4),(85,'David','Juan','Escobar','Aguilar','Calle 54 # 12-79',9456789273,5),(86,'Cristian','Camilo','Escobedo','Agustin','Calle 55 # 13-80',9567900374,1),(87,'Johana','Camilla','Escoto','Alanis','Calle 56 # 14-81',9679011475,2),(88,'Damian','Joel','Escovar','Alarcon','Calle 54 # 12-80',9790122576,3),(89,'Brayan','Emanuel','Espino','Alayon','Calle 55 # 13-81',9901233677,4),(90,'Alejandra','Maira','Esquivel','Alcazar','Calle 56 # 14-82',987654321,5),(91,'Felipe ','Andres','Estrada','Alcocer','Calle 54 # 12-81',987654320,1),(92,'Maria','Jose','Estrella','Alfaro','Calle 55 # 13-82',987654319,2),(93,'Jose ','Maria','Fabregas','Almendarez','Calle 56 # 14-83',987654318,3),(94,'Sebastian','Juan','Falcon','Altamirano','Calle 54 # 12-82',987654317,4),(95,'David','Juan','Farias','Alvarez','Calle 55 # 13-83',987654316,5),(96,'Cristian','Camilo','Fernandez','Alzate','Calle 56 # 14-84',987654315,1),(97,'Johana','Camilla','Ferreira','Amador','Calle 54 # 12-83',987654314,2),(98,'Damian','Joel','Ferrer','Anara','Calle 55 # 13-84',987654313,3),(99,'Brayan','Emanuel','Fierro','Arguelles','Calle 56 # 14-85',987654312,4),(100,'Alejandra','Maira','Figueras','Arjona','Calle 54 # 12-84',987654311,5),(101,'Juan','David','Olaya','Rojas','Calle 54 # 13d-58',22222222,1),(102,'Juan2','David2','Olaya2','Rojas2','Calle 54 # 13d-58',22222222,2);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `ID_Producto` int(2) NOT NULL AUTO_INCREMENT,
  `ID_Tipo_FK` int(2) DEFAULT NULL,
  `ID_Material_FK` int(2) DEFAULT NULL,
  `ID_Color_FK` int(2) DEFAULT NULL,
  `ID_Medida_FK` int(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Producto`),
  KEY `ID_Tipo_FK` (`ID_Tipo_FK`),
  KEY `ID_Material_FK` (`ID_Material_FK`),
  KEY `ID_Color_FK` (`ID_Color_FK`),
  KEY `ID_Medida_FK` (`ID_Medida_FK`),
  CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`ID_Tipo_FK`) REFERENCES `tipo_producto` (`ID_Tipo`),
  CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`ID_Material_FK`) REFERENCES `material_producto` (`ID_Material`),
  CONSTRAINT `producto_ibfk_3` FOREIGN KEY (`ID_Color_FK`) REFERENCES `color_producto` (`ID_Color`),
  CONSTRAINT `producto_ibfk_4` FOREIGN KEY (`ID_Medida_FK`) REFERENCES `medida_producto` (`ID_Medida`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,1,1,1,1),(2,2,2,2,2),(3,3,3,3,3),(4,2,4,4,4),(5,3,1,5,5),(6,1,2,6,6),(7,2,3,7,7),(8,1,4,8,8),(9,3,1,9,9),(10,1,2,10,10),(11,2,3,9,11),(12,3,4,8,12),(13,2,1,7,13),(14,3,2,6,14),(15,1,3,5,15),(16,2,4,4,16),(17,1,3,3,17),(18,3,2,2,18),(19,1,1,1,19),(20,2,2,2,20),(21,3,3,3,21),(22,2,4,4,22),(23,3,1,5,23),(24,1,2,6,24),(25,2,3,7,25),(26,1,4,8,26),(27,3,1,9,27),(28,1,2,10,28),(29,2,3,9,29),(30,3,4,8,30),(31,2,1,7,31),(32,3,2,6,32),(33,1,3,5,33),(34,2,4,4,34),(35,1,3,3,35),(36,3,2,2,36);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rol` (
  `ID_Rol` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Rol`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Administrador'),(2,'Operador'),(3,'Vendedor'),(4,'Almacenista'),(5,'Cliente');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono`
--

DROP TABLE IF EXISTS `telefono`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefono` (
  `ID_Telefono` int(1) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(30) DEFAULT NULL,
  `Numero` bigint(10) DEFAULT NULL,
  `Extension` int(4) DEFAULT NULL,
  `ID_Usuario_FK` int(10) DEFAULT NULL,
  PRIMARY KEY (`ID_Telefono`),
  KEY `ID_Usuario_FK` (`ID_Usuario_FK`),
  CONSTRAINT `telefono_ibfk_1` FOREIGN KEY (`ID_Usuario_FK`) REFERENCES `usuario` (`ID_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono`
--

LOCK TABLES `telefono` WRITE;
/*!40000 ALTER TABLE `telefono` DISABLE KEYS */;
INSERT INTO `telefono` VALUES (1,'Fijo',1234567,0,1),(2,'Celular',3125672345,0,2),(3,'Oficina',2345678,1,3),(4,'Fijo',1234568,0,4),(5,'Celular',3125672341,0,5),(6,'Oficina',5678274,2,6),(7,'Fijo',4376982,0,7),(8,'Celular',3125672342,0,8),(9,'Oficina',1256894,3,9),(10,'Fijo',5487235,0,10),(11,'Celular',3125672343,0,11),(12,'Oficina',4565423,4,12),(13,'Fijo',4567823,0,13),(14,'Celular',3125672344,0,14),(15,'Oficina',3456792,5,15),(16,'Fijo',2462465,0,16),(17,'Celular',3125672346,0,17),(18,'Oficina',6548762,6,18),(19,'Fijo',3452345,0,19),(20,'Celular',3125672347,0,20),(21,'Oficina',1234123,7,21),(22,'Fijo',1234511,0,22),(23,'Celular',3125672348,0,23),(24,'Oficina',1234562,8,24),(25,'Fijo',1234563,0,25),(26,'Celular',1234561,0,26),(27,'Oficina',1234564,9,27),(28,'Fijo',1234565,0,28),(29,'Celular',3125672350,0,29),(30,'Oficina',1234566,10,30),(31,'Fijo',2345234,0,31),(32,'Celular',3126627058,0,32),(33,'Oficina',2345345,11,33),(34,'Fijo',2345456,0,34),(35,'Celular',3125672352,0,35),(36,'Oficina',2345678,12,36),(37,'Fijo',3456123,0,37),(38,'Celular',3125672353,0,38),(39,'Oficina',3456234,13,39),(40,'Fijo',3456345,0,40),(41,'Celular',3125672354,0,41),(42,'Oficina',3456712,14,42),(43,'Fijo',3456723,0,43),(44,'Celular',3125672355,0,44),(45,'Oficina',3456734,15,45),(46,'Fijo',34567456,0,46),(47,'Celular',3125672356,0,47),(48,'Oficina',3456567,16,48),(49,'Fijo',1357924,0,49),(50,'Celular',3125674345,0,50),(51,'Oficina',9876543,17,51),(52,'Fijo',8765432,0,52),(53,'Celular',7654321,0,53),(54,'Oficina',6543219,18,54),(55,'Fijo',5432198,0,55),(56,'Celular',3125872345,0,56),(57,'Oficina',7654321,19,57),(58,'Fijo',6543219,0,58),(59,'Celular',3125675445,0,59),(60,'Oficina',5432876,20,60),(61,'Fijo',5674321,0,61),(62,'Celular',3129872345,0,62),(63,'Oficina',2463514,21,63),(64,'Fijo',1111111,0,64),(65,'Celular',3128972345,0,65),(66,'Oficina',2222222,22,66),(67,'Fijo',3333333,0,67),(68,'Celular',3145672345,0,68),(69,'Oficina',4444444,23,69),(70,'Fijo',5555555,0,70),(71,'Celular',3125675445,0,71),(72,'Oficina',6666666,24,72),(73,'Fijo',7777777,0,73),(74,'Celular',3125772345,0,74),(75,'Oficina',8888888,25,75),(76,'Fijo',9999999,0,76),(77,'Celular',3125882345,0,77),(78,'Oficina',1111112,26,78),(79,'Fijo',2222223,0,79),(80,'Celular',3129972345,0,80),(81,'Oficina',3333334,27,81),(82,'Fijo',4444445,0,82),(83,'Celular',3111252345,0,83),(84,'Oficina',5555556,28,84),(85,'Fijo',6666667,0,85),(86,'Celular',3122672345,0,86),(87,'Oficina',7777778,29,87),(88,'Fijo',8888889,0,88),(89,'Celular',3125332345,0,89),(90,'Oficina',9999991,30,90),(91,'Fijo',1111113,0,91),(92,'Celular',3125442345,0,92),(93,'Oficina',2222224,31,93),(94,'Fijo',3333335,0,94),(95,'Celular',3125655345,0,95),(96,'Oficina',4444446,32,96),(97,'Fijo',5555557,0,97),(98,'Celular',3125676645,0,98),(99,'Oficina',6666668,33,99),(100,'Fijo',7777779,0,100);
/*!40000 ALTER TABLE `telefono` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_producto`
--

DROP TABLE IF EXISTS `tipo_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_producto` (
  `ID_Tipo` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Tipo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_producto`
--

LOCK TABLES `tipo_producto` WRITE;
/*!40000 ALTER TABLE `tipo_producto` DISABLE KEYS */;
INSERT INTO `tipo_producto` VALUES (1,'Base Cama'),(2,'Sala'),(3,'Cabeceros');
/*!40000 ALTER TABLE `tipo_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `ID_Usuario` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre_Usuario` varchar(30) DEFAULT NULL,
  `Contraseña_Usuario` varchar(30) DEFAULT NULL,
  `ID_Persona_FK` int(10) DEFAULT NULL,
  `ID_Rol_FK` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_Usuario`),
  KEY `ID_Persona_FK` (`ID_Persona_FK`),
  KEY `ID_Rol_FK` (`ID_Rol_FK`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`ID_Persona_FK`) REFERENCES `persona` (`ID_Persona`),
  CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`ID_Rol_FK`) REFERENCES `rol` (`ID_Rol`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Usuario 1','Contra 23',100,1),(2,'Usuario 2','Contra 25',99,2),(3,'Usuario 3','Contra 27',98,3),(4,'Usuario 4','Contra 29',97,4),(5,'Usuario 5','Contra 31',96,1),(6,'Usuario 6','Contra 33',95,2),(7,'Usuario 7','Contra 35',94,3),(8,'Usuario 8','Contra 37',93,5),(9,'Usuario 9','Contra 39',92,5),(10,'Usuario 10','Contra 41',91,1),(11,'Usuario 11','Contra 43',90,1),(12,'Usuario 12','Contra 45',89,5),(13,'Usuario 13','Contra 47',88,5),(14,'Usuario 14','Contra 49',87,5),(15,'Usuario 15','Contra 51',86,5),(16,'Usuario 16','Contra 53',85,5),(17,'Usuario 17','Contra 55',84,5),(18,'Usuario 18','Contra 57',83,5),(19,'Usuario 19','Contra 59',82,5),(20,'Usuario 20','Contra 61',81,5),(21,'Usuario 21','Contra 63',80,5),(22,'Usuario 22','Contra 65',79,5),(23,'Usuario 23','Contra 67',78,5),(24,'Usuario 24','Contra 69',77,5),(25,'Usuario 25','Contra 71',76,5),(26,'Usuario 26','Contra 73',75,5),(27,'Usuario 27','Contra 75',74,5),(28,'Usuario 28','Contra 77',73,5),(29,'Usuario 29','Contra 79',72,5),(30,'Usuario 30','Contra 81',71,5),(31,'Usuario 31','Contra 83',70,5),(32,'Usuario 32','Contra 85',69,5),(33,'Usuario 33','Contra 87',68,5),(34,'Usuario 34','Contra 89',67,5),(35,'Usuario 35','Contra 91',66,5),(36,'Usuario 36','Contra 93',65,5),(37,'Usuario 37','Contra 95',64,5),(38,'Usuario 38','Contra 97',63,5),(39,'Usuario 39','Contra 99',62,5),(40,'Usuario 40','Contra 101',61,5),(41,'Usuario 41','Contra 103',60,5),(42,'Usuario 42','Contra 105',59,5),(43,'Usuario 43','Contra 107',58,5),(44,'Usuario 44','Contra 109',57,5),(45,'Usuario 45','Contra 111',56,5),(46,'Usuario 46','Contra 113',55,5),(47,'Usuario 47','Contra 115',54,5),(48,'Usuario 48','Contra 117',53,5),(49,'Usuario 49','Contra 119',52,5),(50,'Usuario 50','Contra 121',51,5),(51,'Usuario 51','Contra 123',50,5),(52,'Usuario 52','Contra 125',49,5),(53,'Usuario 53','Contra 127',48,5),(54,'Usuario 54','Contra 129',47,5),(55,'Usuario 55','Contra 131',46,5),(56,'Usuario 56','Contra 133',45,5),(57,'Usuario 57','Contra 135',44,5),(58,'Usuario 58','Contra 137',43,5),(59,'Usuario 59','Contra 139',42,5),(60,'Usuario 60','Contra 141',41,5),(61,'Usuario 61','Contra 143',40,5),(62,'Usuario 62','Contra 145',39,5),(63,'Usuario 63','Contra 147',38,5),(64,'Usuario 64','Contra 149',37,5),(65,'Usuario 65','Contra 151',36,5),(66,'Usuario 66','Contra 153',35,5),(67,'Usuario 67','Contra 155',34,5),(68,'Usuario 68','Contra 157',33,5),(69,'Usuario 69','Contra 159',32,5),(70,'Usuario 70','Contra 161',31,5),(71,'Usuario 71','Contra 163',30,5),(72,'Usuario 72','Contra 165',29,5),(73,'Usuario 73','Contra 167',28,5),(74,'Usuario 74','Contra 169',27,5),(75,'Usuario 75','Contra 171',26,5),(76,'Usuario 76','Contra 173',25,5),(77,'Usuario 77','Contra 175',24,5),(78,'Usuario 78','Contra 177',23,5),(79,'Usuario 79','Contra 179',22,5),(80,'Usuario 80','Contra 181',21,5),(81,'Usuario 81','Contra 183',20,5),(82,'Usuario 82','Contra 185',19,5),(83,'Usuario 83','Contra 187',18,5),(84,'Usuario 84','Contra 189',17,5),(85,'Usuario 85','Contra 191',16,5),(86,'Usuario 86','Contra 193',15,5),(87,'Usuario 87','Contra 195',14,5),(88,'Usuario 88','Contra 197',13,5),(89,'Usuario 89','Contra 199',12,5),(90,'Usuario 90','Contra 201',11,5),(91,'Usuario 91','Contra 203',10,5),(92,'Usuario 92','Contra 205',9,5),(93,'Usuario 93','Contra 207',8,5),(94,'Usuario 94','Contra 209',7,5),(95,'Usuario 95','Contra 211',6,5),(96,'Usuario 96','Contra 213',5,5),(97,'Usuario 97','Contra 215',4,5),(98,'Usuario 98','Contra 217',3,5),(99,'Usuario 99','Contra 219',2,5),(100,'Usuario 100','Contra 221',1,5),(101,'Juancho','Juancho',102,2);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `venta` (
  `ID_Venta` int(2) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  `Cantidad_Producto` int(10) DEFAULT NULL,
  `Sub_Total` int(10) DEFAULT NULL,
  `Total` int(10) DEFAULT NULL,
  `ID_Producto_FK` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID_Venta`),
  KEY `ID_Producto_FK` (`ID_Producto_FK`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`ID_Producto_FK`) REFERENCES `producto` (`ID_Producto`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,'2020-11-01 00:00:00',1,100000,100000,1),(2,'2020-11-02 00:00:00',2,200000,200000,2),(3,'2020-11-03 00:00:00',3,300000,300000,3),(4,'2020-11-04 00:00:00',4,400000,400000,4),(5,'2020-11-05 00:00:00',5,500000,500000,5),(6,'2020-11-06 00:00:00',6,600000,600000,6),(7,'2020-11-07 00:00:00',7,700000,700000,7),(8,'2020-11-08 00:00:00',8,800000,800000,8),(9,'2020-11-09 00:00:00',9,900000,900000,9),(10,'2020-11-10 00:00:00',10,1000000,1000000,10),(11,'2020-11-11 00:00:00',11,1100000,1100000,11),(12,'2020-11-12 00:00:00',12,1200000,1200000,12),(13,'2020-11-13 00:00:00',13,1300000,1300000,13),(14,'2020-11-14 00:00:00',14,1400000,1400000,14),(15,'2020-11-15 00:00:00',15,1500000,1500000,15),(16,'2020-11-16 00:00:00',16,1600000,1600000,16),(17,'2020-11-17 00:00:00',17,1700000,1700000,17),(18,'2020-11-18 00:00:00',18,1800000,1800000,18),(19,'2020-11-19 00:00:00',19,1900000,1900000,19),(20,'2020-11-20 00:00:00',20,2000000,2000000,20),(21,'2020-11-21 00:00:00',21,2100000,2100000,21),(22,'2020-11-22 00:00:00',22,2200000,2200000,22),(23,'2020-11-23 00:00:00',23,2300000,2300000,23),(24,'2020-11-24 00:00:00',24,2400000,2400000,24),(25,'2020-11-25 00:00:00',25,2500000,2500000,25),(26,'2020-11-26 00:00:00',26,2600000,2600000,26),(27,'2020-11-27 00:00:00',27,2700000,2700000,27),(28,'2020-11-28 00:00:00',28,2800000,2800000,28),(29,'2020-11-29 00:00:00',29,2900000,2900000,29),(30,'2020-11-30 00:00:00',30,3000000,3000000,30),(31,'2020-11-01 00:00:00',31,3100000,3100000,31),(32,'2020-11-02 00:00:00',32,3200000,3200000,32),(33,'2020-11-03 00:00:00',33,3300000,3300000,33),(34,'2020-11-04 00:00:00',34,3400000,3400000,34),(35,'2020-11-05 00:00:00',35,3500000,3500000,35),(36,'2020-11-06 00:00:00',36,3600000,3600000,36),(37,'2020-11-07 00:00:00',37,3700000,3700000,35),(38,'2020-11-08 00:00:00',38,3800000,3800000,34),(39,'2020-11-09 00:00:00',39,3900000,3900000,33),(40,'2020-11-10 00:00:00',40,4000000,4000000,32),(41,'2020-11-11 00:00:00',41,4100000,4100000,31),(42,'2020-11-12 00:00:00',42,4200000,4200000,30),(43,'2020-11-13 00:00:00',43,4300000,4300000,29),(44,'2020-11-14 00:00:00',44,4400000,4400000,28),(45,'2020-11-15 00:00:00',45,4500000,4500000,27),(46,'2020-11-16 00:00:00',46,4600000,4600000,26),(47,'2020-11-17 00:00:00',47,4700000,4700000,25),(48,'2020-11-18 00:00:00',48,4800000,4800000,24),(49,'2020-11-19 00:00:00',49,4900000,4900000,23),(50,'2020-11-20 00:00:00',50,5000000,5000000,22),(51,'2020-11-21 00:00:00',51,5100000,5100000,21),(52,'2020-11-22 00:00:00',52,5200000,5200000,20),(53,'2020-11-23 00:00:00',53,5300000,5300000,19),(54,'2020-11-24 00:00:00',54,5400000,5400000,18),(55,'2020-11-25 00:00:00',55,5500000,5500000,17),(56,'2020-11-26 00:00:00',56,5600000,5600000,16),(57,'2020-11-27 00:00:00',57,5700000,5700000,15),(58,'2020-11-28 00:00:00',58,5800000,5800000,14),(59,'2020-11-29 00:00:00',59,5900000,5900000,13),(60,'2020-11-30 00:00:00',60,6000000,6000000,12),(61,'2020-11-01 00:00:00',61,6100000,6100000,11),(62,'2020-11-02 00:00:00',62,6200000,6200000,10),(63,'2020-11-03 00:00:00',63,6300000,6300000,9),(64,'2020-11-04 00:00:00',64,6400000,6400000,8),(65,'2020-11-05 00:00:00',65,6500000,6500000,7),(66,'2020-11-06 00:00:00',66,6600000,6600000,6),(67,'2020-11-07 00:00:00',67,6700000,6700000,5),(68,'2020-11-08 00:00:00',68,6800000,6800000,4),(69,'2020-11-09 00:00:00',69,6900000,6900000,3),(70,'2020-11-10 00:00:00',70,7000000,7000000,2),(71,'2020-11-11 00:00:00',71,7100000,7100000,1),(72,'2020-11-12 00:00:00',72,7200000,7200000,2),(73,'2020-11-13 00:00:00',73,7300000,7300000,3),(74,'2020-11-14 00:00:00',74,7400000,7400000,4),(75,'2020-11-15 00:00:00',75,7500000,7500000,5),(76,'2020-11-16 00:00:00',76,7600000,7600000,6),(77,'2020-11-17 00:00:00',77,7700000,7700000,7),(78,'2020-11-18 00:00:00',78,7800000,7800000,8),(79,'2020-11-19 00:00:00',79,7900000,7900000,9),(80,'2020-11-20 00:00:00',80,8000000,8000000,10),(81,'2020-11-21 00:00:00',81,8100000,8100000,11),(82,'2020-11-22 00:00:00',82,8200000,8200000,12),(83,'2020-11-23 00:00:00',83,8300000,8300000,13),(84,'2020-11-24 00:00:00',84,8400000,8400000,14),(85,'2020-11-25 00:00:00',85,8500000,8500000,15),(86,'2020-11-26 00:00:00',86,8600000,8600000,16),(87,'2020-11-27 00:00:00',87,8700000,8700000,17),(88,'2020-11-28 00:00:00',88,8800000,8800000,18),(89,'2020-11-29 00:00:00',89,8900000,8900000,19),(90,'2020-11-30 00:00:00',90,9000000,9000000,20),(91,'2020-11-01 00:00:00',91,9100000,9100000,21),(92,'2020-11-02 00:00:00',92,9200000,9200000,22),(93,'2020-11-03 00:00:00',93,9300000,9300000,23),(94,'2020-11-04 00:00:00',94,9400000,9400000,24),(95,'2020-11-05 00:00:00',95,9500000,9500000,25),(96,'2020-11-06 00:00:00',96,9600000,9600000,26),(97,'2020-11-07 00:00:00',97,9700000,9700000,27),(98,'2020-11-08 00:00:00',98,9800000,9800000,28),(99,'2020-11-09 00:00:00',99,9900000,9900000,29),(100,'2020-11-10 00:00:00',100,10000000,10000000,30);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'muebles_jj'
--

--
-- Dumping routines for database 'muebles_jj'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 13:16:10
