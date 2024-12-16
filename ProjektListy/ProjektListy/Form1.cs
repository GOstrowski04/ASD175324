using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektListy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            A.neighbors.AddRange(new List<NodeG> {B, C});
            B.neighbors.AddRange(new List<NodeG> {A, D, E});
            C.neighbors.AddRange(new List<NodeG> {A, D, F});
            D.neighbors.AddRange(new List<NodeG> {B, C, F});
            E.neighbors.AddRange(new List<NodeG> {B, F});
            F.neighbors.AddRange(new List<NodeG> {C, D, E, G});
            G.neighbors.AddRange(new List<NodeG> {F});
            g1.nodes.AddRange(new List<NodeG> {A, B, C, D, E, F, G});

        }
        List lista = new List();
        BST bst = new BST();
        NodeG A = new NodeG(1);
        NodeG B = new NodeG(2);
        NodeG C = new NodeG(7);
        NodeG D = new NodeG(3);
        NodeG E = new NodeG(6);
        NodeG F = new NodeG(4);
        NodeG G = new NodeG(5);
        Graf g1 = new Graf();
        List<NodeT> listT = new List<NodeT>();
        private void AddFirst_Click(object sender, EventArgs e)
        {
            lista.AddFirst(int.Parse(textBox2.Text));
            textBox1.Text = lista.ToString();
        }

        private void AddLast_Click(object sender, EventArgs e)
        {
            lista.AddLast(int.Parse(textBox2.Text));
            textBox1.Text = lista.ToString();
        }

        private void RemoveFirst_Click(object sender, EventArgs e)
        {
            lista.RemoveFirst();
            textBox1.Text = lista.ToString();
        }

        private void RemoveLast_Click(object sender, EventArgs e)
        {
            lista.RemoveLast();
            textBox1.Text = lista.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent non-numeric input
            }
        }

        private void Get_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) >= 0 && int.Parse(textBox3.Text) < lista.count)
            {
                textBox4.Text = lista.Get(int.Parse(textBox3.Text)).ToString();
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent non-numeric input
            }
        }


        private void ShowTree_Click(object sender, EventArgs e)
        {
            int liczba;
            if (int.TryParse(textBox5.Text, out liczba))
            {
                bst.Add(liczba);
                bst.PopulateTreeView(treeView1);
                treeView1.ExpandAll();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }    
        }

        private void RemoveFromTree_Click(object sender, EventArgs e)
        {
            int liczba;
            if (int.TryParse(textBox5.Text, out liczba))
            {
                bst.Remove(liczba);
                bst.PopulateTreeView(treeView1);
                treeView1.ExpandAll();
            }
        }

        private void PreOrder_Click(object sender, EventArgs e)
        {
            textBox1.Text = bst.PreOrder(bst.root);
        }

        private void InOrder_Click(object sender, EventArgs e)
        {
            textBox1.Text = bst.InOrder(bst.root);
        }

        private void PostOrder_Click(object sender, EventArgs e)
        {
            textBox1.Text = bst.PostOrder(bst.root);
        }

        private void ShowList_Click(object sender, EventArgs e)
        {
            textBox1.Text = lista.ToString();
        }

        private void ChodzenieGraf_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            List<NodeG> test = g1.chodzenieWszerz(g1.nodes[0]);
            for (int i = 0; i < test.Count; i++)
            {
                textBox1.Text += test[i].ToString();
                textBox1.Text += ' ';
            }
        }
        private void sortListT()
        {
            listT = listT.OrderBy(node => node.data).ThenBy(node => node.GetType() == typeof(NodeT) ? 0 : 1).ToList();
        }
        private void StworzDictionary_Click(object sender, EventArgs e)
        {
            listT.Clear();
            Dictionary<char, int> tempD = new Dictionary<char, int>();
            string temp = CzestoscText.Text;
            int i = -1;
            foreach (char c in temp)
            {
                if (tempD.ContainsKey(c) == false)
                {
                    tempD[c] = 0;
                    listT.Add(new NodeGS(0, c));
                }
                tempD[c] += 1;
            }
            foreach(var c in tempD)
            {
                listT.Add(new NodeGS(c.Value, c.Key));
            }
            sortListT();
        }

        private void KodowanieHuffmana_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listT.Count-1; i+=2)
            {
                int tempNewG = listT[i].data + listT[i + 1].data;
                listT.Add(new NodeT(tempNewG, listT[i], listT[i + 1]));
            }
        }
    }
}
