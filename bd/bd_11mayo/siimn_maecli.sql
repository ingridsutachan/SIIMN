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
-- Table structure for table `maecli`
--

DROP TABLE IF EXISTS `maecli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maecli` (
  `codigocli` int(11) NOT NULL AUTO_INCREMENT,
  `idcliente` int(11) NOT NULL,
  `facturanombre` varchar(50) NOT NULL,
  `bloqueado` bit(1) NOT NULL,
  `direccionenvio` varchar(50) NOT NULL,
  `plazo` int(11) NOT NULL,
  `cupo` decimal(9,2) NOT NULL,
  `descuento` decimal(3,2) NOT NULL,
  `regimen` varchar(1) NOT NULL,
  `grancotribu` bit(1) NOT NULL,
  `ppago1` decimal(3,2) DEFAULT NULL,
  `ppago2` decimal(3,2) DEFAULT NULL,
  `causareteica` bit(1) NOT NULL,
  `aplicareteica` bit(1) NOT NULL,
  `causareteiva` bit(1) NOT NULL,
  `descuentareteiva` bit(1) NOT NULL,
  `retexcomprar` bit(1) NOT NULL,
  `descontretenvend` bit(1) NOT NULL,
  `porretencion` decimal(3,2) DEFAULT NULL,
  `jefecompra` varchar(45) NOT NULL,
  `comprador` varchar(45) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `idvendedor` int(11) NOT NULL,
  PRIMARY KEY (`codigocli`),
  KEY `fk_cuentacli_idx` (`cuenta`),
  KEY `fk_vendedorcliente_idx` (`idvendedor`),
  KEY `fk_clientedatoscliente_idx` (`idcliente`),
  CONSTRAINT `fk_clientedatoscliente` FOREIGN KEY (`idcliente`) REFERENCES `cliente` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentamaecli` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendedorcliente` FOREIGN KEY (`idvendedor`) REFERENCES `vendedor` (`idvendedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maecli`
--

LOCK TABLES `maecli` WRITE;
/*!40000 ALTER TABLE `maecli` DISABLE KEYS */;
/*!40000 ALTER TABLE `maecli` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-11 11:18:30
