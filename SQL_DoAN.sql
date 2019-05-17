create database QLBanVeChuyenBay
go
Use QLBanVeChuyenBay
go
SET DATEFORMAT DMY
create table SANBAY
(
MaSanBay varchar(10) primary key,
TenSanBay nvarchar(100) not null
)
go
create table CHUYENBAY
(
MaCB varchar(10) primary key,
SanBayDi varchar(10) not null,
SanBayDen varchar(10) not null,
NgayGio smalldatetime not null,
ThoiGianBay int not null,
SLGheHang1 int not null,
SLGheHang2 int not null

)
Alter table CHUYENBAY add GiaVe money
Alter table CHUYENBAY alter column GiaVe int
Alter table CHUYENBAY add constraint fk_CB_SBdi foreign key (SanBayDi) references SANBAY(MaSanBay)
Alter table CHUYENBAY add constraint fk_CB_SBden foreign key (SanBayDen)  references SANBAY(MaSanBay)


create table TRUNGGIAN
(
MaTrungGian varchar(10) primary key,
MaCB varchar(10) not null ,
MaSanBay varchar(10) not null,
ThoiGianDung int not null,
Ghichu nvarchar(500)
)

alter table TRUNGGIAN add constraint fk_TG_CB foreign key (MaCB) references CHUYENBAY (MaCB)
alter table TRUNGGIAN add constraint fk_TG_SB foreign key (MaSanBay) references SANBAY (MaSanBay)

create table TINHTRANG
(
MaTinhTrang varchar(10) primary key,
MaCB varchar(10),
SLGheTrongH1 int,
SLGheTrongH2 int,
TongSoGhe int,
TongSoGheTrong int,
TongSoGheDat int
)
alter table TINHTRANG add constraint fk_TT_CB foreign key(MaCB) references CHUYENBAY(MaCB)

create table HANHKHACH
(
MaHanhKhach varchar(10) primary key,
HoTen nvarchar(100) not null,
CMMD int not null,
SDT int
)

create table VE
(
MaVe varchar(10) primary key,
MaHanhKhach varchar(10),
MaCB varchar(10),
GiaVe money,
HangVe int 
)
alter table VE add constraint pk_Ve_HK foreign key (MaHanhKhach) references HANHKHACH(MaHanhKhach)
alter table VE add constraint pk_Ve_CB foreign key (MaCB) references CHUYENBAY(MaCB)
alter table VE add constraint ck_HangVe check (HangVe =1 or HangVe=2)

create table PHIEUDATCHO
(
MaPhieu varchar(10) primary key,
MaCB varchar(10),
MaHanhKhach varchar(10),
MaVe varchar(10),
NgayDat smalldatetime
)

alter table PHIEUDATCHO add constraint pk_PHIEU_CB foreign key (MaCB) references CHUYENBAY(MaCB)
alter table PHIEUDATCHO add constraint pk_PHIEU_VE foreign key (MaVe) references VE(MaVe)


create table TONGDOANHTHUNAM
(
MaDoanhThuNam varchar(10) primary key,
TongDoanhThu money,
Nam int
)


create table TONGDOANHTHUTHANG
(
MaDoanhThuThang varchar(10) primary key,
MaDoanhThuNam varchar(10),
SoChuyenBay int,
TongDoanhThu money,
TiLe float,	
Thang int
)

alter table TONGDOANHTHUTHANG add constraint pk_DTThang_DTNam foreign key(MaDoanhThuNam) references TONGDOANHTHUNAM(MaDoanhThuNam)

create table DOANHTHUTHANGCB
(
MaDoanhThuCB varchar(10) primary key,
MaDoanhThuThang varchar(10),
MaCB varchar(10),
SoVe int,
DoanhThu money,
TiLe float
)

alter table DOANHTHUTHANGCB add constraint pk_DTCB_DTThang foreign key(MaDoanhThuThang) references TONGDOANHTHUTHANG(MaDoanhThuThang)
alter table DOANHTHUTHANGCB add constraint pk_DTCB_CB foreign key(MaCB) references CHUYENBAY(MaCB)


go
--insert SANBAY--------------------------------------
insert into SANBAY values('SB01',N'Nội Bài') 
insert into SANBAY values('SB02',N'Tân Sơn Nhất ')
insert into SANBAY values('SB03',N'Vinh')
insert into SANBAY values('SB04 ',N'Thọ Xuân ')
insert into SANBAY values('SB05',N'Sao Vàng')
insert into SANBAY values('SB06 ', N'Cần Thơ ')
insert into SANBAY values('SB07 ',N'Côn Đảo ')
insert into SANBAY values('SB08 ',N'Phù Cát ')
insert into SANBAY values('SB09',N'Dà Nẵng ')
insert into SANBAY values('SB10 ',N'Cát Bà ')
go
--insert CHUYENBAY------------------------------------
insert into CHUYENBAY values('CB01 ','SB01 ','SB02 ',12/12/2019 ,120 ,40 ,50 ,1200000 )
insert into CHUYENBAY values('CB02 ','SB02 ','SB04 ', 1/5/2019, 120,60,30 ,2000000 )
insert into CHUYENBAY values('CB03 ','SB06 ','SB04',2/7/2019 , 50, 45,45 ,1000000 )

go

----------insert TinhTRang----------
insert into TINHTRANG values ( 'TT01' , 'CB01' , 40, 50, 90, 90, 0)
insert into TINHTRANG values ( 'TT02' , 'CB02' , 60, 30, 90, 90, 0)
insert into TINHTRANG values ( 'TT03' , 'CB03' , 45, 45, 90, 90, 0)



---------danh sach chuyen bay--------------
select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2
from (CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi=SBdi.MaSanBay join SANBAY SBden on CB.SanBayden =SBden.MaSanBay ) join ( CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB =TG.MaCB left join SANBAY SB_TG on TG.MaSanBay =SB_TG.MaSanBay) on CB.MaCB =CHUYENBAY.MaCB
join TINHTRANG TT on CB.MaCB =TT.MaCB
----------------------------------------------

select* from Ve


create table THAMSO
(
MaThamSo varchar(10) primary key,
SoSanBayTGMax int not null,
TGBayToiDa int not null ,
TGChamNhatDatVe int not null ,
TGChamNhatHuyVe int not null
)

