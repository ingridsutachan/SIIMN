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
-- Table structure for table `maecli`
--

DROP TABLE IF EXISTS `maecli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maecli` (
  `codigocli` int(11) NOT NULL,
  `nit` varchar(10) NOT NULL,
  `digito` varchar(1) NOT NULL,
  `nombrecli` varchar(45) NOT NULL,
  `factnombr` varchar(70) NOT NULL,
  `estado` bit(1) NOT NULL,
  `idpais` int(11) NOT NULL,
  `iddpto` int(11) NOT NULL,
  `idciudad` int(11) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `direnvio` varchar(70) NOT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `celular` varchar(10) NOT NULL,
  `fax` varchar(10) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `plazo` int(11) NOT NULL,
  `cupomes` int(11) NOT NULL,
  `descuento` decimal(9,0) NOT NULL,
  `regimen` char(1) NOT NULL,
  `idvendedor` int(11) NOT NULL,
  `grancontrib` bit(1) NOT NULL,
  `causareteica` bit(1) NOT NULL,
  `aplicareteica` bit(1) NOT NULL,
  `causreteiva` bit(1) NOT NULL,
  `desconreteiva` bit(1) NOT NULL,
  `retexcomprar` bit(1) NOT NULL,
  `desconretevender` bit(1) NOT NULL,
  `porretencion` decimal(9,0) NOT NULL,
  `jefecompr` varchar(45) NOT NULL,
  `comprador` varchar(45) NOT NULL,
  `cuenta` varchar(12) NOT NULL,
  PRIMARY KEY (`codigocli`),
  KEY `fk_cuentaclie_idx` (`cuenta`),
  KEY `fk_paiscli_idx` (`idpais`),
  KEY `fk_dptocli_idx` (`iddpto`),
  KEY `fk_ciudadcli_idx` (`idciudad`),
  KEY `fk_vendedorcli_idx` (`idvendedor`),
  CONSTRAINT `fk_ciudadcli` FOREIGN KEY (`idciudad`) REFERENCES `ciudad` (`idciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentaclie` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_dptocli` FOREIGN KEY (`iddpto`) REFERENCES `departamento` (`iddept`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_paiscli` FOREIGN KEY (`idpais`) REFERENCES `pais` (`idpais`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendedorcli` FOREIGN KEY (`idvendedor`) REFERENCES `vendedor` (`idvendedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maecli`
--

LOCK TABLES `maecli` WRITE;
/*!40000 ALTER TABLE `maecli` DISABLE KEYS */;
INSERT INTO `maecli` VALUES (1,'1090398479','1','INGRID SUTACHAN','INGRID SUTACHAN','\0',1,2,7,'ALTOS','ALTOS','','243245','','42423DSFSF@HOTMAIL.COM',20,2423,3,'1',1,'','','','','\0','\0','',4,'CARLOS PEREZ','ANDRES VERDE','11050505'),(2,'10641','1','MARIA JOSE','MARIA JOSE','\0',1,1,1,'ALTOS','ALTTOS','','2424','','',10,1000,2,'1',1,'\0','\0','\0','\0','\0','\0','\0',0,'ANDRES REYES','CESAR REYES','11050505'),(3,'10902152','1','INGRID PEREZ','INGRID PEREZ','\0',1,1,1,'ALTOS','ALTOS','','24324','','',24,24324,2,'1',1,'\0','\0','\0','\0','\0','\0','\0',0,'ANDRES PEREZ','CARLOS PEREZ','1110');
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

-- Dump completed on 2015-02-04 13:33:02
