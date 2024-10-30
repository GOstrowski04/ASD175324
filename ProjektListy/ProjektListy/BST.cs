using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
jeśli liczba jest mniejsza to na lewo, inaczej na prawo
Usuwanie konkretnego węzła:
1) Gdy węzeł nie ma dzieci - odwiązanie z dwóch kierunków i zwrócić węzeł
2) Gdy węzeł ma jedno dziecko - odwiązanie dziecka i powiązanie go z rodzicem usuwanego
3) Gdy węzeł ma dwoje dzieci - patrzę na prawe poddrzewo i w nim szukam najmniejszego elementu (na samym końcu lewej gałęzi, może mieć 0 lub 1 dzieci
, jeśli jeden to używamy 2)
Chodzenie po drzewie:
trzeba użyć rekurencji
*/
namespace ProjektListy
{
    public class BST
    {
        public NodeT root;
        public void Add(int liczba)
        {
            if (root == null)
            {
                root = new NodeT(liczba);
            }
            else
            {
                AddR(root, liczba);
            }
        }
        private NodeT SzukajRodzica(NodeT dziecko)
        {
            NodeT rodzic = root;
            while (true)
            {
                if (dziecko.data < rodzic.data && rodzic.lewe == null) break;
                else if (dziecko.data < rodzic.data && rodzic.lewe != null) rodzic = rodzic.lewe;
                else if (rodzic.prawe == null) break;
                else  rodzic = rodzic.prawe;
            }
            return rodzic;
        }
        private void AddR(NodeT aktualny, int liczba)
        {
            if (liczba < aktualny.data)
            {
                if (aktualny.lewe == null)
                {
                    aktualny.lewe = new NodeT(liczba) { rodzic = aktualny };
                }
                else
                {
                    AddR(aktualny.lewe, liczba);
                }
            }
            else
            {
                if (aktualny.prawe == null)
                {
                    aktualny.prawe = new NodeT(liczba) { rodzic = aktualny };
                }
                else
                {
                    AddR(aktualny.prawe, liczba);
                }
            }
        }
        public void PopulateTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            if (root != null)
            {
                TreeNode rootNode = new TreeNode(root.data.ToString());
                treeView.Nodes.Add(rootNode);
                PopulateTreeNode(rootNode, root);
            }
        }

        private void PopulateTreeNode(TreeNode treeNode, NodeT node)
        {
            if (node.lewe != null)
            {
                TreeNode leftNode = new TreeNode(node.lewe.data.ToString());
                treeNode.Nodes.Add(leftNode);
                PopulateTreeNode(leftNode, node.lewe);
            }

            if (node.prawe != null)
            {
                TreeNode rightNode = new TreeNode(node.prawe.data.ToString());
                treeNode.Nodes.Add(rightNode);
                PopulateTreeNode(rightNode, node.prawe);
            }
        }
        // 8 3 1 4 3 2 9
        void CPD(NodeT wezel)
        {
            if (wezel == null) return;
            // 1 miejsce pre-order 8 3 1 2 4 3 9

            CPD(wezel.lewe);
            // 2 miejsce in-order wartość węzła od końca po sprawdzeniu lewej strony wypisuje 1 2 3 3 4 8 9 

            CPD(wezel.prawe);
            // 3 miejsce post-order wartość węzła od końca po sprawdzeniu praweje stronu wypisuje 2 1 3 4 3 9 8

        }
    }
}
