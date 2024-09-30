CREATE TABLE Chasis (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NumeroEjes INT NOT NULL,
    TipoTransmision NVARCHAR(50) NOT NULL  -- Automática o Mecánica
);

CREATE TABLE Motor (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PotenciaMaxima INT NOT NULL,
    Tecnologia NVARCHAR(50) NOT NULL  -- Eléctrico, Térmico, Híbrido
);

CREATE TABLE Cojinera (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Material NVARCHAR(50) NOT NULL  -- Cuero, Tela, Sintético
);

CREATE TABLE Vehicle (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Marca NVARCHAR(50) NOT NULL,
    Color NVARCHAR(50) NOT NULL,
    FechaEnsamblaje DATETIME NOT NULL,
    NumeroEnsamblaje INT NOT NULL,
    ChasisId INT NOT NULL,
    MotorId INT NOT NULL,
    CojineraId INT NOT NULL,
    FOREIGN KEY (ChasisId) REFERENCES Chasis(Id),
    FOREIGN KEY (MotorId) REFERENCES Motor(Id),
    FOREIGN KEY (CojineraId) REFERENCES Cojinera(Id)
);
