CREATE DATABASE  IF NOT EXISTS `avm` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `avm`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: avm
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `etkınlık`
--

DROP TABLE IF EXISTS `etkınlık`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etkınlık` (
  `idetkınlık` int NOT NULL,
  `etkınlıkadı` varchar(45) DEFAULT NULL,
  `etkınlıkbaslangıc` date DEFAULT NULL,
  `etkınlıkbıtıs` date DEFAULT NULL,
  `etkınlıkturu` varchar(45) DEFAULT NULL,
  `etkınlıkbutce` int NOT NULL,
  PRIMARY KEY (`idetkınlık`,`etkınlıkbutce`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etkınlık`
--

LOCK TABLES `etkınlık` WRITE;
/*!40000 ALTER TABLE `etkınlık` DISABLE KEYS */;
INSERT INTO `etkınlık` VALUES (2,'2','2022-05-07','2022-05-07','BAYRAM ',22222);
/*!40000 ALTER TABLE `etkınlık` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hızmetler`
--

DROP TABLE IF EXISTS `hızmetler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hızmetler` (
  `idhızmetler` int NOT NULL,
  `hızmetturu` varchar(45) DEFAULT NULL,
  `hızmetsaglayıcı` varchar(45) DEFAULT NULL,
  `hızmetbaslangıc` date DEFAULT NULL,
  `hızmetbıtıs` date DEFAULT NULL,
  `hızmetmalıyetı` int NOT NULL,
  PRIMARY KEY (`idhızmetler`,`hızmetmalıyetı`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hızmetler`
--

LOCK TABLES `hızmetler` WRITE;
/*!40000 ALTER TABLE `hızmetler` DISABLE KEYS */;
INSERT INTO `hızmetler` VALUES (1,'SU ','isu','2022-05-07','2022-06-06',10000);
/*!40000 ALTER TABLE `hızmetler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `magaza`
--

DROP TABLE IF EXISTS `magaza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `magaza` (
  `idmagaza` int NOT NULL,
  `magazaadı` varchar(45) DEFAULT NULL,
  `sırketadı` varchar(45) DEFAULT NULL,
  `magazaturu` varchar(45) DEFAULT NULL,
  `magazacalısan` int DEFAULT NULL,
  `magazasorumlusu` varchar(45) DEFAULT NULL,
  `magazakıra` int NOT NULL,
  PRIMARY KEY (`idmagaza`,`magazakıra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `magaza`
--

LOCK TABLES `magaza` WRITE;
/*!40000 ALTER TABLE `magaza` DISABLE KEYS */;
INSERT INTO `magaza` VALUES (2,'s','w','GİYİM ',4,'s',3);
/*!40000 ALTER TABLE `magaza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personel`
--

DROP TABLE IF EXISTS `personel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personel` (
  `idpersonel` int NOT NULL,
  `personeladı` varchar(45) DEFAULT NULL,
  `personelsoyadı` varchar(45) DEFAULT NULL,
  `personelcinsiyeti` varchar(5) DEFAULT NULL,
  `personeltel` varchar(11) DEFAULT NULL,
  `personeldepartman` varchar(45) DEFAULT NULL,
  `personeladres` varchar(245) DEFAULT NULL,
  `personelmaası` int NOT NULL,
  PRIMARY KEY (`idpersonel`,`personelmaası`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personel`
--

LOCK TABLES `personel` WRITE;
/*!40000 ALTER TABLE `personel` DISABLE KEYS */;
INSERT INTO `personel` VALUES (1,'s','s','ERKEK','1','GÜVENLİK','w',111);
/*!40000 ALTER TABLE `personel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reklam`
--

DROP TABLE IF EXISTS `reklam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reklam` (
  `idreklam` int NOT NULL,
  `reklamadı` varchar(45) DEFAULT NULL,
  `reklambaslangıc` date DEFAULT NULL,
  `reklambıtıs` date DEFAULT NULL,
  `reklamturu` varchar(45) DEFAULT NULL,
  `reklamfiyatı` int NOT NULL,
  PRIMARY KEY (`idreklam`,`reklamfiyatı`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reklam`
--

LOCK TABLES `reklam` WRITE;
/*!40000 ALTER TABLE `reklam` DISABLE KEYS */;
INSERT INTO `reklam` VALUES (1,'bayram','2022-05-07','2022-05-07','GİYİM',20000);
/*!40000 ALTER TABLE `reklam` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yonetım`
--

DROP TABLE IF EXISTS `yonetım`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yonetım` (
  `idyonetım` int NOT NULL,
  `yonetıcıad` varchar(45) DEFAULT NULL,
  `yonetımsıfre` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idyonetım`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yonetım`
--

LOCK TABLES `yonetım` WRITE;
/*!40000 ALTER TABLE `yonetım` DISABLE KEYS */;
INSERT INTO `yonetım` VALUES (1,'semih','w');
/*!40000 ALTER TABLE `yonetım` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-07 22:10:42
