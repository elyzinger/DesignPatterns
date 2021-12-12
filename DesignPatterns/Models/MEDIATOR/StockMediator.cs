using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.MEDIATOR
{
    class StockMediator : Mediator
    {
        private List<Colleague> colleagues;
        private List<StockOffer> saleStocks;
        private List<StockOffer> buyStocks;

        private int colleagueCodes = 0;

        public StockMediator()
        {
            colleagues = new List<Colleague>();
            saleStocks = new List<StockOffer>();
            buyStocks = new List<StockOffer>();
        }
        public void AddColleague(Colleague colleague)
        {
            colleagues.Add(colleague);
            colleagueCodes++;
            colleague.ColleagueCode = colleagueCodes;
        }

        public void BuyOffer(string stock, int shares, int collCode)
        {
            bool stockSold = false;
            foreach(StockOffer stockOffer in saleStocks)
            {
                if(stockOffer.StockSymble ==  stock && stockOffer.StockShares == shares)
                {
                    Console.WriteLine($"{stock} shares of {shares} bought by colleague code {stockOffer.ColleagueCode}");
                    saleStocks.Remove(stockOffer);
                    stockSold = true;
                    break;
                }

            }
            if (!stockSold)
            {
                Console.WriteLine($"{shares} of stock {stock} was added to inventory");
                StockOffer newOffering = new StockOffer(shares, stock, collCode); // this will happen if the stock was not found in sellstocks
                buyStocks.Add(newOffering);
            }
        
        }

        public void SaleOffer(string stock, int shares, int collCode)
        {
            bool stockSold = false;
            foreach (StockOffer stockOffer in buyStocks)
            {
                if (stockOffer.StockSymble == stock && stockOffer.StockShares == shares)
                {
                    Console.WriteLine($"{stock} shares of {shares} sold to colleague code {stockOffer.ColleagueCode}");
                    buyStocks.Remove(stockOffer);
                    stockSold = true;
                    break;
                }

            }
            if (!stockSold)
            {
                Console.WriteLine($"{shares} of stock {stock} was added to inventory");
                StockOffer newOffering = new StockOffer(shares, stock, collCode); // this will happen if the stock was not found in sellstocks
                saleStocks.Add(newOffering);
            }
       
        }
        public void GetStockOffers()
        {
            Console.WriteLine("Stocks For Sale:");
            foreach(StockOffer stockOffer in saleStocks)
            {
                Console.WriteLine($"{stockOffer.StockShares}  of  {stockOffer.StockSymble}");
            }
            Console.WriteLine("Stocks Buy Offer:");
            foreach (StockOffer stockOffer in buyStocks)
            {
                Console.WriteLine($"{stockOffer.StockShares}  of  {stockOffer.StockSymble}");
            }
        }

    }
}
