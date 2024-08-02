CREATE DATABASE projeto_mvc;

USE projeto_mvc;

CREATE TABLE Autor(
	AutorID int PRIMARY KEY AUTO_INCREMENT,
	nome varchar(30),
	nacionalidade varchar(30)
);

CREATE TABLE Livro(
	LivroID int PRIMARY KEY AUTO_INCREMENT,
	Titulo varchar(50), 
    DtPublicacao date,
    AutorID int,
    CONSTRAINT AutorID FOREIGN KEY (AutorID) REFERENCES Autor(AutorID)
);

SELECT * FROM Autor;
SELECT * FROM Livro;


