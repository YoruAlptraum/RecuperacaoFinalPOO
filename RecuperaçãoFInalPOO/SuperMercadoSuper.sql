/*
dados de produtos (codigo, nome, descrição, preço, porcentagem de desconto) e 
cliente (cpf e nome).
*/;
use supermercadosuper;
create table clientes (cpf char(11) primary key not null, nome varchar(255));
create table produtos (codigo char(13) primary key not null, nome varchar(255) unique,descriçao varchar(255),preço decimal(65,2),desconto decimal(65,2));


insert into produtos 
values 
('0123456123456','pão da casa','saboroso e crocante',1.50,10),
('0123456123457','sopa em lata SoSopa','sopa SoSopa diversos sabores',5.25,30);

insert into clientes values('12345678954','Godofredo');
insert into clientes values('12345678910','Eugenio');


select * from produtos;
select * from clientes;

alter table produtos modify codigo char(13)