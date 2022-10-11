-- =================================================================
--							TABELLE
-- =================================================================

-- Creazione

CREATE SEQUENCE SeqClienti START WITH 1 INCREMENT BY 1 ; 
CREATE SEQUENCE SeqPrenotazioni START WITH 1 INCREMENT BY 1 ;

create table Clienti
(	  ID		INTEGER		PRIMARY KEY
	, email		VARCHAR(50) NOT NULL
	, pwd 		VARCHAR(50)
    , nome		VARCHAR(200)
	, telefono	VARCHAR(20)
);

create table Turni
(	  ID 			VARCHAR(2) NOT NULL PRIMARY KEY 
	, valore 		VARCHAR(50)
);

create table Prenotazioni
(	  ID			INTEGER			PRIMARY KEY
	, giorno 		DATE			
	, turno 		VARCHAR(2)		FOREIGN KEY REFERENCES Turni(ID)
    , IdCliente		INTEGER			FOREIGN KEY REFERENCES Clienti(ID)
	, pax			INTEGER
	, note			VARCHAR(200)
);

create table Config
(	  chiave 		VARCHAR(50) NOT NULL
	, data_inizio 	DATE
    , data_fine		DATE
	, valore		VARCHAR(20)
	, PRIMARY KEY (chiave, valore, data_inizio) 
);

create table Messaggi
(	  msg_key 		VARCHAR(50)		PRIMARY KEY
	, msg_text		VARCHAR(100)
);



-- Dati di Configurazione

insert into Config values ('Posti', '20220901', '99991231', 30);
insert into Config values ('GiornoChiusura', '20220901', '99991231', 'domenica');

insert into Turni values ('P1', 'Pranzo 12.30 - 14.00');
insert into Turni values ('P2', 'Pranzo 14.00 - 15.30');
insert into Turni values ('C1', 'Cena 19.30 - 21.00');
insert into Turni values ('C2', 'Cena 21.00 - 22.30');

insert into Clienti values ('0', 'admin@cucinasana.com', 'chef', 'Admin', null);

insert into Messaggi values ('DATA_KO',			'Inserire una data valida.');
insert into Messaggi values ('CHIUSO',			'Nel giorno scelto siamo chiusi.');
insert into Messaggi values ('POSTI_KO',		'Il numero di posti richiesti supera quelli disponibili nel giorno scelto.');
insert into Messaggi values ('PRENOT_OK',		'Prenotazione effettuata!');
insert into Messaggi values ('PRENOT_NOTFOUND', 'Prenotazione non trovata');
insert into Messaggi values ('PRENOT_DELETED',	'Prenotazione cancellata.');
insert into Messaggi values ('USER_EXISTS',		'Utente già registrato con questo indirizzo email');
insert into Messaggi values ('USER_CREATED',	'Utente creato.');



-- Svuotamento tabelle

--drop table Prenotazioni;
--drop Table Clienti;
--truncate table Prenotazioni;
--truncate table Clienti;
--ALTER SEQUENCE SeqPrenotazioni RESTART;
--ALTER SEQUENCE SeqClienti RESTART;

-- =================================================================