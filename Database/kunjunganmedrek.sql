-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 23 Mar 2022 pada 06.22
-- Versi server: 10.4.14-MariaDB
-- Versi PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kunjunganmedrek`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkunjungan`
--

CREATE TABLE `tbkunjungan` (
  `no` varchar(100) NOT NULL,
  `no_reg` varchar(100) NOT NULL,
  `no_rm` varchar(100) NOT NULL,
  `nama_pasien` varchar(200) NOT NULL,
  `jenis_kelamin` varchar(100) NOT NULL,
  `umur` varchar(50) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  `rt` varchar(50) NOT NULL,
  `rw` varchar(50) NOT NULL,
  `wilayah` varchar(200) NOT NULL,
  `cara_bayar` varchar(200) NOT NULL,
  `poli` varchar(200) NOT NULL,
  `petugas` varchar(200) NOT NULL,
  `tanggal_kunjungan` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbkunjungan`
--

INSERT INTO `tbkunjungan` (`no`, `no_reg`, `no_rm`, `nama_pasien`, `jenis_kelamin`, `umur`, `alamat`, `rt`, `rw`, `wilayah`, `cara_bayar`, `poli`, `petugas`, `tanggal_kunjungan`) VALUES
('001', 'Baru', 'RM0001', 'ayuseptiani', 'Perempuan', '21', 'jalan raya maleer no.5, gatot subroto Bandung', '05', '10', 'Bandung Barat', 'Bayar Tunai', 'Umum', 'Umum', '2022-02-15'),
('002', 'Lama', 'RM002', 'sopie siti sopiah', 'Perempuan', '21', 'jalan raya ciamis no.25', '04', '01', 'Luar Kota Bandung', 'Mandiri', 'KIA', 'KIA', '2022-02-15'),
('003', 'Baru', 'RM003', 'rei', 'Laki-Laki', '21', 'Jalan Raya Nanjung No.23', '10', '06', 'Bandung Barat', 'PBI', 'Gigi', 'Gigi', '2021-02-16');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpasien`
--

CREATE TABLE `tbpasien` (
  `no_rm` varchar(50) NOT NULL,
  `nama_pasien` varchar(200) NOT NULL,
  `jenis_kelamin` varchar(50) NOT NULL,
  `tempat_lahir` varchar(200) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `umur` varchar(50) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  `no_telepon` varchar(50) NOT NULL,
  `no_bpjs` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbpasien`
--

INSERT INTO `tbpasien` (`no_rm`, `nama_pasien`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `umur`, `alamat`, `no_telepon`, `no_bpjs`) VALUES
('RM0001', 'ayuseptiani', 'Perempuan', 'bandung', '2000-02-22', '21', 'jalan raya maleer no.5, gatot subroto Bandung', '082237389933', '431888223'),
('RM002', 'sopie siti sopiah', 'Perempuan', 'ciamis', '2000-08-14', '21', 'jalan raya ciamis no.25', '089238327632', '1523382229'),
('RM003', 'rei', 'Laki-Laki', 'bandung', '0000-00-00', '21', 'Jalan Raya Nanjung No.23', '08986046063', '283992992');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpetugas`
--

CREATE TABLE `tbpetugas` (
  `nip` varchar(50) NOT NULL,
  `nama_petugas` varchar(200) NOT NULL,
  `jabatan` varchar(200) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `nomor_telepon` varchar(50) NOT NULL,
  `alamat` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbpetugas`
--

INSERT INTO `tbpetugas` (`nip`, `nama_petugas`, `jabatan`, `tanggal_lahir`, `nomor_telepon`, `alamat`) VALUES
('323294902010391', 'ayuseptiani', 'Staff Medrec', '2000-02-13', '08343742742', 'jalan raya maleer no.5 bandung'),
('3292919413431040', 'reihan fazri', 'Staff Umum', '2000-11-08', '08986046063', 'Jalan Raya Nanjung. no.32');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbuser`
--

CREATE TABLE `tbuser` (
  `nip` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbuser`
--

INSERT INTO `tbuser` (`nip`, `nama`, `username`, `password`) VALUES
('323030430433', 'ayu septiani', 'ayuse123', 'ayu'),
('132435466', 'sopie sayang rei', 'sopie123', 'sopie');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbkunjungan`
--
ALTER TABLE `tbkunjungan`
  ADD PRIMARY KEY (`no_rm`);

--
-- Indeks untuk tabel `tbpasien`
--
ALTER TABLE `tbpasien`
  ADD PRIMARY KEY (`no_rm`);

--
-- Indeks untuk tabel `tbpetugas`
--
ALTER TABLE `tbpetugas`
  ADD PRIMARY KEY (`nip`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
