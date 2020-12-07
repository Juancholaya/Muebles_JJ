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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-03 12:55:51
