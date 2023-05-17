create table PhongBan
(
	MaPhongBan nvarchar(50) not null primary key,
	TenPhongBan nvarchar(50) not null,
	DiaChi nvarchar(30) not null,
	SoDienThoai nvarchar(20) not null,
	Email nvarchar(20),
)

create table NhanVien
(
	MaNhanVien nvarchar(50) not null primary key,
	TenNhanVien nvarchar(50) not null,
	MaPhongBan nvarchar(50) foreign key references PhongBan(MaPhongBan),
	NgaySinh nvarchar(30) not null,
	DiaChi nvarchar(30) not null,
	SoDienThoai nvarchar(20),
)

insert into PhongBan values('123',N'Kinh Doanh',N'TP HCM','0812591361',N'kinhdoanh@gmail.com')
insert into PhongBan values('234',N'Marketing',N'TP HCM','0375649214',N'mkt@gmail.com')
insert into PhongBan values('345',N'Tuyen Dung',N'TP HCM','0864424895',N'hr@gmail.com')
insert into PhongBan values('456',N'Ky Thuat',N'TP HCM','0946783451',N'kythuat@gmail.com')
insert into PhongBan values('567',N'Tai Chinh Ke Toan',N'TP HCM','0893456789',N'tckt@gmail.com')


insert into NhanVien values('NV01',N'Nguyen Van A','123','15/05/1996',N'Ha Noi','0345216789')
insert into NhanVien values('NV02',N'Tran Van B','123','5/03/1992',N'Ha Noi','0345216745')
insert into NhanVien values('NV03',N'Ho Van C','123','02/07/1989',N'Ha Noi','0345216756')
insert into NhanVien values('NV04',N'Le Thi D','123','24/06/1990',N'Ha Noi','0345216776')
insert into NhanVien values('NV05',N'Dao Thi E','123','01/08/2000',N'Ha Noi','0345216775')