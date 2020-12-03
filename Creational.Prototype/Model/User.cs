using System;

namespace Creational.Prototype.Model
{
    public class User : ICloneable<User>
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public Address UserAddress { get; private set; }

        public User(string userName, string email, Address address)
        {
            this.Id = Guid.NewGuid();
            this.UserName = userName;
            this.Email = email;
            this.UserAddress = address;
        }

        public void ChangeUserName(string newUserName)
        {
            this.UserName = newUserName;
        }

        public void ChangeUserEmail(string newEmail)
        {
            this.Email = newEmail;
        }

        public void ChangeAddress(Address newAddress)
        {
            this.UserAddress = newAddress;
        }

        public User DeepCopy()
        {
            User clone = this.MemberwiseClone() as User;
            clone.UserAddress = new Address(new String(this.UserAddress.City), 
                                            new String(this.UserAddress.Street), 
                                            this.UserAddress.HouseNumber);

            clone.UserName = new String(this.UserName);
            clone.Email    = new String(this.Email);

            return clone;
        }

        public User ShallowCopy()
        {
            return this.MemberwiseClone() as User;
        }

        public override string ToString()
        {
            string result = $"Id: {this.Id}, Username: {this.UserName}, Email: {this.Email}, City: {this.UserAddress.City}, Street: {this.UserAddress.Street}";

            return result;
        }
    }
}
