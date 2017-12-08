use muonsach
-- select * from sach
-- https://tiki.vn/inuyasha-tap-2-ban-dac-biet-p1005470.html?src=category-page

insert into tac_gia values('Rumiko Takahashi')
insert into nxb values('Nha xuat ban tre')

insert into sach(ten, anh, ma_tac_gia, ma_nxb, so_trang, gia, gia_thue, mo_ta, nam_xb, ngay_nhap)
values(
	N'Inuyasha - Tập 2 (Bản Đặc Biệt)',
	N'3.u5465.d20171009.t095206.104725.jpg',
	1,
	1,
	120,
	48000,
	1000,
	N'no des',
	'1999',
	'6/12/2017'
)

-- insert user
insert into nguoi_dung(ten_dang_nhap, mat_khau) values('master', 'retsam')

