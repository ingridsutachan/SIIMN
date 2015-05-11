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
-- Table structure for table `formatosbpyg`
--

DROP TABLE IF EXISTS `formatosbpyg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formatosbpyg` (
  `idformato` int(11) NOT NULL AUTO_INCREMENT,
  `tipoformato` char(1) NOT NULL,
  `clasemayor` varchar(1) DEFAULT NULL,
  `linea` varchar(2) DEFAULT NULL,
  `nombref` varchar(45) NOT NULL,
  `cuentaini` int(11) DEFAULT NULL,
  `cuentafin` int(11) DEFAULT NULL,
  PRIMARY KEY (`idformato`),
  KEY `fk_cuentaformatofin_idx` (`cuentafin`),
  KEY `fk_cuentainifombpyg_idx` (`cuentaini`),
  CONSTRAINT `fk_cuentafinforbpyg` FOREIGN KEY (`cuentafin`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentainifombpyg` FOREIGN KEY (`cuentaini`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formatosbpyg`
--

LOCK TABLES `formatosbpyg` WRITE;
/*!40000 ALTER TABLE `formatosbpyg` DISABLE KEYS */;
INSERT INTO `formatosbpyg` VALUES (1,'1',NULL,NULL,'BALANCE GENERAL',NULL,NULL),(2,'2',NULL,NULL,'ESTADO DE PERDIDAS  Y GANANCIAS',NULL,NULL),(3,'1','1','1','PRUEBA 1',9,30),(4,'1','1','2','PRUEBA 2',2,30),(5,'2','1','1','PRUEBAPYG',2,30),(7,'1','1','3','PRUEBA 3',2,30);
/*!40000 ALTER TABLE `formatosbpyg` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-03-24 13:52:34
