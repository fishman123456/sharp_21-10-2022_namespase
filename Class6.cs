namespace wonders
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
            _description = "Море";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + this._name
                + "\tпояснение\t" + this._description + "\n");
        }
    }
}
