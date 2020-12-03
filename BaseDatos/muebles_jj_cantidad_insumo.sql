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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 12:55:51
