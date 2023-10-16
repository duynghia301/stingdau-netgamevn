CREATE DATABASE quanlynet 
go
CREATE TABLE  users (
	
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY ,
    ten_dang_nhap VARCHAR(50) NOT NULL,
    mat_khau VARCHAR(50) NOT NULL,
     so_dien_thoai varchar(20) , 
	ho_ten VARCHAR(100) NOT NULL,
	naptien float not null default 0			
    
    
)
CREATE TABLE MayTinh (
    id INT PRIMARY KEY,
    ten_may VARCHAR(50) NOT NULL,
    trang_thai VARCHAR(20) NOT NULL,
);

CREATE TABLE MoMay (
    id INT PRIMARY KEY,
    may_tinh_id INT NOT NULL,
    time_mo TIME NOT NULL,
    FOREIGN KEY (may_tinh_id) REFERENCES MayTinh(id)
);

