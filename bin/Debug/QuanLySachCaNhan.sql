/*
	CƠ SỞ DỮ LIỆU CHO ỨNG DỤNG QUẢN LÝ SÁCH CÁ NHÂN
	NGƯỜI THỰC HIỆN: Nguyễn Tân Tiến
	NGÀY THỰC HIỆN: 18/05/2023
	NGÀY KẾT THÚC: ?
*/

create database CSDLQuanLySach

go
use CSDLQuanLySach
go

------XÂY DỰNG CÁC BẢNG DỮ LIỆU

--Bảng chủ đề
create table ChuDe
(
	MaCD char(5) primary key,
	TenCD nvarchar(500) not null
);



--Bảng sách
create table Sach
(
	MaSach char(5) primary key,
	TenSach nvarchar(500) not null,
	SoTrang int null,
	NamXB char(4) not null,
	ViTriSach nvarchar(300) null,
	TacGia nvarchar(500) not null,
	LinkHinh varchar(1000) null,
	MaCD char(5) references ChuDe(MaCD)
);


--Bảng bạn đọc
create table BanDoc 
(
	MaBD char(5) primary key,
	TenBD nvarchar(500) not null,
	SoDT nvarchar(15) null,
	DiaChi nvarchar(500) null
);


--Bảng mượn sách
create table MuonSach
(
	MaSach char(5) references Sach(MaSach),
	MaBD char(5) references BanDoc(MaBD),
	LoaiHinhMuon int not null, --Sách đi mượn là 0, sách cho mượn là 1
	NgayMuon datetime not null, 
	NgayTra datetime null,
	primary key(MaSach, MaBD, NgayMuon)
);


------THÊM DỮ LIỆU VÀO CÁC BẢNG


--Bảng chủ đề
insert into ChuDe values('CD001', N'Văn Học')
insert into ChuDe values('CD002', N'Kinh Tế')
insert into ChuDe values('CD003', N'Kỹ Năng Sống')
insert into ChuDe values('CD004', N'Giáo Khoa - Giáo Trình')
insert into ChuDe values('CD005', N'Học Ngoại Ngữ')
insert into ChuDe values('CD006', N'Công Nghệ Thông Tin')
insert into ChuDe values('CD007', N'Y Học')
insert into ChuDe values('CD008', N'Tâm Linh')

--Bảng sách
insert into Sach values('S0001', N'Nhà Giả Kim', 228, '2020', null, N'Paolo Coelho', null, 'CD001')
insert into Sach values('S0002', N'Nhà Thờ Đức Bà Paris', 692, '2019', null, N'Victor Hugo',  null, 'CD001')
insert into Sach values('S0003', N'Từ Tốt Đến Vĩ Đại', 484, '2021', null, N'Jim Collins', null,  'CD002')
insert into Sach values('S0004', N'9 Lần Khởi Nghiệp', 260, '2021', null, N'Nguyễn Phương Nam', null,  'CD002')
insert into Sach values('S0005', N'Không Sinh Không Diệt Đừng Sợ Hãi', 224, '2022', null, N'Thích Nhất Hạnh', null,  'CD003')
insert into Sach values('S0006', N'Thao Túng Tâm Lý', 328, '2022', null, N'Shannon Thomas', null,  'CD003')
insert into Sach values('S0007', N'Giáo Trình Lịch Sử Đảng Cộng Sản Việt Nam', 440, '2021', null, N'Bộ Giáo Dục Và Đào Tạo',  null, 'CD004')
insert into Sach values('S0008', N'Giáo Trình Triết Học Mác - Lênin', 496, '2021', null, N'Bộ Giáo Dục Và Đào Tạo',  null, 'CD004')
insert into Sach values('S0009', N'Tiếng Anh Cho Người Bắt Đầu', 466, '2021', null, N'Trang Anh - Minh Trang', null,  'CD005')
insert into Sach values('S0010', N'Giải Thích Ngữ Pháp Tiếng Anh', 560, '2022', null, N'Mai Lan Hương - Hà Thanh Uyên', null,  'CD005')
insert into Sach values('S0011', N'Python Cơ Bản', 253, '2020', null, N'Bùi Việt Hà', null,  'CD006')
insert into Sach values('S0012', N'Python Nâng Cao', 354, '2023', null, N'Bùi Việt Hà', null,  'CD006')
insert into Sach values('S0013', N'Lưu Thông Máu Tốt Hóa Giải Bách Bệnh', null, '2021', null, N'Akiyoshi Horie',  null, 'CD007')
insert into Sach values('S0014', N'Làm Sạch Mạch Và Máu', 247, '2021', null, N'Nishi Katsuzo', null,  'CD007')
insert into Sach values('S0015', N'Kinh Thánh Tân Ước', 680, '2022', null, N'Nguyễn Thế Thuần - Dịch',  null, 'CD008')

delete from Sach where MaSach = 'S0013'
select * from Sach
--Bảng Bạn đọc
insert into BanDoc values('BD001', N'Nguyễn Tân Tiến', '0358358306', N'Lạc Lâm - Đơn Dương - Lâm Đồng')
insert into BanDoc values('BD002', N'Nguyễn Xuân Tường An', null, N'Trại Mát - Đà Lạt')
insert into BanDoc values('BD003', N'Nguyễn Bảo Khanh', '0914148263', N'Xô Viết Nghệ Tĩnh - Đà Lạt')
insert into BanDoc values('BD004', N'Nguyễn Hoàng Bảo Long', null, N'Xô Viết Nghệ Tĩnh - Đà Lạt')
select * from BanDoc
--Bảng mượn sách
set dateformat dmy
insert into MuonSach values('S0002', 'BD003', 1, '10/05/2023', null)
insert into MuonSach values('S0005', 'BD003', 1, '10/05/2023', null)
insert into MuonSach values('S0004', 'BD002', 1, '10/05/2023', '15/05/2023')
insert into MuonSach values('S0007', 'BD002', 0, '14/05/2023', null)
insert into MuonSach values('S0011', 'BD001', 0, '11/05/2023', '18/05/2023')
insert into MuonSach values('S0010', 'BD004', 1, '09/05/2023', null)
insert into MuonSach values('S0008', 'BD001', 1, '09/05/2023', '22/05/2023')
insert into MuonSach values('S0008', 'BD003', 1, '23/05/2023', null)

select * from MuonSach


------RÀNG BUỘC TOÀN VẸN

go
create trigger trg_MuonSach_ins_upd
on MuonSach for insert, update
as
if update(NgayMuon) or update(NgayTra) or update(MaSach)
begin
	--Ngày mượn phải trước ngày trả sách
	if exists(select * from inserted where inserted.NgayMuon > inserted.NgayTra)
		begin
			raiserror(N'Date error', 15, 1);
			rollback tran
		end
	--Đối với sách cho mượn thì chỉ cho mượn được khi sách đó đang không có ai mượn (Xử lý ở NNLT)

end
go


go
create trigger trg_Sach_ins_upd
on Sach for insert, update
as
begin
	if exists(select * from inserted where inserted.SoTrang = 0)
		begin
			raiserror(N'Page Number error', 15, 1)
			rollback tran
		end
end
go


------HÀM SINH MÃ TỰ ĐỘNG
go
create function fn_SinhMa(@maDau varchar(20))
returns varchar(1000)
as
begin
	declare @sttToiDa int
	declare @kq varchar(500)
	declare @soCanThem int
	set @sttToiDa = 0
	set @soCanThem = 0
	if (@maDau = 'CD')
		begin
			set @sttToiDa = (select right(ChuDe.MaCD, len(ChuDe.MaCD) - 2)
							 from ChuDe
							 group by right(ChuDe.MaCD, len(ChuDe.MaCD) - 2)
							 having right(ChuDe.MaCD, len(ChuDe.MaCD) - 2) >= all(select right(ChuDe.MaCD, len(ChuDe.MaCD) - 2)
							 from ChuDe))
			set @sttToiDa += 1
		end
	if (@maDau = 'S')
		begin
			set @sttToiDa = (select right(Sach.MaSach, len(Sach.MaSach) - 1)
							 from Sach
							 group by right(Sach.MaSach, len(Sach.MaSach) - 1)
							 having right(Sach.MaSach, len(Sach.MaSach) - 1) >= all(select right(Sach.MaSach, len(Sach.MaSach) - 1)
							 from Sach))
			set @sttToiDa += 1
		end
	if (@maDau = 'BD')
		begin
			set @sttToiDa = (select right(BanDoc.MaBD, len(BanDoc.MaBD) - 2)
							 from BanDoc
							 group by right(BanDoc.MaBD, len(BanDoc.MaBD) - 2)
							 having right(BanDoc.MaBD, len(BanDoc.MaBD) - 2) >= all(select right(BanDoc.MaBD, len(BanDoc.MaBD) - 2)
							 from BanDoc))
			set @sttToiDa += 1
		end
	begin
		set @kq = @maDau + convert(varchar, @sttToiDa) --Đây là kết quả chưa được kiểm tra
		if (len(@kq) < 5)
			begin
				set @soCanThem = 5 - len(@kq)
			end
		while @soCanThem >= 1
			begin
				set @maDau += '0'
				set @soCanThem -= 1
			end
		set @kq = upper(@maDau) + convert(varchar, @sttToiDa) --Đây là kết quả chính thức
	end
	return @kq
end
go

go
create function fn_LinkHinh(@tenHinh varchar(500))
returns varcchar(1000)
as
begin
	return ''
end
go



------THỦ TỤC THÊM DỮ LIỆU
--thêm bảng sách
go
create proc usp_ThemBangSach
@tenSach nvarchar(500),
@soTrang int,
@namXB char(4),
@viTriSach nvarchar(300),
@tacGia nvarchar(500),
@tenHinh varchar(500),
@maCD char(5)
as
begin
	declare @maSach char(5)
	declare @linkHinh varchar(1000)
	set @maSach = dbo.fn_SinhMa('S')
	set @linkHinh = dbo.fn_LinkHinh(@tenHinh)
	insert into Sach values(@maSach, @tenSach, @soTrang, @namXB, @viTriSach, @tacGia, @linkHinh ,@maCD)
end
go


exec usp_ThemBangSach N'Hiểu về trái tim', 480, '2019', null, N'Minh Niệm', 'CD003'
select * from Sach

--thêm bảng chủ đề
go
create proc usp_ThemBangChuDe
@tenCD nvarchar(500)
as
begin
	declare @maCD char(5)
	set @maCD = dbo.fn_SinhMa('CD')
	insert into ChuDe values(@maCD, @tenCD)
end
go

exec usp_ThemBangChuDe N'Tâm lý - Giới tính'
select * from ChuDe



--thêm bảng bạn đọc
go
create proc usp_ThemBangBanDoc
@tenBD nvarchar(500),
@soDT nvarchar(15),
@diaChi nvarchar(500)
as
begin
	declare @maBD char(5)
	set @maBD = dbo.fn_SinhMa('BD')
	insert into BanDoc values(@maBD, @tenBD, @soDT, @diaChi)
end
go

exec usp_ThemBangBanDoc N'Cristiano Ronaldo', null, N'Mandeira - Portugal'
select * from BanDoc

--thêm bảng mượn sách
go
create proc usp_ThemBangMuonSach
@maSach char(5),
@maBD char(5),
@loaiHinhMuon int,
@ngayMuon datetime,
@ngayTra datetime
as
begin
	insert into MuonSach values(@maSach, @maBD, @loaiHinhMuon, @ngayMuon, @ngayTra)
end
go




------VIẾT THỦ TỤC TRUY VẤN
--Liệt kê danh mục sách theo từng chủ đề
go
create proc usp_SachTheoChuDe
@tenCD nvarchar(500)
as
begin
	select Sach.*
	from Sach, ChuDe
	where Sach.MaCD = ChuDe.MaCD and ChuDe.TenCD = @tenCD
end
go

--Liệt kê danh mục sách theo thứ tự từ điển
go
create proc usp_SachTheoThuTu
as
begin
	select * 
	from Sach
	order by Sach.TenSach asc
end
go



