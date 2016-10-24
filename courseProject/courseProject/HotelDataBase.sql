



--SELECT * FROM Client

--ALTER TABLE Client
--DROP COLUMN CheckoutDate

INSERT INTO public.Client (id,PassportData,AmountOfMoney,RoomNumber,AccomodationDate,CheckoutDate)
VALUES (1, 'BC325467', 125.5 , 235, '20 september' , '27 september');

INSERT INTO public.Client (id,PassportData,AmountOfMoney,RoomNumber,AccomodationDate,CheckoutDate)
VALUES (2, 'BC353456', 900 , 007, '10 september' , '17 september');

INSERT INTO public.Client (id,PassportData,AmountOfMoney,RoomNumber,AccomodationDate,CheckoutDate)
VALUES (3, 'BC634643', 700.25 , 1337, '18 september' , '25 september');