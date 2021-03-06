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
-- Table structure for table `parametro`
--

DROP TABLE IF EXISTS `parametro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parametro` (
  `idparametro` int(11) NOT NULL AUTO_INCREMENT,
  `nombreparametro` varchar(45) NOT NULL,
  `idmoduloppal` int(11) NOT NULL,
  `descriparam` varchar(70) NOT NULL,
  `valorparam` varchar(75) NOT NULL,
  PRIMARY KEY (`idparametro`),
  KEY `fk_parmodulo_idx` (`idmoduloppal`),
  CONSTRAINT `fk_moduloparametro` FOREIGN KEY (`idmoduloppal`) REFERENCES `moduloppal` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parametro`
--

LOCK TABLES `parametro` WRITE;
/*!40000 ALTER TABLE `parametro` DISABLE KEYS */;
INSERT INTO `parametro` VALUES (1,'cueniniing',7,'CUENTA INICIAL DE INGRESOS CONTABILIDAD','1105'),(2,'cuenfining',7,'CUENTA FINAL DE INGRESOS CONTABILIDAD','1105'),(3,'cueninicos',7,'CUENTA INICIAL DE COSTOS CONTABILIDAD','1105'),(4,'cuenfincos',7,'CUENTA FINAL DE COSTOS CONTABILIDAD','1105'),(5,'cuenuti',7,'CUENTA UTILIDAD CONTABILIDAD','1105'),(6,'codcomp',7,'CODIGO COMPROBANTE CONTABILIDAD','1'),(7,'descomp',7,'DETALLE COMPROBANTE CIERRE CONTABILIDAD','OTRAS'),(8,'actlineaasiento',7,'ACTUALIZAR EN LINEA LOS ASIENTOS','1'),(9,'aniotrabajar',7,'AÑO EN EL CUAL SE ESTA TRABAJANDO','2015'),(10,'mestrabajar',7,'MES ACTUAL DE TRABAJO','03');
/*!40000 ALTER TABLE `parametro` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-05 13:15:19
