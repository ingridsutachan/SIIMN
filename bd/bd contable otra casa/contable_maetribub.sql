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
-- Table structure for table `maetribub`
--

DROP TABLE IF EXISTS `maetribub`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maetribub` (
  `codigotrib` varchar(6) NOT NULL COMMENT 'Numero del codigo tributario',
  `nombre` varchar(40) NOT NULL COMMENT 'Nombre del codigo tributario',
  `tope` decimal(9,0) DEFAULT '0' COMMENT 'tope para el codigo tributario',
  `nittope` varchar(10) DEFAULT '0' COMMENT 'nit del tope del codigo tributario',
  `nomnit` varchar(50) DEFAULT NULL COMMENT 'nombre asignado al nit del tope',
  `idcompania` int(11) NOT NULL,
  PRIMARY KEY (`codigotrib`),
  UNIQUE KEY `codigo_UNIQUE` (`codigotrib`),
  KEY `fk_companiatrib_idx` (`idcompania`),
  CONSTRAINT `fk_comapaniatrib` FOREIGN KEY (`idcompania`) REFERENCES `compania` (`idcompania`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Codigos Tributarios';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maetribub`
--

LOCK TABLES `maetribub` WRITE;
/*!40000 ALTER TABLE `maetribub` DISABLE KEYS */;
INSERT INTO `maetribub` VALUES ('100','TRIBUTARIO NUMERO 1',100000000,'1313','TOPE 100',1);
/*!40000 ALTER TABLE `maetribub` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-02-04 13:33:03
