using System.Collections.Generic;
using ConvertXml.Models.OriginalXml;
using ConvertXml.Models.TranslatedXml;

namespace ConvertXml.Handlers
{
    public static class TranslateHandler
    {
        public static List<TranslatedOrderLine> HandleOrderLinesTranslation(List<OrderLine> orderLines)
        {
            List<TranslatedOrderLine> translatedOrderLines = new List<TranslatedOrderLine>();

            foreach (var order in orderLines)
            {
                TranslatedOrderLine translatedOrderLine = new TranslatedOrderLine
                {
                    Description = order.Description,
                    Price = order.Price,
                    Quantity = order.Quantity,
                    Reference = order.Reference,
                    UnitPrice = order.UnitPrice
                };
                
                translatedOrderLines.Add(translatedOrderLine);
            }

            return translatedOrderLines;
        }
    }
}