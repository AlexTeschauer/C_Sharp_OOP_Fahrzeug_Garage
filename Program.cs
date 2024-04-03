Verleiher verleiher = new Verleiher("Martin", "Mustermann", 55);
Ausleiher ausleiher = new Ausleiher("Max", "Mustermann", 25);

Garage garage = new Garage("Garage", "München", 10);

Tesla tesla_s = new Tesla(1, "Tesla S", "München", "ABC123", "Tesla", verleiher, 10);
Tesla tesla_3 = new Tesla(2, "Tesla 3", "München", "DEF456", "Tesla", verleiher, 15);
Tesla tesla_x = new Tesla(3, "Tesla X", "München", "GHI789", "Tesla", verleiher, 20);
Tesla tesla_y = new Tesla(4, "Tesla Y", "München", "JKL012", "Tesla", verleiher, 25);
Volkswagen volkswagen_golf = new Volkswagen(5, "Volkswagen Golf", "München", "MNO345", "Volkswagen", verleiher, 2);
Volkswagen volkswagen_passat = new Volkswagen(6, "Volkswagen Passat", "München", "PQR678", "Volkswagen", verleiher, 3);
Volkswagen volkswagen_t5 = new Volkswagen(7, "Volkswagen T5", "München", "STU901", "Volkswagen", verleiher, 4);

garage.FügeFahrzeugHinzu(tesla_s);
garage.FügeFahrzeugHinzu(tesla_3);
garage.FügeFahrzeugHinzu(tesla_x);
garage.FügeFahrzeugHinzu(tesla_y);
garage.FügeFahrzeugHinzu(volkswagen_golf);
garage.FügeFahrzeugHinzu(volkswagen_passat);
garage.FügeFahrzeugHinzu(volkswagen_t5);



Printer.PrintFahrzeuge(garage.Fahrzeuge);

int ausleihe = Selector.SelectCar();

Printer.PrintIstAusgeliehen(garage.GetFahrzeug(ausleihe));

ausleiher.Ausleihen(garage, garage.GetFahrzeug(ausleihe));

Printer.PrintIstAusgeliehen(garage.GetFahrzeug(ausleihe));





// LSP
// Kinderklassen konkretisieren/erweitern die Elternklasse, aber verändern sie nicht.
// tesla_3.Fahren();
// tesla_3.Beschleunigen();
// Fahrzeug fahrzeug = new Fahrzeug(1, "Fahrzeug", "München", "ABC123", "Hersteller", verleiher);
// fahrzeug.Fahren();
// fahrzeug.Beschleunigen();
