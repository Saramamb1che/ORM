CREATE DATABASE IF NOT EXISTS libreria_segovia
  CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE libreria_segovia;

CREATE TABLE categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre       VARCHAR(60) NOT NULL UNIQUE
);

CREATE TABLE productos (
    id_producto  INT AUTO_INCREMENT PRIMARY KEY,
    nombre       VARCHAR(100)  NOT NULL,
    precio       DECIMAL(10,2) NOT NULL DEFAULT 0,
    existencia   INT           NOT NULL DEFAULT 0,
    id_categoria INT           NOT NULL,
    version_fila INT           NOT NULL DEFAULT 1,   -- token de concurrencia
    CONSTRAINT fk_producto_categoria FOREIGN KEY (id_categoria)
        REFERENCES categorias (id_categoria)
);

INSERT INTO categorias (nombre) VALUES
  ('Papelería'), ('Útiles escolares'), ('Arte y manualidades'), ('Tecnología');

INSERT INTO productos (nombre, precio, existencia, id_categoria) VALUES
  ('Cuaderno universitario 100 hojas', 85.00, 40, 1),
  ('Resma de papel carta',            260.00, 25, 1),
  ('Lapicero azul (unidad)',           12.00, 300, 2),
  ('Mochila escolar',                 650.00, 12, 2),
  ('Caja de témperas 12 colores',     145.00, 18, 3),
  ('Memoria USB 32 GB',               320.00, 10, 4);
