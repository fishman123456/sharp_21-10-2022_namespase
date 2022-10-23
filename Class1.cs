
namespace wonders
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
            _description = "Юльчик";
        }
        public void Print()
        {
            Console.WriteLine(
              "имя класса\t" + this._name + "\tпояснение\t" +
              this._description + "\n");
        }
    }
}
