USE [DBInstruments]
GO

INSERT INTO [dbo].[Instruments]
           ([Nombre]
           ,[Tipo]
           ,[Marca]
           ,[Descripcion]
           ,[Precio]
           ,[Stock])
     VALUES
           ('Piano','Electrico','Yamaha','Modelo:P45 | Teclas:88 | Midi:Si | Incluye pedal',104426,10),
		   ('Piano','Acustico','Yamaha','Modelo:GL-10 | Teclas:88 | Tipo: Cola | Incluye Banqueta| Medidas: 102cm x 153cm x 150cm',2556459,2),
		   ('Guitarra','Electrica','Femmto','Modelo:EG001 | Forma del cuerpo: Stratocaster| Color: Blanco/Negro | Orientacion de mano: Diestro',18999,20),
		   ('Guitarra','Acustica','Fender','Modelo:Newporter Player | Forma del cuerpo: Auditorium | Material: Abeto y Caoba',95694.20,7),
		   ('Bateria','Electrica','Artesia','Modelo:A50| Cantidad de cuerpos: 5 | Cantidad de sonidos: 200 | Incluye pedales y palillos',186901,15),
		   ('Bateria','Acustica','Pearl','Modelo:exx725s 33 | Cantidad de cuerpos: 5| No incluye pedales ni taburete',108267.12,10),
		   ('Violin','Electrico','Kinglos','Modelo:SDDS | Tamaño: 4/4 | Incluye estuche y accesorios',60072,9),
		   ('Violin','Acustico','Segovia','Modelo:VP101H44 | Tamaño: 4/4 | Incluye estuche y accesorios',8500,20)
GO


