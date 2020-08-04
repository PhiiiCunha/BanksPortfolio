
namespace BanksPortfolio
{
    public class PublicSector : IRiskStrategy
    {
        public TradeRisk Risk(ITrade trade)
        {
            if (trade.Value < 1000000)
            {
                return TradeRisk.LOWRISK;
            }

            return TradeRisk.MEDIUMRISK;
        }
    }
}