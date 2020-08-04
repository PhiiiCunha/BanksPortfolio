using System;
using System.Collections.Generic;

namespace BanksPortfolio
{
    class Test
    {
        private List<String> tradeCategoriesExpected = new List<String>();

        private List<String> tradeCategories = new List<String>();

        public Test()
        {
            tradeCategoriesExpected.Add("HIGHRISK");
            tradeCategoriesExpected.Add("LOWRISK");
            tradeCategoriesExpected.Add("LOWRISK");
            tradeCategoriesExpected.Add("MEDIUMRISK");
        }

        public void Run(List<ITrade> trades)
        {
            var strategy = new TradeRiskStrategy();
            foreach (var trade in trades)
            {
                tradeCategories.Add(strategy.Risk(trade).ToString());
            }

            for (int i = 0; i < tradeCategoriesExpected.Count; i++)
            {
                Console.WriteLine(tradeCategoriesExpected[i] + ": " + tradeCategories[i].Equals(tradeCategoriesExpected[i]));
            }
        }
    }
}