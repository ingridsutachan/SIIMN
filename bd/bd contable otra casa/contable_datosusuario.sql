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
-- Table structure for table `datosusuario`
--

DROP TABLE IF EXISTS `datosusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `datosusuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT COMMENT 'identificacion usuario',
  `nombresusuario` varchar(45) NOT NULL COMMENT 'nombres usuario',
  `apellidosusuario` varchar(45) NOT NULL COMMENT 'apellidos usuario',
  `telefonousuario` varchar(45) NOT NULL COMMENT 'telefono usuario',
  `direccionusuario` varchar(45) NOT NULL COMMENT 'direccion usuario',
  `correousuario` varchar(45) DEFAULT NULL COMMENT 'correo electronico usuario',
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COMMENT='datos de usuario';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datosusuario`
--

LOCK TABLES `datosusuario` WRITE;
/*!40000 ALTER TABLE `datosusuario` DISABLE KEYS */;
INSERT INTO `datosusuario` VALUES (1,'ingrid','sutachan','3124538331','altos del tamarindo','ingridsutachan@hotmail.com');
/*!40000 ALTER TABLE `datosusuario` ENABLE KEYS */;
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
