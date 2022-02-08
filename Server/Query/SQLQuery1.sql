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
(id_penjualan varChar(19) Not Null, id_barang varChar(7) Not Null, qty_jual int, sub_total int,
Constraint Fk_TblPenjualanDetail Foreign Key (id_penjualan) references Penjualan (id_penjualan),
Constraint Fk_TblPenjualanDetailBarang Foreign Key (id_barang) references Barang (id_barang)
)

SELECT TOP 1 id_barang FROM Barang ORDER BY id_barang DESC

SELECT TOP 1 id_penjualan FROM Penjualan ORDER BY id_penjualan DESC

create table Suppliers
(
	id_supplier varChar(7) Not Null Primary Key, nama varChar(50), alamat text, provinsi varChar(50), kota varChar(50), telp varchar(12), email varChar(100), deskripsi text
)

drop table Suppliers

select * from Barang

alter table Barang alter column id_barang varChar(7)

alter table Penjualan_Detail drop Constraint Fk_TblPenjualanDetailBarang

alter table Barang alter column id_barang varChar(7) Not null
alter table Barang add constraint PK_Barang Primary Key (id_barang)
alter table Penjualan_Detail alter column id_barang varChar (7) Not Null

alter table Barang alter column barcode varChar(13) Not Null
alter table Penjualan_Detail add Constraint Fk_TblPenjualanDetailBarang Foreign Key (id_barang) references Barang (id_barang)


/*Create tabel Pembelian*/
create table Pembelian
(
	id_pembelian varChar(19) not null primary key,
	id_supplier varChar(7) not null,
	tgl_pembelian datetime, 
	grandTotal money,
	Constraint Fk_TblSupplierPembelian Foreign Key (id_supplier) References Suppliers (id_supplier)
)

create table Pembelian_Detail
(
	id_pembelian varChar(19) Not Null,
	id_barang varChar(7) Not Null,
	[harga/pcs] money,
	subTotal money,
	Constraint FK_TblPembelianDetail Foreign Key (id_pembelian) references Pembelian (id_pembelian),
	Constraint FK_TblPembelianDetailBarang Foreign key (id_barang) references Barang (id_barang)
)

Create table Stock
(
	id_barang varChar(7) Not null,
	id_pembelian varChar(19) Not Null,
	stock int,
	Constraint FK_StockTblBarang Foreign Key (id_barang) references Barang (id_barang),
	Constraint FK_StockPembelian Foreign Key (id_pembelian) references Pembelian (id_pembelian)
)