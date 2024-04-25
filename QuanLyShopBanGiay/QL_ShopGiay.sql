create database QL_ShopGiay
go
use Ql_ShopGiay
go

create table PhanQuyen
(
MaQuyen nchar(2) primary key,
TenQuyen nvarchar(10)
)
go
create table NhanVien
(
MaNV nchar(5) primary key,
HoTen nvarchar(30),
GioiTinh nchar(3),
DiaChi nvarchar(30),
NgaySinh datetime,
SDT nchar(10),
MaQuyen nchar(2) references PhanQuyen(MaQuyen)
)
go
create table HangHoa
(
MaHang nchar(5) primary key,
TenHang nvarchar(30),
MauSac nvarchar(10),
Size nchar(2),
ThuongHieu nvarchar(20),
GiaBan nchar(100),
GiaGoc nchar(100),
SoLuong int
)
go
create table QL_TaiKhoan
(
TaiKhoan nchar(20),
MatKhau nchar(20),
MaNV nchar(5) references NhanVien(MaNV),
MaQuyen nchar(2) references PhanQuyen(MaQuyen),
TrangThai nvarchar(10)
)
go
create table KhachHang
(
MaKH nchar(5) primary key,
SDT nchar(10),
Ten nvarchar(30)
)
go
create table HoaDon
(
MaHD nchar(5),
MaNV nchar(5) references NhanVien(MaNV),
TenKH nvarchar(30),
SDT nchar(10),
MaHang nchar(5) references HangHoa(MaHang),
TenHang nvarchar(30),
SoLuong int,
ThanhTien nchar(100),
NgayLap datetime
)
go

set dateformat dmy

insert into PhanQuyen values	('Q1',N'Quản trị'),
								('Q2',N'Quản lý'),
								('Q3',N'Nhân viên')
insert into NhanVien values	('NV001',N'Bui Phuc Thinh',N'Nam',N'TP Đà Lạt',11/09/2003,'0987654321','Q1')								
insert into QL_TaiKhoan values	('phucthinh','123','NV001','Q1',N'Hoạt động')
						

------------------------------------------------------------------------------------------------------
create function SinhMaKH() returns nchar(5)
as
begin
	declare @MaxMaKH char(5)
	declare @NewMaKH varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokyso	int
if exists(select * from KhachHang)
begin
select @MaxMaKH = max(MaKH) 
		from KhachHang
		set @stt=convert(int, right(@MaxMaKH,3)) + 1
		end
		else
		set @stt= 1
		set @sokyso = len(convert(varchar(3), @stt))
	set @NewMaKH='KH'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMaKH = @NewMaKH + '0'
			set @i = @i + 1
		end	
	set @NewMaKH = @NewMaKH + convert(varchar(3), @stt)

return @NewMaKH
End
CREATE PROC ThemKH
@sdt nchar(10),@ten nvarchar(30)
As
	declare @maKH char(5)
	
 if not exists(select * from KhachHang 
				where SDT = @sdt and Ten = @ten)
	Begin
		
		--sinh mã cho giáo viên mới
		set @maKH = dbo.SinhMaKH()
		insert into KhachHang values(@maKH, @sdt, @ten)
	
	End
else
	print N'Lỗi!'
Go


create proc UpdateKH
@MaKH nchar(5),
@SDT nchar(10),
@Ten nvarchar(30)
as
	update KhachHang
set	
SDT=@SDT,
Ten=@Ten
where
	MaKH=@MaKH
	if @@ERROR<>0
return 0
else 
return 1
go
---------------------------------------------------------------------------------------------
create proc UpdateTK
@TaiKhoan nchar(20),
@MatKhau nchar(20),
@MaNV nchar(5),
@MaQuyen nchar(2),
@TrangThai nvarchar(10)
as 
	update QL_TaiKhoan
set 
	TaiKhoan=@TaiKhoan,
	MatKhau=@MatKhau,
	MaNV=@MaNV,
	MaQuyen=@MaQuyen,
	TrangThai=@TrangThai
where
	TaiKhoan=@TaiKhoan
	if @@ERROR<>0
return 0
else 
return 1
go

create proc UpdateNV
@MaNV nchar(5),
@HoTen nvarchar(30),
@GioiTinh nchar(3),
@DiaChi nvarchar(30),
@NgaySinh datetime,
@SDT nchar(10),
@MaQuyen nchar(2)
as 
	update NhanVien
set 
	HoTen=@HoTen,
	GioiTinh=@GioiTinh,
	DiaChi=@DiaChi,
	NgaySinh=@NgaySinh,
	SDT=@SDT,
	MaQuyen=@MaQuyen
where
	MaNV=@MaNV
	if @@ERROR<>0
return 0
else 
return 1
go
create proc UpdateHH
@MaHang nchar(5) ,
@TenHang nvarchar(30),
@MauSac nvarchar(10),
@Size nchar(2),
@ThuongHieu nvarchar(20),
@GiaBan nchar(100),
@GiaGoc nchar(100),
@SoLuong int

as
	update HangHoa
set
TenHang=@TenHang,
MauSac=@MauSac,
Size=@Size,
ThuongHieu=@ThuongHieu,
GiaBan=@GiaBan,
GiaGoc=@GiaGoc,
SoLuong=@SoLuong
where
	MaHang=@MaHang
	if @@ERROR<>0
return 0
else 
return 1
go

--------------------------------------------------------------------------------------
create function SinhMaHD_X() returns nchar(5)
as
begin
	declare @MaxMaHD char(5)
	declare @NewMaHD varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokyso	int
if exists(select * from KhachHang)
begin
select @MaxMaHD = max(MaKH) 
		from KhachHang
		set @stt=convert(int, right(@MaxMaHD,3)) + 1
		end
		else
		set @stt= 1
		set @sokyso = len(convert(varchar(3), @stt))
	set @NewMaHD='XH'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMaHD = @NewMaHD + '0'
			set @i = @i + 1
		end	
	set @NewMaHD = @NewMaHD + convert(varchar(3), @stt)

return @NewMaHD
End

CREATE PROC ThemHD_X

@MaNV nchar(5) ,
@TenKH nvarchar(30),
@SDT nchar(10),
@MaHang nchar(5) ,
@TenHang nvarchar(30),
@SoLuong int,
@ThanhTien nchar(100),
@NgayLap datetime
As
	declare @MaHD char(5)
	
 if not exists(select * from HoaDon  
				where MaNV=@MaNV and TenKH=@TenHang and SDT=@SDT and MaHang=@MaHang and TenHang=@TenHang and SoLuong=@SoLuong and ThanhTien=@ThanhTien and NgayLap=@NgayLap)
	Begin
		
		set @MaHD = dbo.SinhMaHD_X()
		insert into HoaDon values(@MaHD,@MaNV,@TenKH,@SDT,@MaHang,@TenHang,@SoLuong,@ThanhTien,@NgayLap)
	End
else
	print N'Lỗi!'
Go

CREATE FUNCTION SinhMaHD_N() RETURNS nchar(5)
AS
BEGIN
	DECLARE @MaxMaHD char(5)
	DECLARE @NewMaHD varchar(5)
	DECLARE @stt int
	DECLARE @i int	
	DECLARE @sokyso int

	IF EXISTS (SELECT * FROM KhachHang)
	BEGIN
		SELECT @MaxMaHD = MAX(MaKH) FROM KhachHang
		SET @stt = CONVERT(int, RIGHT(@MaxMaHD, 3)) + 1
	END
	ELSE
	BEGIN
		SET @stt = 1
	END

	SET @sokyso = LEN(CONVERT(varchar(3), @stt))
	SET @NewMaHD = 'NH'
	SET @i = 0

	WHILE @i < 3 - @sokyso
	BEGIN
		SET @NewMaHD = @NewMaHD + '0'
		SET @i = @i + 1
	END

	SET @NewMaHD = @NewMaHD + CONVERT(varchar(3), @stt)

	RETURN @NewMaHD
END


CREATE PROC ThemHD_X

@MaNV nchar(5) ,
@TenKH nvarchar(30),
@SDT nchar(10),
@MaHang nchar(5) ,
@TenHang nvarchar(30),
@SoLuong int,
@ThanhTien nchar(100),
@NgayLap datetime
As
	declare @MaHD char(5)
	
 if not exists(select * from HoaDon  
				where MaNV=@MaNV and TenKH=@TenHang and SDT=@SDT and MaHang=@MaHang and TenHang=@TenHang and SoLuong=@SoLuong and ThanhTien=@ThanhTien and NgayLap=@NgayLap)
	Begin
		
		set @MaHD = dbo.SinhMaHD_N()
		insert into HoaDon values(@MaHD,@MaNV,@TenKH,@SDT,@MaHang,@TenHang,@SoLuong,@ThanhTien,@NgayLap)
	End
else
	print N'Lỗi!'
Go
------------------------------------------------------------------

create procedure KiemTraTKMK
@Username nvarchar(20),
@Password nvarchar(20)
as
begin
    if exists (select * from QL_TaiKhoan where TaiKhoan = @Username and MatKhau = @Password and MaQuyen = 'Q1')
        select 1 as code
    else if exists (select * from QL_TaiKhoan where TaiKhoan = @Username and MatKhau = @Password and MaQuyen = 'Q2')
        select 2 as code
	else if exists (select * from QL_TaiKhoan where TaiKhoan = @Username and MatKhau = @Password and MaQuyen = 'Q3')
        select 3 as code
    else if exists(select * from QL_TaiKhoan where TaiKhoan = @Username and MatKhau != @Password) 
        select 0 as code
    else select 0 as code
end
select *from QL_TaiKhoan

create proc LayQuyenTheoTK
@Username nvarchar(20)
as
begin
	select MaQuyen  from QL_TaiKhoan where TaiKhoan=@Username;
end