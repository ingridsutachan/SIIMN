CREATE DATABASE  IF NOT EXISTS `siimn` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `siimn`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
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
-- Table structure for table `acucentr`
--

DROP TABLE IF EXISTS `acucentr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acucentr` (
  `idacucentr` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `anio` varchar(4) DEFAULT NULL,
  `mes` int(11) NOT NULL,
  `idcentro` int(11) DEFAULT NULL,
  `idnit` int(11) DEFAULT NULL,
  `idcuenta` int(11) NOT NULL,
  `saldomes` decimal(16,2) NOT NULL,
  `debimes` decimal(16,2) NOT NULL,
  `credimes` decimal(16,2) NOT NULL,
  PRIMARY KEY (`idacucentr`),
  KEY `fk_ciaacucentro_idx` (`idsucursal`),
  KEY `fk_centroacucentro_idx` (`idcentro`),
  KEY `fk_nitacucentro_idx` (`idnit`),
  KEY `fk_cuentaacucentro_idx` (`idcuenta`),
  CONSTRAINT `fk_centroacucentro` FOREIGN KEY (`idcentro`) REFERENCES `centrocostos` (`idcentro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ciaacucentro` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentaacucentro` FOREIGN KEY (`idcuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nitacucentro` FOREIGN KEY (`idnit`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acucentr`
--

LOCK TABLES `acucentr` WRITE;
/*!40000 ALTER TABLE `acucentr` DISABLE KEYS */;
INSERT INTO `acucentr` VALUES (1,1,'2015',1,10,3,4,0.00,0.00,0.00),(2,1,'2015',2,10,3,4,0.00,0.00,0.00),(3,1,'2015',3,10,3,4,161598.40,161598.40,0.00),(4,1,'2015',4,10,3,4,0.00,0.00,0.00),(5,1,'2015',5,10,3,4,0.00,0.00,0.00),(6,1,'2015',6,10,3,4,0.00,0.00,0.00),(7,1,'2015',7,10,3,4,0.00,0.00,0.00),(8,1,'2015',8,10,3,4,0.00,0.00,0.00),(9,1,'2015',9,10,3,4,0.00,0.00,0.00),(10,1,'2015',10,10,3,4,0.00,0.00,0.00),(11,1,'2015',11,10,3,4,0.00,0.00,0.00),(12,1,'2015',12,10,3,4,0.00,0.00,0.00),(13,1,'2015',1,1,3,10,0.00,0.00,0.00),(14,1,'2015',2,1,3,10,0.00,0.00,0.00),(15,1,'2015',3,1,3,10,-17598.40,0.00,-17598.40),(16,1,'2015',4,1,3,10,0.00,0.00,0.00),(17,1,'2015',5,1,3,10,0.00,0.00,0.00),(18,1,'2015',6,1,3,10,0.00,0.00,0.00),(19,1,'2015',7,1,3,10,0.00,0.00,0.00),(20,1,'2015',8,1,3,10,0.00,0.00,0.00),(21,1,'2015',9,1,3,10,0.00,0.00,0.00),(22,1,'2015',10,1,3,10,0.00,0.00,0.00),(23,1,'2015',11,1,3,10,0.00,0.00,0.00),(24,1,'2015',12,1,3,10,0.00,0.00,0.00),(25,1,'2015',1,1,3,4,0.00,0.00,0.00),(26,1,'2015',2,1,3,4,0.00,0.00,0.00),(27,1,'2015',3,1,3,4,0.00,1600.00,-1600.00),(28,1,'2015',4,1,3,4,0.00,0.00,0.00),(29,1,'2015',5,1,3,4,0.00,0.00,0.00),(30,1,'2015',6,1,3,4,0.00,0.00,0.00),(31,1,'2015',7,1,3,4,0.00,0.00,0.00),(32,1,'2015',8,1,3,4,0.00,0.00,0.00),(33,1,'2015',9,1,3,4,0.00,0.00,0.00),(34,1,'2015',10,1,3,4,0.00,0.00,0.00),(35,1,'2015',11,1,3,4,0.00,0.00,0.00),(36,1,'2015',12,1,3,4,0.00,0.00,0.00);
/*!40000 ALTER TABLE `acucentr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cajero`
--

DROP TABLE IF EXISTS `cajero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cajero` (
  `idcajero` int(11) NOT NULL,
  `nombrecaje` varchar(45) NOT NULL,
  `usuariocaje` varchar(10) NOT NULL,
  `clave` char(32) NOT NULL,
  `idmodulo` int(11) NOT NULL,
  PRIMARY KEY (`idcajero`),
  KEY `fk_modulocajero_idx` (`idmodulo`),
  CONSTRAINT `fk_modulocajero` FOREIGN KEY (`idmodulo`) REFERENCES `modulo` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cajero`
--

LOCK TABLES `cajero` WRITE;
/*!40000 ALTER TABLE `cajero` DISABLE KEYS */;
/*!40000 ALTER TABLE `cajero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campoformedios`
--

DROP TABLE IF EXISTS `campoformedios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `campoformedios` (
  `idcampoformato` int(11) NOT NULL,
  `nombrecampo` varchar(45) NOT NULL,
  PRIMARY KEY (`idcampoformato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campoformedios`
--

LOCK TABLES `campoformedios` WRITE;
/*!40000 ALTER TABLE `campoformedios` DISABLE KEYS */;
/*!40000 ALTER TABLE `campoformedios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `centrocostos`
--

DROP TABLE IF EXISTS `centrocostos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centrocostos` (
  `idcentro` int(11) NOT NULL,
  `nombrecentro` varchar(45) NOT NULL,
  PRIMARY KEY (`idcentro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `centrocostos`
--

LOCK TABLES `centrocostos` WRITE;
/*!40000 ALTER TABLE `centrocostos` DISABLE KEYS */;
INSERT INTO `centrocostos` VALUES (1,'GASTOS'),(2,'VENTAS'),(3,'ENTRADAS'),(4,'VARIOS'),(5,'OTROS02'),(6,'ALIMENTOS'),(10,'PRUEBA OTRO'),(11,'CENTRO OTROS GASTOS'),(12,'CENTRO COSTOS');
/*!40000 ALTER TABLE `centrocostos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudad` (
  `idciudad` int(11) NOT NULL AUTO_INCREMENT,
  `codigodepto` int(11) NOT NULL,
  `codigociudad` varchar(3) NOT NULL,
  `nombreciudad` varchar(45) NOT NULL,
  PRIMARY KEY (`idciudad`),
  KEY `fk_dept_idx` (`codigodepto`),
  CONSTRAINT `fk_deptociudad` FOREIGN KEY (`codigodepto`) REFERENCES `departamento` (`iddept`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,2,'001','MEDELLIN'),(2,2,'002','ABEJORRAL'),(3,5,'001','BOGOTA D.C'),(4,4,'001','BARRANQUILLA'),(5,4,'078','BARANOA'),(6,6,'001','CARTAGENA DE INDIAS'),(7,6,'006','ACHI'),(8,7,'001','TUNJA'),(9,7,'238','DUITAMA'),(10,7,'176','CHIQUINQUIRA');
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idcliente` int(11) NOT NULL AUTO_INCREMENT,
  `idtipodto` int(11) NOT NULL,
  `documento` varchar(12) NOT NULL,
  `digito` varchar(1) DEFAULT NULL,
  `nombre` varchar(50) NOT NULL,
  `idciudad` int(11) NOT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `celular` varchar(10) DEFAULT NULL,
  `fax` varchar(10) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcliente`),
  KEY `fk_tipocliente_idx` (`idtipodto`),
  KEY `fk_ciudadcliente_idx` (`idciudad`),
  CONSTRAINT `fk_ciudadcliente` FOREIGN KEY (`idciudad`) REFERENCES `ciudad` (`idciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipodtocliente` FOREIGN KEY (`idtipodto`) REFERENCES `tiponit` (`idtiponit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compania`
--

DROP TABLE IF EXISTS `compania`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compania` (
  `idcompania` int(11) NOT NULL,
  `nombrecia` varchar(45) NOT NULL,
  `nit` varchar(10) NOT NULL,
  `digito` varchar(1) NOT NULL,
  PRIMARY KEY (`idcompania`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compania`
--

LOCK TABLES `compania` WRITE;
/*!40000 ALTER TABLE `compania` DISABLE KEYS */;
INSERT INTO `compania` VALUES (1,'MARKETING SOFTWARE DE COLOMBIA LTDA','830017347','6');
/*!40000 ALTER TABLE `compania` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comprobante`
--

DROP TABLE IF EXISTS `comprobante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comprobante` (
  `codigcomprob` int(11) NOT NULL,
  `descripcomprob` varchar(45) NOT NULL,
  `consecutivo` bit(1) NOT NULL,
  `numsiguiente` int(11) DEFAULT NULL,
  `codigootra` varchar(3) NOT NULL,
  PRIMARY KEY (`codigcomprob`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comprobante`
--

LOCK TABLES `comprobante` WRITE;
/*!40000 ALTER TABLE `comprobante` DISABLE KEYS */;
INSERT INTO `comprobante` VALUES (1,'PRUEBA SIEMPRE','\0',1,'1'),(10,'COMPROBANTE OTRO','',12,'145'),(12,'COMPROBANTE PRUEBA 1','\0',123,'12');
/*!40000 ALTER TABLE `comprobante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conceptospagos`
--

DROP TABLE IF EXISTS `conceptospagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conceptospagos` (
  `idconceptospago` int(11) NOT NULL,
  `descripconcep` varchar(45) NOT NULL,
  `cuenta` varchar(10) NOT NULL,
  `codformaspago` varchar(2) NOT NULL,
  `porcentaje` decimal(3,2) NOT NULL,
  PRIMARY KEY (`idconceptospago`),
  KEY `fk_cuentaconceptos_idx` (`cuenta`),
  KEY `fk_formaconceptos_idx` (`codformaspago`),
  CONSTRAINT `fk_cuentaconceptos` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conceptospagos`
--

LOCK TABLES `conceptospagos` WRITE;
/*!40000 ALTER TABLE `conceptospagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `conceptospagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conexuser`
--

DROP TABLE IF EXISTS `conexuser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conexuser` (
  `idconexion` int(11) NOT NULL AUTO_INCREMENT,
  `idusuario` int(11) NOT NULL,
  `idcompania` int(11) NOT NULL,
  `fechaconex` datetime NOT NULL,
  `fechadescon` datetime NOT NULL,
  PRIMARY KEY (`idconexion`),
  KEY `fk_userconex_idx` (`idusuario`),
  KEY `fk_usercia_idx` (`idcompania`),
  CONSTRAINT `fk_usercia` FOREIGN KEY (`idcompania`) REFERENCES `compania` (`idcompania`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_userconex` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conexuser`
--

LOCK TABLES `conexuser` WRITE;
/*!40000 ALTER TABLE `conexuser` DISABLE KEYS */;
/*!40000 ALTER TABLE `conexuser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `datosusuario`
--

DROP TABLE IF EXISTS `datosusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `datosusuario` (
  `idusuariodat` int(11) NOT NULL AUTO_INCREMENT,
  `cedula` varchar(10) NOT NULL,
  `nombresusuario` varchar(30) NOT NULL,
  `apellidosusuario` varchar(30) NOT NULL,
  `telefonousuario` varchar(10) NOT NULL,
  `direccionusuario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idusuariodat`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datosusuario`
--

LOCK TABLES `datosusuario` WRITE;
/*!40000 ALTER TABLE `datosusuario` DISABLE KEYS */;
INSERT INTO `datosusuario` VALUES (1,'1090398479','INGRID ','SUTACHAN','3124538331','CRA');
/*!40000 ALTER TABLE `datosusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamento` (
  `iddept` int(11) NOT NULL AUTO_INCREMENT,
  `idpais` int(11) NOT NULL,
  `codigodepto` varchar(2) NOT NULL,
  `nombredept` varchar(45) NOT NULL,
  PRIMARY KEY (`iddept`),
  KEY `fk_pais_idx` (`idpais`),
  CONSTRAINT `fk_paisdept` FOREIGN KEY (`idpais`) REFERENCES `pais` (`idpais`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,7,'91','AMAZONAS'),(2,7,'25','ANTIOQUIA'),(3,7,'81','ARAUCA'),(4,7,'08','ATLANTICO'),(5,7,'11','BOGOTA D.C'),(6,7,'13','BOLIVAR'),(7,7,'15','BOYACA'),(8,7,'17','CALDAS'),(9,7,'18','CAQUETA');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formaspago`
--

DROP TABLE IF EXISTS `formaspago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formaspago` (
  `idformaspago` int(11) NOT NULL AUTO_INCREMENT,
  `codformaspago` varchar(2) NOT NULL,
  `nombreforma` varchar(45) NOT NULL,
  `sivence` bit(1) NOT NULL,
  PRIMARY KEY (`idformaspago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formaspago`
--

LOCK TABLES `formaspago` WRITE;
/*!40000 ALTER TABLE `formaspago` DISABLE KEYS */;
/*!40000 ALTER TABLE `formaspago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formato`
--

DROP TABLE IF EXISTS `formato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formato` (
  `idformato` int(11) NOT NULL AUTO_INCREMENT,
  `idmoduloppal` int(11) NOT NULL,
  `codigofor` int(11) NOT NULL,
  `codigotipo` int(11) NOT NULL,
  `activo` bit(1) NOT NULL,
  `fila` int(11) DEFAULT NULL,
  `columna` int(11) DEFAULT NULL,
  `condensa` bit(1) NOT NULL,
  `presentacion` varchar(45) DEFAULT NULL,
  `titulo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idformato`),
  KEY `fk_tipoformato_idx` (`codigotipo`),
  KEY `fk_moduloformato_idx` (`idmoduloppal`),
  CONSTRAINT `fk_moduloformato` FOREIGN KEY (`idmoduloppal`) REFERENCES `moduloppal` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipoformato` FOREIGN KEY (`codigotipo`) REFERENCES `tipoformato` (`codigotipo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formato`
--

LOCK TABLES `formato` WRITE;
/*!40000 ALTER TABLE `formato` DISABLE KEYS */;
/*!40000 ALTER TABLE `formato` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `inflacion`
--

DROP TABLE IF EXISTS `inflacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inflacion` (
  `idinflacion` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `mes` varchar(2) NOT NULL,
  `inflamensual` decimal(4,2) NOT NULL,
  PRIMARY KEY (`idinflacion`),
  KEY `fk_sucursalinfla_idx` (`idsucursal`),
  CONSTRAINT `fk_sucursalinfla` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inflacion`
--

LOCK TABLES `inflacion` WRITE;
/*!40000 ALTER TABLE `inflacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `inflacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maebanta`
--

DROP TABLE IF EXISTS `maebanta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maebanta` (
  `idbanta` int(11) NOT NULL,
  `codigobanta` varchar(2) NOT NULL,
  `nombrebanta` varchar(45) NOT NULL,
  `tipobanta` varchar(1) NOT NULL,
  PRIMARY KEY (`idbanta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maebanta`
--

LOCK TABLES `maebanta` WRITE;
/*!40000 ALTER TABLE `maebanta` DISABLE KEYS */;
/*!40000 ALTER TABLE `maebanta` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `maeconcc`
--

DROP TABLE IF EXISTS `maeconcc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maeconcc` (
  `idconcepto` int(11) NOT NULL,
  `descripconcepto` varchar(45) NOT NULL,
  PRIMARY KEY (`idconcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maeconcc`
--

LOCK TABLES `maeconcc` WRITE;
/*!40000 ALTER TABLE `maeconcc` DISABLE KEYS */;
/*!40000 ALTER TABLE `maeconcc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maeconta`
--

DROP TABLE IF EXISTS `maeconta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maeconta` (
  `idcuenta` int(11) NOT NULL AUTO_INCREMENT,
  `cuenta` varchar(10) NOT NULL,
  `tipocta` varchar(1) NOT NULL,
  `nombre` varchar(70) NOT NULL,
  `pidenit` bit(1) NOT NULL,
  `centro` bit(1) NOT NULL,
  `ajustesinteg` bit(1) NOT NULL,
  `idnitajustes` int(11) DEFAULT NULL,
  `cueaju` int(11) DEFAULT NULL,
  `cuencorre` int(11) DEFAULT NULL,
  `ajudoc` varchar(1) DEFAULT NULL,
  `retencion` bit(1) NOT NULL,
  `porete` decimal(4,2) DEFAULT NULL,
  `conceprete` varchar(70) DEFAULT NULL,
  `reteica` bit(1) NOT NULL,
  `poreteica` decimal(4,2) DEFAULT NULL,
  `concepreteica` varchar(45) DEFAULT NULL,
  `cuentacierre` int(11) DEFAULT NULL,
  `codformatomedios` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcuenta`),
  UNIQUE KEY `cuenta_UNIQUE` (`cuenta`),
  KEY `fk_formatocuenta_idx` (`codformatomedios`),
  KEY `fk_cuentacorre_idx` (`cuenta`,`cuencorre`),
  KEY `fk_nitcuenta_idx` (`idnitajustes`),
  KEY `fk_cuentacueaju_idx` (`cueaju`),
  KEY `fk_cuentacuecor_idx` (`cuencorre`),
  KEY `fk_cuentacuecierre_idx` (`cuentacierre`),
  CONSTRAINT `fk_cuentacueaju` FOREIGN KEY (`cueaju`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentacuecierre` FOREIGN KEY (`cuentacierre`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentacuecor` FOREIGN KEY (`cuencorre`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_formatomedioscuenta` FOREIGN KEY (`codformatomedios`) REFERENCES `formatomedios` (`idformatomedios`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nitcuenta` FOREIGN KEY (`idnitajustes`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maeconta`
--

LOCK TABLES `maeconta` WRITE;
/*!40000 ALTER TABLE `maeconta` DISABLE KEYS */;
INSERT INTO `maeconta` VALUES (1,'1','M','ACTIVO','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(2,'11','M','DISPONIBLE','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(3,'1102','M','CUENTA AUXILIAR PRUEBA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(4,'110201','A','CUENTA MAS','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(5,'110204','A','CUENTA RETENCION ICA','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',0.00,NULL,'',3.50,'HONORARIOS 3.5',NULL,NULL),(6,'110205','A','OTRA PRUEBA','','\0','\0',NULL,NULL,NULL,NULL,'\0',0.00,NULL,'',2.50,'ICA 2.5',NULL,NULL),(7,'1103','M','CUENTA AUXILIAR PRUEBA 2','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(8,'1104','M','CUENTA AUXILIAR PRUEBA 3','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(9,'1105','M','CAJA','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(10,'110505','A','CAJA GENERAL','','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,22,NULL),(11,'11050501','A','CAJA GENERAL SEDE NORTE','\0','\0','',1,24,23,'D','\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(12,'11050502','A','CAJA GENERAL OTRA SEDE','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(13,'11050503','A','CAJA GENERAL SEDE 3','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,21,NULL),(14,'1106','M','CUENTA AUXILIAR 4 PRUEBA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(15,'1107','M','CUENTA AUXILIAR 5 PRUEBA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(16,'1108','M','CUENTA PRUEBA 7','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(17,'1109','M','CUENTA OTRA PRUEBA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(18,'1110','M','BANCOS','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(19,'111005','A','MONEDA NACIONAL ','','','',1,11,25,'D','\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(20,'1112','M','CUENTA AUXILIAR SIGUIENTE PRUEBA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(21,'1113','M','CUENTA OTRA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,20,NULL),(22,'1114','A','OTRA CUENTA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(23,'1115','M','REMESAS EN TRANSITO','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(24,'1116','M','CUENTA AUXILIAR OTRA PRUEBA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,19,NULL),(25,'1117','M','CUENTA OTRA PRUEBA DOS','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(26,'1118','M','PRUEBA CUENTA OTRA','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(27,'1120','M','CUENTA OTRA PR','','','\0',NULL,NULL,NULL,NULL,'',2.50,'RETENCION 2.5','\0',NULL,NULL,NULL,NULL),(28,'1125','M','FONDOS','\0','\0','',1,10,26,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(29,'1140','M','CUENTA VALOR','','','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(30,'12','M','INVERSIONES','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(31,'4','M','PATRIMONIO','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(32,'5','M','GASTOS','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(33,'6','M','COSTOS DE VENTA','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(34,'7','M','COSTOS DE PRODUCION O DE OPERACION','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(35,'8','M','CUENTAS DE ORDEN DEUDORAS','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,'\0',NULL,NULL,NULL,NULL),(36,'110203','A','CUENTA OTRA DETALLE','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',0.00,NULL,'\0',0.00,NULL,NULL,NULL);
/*!40000 ALTER TABLE `maeconta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maenits`
--

DROP TABLE IF EXISTS `maenits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maenits` (
  `idnit` int(11) NOT NULL AUTO_INCREMENT,
  `idtiponit` int(11) NOT NULL,
  `nit` varchar(12) NOT NULL,
  `digito` varchar(1) NOT NULL,
  `nombrenit` varchar(45) NOT NULL,
  `idciudad` int(11) NOT NULL,
  `acteconomic` varchar(10) NOT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `celular` varchar(10) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idnit`),
  KEY `fk_ciudad_idx` (`idciudad`),
  KEY `fk_tiponits_idx` (`idtiponit`),
  CONSTRAINT `fk_ciudadnits` FOREIGN KEY (`idciudad`) REFERENCES `ciudad` (`idciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tiponitnits` FOREIGN KEY (`idtiponit`) REFERENCES `tiponit` (`idtiponit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maenits`
--

LOCK TABLES `maenits` WRITE;
/*!40000 ALTER TABLE `maenits` DISABLE KEYS */;
INSERT INTO `maenits` VALUES (1,1,'1090398479','1','INGRID JOHANNA SUTACHAN',3,'1120','CALLE 168','123','123','INGRIDSUTACHAN@HOTMAIL.COM'),(2,2,'1092941363','1','MARIA JOSE CELIS SUTACHAN',3,'1234','CRA 8H','','3124538331','MAJOCELIS@HOTMAIL.COM'),(3,1,'1090256478','1','CAROLINA MARTINEZ',3,'102544','CRA','','315823146','');
/*!40000 ALTER TABLE `maenits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maepagos`
--

DROP TABLE IF EXISTS `maepagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maepagos` (
  `idpagos` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `mes` int(11) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `idnit` int(11) NOT NULL,
  `saldomes` decimal(16,2) NOT NULL,
  `debimes` decimal(16,2) NOT NULL,
  `credimes` decimal(16,2) NOT NULL,
  PRIMARY KEY (`idpagos`),
  KEY `fk_ciapagos_idx` (`idsucursal`),
  KEY `fk_cuentapagos_idx` (`cuenta`),
  KEY `fk_nitpagos_idx` (`idnit`),
  CONSTRAINT `fk_ciapagos` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentapagos` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nitpagos` FOREIGN KEY (`idnit`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maepagos`
--

LOCK TABLES `maepagos` WRITE;
/*!40000 ALTER TABLE `maepagos` DISABLE KEYS */;
INSERT INTO `maepagos` VALUES (1,1,'2015',1,4,3,0.00,0.00,0.00),(2,1,'2015',2,4,3,0.00,0.00,0.00),(3,1,'2015',3,4,3,161598.40,163198.40,-1600.00),(4,1,'2015',4,4,3,0.00,0.00,0.00),(5,1,'2015',5,4,3,0.00,0.00,0.00),(6,1,'2015',6,4,3,0.00,0.00,0.00),(7,1,'2015',7,4,3,0.00,0.00,0.00),(8,1,'2015',8,4,3,0.00,0.00,0.00),(9,1,'2015',9,4,3,0.00,0.00,0.00),(10,1,'2015',10,4,3,0.00,0.00,0.00),(11,1,'2015',11,4,3,0.00,0.00,0.00),(12,1,'2015',12,4,3,0.00,0.00,0.00),(13,1,'2015',1,10,3,0.00,0.00,0.00),(14,1,'2015',2,10,3,0.00,0.00,0.00),(15,1,'2015',3,10,3,-15998.40,1600.00,-17598.40),(16,1,'2015',4,10,3,0.00,0.00,0.00),(17,1,'2015',5,10,3,0.00,0.00,0.00),(18,1,'2015',6,10,3,0.00,0.00,0.00),(19,1,'2015',7,10,3,0.00,0.00,0.00),(20,1,'2015',8,10,3,0.00,0.00,0.00),(21,1,'2015',9,10,3,0.00,0.00,0.00),(22,1,'2015',10,10,3,0.00,0.00,0.00),(23,1,'2015',11,10,3,0.00,0.00,0.00),(24,1,'2015',12,10,3,0.00,0.00,0.00),(25,1,'2015',1,6,2,0.00,0.00,0.00),(26,1,'2015',2,6,2,0.00,0.00,0.00),(27,1,'2015',3,6,2,-80000.00,0.00,-80000.00),(28,1,'2015',4,6,2,0.00,0.00,0.00),(29,1,'2015',5,6,2,0.00,0.00,0.00),(30,1,'2015',6,6,2,0.00,0.00,0.00),(31,1,'2015',7,6,2,0.00,0.00,0.00),(32,1,'2015',8,6,2,0.00,0.00,0.00),(33,1,'2015',9,6,2,0.00,0.00,0.00),(34,1,'2015',10,6,2,0.00,0.00,0.00),(35,1,'2015',11,6,2,0.00,0.00,0.00),(36,1,'2015',12,6,2,0.00,0.00,0.00);
/*!40000 ALTER TABLE `maepagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maetrac`
--

DROP TABLE IF EXISTS `maetrac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maetrac` (
  `idtransaccion` int(11) NOT NULL,
  `codigotrac` varchar(2) NOT NULL,
  `idmoduloppal` int(11) NOT NULL,
  `nombretrac` varchar(45) NOT NULL,
  `afectasaldo` varchar(1) NOT NULL,
  `afectaotro` bit(1) NOT NULL,
  `generaasiento` bit(1) NOT NULL,
  `consecutivo` bit(1) NOT NULL,
  `numeroactual` int(11) DEFAULT NULL,
  `codigcomp` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtransaccion`),
  UNIQUE KEY `codigotrac_UNIQUE` (`codigotrac`),
  KEY `fk_comprtrac_idx` (`codigcomp`),
  KEY `fk_modulomaetrac_idx` (`idmoduloppal`),
  CONSTRAINT `fk_comprtrac` FOREIGN KEY (`codigcomp`) REFERENCES `comprobante` (`codigcomprob`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_modulotrac` FOREIGN KEY (`idmoduloppal`) REFERENCES `moduloppal` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maetrac`
--

LOCK TABLES `maetrac` WRITE;
/*!40000 ALTER TABLE `maetrac` DISABLE KEYS */;
/*!40000 ALTER TABLE `maetrac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maetribut`
--

DROP TABLE IF EXISTS `maetribut`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maetribut` (
  `idtributario` int(11) NOT NULL,
  `codigotrib` varchar(5) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `tope` decimal(6,2) DEFAULT NULL,
  `idnittope` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtributario`),
  UNIQUE KEY `codigotrib_UNIQUE` (`codigotrib`),
  KEY `fk_nittrib_idx` (`idnittope`),
  CONSTRAINT `fk_nittrib` FOREIGN KEY (`idnittope`) REFERENCES `maenits` (`idnit`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maetribut`
--

LOCK TABLES `maetribut` WRITE;
/*!40000 ALTER TABLE `maetribut` DISABLE KEYS */;
INSERT INTO `maetribut` VALUES (1,'1','SIGUIENTE',0.00,2),(2,'12','PRUEBA',100.02,1),(3,'14','OTRAS COSAS',100.00,2),(4,'2','SEGUNDA PRUEBA',12.00,NULL);
/*!40000 ALTER TABLE `maetribut` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulo`
--

DROP TABLE IF EXISTS `modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modulo` (
  `idmodulo` int(11) NOT NULL,
  `idmoduloppal` int(11) NOT NULL,
  `nombremod` varchar(45) NOT NULL,
  PRIMARY KEY (`idmodulo`),
  KEY `fk_modulo_idx` (`idmoduloppal`),
  CONSTRAINT `fk_moduloppalmodulo` FOREIGN KEY (`idmoduloppal`) REFERENCES `moduloppal` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulo`
--

LOCK TABLES `modulo` WRITE;
/*!40000 ALTER TABLE `modulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moduloppal`
--

DROP TABLE IF EXISTS `moduloppal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `moduloppal` (
  `idmodulo` int(11) NOT NULL,
  `codigmoduloppal` varchar(2) NOT NULL,
  `nombremodppal` varchar(45) NOT NULL,
  PRIMARY KEY (`idmodulo`),
  UNIQUE KEY `codigmoduloppal_UNIQUE` (`codigmoduloppal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moduloppal`
--

LOCK TABLES `moduloppal` WRITE;
/*!40000 ALTER TABLE `moduloppal` DISABLE KEYS */;
INSERT INTO `moduloppal` VALUES (1,'C','CARTERA'),(2,'F','FACTURA'),(3,'H ','CHEQUES'),(4,'I','INVENTARIO'),(5,'N','NOMINA'),(6,'P ','PROVEEDORES'),(7,'T','CONTABILIDAD');
/*!40000 ALTER TABLE `moduloppal` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimi`
--

LOCK TABLES `movimi` WRITE;
/*!40000 ALTER TABLE `movimi` DISABLE KEYS */;
INSERT INTO `movimi` VALUES (1,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,5,'1',NULL,NULL,'',0.00,-4000.00,0.00,-400000.00,NULL,'\0','\0',1,'2015-03-24 21:06:48',1,'2015-04-23 09:51:47','\0'),(2,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,4,'1',10,3,'PROBAR',10099.90,0.00,0.00,0.00,NULL,'\0','\0',1,'2015-03-24 21:06:48',1,'2015-04-23 09:51:50','\0'),(3,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,10,'1',1,3,'',0.00,-1099.90,0.00,0.00,NULL,'\0','\0',1,'2015-03-24 21:06:47',1,'2015-04-23 09:51:52','\0'),(4,'11',1,3,'2015','2015-03-01 00:00:00','1',7,NULL,1,6,'1',NULL,2,'1',0.00,-5000.00,0.00,-500000.00,NULL,'\0','\0',1,'2015-03-24 21:06:46',1,'2015-04-23 09:51:54','\0'),(5,'12FIJO',1,1,'2015','2015-01-01 00:00:00','2FIJO',7,NULL,1,4,'1',1,3,'',100.00,0.00,0.00,5.10,NULL,'','\0',1,'2015-03-13 12:30:22',NULL,NULL,'\0'),(6,'12FIJO',1,1,'2015','2015-01-01 00:00:00','2FIJO',7,NULL,1,4,'1',10,3,'',0.00,-100.00,0.00,0.00,NULL,'','\0',1,'2015-03-13 12:30:22',NULL,NULL,'\0'),(9,'12',1,3,'2015','2015-03-01 00:00:00','2',7,NULL,1,4,'1',1,3,'1',100.00,0.00,0.00,0.00,NULL,'\0','\0',1,'2015-03-18 18:09:57',1,'2015-04-23 09:51:56','\0'),(10,'12',1,3,'2015','2015-03-01 00:00:00','2',7,NULL,1,4,'1',1,3,'',0.00,-100.00,0.00,0.00,NULL,'\0','\0',1,'2015-03-18 18:09:58',1,'2015-04-23 09:51:57','\0'),(11,'13FIJO',1,1,'2015','2015-01-01 00:00:00','3FIJO',7,NULL,1,4,'1',1,3,'1',100.00,0.00,0.00,0.00,NULL,'','\0',1,'2015-03-18 18:14:54',NULL,NULL,'\0'),(12,'13FIJO',1,1,'2015','2015-01-01 00:00:00','3FIJO',7,NULL,1,36,'1',NULL,NULL,'1',0.00,-100.00,0.00,0.00,NULL,'','\0',1,'2015-03-18 18:14:54',NULL,NULL,'\0'),(13,'14',1,3,'2015','2015-03-01 00:00:00','4',7,NULL,1,10,'1',NULL,3,'1',100.00,0.00,0.00,0.00,NULL,'\0','\0',1,'2015-03-31 15:31:11',1,'2015-04-23 09:51:59','\0'),(14,'14',1,3,'2015','2015-03-01 00:00:00','4',7,NULL,1,11,'11',NULL,NULL,'1',0.00,-100.00,0.00,0.00,NULL,'\0','\0',1,'2015-03-31 15:31:11',1,'2015-04-23 09:52:00','\0');
/*!40000 ALTER TABLE `movimi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pais`
--

DROP TABLE IF EXISTS `pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pais` (
  `idpais` int(11) NOT NULL,
  `codpais` varchar(3) NOT NULL,
  `nombrepais` varchar(45) NOT NULL,
  PRIMARY KEY (`idpais`),
  UNIQUE KEY `codpais_UNIQUE` (`codpais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pais`
--

LOCK TABLES `pais` WRITE;
/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
INSERT INTO `pais` VALUES (1,'013','AFGANISTAN'),(2,'017','ALBANIA'),(3,'023','ALEMANIA'),(4,'027','ARUBA'),(5,'063','ARGENTINA'),(6,'069','AUSTRALIA'),(7,'169','COLOMBIA'),(8,'196','COSTA RICA'),(9,'199','CUBA'),(10,'239','ECUADOR'),(11,'850','VENEZUELA');
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `permiso`
--

DROP TABLE IF EXISTS `permiso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permiso` (
  `idpermiso` int(11) NOT NULL AUTO_INCREMENT,
  `idusuario` int(11) NOT NULL,
  `idmodulo` int(11) NOT NULL,
  `permitido` bit(1) NOT NULL,
  PRIMARY KEY (`idpermiso`),
  KEY `fk_userperm_idx` (`idusuario`),
  KEY `fk_permmod_idx` (`idmodulo`),
  CONSTRAINT `fk_permmod` FOREIGN KEY (`idmodulo`) REFERENCES `modulo` (`idmodulo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_userperm` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permiso`
--

LOCK TABLES `permiso` WRITE;
/*!40000 ALTER TABLE `permiso` DISABLE KEYS */;
/*!40000 ALTER TABLE `permiso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `presupuesto`
--

DROP TABLE IF EXISTS `presupuesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `presupuesto` (
  `idpresupuesto` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `idcentro` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `mes` int(2) NOT NULL,
  `cantidad` decimal(16,2) NOT NULL,
  PRIMARY KEY (`idpresupuesto`),
  KEY `fk_cuentapresupuesto_idx` (`cuenta`),
  KEY `fk_ciapresupuesto_idx` (`idsucursal`),
  KEY `fk_centropresupuesto_idx` (`idcentro`),
  CONSTRAINT `fk_centropresupuesto` FOREIGN KEY (`idcentro`) REFERENCES `centrocostos` (`idcentro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ciapresupuesto` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuentapresupuesto` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=89 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presupuesto`
--

LOCK TABLES `presupuesto` WRITE;
/*!40000 ALTER TABLE `presupuesto` DISABLE KEYS */;
INSERT INTO `presupuesto` VALUES (5,1,10,1,'2014',1,1.00),(6,1,10,1,'2014',2,5.00),(7,1,10,1,'2014',3,5.00),(8,1,10,1,'2014',4,6.50),(9,1,10,1,'2014',5,6.10),(10,1,10,1,'2014',6,1.20),(11,1,10,1,'2014',7,8.00),(12,1,10,1,'2014',8,2.00),(13,1,10,1,'2014',9,9.00),(14,1,10,1,'2014',10,4.00),(15,1,10,1,'2014',11,1.00),(16,1,10,1,'2014',12,4.00),(17,1,10,1,'2015',1,1.00),(18,1,10,1,'2015',2,1.00),(19,1,10,1,'2015',3,2.00),(20,1,10,1,'2015',4,2.00),(21,1,10,1,'2015',5,21.00),(22,1,10,1,'2015',6,12.00),(23,1,10,1,'2015',7,0.00),(24,1,10,1,'2015',8,224.00),(25,1,10,1,'2015',9,22112.00),(26,1,10,1,'2015',10,121.00),(27,1,10,1,'2015',11,1.00),(28,1,10,1,'2015',12,1.00),(41,1,10,3,'2014',1,1.00),(42,1,10,3,'2014',2,4.00),(43,1,10,3,'2014',3,4.00),(44,1,10,3,'2014',4,4.00),(45,1,10,3,'2014',5,3.00),(46,1,10,3,'2014',6,3.00),(47,1,10,3,'2014',7,5.00),(48,1,10,3,'2014',8,5.00),(49,1,10,3,'2014',9,6.00),(50,1,10,3,'2014',10,7.00),(51,1,10,3,'2014',11,4.00),(52,1,10,3,'2014',12,3.00),(53,1,10,2,'2015',1,4.00),(54,1,10,2,'2015',2,4.00),(55,1,10,2,'2015',3,3.00),(56,1,10,2,'2015',4,22.00),(57,1,10,2,'2015',5,2.00),(58,1,10,2,'2015',6,2.00),(59,1,10,2,'2015',7,2.00),(60,1,10,2,'2015',8,2.00),(61,1,10,2,'2015',9,2.00),(62,1,10,2,'2015',10,2.00),(63,1,10,2,'2015',11,2.00),(64,1,10,2,'2015',12,2.00),(65,1,28,1,'2014',1,12.00),(66,1,28,1,'2014',2,2.00),(67,1,28,1,'2014',3,3.00),(68,1,28,1,'2014',4,4.00),(69,1,28,1,'2014',5,5.00),(70,1,28,1,'2014',6,6.00),(71,1,28,1,'2014',7,7.00),(72,1,28,1,'2014',8,8.00),(73,1,28,1,'2014',9,9.00),(74,1,28,1,'2014',10,10.00),(75,1,28,1,'2014',11,11.00),(76,1,28,1,'2014',12,12.00),(77,1,28,3,'2014',1,1.00),(78,1,28,3,'2014',2,2.00),(79,1,28,3,'2014',3,3.00),(80,1,28,3,'2014',4,0.00),(81,1,28,3,'2014',5,0.00),(82,1,28,3,'2014',6,0.00),(83,1,28,3,'2014',7,0.00),(84,1,28,3,'2014',8,0.00),(85,1,28,3,'2014',9,0.00),(86,1,28,3,'2014',10,0.00),(87,1,28,3,'2014',11,0.00),(88,1,28,3,'2014',12,0.00);
/*!40000 ALTER TABLE `presupuesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saldoscuentas`
--

DROP TABLE IF EXISTS `saldoscuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saldoscuentas` (
  `idsaldoscuentas` int(11) NOT NULL AUTO_INCREMENT,
  `idsucursal` int(11) NOT NULL,
  `cuenta` int(11) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `mes` int(11) NOT NULL,
  `saldomes` decimal(16,2) NOT NULL,
  `credimes` decimal(16,2) NOT NULL,
  `debimes` decimal(16,2) NOT NULL,
  PRIMARY KEY (`idsaldoscuentas`),
  KEY `fk_cuentsaldo_idx` (`cuenta`),
  KEY `fk_sucursalsaldos_idx` (`idsucursal`),
  CONSTRAINT `fk_cuentasaldos` FOREIGN KEY (`cuenta`) REFERENCES `maeconta` (`idcuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_sucursalsaldos` FOREIGN KEY (`idsucursal`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saldoscuentas`
--

LOCK TABLES `saldoscuentas` WRITE;
/*!40000 ALTER TABLE `saldoscuentas` DISABLE KEYS */;
INSERT INTO `saldoscuentas` VALUES (1,1,5,'2015',1,0.00,0.00,0.00),(2,1,5,'2015',2,0.00,0.00,0.00),(3,1,5,'2015',3,-80000.00,-80000.00,0.00),(4,1,5,'2015',4,0.00,0.00,0.00),(5,1,5,'2015',5,0.00,0.00,0.00),(6,1,5,'2015',6,0.00,0.00,0.00),(7,1,5,'2015',7,0.00,0.00,0.00),(8,1,5,'2015',8,0.00,0.00,0.00),(9,1,5,'2015',9,0.00,0.00,0.00),(10,1,5,'2015',10,0.00,0.00,0.00),(11,1,5,'2015',11,0.00,0.00,0.00),(12,1,5,'2015',12,0.00,0.00,0.00),(13,1,4,'2015',1,0.00,0.00,0.00),(14,1,4,'2015',2,0.00,0.00,0.00),(15,1,4,'2015',3,161598.40,-1600.00,163198.40),(16,1,4,'2015',4,0.00,0.00,0.00),(17,1,4,'2015',5,0.00,0.00,0.00),(18,1,4,'2015',6,0.00,0.00,0.00),(19,1,4,'2015',7,0.00,0.00,0.00),(20,1,4,'2015',8,0.00,0.00,0.00),(21,1,4,'2015',9,0.00,0.00,0.00),(22,1,4,'2015',10,0.00,0.00,0.00),(23,1,4,'2015',11,0.00,0.00,0.00),(24,1,4,'2015',12,0.00,0.00,0.00),(25,1,10,'2015',1,0.00,0.00,0.00),(26,1,10,'2015',2,0.00,0.00,0.00),(27,1,10,'2015',3,-15998.40,-17598.40,1600.00),(28,1,10,'2015',4,0.00,0.00,0.00),(29,1,10,'2015',5,0.00,0.00,0.00),(30,1,10,'2015',6,0.00,0.00,0.00),(31,1,10,'2015',7,0.00,0.00,0.00),(32,1,10,'2015',8,0.00,0.00,0.00),(33,1,10,'2015',9,0.00,0.00,0.00),(34,1,10,'2015',10,0.00,0.00,0.00),(35,1,10,'2015',11,0.00,0.00,0.00),(36,1,10,'2015',12,0.00,0.00,0.00),(37,1,6,'2015',1,0.00,0.00,0.00),(38,1,6,'2015',2,0.00,0.00,0.00),(39,1,6,'2015',3,-80000.00,-80000.00,0.00),(40,1,6,'2015',4,0.00,0.00,0.00),(41,1,6,'2015',5,0.00,0.00,0.00),(42,1,6,'2015',6,0.00,0.00,0.00),(43,1,6,'2015',7,0.00,0.00,0.00),(44,1,6,'2015',8,0.00,0.00,0.00),(45,1,6,'2015',9,0.00,0.00,0.00),(46,1,6,'2015',10,0.00,0.00,0.00),(47,1,6,'2015',11,0.00,0.00,0.00),(48,1,6,'2015',12,0.00,0.00,0.00),(49,1,11,'2015',1,0.00,0.00,0.00),(50,1,11,'2015',2,0.00,0.00,0.00),(51,1,11,'2015',3,-1600.00,-1600.00,0.00),(52,1,11,'2015',4,0.00,0.00,0.00),(53,1,11,'2015',5,0.00,0.00,0.00),(54,1,11,'2015',6,0.00,0.00,0.00),(55,1,11,'2015',7,0.00,0.00,0.00),(56,1,11,'2015',8,0.00,0.00,0.00),(57,1,11,'2015',9,0.00,0.00,0.00),(58,1,11,'2015',10,0.00,0.00,0.00),(59,1,11,'2015',11,0.00,0.00,0.00),(60,1,11,'2015',12,0.00,0.00,0.00);
/*!40000 ALTER TABLE `saldoscuentas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sucursal` (
  `idsucursal` int(11) NOT NULL,
  `idcompania` int(11) NOT NULL,
  `nombresucursal` varchar(45) NOT NULL,
  `idciudad` int(11) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `paginaocorreo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idsucursal`),
  KEY `fk_sucursalciudad_idx` (`idciudad`),
  KEY `fk_ciasucursal_idx` (`idcompania`),
  CONSTRAINT `fk_ciasucursal` FOREIGN KEY (`idcompania`) REFERENCES `compania` (`idcompania`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ciudadsucursal` FOREIGN KEY (`idciudad`) REFERENCES `ciudad` (`idciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
INSERT INTO `sucursal` VALUES (1,1,'PRINCIPAL',3,'CALLE 159 # 17','7655763','SIIMN@YAHOO.ES');
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoformato`
--

DROP TABLE IF EXISTS `tipoformato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoformato` (
  `codigotipo` int(11) NOT NULL,
  `nombretipo` varchar(45) NOT NULL,
  PRIMARY KEY (`codigotipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoformato`
--

LOCK TABLES `tipoformato` WRITE;
/*!40000 ALTER TABLE `tipoformato` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipoformato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiponit`
--

DROP TABLE IF EXISTS `tiponit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiponit` (
  `idtiponit` int(11) NOT NULL AUTO_INCREMENT,
  `codigtiponit` varchar(1) NOT NULL,
  `nombretipo` varchar(45) NOT NULL,
  PRIMARY KEY (`idtiponit`),
  UNIQUE KEY `codigtiponit_UNIQUE` (`codigtiponit`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiponit`
--

LOCK TABLES `tiponit` WRITE;
/*!40000 ALTER TABLE `tiponit` DISABLE KEYS */;
INSERT INTO `tiponit` VALUES (1,'C','CEDULA'),(2,'E','CEDULA DE EXTRANJERIA'),(3,'J','TARJETA DE EXTRANJERIA'),(4,'N','NIT'),(5,'P','PASAPORTE'),(6,'R','REGISTRO CIVIL'),(7,'T','TARJETA DE IDENTIDAD');
/*!40000 ALTER TABLE `tiponit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `idusuariodatos` int(11) NOT NULL,
  `user` varchar(10) NOT NULL,
  `contrasena` char(32) NOT NULL,
  `fechaulticonex` datetime DEFAULT NULL,
  `ultimobloqueo` datetime DEFAULT NULL,
  `intentosfallidos` int(1) NOT NULL,
  `bloqueado` bit(1) NOT NULL,
  `conectado` bit(1) NOT NULL,
  PRIMARY KEY (`idusuario`),
  KEY `fk_usuario_idx` (`idusuariodatos`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`idusuariodatos`) REFERENCES `datosusuario` (`idusuariodat`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,1,'ADMIN','123',NULL,NULL,0,'\0','\0');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuariocia`
--

DROP TABLE IF EXISTS `usuariocia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuariocia` (
  `idusercia` int(11) NOT NULL AUTO_INCREMENT,
  `idcompania` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL,
  PRIMARY KEY (`idusercia`),
  KEY `fk_ciausxcia_idx` (`idcompania`),
  KEY `fk_userusxcia_idx` (`idusuario`),
  CONSTRAINT `fk_ciausxcia` FOREIGN KEY (`idcompania`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_userusxcia` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuariocia`
--

LOCK TABLES `usuariocia` WRITE;
/*!40000 ALTER TABLE `usuariocia` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuariocia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendedor`
--

DROP TABLE IF EXISTS `vendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vendedor` (
  `idvendedor` int(11) NOT NULL,
  `nombrevendedor` varchar(45) NOT NULL,
  `cedula` varchar(45) NOT NULL,
  `tipo` varchar(1) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `emailvend` varchar(45) DEFAULT NULL,
  `direcvend` varchar(45) DEFAULT NULL,
  `activo` bit(1) NOT NULL,
  `comisionrango` bit(1) NOT NULL,
  `comision` decimal(6,2) NOT NULL,
  `idcompania` int(11) NOT NULL,
  PRIMARY KEY (`idvendedor`),
  KEY `fk_sucursalvendedor_idx` (`idcompania`),
  CONSTRAINT `fk_sucursalvendedor` FOREIGN KEY (`idcompania`) REFERENCES `sucursal` (`idsucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendedor`
--

LOCK TABLES `vendedor` WRITE;
/*!40000 ALTER TABLE `vendedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendedor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-04  8:15:00
