create database crud_csharp;
use crud_csharp;
create table empregados(
id int(3) primary key auto_increment,
nomeEmpregado varchar(60),
sobreomeEmpregado varchar(50),
cpfEmpregado varchar(20)
);
select * from empregados;

