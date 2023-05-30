namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Peter";
            person1.Age = 20;

            Person person2 = new Person(34);
            person1.Name = "George";

            Person person3 = new Person("Jose", 20);
        }
    }
}
