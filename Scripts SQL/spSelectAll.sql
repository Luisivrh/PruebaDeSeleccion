create proc spSelectAll
as
begin 
begin try
	
	select * from tblExamen

	select 'Seleccion Exitosa' as result;
end try 
begin catch
	select ERROR_NUMBER() as ErrorNumber,
	ERROR_MESSAGE() as ErrorMessage;
end catch;
end;

