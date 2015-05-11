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
-- Table structure for table `movimi`
--

DROP TABLE IF EXISTS `movimi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimi` (
  `idmovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `idasiento` varchar(18) NOT NULL,
  `idsucursal` int(11) NOT NULL,
  `mes` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `fecha` datetime NOT NULL,
  `documento` varchar(15) NOT NULL,
  `idmoduloimprime` int(11) NOT NULL,
  `idtipodocumento` int(11) DEFAULT NULL,
  `codigcomprob` int(11) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `detalle` varchar(55) NOT NULL,
  `idcentro` int(11) DEFAULT NULL,
  `idnit` int(11) DEFAULT NULL,
  `referencia` varchar(10) DEFAULT NULL,
  `valordebito` decimal(16,2) NOT NULL,
  `valorcredito` decimal(16,2) NOT NULL,
  `baseimpuesto` decimal(16,2) NOT NULL,
  `valorica` decimal(16,2) NOT NULL,
  `entrada` int(11) DEFAULT NULL,
  `asientofijo` bit(1) NOT NULL,
  `actualizado` bit(1) NOT NULL,
  `idusuario` int(11) NOT NULL,
  `fechagrabacion` datetime NOT NULL,
  `idusuarioact` int(11) DEFAULT NULL,
  `fechaact` datetime DEFAULT NULL,
  `eliminado` bit(1) NOT NULL,
  PRIMARY KEY (`idmovimiento`),
  KEY `fk_ciamovimi_idx` (`idsucursal`),
  KEY `fk_compromovimi_idx` (`codigcomprob`),
  KEY `fk_ciacuenta_idx` (`cuenta`),
  KEY `fk_centromovimi_idx` (`idcentro`),
  KEY `fk_nitmovimi_idx` (`idnit`),
  KEY `fk_usuariomovimi_idx` (`idusuario`),
  KEY `fk_modulomovimi_idx` (`idmoduloimprime`),
  KEY `fk_tipomovimi_idx` (`idtipodocumento`),
  KEY `fk_usuarioactmovimi_idx` (`idusuarioact`),
  CONSTRAINT `fk_centromovimi` FOREIGN KEY (`idcentro`) REFERENCES `centrocostos` (`idcentro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ciamovimi` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_compromovimi` FOREIGN KEY (`codigcomprob`) REFERENCES `comprobante` (`codigcomprob`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentamovimi` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_modulomovimi` FOREIGN KEY (`idmoduloimprime`) REFERENCES `moduloppal` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nitmovimi` FOREIGN KEY (`idnit`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipodocmovimi` FOREIGN KEY (`idtipodocumento`) REFERENCES `maetrac` (`idtransaccion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuarioactmovimi` FOREIGN KEY (`idusuarioact`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuariomovimi` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimi`
--

LOCK TABLES `movimi` WRITE;
/*!40000 ALTER TABLE `movimi` DISABLE KEYS */;
INSERT INTO `movimi` VALUES (1,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,3,'1',10,3,'',100.00,0.00,0.00,0.00,NULL,'\0','',1,'2015-03-13 12:18:13',1,'2015-03-13 12:18:13','\0'),(2,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,8,'1',1,3,'',0.00,-10.00,0.00,0.00,NULL,'\0','',1,'2015-03-13 12:18:13',1,'2015-03-13 12:18:13','\0'),(3,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,5,'1',NULL,NULL,'',0.00,-40.00,0.00,-40.00,NULL,'\0','',1,'2015-03-13 12:18:13',1,'2015-03-13 12:18:13','\0'),(4,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,6,'1',NULL,2,'1',0.00,-50.00,0.00,-50.00,NULL,'\0','',1,'2015-03-13 12:18:13',1,'2015-03-13 12:18:13','\0'),(5,'12FIJO',1,1,'2015','2015-01-01 00:00:00','2fijo',7,NULL,1,3,'1',1,3,'',100.00,0.00,0.00,0.00,NULL,'','\0',1,'2015-03-13 12:30:22',NULL,NULL,'\0'),(6,'12FIJO',1,1,'2015','2015-01-01 00:00:00','2fijo',7,NULL,1,4,'1',10,3,'',0.00,-100.00,0.00,0.00,NULL,'','\0',1,'2015-03-13 12:30:22',NULL,NULL,'\0'),(9,'12',1,3,'2015','2015-03-01 00:00:00','2',7,NULL,1,3,'1',1,3,'1',100.00,0.00,0.00,0.00,NULL,'\0','',1,'2015-03-18 18:09:57',1,'2015-03-18 18:09:57',''),(10,'12',1,3,'2015','2015-03-01 00:00:00','2',7,NULL,1,3,'1',1,3,'',0.00,-100.00,0.00,0.00,NULL,'\0','',1,'2015-03-18 18:09:58',1,'2015-03-18 18:09:58',''),(11,'13FIJO',1,1,'2015','2015-01-01 00:00:00','3fijo',7,NULL,1,4,'1',1,3,'1',100.00,0.00,0.00,0.00,NULL,'','\0',1,'2015-03-18 18:14:54',NULL,NULL,''),(12,'13FIJO',1,1,'2015','2015-01-01 00:00:00','3fijo',7,NULL,1,36,'1',NULL,NULL,'1',0.00,-100.00,0.00,0.00,NULL,'','\0',1,'2015-03-18 18:14:54',NULL,NULL,'');
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

-- Dump completed on 2015-03-24 13:52:11
