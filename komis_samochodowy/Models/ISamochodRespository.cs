using System.Collections.Generic;

namespace komis_samochodowy.Models
{
    public interface ISamochodRespository
    {
        IEnumerable<Samochod> PobierzSamochody();
        Samochod PobierzSamochod(int samochodId);
    }
}
