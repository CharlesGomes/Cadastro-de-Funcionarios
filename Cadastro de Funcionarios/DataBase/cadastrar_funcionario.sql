
--
-- Database: `cadastrar_funcionario`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `departamento`
--

CREATE TABLE IF NOT EXISTS `departamento` (
`id` int(10) NOT NULL auto_increment,
  `nome` varchar(50) NOT NULL,
 CONSTRAINT pk_departamento
    PRIMARY KEY (id)
);

--

INSERT INTO `departamento` (`id`, `nome`) VALUES
(1, 'Financeiro'),
(2, 'Compras');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE IF NOT EXISTS `funcionario` (
  `nome` varchar(50) NOT NULL,
  `cpf` double NOT NULL,
  `nasc` varchar(10) NOT NULL,
  `matricula` double NOT NULL,
  `endereco` varchar(255) NOT NULL,
  `telefone` double NOT NULL,
  `sexo` varchar(1) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `estado_civil` varchar(20) NOT NULL,
  `email` varchar(255) NOT NULL,
  `id` int(10) NOT NULL,
 CONSTRAINT pk_funcionario
    PRIMARY KEY (cpf),
CONSTRAINT fk_Departamento_Funcionario
    FOREIGN KEY (id)
    REFERENCES departamento(id)
) ;


-- Estrutura da tabela `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
`id` int(10) NOT NULL auto_increment,
  `login` varchar(25) NOT NULL,
  `senha` varchar(25) NOT NULL,
  `status` varchar(25) NOT NULL,
  `cpf` double NOT NULL,
CONSTRAINT pk_usuario
    PRIMARY KEY (id),
CONSTRAINT fk_Usuario_Funcionario
    FOREIGN KEY (cpf)
    REFERENCES funcionario(cpf)
);

