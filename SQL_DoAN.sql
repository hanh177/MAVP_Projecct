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
TongGheTrong int,
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
insert into CHUYENBAY (MaCB,SanBayDi,SanBayDen,NgayGio,ThoiGianBay,SLGheHang1,SLGheHang2,GiaVe) values('CB01','Nội Bài','tp HCM',12/12/2019,120,12,12,120000)
insert into TRUNGGIAN (MaTrungGian,MaCB,MaSanBay,ThoiGianDung,Ghichu) values('TG01','Cb01','1',12,'không')
select   distinct *
from CHUYENBAY CB join SANBAY SB on CB.SanBayDen=SB.MaSanBay

delete from CHUYENBAY where MaCB='CB03'
select * 
from TRUNGGIAN
select MaSanBay
from SANBAY
where TenSanBay='Sao vàng'
