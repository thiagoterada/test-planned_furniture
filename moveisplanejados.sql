CREATE DATABASE loja_moveis;
USE loja_moveis;

CREATE TABLE CLIENTE(idCli int primary key auto_increment,
					 nome varchar(50) not null,
                     cpf varchar(14) not null,
                     rg varchar(14) not null,
                     sexo char(1) not null,
                     tel varchar(14) not null,
                     cel varchar(14),
                     uf char(2) not null,
                     cidade varchar(50) not null,
                     bairro varchar(50) not null,
                     logradouro varchar(50) not null,
                     numero int not null,
                     cep varchar(9),
                     compl varchar(50)
);

CREATE TABLE TIPO_MOVEL(idTipoMov int primary key auto_increment,
						nome varchar(50) not null,
                        dsMov varchar(500)
);

CREATE TABLE PROJETO(idProj int primary key auto_increment,
					 idTipoMov int not null,
                     CONSTRAINT fk_TIPO_MOVELPROJETO FOREIGN KEY (idTipoMov) REFERENCES TIPO_MOVEL(idTipoMov),
                     idCli int not null,
                     CONSTRAINT fk_CLIENTEPROJETO FOREIGN KEY (idCli) REFERENCES CLIENTE(idCli),
					 nome varchar(100) not null,
                     dsProj varchar(500),
                     preco float not null,
                     dt datetime not null,
                     dt_entrega datetime not null
);

SELECT * FROM CLIENTE;
                     