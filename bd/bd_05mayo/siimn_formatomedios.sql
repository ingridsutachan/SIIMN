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
-- Table structure for table `formatomedios`
--

DROP TABLE IF EXISTS `formatomedios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formatomedios` (
  `idformatomedios` int(11) NOT NULL AUTO_INCREMENT,
  `numeroformatos` varchar(6) NOT NULL,
  `idcampo1` int(11) NOT NULL,
  `idcampo2` int(11) NOT NULL,
  `idcampo3` int(11) NOT NULL,
  `idcampo4` int(11) NOT NULL,
  `idcampo5` int(11) NOT NULL,
  `idcampo6` int(11) NOT NULL,
  `idcampo7` int(11) NOT NULL,
  `idcampo8` int(11) NOT NULL,
  `idcampo9` int(11) NOT NULL,
  `idcampo10` int(11) NOT NULL,
  `idcampo11` int(11) DEFAULT NULL,
  `idcampo12` int(11) DEFAULT NULL,
  `idcampo13` int(11) DEFAULT NULL,
  `idcampo14` int(11) DEFAULT NULL,
  `idcampo15` int(11) DEFAULT NULL,
  `idcampo16` int(11) DEFAULT NULL,
  PRIMARY KEY (`idformatomedios`),
  UNIQUE KEY `numeroformatos_UNIQUE` (`numeroformatos`),
  KEY `fk_campoformato_idx` (`idcampo1`),
  KEY `fk_campo2formato_idx` (`idcampo2`),
  KEY `fk_campo3formato_idx` (`idcampo3`),
  KEY `fk_campo4formato_idx` (`idcampo4`),
  KEY `fk_campo5formato_idx` (`idcampo5`),
  KEY `fk_campo6formato_idx` (`idcampo6`),
  KEY `fk_campo7formato_idx` (`idcampo7`),
  KEY `fk_campo8formato_idx` (`idcampo8`),
  KEY `fk_campo9formato_idx` (`idcampo9`),
  KEY `fk_campo10formato_idx` (`idcampo10`),
  KEY `fk_campo11formato_idx` (`idcampo11`),
  KEY `fk_campo12formato_idx` (`idcampo12`),
  KEY `fk_campo13formato_idx` (`idcampo13`),
  KEY `fk_campo14formato_idx` (`idcampo14`),
  KEY `fk_campo15formato_idx` (`idcampo15`),
  KEY `fk_campo16formato_idx` (`idcampo16`),
  CONSTRAINT `fk_campo10formato` FOREIGN KEY (`idcampo10`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo11formato` FOREIGN KEY (`idcampo11`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo12formato` FOREIGN KEY (`idcampo12`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo13formato` FOREIGN KEY (`idcampo13`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo14formato` FOREIGN KEY (`idcampo14`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo15formato` FOREIGN KEY (`idcampo15`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo16formato` FOREIGN KEY (`idcampo16`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo1formato` FOREIGN KEY (`idcampo1`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo2formato` FOREIGN KEY (`idcampo2`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo3formato` FOREIGN KEY (`idcampo3`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo4formato` FOREIGN KEY (`idcampo4`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo5formato` FOREIGN KEY (`idcampo5`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo6formato` FOREIGN KEY (`idcampo6`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo7formato` FOREIGN KEY (`idcampo7`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo8formato` FOREIGN KEY (`idcampo8`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_campo9formato` FOREIGN KEY (`idcampo9`) REFERENCES `campoformedios` (`idcampoformato`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formatomedios`
--

LOCK TABLES `formatomedios` WRITE;
/*!40000 ALTER TABLE `formatomedios` DISABLE KEYS */;
/*!40000 ALTER TABLE `formatomedios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-05 13:15:17
