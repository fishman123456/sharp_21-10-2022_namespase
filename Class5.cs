
namespace sharp_21_10_2022_namespase
{
    internal class Fifth_Wonders
    {
        private string _name;
        private string _description;
        public Fifth_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Fifth_Wonders()
        {
            _name = "Fifth_Wonders";
            _description = "Тайга";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + _name, "\tпояснение\t" + _description + "\n");
        }
    }
}
