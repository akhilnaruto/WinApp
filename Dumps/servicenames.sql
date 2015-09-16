
CREATE TABLE `ServiceName` (
  `Id` int(20) NOT NULL,
  `Name` varchar(40) DEFAULT NULL,
  `ServiceTypeId` int(20) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
