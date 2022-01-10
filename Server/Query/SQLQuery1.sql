create database db_petshop

use db_petshop

create table Pengguna 
(username varChar(50), pass varChar(25))


Alter table Pengguna Alter Column username varChar(50) Not Null
Alter table Pengguna Alter Column pass varChar(200) Not Null
Alter table Pengguna Add Constraint PK_TBLPENGGUNA Primary Key(username)

insert into Pengguna Values ('admin','YU36ql0ImVM=');

select * from Pengguna

create table SecretKeylogger  
(keylogger varChar(50))

insert into SecretKeylogger Values ('SEFhiaxxxk=')
select * from SecretKeylogger

update SecretKeylogger set keylogger='ePRDkUP97bzhYM4vT/b4Uw==' where keylogger = 'SEFhiaxxxk='

create table Barang 
(id_barang varChar(900) Not Null Primary Key, nama_barang varChar(25), qty int, harga_beli money, harga_jual money, barcode varChar(100))

drop table Barang

select * from Barang

select sum(harga_beli) as 'harga' from Barang

create table Penjualan
(id_penjualan varChar(19) Not Null Primary Key, tgl_transaksi datetime, total_harga money)

create table Penjualan_Detail
(id_penjualan varChar(19) Not Null, id_barang varChar(900) Not Null, qty_jual int, sub_total int,
Constraint Fk_TblPenjualanDetail Foreign Key (id_penjualan) references Penjualan (id_penjualan),
Constraint Fk_TblPenjualanDetailBarang Foreign Key (id_barang) references Barang (id_barang)
)

SELECT TOP 1 id_barang FROM Barang ORDER BY id_barang DESC

SELECT TOP 1 id_penjualan FROM Penjualan ORDER BY id_penjualan DESC