using System.Collections.Generic;

namespace StockPrices.Interfaces
{
    public interface IStockPrices
    {
        List<DTOs.StockPriceDto> CreateList();
    }
}