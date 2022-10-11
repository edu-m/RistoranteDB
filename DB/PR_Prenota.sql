create PROCEDURE PR_PRENOTA
	  @IdCliente	INTEGER
	, @giorno 		DATE
    , @turno		VARCHAR(3)
	, @seats	    INTEGER
	, @note			VARCHAR(200)
	, @message		VARCHAR(100) OUTPUT
AS
BEGIN
	declare @postiDisponibili	INTEGER = 0;
	declare @postiPrenotati		INTEGER = 0;
	declare @postiTotali		INTEGER = 0;
	declare @giornoChiusura		INTEGER = 0;

	set @giornoChiusura = 
		( select COUNT(*) from Config where chiave='GiornoChiusura' and @giorno between data_inizio and data_fine
		and datename(weekday,@giorno) = valore);

	if @giorno < cast(GETDATE() as date)
		set @message = 'Il passato è passato...';
	else 
	if @giornoChiusura > 0
		set @message = 'Nel giorno scelto siamo chiusi';
	else
	BEGIN

		set @postiTotali = 
			(select Valore from Config
			where chiave='Posti' and @giorno between data_inizio and data_fine);

			select * from Prenotazioni P where giorno = @giorno and turno=@turno;
			if @@ROWCOUNT > 0
			set @postiPrenotati =			
				(SELECT sum(seats) from Prenotazioni P where giorno = @giorno and turno=@turno);
				
			if (@seats <= @postiTotali - @postiPrenotati) 
			BEGIN
				insert into Prenotazioni
				values (NEXT VALUE for SeqPrenotazioni, @giorno, @turno, @IdCliente, @seats, @note);

				set @message = 'Prenotazione effettuata! A presto!';
			end
			else
				set @message = 'Il numero di posti richiesti supera quelli disponibili nel giorno scelto.';
	End
END
GO

-- =====================================================
-- Test
declare @message varchar(100);
EXECUTE dbo.PR_PRENOTA 1, '20220930','P1', 4, 'abbiamo fame', @message output;
select @message as MESSAGGIO;

select * from Prenotazioni;
--delete from Prenotazioni where ID = 1;

-- =====================================================
