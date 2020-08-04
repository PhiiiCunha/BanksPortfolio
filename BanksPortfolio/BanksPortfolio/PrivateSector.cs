
namespace BanksPortfolio
{
    public class PrivateSector : IRiskStrategy
    {
        public TradeRisk Risk(ITrade trade)
        {
            if (trade.Value > 1000000)
            {
                return TradeRisk.HIGHRISK;
            }

            return TradeRisk.UNDEFINED;
        }
    }
}