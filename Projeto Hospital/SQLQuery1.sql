Create table tblcargo(
idcargo int identity(1,1) primary key,
cargo varchar(100),
)

Create table tblUser(
idUser int identity(1,1) primary key,
nome varchar(100),
apelido varchar(100),
Cargo int Foreign key references tblcargo(idcargo),
)

Create table tblLogin(
idLogin int identity(1,1) primary key,
username varchar(100),
password varchar(max),
IdUser int Foreign key references tblUser(idUser)
)