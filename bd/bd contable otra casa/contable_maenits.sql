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
-- Table structure for table `maenits`
--

DROP TABLE IF EXISTS `maenits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maenits` (
  `idnit` int(11) NOT NULL AUTO_INCREMENT,
  `nit` varchar(10) NOT NULL COMMENT 'nit de proveedores',
  `digito` varchar(1) NOT NULL COMMENT 'Digito de verificacion de numero de nit',
  `idcompania` int(3) NOT NULL,
  `idtiponit` int(11) NOT NULL COMMENT 'tipo de nit ',
  `idpais` int(11) NOT NULL COMMENT 'pais de nit',
  `iddept` int(11) NOT NULL COMMENT 'departamento de nit',
  `idciudad` int(11) NOT NULL COMMENT 'ciudad de nit',
  `nomnit` varchar(45) NOT NULL COMMENT 'Nombre de nit',
  `acteconomica` varchar(10) NOT NULL,
  `direccion` varchar(60) DEFAULT NULL COMMENT 'direccion',
  `telefono` varchar(10) DEFAULT NULL,
  `celular` varchar(10) NOT NULL COMMENT 'numero de celular ',
  `email` varchar(40) DEFAULT NULL COMMENT 'correo electronico de nit',
  PRIMARY KEY (`idnit`),
  KEY `fk_tipo_idx` (`idtiponit`),
  KEY `fk_cianits_idx` (`idcompania`),
  KEY `fk_pais_idx` (`idpais`),
  KEY `fk_depto_idx` (`iddept`),
  KEY `fk_ciud_idx` (`idciudad`),
  KEY `fk_depto _idx` (`iddept`),
  CONSTRAINT `fk_cianits` FOREIGN KEY (`idcompania`) REFERENCES `compania` (`idcompania`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ciud` FOREIGN KEY (`idciudad`) REFERENCES `ciudad` (`idciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_depto` FOREIGN KEY (`iddept`) REFERENCES `departamento` (`iddept`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ippais` FOREIGN KEY (`idpais`) REFERENCES `pais` (`idpais`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipo` FOREIGN KEY (`idtiponit`) REFERENCES `tiponit` (`idtiponit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COMMENT='Maestro para nits y/o terceros';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maenits`
--

LOCK TABLES `maenits` WRITE;
/*!40000 ALTER TABLE `maenits` DISABLE KEYS */;
INSERT INTO `maenits` VALUES (1,'1090398479','1',1,2,1,2,2,'Ingrid Johanna Sutachan','4545456','Altos del tamarindo j-16','1654564','565465454','ingrid@hotmail.com'),(4,'105654646','1',1,1,1,3,9,'EMPRESA PUBLICA','54564','EL POBLADO','25454654','243545','ADJHSD@HOT.COM'),(6,'10126555','2',1,2,1,3,9,'maria camila','343434','calle 40 av','434354','453454','dfsdfsdf@hotmail.com'),(8,'2123165654','1',1,2,1,2,8,'carlos','5652465465','calle 30','','3213213223','adasdasd@hotmial.com'),(9,'1092941363','1',1,7,1,2,7,'MARIA JOSE CELIS SUTACHAN','54654654','ALTOS DEL TAMARINDO VILLA DEL ROSARIO CASA J-16','5708523','3124538331','MAJOCELIS@HOTMAIL.COM');
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

-- Dump completed on 2015-02-04 13:33:03
