create database if not exists baza
  default character set utf8mb4
  collate utf8mb4_polish_ci;

use baza;

create table if not exists testowa (
  id int unsigned not null auto_increment primary key,
  imie varchar(55) not null,
  nazwisko varchar(155) not null,
  wiek int not null
) engine=innodb default charset=utf8mb4 collate=utf8mb4_polish_ci;

insert into testowa (imie, nazwisko, wiek) values
('piotr','kowalski',50),
('ania','nowak',25),
('tomasz','jaguar',34),
('agata','młyn',22),
('kasia','sobek',45),
('natalia','parus',18),
('kuba','wojewódzki',45),
('zdzisiu','pierdzipieta',55);


select id, imie, nazwisko, wiek
from testowa
order by imie collate utf8mb4_polish_ci asc;

select id, imie, nazwisko, wiek
from testowa
order by wiek asc, imie collate utf8mb4_polish_ci asc;
