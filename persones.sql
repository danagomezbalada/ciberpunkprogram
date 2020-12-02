-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 02, 2020 at 08:31 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `persones`
--

-- --------------------------------------------------------

--
-- Table structure for table `capacitats`
--

CREATE TABLE `capacitats` (
  `ID` int(11) NOT NULL,
  `Capacitat` varchar(500) NOT NULL,
  `Gremi` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `capacitats`
--

INSERT INTO `capacitats` (`ID`, `Capacitat`, `Gremi`) VALUES
(1, 'Environmental Awareness', 'VP Product Management'),
(2, 'Governance', 'Accounting Assistant IV'),
(3, 'Biostatistics', 'Structural Analysis Engineer'),
(4, 'Museum Collections', 'Legal Assistant'),
(5, 'IACUC', 'Software Test Engineer II'),
(6, 'Agents', 'Quality Control Specialist'),
(7, 'Lymphoma', 'Actuary'),
(8, 'Jive SBS', 'Social Worker'),
(9, 'Immunology', 'Accountant III'),
(10, 'Risk Management', 'Database Administrator IV');

-- --------------------------------------------------------

--
-- Table structure for table `gremis`
--

CREATE TABLE `gremis` (
  `ID` int(11) NOT NULL,
  `Gremi` varchar(500) NOT NULL,
  `Capacitat` varchar(500) NOT NULL,
  `Territori` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gremis`
--

INSERT INTO `gremis` (`ID`, `Gremi`, `Capacitat`, `Territori`) VALUES
(1, 'Community Outreach Specialist', 'Small Boat Operations', 'North Battleford'),
(2, 'Clinical Specialist', 'FDDI', 'Ipoh'),
(3, 'Business Systems Development Analyst', 'Jerseys', 'Libertad'),
(4, 'Recruiter', 'DFSORT', 'Dolice'),
(5, 'Accounting Assistant IV', 'Rig', 'Pithári'),
(6, 'Assistant Professor', 'Key Performance Indicators', 'New Orleans'),
(7, 'Help Desk Operator', 'MySpace', 'Dolní Čermná'),
(8, 'Account Representative I', 'GS1', 'Pontevedra'),
(9, 'Desktop Support Technician', 'NS2', 'Dubna'),
(10, 'Recruiter', 'Bonds', 'Dadong’ao'),
(11, 'Technical Writer', 'QNX', 'Višnjevac'),
(12, 'Desktop Support Technician', 'Numerical Simulation', 'Francisco Villa'),
(13, 'Accountant IV', 'UK GAAP', 'Donostia-San Sebastian'),
(14, 'Recruiting Manager', 'PPAP', 'Tabalong'),
(15, 'Computer Systems Analyst I', 'DFSS Green Belt', 'Huaihe');

-- --------------------------------------------------------

--
-- Table structure for table `persones`
--

CREATE TABLE `persones` (
  `ID` int(11) NOT NULL,
  `Nom` varchar(250) NOT NULL,
  `Cognom` varchar(300) NOT NULL,
  `Edat` int(150) NOT NULL,
  `Territori` varchar(500) NOT NULL,
  `Capacitat` varchar(500) NOT NULL,
  `Espai` varchar(500) NOT NULL,
  `Educacio` varchar(500) NOT NULL,
  `Gremi` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `persones`
--

INSERT INTO `persones` (`ID`, `Nom`, `Cognom`, `Edat`, `Territori`, `Capacitat`, `Espai`, `Educacio`, `Gremi`) VALUES
(1, 'Brittan', 'Rubinowitch', 26, 'Неготино', 'MPages', 'Florence', 'Glasgow School of Art', 'Mechanical Systems Engineer'),
(2, 'Jorge', 'Shrubsall', 67, 'Ramotswa', 'Integration', 'Village', 'Inner Mongolia University', 'Legal Assistant'),
(3, 'Brandise', 'Bolan', 69, 'Qorovulbozor', 'JFace', 'Mayer', 'Americanos College', 'Chemical Engineer'),
(4, 'Saloma', 'Jaggi', 54, 'Bangilan', 'GCF', 'Fairview', 'Daido Institute of Technology', 'Technical Writer'),
(5, 'Teirtza', 'Godbold', 72, 'Dinghuo', 'NDIS', 'Declaration', 'Florida Gulf Coast University', 'Senior Developer'),
(6, 'Yolane', 'Robbey', 63, 'Delod Pangkung', 'Corporate Governance', 'Beilfuss', 'Parwan University', 'Geologist III'),
(7, 'Marcelo', 'Sumpton', 22, 'Nova Varoš', 'BPL', 'Jenifer', 'Universidad Pedagógica de El Salvador', 'Administrative Officer'),
(8, 'Rey', 'Gallaher', 83, 'Pueblo Nuevo', 'pgAdmin', 'Kipling', 'Omdurman Islamic University', 'Dental Hygienist'),
(9, 'Rodi', 'Gladbach', 67, 'Vermil', 'Visual Arts', 'High Crossing', 'Westfield State College', 'Programmer I'),
(10, 'Sile', 'Woodhams', 65, 'Zhaxirabdain', 'FTTx', 'Tomscot', 'E.A.P. Europäische Wirtschaftshochschule Berlin', 'Computer Systems Analyst II'),
(11, 'Chauncey', 'Comettoi', 83, 'Taltal', 'Small Boat Operations', 'Bultman', 'International Christian University', 'Environmental Specialist'),
(12, 'Catherine', 'Linturn', 22, 'Malainen Luma', 'Business Analysis', 'Toban', 'College of Education Oju', 'Senior Quality Engineer'),
(13, 'Zack', 'Whiles', 26, 'Castanheira de Pêra', 'WSPG', 'Sutteridge', 'Pacific College of Oriental Medicine', 'Assistant Professor'),
(14, 'Hamil', 'Preedy', 33, 'Yanjiang', 'HVDC', 'Texas', 'Universidad de Hermosillo', 'Operator'),
(15, 'Jo-anne', 'Pitbladdo', 56, 'Hanting', 'PyGTK', 'Russell', 'Miyagi Gakuin Women\'s College', 'Geological Engineer'),
(16, 'Blayne', 'Ledger', 58, 'Kara', 'Obstructive Sleep Apnea', 'Mallard', 'Universidad Metropolitana de Monterrey', 'Web Developer II'),
(17, 'Inessa', 'Parsand', 71, 'Rîbniţa', 'MCMS', 'Mallory', 'National Chung Hsing University, Taipei', 'Associate Professor'),
(18, 'Kinna', 'Guitton', 71, 'Xiji', 'dtSearch', 'Clarendon', 'Solusi University', 'Senior Quality Engineer'),
(19, 'Pammi', 'Gibbin', 58, 'Dorchester', 'NRSWA', 'Novick', 'Kent State University', 'Developer I'),
(20, 'Ware', 'Mellanby', 53, 'Shuishi', 'DL1', 'Mendota', 'Caldwell College', 'Research Nurse');

-- --------------------------------------------------------

--
-- Table structure for table `territoris`
--

CREATE TABLE `territoris` (
  `ID` int(11) NOT NULL,
  `Territori` varchar(500) NOT NULL,
  `Gremi` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `territoris`
--

INSERT INTO `territoris` (`ID`, `Territori`, `Gremi`) VALUES
(1, 'Satowebrang', 'Research Associate'),
(2, 'Adelaide Mail Centre', 'Engineer IV'),
(3, 'Yushugou', 'Quality Control Specialist'),
(4, 'Chahe', 'Research Nurse'),
(5, 'Woippy', 'Registered Nurse'),
(6, 'Västerås', 'Teacher'),
(7, 'Punta Alta', 'Social Worker'),
(8, 'Järfälla', 'Tax Accountant'),
(9, 'Gumawang', 'Human Resources Manager'),
(10, 'Patos Fshat', 'Social Worker'),
(11, 'Kakamigahara', 'Design Engineer'),
(12, 'Curitibanos', 'VP Quality Control'),
(13, 'Ochota', 'Desktop Support Technician');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `capacitats`
--
ALTER TABLE `capacitats`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `gremis`
--
ALTER TABLE `gremis`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `persones`
--
ALTER TABLE `persones`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `territoris`
--
ALTER TABLE `territoris`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `capacitats`
--
ALTER TABLE `capacitats`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `gremis`
--
ALTER TABLE `gremis`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `persones`
--
ALTER TABLE `persones`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `territoris`
--
ALTER TABLE `territoris`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
