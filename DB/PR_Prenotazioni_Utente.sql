create PROCEDURE PR_PRENOTAZIONI_UTENTE
	  @Id			INTEGER
	, @result		CURSOR VARYING OUTPUT  
AS
BEGIN
	set @result = CURSOR FORWARD_ONLY STATIC FOR 
		select ID, Giorno, Turno, Pax from Prenotazioni where IdCliente = @Id;

	open @result;
END
GO

-- =====================================================
-- Test
declare @res CURSOR;
EXECUTE dbo.PR_PRENOTAZIONI_UTENTE 1, @result=@res output;

WHILE (@@FETCH_STATUS = 0)  
    BEGIN;  
         FETCH NEXT FROM @res;  
    END;  

CLOSE @res;  
DEALLOCATE @res;  
GO   

-- =====================================================
