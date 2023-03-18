-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22-Out-2022 às 03:56
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `expresso`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `faleconosco`
--

CREATE TABLE `faleconosco` (
  `id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telefone` double DEFAULT NULL,
  `Mensagem` varchar(400) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `faleconosco`
--

INSERT INTO `faleconosco` (`id`, `Nome`, `Email`, `Telefone`, `Mensagem`) VALUES
(1, 'murilo', 'murilo@gmail.com', 5959595, 'passagem');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fretamentoeturismo`
--

CREATE TABLE `fretamentoeturismo` (
  `id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Celular` double DEFAULT NULL,
  `Telefone` double DEFAULT NULL,
  `CidadeOrigem` varchar(100) DEFAULT NULL,
  `CidadeDestino` varchar(100) DEFAULT NULL,
  `DataIda` varchar(100) DEFAULT NULL,
  `DataVolta` varchar(100) DEFAULT NULL,
  `Descricao` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fretamentoeturismo`
--

INSERT INTO `fretamentoeturismo` (`id`, `Nome`, `Email`, `Celular`, `Telefone`, `CidadeOrigem`, `CidadeDestino`, `DataIda`, `DataVolta`, `Descricao`) VALUES
(1, 'murilo', 'ademarcrestani@ibest.com.br', 45454545, 56454654654, 'santiago', 'Gramado', '2022-10-28', '2022-10-29', 'saida 12:30'),
(3, 'murilo', 'ademarcrestani@ibest.com.br', 45454545, 56454654654, 'aa', 'aaa', '2022-10-22', '2022-10-28', 'saida 12:30');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacotes`
--

CREATE TABLE `pacotes` (
  `id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Origem` varchar(100) DEFAULT NULL,
  `Destino` varchar(100) DEFAULT NULL,
  `Saida` varchar(100) DEFAULT NULL,
  `Valor` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pacotes`
--

INSERT INTO `pacotes` (`id`, `Nome`, `Origem`, `Destino`, `Saida`, `Valor`) VALUES
(1, 'Santa Maria', 'Santiago', 'Santa Maria', '2022-10-31', 60),
(2, 'Porto Alegre', 'Santiago', 'Porto Alegre', '2022-10-30', 187),
(3, 'Nova Esperança do Sul', 'Santiago', 'Nova Esperança do Sul', '2022-12-09', 20);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Login` varchar(100) DEFAULT NULL,
  `Senha` varchar(100) DEFAULT NULL,
  `Conta` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `Nome`, `Login`, `Senha`, `Conta`) VALUES
(1, 'Murilo', '123', '123', 'administrador');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `faleconosco`
--
ALTER TABLE `faleconosco`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `fretamentoeturismo`
--
ALTER TABLE `fretamentoeturismo`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `pacotes`
--
ALTER TABLE `pacotes`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `faleconosco`
--
ALTER TABLE `faleconosco`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `fretamentoeturismo`
--
ALTER TABLE `fretamentoeturismo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `pacotes`
--
ALTER TABLE `pacotes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
