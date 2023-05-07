-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: Št 02.Mar 2023, 15:21
-- Verzia serveru: 10.4.25-MariaDB
-- Verzia PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `online-testovanie`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `otazky`
--

CREATE TABLE `otazky` (
  `otazka_id` int(11) NOT NULL,
  `otazka_popis` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `moznost_1` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `moznost_2` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `moznost_3` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `moznost_4` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `spravna_odpoved` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `otazka_predmet` varchar(255) COLLATE utf8_slovak_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovak_ci;

--
-- Sťahujem dáta pre tabuľku `otazky`
--

INSERT INTO `otazky` (`otazka_id`, `otazka_popis`, `moznost_1`, `moznost_2`, `moznost_3`, `moznost_4`, `spravna_odpoved`, `otazka_predmet`) VALUES
(1, 'Čo je to C#?', 'dopytovací jazyk', 'programovací jazyk', 'značkovací jazyk', 'ľudský jazyk', 'programovací jazyk', 'PRG'),
(2, 'Kde sa využíva C#?', 'v domácnosti', 'v športe', 'v prírode', 'v IT', 'v IT', 'PRG'),
(3, 'Ktorá spoločnosť vyvinula C#?', 'Apple', 'Microsoft', 'Google', 'Samsung', 'Microsoft', 'PRG'),
(4, 'V ktorom roku vznikol C#?', '2000', '2004', '1999', '2006', '2000', 'PRG'),
(5, 'Akú príponu používa program napísaný v C#?', '.app', '.cc', '.c#', '.cs', '.cs', 'PRG'),
(6, 'Ako napíšeme jednoriadkový komentár v C#?', '/* */', '/+ +/', '//', '#', '//', 'PRG'),
(7, 'Ako napíšeme viacriadkový komentár v C#?', '/* */', '#', '//', '/+ +/', '/* */', 'PRG'),
(8, 'Ako definujeme pole v C#?', '{}', '()', '[]', '</ />', '[]', 'PRG'),
(9, 'Ako vytvoríme metódu v C#?', 'MojaMetóda()', 'mojaMetóda[]', 'MojaMetóda.', '(mojaMetóda)', 'MojaMetóda()', 'PRG'),
(10, 'Kde sa využíva C#?', 'v domácnosti', 'v športe', 'v prírode', 'v IT', 'v IT', 'PRG'),
(11, 'Akým indexom začínajú polia v C#?', '-1', '0', '1', '0,0', '0', 'PRG'),
(12, 'Ktorá možnosť označuje koniec bloku #region v C#?', 'endregion', 'region', 'error', '//region', 'endregion', 'PRG'),
(13, 'V ktorom roku bola vydaná najnovšia verzia C#?', '2019', '2013', '2017', '2016', '2017', 'PRG'),
(14, 'Ako správne zadeklarujeme pole v C#?', 'int[] intPole = new int[5];', 'int[5] intPole = new int[];', 'int intPole[] = new int[5];', 'int[] intPole = new int[];', 'int[] intPole = new int[5];', 'PRG');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `predmety`
--

CREATE TABLE `predmety` (
  `predmet_id` int(11) NOT NULL,
  `predmet_nazov` varchar(255) COLLATE utf8_slovak_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovak_ci;

--
-- Sťahujem dáta pre tabuľku `predmety`
--

INSERT INTO `predmety` (`predmet_id`, `predmet_nazov`) VALUES
(1, 'PRG');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `studenti`
--

CREATE TABLE `studenti` (
  `student_id` int(11) NOT NULL,
  `student_meno` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `student_vek` int(11) NOT NULL,
  `student_heslo` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `student_skore` int(11) DEFAULT NULL,
  `student_adresa` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `student_mobil` varchar(255) COLLATE utf8_slovak_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovak_ci;

--
-- Sťahujem dáta pre tabuľku `studenti`
--

INSERT INTO `studenti` (`student_id`, `student_meno`, `student_vek`, `student_heslo`, `student_skore`, `student_adresa`, `student_mobil`) VALUES
(1, 'stefan mudry', 19, 'stefan123', 9, 'Pekná 123', '0912345678');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `vysledky`
--

CREATE TABLE `vysledky` (
  `vysledok_id` int(11) NOT NULL,
  `vysledok_predmet` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `vysledok_student` varchar(255) COLLATE utf8_slovak_ci NOT NULL,
  `vysledok_datum` date NOT NULL,
  `vysledok_cas` time(2) NOT NULL,
  `vysledok_skore` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovak_ci;

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `otazky`
--
ALTER TABLE `otazky`
  ADD PRIMARY KEY (`otazka_id`);

--
-- Indexy pre tabuľku `predmety`
--
ALTER TABLE `predmety`
  ADD PRIMARY KEY (`predmet_id`);

--
-- Indexy pre tabuľku `studenti`
--
ALTER TABLE `studenti`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexy pre tabuľku `vysledky`
--
ALTER TABLE `vysledky`
  ADD PRIMARY KEY (`vysledok_id`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `otazky`
--
ALTER TABLE `otazky`
  MODIFY `otazka_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pre tabuľku `predmety`
--
ALTER TABLE `predmety`
  MODIFY `predmet_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pre tabuľku `studenti`
--
ALTER TABLE `studenti`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pre tabuľku `vysledky`
--
ALTER TABLE `vysledky`
  MODIFY `vysledok_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
