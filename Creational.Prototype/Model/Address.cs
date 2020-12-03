
namespace Creational.Prototype.Model
{
    public class Address
    {
        public string City { get; private set; }
        public string Street { get; private set; }
        public int HouseNumber { get; private set; }

        public Address(string city, string street, int houseNumber)
        {
            this.City = city;
            this.Street = street;
            this.HouseNumber = houseNumber;
        }

        public void ChangeCity(string newCity)
        {
            this.City = newCity;
        }

        public void ChangeStreet(string newStreet)
        {
            this.Street = newStreet;
        }

        public void ChangeHouseNumber(int newHouseNumber)
        {
            this.HouseNumber = newHouseNumber;
        }
    }
}
