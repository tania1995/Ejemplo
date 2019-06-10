# Host: localhost:33065  (Version 5.5.5-10.1.38-MariaDB)
# Date: 2019-04-09 10:14:46
# Generator: MySQL-Front 6.0  (Build 2.20)


#
# Structure for table "empleados"
#

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `idempleado` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(255) DEFAULT NULL,
  `apellidos` varchar(255) DEFAULT NULL,
  `edad` int(11) DEFAULT '0',
  PRIMARY KEY (`idempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

#
# Data for table "empleados"
#

INSERT INTO `empleados` VALUES (1,'juana','perez',22),(3,'ana','lopez',28),(5,'Miguel','Quispe',42),(6,'ana','mamani',21),(7,'','',0),(8,'','',0),(9,'','',0),(10,'','',0);

#
# Structure for table "usuarios"
#

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `habilitado` char(1) DEFAULT '1',
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "usuarios"
#

INSERT INTO `usuarios` VALUES (1,'lisss','445555','0');
