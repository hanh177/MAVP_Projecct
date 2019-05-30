use QLBanVeChuyenBay
go
select * from HANHKHACH

select * from TINHTRANG

select * from DOANHTHUTHANGCB

select * from TONGDOANHTHUTHANG

select * from TONGDOANHTHUNAM

select * from CHUYENBAY

select * from ve

select * from PHIEUDATCHO


delete DOANHTHUTHANGCB
go
delete TONGDOANHTHUTHANG
go
delete TONGDOANHTHUNAM
go
delete PHIEUDATCHO 
go
delete Ve 
go
delete HANHKHACH 
go
delete TINHTRANG 
go
delete from CHUYENBAY 

alter table TongDoanhThuNam add TiLe float
alter table Ve alter column Giave int
update DOANHTHUTHANGCB set TiLe =cast(round(100*SoVe/70.0,2) as numeric(36,2)) 

select cast(round( sum(tile),2 ) as numeric(36,2)) tongTiLe, count(MaDoanhThuThang) tongsoThang  from TONGDOANHTHUTHANG where  MaDoanhThuNam= 'dtn2019'