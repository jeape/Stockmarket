using System.Collections.Generic;

namespace StockPrices.Domain.Interfaces
{
    public interface IStockPrices
    {
        List<DTOs.StockPriceDto> CreateList();
    }
}