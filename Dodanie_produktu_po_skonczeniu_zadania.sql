CREATE TRIGGER [Dodanie produktu po skonczeniu zadania]
	ON [Zadania]
	FOR DELETE, INSERT, UPDATE
	AS
	Begin
	IF ((select i.Zakończone from inserted i) = 1)
	BEGIN
	declare @AddToProduct int
	declare @Produkt int
	set @AddToProduct = (select z.[Wykonanych sztuk produktu] 
						from Zadania z, inserted i 
						where z.Id = i.Id)
    set @Produkt = (select z.[Produkowany produkt] 
					from Zadania z, inserted i
					where z.id = i.Id)
    update Produkty
	set Produkty.[Ilość na stanie] = (Produkty.[Ilość na stanie] + @AddToProduct)
	where Produkty.Id = @Produkt
	END
	end