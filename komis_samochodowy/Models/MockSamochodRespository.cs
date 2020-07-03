using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace komis_samochodowy.Models
{
    public class MockSamochodRespository : ISamochodRespository
    {
        List<Samochod> samochody;
        public MockSamochodRespository()
        {
            if (samochody == null)
            {
                ZaladujSamochody();
            }
        }

        public Samochod PobierzSamochod(int samochodId)
        {
            return samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzSamochody()
        {
            return samochody;
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
            {
                new Samochod { Id = 1, Marka = "Fiat", Model = "Bravo", RokProdukcji = "2008", Przebieg = "116 000 km", Pojemnosc = "1045 cm3", Moc = "100", RodzajPaliwa = "Benzyna", SamochodTygodnia = false, ZdjecieUrl = "/images/fiat.jpg", Opis = "bla bla 1", MiniatrukaUrl = "/images/fiatmin.jpg", Cena = 12000M },
                new Samochod { Id = 2, Marka = "Fiat", Model = "Bravo", RokProdukcji = "2008", Przebieg = "116 000 km", Pojemnosc = "1045 cm3", Moc = "100", RodzajPaliwa = "Benzyna", SamochodTygodnia = false, ZdjecieUrl = "/images/fiat.jpg", Opis = "bla bla 2", MiniatrukaUrl = "/images/fiatmin.jpg", Cena = 12000M },
                new Samochod { Id = 3, Marka = "Fiat", Model = "Bravo", RokProdukcji = "2008", Przebieg = "116 000 km", Pojemnosc = "1045 cm3", Moc = "100", RodzajPaliwa = "Benzyna", SamochodTygodnia = false, ZdjecieUrl = "/images/fiat.jpg", Opis = "bla bla 3", MiniatrukaUrl = "/images/fiatmin.jpg", Cena = 12000M },
                new Samochod { Id = 4, Marka = "Fiat", Model = "Bravo", RokProdukcji = "2008", Przebieg = "116 000 km", Pojemnosc = "1045 cm3", Moc = "100", RodzajPaliwa = "Benzyna", SamochodTygodnia = false, ZdjecieUrl = "/images/fiat.jpg", Opis = "bla bla 4", MiniatrukaUrl = "/images/fiatmin.jpg", Cena = 12000M },
                new Samochod { Id = 5, Marka = "Fiat", Model = "Bravo", RokProdukcji = "2008", Przebieg = "116 000 km", Pojemnosc = "1045 cm3", Moc = "100", RodzajPaliwa = "Benzyna", SamochodTygodnia = false, ZdjecieUrl = "/images/fiat.jpg", Opis = "bla bla 5", MiniatrukaUrl = "/images/fiatmin.jpg", Cena = 12000M },
                new Samochod { Id = 6, Marka = "Fiat", Model = "Bravo", RokProdukcji = "2008", Przebieg = "116 000 km", Pojemnosc = "1045 cm3", Moc = "100", RodzajPaliwa = "Benzyna", SamochodTygodnia = false, ZdjecieUrl = "/images/fiat.jpg", Opis = "bla bla 6", MiniatrukaUrl = "/images/fiatmin.jpg", Cena = 12000M },
            };
        }
    }
}
