namespace HomeWork10
{
    class User
    {
        internal string lastName;
        internal string firstName;
        public User(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
    //Inheritance example2
    class Employee : User
    {
        public string position;
        public Employee(string firstName, string lastName, string position) : base(lastName, firstName)
        {
            this.position = position;
        }
    }
}