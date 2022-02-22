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

/*Tambahkan kolom catatan ke Pembelian Detail*/
alter table Pembelian_Detail Add Catatan Text

create table Pembelian_Detail
(
	id_pembelian varChar(19) Not Null,
	id_barang varChar(7) Not Null,
	[harga/pcs] money,
	subTotal money,
	Constraint FK_TblPembelianDetail Foreign Key (id_pembelian) references Pembelian (id_pembelian),
	Constraint FK_TblPembelianDetailBarang Foreign key (id_barang) references Barang (id_barang)
)

/*Tambahkan qty ke tabel Pembelian*/
alter table Pembelian_Detail add Qty int

select * from Pembelian_Detail

Create table Stock
(
	id_barang varChar(7) Not null,
	id_pembelian varChar(19) Not Null,
	stock int,
	Constraint FK_StockTblBarang Foreign Key (id_barang) references Barang (id_barang),
	Constraint FK_StockPembelian Foreign Key (id_pembelian) references Pembelian (id_pembelian)
)

/*hapus kolom catatan pada tabel pembelian*/

alter table Pembelian drop column Catatan


select * from Pembelian
select * from Pembelian_Detail
select * from Stock
select * from Suppliers
select * from Barang
select * from Penjualan
select * from Penjualan_Detail


delete from Pembelian
delete from Pembelian_Detail
delete from Stock
delete from Barang
delete from Penjualan_Detail
delete from Penjualan


/*tampil list pembelian*/
select t1.id_pembelian, t1.id_supplier, t2.nama as [Nama Supplier], t1.tgl_pembelian, t1.grandTotal from Pembelian t1 inner join Suppliers t2 on t1.id_supplier = t2.id_supplier

/*tamppil list pembelian detail yang dipilih*/
select t1.id_pembelian, t1.id_barang, t2.nama_barang as [Nama Barang], t1.[harga/pcs], t1.subTotal, t1.Qty, t1.Catatan from Pembelian_Detail t1 inner join Barang t2 on t1.id_barang=t2.id_barang 

/*Hapus kolom qty, dan harga beli pada tabell barang*/
Alter table Barang Drop Column qty, harga_beli

/*Tambah kolom deskripsi pada tabel barang*/
Alter table Barang add deskripsi text

/*Tambah Kolom discontinued pada tabel barang  rules 1=true, 0=false*/
Alter table Barang add discontinued BIT

/*Ubah deskripsi text menjadi varchar*/
Alter table Barang alter column deskripsi varChar(1000)

select t1.id_barang, t1.nama_barang, t1.harga_jual, ISNull(Sum(t2.stock),0) as 'stock' ,t1.barcode, t1.discontinued,t1.deskripsi from Barang t1 Left Outer join Stock t2 on t1.id_barang=t2.id_barang Group by t1.id_barang,t1.nama_barang,t1.harga_jual,t1.barcode,t1.discontinued,t1.deskripsi


/*Ubah max value nama barang pada tabel barang */
ALter table Barang alter column nama_barang varChar(100)

select * from Stock
select * from Pembelian_Detail

select t1.id_barang, t1.stock, t2.tgl_pembelian, t3.[harga/pcs] from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian inner join Pembelian_Detail t3 on t2.id_pembelian=t3.id_pembelian where t1.id_barang='BRG0001' and t1.stock>0 order by tgl_pembelian asc

/*tampilkan browse barang di penjualan*/
select t1.id_barang, t1.nama_barang, t1.harga_jual, ISNull(Sum(t2.stock),0) as 'stock' ,t1.barcode, t1.deskripsi from Barang t1 Left Outer join Stock t2 on t1.id_barang=t2.id_barang where t1.discontinued=0 Group by t1.id_barang,t1.nama_barang,t1.harga_jual,t1.barcode,t1.discontinued,t1.deskripsi Having ISNull(Sum(t2.stock),0) >0

--select t1.id_barang, t1.nama_barang, t1.harga_jual, Sum(t2.stock) as Stock, t3.tgl_pembelian, t4.[harga/pcs] ,t1.barcode, t1.deskripsi from Barang t1 inner join Stock t2 on t1.id_barang=t2.id_barang inner join Pembelian t3 on t2.id_pembelian=t3.id_pembelian inner join Pembelian_Detail t4 on t3.id_pembelian=t4.id_pembelian where t1.discontinued=0 Group by t1.id_barang,t1.nama_barang,t1.harga_jual,t1.barcode,t1.discontinued,t1.deskripsi, t3.tgl_pembelian,t4.[harga/pcs] Having ISNull(Sum(t2.stock),0) >0 

select  t1.id_barang, t1.stock, t2.tgl_pembelian, t3.[harga/pcs] from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian inner join Pembelian_Detail t3 on t2.id_pembelian=t3.id_pembelian where t1.id_barang='BRG0001' and t1.stock>0 order by tgl_pembelian asc

select * from Penjualan
select * from Penjualan_Detail

--ambil data stock sekarang ketika sebelum pembelian terjadi
select top 1 t1.stock,t1.id_pembelian from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian where id_barang='BRG0001' Order by t2.tgl_pembelian asc


----kurangi stock barang ketika terjadi pembelian
select * from stock order by id_pembelian
