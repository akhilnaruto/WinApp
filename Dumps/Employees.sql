
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
