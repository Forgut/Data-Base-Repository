create trigger Cena_wyrobu_a_sprzedazy
on Produkty
for Insert, Update
as
begin
declare @cena_wyrobu int
declare @cena_sprzedazy int
set @cena_wyrobu=(select p.[Cena produkcji]
			 	 from Produkty p, Inserted i 
			 	 where p.Id = i.Id)
set @cena_sprzedazy=(select p.[Cena za szt.] 
					from Produkty p, inserted i
					where p.id = i.Id)
if (@cena_sprzedazy < @cena_wyrobu)
	begin
	rollback
	raiserror('Cena sprzedaży musi być wyższa niż cena produkcji!!!',16,1)
	end
end
