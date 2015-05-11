CREATE DATABASE  IF NOT EXISTS `siimn` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `siimn`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: fliaguerrero.no-ip.info    Database: siimn
-- ------------------------------------------------------
-- Server version	5.6.23-log

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
  `idtransaccion` int(11) NOT NULL,
  `codigotrac` varchar(2) NOT NULL,
  `idmoduloppal` int(11) NOT NULL,
  `nombretrac` varchar(45) NOT NULL,
  `afectasaldo` varchar(1) NOT NULL,
  `afectaotro` bit(1) NOT NULL,
  `generaasiento` bit(1) NOT NULL,
  `consecutivo` bit(1) NOT NULL,
  `numeroactual` int(11) DEFAULT NULL,
  `codigcomp` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtransaccion`),
  UNIQUE KEY `codigotrac_UNIQUE` (`codigotrac`),
  KEY `fk_comprtrac_idx` (`codigcomp`),
  KEY `fk_modulomaetrac_idx` (`idmoduloppal`),
  CONSTRAINT `fk_comprtrac` FOREIGN KEY (`codigcomp`) REFERENCES `comprobante` (`codigcomprob`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_modulotrac` FOREIGN KEY (`idmoduloppal`) REFERENCES `moduloppal` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maetrac`
--

LOCK TABLES `maetrac` WRITE;
/*!40000 ALTER TABLE `maetrac` DISABLE KEYS */;
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

-- Dump completed on 2015-05-05 13:15:03
