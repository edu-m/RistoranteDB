alter PROCEDURE PR_CREA_UTENTE 
	@email		VARCHAR(50)
	, @pwd 		VARCHAR(50)
    , @nome		VARCHAR(100)
	, @telefono	VARCHAR(20) 
	, @message  VARCHAR(100) OUTPUT
AS
BEGIN
	SELECT * from Clienti where email = trim(lower(@email));
	if (@@ROWCOUNT>0) 
		set @message = 'Utente già registrato';
	else
	begin
		insert into Clienti values(NEXT VALUE for SeqClienti, trim(lower(@email)), @pwd, @nome, @telefono);
		set @message = 'Utente creato.';
	end
END
GO

-- =====================================================
-- Test
declare @message VARCHAR(200);
EXEC dbo.PR_CREA_UTENTE 'ilamukki@gmail.com', 'dieta', 'Ila', '+393473743474', @message output;
select @message as MESSAGGIO;

select * from Clienti;
--delete from Clienti where id=1;
		
-- =====================================================
