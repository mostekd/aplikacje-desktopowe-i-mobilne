-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 24, 2024 at 06:39 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test_firma`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `formularz`
--

CREATE TABLE `formularz` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nr_telefonu` varchar(255) NOT NULL,
  `message` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `numery_kierunkowe`
--

CREATE TABLE `numery_kierunkowe` (
  `Kraj` varchar(28) DEFAULT NULL,
  `Kierunkowy` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `numery_kierunkowe`
--

INSERT INTO `numery_kierunkowe` (`Kraj`, `Kierunkowy`) VALUES
('', ''),
('Afganistan', '+93'),
('Alaska', '+1907'),
('Albania', '+355'),
('Algieria', '+213'),
('Andora', '+376'),
('Angola', '+244'),
('Antyle Holenderskie', '+599'),
('Arabia Saudyjska', '+966'),
('Argentyna', '+54'),
('Armenia', '+374'),
('Australia', '+61'),
('Austria', '+43'),
('Azerbejdżan', '+994'),
('Bahamy', '+1242'),
('Bahrajn', '+973'),
('Bangladesz', '+880'),
('Belgia', '+32'),
('Benin', '+229'),
('Białoruś', '+375'),
('Boliwia', '+591'),
('Bośnia i Hercegowina', '+387'),
('Botswana', '+267'),
('Brazylia', '+55'),
('Brunei', '+673'),
('Bułgaria', '+359'),
('Burkina Faso', '+226'),
('Burundi', '+257'),
('Chile', '+56'),
('Chiny', '+86'),
('Chorwacja', '+385'),
('Cook’a Wyspy', '+682'),
('Cypr', '+357'),
('Czad', '+235'),
('Czechy', '+420'),
('Dania', '+45'),
('Diego Garcia', '+246'),
('Dominikana', '+1809'),
('Dżibuti', '+253'),
('Egipt', '+20'),
('Ekwador', '+593'),
('Erytrea', '+291'),
('Estonia', '+372'),
('Etiopia', '+251'),
('Falklandy', '+500'),
('Fidżi', '+679'),
('Filipiny', '+63'),
('Finlandia', '+358'),
('Francja', '+33'),
('Gabon', '+241'),
('Gambia', '+220'),
('Ghana', '+233'),
('Gibraltar', '+350'),
('Grecja', '+30'),
('Grenlandia', '+299'),
('Gruzja', '+995'),
('Gujana Francuska', '+594'),
('Gujana', '+592'),
('Gwadelupa', '+590'),
('Gwinea – Bissau', '+245'),
('Gwinea Równikowa', '+240'),
('Gwinea', '+224'),
('Hawaje', '+1808'),
('Hiszpania', '+34'),
('Holandia', '+31'),
('Hong Kong', '+852'),
('Indie', '+91'),
('Indonezja', '+62'),
('Irak', '+964'),
('Iran', '+98'),
('Irlandia', '+353'),
('Islandia', '+354'),
('Izrael', '+972'),
('Japonia', '+81'),
('Jemen', '+967'),
('Jordania', '+962'),
('Jugosławia', '+381'),
('Kambodża', '+588'),
('Kamerun', '+237'),
('Kanada', '+1'),
('Kanaryjskie Wyspy', '+34'),
('Katar', '+974'),
('Kazachstan', '+7'),
('Kenia', '+254'),
('Kirgistan', '+996'),
('Kiribati', '+686'),
('Kolumbia', '+57'),
('Komory', '+269'),
('Kongo Republika Demokrat.', '+234'),
('Kongo', '+242'),
('Korea Południowa', '+82'),
('Koreańska RL-D', '+850'),
('Kostaryka', '+506'),
('Kuba', '+53'),
('Kuwejt', '+965'),
('Laos', '+856'),
('Lesotho', '+266'),
('Liban', '+961'),
('Liberia', '+231'),
('Libia', '+218'),
('Liechtenstein', '+423'),
('Litwa', '+370'),
('Luksemburg', '+352'),
('Łotwa', '+371'),
('Macedonia', '+389'),
('Madagaskar', '+261'),
('Makau', '+853'),
('Malawi', '+265'),
('Malediwy', '+960'),
('Malezja', '+60'),
('Mali', '+223'),
('Malta', '+356'),
('Maroko', '+212'),
('Marshalla Wyspy', '+692'),
('Martynika', '+596'),
('Mauretania', '+222'),
('Mauritius', '+230'),
('Meksyk', '+52'),
('Mołdawia', '+373'),
('Monako', '+377'),
('Mongolia', '+976'),
('Mozambik', '+258'),
('Myanmar (Birma)', '+95'),
('Namibia', '+264'),
('Nauru', '+674'),
('Nepal', '+977'),
('Niemcy', '+49'),
('Niger', '+227'),
('Nigeria', '+234'),
('Nikaragua', '+505'),
('Niue', '+683'),
('Norfolk Wyspa', '+672'),
('Norwegia', '+47'),
('Nowa Kaledonia', '+687'),
('Nowa Zelandia', '+64'),
('Oman', '+968'),
('Owcze Wyspy', '+298'),
('Pakistan', '+92'),
('Palau', '+680'),
('Palestyna', '+970'),
('Panama', '+507'),
('Papua Nowa Gwinea', '+675'),
('Paragwaj', '+595'),
('Peru', '+51'),
('Polinezja Francuska', '+689'),
('Polska', '+48'),
('Portoryko', '+1787'),
('Portugalia', '+351'),
('Republika Południowej Afryki', '+27'),
('Republika Środkowoafrykańska', '+236'),
('Reunion', '+262'),
('Rosja', '+7'),
('Rumunia', '+40'),
('Rwanda', '+250'),
('Sain Christopher i Nevis', '+1869'),
('Saint Lucia', '+1758'),
('Saint Vincent', '+1809'),
('Salomona Wyspy', '+677'),
('Salwador', '+503'),
('Samoa Zachodnie', '+685'),
('Samoa', '+684'),
('San Marino', '+378'),
('Senegal', '+221'),
('Seszele', '+248'),
('Sierra Leone', '+232'),
('Singapur', '+65'),
('Słowacja', '+421'),
('Słowenia', '+386'),
('Somalia', '+252'),
('Sri Lanka', '+94'),
('Stany Zjednoczone Ameryki', '+1'),
('Suazi', '+268'),
('Sudan', '+249'),
('Surinam', '+597'),
('Syria', '+963'),
('Szwajcaria', '+41'),
('Szwecja', '+46'),
('Św. Heleny Wyspa', '+290'),
('Św. Piotra i Mikeleona Wyspy', '+508'),
('Św. Tomasza Wyspy', '+239'),
('Tadżykistan', '+992'),
('Tajlandia', '+66'),
('Tajwan', '+886'),
('Tanzania', '+255'),
('Togo', '+228'),
('Tokelau', '+690'),
('Tonga', '+676'),
('Tunezja', '+216'),
('Turcja', '+90'),
('Turkmenistan', '+993'),
('Turks i Caicos', '+1649'),
('Tuvalu', '+688'),
('Uganda', '+256'),
('Ukraina', '+380'),
('Urugwaj', '+598'),
('Uzbekistan', '+998'),
('Vanuatu', '+678'),
('Wallis i Futuna', '+681'),
('Watykan', '+39'),
('Wenezuela', '+58'),
('Węgry', '+36'),
('Wielka Brytania', '+44'),
('Wietnam', '+84'),
('Włochy', '+39'),
('Wniebowstąpienia Wyspa', '+247'),
('Wybrzeże Kości Słoniowej', '+225'),
('Zambia', '+260'),
('Zanzibar', '+259'),
('Zielonego Przylądka Wyspy', '+238'),
('Zimbabwe', '+263');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `formularz`
--
ALTER TABLE `formularz`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `formularz`
--
ALTER TABLE `formularz`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
