-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 20:16:54
-- Sunucu sürümü: 8.0.30
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `otoservis`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `araclar`
--

CREATE TABLE `araclar` (
  `arac_id` int NOT NULL,
  `marka` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `model` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `yil` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sase_no` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `plaka` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sigorta_id` int NOT NULL,
  `filo_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `araclar`
--

INSERT INTO `araclar` (`arac_id`, `marka`, `model`, `yil`, `sase_no`, `plaka`, `sigorta_id`, `filo_id`) VALUES
(2, 'marka1', 'model1', '2020', 'sad23asd', 'sad23saq', 1, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `filolar`
--

CREATE TABLE `filolar` (
  `filo_id` int NOT NULL,
  `filo_no` int NOT NULL,
  `filo_adi` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `filolar`
--

INSERT INTO `filolar` (`filo_id`, `filo_no`, `filo_adi`) VALUES
(1, 333, 'asdasd'),
(2, 2321, 'asdsa');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gecmis`
--

CREATE TABLE `gecmis` (
  `gecmisislem_id` int NOT NULL,
  `arac_id` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `parca` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `islem` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `bedel` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `gecmis`
--

INSERT INTO `gecmis` (`gecmisislem_id`, `arac_id`, `parca`, `islem`, `bedel`) VALUES
(7, '2 marka1 model1', 'silecek:100', 'işlem2:500', 600),
(8, '3 asdasd asdasd', 'motor:2000', 'işlem2:500', 2500),
(10, '2 marka1 model1', 'silecek:100', 'işlem1:400', 500),
(11, '3 asdasd asdasd', 'motor:2000', 'işlem2:500', 2500),
(12, '3 asdasd asdasd', 'silecek:100', 'işlem2:400', 500),
(14, '2 marka1 model1', 'silecek:100', 'işlem1:400', 500),
(15, '3 asdasd asdasd', 'motor:2000', 'işlem2:500', 2500),
(16, '2 marka1 model1', 'ayna:200', 'işlem1:400', 600),
(17, '2 marka1 model1', 'direksiyon:300', 'işlem1:400', 700),
(18, '2 marka1 model1', 'motor:2000', 'işlem2:500', 2500);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `islem`
--

CREATE TABLE `islem` (
  `islem_id` int NOT NULL,
  `islem_isim` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `islem_fiyat` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `islem`
--

INSERT INTO `islem` (`islem_id`, `islem_isim`, `islem_fiyat`) VALUES
(4, 'işlem2', '400'),
(5, 'işlem2', '500'),
(9, 'islem4', '900'),
(10, 'işlem9', '1800'),
(11, 'işlem11', '12400');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteriler`
--

CREATE TABLE `musteriler` (
  `musteri_id` int NOT NULL,
  `ad` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `soyad` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tc` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci NOT NULL,
  `adres` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tel` varchar(20) COLLATE utf8mb4_turkish_ci NOT NULL,
  `arac_id` int NOT NULL,
  `sigorta_id` int NOT NULL,
  `filo_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `musteriler`
--

INSERT INTO `musteriler` (`musteri_id`, `ad`, `soyad`, `tc`, `adres`, `tel`, `arac_id`, `sigorta_id`, `filo_id`) VALUES
(2, 'oğuzhan', 'örge', '555555555555', '.mah .sok NO:', '55555555555', 2, 1, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sigorta_sirketleri`
--

CREATE TABLE `sigorta_sirketleri` (
  `sigorta_id` int NOT NULL,
  `sigorta_no` int NOT NULL,
  `sigorta_adi` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `sigorta_sirketleri`
--

INSERT INTO `sigorta_sirketleri` (`sigorta_id`, `sigorta_no`, `sigorta_adi`) VALUES
(1, 123123, 'sigorta12');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yedekparca`
--

CREATE TABLE `yedekparca` (
  `parca_id` int NOT NULL,
  `parca_isim` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `parca_fiyat` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `yedekparca`
--

INSERT INTO `yedekparca` (`parca_id`, `parca_isim`, `parca_fiyat`) VALUES
(3, 'motor', '2000'),
(5, 'silecek', '100'),
(20, 'ayna', '200'),
(21, 'direksiyon', '300'),
(22, 'kaporta', '800');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `araclar`
--
ALTER TABLE `araclar`
  ADD PRIMARY KEY (`arac_id`);

--
-- Tablo için indeksler `filolar`
--
ALTER TABLE `filolar`
  ADD PRIMARY KEY (`filo_id`);

--
-- Tablo için indeksler `gecmis`
--
ALTER TABLE `gecmis`
  ADD PRIMARY KEY (`gecmisislem_id`);

--
-- Tablo için indeksler `islem`
--
ALTER TABLE `islem`
  ADD PRIMARY KEY (`islem_id`);

--
-- Tablo için indeksler `musteriler`
--
ALTER TABLE `musteriler`
  ADD PRIMARY KEY (`musteri_id`);

--
-- Tablo için indeksler `sigorta_sirketleri`
--
ALTER TABLE `sigorta_sirketleri`
  ADD PRIMARY KEY (`sigorta_id`);

--
-- Tablo için indeksler `yedekparca`
--
ALTER TABLE `yedekparca`
  ADD PRIMARY KEY (`parca_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `araclar`
--
ALTER TABLE `araclar`
  MODIFY `arac_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `filolar`
--
ALTER TABLE `filolar`
  MODIFY `filo_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `gecmis`
--
ALTER TABLE `gecmis`
  MODIFY `gecmisislem_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Tablo için AUTO_INCREMENT değeri `islem`
--
ALTER TABLE `islem`
  MODIFY `islem_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `musteriler`
--
ALTER TABLE `musteriler`
  MODIFY `musteri_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `sigorta_sirketleri`
--
ALTER TABLE `sigorta_sirketleri`
  MODIFY `sigorta_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `yedekparca`
--
ALTER TABLE `yedekparca`
  MODIFY `parca_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
