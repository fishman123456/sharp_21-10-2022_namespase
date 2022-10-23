namespace wonders
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
            _description = "Небо";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + this._name
                + "\tпояснение\t" + this._description + "\n");
        }
    }
}
