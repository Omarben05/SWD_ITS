USE Magazzino27;

UPDATE prodotto SET giacenza=0 where id=3;
UPDATE prodotto SET giacenza=3 where id=4;
UPDATE prodotto SET giacenza=30, prezzo=1.55 where id=2;

UPDATE prodotto SET descrizione= 'Descrizione prodotto 1' WHERE id=1