using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTradingSystemForCSharp
{
    public interface graph
    {
        // 何が必要かわからないなー
        List<object> setLabel(List<object> pLabellst);
        Dictionary<object,object> setData(List<object> pLabellst);
    }
}