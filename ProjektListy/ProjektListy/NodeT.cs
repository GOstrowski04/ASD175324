using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektListy
{
    public class NodeT
    {
        public NodeT rodzic;
        public NodeT lewe;
        public NodeT prawe;
        public int data;
        public NodeT(int liczba)
        {
            this.data = liczba;
        }
        public NodeT(int liczba, NodeT lewe, NodeT prawe)
        {
            this.lewe = lewe;
            this.prawe = prawe;
            this.data = liczba;
        }
        void Connect(NodeT dziecko)
        {
            rodzic = this;
            dziecko.rodzic = this;
            if (dziecko.data < rodzic.data)
            {
                rodzic.lewe = dziecko;
            }
            else rodzic.prawe = dziecko;
        }
        public NodeT Min(NodeT root)
        {
            while (root.lewe != null)
            {
                root = root.lewe;
            }
            return root;
        }
    }
}
