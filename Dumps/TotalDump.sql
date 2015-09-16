CREATE DATABASE `eTemple_vc`;

CREATE TABLE `Roles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

INSERT INTO `Roles` VALUES (1,'Admin'),(2,'User'),(3,'TicketAgent'),(4,'Clerk');

CREATE TABLE `Designations` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

INSERT INTO `Designations` VALUES (1,'Admin'),(2,'Clerk'),(3,'EO'),(4,'Priest');

CREATE TABLE `Employees` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Designation` int(11) NOT NULL,
  `Role` int(11) NOT NULL,
  `AllowLogin` tinyint(1) NOT NULL DEFAULT '0',
  `LoginId` varchar(50) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL,
  `IsDeleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedBy` int(11) DEFAULT NULL,
  `CreatedOn` datetime DEFAULT CURRENT_TIMESTAMP,
  `ModifiedOn` datetime DEFAULT CURRENT_TIMESTAMP,
  `ModifiedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Employees_Designation_Designations_Id_idx` (`Designation`),
  KEY `FK_Employees_RoldId_Roles_Id_idx` (`Role`),
  CONSTRAINT `FK_Employees_Designation_Designations_Id` FOREIGN KEY (`Designation`) REFERENCES `Designations` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Employees_RoleId_Roles_Id` FOREIGN KEY (`Role`) REFERENCES `Roles` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

INSERT INTO `Employees` VALUES (1,'M.S.Raju',3,1,1,'superadmin','hyma2259',0,1,'2014-08-05 19:31:26','2014-08-05 19:31:26',1),(2,'Srinivas',2,1,1,'admin','Srinu2211',0,1,'2015-03-13 09:30:50','2015-03-13 09:30:50',1),(3,'Durga',2,3,1,'operator2','Laxmi',0,1,'2015-01-03 08:39:02','2015-01-03 08:39:02',1),(4,'Balaji',2,3,1,'operator1','svsbalaji',0,1,'2015-01-03 08:32:39','2015-01-03 08:32:39',1),(5,'Prasad',2,3,1,'operator3','sindhu',0,1,'2015-01-03 08:24:31','2015-01-03 08:24:31',1),(6,'Govind',2,3,0,'','',0,1,'2014-08-05 19:26:26','2014-08-05 19:26:26',1),(7,'SURESH (ARCHAKA)',4,2,0,'','',0,1,'2014-07-25 10:22:09','2014-07-25 10:22:09',1),(8,'PRAKASH',2,4,0,'','',0,1,'2014-07-25 15:41:24','2014-07-25 15:41:24',1),(9,'SATISH(ARCHAKA)',4,2,0,'','',0,1,'2014-07-25 15:42:06','2014-07-25 15:42:06',1),(10,'MURTHY',2,4,0,'','',0,1,'2014-07-25 17:07:36','2014-07-25 17:07:36',1),(11,'GKNRAO',2,4,0,'','',0,1,'2014-07-25 17:07:49','2014-07-25 17:07:49',1),(12,'VENKANNA',2,2,0,'','',0,1,'2014-07-26 08:38:29','2014-07-26 08:38:29',1),(13,'SRINU.V',2,4,0,'','',0,1,'2014-08-01 11:59:42','2014-08-01 11:59:42',1),(14,'Ganeswararao',2,4,0,'','',0,1,'2014-08-23 10:29:47','2014-08-23 10:29:47',1),(15,'Laxmi',2,4,1,'operator4','mohan',0,1,'2015-02-05 08:14:00','2015-02-05 08:14:00',1),(16,'Administrator',1,1,1,'dwaraka','sri@1234',0,NULL,'2014-04-29 01:26:17','2014-04-29 01:26:17',NULL);

CREATE TABLE `Prefixes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

INSERT INTO `Prefixes` VALUES (1,'????'),(2,'???????'),(3,'??????'),(4,'????????'),(5,'?????'),(6,'?????'),(7,'????????????'),(8,'??????? & ????');



CREATE TABLE `Stars` (
  `Id` int(20) NOT NULL,
  `Name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE `ServiceTypes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Status` int(11) NOT NULL DEFAULT '1',
  `CreatedOn` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CreatedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

INSERT INTO `ServiceTypes` VALUES (1,'Daily Poojas',1,'2014-04-29 18:29:26',1),(2,'Prasadam',1,'2014-04-29 18:30:15',1),(3,'Vehicle Pooja',1,'2014-04-29 18:32:02',1),(4,'Daily Annadanam',1,'2014-04-29 18:32:02',1),(5,'Saswatha Annadanam',1,'2014-04-29 18:32:02',1),(6,'Temple Donations',1,'2014-04-29 18:32:02',1),(7,'Special Poojas',1,'2014-04-29 18:32:02',1),(8,'Yearly Poojas',1,'2014-04-29 18:32:02',1),(9,'Free Annadanam',1,'2014-05-14 17:59:45',1),(10,'Poojas with Single Token Multiple Persons',1,'2014-05-16 17:09:13',1),(11,'Photos',1,'2014-05-16 17:11:52',1),(12,'Auctions',1,'2014-05-16 17:11:52',1),(13,'Hundials',1,'2014-05-16 17:12:42',1),(14,'Misc Incomes',1,'2014-05-16 17:12:42',1),(15,'Single Receipt Multiple Quantity',1,'2014-06-03 07:10:36',1),(16,'VIP Prasadam',1,'2014-07-16 14:55:58',1),(17,'Monthly Annadanam',1,'2014-04-29 18:29:26',1),(18,'GoSeva',1,'2014-04-29 18:29:26',1),(19,'SanjeevaniTrust',1,'2014-04-29 18:29:26',1);


CREATE TABLE `ServiceName` (
  `Id` int(20) NOT NULL,
  `Name` varchar(40) DEFAULT NULL,
  `ServiceTypeId` int(20) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE `SpecialDay` (
  `Id` int(20) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `SpecialDay` VALUES (1,'MUKKOTI'),(2,'DHANURMASA'),(3,'BHOGI'),(4,'SANKRANTHI'),(5,'VLVRATAM'),(6,'KANUMA');


CREATE TABLE `DateType` (
  `Id` int(20) NOT NULL,
  `Name` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `DateType` VALUES (1,'Telugu'),(2,'English'),(3,'Special');


CREATE TABLE `Donors` (
  `Id` int(20) NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT CURRENT_TIMESTAMP,
  `Address` varchar(3000) DEFAULT NULL,
  `Surname` varchar(200) DEFAULT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `DistrictName` varchar(200) DEFAULT NULL,
  `City` varchar(100) DEFAULT NULL,
  `Pin` int(11) DEFAULT NULL,
  `State` varchar(200) DEFAULT NULL,
  `Country` varchar(200) DEFAULT NULL,
  `NameOn` varchar(200) DEFAULT NULL,
  `Star` int(10) DEFAULT NULL,
  `Occassion` varchar(200) DEFAULT NULL,
  `Gothram` varchar(200) DEFAULT NULL,
  `Amount` int(10) DEFAULT NULL,
  `MR No` int(20) DEFAULT NULL,
  `Remarks` varchar(3000) DEFAULT NULL,
  `PhoneNumber` varchar(20) DEFAULT NULL,
   `SpecialDayId` int(20) DEFAULT NULL,
  `ServiceTypeId` int(20) DEFAULT NULL,
  `ServiceNameId` int(20) DEFAULT NULL,
  `DateTypeId` int(20) DEFAULT NULL,
  `PerformDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `EmailId` varchar(50) DEFAULT NULL,
  `Paksha` varchar(40) DEFAULT NULL,
  `Month` varchar(40) DEFAULT NULL,
  `Thidhi` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ServiceTypeId` (`ServiceTypeId`),
  KEY `ServiceNameId` (`ServiceNameId`),
  KEY `DateTypeId` (`DateTypeId`),
  CONSTRAINT `donors_ibfk_1` FOREIGN KEY (`ServiceTypeId`) REFERENCES `ServiceTypes` (`Id`),
  CONSTRAINT `donors_ibfk_2` FOREIGN KEY (`ServiceNameId`) REFERENCES `ServiceName` (`Id`),
  CONSTRAINT `donors_ibfk_3` FOREIGN KEY (`DateTypeId`) REFERENCES `DateType` (`Id`),
  CONSTRAINT `donors_ibfk_4` FOREIGN KEY (`SpecialDayId`) REFERENCES `SpecialDay` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

