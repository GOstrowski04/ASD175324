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
        }
        List lista = new List();
        BST bst = new BST();
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
    }
}
