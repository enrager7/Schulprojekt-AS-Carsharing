--Tabellenstruktur
CREATE TABLE IF NOT EXISTS T_Carsharing
(
p_branchNo INTEGER PRIMARY KEY,
name VARCHAR(50),
adress VARCHAR(200)
); 

CREATE TABLE IF NOT EXISTS T_LenderCar
(
p_f_lenderId INTEGER NOT NULL,
p_f_licenseTag VARCHAR(8) NOT NULL, 
PRIMARY KEY (p_f_lenderId, p_f_licenseTag)
FOREIGN KEY (p_f_lenderId) REFERENCES T_Lender (p_lenderId)
	ON UPDATE CASCADE 
	ON DELETE NO ACTION, 
FOREIGN KEY (p_f_licenseTag) REFERENCES T_Car (P_licenseTag) 
	ON UPDATE CASCADE
	ON DELETE NO ACTION
);
CREATE TABLE IF NOT EXISTS T_Car
(
p_licenseTag VARCHAR(8) NOT NULL PRIMARY KEY, 
model VARCHAR(200),
manufacturer VARCHAR(200),
priceperDay DECIMAL,
p_f_branchNo INTEGER DEFAULT NULL,
FOREIGN KEY (p_f_branchNo) REFERENCES T_Carsharing (p_branchNo)
	ON UPDATE CASCADE
	ON DELETE SET NULL
);
CREATE TABLE IF NOT EXISTS T_Lender
(
p_lenderId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
name VARCHAR(50),
age INTEGER,
adress VARCHAR(200)
);

--das Ganze als Einzeiler für C#:
--		CREATE TABLE IF NOT EXISTS T_Carsharing (p_branchNo INTEGER PRIMARY KEY, name VARCHAR(50), adress VARCHAR(200)); CREATE TABLE IF NOT EXISTS T_LenderCar (p_f_lenderId INTEGER NOT NULL, p_f_licenseTag VARCHAR(8) NOT NULL, PRIMARY KEY (p_f_lenderId, p_f_licenseTag) FOREIGN KEY (p_f_lenderId) REFERENCES T_Lender (p_lenderId) ON UPDATE CASCADE ON DELETE NO ACTION, FOREIGN KEY (p_f_licenseTag) REFERENCES T_Car (P_licenseTag) ON UPDATE CASCADE ON DELETE NO ACTION ); CREATE TABLE IF NOT EXISTS T_Car  ( p_licenseTag VARCHAR(8) NOT NULL PRIMARY KEY, model VARCHAR(200), manufacturer VARCHAR(200), priceperDay DECIMAL, p_f_branchNo INTEGER DEFAULT NULL, FOREIGN KEY (p_f_branchNo) REFERENCES T_Carsharing (p_branchNo) ON UPDATE CASCADE ON DELETE SET NULL ); CREATE TABLE IF NOT EXISTS T_Lender  ( p_lenderId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(50), age INTEGER, adress VARCHAR(200));


--TESTDATA
	INSERT INTO T_Carsharing VALUES(0, 'Fahrzeugdepot', 'Musterstraße 11, 10371 Berlin');
	INSERT INTO T_Carsharing VALUES(1, 'Autoverleih Berlin Mitte', 'Alexanderstraße 22, 10948 Berlin');
	INSERT INTO T_Carsharing VALUES(2, 'Autoverleih Berlin Spandau', 'Seegelfelder Str. 57, 13583 Berlin');
	INSERT INTO T_Lender VALUES(1, 'Max Mustermann', '45', 'Gensinger Str. 52, 10315 Berlin');
	INSERT INTO T_Lender VALUES(2, 'Pierre Jenchen', '25', 'Berliner Allee 21, 12545 Berlin');
	INSERT INTO T_Lender VALUES(3, 'Markus Hoefgen', '24', 'Hoefgener Weg 115, 10219 Berlin');
	INSERT INTO T_Lender VALUES(4, 'Artem Efimov','26', 'Zechliner Str. 16, 13055 Berlin');
	INSERT INTO T_Car VALUES('B001', 'Mercedes Benz E320', 'Daimler AG', 160.00, 0); 
	INSERT INTO T_Car VALUES('B002', 'Smart', 'Daimler AG', 55.00, 1);
	INSERT INTO T_Car VALUES('B003', 'Fiat Panda', 'Fiat', 75.00, 2);
	INSERT INTO T_Car VALUES('B004', 'Opel Corsa', 'Opel', 69.99, 2);
	INSERT INTO T_LenderCar VALUES(2, 'B002');

--	Notizen, Änderungen etc:
--	
--	1. Beispiel: Kunde mit lenderId 1 leiht fahrzeug mit licenseTag 'B002' aus, und wird anschliessend entfernt ohne das Auto zu 'entleihen'.
--	RICHTIG: Fehlermeldung erscheint "Kunde {lenderId} hat noch ein Fahrzeug ausgeliehen und kann nicht entfernt werden". Sobald der zugehörige Eintrag 
--	aus der Tabelle T_LenderCar entfernt wird, kann auch der Kunde entfernt werden. FUNKTIONIERT (gefixt durch Angabe des Foreign key constraints in der Tabelle T_LenderCar
--
--2	- Ausleiher wird gelöscht bzw. Id wird geändert > Solange der Ausleiher noch ein Fahzeug ausgeliehen hat, wird der Datensatz nicht gelöscht, Änderungen hingegen werden akzeptiert und in beiden Tabellen übernommen
-- 	- Fahrzeug wird gelöscht bzw. licenseTag wird geändert  > Solange das Fahrzeug noch ausgeliehen ist, wird der Datensatz nicht gelöscht, Änderungen hingegen werden akzeptiert und in beiden Tabellen übernommen
-- 	-(fixed durrch ON UPDATE CASCADE & ON DELETE NO ACTION zu den Jeweiligen Foreign Key constraints)
--3	- Nummernschild VARCHAR(von 10 auf 8 gesetzt)