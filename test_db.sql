-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: test
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `documents`
--

DROP TABLE IF EXISTS `documents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `documents` (
  `DId` int(11) NOT NULL AUTO_INCREMENT,
  `DIndex` varchar(255) DEFAULT NULL,
  `DDate` date DEFAULT NULL,
  `DFrom` varchar(255) DEFAULT NULL,
  `DAbout` varchar(255) DEFAULT NULL,
  `FId` int(11) DEFAULT NULL,
  PRIMARY KEY (`DId`),
  KEY `FId_idx` (`FId`),
  CONSTRAINT `FId` FOREIGN KEY (`FId`) REFERENCES `files` (`fid`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documents`
--

LOCK TABLES `documents` WRITE;
/*!40000 ALTER TABLE `documents` DISABLE KEYS */;
/*!40000 ALTER TABLE `documents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `files`
--

DROP TABLE IF EXISTS `files`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `files` (
  `FId` int(11) NOT NULL AUTO_INCREMENT,
  `FName` varchar(255) NOT NULL,
  `FType` varchar(255) NOT NULL,
  `FByte` longblob NOT NULL,
  PRIMARY KEY (`FId`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `files`
--

LOCK TABLES `files` WRITE;
/*!40000 ALTER TABLE `files` DISABLE KEYS */;
/*!40000 ALTER TABLE `files` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `resolves`
--

DROP TABLE IF EXISTS `resolves`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `resolves` (
  `ResId` int(11) NOT NULL AUTO_INCREMENT,
  `DId` int(11) NOT NULL,
  `UId` int(11) NOT NULL,
  `RAddress` varchar(255) NOT NULL,
  `RStatus` varchar(255) NOT NULL,
  PRIMARY KEY (`ResId`),
  KEY `DId_idx` (`DId`),
  KEY `UId_idx` (`UId`),
  CONSTRAINT `DId` FOREIGN KEY (`DId`) REFERENCES `documents` (`did`),
  CONSTRAINT `UId` FOREIGN KEY (`UId`) REFERENCES `users` (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `resolves`
--

LOCK TABLES `resolves` WRITE;
/*!40000 ALTER TABLE `resolves` DISABLE KEYS */;
/*!40000 ALTER TABLE `resolves` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `roles` (
  `RId` int(11) NOT NULL AUTO_INCREMENT,
  `RName` varchar(255) NOT NULL,
  `RAlterName` varchar(255) NOT NULL,
  PRIMARY KEY (`RId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'admin','Адміністратор'),(2,'new','Новий користувач'),(3,'office','Канцелярія'),(4,'rector','Ректор'),(5,'vrector','Проректор'),(6,'dean','Декан'),(7,'cathedra','Кафедра');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tokens`
--

DROP TABLE IF EXISTS `tokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tokens` (
  `TId` int(11) NOT NULL AUTO_INCREMENT,
  `TToken` varchar(255) NOT NULL,
  PRIMARY KEY (`TId`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tokens`
--

LOCK TABLES `tokens` WRITE;
/*!40000 ALTER TABLE `tokens` DISABLE KEYS */;
INSERT INTO `tokens` VALUES (25,'rkcY7eaMlr'),(26,'qcCIzMJpS7'),(27,'3Md63Qt5oz'),(28,'bpQCN8RycK'),(29,'93nP6IfJtX');
/*!40000 ALTER TABLE `tokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `users` (
  `UId` int(11) NOT NULL AUTO_INCREMENT,
  `UMail` varchar(255) NOT NULL,
  `UPassword` varchar(255) NOT NULL,
  `UName` varchar(255) NOT NULL,
  `RId` int(11) DEFAULT NULL,
  PRIMARY KEY (`UId`),
  KEY `fk_rid_idx` (`RId`),
  CONSTRAINT `fk_rid` FOREIGN KEY (`RId`) REFERENCES `roles` (`rid`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (12,'factworkflow@gmail.com','#�;ä�����k�\"���','Адміністратор',1),(14,'office@gmail.com','�/EE�h�luO��W5','Канцелярія',3),(19,'vrector@gmail.com','�ɬɯ�J���<%���','Проректор',5),(20,'dean@gmail.com','Hvta�	FSbƇ�Du;','Декан',6),(21,'cathedra@gmail.com','��C��I�ts�,�(�','Кафедра',7),(25,'rector@gmail.com','���G��#���6\r�','Ректор',4);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-06 11:12:45
