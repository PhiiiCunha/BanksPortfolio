
namespace BanksPortfolio
{
    interface IRiskStrategy
    {
        TradeRisk Risk(ITrade trade);
    }
}