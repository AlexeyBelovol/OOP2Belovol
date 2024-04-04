using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Belovol
{
    public class PostalAddress
    {
        private string street;
        private string city;
        private string postalCode;
        private string country;

        public PostalAddress()
        {
            street = "";
            city = "";
            postalCode = "";
            country = "";
        }
        public void SetAddress(string street, string city, string postalCode, string country)
        {
            this.street = street;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
        }
        public void ClearAddress()
        {
            street = "";
            city = "";
            postalCode = "";
            country = "";
        }

        public void ClearStreet()
        {
            street = "";
        }

        public void ClearCity()
        {
            city = "";
        }

        public void ClearPostalCode()
        {
            postalCode = "";
        }

        public void ClearCountry()
        {
            country = "";
        }

        public override string ToString()
        {
            return $"{street}, {city}, {postalCode}, {country}";
        }
    }

}
