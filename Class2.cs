namespace wonders
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
            _description = "Любовь";
        }
        public void Print()
        {
            Console.WriteLine("имя класса\t" + this._name
                + "\tпояснение\t" + this._description + "\n");
        }
    }
}
