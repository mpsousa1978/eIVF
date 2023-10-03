database in mysql


create database datamp


CREATE TABLE .datampmp_type (
  IdType INT AUTO_INCREMENT PRIMARY KEY,
  Description VARCHAR(45) NOT NULL
);

CREATE TABLE datamp.MP_PRODUCT(
	IdProduct INT AUTO_INCREMENT PRIMARY KEY,
	IdType int NOT NULL,
	Description varchar(100) NOT NULL,
	amount int NOT NULL,
	price decimal(10, 2) NOT NULL,
	Status bit NOT NULL,
	created_at datetime NOT NULL
)