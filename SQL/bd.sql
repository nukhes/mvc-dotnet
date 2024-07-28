CREATE DATABASE projeto_mvc;
USE projeto_mvc;

CREATE TABLE Autor (
    AutorID INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(30) not null,
    Nacionalidade VARCHAR(30) not null
);

CREATE TABLE Livro (
    LivroID INT PRIMARY KEY AUTO_INCREMENT,
    Titulo VARCHAR(50) not null,
    DtPublicacao DATE,
    AutorID INT,
    constraint fk_AutorID foreign key (AutorID) references Autor (AutorID)
);

-- Operações Úteis
SELECT * FROM Autor;
SELECT * FROM Livro;