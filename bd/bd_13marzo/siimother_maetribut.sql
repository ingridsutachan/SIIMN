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
-- Table structure for table `maetribut`
--

DROP TABLE IF EXISTS `maetribut`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maetribut` (
  `idtributario` int(11) NOT NULL,
  `codigotrib` varchar(5) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `tope` decimal(6,2) DEFAULT NULL,
  `idnittope` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtributario`),
  UNIQUE KEY `codigotrib_UNIQUE` (`codigotrib`),
  KEY `fk_nittrib_idx` (`idnittope`),
  CONSTRAINT `fk_nittrib` FOREIGN KEY (`idnittope`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maetribut`
--

LOCK TABLES `maetribut` WRITE;
/*!40000 ALTER TABLE `maetribut` DISABLE KEYS */;
INSERT INTO `maetribut` VALUES (1,'1','SIGUIENTE',0.00,2),(2,'12','PRUEBA',100.02,1),(3,'14','OTRAS COSAS',100.00,2),(4,'2','SEGUNDA PRUEBA',12.00,NULL);
/*!40000 ALTER TABLE `maetribut` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-03-13 14:07:23