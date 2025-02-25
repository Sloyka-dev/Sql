# sql

[MySQL Server](https://dev.mysql.com/downloads/installer/)

[MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

## База данных

``` sql
CREATE DATABASE test;

use test;

CREATE TABLE `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `login` varchar(20) DEFAULT NULL,
  `pass` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `login_UNIQUE` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `test`.`users` (`login`, `pass`)
VALUES ('admin', 'Pas$w0rD'), 
('user1', 'qwerty'), 
('user2', 'pass'), 
('user3', '12345'), 
('user4', 'user4');
```
