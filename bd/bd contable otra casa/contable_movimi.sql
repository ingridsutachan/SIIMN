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
-- Table structure for table `movimi`
--

DROP TABLE IF EXISTS `movimi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimi` (
  `idmovimi` int(11) NOT NULL AUTO_INCREMENT,
  `documento` varchar(10) NOT NULL,
  `idcentro` int(3) DEFAULT NULL,
  `idcompania` int(3) NOT NULL,
  `idasiento` int(11) NOT NULL,
  `idmes` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `fecha` datetime NOT NULL,
  `codicomp` int(11) NOT NULL,
  `cuenta` varchar(12) NOT NULL,
  `idnit` int(11) DEFAULT NULL,
  `cheque` varchar(8) DEFAULT NULL,
  `descrip` varchar(55) NOT NULL,
  `valorcredito` decimal(20,2) NOT NULL,
  `valordebito` decimal(20,2) NOT NULL,
  `imprime` bit(1) NOT NULL,
  `usuario` int(11) NOT NULL,
  `fechagraba` datetime NOT NULL,
  `actualizado` bit(1) NOT NULL,
  `usuarioactu` int(11) DEFAULT NULL,
  `fechaactualiz` datetime DEFAULT NULL,
  `asientofijo` bit(1) NOT NULL,
  PRIMARY KEY (`idmovimi`),
  KEY `fk_centro_idx` (`idcentro`),
  KEY `fk_compania_idx` (`idcompania`),
  KEY `fk_comprobante_idx` (`codicomp`),
  KEY `fk_cuentamov_idx` (`cuenta`),
  KEY `fk_usuarioguard_idx` (`usuario`),
  KEY `fk_nitmovi_idx` (`idnit`),
  KEY `fk_mesmov_idx` (`idmes`),
  CONSTRAINT `fk_centromov` FOREIGN KEY (`idcentro`) REFERENCES `centro` (`idcentro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_companiamov` FOREIGN KEY (`idcompania`) REFERENCES `compania` (`idcompania`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_comprobante` FOREIGN KEY (`codicomp`) REFERENCES `comprobante` (`codicomp`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentamov` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_mesmovim` FOREIGN KEY (`idmes`) REFERENCES `mes` (`idmes`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nitsmovi` FOREIGN KEY (`idnit`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuariogu` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COMMENT='Movimientos de Asientos Contables';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimi`
--

LOCK TABLES `movimi` WRITE;
/*!40000 ALTER TABLE `movimi` DISABLE KEYS */;
INSERT INTO `movimi` VALUES (3,'1',1,1,1,1,'2014','2014-07-09 19:13:35',1,'11050505',6,'1','1',-10000.00,0.00,'\0',1,'2014-07-09 19:15:43','\0',NULL,'0001-01-01 00:00:00','\0'),(4,'1',1,1,1,1,'2014','2014-07-09 19:13:35',1,'110506',6,'1','11',0.00,10000.00,'\0',1,'2014-07-09 19:15:43','\0',NULL,'0001-01-01 00:00:00','\0'),(5,'2',10,1,1,7,'2014','2014-07-10 07:19:44',1,'110506',6,'1','PAGOS',0.00,1000000.00,'\0',1,'2014-07-10 07:21:01','\0',NULL,'0001-01-01 00:00:00','\0'),(6,'2',1,1,1,7,'2014','2014-07-10 07:19:44',1,'413526',6,'1','VENTA',-1000000.00,0.00,'\0',1,'2014-07-10 07:21:01','\0',NULL,'0001-01-01 00:00:00','\0'),(7,'3',10,1,1,1,'2014','2014-07-10 07:24:04',1,'110506',1,'1','PAGO',-1500000.00,0.00,'\0',1,'2014-07-10 07:25:09','\0',NULL,'0001-01-01 00:00:00','\0'),(8,'3',10,1,1,1,'2014','2014-07-10 07:24:04',1,'61352601',9,'1','VENTA',0.00,1500000.00,'\0',1,'2014-07-10 07:25:09','\0',NULL,'0001-01-01 00:00:00','\0');
/*!40000 ALTER TABLE `movimi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-02-04 13:33:01
