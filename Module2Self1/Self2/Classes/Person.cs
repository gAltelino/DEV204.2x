namespace Self2
{
    public abstract class Person
    {

        public string Name;

        public string PersonName()
        {
            return this.Name;
        }

        public Person(string name)
        {
            this.Name = name;
        }

    }
}