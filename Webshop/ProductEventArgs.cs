using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
}
