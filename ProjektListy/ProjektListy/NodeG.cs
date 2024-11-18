using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektListy
{
    public class NodeG
    {
        public List<NodeG> neighbors = new List<NodeG>();
        public int data;
        public NodeG(int liczba)
        {
            this.data = liczba;
        }
        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
