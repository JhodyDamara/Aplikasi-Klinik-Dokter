-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Waktu pembuatan: 16. Januari 2019 jam 20:40
-- Versi Server: 5.5.16
-- Versi PHP: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `klinik_dokter`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `dokter`
--

CREATE TABLE IF NOT EXISTS `dokter` (
  `kd_dok` varchar(10) NOT NULL,
  `nama_dok` varchar(25) DEFAULT NULL,
  `spesialis` varchar(20) DEFAULT NULL,
  `jk` varchar(10) DEFAULT NULL,
  `no_hp` varchar(13) DEFAULT NULL,
  `alamat` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_dok`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dokter`
--

INSERT INTO `dokter` (`kd_dok`, `nama_dok`, `spesialis`, `jk`, `no_hp`, `alamat`) VALUES
('DOK001', 'Jhody Dmr', 'Umum', 'Laki-Laki', '081364431051', 'Jl. Air Dingin'),
('DOK002', 'Riduan  ', 'Kandungan', 'Laki-Laki', '0813xxxxxxxx', 'Jl.  Karya'),
('DOK003', 'Hahaha', 'Gigi', 'Perempuan', '0813xxxxxxxx', 'Jl. Cinta'),
('DOK004', 'Riri', 'Umum', 'Perempuan', '0822xxxxxxxx', 'Jl. Mawar'),
('DOK006', 'Ayu', 'Kandungan', 'Perempuan', '0813xxxxxxxx', 'Jl. Karya'),
('DOK007', 'Roy', 'Umum', 'Laki-Laki', '0823xxxxxxxx', 'Jl. Melati'),
('DOK008', 'Nurul', 'Umum', 'Perempuan', '0823xxxxxxxx', 'Jl. anggrek'),
('DOK009', 'Deni', 'Umum', 'Laki-Laki', '081387654567', 'Jl. Miduk');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pasien`
--

CREATE TABLE IF NOT EXISTS `pasien` (
  `kd_pas` varchar(10) NOT NULL,
  `nik` varchar(20) DEFAULT NULL,
  `nama_pas` varchar(25) DEFAULT NULL,
  `tmpt_lahir` varchar(20) DEFAULT NULL,
  `tgl_lahir` varchar(25) DEFAULT NULL,
  `jk` varchar(12) DEFAULT NULL,
  `usia` varchar(5) DEFAULT NULL,
  `pekerjaan` varchar(30) DEFAULT NULL,
  `no_hp` varchar(13) DEFAULT NULL,
  `alamat` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_pas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pasien`
--

INSERT INTO `pasien` (`kd_pas`, `nik`, `nama_pas`, `tmpt_lahir`, `tgl_lahir`, `jk`, `usia`, `pekerjaan`, `no_hp`, `alamat`) VALUES
('pas0001', '1234567890123456', 'yoga', 'dumai', '25 Juni 1997', 'Laki-Laki', '21', 'mahasiswa', '081256765434', 'jl. karya'),
('pas0002', '1234567890123453', 'deni', 'dumai', '13 Juli 2000', 'Laki-Laki', '18', 'mahasiswa', '081212345678', 'jl. miduk'),
('pas0003', '1234567890123476', 'restu', 'ukui', '25 Mei 1995', 'Laki-Laki', '23', 'mahasiswa', '08121234134', 'jl. ketapang'),
('pas0004', '1223234434465654', 'nizam', 'bagan', '15 Juni 1995', 'Pilih', '24', 'Mahasiswa', '081287654567', 'Kubang');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pendaftaran`
--

CREATE TABLE IF NOT EXISTS `pendaftaran` (
  `kd_daftar` varchar(10) NOT NULL,
  `tgl_daftar` varchar(20) DEFAULT NULL,
  `nama_dok` varchar(30) DEFAULT NULL,
  `nama_per` varchar(30) DEFAULT NULL,
  `kd_pas` varchar(10) DEFAULT NULL,
  `nama_pas` varchar(30) DEFAULT NULL,
  `usia` varchar(5) DEFAULT NULL,
  `keluhan` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pendaftaran`
--

INSERT INTO `pendaftaran` (`kd_daftar`, `tgl_daftar`, `nama_dok`, `nama_per`, `kd_pas`, `nama_pas`, `usia`, `keluhan`) VALUES
('dft0001', '15/11/2018', 'Jhody Dmr', 'Risna', 'pas0001', 'yoga', '21', 'Sakit Perut'),
('dft0002', '15/11/2018', 'Riri', 'Risna', 'pas0002', 'deni', '18', 'Sakit Kepala'),
('dft0003', '15/11/2018', 'Roy', 'Ani', 'pas0003', 'restu', '23', 'Demam'),
('dft0004', '16/11/2018', 'Nurul', 'Ayu', 'pas0004', 'nizam', '24', 'Sakit Pinggang'),
('dft0005', '17/11/2018', 'Nurul', 'Ayu', 'pas0001', 'yoga', '21', 'Sakit Perut');

-- --------------------------------------------------------

--
-- Struktur dari tabel `perawat`
--

CREATE TABLE IF NOT EXISTS `perawat` (
  `kd_per` varchar(10) NOT NULL,
  `nama_per` varchar(25) DEFAULT NULL,
  `jk` varchar(10) DEFAULT NULL,
  `no_hp` varchar(13) DEFAULT NULL,
  `alamat` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_per`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `perawat`
--

INSERT INTO `perawat` (`kd_per`, `nama_per`, `jk`, `no_hp`, `alamat`) VALUES
('PER001', 'Risna', 'Perempuan', '0813xxxxxxxx', 'Panam'),
('PER002', 'Ayu', 'Perempuan', '0812xxxxxxxx', 'Kubang'),
('PER003', 'Haha', 'Laki-Laki', '0822xxxxxxxx', 'sukajadi'),
('PER004', 'wkwk', 'Perempuan', '0813xxxxxxxx', 'Jl. wkwkland'),
('PER005', 'Cinta', 'Perempuan', '081398765432', 'Sukajadi'),
('PER006', 'Ani', 'Perempuan', '082387656764', 'Jl. Karya');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tindakan`
--

CREATE TABLE IF NOT EXISTS `tindakan` (
  `kd_tindak` varchar(15) NOT NULL,
  `kd_daftar` varchar(10) DEFAULT NULL,
  `tgl_daftar` varchar(12) DEFAULT NULL,
  `nama_pas` varchar(30) DEFAULT NULL,
  `usia` varchar(5) DEFAULT NULL,
  `keluhan` varchar(30) DEFAULT NULL,
  `tindakan` varchar(30) DEFAULT NULL,
  `diagnosa` varchar(30) DEFAULT NULL,
  `biaya` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_tindak`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tindakan`
--

INSERT INTO `tindakan` (`kd_tindak`, `kd_daftar`, `tgl_daftar`, `nama_pas`, `usia`, `keluhan`, `tindakan`, `diagnosa`, `biaya`) VALUES
('RM0001', 'dft0001', '15/11/2018', 'yoga', '21', 'Sakit Perut', 'Periksa', 'Mag', '250000'),
('RM0002', 'dft0002', '15/11/2018', 'deni', '18', 'Sakit Kepala', 'Periksa', 'Migrain', '200000'),
('RM0003', 'dft0003', '15/11/2018', 'restu', '23', 'Demam', 'Periksa', 'Demam', '300000'),
('RM0004', 'dft0004', '16/11/2018', 'nizam', '24', 'Sakit Pinggang', 'Ronsen', 'Encok', '350000'),
('RM0005', 'dft0001', '15/11/2018', 'yoga', '21', 'Sakit Perut', 'Periksa', 'Diare', '200000');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
