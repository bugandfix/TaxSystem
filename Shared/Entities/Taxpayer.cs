using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities;

public class Taxpayer
{
    public int ID { get; set; }
    public string TaxNumber { get; set; }

    public string? Name { get; set; }

    public string? Family { get; set; }

    public Nationality Nationality { get; set; }

    public DateTime Birthdate { get; set; }

    public string? Address { get; set; }

    public int Salary { get; set; }

    public int TaxRate { get; set; }

}