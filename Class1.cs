
namespace sharp_21_10_2022_namespase
{
    internal class First_Wonders
    {
        private string _name;
        private string _description;
        public First_Wonders(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public First_Wonders()
        {
            _name = "One_Wonders";
            _description = "Небо";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t"+_name,
                "\tпояснение\t"+ _description+"\n");
        }
    }
}
