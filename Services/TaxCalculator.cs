using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services;

public class TaxCalculator
{
    public int NationalityBaseTaxRateIndicator(Taxpayer taxpayer)
    {
        switch (taxpayer.Nationality)
        {
            case Shared.Enums.Nationality.Iran: return 12;
            case Shared.Enums.Nationality.Malaysia: return 5;
            case Shared.Enums.Nationality.Italy: return 20;
            case Shared.Enums.Nationality.Spain: return 19;
            case Shared.Enums.Nationality.Germany: return 25;
            default: return 1;
        }

    }

    public int CalculateTax(Taxpayer taxpayer)
    {
        var basetaxrate = NationalityBaseTaxRateIndicator(taxpayer);
        int taxrate = 0;
        if (taxpayer.Salary > 500)
        {
            taxrate = basetaxrate + 8;
        }
        return taxrate;
    }
}
