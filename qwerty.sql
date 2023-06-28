-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 23 2022 г., 14:07
-- Версия сервера: 5.7.36
-- Версия PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `qwerty`
--

-- --------------------------------------------------------

--
-- Структура таблицы `admins`
--

DROP TABLE IF EXISTS `admins`;
CREATE TABLE IF NOT EXISTS `admins` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL,
  `email` varchar(25) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `admins`
--

INSERT INTO `admins` (`id`, `login`, `password`, `email`) VALUES
(1, 'damirlan', '10523411', 'hanov91@gmail.com'),
(2, 'kirill', '13572468', 'kirill@gmail.com');

-- --------------------------------------------------------

--
-- Структура таблицы `breedofanimal`
--

DROP TABLE IF EXISTS `breedofanimal`;
CREATE TABLE IF NOT EXISTS `breedofanimal` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `name_breed` varchar(20) NOT NULL,
  `id_type` int(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_type` (`id_type`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `breedofanimal`
--

INSERT INTO `breedofanimal` (`id`, `name_breed`, `id_type`) VALUES
(1, 'CentralAsian', 2),
(2, 'Red', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `brend`
--

DROP TABLE IF EXISTS `brend`;
CREATE TABLE IF NOT EXISTS `brend` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `name_brend` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `brend`
--

INSERT INTO `brend` (`id`, `name_brend`) VALUES
(1, 'royalcanin'),
(2, 'acana');

-- --------------------------------------------------------

--
-- Структура таблицы `familyofanimal`
--

DROP TABLE IF EXISTS `familyofanimal`;
CREATE TABLE IF NOT EXISTS `familyofanimal` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `name_family` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `familyofanimal`
--

INSERT INTO `familyofanimal` (`id`, `name_family`) VALUES
(1, 'mammals'),
(2, 'reptiles');

-- --------------------------------------------------------

--
-- Структура таблицы `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE IF NOT EXISTS `product` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `name_product` varchar(20) NOT NULL,
  `id_animal` int(20) NOT NULL,
  `id_top` int(20) NOT NULL,
  `id_brend` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_animal` (`id_animal`,`id_top`,`id_brend`),
  KEY `id_brend` (`id_brend`),
  KEY `id_top` (`id_top`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `product`
--

INSERT INTO `product` (`id`, `name_product`, `id_animal`, `id_top`, `id_brend`) VALUES
(1, 'pork', 2, 1, 2),
(2, 'suit', 1, 2, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `purchases`
--

DROP TABLE IF EXISTS `purchases`;
CREATE TABLE IF NOT EXISTS `purchases` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_user` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_product` (`id_product`),
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `purchases`
--

INSERT INTO `purchases` (`id`, `id_user`, `id_product`) VALUES
(1, 1, 1),
(2, 2, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `typeofanimal`
--

DROP TABLE IF EXISTS `typeofanimal`;
CREATE TABLE IF NOT EXISTS `typeofanimal` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `name_type` varchar(20) NOT NULL,
  `id_family` int(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_family` (`id_family`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `typeofanimal`
--

INSERT INTO `typeofanimal` (`id`, `name_type`, `id_family`) VALUES
(1, 'cat', 1),
(2, 'turtle', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `typeofproduct`
--

DROP TABLE IF EXISTS `typeofproduct`;
CREATE TABLE IF NOT EXISTS `typeofproduct` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `name_top` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `typeofproduct`
--

INSERT INTO `typeofproduct` (`id`, `name_top`) VALUES
(1, 'food'),
(2, 'clothes');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `login` varchar(11) NOT NULL,
  `password` varchar(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`) VALUES
(1, 'damir', '1000'),
(2, 'silya', '10223411'),
(4, 'sarnava', '10023411'),
(5, 'pasha', '123456'),
(6, 'fuuu', '2468'),
(7, 'kirill', '109'),
(9, 'ural', '123'),
(10, 'damir', '123'),
(32, 'sarnava', '10323411');

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `breedofanimal`
--
ALTER TABLE `breedofanimal`
  ADD CONSTRAINT `breedofanimal_ibfk_1` FOREIGN KEY (`id_type`) REFERENCES `typeofanimal` (`id`);

--
-- Ограничения внешнего ключа таблицы `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`id_animal`) REFERENCES `breedofanimal` (`id`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`id_brend`) REFERENCES `brend` (`id`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`id_top`) REFERENCES `typeofproduct` (`id`);

--
-- Ограничения внешнего ключа таблицы `purchases`
--
ALTER TABLE `purchases`
  ADD CONSTRAINT `purchases_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `purchases_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

--
-- Ограничения внешнего ключа таблицы `typeofanimal`
--
ALTER TABLE `typeofanimal`
  ADD CONSTRAINT `typeofanimal_ibfk_1` FOREIGN KEY (`id_family`) REFERENCES `familyofanimal` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
