
namespace BanksPortfolio
{
    public class UndefinedStrategy : IRiskStrategy
    {
        public TradeRisk Risk(ITrade trade)
        {
            return TradeRisk.UNDEFINED;
        }
    }
}