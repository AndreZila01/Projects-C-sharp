Create table tbl_Login(
idLogin int identity(1,1) primary key,
Usern varchar(150),
Passw varchar(150),
);

Create table Tbl_Medicos(
NumMed int identity(1,1) Primary key,
NomeMed varchar(50) UNIQUE,
Especialidade varchar(100) not null,
Sexo varchar(1) not null, 
NumOrdemMed varchar(9),
idlogin int foreign key references tblLogin(idLogin),
Telefone varchar(12)
);

Create table Tbl_Pacientes(
NumPac int identity(1,1) Primary key,
NomePac varchar(50) UNIQUE,
DataNasc date not null,
Subsistema varchar(150) not null,
Telefone varchar(12) not null,
NomeResp varchar(50) not null, --Nome de Responsavel
TeleResp varchar(12) not null
);

Create table Tbl_Consulta (
NumCons int identity(1,1) Primary key,
DataCons date not null,
NMed int Foreign key references tbl_Medicos(NumMed),
NPac int Foreign key references tbl_Pacientes(NumPac),
ValorCon Decimal(7,2) not null,
MotivoDaConsulta varchar(100) not null,
ResultadoMed varchar(150),
);

insert into tbl_Login(Usern, Passw)values(
'JosePedro', '123');

insert into Tbl_Medicos(NomeMed,NumOrdemMed,Sexo,Telefone,Especialidade, idlogin)values(
'José', '521942347', 'M', '912345638', 'Cirurgião plastico', 1
);

Insert into Tbl_Consulta(DataCons, NMed, NPac, ValorCon, MotivoDaConsulta, ResultadoMed)
values
('20210311', 1, 1, 30.00, 'Dores de barriga', 'Colicas')

