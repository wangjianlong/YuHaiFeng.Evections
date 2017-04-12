using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Parameters
{
    public class PageParameter
    {
        public PageParameter() : this(1, 20)
        {
        }

        public PageParameter(int page, int limit)
        {
            PageIndex = page < 1 ? 1 : page;
            PageSize = limit < 1 ? 20 : limit;
        }
        public PageParameter(int? page, int? limit)
        {
            PageIndex = page.HasValue ? page.Value < 1 ? 1 : page.Value : 1;
            PageSize = limit.HasValue ? limit.Value < 1 ? 20 : limit.Value : 20;
        }
        public int RecordCount { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }


        public int PageCount
        {
            get
            {
                var count = RecordCount / PageSize + (RecordCount % PageSize > 0 ? 1 : 0);
                return count < 1 ? 1 : count;
            }
        }
    }
}