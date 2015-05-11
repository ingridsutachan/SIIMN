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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-05 13:15:15