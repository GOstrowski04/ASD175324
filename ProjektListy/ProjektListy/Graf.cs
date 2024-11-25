using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// przechodzenie w głąb: tak jak drzewo, do najbliższego sąsiada aż się nie zapętli, zaznacza się odwiedzone potem do pierwszego sąsiada i zaznacza go do odwiedzonych
/// potem tak samo z B, pierwszym sąsiadem jest A więc idzie do nastepnego czyli D, dodaje go do i idzie do niego. W przypadku G kończy się odwiedzanie G i wraca się do F
/// na koniec wraca się do A i kończy
namespace ProjektListy
{
    public class Graf
    {
        public List<NodeG> nodes = new List<NodeG>();
        private bool checkIfIn(List<NodeG> nodes, NodeG node)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] == node) return true;
            }
            return false;
        }
        public List<NodeG> chodzenieWszerz(NodeG start)
        {
            List<NodeG> temp = new List<NodeG>();
            temp.Add(start);
            for (int i = 0; i < temp.Count; i++)
            {
                NodeG node = temp[i];
                for (int j = 0; j < node.neighbors.Count; j++)
                {
                    if (checkIfIn(temp, node.neighbors[j]) == false)
                    {
                        temp.Add(node.neighbors[j]);
                    }
                }
            }
            return temp;
        }
        public List<NodeG> chodzenieWGlab(NodeG start)
        {
            List<NodeG> visited = new List<NodeG>();
            Stack<NodeG> stack = new Stack<NodeG>();

            stack.Push(start);

            while (stack.Count > 0)
            {
                NodeG current = stack.Pop();

                if (!checkIfIn(visited, current))
                {
                    visited.Add(current);
                    for (int i = current.neighbors.Count - 1; i >= 0; i--)
                    {
                        NodeG neighbor = current.neighbors[i];
                        if (!checkIfIn(visited, neighbor))
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }
            return visited;
        }
    }
}
