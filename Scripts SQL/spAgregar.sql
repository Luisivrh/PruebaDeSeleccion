
create proc [dbo].[spAgregar]
@idExamen int,
@Nombre varchar(255),
@Descripcion varchar(255)
as
begin 
begin try
	insert into tblExamen (idExamen, Nombre, Descripcion) 
	values (@idExamen, @Nombre, @Descripcion)
	select 'Insercion Exitosa' as result;
end try
begin catch
	select ERROR_NUMBER() as ErrorNumber,
	ERROR_MESSAGE() as ErrorMessage;
end catch;
end;


