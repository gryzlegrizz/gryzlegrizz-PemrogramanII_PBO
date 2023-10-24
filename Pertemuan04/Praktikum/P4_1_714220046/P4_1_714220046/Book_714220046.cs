using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220046
{
    public class Book_714220046: Product_714220046
    {
        protected string pageCount;

        public Book_714220046(string type, string title, string pageCount): base(type, title)
        {
            this.pageCount = pageCount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
