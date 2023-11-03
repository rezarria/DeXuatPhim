using CsvHelper.Configuration;
using DeXuatApp.Models;

namespace DeXuatApp.CSV;

public class Cvt : ClassMap<Movie>
{
    public Cvt()
    {
        Map(x=>x.Casts).Convert()
    }
}