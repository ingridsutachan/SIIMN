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
-- Table structure for table `coneusuar`
--

DROP TABLE IF EXISTS `coneusuar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `coneusuar` (
  `iduser` int(11) NOT NULL,
  `fechacon` datetime NOT NULL,
  `compania` int(11) NOT NULL,
  `conectado` bit(1) NOT NULL,
  PRIMARY KEY (`iduser`,`fechacon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coneusuar`
--

LOCK TABLES `coneusuar` WRITE;
/*!40000 ALTER TABLE `coneusuar` DISABLE KEYS */;
INSERT INTO `coneusuar` VALUES (1,'2014-03-03 21:09:27',2,''),(1,'2014-03-03 21:13:17',3,''),(1,'2014-03-03 21:15:35',1,''),(1,'2014-03-03 21:18:52',2,''),(1,'2014-03-03 21:20:10',1,''),(1,'2014-03-03 21:29:08',1,''),(1,'2014-03-03 22:49:43',1,''),(1,'2014-03-03 23:01:47',1,''),(1,'2014-03-03 23:12:41',1,''),(1,'2014-03-03 23:13:15',1,''),(1,'2014-03-03 23:19:43',1,''),(1,'2014-03-03 23:24:39',1,''),(1,'2014-05-20 10:57:43',2,''),(1,'2014-05-20 10:58:14',1,''),(1,'2014-06-15 18:22:04',1,''),(1,'2014-06-25 12:36:32',1,''),(1,'2014-06-25 12:47:24',1,''),(1,'2014-06-25 19:48:13',1,''),(1,'2014-06-26 15:38:11',1,''),(1,'2014-06-26 15:59:23',1,'');
/*!40000 ALTER TABLE `coneusuar` ENABLE KEYS */;
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
