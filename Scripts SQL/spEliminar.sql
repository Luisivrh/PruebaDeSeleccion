create proc [dbo].[spEliminar]
@idExamen int
as
begin 
	delete from tblExamen where idExamen=@idExamen
	select 'Elemento eliminado' as result;
end

exec spEliminar 823;
select * from tblExamen;