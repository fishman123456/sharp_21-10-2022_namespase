
namespace wonders
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
            Console.WriteLine("имя класса\t" + this._name
                + "\tпояснение\t" + this._description + "\n");
        }
    }
}
