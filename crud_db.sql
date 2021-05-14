create database crud_csharp;
use crud_csharp;
create table empregados(
id int(3) primary key auto_increment,
nomeEmpregado varchar(60),
sobreomeEmpregado varchar(50),
cpfEmpregado varchar(20)
);
select * from empregados;

create database crud_fornecedor;
use crud_fornecedor;
create table fornecedores(
idFornecedor int auto_increment not null,
CNPJ varchar(14) not null,
Nome varchar(40),
Telefone varchar(15),
Email varchar(30),
primary key(idFornecedor)
);
select * from fornecedores;
