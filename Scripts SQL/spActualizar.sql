create proc spActualizar
@idExamen int,
@Nombre varchar(255),
@Descripcion varchar(255)
as
begin 
	update tblExamen set Nombre=@Nombre, Descripcion=@Descripcion 
			where idExamen=@idExamen
end


select * from tblExamen;
exec dbo.spActualizar 1, 'Examen prueba actualizado', 'ac Esta es la prueba del procedimiento'