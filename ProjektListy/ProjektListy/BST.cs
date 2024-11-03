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
        public string PreOrder(NodeT wezel)
        {
            if (wezel == null) return "";
            return wezel.data + " " + PreOrder(wezel.lewe) + PreOrder(wezel.prawe);
        }

        public string InOrder(NodeT wezel)
        {
            if (wezel == null) return "";
            return InOrder(wezel.lewe) + wezel.data + " " + InOrder(wezel.prawe);
        }
        public string PostOrder(NodeT wezel)
        {
            if (wezel == null) return "";
            return PostOrder(wezel.lewe) + PostOrder(wezel.prawe) + wezel.data + " ";
        }
        private void RemoveZero(NodeT usuwany)
        {
            if (usuwany == root)
                root = null;
            else if (usuwany.data < usuwany.rodzic.data)
            {
                usuwany.rodzic.lewe = null;
            }
            else
            {
                usuwany.rodzic.prawe = null;
            }
            usuwany.rodzic = null;
        }
        private void RemoveOne(NodeT usuwany)
        {
            NodeT child = (usuwany.lewe != null) ? usuwany.lewe : usuwany.prawe;

            if (usuwany == root)
                root = child;
            else if (usuwany.data < usuwany.rodzic.data)
                usuwany.rodzic.lewe = child;
            else
                usuwany.rodzic.prawe = child;

            child.rodzic = usuwany.rodzic;
        }
        private NodeT findNode(int n)
        {
            if (root != null)
            {
                NodeT temp = root;
                while (temp != null)
                {
                    if (n == temp.data) return temp;
                    if (n < temp.data) temp = temp.lewe;
                    else temp = temp.prawe;
                }
                return temp;
            }
            return null;
        }
        public void Remove(int n)
        {
            NodeT usuwany = findNode(n);
            if (usuwany != null)
            {
                if (usuwany.lewe == null && usuwany.prawe == null)
                {
                    RemoveZero(usuwany);
                }
                else if (usuwany.lewe != null && usuwany.prawe == null)
                {
                    RemoveOne(usuwany);
                }
                else if (usuwany.lewe == null && usuwany.prawe != null)
                {
                    RemoveOne(usuwany);
                }
                else
                {
                    NodeT tempRoot = usuwany.prawe;
                    while (tempRoot.lewe != null) tempRoot = tempRoot.lewe;
                    usuwany.data = tempRoot.data;
                    if (tempRoot.prawe == null)
                    {
                        RemoveZero(tempRoot);
                    }
                    else
                    {
                        RemoveOne(tempRoot);
                    }
                    tempRoot = null;
                }

            }
        }
    }
}
