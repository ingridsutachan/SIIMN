CREATE DATABASE  IF NOT EXISTS `siimother` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `siimother`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: siimother
-- ------------------------------------------------------
-- Server version	5.1.73-community

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
-- Table structure for table `presupuesto`
--

DROP TABLE IF EXISTS `presupuesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `presupuesto` (
  `idpresupuesto` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `idcentro` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `mes` int(2) NOT NULL,
  `cantidad` decimal(16,2) NOT NULL,
  PRIMARY KEY (`idpresupuesto`),
  KEY `fk_cuentapresupuesto_idx` (`cuenta`),
  KEY `fk_ciapresupuesto_idx` (`idsucursal`),
  KEY `fk_centropresupuesto_idx` (`idcentro`),
  CONSTRAINT `fk_centropresupuesto` FOREIGN KEY (`idcentro`) REFERENCES `centrocostos` (`idcentro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ciapresupuesto` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentapresupuesto` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=89 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presupuesto`
--

LOCK TABLES `presupuesto` WRITE;
/*!40000 ALTER TABLE `presupuesto` DISABLE KEYS */;
INSERT INTO `presupuesto` VALUES (5,1,10,1,'2014',1,1.00),(6,1,10,1,'2014',2,5.00),(7,1,10,1,'2014',3,5.00),(8,1,10,1,'2014',4,6.50),(9,1,10,1,'2014',5,6.10),(10,1,10,1,'2014',6,1.20),(11,1,10,1,'2014',7,8.00),(12,1,10,1,'2014',8,2.00),(13,1,10,1,'2014',9,9.00),(14,1,10,1,'2014',10,4.00),(15,1,10,1,'2014',11,1.00),(16,1,10,1,'2014',12,4.00),(17,1,10,1,'2015',1,1.00),(18,1,10,1,'2015',2,1.00),(19,1,10,1,'2015',3,2.00),(20,1,10,1,'2015',4,2.00),(21,1,10,1,'2015',5,21.00),(22,1,10,1,'2015',6,12.00),(23,1,10,1,'2015',7,0.00),(24,1,10,1,'2015',8,224.00),(25,1,10,1,'2015',9,22112.00),(26,1,10,1,'2015',10,121.00),(27,1,10,1,'2015',11,1.00),(28,1,10,1,'2015',12,1.00),(41,1,10,3,'2014',1,1.00),(42,1,10,3,'2014',2,4.00),(43,1,10,3,'2014',3,4.00),(44,1,10,3,'2014',4,4.00),(45,1,10,3,'2014',5,3.00),(46,1,10,3,'2014',6,3.00),(47,1,10,3,'2014',7,5.00),(48,1,10,3,'2014',8,5.00),(49,1,10,3,'2014',9,6.00),(50,1,10,3,'2014',10,7.00),(51,1,10,3,'2014',11,4.00),(52,1,10,3,'2014',12,3.00),(53,1,10,2,'2015',1,4.00),(54,1,10,2,'2015',2,4.00),(55,1,10,2,'2015',3,3.00),(56,1,10,2,'2015',4,22.00),(57,1,10,2,'2015',5,2.00),(58,1,10,2,'2015',6,2.00),(59,1,10,2,'2015',7,2.00),(60,1,10,2,'2015',8,2.00),(61,1,10,2,'2015',9,2.00),(62,1,10,2,'2015',10,2.00),(63,1,10,2,'2015',11,2.00),(64,1,10,2,'2015',12,2.00),(65,1,28,1,'2014',1,12.00),(66,1,28,1,'2014',2,2.00),(67,1,28,1,'2014',3,3.00),(68,1,28,1,'2014',4,4.00),(69,1,28,1,'2014',5,5.00),(70,1,28,1,'2014',6,6.00),(71,1,28,1,'2014',7,7.00),(72,1,28,1,'2014',8,8.00),(73,1,28,1,'2014',9,9.00),(74,1,28,1,'2014',10,10.00),(75,1,28,1,'2014',11,11.00),(76,1,28,1,'2014',12,12.00),(77,1,28,3,'2014',1,1.00),(78,1,28,3,'2014',2,2.00),(79,1,28,3,'2014',3,3.00),(80,1,28,3,'2014',4,0.00),(81,1,28,3,'2014',5,0.00),(82,1,28,3,'2014',6,0.00),(83,1,28,3,'2014',7,0.00),(84,1,28,3,'2014',8,0.00),(85,1,28,3,'2014',9,0.00),(86,1,28,3,'2014',10,0.00),(87,1,28,3,'2014',11,0.00),(88,1,28,3,'2014',12,0.00);
/*!40000 ALTER TABLE `presupuesto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-03-13 14:07:22
