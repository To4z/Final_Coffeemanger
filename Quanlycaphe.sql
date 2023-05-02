use master
go
if exists (select * from sysdatabases where name='QuanLyCoffeOngBau')
	drop database QuanLyCoffeOngBau
go
create database QuanLyCoffeOngBau
go

use QuanLyCoffeOngBau
go

create table nhanvien(
	sdt varchar(50) primary key,
	ten_nv nvarchar(100),
	gioitinh bit,
	chucvu nvarchar(50),
	diachi nvarchar(100),
	phanquyen bit,
	ngayvaolam date,
	matkhau varchar(100)
)

insert into nhanvien values('222', N'thanh', 1, N'Quan ly', N'Ha noi', 1, '01/01/2021', '222');
insert into nhanvien values('333', N'thanh', 0, N'NhanVien', N'Ha noi', 0, '01/01/2021', '222');


create table khachhang(
	sdt varchar(50) primary key,
	ten_kh nvarchar(100),
	diemtl int,
	matkhau varchar(50),
)

create table khuvuc (
	makhuvuc varchar(100) primary key,
	tenkhuvuc nvarchar(100),
	trangthai varchar(100)
)

create table ban(
	maban varchar(100) primary key,
	tenban nvarchar(100),
	makhuvuc varchar(100),
	trangthai varchar(100),
	FOREIGN KEY (makhuvuc) REFERENCES khuvuc(makhuvuc)
)

create table nhacungcap(
	sdt varchar(100) primary key,
	ten_nhacungcap nvarchar(100),
	diachi nvarchar(100)
)

create table loaihanghoa(
ma_loaihoang varchar(100) primary key,
tenloaihang nvarchar(100),
mota nvarchar(254)
)

create table hanghoa(
	ma_hanghoa varchar(100) primary key,
	ten_hanghoa nvarchar(100),
	ma_loaihoang varchar(100),
	hinh_anh varchar(254),
	sdt_ncc varchar(100) ,
	soluong int,
	giasp int,
	FOREIGN KEY (ma_loaihoang) REFERENCES loaihanghoa(ma_loaihoang),
	FOREIGN KEY (sdt_ncc) REFERENCES nhacungcap(sdt)
)

create table  calamviec(
	ma_clv varchar(50) primary key,
	ten_clv nvarchar(100),
	gio_BD int,
	gio_kt int,
	sotien int
)

create table hoadonbanhang(
	ma_hd_bh varchar(50) primary key,
	sdt_nv varchar(50),
	sdt_kh varchar(50),
	maban varchar(100),
	ngay_hd_bh_check_in date,
	tongtien int,
	diemtl int,
	giagiam int,
	trangthai bit,
	FOREIGN KEY (sdt_nv) REFERENCES nhanvien(sdt),
	FOREIGN KEY (maban) REFERENCES ban(maban),
	FOREIGN KEY (sdt_kh) REFERENCES khachhang(sdt)
)

create table chitietbanhang(
	ma_hd_bh varchar(50),
	ma_hanghoa varchar(100),
	soluong int default 0,
	thanhtien int default 0,
	primary key(ma_hd_bh,ma_hanghoa),
	FOREIGN KEY (ma_hd_bh) REFERENCES hoadonbanhang(ma_hd_bh),
	FOREIGN KEY (ma_hanghoa) REFERENCES hanghoa(ma_hanghoa)
)

create table chitietluongnhanvien (
	ma_clv varchar(50),
	sdt_nv varchar(50),
	tongcalamtrongthang int,
	thanhtien int,
	primary key (ma_clv, sdt_nv),
	FOREIGN KEY (ma_clv) REFERENCES calamviec(ma_clv),
	FOREIGN KEY (sdt_nv) REFERENCES nhanvien(sdt)
	
)



create table hoadonnhaphang(
	ma_hd_nh varchar(50) primary key,
	sdt_nv varchar(50),
	sdt_ncc varchar(50),
	ngayhdnh date,
	thanhtien int
)

create table chitietnhaphanghoa(
	ma_hd_nh varchar(50),
	ma_hanghoa varchar(100),
	soluong int,
	thanhtien int
	primary key(ma_hd_nh,ma_hanghoa),
	FOREIGN KEY (ma_hd_nh) REFERENCES hoadonnhaphang(ma_hd_nh),
	FOREIGN KEY (ma_hanghoa) REFERENCES hanghoa(ma_hanghoa)
)

go

ALTER TABLE chitietbanhang
ADD trangthai varchar(255);

ALTER TABLE chitietbanhang
ADD ngaygiao varchar(255);

ALTER TABLE chitietbanhang
ADD giogiao	 varchar(255);

ALTER TABLE chitietbanhang
ADD diachi	 varchar(255);

ALTER TABLE chitietbanhang
ADD sodienthoai varchar(255);


go

CREATE PROCEDURE usp_Login_KHACHHANG
(
@sdt NVARCHAR(50),  @pass NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  *
FROM khachhang
WHERE sdt=@sdt AND matkhau=@pass
end

go




CREATE PROCEDURE usp_Login_NhanVien
(
@sdt NVARCHAR(50),  @pass NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  *
FROM nhanvien
WHERE sdt=@sdt AND matkhau=@pass
end

select * from Khachhang
select * from loaikhachhang
exec usp_Login_KHACHHANG @sdt = '123', @pass = '123'
go

CREATE PROCEDURE insert_khachhang
(
	 @p_sdt VARCHAR(50),
     @p_ten_kh NVARCHAR(100),
     @p_diemtl INT,
     @p_password VARCHAR(50)
)
AS
BEGIN
	if exists ( SELECT * FROM khachhang WHERE sdt = @p_sdt)
	BEGIN
		select 'failed' stt
	end
	else
	begin
		INSERT INTO khachhang (sdt, ten_kh, diemtl, matkhau)
		VALUES (@p_sdt, @p_ten_kh, @p_diemtl, @p_password);
		select 'done' stt
	end
end

go

ALTER TABLE hoadonbanhang
ALTER COLUMN trangthai varchar(50)

insert into nhacungcap values('03862', N'XỊN XỊN', N'Hà Nội')


insert into loaihanghoa
values(N'DU', N'Đồ Uống', N'No')
insert into loaihanghoa
values(N'MA', N'Món Ăn', N'No')


insert into hanghoa
values('MA1', N'Bana Chips vị bạch tuộc cay 48g (ăn vặt)', 'MA', 'https://vn-live-01.slatic.net/p/465b3f68921073c753a09d5a9465a505.png', '03862', 10, 16000)
insert into hanghoa
values('MA2', N'Bana Chips vị bò BBQ 48g (ăn vặt)', 'MA', 'https://cdn.tgdd.vn/Files/2022/11/01/1482590/moi-la-snack-chuoi-gia-vi-man-dau-tien-tai-viet-nam-tu-bana-chips-202211011056121831.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA3', N'Bana Chips vị rong biển 48g (ăn vặt)', 'MA', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWLsCGkNjk-uzYaSGocNetHG9g7r1Q1Vz2p7ji3M-0IpaCovi4RpxnmDMpF7zyeLXmNpo&usqp=CAU', '03862', 10, 16000)
insert into hanghoa
values('MA4', N'Bana Chips vị tỏi ớt 48g (ăn vặt)', 'MA', 'https://cf.shopee.vn/file/sg-11134201-22090-1gf22slcmthv72', '03862', 10, 16000)
insert into hanghoa
values('MA5', N'Da cá sấy cháy giòn vị trứng muối (ăn vặt)', 'MA', 'https://salt.tikicdn.com/cache/w1200/ts/product/b2/63/66/78904a7096aa31702eff3f010d405f64.jpg', '03862', 10, 30000)
insert into hanghoa
values('MA6', N'Hạt hướng dương nguyên vị (ăn vặt)', 'MA', 'https://sg-live-01.slatic.net/p/a9daf4d15a1f0d9b8ebaffa1da062b1c.jpg', '03862', 10, 15000)
insert into hanghoa
values('MA7', N'Kho gà lá chanh (ăn vặt)', 'MA', 'https://cf.shopee.vn/file/04764c583278baaf44e715bd6f8f72fd', '03862', 10, 22000)

insert into hanghoa
values('MA8', N'Kho heo lá chanh (ăn vặt)', 'MA', 'https://kinhtechungkhoan.vn/stores/news_dataimages/thuydung/052022/18/14/2239_heo_bapi.jpg?rt=20220518142242', '03862', 10, 22000)

insert into hanghoa
values('MA10', N'Hạt dưa lá chanh (ăn vặt)', 'MA', 'https://tvphapluat.vn/upload/news/2022/04/04/tphcm-xu-phat-3-co-so-tieu-thu-thit-heo-ban-buoc-tieu-huy-hon-900kg-thit-thumbnail-597482.jpg', '03862', 10, 22000)

insert into hanghoa
values('MA9', N'Bắp rang bơ lá chanh (ăn vặt)', 'MA', 'https://99poultry.com/vnt_upload/product/08_2022/thumbs/870_ga_Chip.png', '03862', 10, 22000)

insert into hanghoa
values('MA11', N'Gà rán (ăn chính)', 'MA', 'https://cdn.fast.vn/tmp/20200919120948-ga-chip-99-poultry-goi-500g-6.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA12', N'Hamgerger (ăn chính)', 'MA', 'https://www.verywellfit.com/thmb/qRY50wrwj5bf9sGENpGQAPmMrR4=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/banana-chips_annotated2-76d563db5db6406ab8c05846e624ebdf.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA13', N'Mì ý (ăn chính)', 'MA', 'https://images.foody.vn/res/g100005/1000044297/s800/foody-chip-chip-banh-uot-long-ga-banh-can-tang-bat-ho.fbybg0-260-637943727805880206.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA14', N'Mì tôm (ăn chính)', 'MA', 'https://www.google.com/url?sa=i&url=https%3A%2F%2Ffast.vn%2Fsan-pham%2Fga-chip-99-poultry-goi-500g-22051.html&psig=AOvVaw3TnMT66rX3cMiZtBN1fhtv&ust=1679124235154000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCNDO2a634v0CFQAAAAAdAAAAABBG', '03862', 10, 16000)
insert into hanghoa
values('MA15', N'Bò mỹ(ăn chính)', 'MA', 'https://rukminim1.flixcart.com/image/416/416/kltryq80/fmcg-combo/n/q/l/yellow-banana-chips-and-bhavnagri-gathiya-combo-chheda-s-original-imagyv87ysmx6udb.jpeg?q=70', '03862', 10, 30000)

insert into hanghoa
values('MA1211', N'Xoài (Hoa quả)', 'MA', 'https://i1-suckhoe.vnecdn.net/2022/12/18/fruits-1729-1671358576.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=SNhg9o6v9bznTlpkm3cR7w', '03862', 10, 16000)
insert into hanghoa
values('MA1212', N'Cóc (Hoa quả)', 'MA', 'https://www.btaskee.com/wp-content/uploads/2020/10/meo-chon-mua-trai-cay-tuoi-ngon.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA1213', N'Mận (Hoa quả)', 'MA', 'https://physalisvn.com/uploads/blog/2021_05/c034e02077c1829fdbd0.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA134', N'Ổi (Hoa quả)', 'MA', 'https://images2.thanhnien.vn/Uploaded/ngocthanh/2022_04_10/rau-2229.jpg', '03862', 10, 16000)
insert into hanghoa
values('MA145', N'Táo (Hoa quả)', 'MA', 'https://tiengiang.gov.vn/documents/1058688/7027032//1058688_7027032_144749_18012019.jpg', '03862', 10, 30000)


insert into hanghoa
values('DU1', N'Bạc xỉu (Cà phê)', 'DU', 'https://suckhoedoisong.qltns.mediacdn.vn/324455921873985536/2022/8/18/ca-phe-16607581080101863582923.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU2', N'Cà phê đen', 'DU', 'https://suckhoedoisong.qltns.mediacdn.vn/zoom/600_315/Images/duylinh/2018/04/27/ca-phe-loi-hay-hai-cho-suc-khoe1524762701.jpg', '03862', 10, 22000)
insert into hanghoa
values('DU3', N'Cà phê phin', 'DU', 'https://cdn.dayphache.edu.vn/wp-content/uploads/2019/05/ca-phe-re-nhat-bang-xep-hang.jpg', '03862', 10, 22000)
insert into hanghoa
values('DU4', N'Cà phê sữa', 'DU', 'https://caphenguyenchat.vn/wp-content/uploads/2018/03/bi-quyet-pha-ca-phe-ngon-10-ly-nhu-1-5.jpg', '03862', 10, 24000)
insert into hanghoa
values('DU5', N'Cà phê sữa phin', 'DU', 'https://vuicoffee.com/wp-content/uploads/2019/09/ca-phe-nguyen-chat-bao-nhieu-tien-1kg-2.png', '03862', 10, 24000)
insert into hanghoa
values('DU6', N'Cà phê trứng đá', 'DU', 'https://www.puncoffee.com/wp-content/uploads/2022/05/c%C3%A0-ph%C3%AA-s%E1%BB%AFa-%C4%91%C3%A1-Vi%E1%BB%87t-Nam-1024x800.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU7', N'Cà phê trứng nóng', 'DU', 'https://icdn.dantri.com.vn/thumb_w/770/2022/05/11/gia-ca-phe-hom-nay-2-11-1652275990962.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU8', N'Capuchino (Cà phê)', 'DU', 'https://domingocoffee.com.vn/wp-content/uploads/2021/06/tim-hieu-ve-ca-phe-1.jpg', '03862', 10, 35000)



insert into hanghoa
values('DU911', N'Trà sữa', 'DU', 'https://icdn.dantri.com.vn/thumb_w/640/2018/8/17/photo-2-15344660253391589797590.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU1011', N'Trà gừng', 'DU', 'https://cdn.dayphache.edu.vn/wp-content/uploads/2020/02/mon-tra-sua-tran-chau.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU2911', N'Trà đào', 'DU', 'http://cdn.tgdd.vn/Files/2021/12/13/1404245/huong-dan-cach-lam-tra-sua-don-gian-tai-nha-202112132320474492.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU1201122', N'Trà vải', 'DU', 'https://images2.thanhnien.vn/Uploaded/congson/2022_03_15/anh-1-tra-sua-tran-chau-boba-milk-tea-pho-bien-nhieu-noi-tren-the-gioi-dac-biet-la-nuoc-my-noi-cong-dong-nguoi-my-goc-a-goi-la-boba-milk-tea-anh-kowloon-house-ph-2127.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU12011', N'Trà nho', 'DU', 'https://mccoffeetanphu.com/uploads/source/mccoffee/b45-3-min.jpg', '03862', 10, 35000)


insert into hanghoa
values('DU9522', N'Latte nghệ', 'DU', 'https://www.starbucksathome.com/it/sites/default/files/2021-06/10032021_LATTE_MACCHIATO_LS-min_0.png', '03862', 10, 35000)
insert into hanghoa
values('DU10522', N'Latte nghệ mật ong', 'DU', 'https://bakingmischief.com/wp-content/uploads/2019/10/easy-caramel-latte-image-square-500x500.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU29522', N'Latte mật ong', 'DU', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRX3wJc96LPRNPyzcDDutk8a7caF4NiXmqoBw&usqp=CAU', '03862', 10, 35000)
insert into hanghoa
values('DU1205222', N'Latte cacao', 'DU', 'https://athome.starbucks.com/sites/default/files/2022-04/CAH_ClassicLatte_Hero_0.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU120522', N'Latte đậu xanh', 'DU', 'https://sainthonore.com.vn/media/product/2021/05//17369_1620976860.jpg', '03862', 10, 35000)


insert into hanghoa
values('DU9122', N'Trà sữa (đóng chai)', 'DU', 'https://cdn.tgdd.vn/Products/Images/2443/76446/bhx/nuoc-ngot-7-up-vi-chanh-330ml-201905301056152288.JPG', '03862', 10, 35000)
insert into hanghoa
values('DU10221', N'Cocacola (đóng chai)', 'DU', 'https://cdn.tgdd.vn/Products/Images/2443/76446/bhx/nuoc-ngot-7-up-vi-chanh-330ml-201905301056152288.JPG', '03862', 10, 35000)
insert into hanghoa
values('DU29122', N'Stinh (đóng chai)', 'DU', 'https://cdn.tgdd.vn/Products/Images/2443/76446/bhx/nuoc-ngot-7-up-vi-chanh-330ml-201905301056152288.JPG', '03862', 10, 35000)
insert into hanghoa
values('DU1201224', N'7Up (đóng chai)', 'DU', 'https://cdn.tgdd.vn/Products/Images/2443/76446/bhx/nuoc-ngot-7-up-vi-chanh-330ml-201905301056152288.JPG', '03862', 10, 35000)
insert into hanghoa
values('DU120122', N'Nước suối (đóng chai)', 'DU', 'https://toana.vn/admin/uploads/cac-loai-nuoc-uong-dong-chai.webp', '03862', 10, 35000)


insert into hanghoa
values('DU92232', N'Sữa chua truyền thống', 'DU', 'https://cdn.tgdd.vn/2021/08/CookRecipe/Avatar/sua-chua-yaourt-thumbnail.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU102232', N'Sữa chua đậu xanh', 'DU', 'https://product.hstatic.net/1000074072/product/khong_duong_vi_beed92730ace45af9dd98aa5c9f105cd_master.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU292223', N'Sữa chua trân châu', 'DU', 'https://cdn.dayphache.edu.vn/wp-content/uploads/2019/05/hinh-sua-chua-khong-dong-da.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU12023311', N'Sữa chua mật', 'DU', 'https://smoothiedays.com/wp-content/uploads/2020/08/cach-lam-sua-chua-danh-da.png', '03862', 10, 35000)
insert into hanghoa
values('DU12023', N'Sữa chua nho', 'DU', 'https://smoothiedays.com/wp-content/uploads/2020/08/cach-lam-sua-chua-danh-da.png', '03862', 10, 35000)

insert into hanghoa
values('DU9233', N'Soda kiwi', 'DU', 'http://file.hstatic.net/1000394081/article/soda_824b8f9a8a744318bcb3980a5708e580.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU10233', N'Soda trà', 'DU', 'http://file.hstatic.net/1000394081/article/soda_824b8f9a8a744318bcb3980a5708e580.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU29233', N'Soda nho', 'DU', 'http://file.hstatic.net/1000394081/article/soda_824b8f9a8a744318bcb3980a5708e580.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU1202333', N'Soda xoài', 'DU', 'http://file.hstatic.net/1000394081/article/soda_824b8f9a8a744318bcb3980a5708e580.jpg', '03862', 10, 35000)
insert into hanghoa
values('DU120233', N'Soda đào', 'DU', 'http://file.hstatic.net/1000394081/article/soda_824b8f9a8a744318bcb3980a5708e580.jpg', '03862', 10, 35000)

go



insert into khuvuc values('kv1',N'Tầng 1', '1')
insert into khuvuc values('kv2',N'Tầng 2', '1')
insert into khuvuc values('kv3',N'Tầng 3', '1')

insert into ban values('1',N'Bàn 1', 'kv1', '1')
insert into ban values('2',N'Bàn 2', 'kv1', '1')
insert into ban values('3',N'Bàn 3', 'kv1', '1')
insert into ban values('4',N'Bàn 4', 'kv1', '1')
insert into ban values('5',N'Bàn 5', 'kv1', '1')
insert into ban values('6',N'Bàn 6', 'kv1', '1')
insert into ban values('7',N'Bàn 7', 'kv1', '1')


insert into ban values('11',N'Bàn 11', 'kv2', '1')
insert into ban values('21',N'Bàn 21', 'kv2', '1')
insert into ban values('31',N'Bàn 31', 'kv2', '1')
insert into ban values('41',N'Bàn 41', 'kv2', '1')
insert into ban values('51',N'Bàn 51', 'kv2', '1')
insert into ban values('61',N'Bàn 61', 'kv2', '1')
insert into ban values('71',N'Bàn 71', 'kv2', '1')

insert into ban values('112',N'Bàn 112', 'kv3', '1')
insert into ban values('212',N'Bàn 212', 'kv3', '1')
insert into ban values('312',N'Bàn 312', 'kv3', '1')
insert into ban values('412',N'Bàn 412', 'kv3', '1')
insert into ban values('512',N'Bàn 521', 'kv3', '1')
insert into ban values('612',N'Bàn 612', 'kv3', '1')
insert into ban values('712',N'Bàn 712', 'kv3', '1')


CREATE PROCEDURE usp_selectbylikename
(
@name NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  *
FROM hanghoa
WHERE ten_hanghoa like '%' + @name + '%'
END
GO


CREATE PROCEDURE usp_deleteProduct
(
@id NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
delete hanghoa where ma_hanghoa = @id
END
GO


exec usp_selectbylikename @name = N'Soda'


insert into ban  values('8',N'Bàn 8', 'kv1', '1')
insert into ban  values('9',N'Bàn 9', 'kv1', '1')
insert into ban  values('10',N'Bàn 10', 'kv1', '1')
insert into ban  values('11',N'Bàn 11', 'kv1', '1')
insert into ban  values('12',N'Bàn 12', 'kv1', '1')
insert into ban  values('13',N'Bàn 13', 'kv1', '1')
insert into ban  values('14',N'Bàn 14', 'kv1', '1')
insert into ban  values('15',N'Bàn 15', 'kv1', '1')
insert into ban  values('16',N'Bàn 16', 'kv1', '1')

CREATE PROCEDURE usp_selectbyLOAIHANG
(
@name NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;

select hanghoa.* from hanghoa  join loaihanghoa on hanghoa.ma_loaihoang = loaihanghoa.ma_loaihoang
where loaihanghoa.tenloaihang = @name

END
GO

create proc reduceQuantityProduct @ma_hanghoa varchar(50), @soluong int
as
begin
	update hanghoa set soluong = soluong - @soluong
	where ma_hanghoa = @ma_hanghoa
end

create proc changeSTTBan @maban varchar(100), @trangthai varchar(100)
as
begin
	update ban set trangthai = @trangthai where maban = @maban

end

create proc proc_hoadonbanhang 
@ma_hd_bh varchar(100), @sdtkh varchar(50), @maban varchar(50),
 @tongtien int, @trangthai varchar(100)
as
begin
insert into hoadonbanhang (ma_hd_bh, sdt_kh,maban,ngay_hd_bh_check_in,tongtien, trangthai)
values(@ma_hd_bh, @sdtkh, @maban,GETDATE(), @tongtien, @trangthai)

end

create proc insertchitietbanhang @ma_hd_bh varchar(100), @ma_hanghoa varchar(100), @soluong int, @thanhtien int, @sdt varchar(100)
as
begin
insert into chitietbanhang(ma_hd_bh,ma_hanghoa,soluong, thanhtien, sodienthoai)
values(@ma_hd_bh, @ma_hanghoa, @soluong, @thanhtien, @sdt)
end



create proc insertchitietbanhang_online @ma_hd_bh varchar(100), @ma_hanghoa varchar(100), @soluong int, @thanhtien int, @trangthai varchar(100), @ngaygiao varchar(100), @giogiao varchar(100), @diachi varchar(100), @sodienthoai varchar(100)
as
begin
insert into chitietbanhang(ma_hd_bh,ma_hanghoa,soluong, thanhtien, trangthai, ngaygiao, giogiao, diachi, sodienthoai)
values(@ma_hd_bh, @ma_hanghoa, @soluong, @thanhtien, @trangthai , @ngaygiao, @giogiao ,@diachi , @sodienthoai  )
end

insert into khuvuc values('online', 'online', 'online')
insert into ban values('online', 'online', 'online', 'online')

create table lichSumuaHangKH(
	mahoadon varchar(100),
	TenSanPham varchar(100),
	phoneNumber varchar(100),
	soluong int,
	Gia int,
	Ngay varchar(100)
)

go



create proc lichSumuaHangKH_UP_insert
	@mahoadon varchar(100),
	@TenSanPham varchar(100),
	@phoneNumber varchar(100),
	@soluong int,
	@Gia int,
	@Ngay varchar(100)
as
begin 
	insert into lichSumuaHangKH(mahoadon, TenSanPham, phoneNumber, soluong, Gia, Ngay) values(@mahoadon, @TenSanPham, @phoneNumber, @soluong, @Gia, @Ngay)
end

create proc getALLlichSumuaHangKH_UP @phoneNumber varchar(100)
as
begin
	select * from lichSumuaHangKH where phoneNumber = @phoneNumber
end

alter table khachhang add diachi varchar(100)


create proc updateKH_up @name varchar(100), @sdt varchar(100), @diachi varchar(100), @pass varchar(100)
as
begin
	update khachhang set ten_kh = @name where sdt = @sdt
	update khachhang set sdt = @sdt where sdt = @sdt
	update khachhang set diachi = @diachi where sdt = @sdt
	update khachhang set matkhau = @pass where sdt = @sdt
end


CREATE TRIGGER congdiemtl
ON hoadonbanhang
AFTER INSERT
AS
BEGIN
    -- Lấy số điện thoại khách hàng từ hóa đơn bán hàng mới được thêm vào
    DECLARE @sdt_kh varchar(50)
    SELECT @sdt_kh = sdt_kh FROM inserted
    
    -- Cộng thêm 10 điểm thưởng vào điểm thưởng hiện tại của khách hàng
    UPDATE khachhang SET diemtl = diemtl + 10 WHERE sdt = @sdt_kh
END


insert into khachhang values('null','null', 0, 'null', 'null')
insert into ban values('OFF_MANGVE', 'OFF_MANGVE', 'online', '1')

create proc deleteHoaDon @mahd varchar(100)
as begin 
delete from chitietbanhang where ma_hd_bh = @mahd;
delete  from hoadonbanhang where ma_hd_bh = @mahd;
end


select * from ban join hoadonbanhang on ban.maban = hoadonbanhang.maban
where hoadonbanhang.maban = '14' and ban.trangthai = '0' and (hoadonbanhang.trangthai = 'OFF' or hoadonbanhang.trangthai


create proc infoHDtheoBan @maban varchar(100)
as
begin
select * from ban join hoadonbanhang on ban.maban = hoadonbanhang.maban
where hoadonbanhang.maban = @maban and ban.trangthai = '0' and (hoadonbanhang.trangthai = 'OFF' or hoadonbanhang.trangthai = 'DATBAN')

end

create proc ucp_updateChuyenBan @maban1 varchar(100), @maban2 varchar(100), @mahd varchar(100)
as
begin
update ban set trangthai = '1' where maban = @maban1
update ban set trangthai = '0' where maban = @maban2
update hoadonbanhang set maban = @maban2 where ma_hd_bh = @mahd
end

create proc deleteGopBan @mahdxoa varchar(100), @mahdgop varchar(100), @maban varchar(100)
as
begin
delete chitietbanhang where ma_hd_bh = @mahdxoa
delete hoadonbanhang where ma_hd_bh = @mahdxoa
update hoadonbanhang set maban = @maban where ma_hd_bh = @mahdgop
end

create table uudai(
	tenuudai varchar(100),
	tiengiamgia int
)

alter table hanghoa
add trangthai varchar(100)

create proc inserthh @ma_hanghoa varchar(254),@ten_hanghoa varchar(254),@ma_loaihoang varchar(254),@hinh_anh varchar(254),@sdt_ncc varchar(254), @soluong int , @giasp int ,@trangthai varchar(254)
as begin
insert into hanghoa(ma_hanghoa,ten_hanghoa,ma_loaihoang,hinh_anh,sdt_ncc, soluong, giasp,trangthai)
values(@ma_hanghoa , @ten_hanghoa , @ma_loaihoang , @hinh_anh , @sdt_ncc , @soluong , @giasp , @trangthai)
end

create proc updateHH  @ma_hanghoa varchar(254),@ten_hanghoa varchar(254),@ma_loaihoang varchar(254),@hinh_anh varchar(254),@sdt_ncc varchar(254), @soluong int , @giasp int ,@trangthai varchar(254)
as
begin
	update hanghoa set ten_hanghoa = @ten_hanghoa where ma_hanghoa = @ma_hanghoa
	update hanghoa set ma_loaihoang = @ma_loaihoang where ma_hanghoa = @ma_hanghoa
	update hanghoa set hinh_anh = @hinh_anh where ma_hanghoa = @ma_hanghoa
	update hanghoa set trangthai = @trangthai where ma_hanghoa = @ma_hanghoa
	update hanghoa set sdt_ncc = @sdt_ncc where ma_hanghoa = @ma_hanghoa
	update hanghoa set soluong = @soluong where ma_hanghoa = @ma_hanghoa
	update hanghoa set giasp = @giasp where ma_hanghoa = @ma_hanghoa
end


create proc insertnv @sdt varchar(100), @ten_nv  varchar(100), @gioitinh bit, @chucvu  varchar(100), @phanquyen bit, @ngayvaolam date, @matkhau  varchar(100), @calam  varchar(100)
as begin
insert into nhanvien
(sdt , ten_nv , gioitinh ,chucvu  ,phanquyen ,ngayvaolam ,matkhau  ,calam)
values(@sdt , @ten_nv , @gioitinh ,@chucvu  ,@phanquyen ,@ngayvaolam ,@matkhau  ,@calam)
end

create proc updateNV  @sdt varchar(100), @ten_nv  varchar(100), @gioitinh bit, @chucvu  varchar(100),
@phanquyen bit, @ngayvaolam date, @matkhau  varchar(100), @calam  varchar(100)
as
begin

	update nhanvien set ten_nv = @ten_nv where sdt = @sdt
	update nhanvien set gioitinh = @gioitinh where sdt = @sdt
	update nhanvien set chucvu = @chucvu where sdt = @sdt
	update nhanvien set phanquyen = @phanquyen where sdt = @sdt
	update nhanvien set ngayvaolam = @ngayvaolam where sdt = @sdt
	update nhanvien set matkhau = @matkhau where sdt = @sdt
	update nhanvien set calam = @calam where sdt = @sdt
end


create proc insertclv @ma_clv varchar(100), @ten_clv  varchar(100), @gio_BD int, @gio_kt  int , @sotien int
as begin
insert into calamviec
(ma_clv , ten_clv  , gio_BD , gio_kt   , sotien )
values(@ma_clv , @ten_clv  , @gio_BD , @gio_kt   , @sotien)
end

create proc updateCLV  @ma_clv varchar(100), @ten_clv  varchar(100), @gio_BD int, @gio_kt  int , @sotien int
as
begin

	update calamviec set ten_clv = @ten_clv where ma_clv = @ma_clv
	update calamviec set gio_BD = @gio_BD where ma_clv = @ma_clv
	update calamviec set gio_kt = @gio_kt where ma_clv = @ma_clv
	update calamviec set sotien = @sotien where ma_clv = @ma_clv

end


create proc insert_ban @maban varchar(100), @tenban varchar(100), @makhuvuc varchar(100), @trangthai varchar(100)
as begin 
insert into ban(maban , tenban , makhuvuc , trangthai) values(@maban , @tenban , @makhuvuc , @trangthai )
end

create proc update_ban @maban varchar(100), @tenban varchar(100), @makhuvuc varchar(100), @trangthai varchar(100)
as begin
update ban set tenban = @tenban where maban = @maban
update ban set makhuvuc = @makhuvuc where maban = @maban
update ban set trangthai = @trangthai where maban = @maban
end

create proc insert_uudai @tenuudai varchar(100), @tiengiamgia int, @trangthai varchar(100)
as begin 
insert into uudai(tenuudai, tiengiamgia, trangthai) values(@tenuudai, @tiengiamgia, @trangthai )
end

create proc update_uudai @tenuudai varchar(100), @tiengiamgia int, @trangthai varchar(100)
as begin
update uudai set tiengiamgia = @tiengiamgia where tenuudai = @tenuudai
update uudai set trangthai = @trangthai where tenuudai = @tenuudai
end

CREATE TRIGGER update_hanghoa_quantity
ON chitietbanhang
AFTER INSERT
AS
BEGIN
    UPDATE hanghoa
    SET hanghoa.soluong = hanghoa.soluong - inserted.soluong
    FROM hanghoa 
    INNER JOIN inserted  ON hanghoa.ma_hanghoa = inserted.ma_hanghoa;
END