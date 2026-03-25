# apbd-Cw2-s33198
Projekt przedstawia prosty mechanizm działania wypożyczalni sprzętu komputerowego.

Wszystkie trzy listy - Użytkownicy, urzadzenia oraz wypożyczenia znajdują sie w listach przypisanych do klasy Database. Ustawienia logiki biznesowej - maksymalna ilosc wypozyczen, kary finansowe itp. znajdują się w klasie Settings.

Klasy Camera, Laptop, Projector dziedziczą po klasie Device, klasy Student i Employee dziedziczą po User.

Dzięki użyciu oddzielnej klasy Rentals i DatabaseServices komendy oddzielone są od innych klas przez co modyfikacja dowolnej klasy wymaga zmienienia tylko klas w katalogu services, nie wplywa na inne klasy.

Zadbałem o kohezje poprzez uzycie oddzielnycxh klas do roznych komend z zakresu rentals

