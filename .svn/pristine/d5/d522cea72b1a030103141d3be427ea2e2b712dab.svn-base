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
-- Table structure for table `maenits`
--

DROP TABLE IF EXISTS `maenits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maenits` (
  `idnit` int(11) NOT NULL AUTO_INCREMENT,
  `idtiponit` int(11) NOT NULL,
  `nit` varchar(12) NOT NULL,
  `digito` varchar(1) NOT NULL,
  `nombrenit` varchar(45) NOT NULL,
  `idciudad` int(11) NOT NULL,
  `acteconomic` varchar(10) NOT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `celular` varchar(10) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idnit`),
  KEY `fk_ciudad_idx` (`idciudad`),
  KEY `fk_tiponits_idx` (`idtiponit`),
  CONSTRAINT `fk_ciudadnits` FOREIGN KEY (`idciudad`) REFERENCES `ciudad` (`idciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tiponitnits` FOREIGN KEY (`idtiponit`) REFERENCES `tiponit` (`idtiponit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maenits`
--

LOCK TABLES `maenits` WRITE;
/*!40000 ALTER TABLE `maenits` DISABLE KEYS */;
INSERT INTO `maenits` VALUES (1,1,'1090398479','1','INGRID JOHANNA SUTACHAN',3,'1120','CALLE 168','123','123','INGRIDSUTACHAN@HOTMAIL.COM'),(2,2,'1092941363','1','MARIA JOSE CELIS SUTACHAN',3,'1234','CRA 8H','','3124538331','MAJOCELIS@HOTMAIL.COM'),(3,1,'1090256478','1','CAROLINA MARTINEZ',3,'102544','CRA','','315823146','');
/*!40000 ALTER TABLE `maenits` ENABLE KEYS */;
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
