create database db_petshop

use db_petshop

create table Pengguna 
(username varChar(50), pass varChar(25))


Alter table Pengguna Alter Column username varChar(50) Not Null
Alter table Pengguna Alter Column pass varChar(200) Not Null
Alter table Pengguna Add Constraint PK_TBLPENGGUNA Primary Key(username)

insert into Pengguna Values ('admin','YU36ql0ImVM=');

select * from Pengguna
select * from SecretKeylogger

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
select top 2 t1.stock,t1.id_pembelian from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian where id_barang='BRG0001' Order by t2.tgl_pembelian asc


----kurangi stock barang ketika terjadi pembelian
select * from stock order by id_pembelian

use db_petshop

select * from Penjualan_Detail
select * from Penjualan
select * from Stock
---Ambil data harga beli (join 3 tabel)
select t1.id_barang, t1.stock,t1.id_pembelian, t3.[harga/pcs] from Stock t1 inner join Pembelian t2 on t1.id_pembelian=t2.id_pembelian inner join Pembelian_Detail t3 on t2.id_pembelian=t3.id_pembelian where t1.id_barang='BRG0001' and stock >0 Order by t2.tgl_pembelian asc


---ambil data untuk history penjualan
select t1.id_barang as ID, t2.nama_barang as Nama, sum(t1.qty_jual) as Qty, t1.harga_jual as Harga, t1.sub_total as SubTotal from Penjualan_Detail t1 inner join Barang t2 on t1.id_barang = t2.id_barang where id_penjualan = 'PJ000006/04/03/2022' group by t1.id_barang,t2.nama_barang,t1.harga_jual,t1.sub_total


---Buat Tabel Backup Record
Create Table BackupTrackRecord 
( 
	backupID int not null IDENTITY (1,1) PRIMARY KEY,
	tgl_backup datetime,
	file_path text
)

select * from BackupTrackRecord

select Top 1 tgl_backup from BackupTrackRecord order by tgl_backup DESC

use db_petshop

select t1.id_barang , t2.nama_barang, sum(t1.stock) as Qty from Stock t1 inner join Barang t2 on t1.id_barang=t2.id_barang group by t1.id_barang,t2.nama_barang having sum(t1.stock)>0 

select * from Stock
select * from Pembelian
select * from Suppliers
select * from Pembelian_Detail


select t1.id_pembelian, t4.nama as 'Nama Supplier', t1.stock, t3.[harga/pcs], t3.Catatan from Stock t1 inner join Pembelian t2 on t1.id_pembelian = t2.id_pembelian
inner join Suppliers t4 on t2.id_supplier = t4.id_supplier inner join Pembelian_Detail t3 on t2.id_pembelian= t3.id_pembelian where t1.stock>0 


---Buat Tabel Pengurangan Stock
Create Table Pengurangan_Stock 
(
	id_pengurangan varChar(19) Not Null Primary Key,
	id_barang varChar(7) Not Null,
	id_pembelian varChar(19) Not Null,
	tglPengurangan datetime,
	qtyAwal int,
	qtyAkhir int,
	jlhPengurangan int,
	Keterangan Text,
	Constraint FK_PenguranganBarang Foreign Key (id_barang) References Barang (id_barang),
	Constraint FK_PenguranganPembelian Foreign Key (id_pembelian) References Pembelian (id_pembelian)
)

select * from Pengurangan_Stock
select * from Barang
select * from Penjualan_Detail
--ambil data untuk RECEIPT
select t1.id_penjualan,Convert(varchar,t1.tgl_transaksi,0) as tgl_transaksi,FORMAT(t1.total_harga,'Rp#,0.00')as total_harga,FORMAT(t1.potongan,'Rp#,0.00') as potongan,Format(t1.grand_total,'Rp#,0.00') as grand_total,Format(t1.dibayarkan,'Rp#,0.00') as Dibayarkan ,Format(t1.kembalian,'Rp#,0.00') as Kembalian,t2.id_barang, t3.nama_barang,sum(t2.qty_jual) as Qty, Format(t2.harga_jual,'Rp#,0.00' )as Harga, FORMAT(t2.sub_total,'Rp#,0.00') as SubTotal from Penjualan t1 inner join Penjualan_Detail t2 on t1.id_penjualan= t2.id_penjualan inner join Barang t3 ON t2.id_barang=t3.id_barang where t1.id_penjualan = 'PJ000002/29/05/2022' group by t1.id_penjualan, t1.tgl_transaksi,t1.total_harga,t1.potongan,t1.grand_total,t1.dibayarkan,t1.kembalian,t2.id_barang,t3.nama_barang,t2.harga_jual,t2.sub_total

--Ambil pengeluaran Bulan Ini
Select FORMAT(sum(biaya),'#0,0') as Biaya from BiayaLain where Month(tgl) = 6 and YEAR(tgl) = 2022 

--Ambil data total stock
Select sum(stock) from Stock 

--Ambil data stock yang terjual
Select sum(qty_jual) as Stock_Terjual from Penjualan_Detail

--Ambil data rata-rata stock terjual perbulan
SELECT AVG(a.sum) AS avgStockTerjual 
FROM ( SELECT sum(t1.qty_jual) AS sum, MONTH(t2.tgl_transaksi) as mnth
       FROM Penjualan_Detail t1 inner join Penjualan t2 on t1.id_penjualan=t2.id_penjualan 
       GROUP BY MONTH(t2.tgl_transaksi)) AS a


--Ambil data total transaksi
Select count(id_penjualan) as Total_Transaksi from Penjualan

--Ambil data total transaksi bulan ini
Select count(id_penjualan) as Total_Transaksi from Penjualan where Month(tgl_transaksi)=MONTH(GETDATE())

--Ambil data rata-rata transaksi perbulan
SELECT AVG(a.count) AS TransaksiRataRata 
FROM ( SELECT count(*) AS count, MONTH(tgl_transaksi) as mnth
       FROM Penjualan
       GROUP BY MONTH(tgl_transaksi) ) AS a


--Ambil data Pendapatan Setiap Bulan
Select Sum(t1.sub_total) as Pendapatan_Kotor, sum(t1.harga_jual-t1.harga_beli-t2.potongan)as Pendapatan_Bersih, FORMAT(t2.tgl_transaksi,'yyyy-MM') as Year_Month from Penjualan_Detail t1
inner join Penjualan t2 on t1.id_penjualan=t2.id_penjualan Group By FORMAT(t2.tgl_transaksi,'yyyy-MM')

--ambil data biaya perbulan
Select Sum(biaya) as biaya, FORMAT(tgl,'yyyy-MM') as blnThn from BiayaLain Group By FORMAT(tgl,'yyyy-MM')

select * from Penjualan_Detail

Select * from BiayaLain

select Sum(t1.qty_jual) as sum from Penjualan_Detail t1 inner join Penjualan t2 on t1.id_penjualan=t2.id_penjualan where month(t2.tgl_transaksi)=5 

use db_petshop

select t1.id_pengurangan, t1.id_barang, t2.nama_barang, t1.id_pembelian, t3.id_supplier, t4.nama as nama_supplier, t1.tglPengurangan, t1.qtyAwal, t1. qtyAkhir,t1.jlhPengurangan, t1.Keterangan from Pengurangan_Stock t1 inner join Barang t2 on t1.id_barang = t2.id_barang inner join Pembelian t3 on t1.id_pembelian=t3.id_pembelian inner join Suppliers t4 on t3.id_supplier=t4.id_supplier order by t1.tglPengurangan DESC

--ambil data pendapatan harian
Select Sum(t1.sub_total) as Pendapatan_Kotor, sum(t1.harga_jual-t1.harga_beli-t2.potongan)as Pendapatan_Bersih, FORMAT(t2.tgl_transaksi,'yyyy-MM-dd') as Tanggal from Penjualan_Detail t1
inner join Penjualan t2 on t1.id_penjualan=t2.id_penjualan Group By FORMAT(t2.tgl_transaksi,'yyyy-MM-dd')

use db_petshop
----Get laba Keseluruhan----
SELECT (select SUM(harga_jual*qty_jual) as laba from Penjualan_Detail ) - (SELECT SUM(biaya) as biaya FROM BiayaLain) - (SELECT SUM(grandTotal) FROM Pembelian) -
(SELECT SUM(t2.[harga/pcs]*t1.jlhPengurangan) as Total_Pengurangan FROM Pengurangan_Stock t1 inner join Pembelian_Detail t2 on t1.id_pembelian = t2.id_pembelian AND t1.id_barang = t2.id_barang) AS 'Laba Keseluruhan'
---Get laba Keseluruhan----

----Get laba Keseluruhan Per Month----
SELECT (select SUM(harga_jual*qty_jual) as laba from Penjualan_Detail) - (SELECT SUM(biaya) as biaya FROM BiayaLain) - (SELECT SUM(grandTotal) FROM Pembelian) -
(SELECT SUM(t2.[harga/pcs]*t1.jlhPengurangan) as Total_Pengurangan FROM Pengurangan_Stock t1 inner join Pembelian_Detail t2 on t1.id_pembelian = t2.id_pembelian AND t1.id_barang = t2.id_barang) AS 'Laba Keseluruhan'
---Get laba Keseluruhan Per Month----

CREATE FUNCTION vw_LabaBersihKeseluruhan (@month int, @year int)
RETURNS TABLE
AS
RETURN
	SELECT ISNULL((select SUM(grand_total) as laba from Penjualan where (MONTH(tgl_transaksi)=@month AND YEAR(tgl_transaksi)=@year)),0) - ISNULL((SELECT SUM(biaya) as biaya FROM BiayaLain where (MONTH(tgl)=@month AND YEAR(tgl)=@year)),0) - ISNULL((SELECT SUM(grandTotal) FROM Pembelian WHERE (MONTH(tgl_pembelian)=@month AND YEAR(tgl_pembelian)=@year)),0) -
	ISNULL((SELECT SUM(t2.[harga/pcs]*t1.jlhPengurangan) as Total_Pengurangan FROM Pengurangan_Stock t1 inner join Pembelian_Detail t2 on t1.id_pembelian = t2.id_pembelian AND t1.id_barang = t2.id_barang WHERE (MONTH(tglPengurangan)=@month AND YEAR(tglPengurangan)=@year)),0) AS 'Laba_Keseluruhan' 

DROP Function vw_LabaBersihKeseluruhan

SELECT * FROM Penjualan where MONTH(tgl_transaksi)=2 AND Year(tgl_transaksi)=2022

SELECT * FROM vw_LabaBersihKeseluruhan(2,2022)
SELECT * FROM Penjualan
SELECT * FROM Pengurangan_Stock
SELECT * FROM BiayaLain
SELECT  * FROM Penjualan_Detail
SELECT * FROM Pembelian

SELECT * FROM Penjualan

SELECT t1.id_pengurangan, t1.id_barang, t1.id_pembelian, t1.jlhPengurangan, t2.[harga/pcs] FROM Pengurangan_Stock t1 inner join Pembelian_Detail t2 on t1.id_pembelian = t2.id_pembelian AND t1.id_barang = t2.id_barang

--Get StartPeriod From All Transaction
DECLARE @datePenjualan varchar(max), @datePembelian varchar(max)
SET @datePenjualan = MAX(tgl_transaksi) from Penjualan 
SET @datePembelian = MAX(tgl_pembelian) from Pembelian
IF @datePenjualan=@datePembelian
SELECT 'equal date'
ELSE
IF @datePenjualan<@datePembelian SELECT 'date2 is greater'
ELSE SELECT 'date1 is greater';


--Get LastPeriod From All Transaction

use db_petshop

SELECT ISNULL((select SUM(grand_total) as laba from Penjualan where (MONTH(tgl_transaksi)=2 AND YEAR(tgl_transaksi)=2022) ),0) - ISNULL((SELECT SUM(biaya) as biaya FROM BiayaLain where (MONTH(tgl)=2 AND YEAR(tgl)=2022)),0) - ISNULL((SELECT SUM(grandTotal) FROM Pembelian WHERE (MONTH(tgl_pembelian)=2 AND YEAR(tgl_pembelian)=2022)),0) -
	ISNULL((SELECT SUM(t2.[harga/pcs]*t1.jlhPengurangan) as Total_Pengurangan FROM Pengurangan_Stock t1 inner join Pembelian_Detail t2 on t1.id_pembelian = t2.id_pembelian AND t1.id_barang = t2.id_barang WHERE (MONTH(tglPengurangan)=2 AND YEAR(tglPengurangan)=2022)),0) AS 'Laba_Keseluruhan' 

	SELECT * FROM vw_LabaBersihKeseluruhan(1,2022)

	SELECT * FROM Penjualan

CREATE FUNCTION vw_sumItemTerjual (@startDate Date, @endDate Date)
RETURNS TABLE
AS
RETURN
Select t3.nama_barang, isNull(sum(t2.qty_jual),0) as terjual FROM Penjualan t1 inner join Penjualan_Detail t2 on t1.id_penjualan = t2.id_penjualan right outer join barang t3 on t2.id_barang=t3.id_barang where t1.tgl_transaksi between @startDate AND @endDate group by t3.nama_barang 

SELECT * FROM vw_sumItemTerjual('1-1-2022','5-11-2022')

drop Function vw_sumItemTerjual 

Select t3.nama_barang, isNull(sum(t2.qty_jual),0) as terjual FROM Penjualan t1 left outer join Penjualan_Detail t2 on t1.id_penjualan = t2.id_penjualan left outer join barang t3 on t2.id_barang=t3.id_barang where (MONTH(t1.tgl_transaksi)=2 AND YEAR(t1.tgl_transaksi)=2022) group by t3.nama_barang 


SELECT t1.nama_barang, isNull(sum(t2.qty_jual),0) as terjual from barang t1 left outer join Penjualan_Detail t2 on t1.id_barang=t2.id_barang inner join Penjualan t3 on t2.id_penjualan=t3.id_penjualan group by t1.nama_barang

SELECT YEAR(getdate()) * 100

SELECT * FROM Penjualan

CREATE FUNCTION vw_pendapatanKotor (@month int, @year int)
RETURNS TABLE
AS
RETURN
SELECT ISNULL(SUM(grand_total),0) as pendapatan_kotor FROM Penjualan where (MONTH(tgl_transaksi)=@month AND YEAR(tgl_transaksi)=@year)

Drop Function vw_labaKotor


---GET LAPORAN LABA KOTOR
Select Sum(t1.sub_total-t2.potongan) AS Laba_Kotor, FORMAT(t2.tgl_transaksi,'yyyy-MM') as Year_Month from Penjualan_Detail t1 inner join Penjualan t2 on t1.id_penjualan = t2.id_penjualan Group By FORMAT(t2.tgl_transaksi, 'yyyy-MM')

---GET LAPORAN BARANG
SELECT * FROM vw_sumItemTerjual(@startDate,@endDate)

--GET LAPORAN LABA
SELECT * FROM vw_LabaBersihKeseluruhan(@month,@year)

SELECT * FROM Penjualan_Detail

SELECT * FROM vw_sumItemTerjual(@startDate,@endDate) 

SELECT        Pembelian.id_pembelian, Pembelian.tgl_pembelian, Pembelian.id_supplier, Pembelian.grandTotal, Suppliers.nama, Pembelian_Detail.id_barang, Pembelian_Detail.[harga/pcs] as hargaPcs, Pembelian_Detail.subTotal, 
                         Pembelian_Detail.Qty, Barang.nama_barang
FROM            Pembelian INNER JOIN
                         Pembelian_Detail ON Pembelian.id_pembelian = Pembelian_Detail.id_pembelian INNER JOIN
                         Suppliers ON Pembelian.id_supplier = Suppliers.id_supplier INNER JOIN
                         Barang ON Pembelian_Detail.id_barang = Barang.id_barang where  Order By Pembelian.tgl_pembelian DESC

select * from Pembelian_Detail where id_pembelian = 'PB000003/20/02/2022' AND id_barang='BRG0001'

SELECT * FROM Pengurangan_Stock


select t1.id_pengurangan, t1.id_barang, t2.nama_barang, t1.id_pembelian,
                 t3.id_supplier, t4.nama as nama_supplier, t1.tglPengurangan, t1.qtyAwal, t1. qtyAkhir,t1.jlhPengurangan, (t1.jlhPengurangan * t5.[harga/pcs]) as jlhKerugian,
                t1.Keterangan from Pengurangan_Stock t1 inner join Barang t2 on t1.id_barang = t2.id_barang inner join Pembelian t3 
                on t1.id_pembelian=t3.id_pembelian inner join Suppliers t4 on t3.id_supplier=t4.id_supplier inner join pembelian_detail t5 on (t1.id_pembelian=t5.id_pembelian AND  t1.id_barang=t5.id_barang) where t1.tglPengurangan between '' AND ''order by t1.tglPengurangan DESC

use db_petshop

select sum(biaya) as totalBiayaLain from BiayaLain 

select sum(grandTotal) as totalPembelian from Pembelian

select * from Pengurangan_Stock

Select sum(t1.jlhPengurangan * t2.[harga/pcs]) as totalPenguranganBarang from Pengurangan_Stock t1 inner join Pembelian_Detail t2 on (t1.id_pembelian=t2.id_pembelian AND t1.id_barang = t2.id_barang) where t1.tglPengurangan BETWEEN '2022-03-01' and '2022-05-10'

select * from Pengurangan_Stock t1 inner join Pembelian_Detail t2 on (t1.id_pembelian=t2.id_pembelian AND t1.id_barang = t2.id_barang) where t1.tglPengurangan BETWEEN '2022-03-01' and '2022-05-10'

select * from Pembelian_Detail

create function f_showSummaryPengeluaran (
	@startDate Date,
	@endDate date
)
returns table
as return 
SELECT (Select isnull(sum(t1.jlhPengurangan * t2.[harga/pcs]),0) as totalPenguranganBarang from Pengurangan_Stock t1 inner join Pembelian_Detail t2 on (t1.id_pembelian=t2.id_pembelian AND t1.id_barang = t2.id_barang) where t1.tglPengurangan Between @startDate and @endDate) as totalPenguranganBarang, 
(select isnull(sum(grandTotal),0) as totalPembelian from Pembelian where tgl_pembelian BETWEEN @startDate and @endDate) as totalPembelian, 
(select isnull(sum(biaya),0) as totalBiayaLain from BiayaLain where tgl between @startDate and @endDate) as totalBiayaLain

select * from BiayaLain

--drop function f_showSummaryPengeluaran

use db_petshop

SELECT * FROM Pengguna

ALTER Table Pengguna ADD 

SELECT * FROm Pengguna

SELECT * From SecretKeylogger