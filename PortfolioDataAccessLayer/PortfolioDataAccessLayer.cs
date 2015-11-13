using System;
using System.Collections.Generic;
using System.Linq;
using PortfolioDataAccessLayer.Properties;

namespace PortfolioDataAccessLayer
{
    public class PortfolioDataAccessLayer
    {
        public PortfolioDataAccessLayer()
        {
            DataContext = new PortfolioDataContext(Settings.Default.PortfolioDatabaseConnectionString);
        }

        public PortfolioDataContext DataContext { get; set; }

        // Coupon

        public List<Coupon> ShowCoupons()
        {
            return (from coupon in DataContext.Coupon
                    orderby coupon.StartDate
                    select coupon).ToList();
        }

        public Coupon ShowCoupons(decimal oldValue)
        {
            return (from coupon in DataContext.Coupon
                    where coupon.Value.Equals(oldValue)
                    select coupon).Single();
        }

        public bool InsertCoupons(Coupon newCoupon)
        {
            try
            {
                DataContext.Coupon.InsertOnSubmit(newCoupon);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool EditCoupons(decimal oldValue, Coupon newCoupon)
        {
            try
            {
                Coupon editableCoupon = DataContext.Coupon.Single(c => c.Value == oldValue);
                editableCoupon.Value = newCoupon.Value;
                editableCoupon.StartDate = newCoupon.StartDate;
                editableCoupon.LastDate = newCoupon.LastDate;
                editableCoupon.Frequency = newCoupon.Frequency;
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool DeleteCoupons(Coupon oldCoupon)
        {
            try
            {
                DataContext.Coupon.DeleteOnSubmit(oldCoupon);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        // PriceHistory

        public List<PriceHistory> ShowPriceHistorys()
        {
            return (from priceHistory in DataContext.PriceHistory
                    orderby priceHistory.Time
                    select priceHistory).ToList();
        }

        public PriceHistory ShowPriceHistorys(DateTime oldTime)
        {
            return (from priceHistory in DataContext.PriceHistory
                    where priceHistory.Time.Equals(oldTime)
                    select priceHistory).Single();
        }

        public bool InsertPriceHistorys(PriceHistory newPriceHistory)
        {
            try
            {
                DataContext.PriceHistory.InsertOnSubmit(newPriceHistory);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool EditPriceHistorys(DateTime oldTime, PriceHistory newPriceHistory)
        {
            try
            {
                PriceHistory editablePriceHistory = DataContext.PriceHistory.Single(c => c.Time == oldTime);
                editablePriceHistory.Time = newPriceHistory.Time;
                editablePriceHistory.Price = newPriceHistory.Price;
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool DeletePriceHistorys(PriceHistory oldPriceHistory)
        {
            try
            {
                DataContext.PriceHistory.DeleteOnSubmit(oldPriceHistory);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        // Stock

        public List<Stock> ShowStocks()
        {
            return (from stock in DataContext.Stock
                    orderby stock.Id
                    select stock).ToList();
        }

        public Stock ShowStocks(int oldId)
        {
            return (from stock in DataContext.Stock
                    where stock.Id.Equals(oldId)
                    select stock).Single();
        }

        public bool InsertStocks(Stock newStock)
        {
            try
            {
                DataContext.Stock.InsertOnSubmit(newStock);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool EditStocks(int oldId, Stock newStock)
        {
            try
            {
                Stock editableStock = DataContext.Stock.Single(c => c.Id == oldId);
                editableStock.Id = newStock.Id;
                editableStock.PriceHistory = newStock.PriceHistory;
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool DeleteStocks(Stock oldStock)
        {
            try
            {
                DataContext.Stock.DeleteOnSubmit(oldStock);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        // Bond

        public List<Bond> ShowBonds()
        {
            return (from bond in DataContext.Bond
                    orderby bond.Id
                    select bond).ToList();
        }

        public Bond ShowBonds(int oldId)
        {
            return (from bond in DataContext.Bond
                    where bond.Id.Equals(oldId)
                    select bond).Single();
        }

        public bool InsertBonds(Bond newBond)
        {
            try
            {
                DataContext.Bond.InsertOnSubmit(newBond);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool EditBonds(int oldId, Bond newBond)
        {
            try
            {
                Bond editableBond = DataContext.Bond.Single(c => c.Id == oldId);
                editableBond.Id = newBond.Id;
                editableBond.PriceHistory = newBond.PriceHistory;
                editableBond.Coupon = newBond.Coupon;
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool DeleteBonds(Bond oldBond)
        {
            try
            {
                DataContext.Bond.DeleteOnSubmit(oldBond);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        // Portfolio

        public List<Portfolio> ShowPortfolios()
        {
            return (from portFolio in DataContext.Portfolio
                    orderby portFolio.Name
                    select portFolio).ToList();
        }

        public Portfolio ShowPortfolios(String oldName)
        {
            return (from portfolio in DataContext.Portfolio
                    where portfolio.Name.Equals(oldName)
                    select portfolio).Single();
        }

        public List<int> ShowPortfoliosStocksQuantitys()
        {
            return (from portfolio in DataContext.Portfolio
                    orderby portfolio.Time
                    select portfolio.StockQuantity).ToList();
        }

        public List<int> ShowPortfoliosBondsQuantitys()
        {
            return (from portfolio in DataContext.Portfolio
                    orderby portfolio.Time
                    select portfolio.BondQuantity).ToList();
        }

        public decimal ShowPortfoliosStocksUnitaryMarketValue(DateTime time)
        {
            return (from portfolio in DataContext.Portfolio
                    join stock in DataContext.Stock
                        on portfolio.Stock equals stock.Id
                    join priceHistory in DataContext.PriceHistory
                        on stock.PriceHistory equals priceHistory.Id
                    where priceHistory.Time.Equals(time)
                    orderby portfolio.Time
                    select priceHistory.Price).Single();
        }

        public decimal ShowPortfoliosStocksUnitaryMarketValue()
        {
            return (from portfolio in DataContext.Portfolio
                    join stock in DataContext.Stock
                        on portfolio.Stock equals stock.Id
                    join priceHistory in DataContext.PriceHistory
                        on stock.PriceHistory equals priceHistory.Id
                    orderby portfolio.Time
                    select priceHistory.Price).Single();
        }

        public decimal ShowPortfoliosBondsUnitaryMarketValue(DateTime time)
        {
            return (from portfolio in DataContext.Portfolio
                    join bond in DataContext.Bond
                        on portfolio.Bond equals bond.Id
                    join coupon in DataContext.Coupon
                        on bond.Coupon equals coupon.Id
                    where coupon.StartDate <= time && time <= coupon.LastDate
                    orderby portfolio.Time
                    select coupon.Value).Sum() +
                   (from portfolio in DataContext.Portfolio
                    join bond in DataContext.Bond
                        on portfolio.Bond equals bond.Id
                    join priceHistory in DataContext.PriceHistory
                        on bond.PriceHistory equals priceHistory.Id
                    where priceHistory.Time.Equals(time)
                    orderby portfolio.Time
                    select priceHistory.Price).Single();
        }

        public List<decimal> ShowPortfoliosWeight(DateTime time)
        {
            return MarketValueStocks(time).
                Select(marketValue => (marketValue)/MarketValueStocks().Sum()).ToList();
        }

        public List<decimal> ShowPortfoliosWeight()
        {
            return MarketValueStocks().
                Select(marketValue => (marketValue)/MarketValueStocks().Sum()).ToList();
        }

        public bool InsertPortfolios(Portfolio newPortfolio)
        {
            try
            {
                DataContext.Portfolio.InsertOnSubmit(newPortfolio);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool EditPortfolios(int oldId, Portfolio newPortfolio)
        {
            try
            {
                Portfolio editablePortfolio = DataContext.Portfolio.Single(c => c.Id == oldId);
                editablePortfolio.Id = newPortfolio.Id;
                editablePortfolio.Name = newPortfolio.Name;
                editablePortfolio.Time = newPortfolio.Time;
                editablePortfolio.Bond = newPortfolio.Bond;
                editablePortfolio.BondQuantity = newPortfolio.BondQuantity;
                editablePortfolio.Stock = newPortfolio.Stock;
                editablePortfolio.StockQuantity = newPortfolio.StockQuantity;
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public bool DeletePortfolios(Portfolio oldPortfolio)
        {
            try
            {
                DataContext.Portfolio.DeleteOnSubmit(oldPortfolio);
                DataContext.SubmitChanges();
                return true;
            }
            catch (Exception) /*FIXME*/
            {
                return false;
            }
        }

        public List<decimal> MarketValueStocks(DateTime time)
        {
            return ShowPortfoliosStocksQuantitys().
                Select(stockQuantity => (stockQuantity*ShowPortfoliosStocksUnitaryMarketValue(time))).ToList();
        }

        public List<decimal> MarketValueStocks()
        {
            return ShowPortfoliosStocksQuantitys().
                Select(stockQuantity => (stockQuantity*ShowPortfoliosStocksUnitaryMarketValue())).ToList();
        }

        public List<bool> MarketValueStocksCheck(DateTime time)
        {
            return MarketValueStocks(time).
                Select(marketValue => marketValue > 10000).ToList();
        }

        public List<decimal> MarketValueBonds(DateTime time)
        {
            return ShowPortfoliosBondsQuantitys().
                Select(stockQuantity => (stockQuantity*ShowPortfoliosBondsUnitaryMarketValue(time))).ToList();
        }

        public List<bool> MarketValueBondsCheck(DateTime time)
        {
            return MarketValueBonds(time).
                Select(marketValue => marketValue > 10000).ToList();
        }

        public decimal StockWeight(DateTime time)
        {
            return ShowPortfoliosWeight(time).Sum()/ShowPortfoliosWeight().Sum()*100;
        }

        public bool StockWeightCheck(DateTime time)
        {
            return Decimal.Compare(StockWeight(time), new decimal(0.4)) > 0;
        }
    }
}