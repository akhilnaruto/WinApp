
CREATE TABLE `ServiceTypes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Status` int(11) NOT NULL DEFAULT '1',
  `CreatedOn` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CreatedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

INSERT INTO `ServiceTypes` VALUES (1,'Daily Poojas',1,'2014-04-29 18:29:26',1),(2,'Prasadam',1,'2014-04-29 18:30:15',1),(3,'Vehicle Pooja',1,'2014-04-29 18:32:02',1),(4,'Daily Annadanam',1,'2014-04-29 18:32:02',1),(5,'Saswatha Annadanam',1,'2014-04-29 18:32:02',1),(6,'Temple Donations',1,'2014-04-29 18:32:02',1),(7,'Special Poojas',1,'2014-04-29 18:32:02',1),(8,'Yearly Poojas',1,'2014-04-29 18:32:02',1),(9,'Free Annadanam',1,'2014-05-14 17:59:45',1),(10,'Poojas with Single Token Multiple Persons',1,'2014-05-16 17:09:13',1),(11,'Photos',1,'2014-05-16 17:11:52',1),(12,'Auctions',1,'2014-05-16 17:11:52',1),(13,'Hundials',1,'2014-05-16 17:12:42',1),(14,'Misc Incomes',1,'2014-05-16 17:12:42',1),(15,'Single Receipt Multiple Quantity',1,'2014-06-03 07:10:36',1),(16,'VIP Prasadam',1,'2014-07-16 14:55:58',1),(17,'Monthly Annadanam',1,'2014-04-29 18:29:26',1),(18,'GoSeva',1,'2014-04-29 18:29:26',1),(19,'SanjeevaniTrust',1,'2014-04-29 18:29:26',1);

