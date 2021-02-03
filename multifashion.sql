-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-02-2021 a las 00:50:12
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `multifashion`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarPedidoFinal` (IN `idpedido` INT, IN `llego` INT)  NO SQL
BEGIN
	UPDATE pedidos SET Llego = llego WHERE pedidos.IDPedido = idpedido;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarCliente` (IN `idcliente` BIGINT, IN `nombre` VARCHAR(50))  NO SQL
BEGIN
	INSERT INTO clientes(IDCliente, Nombre) VALUES (idcliente, nombre);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarMarca` (IN `idmarca` INT(11), IN `nombre` VARCHAR(50))  MODIFIES SQL DATA
BEGIN
	INSERT INTO marca VALUES(idmarca, nombre); 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarModelo` (IN `idmodelo` VARCHAR(50), IN `idmarca` BIGINT, IN `color` VARCHAR(50), IN `talla` VARCHAR(50), IN `preciocliente` DECIMAL(10,2))  NO SQL
BEGIN
	SET @var := (SELECT modelos.IDModelo FROM modelos WHERE modelos.IDModelo = idmodelo);
    IF @var = idmodelo THEN 
    	SELECT 1;
    ELSE
		INSERT INTO modelos (modelos.IDModelo, modelos.IDMarca, modelos.Color, 	modelos.Talla, modelos.PrecioCliente, modelos.Fecha) VALUES(idmodelo, idmarca, color, talla, preciocliente, NOW());
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarPedido` (IN `idpedido` VARCHAR(50), IN `idmodelo` VARCHAR(50), IN `idcliente` BIGINT, IN `color` VARCHAR(50), IN `talla` VARCHAR(50))  NO SQL
BEGIN
	SET @var1 := (SELECT COUNT(*) FROM pedidos WHERE pedidos.IDPedido = idpedido);
    IF @var1 = 1 THEN
    	UPDATE pedidos SET IDModelo = idmodelo, Color = color, Talla = talla, Fecha = NOW() WHERE pedidos.IDPedido = idpedido;
    ELSE
		INSERT INTO pedidos(IDModelo, IDCliente, Color, Talla, Fecha) VALUES
    (idmodelo, idcliente, color, talla, NOW());
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarPedidosFinal` (IN `idmodelo` VARCHAR(50), IN `idcliente` BIGINT, IN `color` INT, IN `talla` INT)  MODIFIES SQL DATA
INSERT INTO pedidos(IDModelo, IDCliente, Color, Talla, Fecha) VALUES(idmodelo, idcliente, color, talla, NOW())$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ColoresyTallas` (IN `valor` INT, IN `opcion` INT, IN `id` INT, IN `nn` VARCHAR(50))  READS SQL DATA
BEGIN
	IF valor = 1 THEN
    	IF opcion = 1 THEN
        	INSERT INTO color (color.Nombre) VALUES(nn);
        ELSEIF opcion = 2 THEN 
        	UPDATE color SET color.Nombre = nn WHERE color.IDColor = id;
       	ELSE
        	DELETE FROM color WHERE color.IDColor = id;
        END IF;
    ELSE
    	IF opcion = 1 THEN
        	INSERT INTO talla (talla.Numero) VALUES(nn);
        ELSEIF opcion = 2 THEN 
        	UPDATE talla SET talla.Numero = nn WHERE talla.IDTalla = id;
       	ELSE
        	DELETE FROM talla WHERE talla.IDTalla = id;
        END IF;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarCliente` (IN `idclienteActual` BIGINT, IN `idcliente` BIGINT, IN `nombre` VARCHAR(50))  NO SQL
BEGIN
    SET @var1 := (SELECT COUNT(*) FROM clientes WHERE clientes.IDCliente = idclienteActual);
    IF @var1 = 0 THEN 
    	UPDATE clientes SET clientes.Nombre = nombre WHERE clientes.IDCliente = idclienteActual;
    ELSE
    	UPDATE clientes SET clientes.IDCliente = idcliente, clientes.Nombre = nombre WHERE clientes.IDCliente = idclienteActual;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarMarca` (IN `idmarcaActual` BIGINT, IN `idmarca` BIGINT, IN `nombre` VARCHAR(50))  NO SQL
BEGIN
    SET @var1 := (SELECT COUNT(*) FROM marca WHERE marca.IDMarca = idmarcaActual);
    IF @var1 = 0 THEN 
    	UPDATE marca SET marca.Nombre = nombre WHERE marca.IDMarca = idmarcaActual;
    ELSE
    	UPDATE marca SET marca.IDMarca = idmarca, marca.Nombre = nombre WHERE marca.IDMarca = idmarcaActual;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarModelo` (IN `idmodeloActual` VARCHAR(50), IN `idmodelo` VARCHAR(50), IN `idmarca` BIGINT, IN `color` VARCHAR(50), IN `talla` VARCHAR(50), IN `preciocliente` DECIMAL(10,2))  NO SQL
BEGIN
	SET @var:= (SELECT COUNT(*) FROM modelos WHERE modelos.IDModelo = idmodeloActual);
    IF @var = 0 THEN
    	UPDATE modelos SET modelos.IDMarca = idmarca, modelos.Color = color, modelos.Talla = talla, modelos.PrecioCliente = preciocliente WHERE modelos.IDModelo = idmodeloActual;
    ELSE 
    	UPDATE modelos SET modelos.IDModelo = idmodelo, modelos.IDMarca = idmarca, modelos.Color = color, modelos.Talla = talla, modelos.PrecioCliente = preciocliente WHERE modelos.IDModelo = idmodeloActual;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarPedidoFinal` (IN `idmodelo` VARCHAR(50), IN `idcliente` BIGINT)  MODIFIES SQL DATA
BEGIN
	UPDATE pedidos SET Llego = 1 WHERE (IDModelo = idmodelo AND IDCliente = idcliente); 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarPedido` (IN `idpedido` BIGINT)  NO SQL
BEGIN
	DELETE FROM pedidos WHERE pedidos.IDPedido = idpedido;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `FolioExistente` (IN `idfolio` BIGINT)  NO SQL
BEGIN
	SET @var := (SELECT venta.IDFolio FROM venta WHERE venta.IDFolio = idfolio);
    IF(@var = idfolio) THEN
    	SELECT 1;
    ELSE
    	SELECT 0;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `FoliosVentas` ()  NO SQL
BEGIN
	SELECT venta.IDFolio as "ID Folio", venta.IDCliente as "ID Cliente", venta.Fecha,  CONCAT('$', FORMAT(venta.Total, 2)) as "Total" FROM venta;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VentaFolio` (IN `idfolio` BIGINT, IN `idcliente` BIGINT, IN `fecha` DATETIME, IN `total` DECIMAL(10,2))  NO SQL
BEGIN
	INSERT INTO venta(venta.IDFolio, venta.IDCliente, venta.Fecha, venta.Total) VALUES (idfolio, idcliente, fecha, total);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VentaPedido` (IN `idfolio` BIGINT, IN `idpedido` INT)  NO SQL
BEGIN
	UPDATE pedidos SET pedidos.Vendido = 1 WHERE pedidos.IDPedido = idpedido;
    INSERT INTO venta_pedidos(venta_pedidos.IDFolio, venta_pedidos.IDPedido) VALUES(idfolio, idpedido);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerClientes` ()  READS SQL DATA
BEGIN
	SELECT IDCliente, Nombre FROM clientes;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerClientesPedido` (IN `idcliente` BIGINT)  NO SQL
BEGIN
	SELECT p.IDPedido, p.IDModelo, p.Color, p.Talla FROM pedidos p WHERE p.IDCliente = idcliente;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerClientesPedidoLlego` (IN `idcliente` BIGINT)  NO SQL
BEGIN
	SELECT p.IDPedido, p.IDModelo AS 'ID Modelo', m.Nombre AS 'Marca', p.Color, p.Talla, CONCAT('$', FORMAT(mo.PrecioCliente, 2)) AS 'Precio Cliente' FROM pedidos AS p INNER JOIN modelos AS mo USING(IDModelo) INNER JOIN marca AS m USING(IDMarca) WHERE p.IDCliente = idcliente AND p.Llego = 1 AND p.Vendido = 0;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerColores` ()  READS SQL DATA
SELECT color.IDColor, color.Nombre FROM color$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerListaPedidoFinal` (IN `buscar` VARCHAR(50))  READS SQL DATA
SELECT p.IDPedido, c.IDCliente, c.Nombre, m.IDModelo, ma.Nombre as 'Marca', p.Color, p.Talla, CONCAT('$', FORMAT(m.PrecioCliente, 2)) AS 'Precio Cliente', p.Fecha, p.Llego, p.Vendido FROM pedidos p INNER JOIN clientes c ON p.IDCliente = c.IDCliente INNER JOIN modelos m ON m.IDModelo = p.IDModelo INNER JOIN marca ma ON ma.IDMarca = m.IDMarca WHERE p.IDModelo LIKE CONCAT('%', buscar, '%') ORDER BY c.IDCliente ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerMarcas` ()  BEGIN
	SELECT IDMarca, Nombre FROM marca;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerModelos` ()  NO SQL
BEGIN
	SELECT IDModelo, m.IDMarca, m.Nombre, Color, Talla, PrecioCliente, Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerModelosLimit` (IN `inicio` INT, IN `opcion` INT, IN `buscar` VARCHAR(50), IN `fecha` DATE)  READS SQL DATA
BEGIN
    IF opcion = 1 THEN
	SELECT IDModelo, m.IDMarca, m.Nombre, mo.Color, mo.Talla, CONCAT('$', FORMAT(mo.PrecioCliente, 2)) AS 'PrecioCliente', mo.Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca WHERE mo.IDModelo LIKE CONCAT ('%', buscar, '%') LIMIT inicio, 100;
    ELSE
    	SELECT IDModelo, m.IDMarca, m.Nombre, mo.Color, mo.Talla, CONCAT('$', FORMAT(mo.PrecioCliente, 2)) AS 'PrecioCliente', mo.Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca WHERE CAST(mo.Fecha AS DATE) = fecha LIMIT inicio, 100;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerTallas` ()  READS SQL DATA
SELECT talla.IDTalla, talla.Numero FROM talla$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerVentaPedidoModelo` (IN `idfolio` INT)  NO SQL
BEGIN
	SELECT p.IDPedido, m.IDModelo, m.IDMarca, m.Color, m.Talla, m.PrecioCliente FROM ((venta_pedidos vp INNER JOIN pedidos p ON vp.IDPedido = p.IDPedido) INNER JOIN modelos m ON m.IDModelo = p.IDModelo) WHERE vp.IDFolio = idfolio;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `IDCliente` bigint(20) NOT NULL,
  `Nombre` varchar(29) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`IDCliente`, `Nombre`, `Telefono`) VALUES
(1, 'ANA LAURA GUZMAN', ''),
(2, 'RAQUEL MENDOZA', ''),
(3, 'ANGELES CHAVEZ', ''),
(4, 'CRISTINA AVILA', ''),
(5, 'KARINA CHAVEZ MORFIN', ''),
(6, 'BLANCA ESTHELA CHAVEZ', ''),
(7, 'CARMEN LOPEZ', ''),
(8, 'AURELIA VALENCIA', ''),
(9, 'EDUARDO PEÑA', ''),
(10, 'CECILIA MORFIN MUNGUIA', ''),
(11, 'JUANA ALVAREZ GARCIA', ''),
(12, 'ANDREA FIGUEROA', ''),
(13, 'IRENE MONTES', ''),
(14, 'JOSEFINA BARRAGAN', ''),
(15, 'KARINA OCEGUERA', ''),
(16, 'MA. ELENA TORRES', ''),
(17, 'MARGARITA BARRAGAN', ''),
(18, 'MARIA GONZALEZ', ''),
(19, 'MARIA GPE. GARCIA N.', ''),
(20, 'MARIA RUIZ', ''),
(21, 'MARIA RUIZ', ''),
(22, 'MARICELA OROZCO', ''),
(23, 'CECILIA RUIZ', ''),
(24, 'SILVIA SANDOVAL', ''),
(25, 'A.YANETH MENDOZA', ''),
(26, 'SANDRA IBARRA', ''),
(27, 'VICTORIA CHAVEZ', ''),
(28, 'YOLANDA GERRERO', ''),
(29, 'ROCIO SANCHEZ', ''),
(30, 'VIRIDIANA MANZO', ''),
(31, 'ARACELI TORRES', ''),
(32, 'CARLA INES CEJA', ''),
(33, 'LUZ ELENA VALENCIA', ''),
(34, 'MAYRA A. MORFIN', ''),
(35, 'MARTA CERVANTES HERRERA', ''),
(36, 'TERESA VALENCIA', ''),
(37, 'MARIA CEJA', ''),
(38, 'HILDA MORFIN', ''),
(39, 'ANDREA MALDONADO', ''),
(40, 'LIDIA ESPINOZA', ''),
(41, 'MA. DE JESUS SANCHEZ', ''),
(42, 'BLANCA VARGAS CHAVEZ', ''),
(43, 'MONICA LUA', ''),
(44, 'ANGELES APOLINAR', ''),
(45, 'MA. ELENA BARAJAS', ''),
(46, 'GRISELDA CHAVEZ ESPINOZA', ''),
(47, 'MARIA CELI GONZALEZ G.', ''),
(48, 'MARIA ELENA FLORES', ''),
(49, 'EVA MARTINEZ', ''),
(50, 'MARTHA SANCHEZ', ''),
(51, 'HERMINIA CHAVEZ', ''),
(52, 'LUCELY VILCHES', ''),
(53, 'MAYRA PULIDO', ''),
(54, 'GUADALUPE RINCON', ''),
(55, 'YESICA MORALES', ''),
(56, 'SILVIA MENDOZA', ''),
(57, 'GUADALUPE GARCIA', ''),
(58, 'LETY', ''),
(59, 'MARISOL CHAVEZ', ''),
(60, 'GRISELDA GAYTAN', ''),
(61, 'ELVIA ROCIO MALFAVON', ''),
(62, 'PILAR MENDOZA', ''),
(63, 'GONZALO CHAVEZ', ''),
(64, 'CECILIA CEJA', ''),
(65, 'ESPERANZA ALVAREZ', ''),
(66, 'BERTHA GUZMAN', ''),
(67, 'VANESSA FIGUEROA', ''),
(68, 'ANGELICA CARDENAS', ''),
(69, 'MAURA GALLARDO', ''),
(70, 'ELIZABETH ESTRADA', ''),
(72, 'ANA ISABEL AVILA', ''),
(73, 'ANTONIO GUDIÑO SANCHEZ CARTON', ''),
(74, 'MA. DEL RAYO ACEVES', ''),
(78, 'ESTEFANY MADRIGAL TORRES', ''),
(80, 'MIREYA MENDOZA', ''),
(81, 'NELLELI CHAVEZ', ''),
(82, 'MARIA DE JESUS BUCIO', ''),
(85, 'ANGELICA MENDOZA', ''),
(86, 'EVA VILCHEZ', ''),
(87, 'JUANA GARCIA SANCHEZ', ''),
(93, 'NORMA VALDOVINOS', ''),
(100, 'TERESA ', NULL),
(101, 'OSCAR', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `color`
--

CREATE TABLE `color` (
  `IDColor` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `color`
--

INSERT INTO `color` (`IDColor`, `Nombre`) VALUES
(24, 'AZUL'),
(25, 'MORADO'),
(26, 'ROJO'),
(27, 'RUBY'),
(28, 'AMARILLLO'),
(29, 'TURQUESA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion`
--

CREATE TABLE `devolucion` (
  `IDDevolucion` bigint(20) NOT NULL,
  `IDPedido` bigint(20) NOT NULL,
  `Fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `IDMarca` bigint(20) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`IDMarca`, `Nombre`) VALUES
(1, 'ANDREA'),
(2, 'CKLASS'),
(3, 'TERRA'),
(6, 'VICKY FORM'),
(7, 'MODACLUB');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modelos`
--

CREATE TABLE `modelos` (
  `IDModelo` varchar(50) NOT NULL,
  `IDMarca` bigint(20) NOT NULL,
  `Color` varchar(50) DEFAULT NULL,
  `Talla` varchar(50) DEFAULT NULL,
  `PrecioCliente` decimal(10,2) DEFAULT NULL,
  `PrecioPublico` decimal(10,2) DEFAULT NULL,
  `Fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modelos`
--

INSERT INTO `modelos` (`IDModelo`, `IDMarca`, `Color`, `Talla`, `PrecioCliente`, `PrecioPublico`, `Fecha`) VALUES
('1', 2, 'MENGUATE', '26', '100.00', NULL, '2020-10-15 11:03:09'),
('100', 7, 'AZUL', '22', '500.00', NULL, '2020-10-13 23:35:14'),
('10001', 7, 'MERLOT', '22 AL 26', '459.50', NULL, '2020-10-04 18:19:49'),
('10002', 7, 'AZUL', '25', '460.50', NULL, '2020-10-04 18:19:51'),
('10009', 7, 'NEGRO', '23 AL 26', '551.50', NULL, '2020-10-04 18:19:49'),
('101', 7, 'AMARILLO', '23', '516.55', NULL, '2020-10-13 23:35:15'),
('102', 7, 'NEGRO', '24', '533.10', NULL, '2020-10-13 23:35:15'),
('103', 7, 'VIOLETA', '25', '549.65', NULL, '2020-10-13 23:35:15'),
('104', 7, 'AZUL', 'M', '566.20', NULL, '2020-10-13 23:35:15'),
('105', 7, 'AMARILLO', 'CH', '582.75', NULL, '2020-10-13 23:35:15'),
('106', 7, 'NEGRO', 'T', '599.30', NULL, '2020-10-13 23:35:15'),
('107', 7, 'VIOLETA', 'XG', '615.85', NULL, '2020-10-13 23:35:15'),
('108', 7, 'AZUL', '22', '632.40', NULL, '2020-10-13 23:35:15'),
('109', 7, 'AMARILLO', '23', '648.95', NULL, '2020-10-13 23:35:15'),
('110', 7, 'NEGRO', '24', '665.50', NULL, '2020-10-13 23:35:15'),
('111', 7, 'VIOLETA', '25', '682.05', NULL, '2020-10-13 23:35:15'),
('112', 7, 'AZUL', 'M', '698.60', NULL, '2020-10-13 23:35:15'),
('113', 7, 'AMARILLO', 'CH', '715.15', NULL, '2020-10-13 23:35:15'),
('114', 7, 'NEGRO', 'T', '731.70', NULL, '2020-10-13 23:35:15'),
('115', 7, 'VIOLETA', 'XG', '748.25', NULL, '2020-10-13 23:35:15'),
('116', 7, 'AZUL', '22', '764.80', NULL, '2020-10-13 23:35:15'),
('117', 7, 'AMARILLO', '23', '781.35', NULL, '2020-10-13 23:35:15'),
('118', 3, 'NEGRO', '24', '4000.00', NULL, '2020-10-13 23:35:15'),
('119', 7, 'VIOLETA', '25', '814.45', NULL, '2020-10-13 23:35:15'),
('12', 6, '', '', '0.00', NULL, '2021-01-15 10:25:17'),
('120', 7, 'AZUL', 'M', '831.00', NULL, '2020-10-13 23:35:15'),
('121', 7, 'AMARILLO', 'CH', '847.55', NULL, '2020-10-13 23:35:16'),
('122', 7, 'NEGRO', 'T', '864.10', NULL, '2020-10-13 23:35:16'),
('123', 7, 'VIOLETA', 'XG', '880.65', NULL, '2020-10-13 23:35:16'),
('124', 7, 'AZUL', '22', '897.20', NULL, '2020-10-13 23:35:16'),
('125', 7, 'AMARILLO', '23', '913.75', NULL, '2020-10-13 23:35:16'),
('126', 7, 'NEGRO', '24', '930.30', NULL, '2020-10-13 23:35:16'),
('127', 7, 'VIOLETA', '25', '946.85', NULL, '2020-10-13 23:35:16'),
('128', 7, 'AZUL', 'M', '963.40', NULL, '2020-10-13 23:35:16'),
('129', 7, 'AMARILLO', 'CH', '979.95', NULL, '2020-10-13 23:35:16'),
('130', 7, 'NEGRO', 'T', '996.50', NULL, '2020-10-13 23:35:16'),
('131', 7, 'VIOLETA', 'XG', '1013.05', NULL, '2020-10-13 23:35:16'),
('132', 7, 'AZUL', '22', '1029.60', NULL, '2020-10-13 23:35:16'),
('133', 7, 'AMARILLO', '23', '1046.15', NULL, '2020-10-13 23:35:16'),
('134', 7, 'NEGRO', '24', '1062.70', NULL, '2020-10-13 23:35:16'),
('135', 7, 'VIOLETA', '25', '1079.25', NULL, '2020-10-13 23:35:16'),
('136', 7, 'AZUL', 'M', '1095.80', NULL, '2020-10-13 23:35:16'),
('137', 7, 'AMARILLO', 'CH', '1112.35', NULL, '2020-10-13 23:35:16'),
('138', 7, 'NEGRO', 'T', '1128.90', NULL, '2020-10-13 23:35:16'),
('139', 7, 'VIOLETA', 'XG', '1145.45', NULL, '2020-10-13 23:35:16'),
('140', 7, 'AZUL', '22', '1162.00', NULL, '2020-10-13 23:35:16'),
('141', 7, 'AMARILLO', '23', '1178.55', NULL, '2020-10-13 23:35:16'),
('142', 7, 'NEGRO', '24', '1195.10', NULL, '2020-10-13 23:35:16'),
('143', 7, 'VIOLETA', '25', '1211.65', NULL, '2020-10-13 23:35:16'),
('144', 7, 'AZUL', 'M', '1228.20', NULL, '2020-10-13 23:35:16'),
('145', 7, 'AMARILLO', 'CH', '1244.75', NULL, '2020-10-13 23:35:16'),
('146', 7, 'NEGRO', 'T', '1261.30', NULL, '2020-10-13 23:35:16'),
('147', 7, 'VIOLETA', 'XG', '1277.85', NULL, '2020-10-13 23:35:17'),
('148', 7, 'AZUL', '22', '1294.40', NULL, '2020-10-13 23:35:17'),
('149', 7, 'AMARILLO', '23', '1310.95', NULL, '2020-10-13 23:35:17'),
('150', 7, 'NEGRO', '24', '1327.50', NULL, '2020-10-13 23:35:17'),
('151', 7, 'VIOLETA', '25', '1344.05', NULL, '2020-10-13 23:35:17'),
('152', 7, 'AZUL', 'M', '1360.60', NULL, '2020-10-13 23:35:17'),
('153', 7, 'AMARILLO', 'CH', '1377.15', NULL, '2020-10-13 23:35:17'),
('154', 7, 'NEGRO', 'T', '1393.70', NULL, '2020-10-13 23:35:17'),
('155', 7, 'VIOLETA', 'XG', '1410.25', NULL, '2020-10-13 23:35:17'),
('156', 7, 'AZUL', '22', '1426.80', NULL, '2020-10-13 23:35:17'),
('157', 7, 'AMARILLO', '23', '1443.35', NULL, '2020-10-13 23:35:17'),
('158', 7, 'NEGRO', '24', '1459.90', NULL, '2020-10-13 23:35:17'),
('159', 7, 'VIOLETA', '25', '1476.45', NULL, '2020-10-13 23:35:17'),
('160', 7, 'AZUL', 'M', '1493.00', NULL, '2020-10-13 23:35:17'),
('161', 7, 'AMARILLO', 'CH', '1509.55', NULL, '2020-10-13 23:35:17'),
('162', 7, 'NEGRO', 'T', '1526.10', NULL, '2020-10-13 23:35:17'),
('163', 7, 'VIOLETA', 'XG', '1542.65', NULL, '2020-10-13 23:35:17'),
('164', 7, 'AZUL', '22', '1559.20', NULL, '2020-10-13 23:35:17'),
('165', 7, 'AMARILLO', '23', '1575.75', NULL, '2020-10-13 23:35:17'),
('166', 7, 'NEGRO', '24', '1592.30', NULL, '2020-10-13 23:35:17'),
('167', 7, 'VIOLETA', '25', '1608.85', NULL, '2020-10-13 23:35:17'),
('168', 7, 'AZUL', 'M', '1625.40', NULL, '2020-10-13 23:35:18'),
('169', 7, 'AMARILLO', 'CH', '1641.95', NULL, '2020-10-13 23:35:18'),
('170', 7, 'NEGRO', 'T', '1658.50', NULL, '2020-10-13 23:35:18'),
('171', 7, 'VIOLETA', 'XG', '1675.05', NULL, '2020-10-13 23:35:18'),
('172', 7, 'AZUL', '22', '1691.60', NULL, '2020-10-13 23:35:18'),
('173', 7, 'AMARILLO', '23', '1708.15', NULL, '2020-10-13 23:35:18'),
('174', 7, 'NEGRO', '24', '1724.70', NULL, '2020-10-13 23:35:18'),
('175', 7, 'VIOLETA', '25', '1741.25', NULL, '2020-10-13 23:35:18'),
('176', 7, 'AZUL', 'M', '1757.80', NULL, '2020-10-13 23:35:18'),
('177', 7, 'AMARILLO', 'CH', '1774.35', NULL, '2020-10-13 23:35:19'),
('178', 7, 'NEGRO', 'T', '1790.90', NULL, '2020-10-13 23:35:19'),
('179', 7, 'VIOLETA', 'XG', '1807.45', NULL, '2020-10-13 23:35:19'),
('180', 7, 'AZUL', '22', '1824.00', NULL, '2020-10-13 23:35:19'),
('181', 7, 'AMARILLO', '23', '1840.55', NULL, '2020-10-13 23:35:19'),
('182', 7, 'NEGRO', '24', '1857.10', NULL, '2020-10-13 23:35:20'),
('183', 7, 'VIOLETA', '25', '1873.65', NULL, '2020-10-13 23:35:20'),
('184', 7, 'AZUL', 'M', '1890.20', NULL, '2020-10-13 23:35:20'),
('185', 7, 'AMARILLO', 'CH', '1906.75', NULL, '2020-10-13 23:35:20'),
('186', 7, 'NEGRO', 'T', '1923.30', NULL, '2020-10-13 23:35:20'),
('187', 7, 'VIOLETA', 'XG', '1939.85', NULL, '2020-10-13 23:35:20'),
('188', 7, 'AZUL', '22', '1956.40', NULL, '2020-10-13 23:35:20'),
('189', 7, 'AMARILLO', '23', '1972.95', NULL, '2020-10-13 23:35:20'),
('190', 7, 'NEGRO', '24', '1989.50', NULL, '2020-10-13 23:35:20'),
('191', 7, 'VIOLETA', '25', '2006.05', NULL, '2020-10-13 23:35:20'),
('192', 7, 'AZUL', 'M', '2022.60', NULL, '2020-10-13 23:35:20'),
('193', 7, 'AMARILLO', 'CH', '2039.15', NULL, '2020-10-13 23:35:20'),
('194', 7, 'NEGRO', 'T', '2055.70', NULL, '2020-10-13 23:35:20'),
('195', 7, 'VIOLETA', 'XG', '2072.25', NULL, '2020-10-13 23:35:20'),
('196', 7, 'AZUL', '22', '2088.80', NULL, '2020-10-13 23:35:21'),
('197', 7, 'AMARILLO', '23', '2105.35', NULL, '2020-10-13 23:35:21'),
('198', 7, 'NEGRO', '24', '2121.90', NULL, '2020-10-13 23:35:21'),
('199', 7, 'VIOLETA', '25', '2138.45', NULL, '2020-10-13 23:35:21'),
('2', 1, 'NEGRO/AZUL', '22', '750.00', NULL, '2020-10-12 09:34:28'),
('200', 7, 'AZUL', 'M', '2155.00', NULL, '2020-10-13 23:35:21'),
('201', 7, 'AMARILLO', 'CH', '2171.55', NULL, '2020-10-13 23:35:21'),
('202', 7, 'NEGRO', 'T', '2188.10', NULL, '2020-10-13 23:35:21'),
('203', 7, 'VIOLETA', 'XG', '2204.65', NULL, '2020-10-13 23:35:21'),
('204', 7, 'AZUL', '22', '2221.20', NULL, '2020-10-13 23:35:21'),
('205', 7, 'AMARILLO', '23', '2237.75', NULL, '2020-10-13 23:35:21'),
('206', 7, 'NEGRO', '24', '2254.30', NULL, '2020-10-13 23:35:21'),
('207', 7, 'VIOLETA', '25', '2270.85', NULL, '2020-10-13 23:35:21'),
('208', 7, 'AZUL', 'M', '2287.40', NULL, '2020-10-13 23:35:21'),
('209', 7, 'AMARILLO', 'CH', '2303.95', NULL, '2020-10-13 23:35:21'),
('210', 7, 'NEGRO', 'T', '2320.50', NULL, '2020-10-13 23:35:21'),
('211', 7, 'VIOLETA', 'XG', '2337.05', NULL, '2020-10-13 23:35:21'),
('212', 7, 'AZUL', '22', '2353.60', NULL, '2020-10-13 23:35:21'),
('213', 7, 'AMARILLO', '23', '2370.15', NULL, '2020-10-13 23:35:21'),
('214', 7, 'NEGRO', '24', '2386.70', NULL, '2020-10-13 23:35:21'),
('215', 7, 'VIOLETA', '25', '2403.25', NULL, '2020-10-13 23:35:21'),
('216', 7, 'AZUL', 'M', '2419.80', NULL, '2020-10-13 23:35:22'),
('217', 7, 'AMARILLO', 'CH', '2436.35', NULL, '2020-10-13 23:35:22'),
('218', 7, 'NEGRO', 'T', '2452.90', NULL, '2020-10-13 23:35:22'),
('219', 7, 'VIOLETA', 'XG', '2469.45', NULL, '2020-10-13 23:35:22'),
('220', 7, 'AZUL', '22', '2486.00', NULL, '2020-10-13 23:35:22'),
('221', 7, 'AMARILLO', '23', '2502.55', NULL, '2020-10-13 23:35:22'),
('222', 7, 'NEGRO', '24', '2519.10', NULL, '2020-10-13 23:35:22'),
('223', 7, 'VIOLETA', '25', '2535.65', NULL, '2020-10-13 23:35:22'),
('224', 7, 'AZUL', 'M', '2552.20', NULL, '2020-10-13 23:35:22'),
('225', 7, 'AMARILLO', 'CH', '2568.75', NULL, '2020-10-13 23:35:22'),
('226', 7, 'NEGRO', 'T', '2585.30', NULL, '2020-10-13 23:35:22'),
('227', 7, 'VIOLETA', 'XG', '2601.85', NULL, '2020-10-13 23:35:22'),
('228', 7, 'AZUL', '22', '2618.40', NULL, '2020-10-13 23:35:22'),
('229', 7, 'AMARILLO', '23', '2634.95', NULL, '2020-10-13 23:35:22'),
('230', 7, 'NEGRO', '24', '2651.50', NULL, '2020-10-13 23:35:22'),
('231', 7, 'VIOLETA', '25', '2668.05', NULL, '2020-10-13 23:35:22'),
('232', 7, 'AZUL', 'M', '2684.60', NULL, '2020-10-13 23:35:22'),
('233', 7, 'AMARILLO', 'CH', '2701.15', NULL, '2020-10-13 23:35:22'),
('234', 7, 'NEGRO', 'T', '2717.70', NULL, '2020-10-13 23:35:22'),
('235', 7, 'VIOLETA', 'XG', '2734.25', NULL, '2020-10-13 23:35:22'),
('236', 7, 'AZUL', '22', '2750.80', NULL, '2020-10-13 23:35:22'),
('237', 7, 'AMARILLO', '23', '2767.35', NULL, '2020-10-13 23:35:22'),
('238', 7, 'NEGRO', '24', '2783.90', NULL, '2020-10-13 23:35:22'),
('239', 7, 'VIOLETA', '25', '2800.45', NULL, '2020-10-13 23:35:22'),
('240', 7, 'AZUL', 'M', '2817.00', NULL, '2020-10-13 23:35:23'),
('241', 7, 'AMARILLO', 'CH', '2833.55', NULL, '2020-10-13 23:35:23'),
('242', 7, 'NEGRO', 'T', '2850.10', NULL, '2020-10-13 23:35:23'),
('243', 7, 'VIOLETA', 'XG', '2866.65', NULL, '2020-10-13 23:35:23'),
('244', 7, 'AZUL', '22', '2883.20', NULL, '2020-10-13 23:35:23'),
('245', 7, 'AMARILLO', '23', '2899.75', NULL, '2020-10-13 23:35:23'),
('246', 7, 'NEGRO', '24', '2916.30', NULL, '2020-10-13 23:35:23'),
('247', 7, 'VIOLETA', '25', '2932.85', NULL, '2020-10-13 23:35:23'),
('248', 7, 'AZUL', 'M', '2949.40', NULL, '2020-10-13 23:35:23'),
('249', 7, 'AMARILLO', 'CH', '2965.95', NULL, '2020-10-13 23:35:23'),
('25', 7, 'MERLOT', '22 AL 27  ENTEROS', '459.50', NULL, '2020-10-04 18:19:49'),
('250', 7, 'NEGRO', 'T', '2982.50', NULL, '2020-10-13 23:35:23'),
('251', 7, 'VIOLETA', 'XG', '2999.05', NULL, '2020-10-13 23:35:23'),
('252', 7, 'AZUL', '22', '3015.60', NULL, '2020-10-13 23:35:23'),
('253', 7, 'AMARILLO', '23', '3032.15', NULL, '2020-10-13 23:35:23'),
('254', 7, 'NEGRO', '23 AL 26', '574.50', NULL, '2020-10-04 18:19:49'),
('255', 7, 'VIOLETA', '25', '3065.25', NULL, '2020-10-13 23:35:26'),
('256', 7, 'AZUL', 'M', '3081.80', NULL, '2020-10-13 23:35:26'),
('257', 7, 'AMARILLO', 'CH', '3098.35', NULL, '2020-10-13 23:35:26'),
('258', 7, 'NEGRO', 'T', '3114.90', NULL, '2020-10-13 23:35:26'),
('259', 7, 'VIOLETA', 'XG', '3131.45', NULL, '2020-10-13 23:35:26'),
('260', 7, 'AZUL', '22', '3148.00', NULL, '2020-10-13 23:35:26'),
('261', 7, 'AMARILLO', '23', '3164.55', NULL, '2020-10-13 23:35:26'),
('262', 7, 'NEGRO', '24', '3181.10', NULL, '2020-10-13 23:35:26'),
('263', 7, 'VIOLETA', '25', '3197.65', NULL, '2020-10-13 23:35:26'),
('264', 7, 'AZUL', 'M', '3214.20', NULL, '2020-10-13 23:35:26'),
('265', 7, 'AMARILLO', 'CH', '3230.75', NULL, '2020-10-13 23:35:26'),
('266', 7, 'NEGRO', 'T', '3247.30', NULL, '2020-10-13 23:35:26'),
('267', 7, 'VIOLETA', 'XG', '3263.85', NULL, '2020-10-13 23:35:27'),
('268', 7, 'AZUL', '22', '3280.40', NULL, '2020-10-13 23:35:27'),
('269', 7, 'AMARILLO', '23', '3296.95', NULL, '2020-10-13 23:35:27'),
('270', 7, 'NEGRO', '24', '3313.50', NULL, '2020-10-13 23:35:27'),
('271', 7, 'VIOLETA', '25', '3330.05', NULL, '2020-10-13 23:35:27'),
('272', 7, 'AZUL', 'M', '3346.60', NULL, '2020-10-13 23:35:27'),
('273', 7, 'AMARILLO', 'CH', '3363.15', NULL, '2020-10-13 23:35:27'),
('274', 7, 'NEGRO', 'T', '3379.70', NULL, '2020-10-13 23:35:27'),
('275', 7, 'VIOLETA', 'XG', '3396.25', NULL, '2020-10-13 23:35:27'),
('276', 7, 'AZUL', '22', '3412.80', NULL, '2020-10-13 23:35:27'),
('277', 7, 'AMARILLO', '23', '3429.35', NULL, '2020-10-13 23:35:27'),
('278', 7, 'NEGRO', '24', '3445.90', NULL, '2020-10-13 23:35:27'),
('279', 7, 'VIOLETA', '25', '3462.45', NULL, '2020-10-13 23:35:27'),
('280', 7, 'AZUL', 'M', '3479.00', NULL, '2020-10-13 23:35:27'),
('281', 7, 'AMARILLO', 'CH', '3495.55', NULL, '2020-10-13 23:35:27'),
('282', 7, 'NEGRO', 'T', '3512.10', NULL, '2020-10-13 23:35:27'),
('283', 7, 'VIOLETA', 'XG', '3528.65', NULL, '2020-10-13 23:35:27'),
('284', 7, 'AZUL', '22', '3545.20', NULL, '2020-10-13 23:35:27'),
('285', 7, 'AMARILLO', '23', '3561.75', NULL, '2020-10-13 23:35:27'),
('286', 7, 'NEGRO', '24', '3578.30', NULL, '2020-10-13 23:35:27'),
('287', 7, 'VIOLETA', '25', '3594.85', NULL, '2020-10-13 23:35:27'),
('288', 7, 'AZUL', 'M', '3611.40', NULL, '2020-10-13 23:35:27'),
('289', 7, 'AMARILLO', 'CH', '3627.95', NULL, '2020-10-13 23:35:27'),
('290', 6, 'NEGRO', 'T', '0.00', NULL, '2020-10-13 23:35:27'),
('291', 3, 'VIOLETA', 'XG', '0.00', NULL, '2020-10-13 23:35:27'),
('292', 7, 'AZUL', '22', '3677.60', NULL, '2020-10-13 23:35:27'),
('293', 7, 'AMARILLO', '23', '3694.15', NULL, '2020-10-13 23:35:27'),
('294', 7, 'NEGRO', '24', '3710.70', NULL, '2020-10-13 23:35:28'),
('295', 7, 'VIOLETA', '25', '3727.25', NULL, '2020-10-13 23:35:28'),
('296', 7, 'AZUL', 'M', '3743.80', NULL, '2020-10-13 23:35:28'),
('297', 7, 'AMARILLO', 'CH', '3760.35', NULL, '2020-10-13 23:35:28'),
('298', 7, 'NEGRO', 'T', '3776.90', NULL, '2020-10-13 23:35:28'),
('299', 7, 'VIOLETA', 'XG', '3793.45', NULL, '2020-10-13 23:35:28'),
('3', 3, 'MARINO', '22', '392.50', NULL, '2020-10-13 23:04:43'),
('300', 7, 'AZUL', '22', '3810.00', NULL, '2020-10-13 23:35:28'),
('301', 7, 'AMARILLO', '23', '3826.55', NULL, '2020-10-13 23:35:28'),
('302', 7, 'NEGRO', '24', '3843.10', NULL, '2020-10-13 23:35:28'),
('303', 7, 'VIOLETA', '25', '3859.65', NULL, '2020-10-13 23:35:28'),
('304', 7, 'AZUL', 'M', '3876.20', NULL, '2020-10-13 23:35:28'),
('305', 7, 'AMARILLO', 'CH', '3892.75', NULL, '2020-10-13 23:35:28'),
('306', 7, 'NEGRO', 'T', '3909.30', NULL, '2020-10-13 23:35:28'),
('307', 7, 'VIOLETA', 'XG', '3925.85', NULL, '2020-10-13 23:35:28'),
('308', 7, 'AZUL', '22', '3942.40', NULL, '2020-10-13 23:35:28'),
('309', 7, 'AMARILLO', '23', '3958.95', NULL, '2020-10-13 23:35:28'),
('310', 7, 'NEGRO', '24', '3975.50', NULL, '2020-10-13 23:35:28'),
('311', 7, 'VIOLETA', '25', '3992.05', NULL, '2020-10-13 23:35:28'),
('312', 7, 'AZUL', 'M', '4008.60', NULL, '2020-10-13 23:35:28'),
('313', 7, 'AMARILLO', 'CH', '4025.15', NULL, '2020-10-13 23:35:28'),
('314', 7, 'NEGRO', 'T', '4041.70', NULL, '2020-10-13 23:35:28'),
('315', 7, 'VIOLETA', 'XG', '4058.25', NULL, '2020-10-13 23:35:28'),
('316', 7, 'AZUL', '22', '4074.80', NULL, '2020-10-13 23:35:28'),
('317', 7, 'AMARILLO', '23', '4091.35', NULL, '2020-10-13 23:35:28'),
('318', 7, 'NEGRO', '24', '4107.90', NULL, '2020-10-13 23:35:28'),
('319', 7, 'VIOLETA', '25', '4124.45', NULL, '2020-10-13 23:35:28'),
('320', 7, 'AZUL', 'M', '4141.00', NULL, '2020-10-13 23:35:29'),
('321', 7, 'AMARILLO', 'CH', '4157.55', NULL, '2020-10-13 23:35:29'),
('322', 7, 'NEGRO', 'T', '4174.10', NULL, '2020-10-13 23:35:29'),
('323', 7, 'VIOLETA', 'XG', '4190.65', NULL, '2020-10-13 23:35:29'),
('324', 7, 'AZUL', '22', '4207.20', NULL, '2020-10-13 23:35:29'),
('325', 7, 'AMARILLO', '23', '4223.75', NULL, '2020-10-13 23:35:29'),
('326', 7, 'NEGRO', '24', '4240.30', NULL, '2020-10-13 23:35:29'),
('327', 7, 'VIOLETA', '25', '4256.85', NULL, '2020-10-13 23:35:29'),
('328', 7, 'AZUL', 'M', '4273.40', NULL, '2020-10-13 23:35:29'),
('329', 7, 'AMARILLO', 'CH', '4289.95', NULL, '2020-10-13 23:35:29'),
('330', 7, 'NEGRO', 'T', '4306.50', NULL, '2020-10-13 23:35:29'),
('331', 7, 'VIOLETA', 'XG', '4323.05', NULL, '2020-10-13 23:35:29'),
('332', 7, 'AZUL', '22', '4339.60', NULL, '2020-10-13 23:35:29'),
('333', 7, 'AMARILLO', '23', '4356.15', NULL, '2020-10-13 23:35:29'),
('334', 7, 'NEGRO', '24', '4372.70', NULL, '2020-10-13 23:35:29'),
('335', 7, 'VIOLETA', '25', '4389.25', NULL, '2020-10-13 23:35:29'),
('336', 7, 'AZUL', 'M', '4405.80', NULL, '2020-10-13 23:35:29'),
('337', 7, 'AMARILLO', 'CH', '4422.35', NULL, '2020-10-13 23:35:29'),
('338', 7, 'NEGRO', 'T', '4438.90', NULL, '2020-10-13 23:35:29'),
('339', 7, 'VIOLETA', 'XG', '4455.45', NULL, '2020-10-13 23:35:29'),
('340', 7, 'AZUL', '22', '4472.00', NULL, '2020-10-13 23:35:29'),
('341', 7, 'AMARILLO', '23', '4488.55', NULL, '2020-10-13 23:35:29'),
('342', 7, 'NEGRO', '24', '4505.10', NULL, '2020-10-13 23:35:29'),
('343', 7, 'VIOLETA', '25', '4521.65', NULL, '2020-10-13 23:35:29'),
('344', 7, 'AZUL', 'M', '4538.20', NULL, '2020-10-13 23:35:29'),
('345', 7, 'AMARILLO', 'CH', '4554.75', NULL, '2020-10-13 23:35:29'),
('346', 7, 'NEGRO', 'T', '4571.30', NULL, '2020-10-13 23:35:30'),
('347', 7, 'VIOLETA', 'XG', '4587.85', NULL, '2020-10-13 23:35:30'),
('348', 7, 'AZUL', '22', '4604.40', NULL, '2020-10-13 23:35:30'),
('349', 7, 'AMARILLO', '23', '4620.95', NULL, '2020-10-13 23:35:30'),
('35', 3, 'MARINO', '25', '200.00', NULL, '2020-10-13 23:19:05'),
('350', 7, 'NEGRO', '24', '4637.50', NULL, '2020-10-13 23:35:30'),
('351', 7, 'VIOLETA', '25', '4654.05', NULL, '2020-10-13 23:35:30'),
('352', 7, 'AZUL', 'M', '4670.60', NULL, '2020-10-13 23:35:30'),
('353', 7, 'AMARILLO', 'CH', '4687.15', NULL, '2020-10-13 23:35:30'),
('354', 7, 'NEGRO', 'T', '4703.70', NULL, '2020-10-13 23:35:30'),
('355', 7, 'VIOLETA', 'XG', '4720.25', NULL, '2020-10-13 23:35:30'),
('356', 7, 'AZUL', '22', '4736.80', NULL, '2020-10-13 23:35:30'),
('357', 7, 'AMARILLO', '23', '4753.35', NULL, '2020-10-13 23:35:30'),
('358', 7, 'NEGRO', '24', '4769.90', NULL, '2020-10-13 23:35:30'),
('359', 7, 'VIOLETA', '25', '4786.45', NULL, '2020-10-13 23:35:30'),
('360', 7, 'AZUL', 'M', '4803.00', NULL, '2020-10-13 23:35:30'),
('361', 7, 'AMARILLO', 'CH', '4819.55', NULL, '2020-10-13 23:35:30'),
('362', 7, 'NEGRO', 'T', '4836.10', NULL, '2020-10-13 23:35:30'),
('363', 7, 'VIOLETA', 'XG', '4852.65', NULL, '2020-10-13 23:35:30'),
('364', 7, 'AZUL', '22', '4869.20', NULL, '2020-10-13 23:35:30'),
('365', 7, 'AMARILLO', '23', '4885.75', NULL, '2020-10-13 23:35:30'),
('366', 7, 'NEGRO', '24', '4902.30', NULL, '2020-10-13 23:35:30'),
('367', 7, 'VIOLETA', '25', '4918.85', NULL, '2020-10-13 23:35:30'),
('368', 7, 'AZUL', 'M', '4935.40', NULL, '2020-10-13 23:35:30'),
('369', 7, 'AMARILLO', 'CH', '4951.95', NULL, '2020-10-13 23:35:31'),
('370', 7, 'NEGRO', 'T', '4968.50', NULL, '2020-10-13 23:35:31'),
('371', 7, 'VIOLETA', 'XG', '4985.05', NULL, '2020-10-13 23:35:31'),
('372', 7, 'AZUL', '22', '5001.60', NULL, '2020-10-13 23:35:31'),
('373', 7, 'AMARILLO', '23', '5018.15', NULL, '2020-10-13 23:35:31'),
('374', 7, 'NEGRO', '24', '5034.70', NULL, '2020-10-13 23:35:31'),
('375', 7, 'VIOLETA', '25', '5051.25', NULL, '2020-10-13 23:35:31'),
('376', 7, 'AZUL', 'M', '5067.80', NULL, '2020-10-13 23:35:31'),
('377', 7, 'AMARILLO', 'CH', '5084.35', NULL, '2020-10-13 23:35:31'),
('378', 7, 'NEGRO', 'T', '5100.90', NULL, '2020-10-13 23:35:31'),
('379', 7, 'VIOLETA', 'XG', '5117.45', NULL, '2020-10-13 23:35:31'),
('380', 7, 'AZUL', '22', '5134.00', NULL, '2020-10-13 23:35:31'),
('381', 7, 'AMARILLO', '23', '5150.55', NULL, '2020-10-13 23:35:31'),
('382', 7, 'NEGRO', '24', '5167.10', NULL, '2020-10-13 23:35:31'),
('383', 7, 'VIOLETA', '25', '5183.65', NULL, '2020-10-13 23:35:31'),
('384', 7, 'AZUL', 'M', '5200.20', NULL, '2020-10-13 23:35:31'),
('385', 7, 'AMARILLO', 'CH', '5216.75', NULL, '2020-10-13 23:35:31'),
('386', 7, 'NEGRO', 'T', '5233.30', NULL, '2020-10-13 23:35:31'),
('387', 7, 'VIOLETA', 'XG', '5249.85', NULL, '2020-10-13 23:35:32'),
('388', 7, 'AZUL', '22', '5266.40', NULL, '2020-10-13 23:35:32'),
('389', 7, 'AMARILLO', '23', '5282.95', NULL, '2020-10-13 23:35:32'),
('390', 7, 'NEGRO', '24', '5299.50', NULL, '2020-10-13 23:35:32'),
('391', 7, 'VIOLETA', '25', '5316.05', NULL, '2020-10-13 23:35:32'),
('392', 7, 'AZUL', 'M', '5332.60', NULL, '2020-10-13 23:35:32'),
('393', 7, 'AMARILLO', 'CH', '5349.15', NULL, '2020-10-13 23:35:32'),
('394', 7, 'NEGRO', 'T', '5365.70', NULL, '2020-10-13 23:35:32'),
('395', 7, 'VIOLETA', 'XG', '5382.25', NULL, '2020-10-13 23:35:32'),
('396', 7, 'AZUL', '22', '5398.80', NULL, '2020-10-13 23:35:32'),
('397', 7, 'AMARILLO', '23', '5415.35', NULL, '2020-10-13 23:35:32'),
('398', 7, 'NEGRO', '24', '5431.90', NULL, '2020-10-13 23:35:32'),
('4', 2, 'VERDE', '43', '100.00', NULL, '2020-10-15 11:04:00'),
('6', 6, 'MAGENTA', '35 AL 25', '0.00', NULL, '2020-10-19 15:04:05'),
('60', 2, 'MORADO', '5', '0.00', NULL, '2021-01-16 12:48:54'),
('6762', 7, 'NEGRO', '22 AL 27  ENTEROS', '459.50', NULL, '2020-10-04 18:19:49'),
('7', 6, 'CELESTE', '34', '0.00', NULL, '2020-10-19 14:31:38'),
('8', 6, 'ROSA', '22 AL 28', '0.00', NULL, '2020-10-19 15:05:43'),
('801', 7, 'LADRILLO', '22 AL 26', '45.00', NULL, '2020-10-04 18:19:48'),
('8049', 7, 'NEGRO', '23 AL 26', '505.50', NULL, '2020-10-04 18:19:49'),
('8050', 7, 'NUTRIA', '23 AL 26', '574.50', NULL, '2020-10-04 18:19:49'),
('95184', 7, 'NEGRO', '23 AL 26', '896.50', NULL, '2020-10-04 18:19:49');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `IDPedido` bigint(20) NOT NULL,
  `IDModelo` varchar(50) NOT NULL,
  `IDCliente` bigint(20) DEFAULT NULL,
  `Color` varchar(50) DEFAULT NULL,
  `Talla` varchar(50) DEFAULT NULL,
  `Fecha` datetime NOT NULL,
  `Llego` bit(1) NOT NULL,
  `Vendido` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`IDPedido`, `IDModelo`, `IDCliente`, `Color`, `Talla`, `Fecha`, `Llego`, `Vendido`) VALUES
(60, '10009', 101, 'AMARILLLO', '22', '2021-02-03 09:39:15', b'1', b'1'),
(61, '60', 101, 'RUBY', 'G', '2021-02-03 09:39:15', b'1', b'1'),
(62, '7', 101, 'TURQUESA', '17', '2021-02-03 09:39:15', b'1', b'1'),
(63, '10009', 101, 'RUBY', 'XG', '2021-02-03 09:40:23', b'1', b'1'),
(64, '6', 101, 'TURQUESA', '22', '2021-02-03 09:40:23', b'1', b'1'),
(65, '10009', 101, 'ROJO', 'CH', '2021-02-03 09:40:23', b'1', b'1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `talla`
--

CREATE TABLE `talla` (
  `IDTalla` int(11) NOT NULL,
  `Numero` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `talla`
--

INSERT INTO `talla` (`IDTalla`, `Numero`) VALUES
(26, 'CH'),
(27, 'M'),
(28, 'G'),
(29, 'XG'),
(30, '18'),
(31, '22'),
(33, '17');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `IDUsuario` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contrasena` varchar(50) NOT NULL,
  `EsAdmin` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`IDUsuario`, `Nombre`, `Contrasena`, `EsAdmin`) VALUES
(1, 'Oscar', 'admin', b'1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `IDFolio` bigint(11) NOT NULL,
  `IDCliente` bigint(20) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`IDFolio`, `IDCliente`, `Fecha`, `Total`) VALUES
(1, 101, '2021-02-03 09:39:37', '551.50'),
(2, 101, '2021-02-03 09:41:05', '1654.50');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta_pedidos`
--

CREATE TABLE `venta_pedidos` (
  `IDVentaPedido` bigint(20) NOT NULL,
  `IDFolio` bigint(20) NOT NULL,
  `IDPedido` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `venta_pedidos`
--

INSERT INTO `venta_pedidos` (`IDVentaPedido`, `IDFolio`, `IDPedido`) VALUES
(1, 2, 61),
(2, 2, 62),
(3, 2, 64),
(4, 2, 60),
(5, 2, 63),
(6, 2, 65);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`IDCliente`);

--
-- Indices de la tabla `color`
--
ALTER TABLE `color`
  ADD PRIMARY KEY (`IDColor`);

--
-- Indices de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD PRIMARY KEY (`IDDevolucion`),
  ADD KEY `IDPedido` (`IDPedido`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`IDMarca`);

--
-- Indices de la tabla `modelos`
--
ALTER TABLE `modelos`
  ADD PRIMARY KEY (`IDModelo`),
  ADD KEY `IDMarca` (`IDMarca`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`IDPedido`),
  ADD KEY `IDModelo` (`IDModelo`),
  ADD KEY `IDCliente` (`IDCliente`);

--
-- Indices de la tabla `talla`
--
ALTER TABLE `talla`
  ADD PRIMARY KEY (`IDTalla`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IDUsuario`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`IDFolio`),
  ADD KEY `IDCliente` (`IDCliente`);

--
-- Indices de la tabla `venta_pedidos`
--
ALTER TABLE `venta_pedidos`
  ADD PRIMARY KEY (`IDVentaPedido`),
  ADD KEY `IDPedido` (`IDPedido`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `IDCliente` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- AUTO_INCREMENT de la tabla `color`
--
ALTER TABLE `color`
  MODIFY `IDColor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  MODIFY `IDDevolucion` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `IDPedido` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT de la tabla `talla`
--
ALTER TABLE `talla`
  MODIFY `IDTalla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IDUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `venta_pedidos`
--
ALTER TABLE `venta_pedidos`
  MODIFY `IDVentaPedido` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD CONSTRAINT `devolucion_ibfk_1` FOREIGN KEY (`IDPedido`) REFERENCES `pedidos` (`IDPedido`);

--
-- Filtros para la tabla `modelos`
--
ALTER TABLE `modelos`
  ADD CONSTRAINT `modelos_ibfk_1` FOREIGN KEY (`IDMarca`) REFERENCES `marca` (`IDMarca`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`IDModelo`) REFERENCES `modelos` (`IDModelo`),
  ADD CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`IDCliente`) REFERENCES `clientes` (`IDCliente`);

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_2` FOREIGN KEY (`IDCliente`) REFERENCES `clientes` (`IDCliente`);

--
-- Filtros para la tabla `venta_pedidos`
--
ALTER TABLE `venta_pedidos`
  ADD CONSTRAINT `venta_pedidos_ibfk_1` FOREIGN KEY (`IDPedido`) REFERENCES `pedidos` (`IDPedido`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
