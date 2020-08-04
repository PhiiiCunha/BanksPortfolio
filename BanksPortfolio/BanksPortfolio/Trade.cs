
namespace BanksPortfolio
{
    class Trade : ITrade
    {
        public double Value { get; private set; }
        public string ClientSector { get; private set; }

        public Trade(double value, string sector)
        {
            Value = value;
            ClientSector = sector;
        }
    }
}