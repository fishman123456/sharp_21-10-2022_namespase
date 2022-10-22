namespace sharp_21_10_2022_namespase
{
    internal class Third_Wonders
    {
        private string _name;
        private string _description;
        public Third_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Third_Wonders()
        {
            _name = "Third_Wonders";
            _description = "Земля";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + _name,
                "\tпояснение\t" + _description + "\n");
        }
    }
}
