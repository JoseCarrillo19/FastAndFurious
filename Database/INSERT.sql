-- Insertar datos en la tabla Chasis
INSERT INTO Chasis (NumeroEjes, TipoTransmision)
VALUES (4, 'Automática'),
       (2, 'Mecánica'),
       (6, 'Automática'),
       (4, 'Mecánica');

-- Insertar datos en la tabla Motor
INSERT INTO Motor (PotenciaMaxima, Tecnologia)
VALUES (180, 'Híbrido'),
       (200, 'Eléctrico'),
       (150, 'Térmico'),
       (220, 'Híbrido');

-- Insertar datos en la tabla Cojinera
INSERT INTO Cojinera (Material)
VALUES ('Cuero'),
       ('Tela'),
       ('Sintético'),
       ('Cuero');

-- Insertar datos en la tabla Vehicle
-- Nota: Asegúrate de que los IDs de Chasis, Motor y Cojinera son correctos
INSERT INTO Vehicle (Marca, Color, FechaEnsamblaje, NumeroEnsamblaje, ChasisId, MotorId, CojineraId)
VALUES ('Toyota', 'Rojo', GETDATE(), 1234, 1, 2, 3),
       ('Ford', 'Azul', GETDATE(), 5678, 2, 1, 4),
       ('Mazda', 'Blanco', GETDATE(), 9101, 3, 3, 2),
       ('Toyota', 'Negro', GETDATE(), 1122, 4, 4, 1);
