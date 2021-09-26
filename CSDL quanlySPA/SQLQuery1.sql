--tao CSDL ten la "quanlySPA"
-- code duoi day --

---------hien_san
CREATE TABLE KHACHHANG(
	MAKH NVARCHAR(100),
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH INT NOT NULL,
	NAMSINH DATE NOT NULL,
	TUOI INT,
	QUEQUAN NVARCHAR(100) NOT NULL,
	QUOCTICH NVARCHAR(100),
	DOITUONG NVARCHAR(100),
	DIENTHOAI INT NOT NULL,
	PRIMARY KEY (MAKH)
)
CREATE TABLE LIEUTRINH(
	MALT NVARCHAR(100),
	TENLT NVARCHAR(100),
	THOIGIANDT INT,
	GIATIEN INT,
	PRIMARY KEY (MALT)
)
CREATE TABLE CTDT(
	MABS NVARCHAR(100),
	MAKH NVARCHAR(100),
	MALT NVARCHAR(100),
	TIENTRINH INT,
	PHANTRAMDT INT,
	DATHANHTOAN INT,
	PRIMARY KEY (MABS,MAKH,MALT)
)
----Viz
CREATE TABLE HOADON(
    SOHD INT,
	MAKH NVARCHAR(100),
	TONGTIEN INT,
	PRIMARY KEY (SOHD,MAKH)
)
CREATE TABLE CTHD(
    SOHD INT,
	MAMP NVARCHAR(100),
	THANHTIENMP INT,
	SOLUONG INT,
	PRIMARY KEY (SOHD,MAMP)
)
CREATE TABLE QLBS(
    MABS NVARCHAR(100),
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH INT NOT NULL,
	CHUCVU NVARCHAR(100) NOT NULL,
	CHUYENMON NVARCHAR(100) NOT NULL,
	QUEQUAN NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	SDT INT NOT NULL,
	HESOLUONG INT,
	NBDHD DATE NOT NULL,
	NKTHD DATE NOT NULL,
	PRIMARY KEY (MABS)
)
<<<<<<< HEAD
-----Bach san
-----Nhan san
=======
<<<<<<< HEAD
-----Bekz
CREATE TABLE QLNV(
	MANV NVARCHAR(100),
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH INT NOT NULL,
	NHIEMVU NVARCHAR(100) NOT NULL,
	QUEQUAN NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	SDT INT NOT NULL,
	HESOLUONG INT, 
	NBDHD DATE NOT NULL,
	NKTHD DATE NOT NULL,
	PRIMARY KEY (MANV),
)
CREATE TABLE MYPHAM(
	MAMP NVARCHAR(100),
	TENMP NVARCHAR(100) NOT NULL,
	CHUNGLOAI NVARCHAR(100) NOT NULL,
	HAMLUONG INT NOT NULL,
	SOLUONGTONKHO INT NOT NULL,
	GIABAN INT NOT NULL, 
	PRIMARY KEY (MAMP),
)
CREATE TABLE QLNCC(
	MANCC NVARCHAR(100) NOT NULL,
	TENNCC NVARCHAR(100) NOT NULL,
	DIENTHOAI INT NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	PRIMARY KEY (MANCC),
)



=======
-----Nhan
CREATE TABLE LUONGBS(
	MABS NVARCHAR(100),
	MATT NVARCHAR(100),
	NGAYTT DATE NOT NULL,
	TIENLUONG INT,
	TIENTHUONG INT,
	TONGTIEN INT,
	PRIMARY KEY (MABS)
)

CREATE TABLE LUONGNV(
	MANV NVARCHAR(100),
	MATT NVARCHAR(100),
	NGAYTT DATE NOT NULL,
	TIENLUONG INT,
	TIENTHUONG INT,
	TONGTIEN INT,
	PRIMARY KEY (MANV)
)

CREATE TABLE NHAPTB(
	MATB NVARCHAR(100),
	MANCC NVARCHAR(100),
	DONGIA INT,
	NGAYNHAP DATE NOT NULL,
	NSX DATE NOT NULL,
	SLNHAP INT,
	DTV INT NOT NULL,
	THANHTIENDH INT,
	MANV NVARCHAR(100),
	PRIMARY KEY (MATB)
)

CREATE TABLE NHAPMP(
	MAMP NVARCHAR(100),
	MANCC NVARCHAR(100),
	NGAYGIAO DATE NOT NULL,
	DONGIA INT,
	NGAYNHAP DATE NOT NULL,
	SLNHAP INT,
	THANHTIENDH INT,
	MADH NVARCHAR(100),
	DTV INT NOT NULL,
	MANV NVARCHAR(100),
	PRIMARY KEY (MAMP)
)
>>>>>>> 9e2a97540b0d91f6493578a036bd377aee2dde37
>>>>>>> 69297c4be4c151d14f8b8c2f679a9c383e0903e3
