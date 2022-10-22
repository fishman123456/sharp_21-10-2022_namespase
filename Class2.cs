namespace sharp_21_10_2022_namespase
{
    internal class Second_Wonders
    {
        private string _name;
        private string _description;
        public Second_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Second_Wonders()
        {
            _name = "Second_Wonders";
            _description = "Море";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + _name,
                "\tпояснение\t" + _description + "\n");
        }
    }
}
