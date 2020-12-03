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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 12:55:52
