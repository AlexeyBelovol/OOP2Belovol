
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

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
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

