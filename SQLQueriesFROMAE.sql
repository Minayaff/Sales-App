--CREATE DATABASE FromAE;

--USE FromAE;

--CREATE SCHEMA Product AUTHORIZATION dbo;
GO --batch

--Create TABLE Product.Product
--(Id int not null primary key identity,
--[Name] nvarchar(50) not null,
--Price decimal,
--Status bit default 1,
--[Path] nvarchar(150),
--CategoryId int references Product.Categories(Id)
--)

--CREATE TABLE Product.Categories
--(Id int not null primary key identity,
--[Name] nvarchar(50) not null,
--)


--create table Users(
--ID int not null primary key identity,
--[Name] nvarchar(200),
--[Surname] nvarchar(200),
--[Password] nvarchar(255)
--)

--create table UserToProduct(
--ID int not null primary key identity,
--UserId int references Users(ID),
--ProductId int references Product.Product(Id),

--)