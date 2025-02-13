CREATE DATABASE IF NOT EXISTS recibos_db;
USE recibos_db;

CREATE TABLE atos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    codigo CHAR(3) NOT NULL UNIQUE,
    custas_oficial DECIMAL(10, 2) NOT NULL,
    custas_iss DECIMAL(10, 2) NOT NULL,
    custas_ipesp DECIMAL(10, 2) NOT NULL,
    nome VARCHAR(63) NOT NULL
);

CREATE TABLE recibos_provisorios (
    id INT PRIMARY KEY AUTO_INCREMENT,
    data TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    requerente VARCHAR(255) NOT NULL,
    cpf CHAR(11)
);

CREATE TABLE recibo_provisorio_atos (
	id INT PRIMARY KEY AUTO_INCREMENT,
    recibo_provisorio_id INT,
    ato_id INT,
    descricao VARCHAR(127),
    quantidade INT NOT NULL,
    FOREIGN KEY (recibo_provisorio_id) REFERENCES recibos_provisorios(id) ON DELETE CASCADE,
    FOREIGN KEY (ato_id) REFERENCES atos(id) ON DELETE CASCADE
);

CREATE TABLE recibos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    data TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    requerente VARCHAR(255) NOT NULL,
    cpf CHAR(11),
    recibo_provisorio_id INT NULL,
    FOREIGN KEY (recibo_provisorio_id) REFERENCES recibos_provisorios(id)
);

CREATE TABLE recibo_atos (
	id INT PRIMARY KEY AUTO_INCREMENT,
	recibo_id INT,
    ato_id INT,
    descricao VARCHAR(127),
    quantidade INT NOT NULL,
    FOREIGN KEY (recibo_id) REFERENCES recibos(id) ON DELETE CASCADE,
    FOREIGN KEY (ato_id) REFERENCES atos(id) ON DELETE CASCADE
);