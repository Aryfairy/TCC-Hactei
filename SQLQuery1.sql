CREATE TABLE laboratorio (
    lab_cod INTEGER PRIMARY KEY IDENTITY(1,1),
    lab_nome VARCHAR(80) NOT NULL,
    lab_disc VARCHAR(80) NOT NULL,
    lab_sala VARCHAR(20) NOT NULL,
);

CREATE TABLE professor (
    prof_cod INTEGER PRIMARY KEY IDENTITY(1,1),
    prof_nome VARCHAR(80) NOT NULL,
    prof_disciplina VARCHAR(60) NOT NULL,
    prof_email VARCHAR(40),
    prof_celular BIGINT
);

CREATE TABLE reserva (
    res_cod INTEGER PRIMARY KEY IDENTITY(1,1),
    lab_cod INTEGER NOT NULL,
    prof_cod INTEGER NOT NULL,
    res_data DATE NOT NULL,
    res_horainicial TIME NOT NULL,
    res_horafinal TIME NOT NULL,
    res_status NVARCHAR(50) NOT NULL CHECK (res_status IN ('disponivel', 'reservado'))
    FOREIGN KEY (lab_cod) REFERENCES laboratorio(lab_cod),
    FOREIGN KEY (prof_cod) REFERENCES professor(prof_cod)
);

CREATE TABLE administrador (
    admin_id INTEGER PRIMARY KEY IDENTITY(1,1),
    admin_nome VARCHAR(80) NOT NULL,
    admin_email VARCHAR(100) NOT NULL,
    admin_usuario VARCHAR(30) NOT NULL,
    admin_senha VARCHAR(100) NOT NULL,
    UNIQUE(admin_email),
    UNIQUE(admin_usuario)
);