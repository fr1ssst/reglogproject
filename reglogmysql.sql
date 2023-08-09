-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Час створення: Сер 09 2023 р., 14:43
-- Версія сервера: 5.7.24
-- Версія PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `reglogmysql`
--

-- --------------------------------------------------------

--
-- Структура таблиці `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(16) NOT NULL,
  `surname` varchar(16) NOT NULL,
  `dateOfBirth` date NOT NULL,
  `sex` varchar(5) NOT NULL,
  `login` longtext NOT NULL,
  `password` longtext NOT NULL,
  `telephone` int(12) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп даних таблиці `users`
--

INSERT INTO `users` (`id`, `name`, `surname`, `dateOfBirth`, `sex`, `login`, `password`, `telephone`) VALUES
(1, 'Назар', 'Мельник', '2000-06-15', 'Чол.', 'admin@gmail.com', '$2a$10$H2Gi2iFmiCNGWe7zg.E1xONvBpUq36LAsplRztmb8hgyr/4e2uOHa', 338833),
(2, 'Аліна', 'Левченко', '1998-09-16', 'Жін.', 'moderator@gmail.com', '$2a$10$lesA5QTTWTvwr/GJkA1fQuIl0hUJRrcHsWh5qswrt502UerO.k19u', 337733),
(3, 'Олена', 'Корнієнко', '1995-06-22', 'Жін.', 'olenakor@gmail.com', '$2a$10$gJtSWpTcXI1/DBEf6LeHIuFOsFbhcTTwHZpu.1eUvKFw7PtJtarT2', 434354),
(4, 'Олексій', 'Агамат', '2005-02-18', 'Чол.', 'alexagamat@gmail.com', '$2a$10$huyMDOjQovKFfMO58LcS6uwVMUXjw0vo20Zam60UvJTfruisIR0su', 456834),
(5, 'Настя', 'Пчілка', '2009-07-24', 'Жін.', 'anastasiapchilka@gmail.com', '$2a$10$tdJAamv343faqLXqsP109e7YDK4564t2Pc9dPUKaj8dDdZFjhkNPm', 1235342);

--
-- Індекси збережених таблиць
--

--
-- Індекси таблиці `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для збережених таблиць
--

--
-- AUTO_INCREMENT для таблиці `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
