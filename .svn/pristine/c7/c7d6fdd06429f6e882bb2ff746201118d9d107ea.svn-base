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
-- Table structure for table `maeconta`
--

DROP TABLE IF EXISTS `maeconta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maeconta` (
  `cuenta` varchar(12) NOT NULL DEFAULT '' COMMENT 'numero cuenta',
  `idcompania` int(3) NOT NULL COMMENT 'Compañia que realiza movimiento',
  `tipocta` varchar(1) NOT NULL COMMENT 'Tipo de cuenta (GENERAL O DETALLE) G o D',
  `nombre` varchar(65) NOT NULL COMMENT 'Nombre de la cuenta',
  `pidenit` bit(1) NOT NULL COMMENT 'Campo que establece si la cuenta pide nit ',
  `centro` bit(1) NOT NULL COMMENT 'Este campo establece si hay o no hay centro de costos',
  `ajustesinteg` bit(1) NOT NULL,
  `nitajustes` varchar(20) DEFAULT NULL,
  `cueaju` varchar(10) DEFAULT NULL COMMENT 'base ',
  `cuencorre` varchar(10) DEFAULT NULL,
  `ajudoc` varchar(1) DEFAULT NULL,
  `cuentret` bit(1) NOT NULL,
  `porete` int(3) DEFAULT NULL COMMENT 'Porcentaje de retencion ',
  `concepret` varchar(45) DEFAULT NULL,
  `cuentacierreimp` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`cuenta`),
  UNIQUE KEY `cuenta_UNIQUE` (`cuenta`),
  KEY `fk_ciaconta_idx` (`idcompania`),
  CONSTRAINT `fk_compania` FOREIGN KEY (`idcompania`) REFERENCES `compania` (`idcompania`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Cuentas o puc ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maeconta`
--

LOCK TABLES `maeconta` WRITE;
/*!40000 ALTER TABLE `maeconta` DISABLE KEYS */;
INSERT INTO `maeconta` VALUES ('1',1,'M','ACTIVOS','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,NULL),('11',1,'M','DISPONIBLE ','\0','\0','\0',NULL,NULL,NULL,NULL,'\0',NULL,NULL,NULL),('1105',1,'M','CAJA','','','',NULL,NULL,NULL,NULL,'\0',NULL,NULL,NULL),('11050505',1,'A','BANCOS TRASNACIONALES','','','','5545456','11050505','121005',NULL,'\0',0,'',NULL),('110506',1,'A','CAJA MAYOR','','','\0','','','',NULL,'\0',0,'',NULL),('1110',1,'M','BANCOS','\0','\0','','12346','1105','1105',NULL,'\0',50,'PRUEBA DE OTRA CUENTA',NULL),('111005',1,'M','MONEDA NACIONAL','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('1112',1,'M','OTROS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('12',1,'M','INVERSIONES','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('121005',1,'M','INVERSIONES INTERNACIONALES','','\0','','45545','11050505','11050505','D','',55,'sdad',NULL),('2',1,'M','PASIVOS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('4',1,'M','INGRESOS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('41',1,'M','OPERACIONALES','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('4120',1,'M','INDUSTRIAS MANUFACTURERAS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('412035',1,'A','IMPRESION','','','\0','','','',NULL,'\0',0,'',NULL),('4135',1,'M','COMERCIO AL POR MAYOR Y AL POR MENOS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('413526',1,'A','VENTA DE PAPEL O CARTON','','','\0','','','',NULL,'\0',0,'',NULL),('413554',1,'M','VENTA DE MAQUINARIA, EQUIPOS DE OFICINA Y PROGRAMAS DE COMPUTADOR','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('41355401',1,'A','VENTA DE COMPUTADOR','','','\0','','','',NULL,'\0',0,'',NULL),('41355402',1,'A','VENTA DE SOFTWARE SIIMN','','','\0','','','',NULL,'\0',0,'',NULL),('47',1,'M','AJUSTES POR INFLACION','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('4705',1,'M','CORECCION MONETARIA','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('470515',1,'A','PROPIEDADES,PLANTA Y EQUIPO','','','\0','','','',NULL,'\0',0,'',NULL),('470590',1,'A','COMPRAS','','','\0','','','',NULL,'\0',0,'',NULL),('5',1,'M','GASTOS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('51',1,'M','OPERACIONALES DE ADMINISTRACION','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('5105',1,'M','GASTOS DE PERSONAL','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('510506',1,'A','SUELDOS','','','\0','','','',NULL,'\0',0,'',NULL),('510527',1,'A','AUXILIO DE TRANSPORTE','','','\0','','','',NULL,'\0',0,'',NULL),('510551',1,'A','DOTACION Y SUMINISTRO A TRABAJADORES','','','\0','','','',NULL,'\0',0,'',NULL),('510563',1,'A','CAPACITACION AL PERSONAL','','','\0','','','',NULL,'\0',0,'',NULL),('5135',1,'M','SERVICIOS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('513505',1,'M','ASEO Y VIGILANCIA','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('51350501',1,'A','ASEO OFICINAS','','','\0','','','',NULL,'\0',0,'',NULL),('51350502',1,'A','VIGILANCIA OFICINAS','','','\0','','','',NULL,'\0',0,'',NULL),('6',1,'M','COSTOS DE VENTAS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('61',1,'M','COSTOS DE VENTAS Y DE PRESTACION DE SERVICIOS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('6120',1,'M','INDUSTRIAS MANUFACTURERAS','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('6135',1,'M','COMERCIO AL POR MAYOR Y AL POR MENOR','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('613526',1,'M','VENTA DE PAPEL Y CARTON','\0','\0','\0','','','',NULL,'\0',0,'',NULL),('61352601',1,'A','VENTA DE ROLLOS DE PAPEL PARA IMPRESORA','','','\0','','','',NULL,'\0',0,'',NULL),('613554',1,'M','VENTA DE MAQUINARIA,EQUIPO DE OFICINA Y PROGRAMAS DE COMPUTADOR','\0','\0','\0','','','',NULL,'\0',0,'',NULL);
/*!40000 ALTER TABLE `maeconta` ENABLE KEYS */;
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
