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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 12:55:51
