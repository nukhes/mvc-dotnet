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

INSERT INTO Autor (nome, nacionalidade) VALUES ('J.K. Rowling', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('George R.R. Martin', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('J.R.R. Tolkien', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Isaac Asimov', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Stephen King', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Agatha Christie', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('H.G. Wells', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Orwell', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('F. Scott Fitzgerald', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Ernest Hemingway', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Mark Twain', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Jane Austen', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Charles Dickens', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Herman Melville', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Leo Tolstoy', 'Russiana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Fyodor Dostoevsky', 'Russa');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Gabriel Garcia Marquez', 'Colombiana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Pablo Neruda', 'Chilena');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Jorge Luis Borges', 'Argentina');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Mario Vargas Llosa', 'Peruana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Miguel de Cervantes', 'Espanhola');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Hermann Hesse', 'Alemã');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Thomas Mann', 'Alemã');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Franz Kafka', 'Alemã');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Kurt Vonnegut', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Ray Bradbury', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Arthur C. Clarke', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Douglas Adams', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Margaret Atwood', 'Canadense');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Ursula K. Le Guin', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Neil Gaiman', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Liu Cixin', 'Chinesa');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Haruki Murakami', 'Japonesa');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Salman Rushdie', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Toni Morrison', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('John Steinbeck', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Daphne du Maurier', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('E. M. Forster', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Vladimir Nabokov', 'Russa');
INSERT INTO Autor (nome, nacionalidade) VALUES ('George Orwell', 'Britânica');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Bram Stoker', 'Irlandesa');
INSERT INTO Autor (nome, nacionalidade) VALUES ('J.D. Salinger', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Sylvia Plath', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('Jack Kerouac', 'Americana');
INSERT INTO Autor (nome, nacionalidade) VALUES ('William Faulkner', 'Americana');

INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Harry Potter e a Pedra Filosofal', '1997-06-26', 1);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('A Guerra dos Tronos', '1996-08-06', 2);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Senhor dos Anéis', '1954-07-29', 3);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Fundação', '1951-06-01', 4);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Iluminado', '1977-09-01', 5);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Assassinato no Expresso do Oriente', '1934-01-01', 6);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('A Máquina do Tempo', '1895-01-01', 7);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('1984', '1949-06-08', 8);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Grande Gatsby', '1925-04-10', 9);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Velho e o Mar', '1952-09-01', 10);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('As Aventuras de Tom Sawyer', '1876-01-01', 11);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Orgulho e Preconceito', '1813-01-28', 12);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Oliver Twist', '1837-01-01', 13);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Moby-Dick', '1851-11-14', 14);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Guerra e Paz', '1869-01-01', 15);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Crime e Castigo', '1866-01-01', 16);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Cem Anos de Solidão', '1967-05-30', 17);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Canto Geral', '1950-01-01', 18);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Ficções', '1944-01-01', 19);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('A Guerra do Fogo', '2006-01-01', 20);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Dom Quixote', '1605-01-01', 21);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Lobo da Estepe', '1927-01-01', 22);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Os Buddenbrook', '1901-01-01', 23);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Processo', '1925-01-01', 24);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Coração Satânico', '1987-09-01', 25);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Fahrenheit 451', '1953-10-19', 26);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Guia do Mochileiro das Galáxias', '1979-10-12', 27);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('A Mão Esquerda da Escuridão', '1969-03-01', 28);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Neverwhere', '1996-11-01', 29);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('O Problema dos Três Corpos', '2008-11-11', 30);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Kafka à Beira-Mar', '2002-05-05', 31);
INSERT INTO Livro (Titulo, DtPublicacao, AutorID) VALUES ('Os Versos Satânicos', '1988-09-01', 32);

SELECT * FROM Autor;
SELECT * FROM Livro;


