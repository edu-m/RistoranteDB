create PROCEDURE PR_CANCELLA_PRENOTAZIONE
	  @IdPrenotazione	INTEGER
	, @IdCliente		INTEGER
	, @message			VARCHAR(100) OUTPUT
AS
BEGIN
	
	declare @cerca		INTEGER = 0;
	
	set @cerca = 
		( select COUNT(*) from Prenotazioni where ID = @IdPrenotazione and IdCliente = @IdCliente);

	if @cerca = 0
		set @message = (select msg_text from Messaggi where msg_key = 'PRENOT_NOTFOUND');
	else 
	BEGIN

		delete from Prenotazioni where ID = @IdPrenotazione;

		set @message = (select msg_text from Messaggi where msg_key = 'PRENOT_DELETED');
	End
END
GO

-- =====================================================
-- Test
declare @message varchar(100);
EXECUTE dbo.PR_CANCELLA_PRENOTAZIONE 14, 1, @message output;
select @message as MESSAGGIO;

select * from Prenotazioni;

-- =====================================================
