
namespace sharp_21_10_2022_namespase
{
    internal class Fourth_Wonders
    {
        private string _name;
        private string _description;
        public Fourth_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Fourth_Wonders()
        {
            _name = "Fourth_Wonders";
            _description = "Вода";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + _name, "\tпояснение\t" + _description + "\n");
        }
    }
}
