namespace sharp_21_10_2022_namespase
{
    internal class Sixth_Wonders
    {
        private string _name;
        private string _description;
        public Sixth_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Sixth_Wonders()
        {
            _name = "Sixth_Wonders";
            _description = "Юльчик";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + _name, "\tпояснение\t" + _description + "\n");
        }
    }
}
