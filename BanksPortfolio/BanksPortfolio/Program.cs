using System;
using System.Collections.Generic;

namespace BanksPortfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new TradeRiskStrategy();

            var portfolio = new List<ITrade>();
            var tradeCategories = new List<String>();
            portfolio.Add(new Trade(2000000, "Private"));
            portfolio.Add(new Trade(400000, "Public"));
            portfolio.Add(new Trade(500000, "Public"));
            portfolio.Add(new Trade(3000000, "Public"));

            foreach (var trade in portfolio)
            {
                tradeCategories.Add(strategy.Risk(trade).ToString());
            }

            var test = new Test();
            test.Run(portfolio);

            Console.ReadKey();
        }
    }
}