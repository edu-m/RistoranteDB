create PROCEDURE PR_ELIMINA_PRENOTAZIONE
	  @Id			INTEGER
	, @message		VARCHAR(100) OUTPUT
AS
BEGIN
	delete from Prenotazioni where ID = @Id;
	set @message = 'Prenotazione cancellata. Buona dieta :)';
END
GO

-- =====================================================
-- Test
declare @message varchar(100);
EXECUTE dbo.PR_ELIMINA_PRENOTAZIONE 1, @message output;
select @message as MESSAGGIO;

select * from Prenotazioni;
delete from Prenotazioni where IdCliente = 1;

-- =====================================================
