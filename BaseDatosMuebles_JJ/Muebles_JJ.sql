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
-- Table structure for table `color_producto`
--

DROP TABLE IF EXISTS `color_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `color_producto` (
  `ID_Color` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID_Color`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comprobante_pago`
--

LOCK TABLES `comprobante_pago` WRITE;
/*!40000 ALTER TABLE `comprobante_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `comprobante_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_venta`
--

DROP TABLE IF EXISTS `detalle_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_venta` (
  `ID_Detalle` int(2) NOT NULL AUTO_INCREMENT,
  `ID_Venta_Fk` int(11) DEFAULT NULL,
  `ID_Producto_Fk` int(11) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Valor_Unitario` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ID_Detalle`),
  KEY `ID_Venta_Fk` (`ID_Venta_Fk`),
  KEY `ID_Producto_Fk` (`ID_Producto_Fk`),
  CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`ID_Venta_Fk`) REFERENCES `venta` (`ID_Venta`),
  CONSTRAINT `detalle_venta_ibfk_2` FOREIGN KEY (`ID_Producto_Fk`) REFERENCES `producto` (`ID_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_venta`
--

LOCK TABLES `detalle_venta` WRITE;
/*!40000 ALTER TABLE `detalle_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_venta` ENABLE KEYS */;
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
  `Id_Medida_FK` int(2) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Insumo`),
  KEY `Id_Medida_FK` (`Id_Medida_FK`),
  CONSTRAINT `insumo_ibfk_1` FOREIGN KEY (`Id_Medida_FK`) REFERENCES `unidadmedida` (`Id_Medida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insumo`
--

LOCK TABLES `insumo` WRITE;
/*!40000 ALTER TABLE `insumo` DISABLE KEYS */;
/*!40000 ALTER TABLE `insumo` ENABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'Juan','David','Acosta','Acuña','Calle 54 # 12-51',123456789,1),(2,'Juan','Diego','Aguilar','Aguirre','Calle 55 # 13-52',234567890,2),(3,'Camilo','Deiver','Agustin','Ahumada','Calle 56 # 14-53',345678991,3),(4,'Camilla','Andrea','Alanis','Baca','Calle 54 # 12-52',456790092,4),(5,'Joel','Camilo','Alarcon','Baez','Calle 55 # 13-53',567901193,5),(6,'Emanuel','Jesus','Alayon','Baños','Calle 56 # 14-54',679012294,1),(7,'Maira','Alejandra','Alcazar','Barba','Calle 54 # 12-53',790123395,2),(8,'John','Roberto','Alcocer','Barrera','Calle 55 # 13-54',901234496,3),(9,'Cristian','Armando','Alfaro','Barrientos','Calle 56 # 14-55',1012345597,4),(10,'Yuli','Camila','Almendarez','Barriga','Calle 54 # 12-54',1123456698,5),(11,'Saray','Adriana','Altamirano','Bastida','Calle 55 # 13-55',1234567799,1),(12,'Yusleini','Sandra','Alvarez','Batalla','Calle 56 # 14-56',1345678900,2),(13,'Roberto','Celio','Alzate','Bautista','Calle 54 # 12-55',1456790001,3),(14,'Clemencia','Maria','Amador','Bazan','Calle 55 # 13-56',1567901102,4),(15,'Rodrigo','Alberto','Anara','Becerra','Calle 56 # 14-57',1679012203,5),(16,'Andres','Edwin','Arguelles','Becerril','Calle 54 # 12-56',1790123304,1),(17,'Felipe ','Andres','Arjona','Bello','Calle 55 # 13-57',1901234405,2),(18,'Maria','Jose','Arriaga','Beltran','Calle 56 # 14-58',2012345506,3),(19,'Jose ','Maria','Arrollo','Benitez','Calle 54 # 12-57',2123456607,4),(20,'Sebastian','Juan','Ayala','Bernal','Calle 55 # 13-58',2234567708,5),(21,'David','Juan','Baca','Bolaños','Calle 56 # 14-59',2345678809,1),(22,'Cristian','Camilo','Baez','Bonilla','Calle 54 # 12-58',2456789910,2),(23,'Johana','Camilla','Baños','Borgues','Calle 55 # 13-59',2567901011,3),(24,'Damian','Joel','Barba','Bustamante','Calle 56 # 14-60',2679012112,4),(25,'Brayan','Emanuel','Barrera','Busto','Calle 54 # 12-59',2790123213,5),(26,'Alejandra','Maira','Barrientos','Caballero','Calle 55 # 13-60',2901234314,1),(27,'John','John','Barriga','Cabeza','Calle 56 # 14-61',3012345415,2),(28,'Cristian','Cristian','Bastida','Cabrera','Calle 54 # 12-60',3123456516,3),(29,'Yuli','Yuli','Batalla','Cadenas','Calle 55 # 13-61',3234567617,4),(30,'Saray','Saray','Bautista','Cladera','Calle 56 # 14-62',3345678718,5),(31,'Yusleini','Yusleini','Bazan','Calleja','Calle 54 # 12-61',3456789819,1),(32,'Roberto','Roberto','Becerra','Calles','Calle 55 # 13-62',3567900920,2),(33,'Clemencia','Clemencia','Becerril','Camacho','Calle 56 # 14-63',3679012021,3),(34,'Rodrigo','Rodrigo','Bello','Camareno','Calle 54 # 12-62',3790123122,4),(35,'Andres','Andres','Beltran','Camarillo','Calle 55 # 13-63',3901234223,5),(36,'Felipe ','Felipe ','Benitez','Campos','Calle 56 # 14-64',4012345324,1),(37,'Maria','Maria','Bernal','Cardenas','Calle 54 # 12-63',4123456425,2),(38,'Jose ','Jose ','Bolaños','Cardoso','Calle 55 # 13-64',4234567526,3),(39,'Juan','David','Bonilla','Carranza','Calle 56 # 14-65',4345678627,4),(40,'Juan','Diego','Borgues','Carrillo','Calle 54 # 12-64',4456789728,5),(41,'Camilo','Deiver','Bustamante','Carvajal','Calle 55 # 13-65',4567900829,1),(42,'Camilla','Andrea','Busto','Carvallo','Calle 56 # 14-66',4679011930,2),(43,'Joel','Camilo','Caballero','Casas','Calle 54 # 12-65',4790123031,3),(44,'Emanuel','Jesus','Cabeza','Castellanos','Calle 55 # 13-66',4901234132,4),(45,'Maira','Alejandra','Cabrera','Castañeda','Calle 56 # 14-67',5012345233,5),(46,'John','Roberto','Cadenas','Cepeda','Calle 54 # 12-66',5123456334,1),(47,'Cristian','Armando','Cladera','Cerda','Calle 55 # 13-67',5234567435,2),(48,'Yuli','Camila','Calleja','Cervantes','Calle 56 # 14-68',5345678536,3),(49,'Saray','Adriana','Calles','Cespedes','Calle 54 # 12-67',5456789637,4),(50,'Yusleini','Sandra','Camacho','cavallos','Calle 55 # 13-68',5567900738,5),(51,'Roberto','Celio','Camareno','Cevedo','Calle 56 # 14-69',5679011839,1),(52,'Clemencia','Maria','Camarillo','Chavez','Calle 54 # 12-68',5790122940,2),(53,'Rodrigo','Alberto','Campos','Chaviria','Calle 55 # 13-69',5901234041,3),(54,'Andres','Edwin','Cardenas','Cisneros','Calle 56 # 14-70',6012345142,4),(55,'Felipe ','Andres','Cardoso','Collado','Calle 54 # 12-69',6123456243,5),(56,'Maria','Jose','Carranza','Cordado','Calle 55 # 13-70',6234567344,1),(57,'Jose ','Maria','Carrillo','Cornejo','Calle 56 # 14-71',6345678445,2),(58,'Sebastian','Juan','Carvajal','Correa','Calle 54 # 12-70',6456789546,3),(59,'David','Juan','Carvallo','Corro','Calle 55 # 13-71',6567900647,4),(60,'Cristian','Camilo','Casas','Cuellar Cuervo','Calle 56 # 14-72',6679011748,5),(61,'Johana','Camilla','Castellanos','Cuesta','Calle 54 # 12-71',6790122849,1),(62,'Damian','Joel','Castañeda','Cuevas','Calle 55 # 13-72',6901233950,2),(63,'Brayan','Emanuel','Cepeda','Echeverria','Calle 56 # 14-73',7012345051,3),(64,'Alejandra','Maira','Cerda','Elizondo','Calle 54 # 12-72',7123456152,4),(65,'Juan','David','Cervantes','Enriquez','Calle 55 # 13-73',7234567253,5),(66,'Juan','Diego','Cespedes','Escalante','Calle 56 # 14-74',7345678354,1),(67,'Camilo','Deiver','cavallos','Escamilla','Calle 54 # 12-73',7456789455,2),(68,'Camilla','Andrea','Cevedo','Escobar','Calle 55 # 13-74',7567900556,3),(69,'Joel','Camilo','Chavez','Escobedo','Calle 56 # 14-75',7679011657,4),(70,'Emanuel','Jesus','Chaviria','Escoto','Calle 54 # 12-74',7790122758,5),(71,'Maira','Alejandra','Cisneros','Escovar','Calle 55 # 13-75',7901233859,1),(72,'John','Roberto','Collado','Espino','Calle 56 # 14-76',8012344960,2),(73,'Cristian','Armando','Cordado','Esquivel','Calle 54 # 12-75',8123456061,3),(74,'Yuli','Camila','Cornejo','Estrada','Calle 55 # 13-76',8234567162,4),(75,'Saray','Adriana','Correa','Estrella','Calle 56 # 14-77',8345678263,5),(76,'Yusleini','Sandra','Corro','Fabregas','Calle 54 # 12-76',8456789364,1),(77,'Roberto','Celio','Cuellar Cuervo','Falcon','Calle 55 # 13-77',8567900465,2),(78,'Clemencia','Maria','Cuesta','Farias','Calle 56 # 14-78',8679011566,3),(79,'Rodrigo','Alberto','Cuevas','Fernandez','Calle 54 # 12-77',8790122667,4),(80,'Andres','Edwin','Echeverria','Ferreira','Calle 55 # 13-78',8901233768,5),(81,'Felipe ','Andres','Elizondo','Ferrer','Calle 56 # 14-79',9012344869,1),(82,'Maria','Jose','Enriquez','Fierro','Calle 54 # 12-78',9123455970,2),(83,'Jose ','Maria','Escalante','Figueras','Calle 55 # 13-79',9234567071,3),(84,'Sebastian','Juan','Escamilla','Acosta','Calle 56 # 14-80',9345678172,4),(85,'David','Juan','Escobar','Aguilar','Calle 54 # 12-79',9456789273,5),(86,'Cristian','Camilo','Escobedo','Agustin','Calle 55 # 13-80',9567900374,1),(87,'Johana','Camilla','Escoto','Alanis','Calle 56 # 14-81',9679011475,2),(88,'Damian','Joel','Escovar','Alarcon','Calle 54 # 12-80',9790122576,3),(89,'Brayan','Emanuel','Espino','Alayon','Calle 55 # 13-81',9901233677,4),(90,'Alejandra','Maira','Esquivel','Alcazar','Calle 56 # 14-82',987654321,5),(91,'Felipe ','Andres','Estrada','Alcocer','Calle 54 # 12-81',987654320,1),(92,'Maria','Jose','Estrella','Alfaro','Calle 55 # 13-82',987654319,2),(93,'Jose ','Maria','Fabregas','Almendarez','Calle 56 # 14-83',987654318,3),(94,'Sebastian','Juan','Falcon','Altamirano','Calle 54 # 12-82',987654317,4),(95,'David','Juan','Farias','Alvarez','Calle 55 # 13-83',987654316,5),(96,'Cristian','Camilo','Fernandez','Alzate','Calle 56 # 14-84',987654315,1),(97,'Johana','Camilla','Ferreira','Amador','Calle 54 # 12-83',987654314,2),(98,'Damian','Joel','Ferrer','Anara','Calle 55 # 13-84',987654313,3),(99,'Brayan','Emanuel','Fierro','Arguelles','Calle 56 # 14-85',987654312,4),(100,'Alejandra','Maira','Figueras','Arjona','Calle 54 # 12-84',987654311,5);
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
-- Table structure for table `unidadmedida`
--

DROP TABLE IF EXISTS `unidadmedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidadmedida` (
  `Id_Medida` int(2) NOT NULL AUTO_INCREMENT,
  `NombreLargo` varchar(20) DEFAULT NULL,
  `NombreCorto` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id_Medida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidadmedida`
--

LOCK TABLES `unidadmedida` WRITE;
/*!40000 ALTER TABLE `unidadmedida` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidadmedida` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Usuario1','Contra23',100,1),(2,'Usuario2','Contra25',99,2),(3,'Usuario3','Contra27',98,3),(4,'Usuario4','Contra29',97,4),(5,'Usuario5','Contra31',96,1),(6,'Usuario6','Contra33',95,2),(7,'Usuario7','Contra35',94,3),(8,'Usuario8','Contra37',93,5),(9,'Usuario9','Contra39',92,5),(10,'Usuario10','Contra41',91,1),(11,'Usuario11','Contra43',90,1),(12,'Usuario12','Contra45',89,5),(13,'Usuario13','Contra47',88,5),(14,'Usuario14','Contra49',87,5),(15,'Usuario15','Contra51',86,5),(16,'Usuario16','Contra53',85,5),(17,'Usuario17','Contra55',84,5),(18,'Usuario18','Contra57',83,5),(19,'Usuario19','Contra59',82,5),(20,'Usuario20','Contra61',81,5),(21,'Usuario21','Contra63',80,5),(22,'Usuario22','Contra65',79,5),(23,'Usuario23','Contra67',78,5),(24,'Usuario24','Contra69',77,5),(25,'Usuario25','Contra71',76,5),(26,'Usuario26','Contra73',75,5),(27,'Usuario27','Contra75',74,5),(28,'Usuario28','Contra77',73,5),(29,'Usuario29','Contra79',72,5),(30,'Usuario30','Contra81',71,5),(31,'Usuario31','Contra83',70,5),(32,'Usuario32','Contra85',69,5),(33,'Usuario33','Contra87',68,5),(34,'Usuario34','Contra89',67,5),(35,'Usuario35','Contra91',66,5),(36,'Usuario36','Contra93',65,5),(37,'Usuario37','Contra95',64,5),(38,'Usuario38','Contra97',63,5),(39,'Usuario39','Contra99',62,5),(40,'Usuario40','Contra101',61,5),(41,'Usuario41','Contra103',60,5),(42,'Usuario42','Contra105',59,5),(43,'Usuario43','Contra107',58,5),(44,'Usuario44','Contra109',57,5),(45,'Usuario45','Contra111',56,5),(46,'Usuario46','Contra113',55,5),(47,'Usuario47','Contra115',54,5),(48,'Usuario48','Contra117',53,5),(49,'Usuario49','Contra119',52,5),(50,'Usuario50','Contra121',51,5),(51,'Usuario51','Contra123',50,5),(52,'Usuario52','Contra125',49,5),(53,'Usuario53','Contra127',48,5),(54,'Usuario54','Contra129',47,5),(55,'Usuario55','Contra131',46,5),(56,'Usuario56','Contra133',45,5),(57,'Usuario57','Contra135',44,5),(58,'Usuario58','Contra137',43,5),(59,'Usuario59','Contra139',42,5),(60,'Usuario60','Contra141',41,5),(61,'Usuario61','Contra143',40,5),(62,'Usuario62','Contra145',39,5),(63,'Usuario63','Contra147',38,5),(64,'Usuario64','Contra149',37,5),(65,'Usuario65','Contra151',36,5),(66,'Usuario66','Contra153',35,5),(67,'Usuario67','Contra155',34,5),(68,'Usuario68','Contra157',33,5),(69,'Usuario69','Contra159',32,5),(70,'Usuario70','Contra161',31,5),(71,'Usuario71','Contra163',30,5),(72,'Usuario72','Contra165',29,5),(73,'Usuario73','Contra167',28,5),(74,'Usuario74','Contra169',27,5),(75,'Usuario75','Contra171',26,5),(76,'Usuario76','Contra173',25,5),(77,'Usuario77','Contra175',24,5),(78,'Usuario78','Contra177',23,5),(79,'Usuario79','Contra179',22,5),(80,'Usuario80','Contra181',21,5),(81,'Usuario81','Contra183',20,5),(82,'Usuario82','Contra185',19,5),(83,'Usuario83','Contra187',18,5),(84,'Usuario84','Contra189',17,5),(85,'Usuario85','Contra191',16,5),(86,'Usuario86','Contra193',15,5),(87,'Usuario87','Contra195',14,5),(88,'Usuario88','Contra197',13,5),(89,'Usuario89','Contra199',12,5),(90,'Usuario90','Contra201',11,5),(91,'Usuario91','Contra203',10,5),(92,'Usuario92','Contra205',9,5),(93,'Usuario93','Contra207',8,5),(94,'Usuario94','Contra209',7,5),(95,'Usuario95','Contra211',6,5),(96,'Usuario96','Contra213',5,5),(97,'Usuario97','Contra215',4,5),(98,'Usuario98','Contra217',3,5),(99,'Usuario99','Contra219',2,5),(100,'Usuario100','Contra221',1,5);
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
  `Documento_Cliente` varchar(20) DEFAULT NULL,
  `ID_Documento_Fk` int(11) DEFAULT NULL,
  `Nombre_Cliente` varchar(50) DEFAULT NULL,
  `Fecha_Venta` datetime DEFAULT NULL,
  `Fecha_Entrega` datetime DEFAULT NULL,
  `Entrega` int(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Venta`),
  KEY `ID_Documento_Fk` (`ID_Documento_Fk`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`ID_Documento_Fk`) REFERENCES `documento` (`ID_Documento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
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

-- Dump completed on 2020-12-11  1:48:39
