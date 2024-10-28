using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektListy
{
    public class NodeT
    {
        NodeT rodzic;
        NodeT lewe;
        NodeT prawe;
        int data;
        public NodeT(int liczba)
        {
            this.data = liczba;
        }
    }
}
