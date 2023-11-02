create proc spConsultar
@Nombre varchar(255),
@Descripcion varchar(255)
as
begin
begin try
	if @Nombre=(select Nombre from tblExamen where Descripcion = @Descripcion)
	begin
		select idExamen, Nombre, Descripcion from tblExamen where Nombre = @Nombre;
		select 'Insercion Exitosa' as result;
	end
	else
	begin 
		select 'Valores no encontrados'
	end
end try
begin catch
	select ERROR_NUMBER() as ErrorNumber,
	ERROR_MESSAGE() as ErrorMessage;
end catch;
end;
