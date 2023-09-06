using Services;
using Shared.Entities;
using Shared.Enums;

namespace TaxSystemTest
{
    public class TaxPayerTests
    {
        Taxpayer taxPayer;
        public TaxPayerTests()
        {
            //Arrange
            taxPayer = new Taxpayer
            {
                TaxNumber = "SG123439354",
                Name = "Ali",
                Family = "Kolahdoozan",
                Address = "MY-KL-ST2",
                Birthdate = new DateTime(1982, 09, 03),
                Salary = 2500,
                Nationality = Nationality.Iran
            };
        }
        [Fact]
        public void IranianNationalities_BaseTaxRate_Shouldbe_12PC()
        {
            // Act
            var basetaxrate = (new TaxCalculator()).NationalityBaseTaxRateIndicator(taxPayer);

            // Assert
            Assert.Equal(12, basetaxrate);
        }
        [Fact]
        public void IranianNationalities_WithMorethan500USDSalary_TaxRate_Shouldbe_20PC()
        {
            // Act
            var taxrate = (new TaxCalculator()).CalculateTax(taxPayer);

            // Assert
            Assert.Equal(20, taxrate);
        }

    }
}
