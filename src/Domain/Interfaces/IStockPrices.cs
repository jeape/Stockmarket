using System.Collections.Generic;

using StockMarket.Domain.Entities;

namespace StockMarket.Domain.Interfaces
{
    public interface IStockPrices
    {
        List<StockPriceDto> CreateList();
    }
}