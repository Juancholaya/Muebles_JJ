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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 12:55:52
