namespace sharp_21_10_2022_namespase
{
    internal class Seventh_Wonders
    {
        private string _name;
        private string _description;
        public Seventh_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Seventh_Wonders()
        {
            _name = "Seventh_Wonders";
            _description = "Любовь";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + _name, "\tпояснение\t" + _description + "\n");
        }
    }
}
