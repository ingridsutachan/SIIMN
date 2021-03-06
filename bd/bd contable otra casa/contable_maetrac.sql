CREATE DATABASE  IF NOT EXISTS `contable` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `contable`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: contable
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
-- Table structure for table `maetrac`
--

DROP TABLE IF EXISTS `maetrac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maetrac` (
  `codigotrac` varchar(3) NOT NULL,
  `nombretrac` varchar(45) NOT NULL,
  `afectasaldo` varchar(1) NOT NULL,
  `afectaotros` bit(1) NOT NULL,
  `generaasiento` bit(1) NOT NULL,
  `consecutivo` bit(1) NOT NULL,
  `numeroactual` int(11) DEFAULT NULL,
  `codicomp` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigotrac`),
  KEY `fk_comprobantetra_idx` (`codicomp`),
  CONSTRAINT `fk_comprobantetra` FOREIGN KEY (`codicomp`) REFERENCES `comprobante` (`codicomp`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maetrac`
--

LOCK TABLES `maetrac` WRITE;
/*!40000 ALTER TABLE `maetrac` DISABLE KEYS */;
INSERT INTO `maetrac` VALUES ('1','PRUEBA 1','+','','','',500,2),('2','PRUEBA 2','-','','','',124,1);
/*!40000 ALTER TABLE `maetrac` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-02-04 13:33:01
