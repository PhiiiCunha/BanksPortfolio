using System;
using System.Collections.Generic;

namespace BanksPortfolio
{
    public class TradeRiskStrategy : IRiskStrategy
    {
        private Dictionary<String, IRiskStrategy> strategies = new Dictionary<String, IRiskStrategy>();

        private IRiskStrategy strategyDefault = new UndefinedStrategy();

        public TradeRiskStrategy()
        {
            strategies.Add("Public", new PublicSector());
            strategies.Add("Private", new PrivateSector());
        }

        public TradeRisk Risk(ITrade trade)
        {
            return strategies.GetValueOrDefault(trade.ClientSector, strategyDefault).Risk(trade);
        }
    }
}