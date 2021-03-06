
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
  CONSTRAINT `donors_ibfk_3` FOREIGN KEY (`DateTypeId`) REFERENCES `DateType` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
