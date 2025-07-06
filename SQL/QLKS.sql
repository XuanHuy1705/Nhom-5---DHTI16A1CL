CREATE TABLE NhatKyTraPhong (
    MaDatPhong VARCHAR(20) FOREIGN KEY REFERENCES DatPhong(MaDatPhong),
    NgayTraThucTe DATE,
    NhanVien NVARCHAR(100),
    GhiChu NVARCHAR(255)
);
