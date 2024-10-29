using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
jeśli liczba jest mniejsza to na lewo, inaczej na prawo
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
                AddRecursive(root, liczba);
            }
        }

        private void AddRecursive(NodeT aktualny, int liczba)
        {
            if (liczba < aktualny.data)
            {
                if (aktualny.lewe == null)
                {
                    aktualny.lewe = new NodeT(liczba) { rodzic = aktualny };
                }
                else
                {
                    AddRecursive(aktualny.lewe, liczba);
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
                    AddRecursive(aktualny.prawe, liczba);
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
    }
}
