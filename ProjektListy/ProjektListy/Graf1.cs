using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// minimalne drzewo w grafie, zwracanie grafa, jak przypadek 1 (2 node dodawany) to robi się podgraf
namespace ProjektListy
{
    public class Graf1
    {
        List<NodeG1> nodes;
        List<Edge> edges;
        Graf1(Edge k)
        {
            this.Add(k);
        }
        void Add(Edge k)
        {
            this.edges.Add(k);
            if (!this.nodes.Contains(k.start))
            {
                this.nodes.Add(k.start);
            }
            if (!this.nodes.Contains(k.end))
            {
                this.nodes.Add(k.end);
            }
        }
        int ileNowychWezlow(Edge k, Graf1 tmpG)
        {
            int tmp = 0;
            if (!tmpG.nodes.Contains(k.start))
            {
                tmp += 1;
            }
            if (!tmpG.nodes.Contains(k.end))
            {
                tmp += 1;
            }
            return tmp;
        }
        void Join(Graf1 g1)
        {
            for (int i = 0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }
        }
        /// graf wyjsciowy musi być spójny i niepusty
        Graf1 algorytmKruskala()
        {
            List<Graf1> tmp = new List<Graf1>();
            var lista = this.edges.OrderBy(e => e.weight).ToList();
            tmp.Add(new Graf1(lista[0]));
            int x = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (ileNowychWezlow(lista[i], tmp[x]) == 2)
                {

                }
            }
        }
    }
}
