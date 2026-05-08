-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: bibliotecadb
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20260508015249_CriacaoInicial','9.0.0');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `autores`
--

DROP TABLE IF EXISTS `autores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autores` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Descricao` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ImageName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autores`
--

LOCK TABLES `autores` WRITE;
/*!40000 ALTER TABLE `autores` DISABLE KEYS */;
INSERT INTO `autores` VALUES (1,'Machado de Assis','Um dos maiores escritores da literatura brasileira, fundador da Academia Brasileira de Letras. Destacou-se no realismo com obras como Dom Casmurro e Memórias Póstumas de Brás Cubas. Sua escrita é marcada por ironia, crítica social e profunda análise psicológica dos personagens.','machadoDeAssis.jpg'),(2,'WIlliam Shakespeare','William Shakespeare foi um importante dramaturgo e poeta inglês dos séculos XVI e XVII, reconhecido como um dos maiores escritores da história. Autor de obras famosas como Romeu e Julieta e Hamlet, destacou-se por criar personagens marcantes e histórias que exploram temas como amor, poder, vingança e ambição. Suas peças e poemas influenciaram profundamente a literatura, o teatro e a cultura mundial, permanecendo populares e estudados até os dias atuais.','shakespeare.jpg'),(3,'George Orwell','George Orwell foi um escritor e jornalista inglês conhecido por suas obras de crítica política e social. Tornou-se mundialmente famoso pelos livros 1984 e A Revolução dos Bichos, nos quais criticou regimes autoritários e a manipulação do poder. Sua escrita clara e reflexiva abordava temas como liberdade, desigualdade e controle social. Até hoje, suas obras continuam influentes e muito discutidas na literatura e na política.','georgeOrwell.jpg'),(4,'Carolina Maria de Jesus','Carolina Maria de Jesus foi uma importante escritora brasileira conhecida por retratar a realidade da pobreza e da desigualdade social no Brasil. Ganhou destaque com o livro Quarto de Despejo, baseado em seus diários sobre a vida na favela. Sua escrita simples e direta revelou as dificuldades enfrentadas por milhares de brasileiros marginalizados. Carolina tornou-se um símbolo de resistência e da força da literatura como forma de denúncia social e expressão pessoal.','carolinaMariaDeJesus.jpg'),(5,'Dante Alighieri','Dante Alighieri foi um dos maiores escritores da literatura italiana e mundial, conhecido principalmente pela obra A Divina Comédia. Em seu poema, descreveu uma viagem pelo Inferno, Purgatório e Paraíso, abordando temas religiosos, filosóficos e políticos. Sua escrita teve grande influência na língua italiana e na literatura ocidental. Até hoje, Dante é lembrado como um dos autores mais importantes da Idade Média.','danteAlighieri.jpg'),(6,' Fiódor Dostoiévski','Fiódor Dostoiévski foi um dos mais importantes escritores da literatura russa e mundial, conhecido por explorar profundamente a mente humana e os conflitos psicológicos de seus personagens. Entre suas obras mais famosas estão Crime e Castigo e Os Irmãos Karamázov, que abordam temas como culpa, moralidade, fé e sofrimento. Sua escrita influenciou a filosofia, a psicologia e a literatura moderna. Até hoje, seus livros continuam sendo amplamente estudados e admirados no mundo inteiro.','fiodor.jpg'),(7,'Graciliano Ramos','Graciliano Ramos foi um importante escritor brasileiro do modernismo, conhecido por retratar de forma realista a vida no sertão nordestino e as dificuldades sociais do país. Entre suas obras mais famosas estão Vidas Secas e São Bernardo, marcadas por uma escrita direta e profunda. Seus livros abordam temas como pobreza, injustiça e sofrimento humano. Graciliano é considerado um dos maiores nomes da literatura brasileira.','graciliano.jpg'),(8,'Nikola Tesla','Nikola Tesla foi um inventor e engenheiro conhecido por suas importantes contribuições para o desenvolvimento da eletricidade moderna. Destacou-se pela criação e aperfeiçoamento do sistema de corrente alternada, fundamental para a distribuição de energia elétrica no mundo. Tesla também realizou estudos inovadores nas áreas de rádio, magnetismo e transmissão de energia sem fio. Sua genialidade e visão futurista fizeram dele um dos cientistas mais admirados da história.','nikolaTesla.jpeg');
/*!40000 ALTER TABLE `autores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livros`
--

DROP TABLE IF EXISTS `livros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livros` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Titulo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `NumPaginas` int NOT NULL,
  `AutorId` int NOT NULL,
  `Genero` int NOT NULL,
  `DataPublicacao` date NOT NULL,
  `ImageName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`),
  KEY `IX_Livros_AutorId` (`AutorId`),
  CONSTRAINT `FK_Livros_Autores_AutorId` FOREIGN KEY (`AutorId`) REFERENCES `autores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livros`
--

LOCK TABLES `livros` WRITE;
/*!40000 ALTER TABLE `livros` DISABLE KEYS */;
INSERT INTO `livros` VALUES (2,'O Alienista',123,1,0,'1901-09-11','oAlienista.jpg'),(3,'Memórias Póstumas de Brás Cubas',256,1,0,'1881-12-12','memoriasPostumas.jpg'),(4,'Dom Casmurro',250,1,0,'1889-12-05','domCasmurro.jpeg'),(5,'Hamlet',112,2,3,'1600-06-20','hamlet.jpeg'),(6,'Otelo, o Mouro de Veneza',212,2,3,'1603-03-16','hotelo.jpg'),(7,'Revolução dos Bixos',152,3,1,'1945-08-17','revolucaoBichos.jpeg'),(8,'1984',352,3,1,'1949-06-08','1984.jpeg'),(9,'Quarto de Despejo',240,4,2,'1960-08-19','quartoDespejo.jpeg'),(10,'Divina Comédia',676,5,4,'1313-04-09','divinaComedia.jpeg'),(11,'Memórias do Subsolo',189,6,0,'1864-07-26','memoriasSubsolo.jpeg'),(12,'Vidas Secas',115,7,0,'1938-11-11','vidasSecas.jpeg'),(13,'Minhas Invenções',122,8,2,'1919-12-19','minhasInvencoes.jpg');
/*!40000 ALTER TABLE `livros` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-07 23:47:31
