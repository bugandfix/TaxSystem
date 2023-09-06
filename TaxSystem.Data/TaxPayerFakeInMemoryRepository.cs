using Shared.Entities;
using Shared.Enums;

namespace TaxSystem.Data;

public class TaxPayerFakeInMemoryRepository
{
    List<Taxpayer>? taxpayerlist;

    public List<Taxpayer> GetAllTaxPayers()
    {
        taxpayerlist = new List<Taxpayer>
        {
        new Taxpayer
        {
            ID = 1,
            TaxNumber = "SG3434545",
            Name = "Sara",
            Family = "King",
            Nationality = Nationality.Malaysia, 
            Birthdate = new DateTime(1985, 5, 10), 
            Address = "123 Main St",
            Salary = 3000,
            TaxRate = 5,
        },
        new Taxpayer
        {
            ID = 2,
            TaxNumber = "SG956345",
            Name = "Jane",
            Family = "Smith",
            Nationality = Nationality.Italy, 
            Birthdate = new DateTime(1990, 8, 25), 
            Address = "456 Elm Ave",
            Salary = 6000,
            TaxRate = 18,
        },
        new Taxpayer
        {
            ID = 3,
            TaxNumber = "SG2356345635",
            Name = "Michael",
            Family = "Johnson",
            Nationality = Nationality.Germany, 
            Birthdate = new DateTime(1978, 3, 15), 
            Address = "789 Oak Rd",
            Salary = 55000,
            TaxRate = 22,
        },

    };

        return taxpayerlist;


    }
}