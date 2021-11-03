using System.Collections.Generic;

using StockPrices.Application.Models;

namespace StockPrices.Domain.Interfaces
{
    public interface IStockPrices
    {
        List<StockPriceDto> CreateList();
    }
}