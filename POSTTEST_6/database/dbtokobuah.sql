CREATE DATABASE dbtokobuah;
USE dbtokobuah;
CREATE TABLE tbsupplier (
    id_supplier VARCHAR(5) PRIMARY KEY,
    nama_supplier VARCHAR(50),
    alamat VARCHAR(100)
);

CREATE TABLE buah (
    id_buah VARCHAR(5) PRIMARY KEY,
    nama_buah VARCHAR(50),
    harga INT,
    stok INT,
    id_supplier VARCHAR(5),
    -- Menghubungkan ke tabel tbsupplier
    CONSTRAINT fk_supplier_buah
        FOREIGN KEY (id_supplier) 
        REFERENCES tbsupplier(id_supplier)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

INSERT INTO tbsupplier (id_supplier, nama_supplier, alamat) VALUES 
('S001', 'Tani Makmur', 'Jl. Kadrie Oening, Samarinda'),
('S002', 'Berau Tropical Fruit', 'Jl. Ahmad Yani, Berau'),
('S003', 'Distributor Buah Segar', 'Jl. Pahlawan, Samarinda'),
('S004', 'Kebun Nusantara', 'Jl. Sultan Hasanuddin, Balikpapan');