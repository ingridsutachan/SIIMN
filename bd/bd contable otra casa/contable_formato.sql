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
-- Table structure for table `formato`
--

DROP TABLE IF EXISTS `formato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formato` (
  `idbalance` int(11) NOT NULL AUTO_INCREMENT,
  `tipoformato` char(1) NOT NULL,
  `clasemayor` varchar(1) DEFAULT NULL,
  `linea` varchar(2) DEFAULT NULL,
  `nombref` varchar(45) NOT NULL,
  `cuentainicial` varchar(12) DEFAULT NULL,
  `cuentafinal` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`idbalance`),
  KEY `fk_idclaseba_idx` (`clasemayor`),
  KEY `fk_cuentainiba_idx` (`cuentainicial`),
  KEY `fk_cuentafinaba_idx` (`cuentafinal`),
  CONSTRAINT `fk_cuentafinafo` FOREIGN KEY (`cuentafinal`) REFERENCES `maeconta` (`cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentainifo` FOREIGN KEY (`cuentainicial`) REFERENCES `maeconta` (`cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formato`
--

LOCK TABLES `formato` WRITE;
/*!40000 ALTER TABLE `formato` DISABLE KEYS */;
INSERT INTO `formato` VALUES (1,'1',NULL,NULL,'BALANCE GENERAL PRUEBA',NULL,NULL),(2,'2',NULL,NULL,'ESTADO DE PERDIDAS Y GANANCIAS',NULL,NULL),(5,'1','1','1','ACTIVOS CORRIENTES','11050505','11050505'),(6,'2','1','1','ACTIVO CORRIENTE','11050505','11050505'),(8,'1','1','2','ACTIVOS FIJOS','1105','1105'),(9,'2','1','2','INGRESOS PERDIDOS','11050505','11050505'),(10,'1','1','3','CA','11050505','11050505');
/*!40000 ALTER TABLE `formato` ENABLE KEYS */;
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
