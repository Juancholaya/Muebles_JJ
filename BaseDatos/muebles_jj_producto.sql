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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 12:55:51
