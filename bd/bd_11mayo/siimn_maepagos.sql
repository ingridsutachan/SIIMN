CREATE DATABASE  IF NOT EXISTS `siimn` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `siimn`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: siimn
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
-- Table structure for table `maepagos`
--

DROP TABLE IF EXISTS `maepagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maepagos` (
  `idpagos` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `mes` int(11) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `idnit` int(11) NOT NULL,
  `saldomes` decimal(16,2) NOT NULL,
  `debimes` decimal(16,2) NOT NULL,
  `credimes` decimal(16,2) NOT NULL,
  PRIMARY KEY (`idpagos`),
  KEY `fk_ciapagos_idx` (`idsucursal`),
  KEY `fk_cuentapagos_idx` (`cuenta`),
  KEY `fk_nitpagos_idx` (`idnit`),
  CONSTRAINT `fk_ciapagos` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentapagos` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nitpagos` FOREIGN KEY (`idnit`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maepagos`
--

LOCK TABLES `maepagos` WRITE;
/*!40000 ALTER TABLE `maepagos` DISABLE KEYS */;
INSERT INTO `maepagos` VALUES (1,1,'2015',1,4,3,0.00,0.00,0.00),(2,1,'2015',2,4,3,0.00,0.00,0.00),(3,1,'2015',3,4,3,161598.40,163198.40,-1600.00),(4,1,'2015',4,4,3,0.00,0.00,0.00),(5,1,'2015',5,4,3,0.00,0.00,0.00),(6,1,'2015',6,4,3,0.00,0.00,0.00),(7,1,'2015',7,4,3,0.00,0.00,0.00),(8,1,'2015',8,4,3,0.00,0.00,0.00),(9,1,'2015',9,4,3,0.00,0.00,0.00),(10,1,'2015',10,4,3,0.00,0.00,0.00),(11,1,'2015',11,4,3,0.00,0.00,0.00),(12,1,'2015',12,4,3,0.00,0.00,0.00),(13,1,'2015',1,10,3,0.00,0.00,0.00),(14,1,'2015',2,10,3,0.00,0.00,0.00),(15,1,'2015',3,10,3,-15998.40,1600.00,-17598.40),(16,1,'2015',4,10,3,0.00,0.00,0.00),(17,1,'2015',5,10,3,0.00,0.00,0.00),(18,1,'2015',6,10,3,0.00,0.00,0.00),(19,1,'2015',7,10,3,0.00,0.00,0.00),(20,1,'2015',8,10,3,0.00,0.00,0.00),(21,1,'2015',9,10,3,0.00,0.00,0.00),(22,1,'2015',10,10,3,0.00,0.00,0.00),(23,1,'2015',11,10,3,0.00,0.00,0.00),(24,1,'2015',12,10,3,0.00,0.00,0.00),(25,1,'2015',1,6,2,0.00,0.00,0.00),(26,1,'2015',2,6,2,0.00,0.00,0.00),(27,1,'2015',3,6,2,-80000.00,0.00,-80000.00),(28,1,'2015',4,6,2,0.00,0.00,0.00),(29,1,'2015',5,6,2,0.00,0.00,0.00),(30,1,'2015',6,6,2,0.00,0.00,0.00),(31,1,'2015',7,6,2,0.00,0.00,0.00),(32,1,'2015',8,6,2,0.00,0.00,0.00),(33,1,'2015',9,6,2,0.00,0.00,0.00),(34,1,'2015',10,6,2,0.00,0.00,0.00),(35,1,'2015',11,6,2,0.00,0.00,0.00),(36,1,'2015',12,6,2,0.00,0.00,0.00);
/*!40000 ALTER TABLE `maepagos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-11 11:18:31
