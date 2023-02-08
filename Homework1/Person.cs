namespace Homework1
{
    internal class Person
    {
        string name;
        int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            if (age <= 0)
            {
                System.Console.WriteLine("Age cannot negative ");
                System.Console.WriteLine("Therefore, the minimum age assigned is 0");
                Age = 0;
            }
            else
            {
                Age = age;
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + "; Age: " + Age;
        }
    }
}
