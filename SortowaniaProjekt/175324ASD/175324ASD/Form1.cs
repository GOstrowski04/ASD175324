using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace _175324ASD
{
    public partial class Form1 : Form
    {
        int[] tab;
        int randNum;
        int maxRand = 100;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }
        private bool stringCheck(string input)
        {
            
            var parts = input.Split(',');
            foreach (var part in parts)
            {
                if (!int.TryParse(part.Trim(), out _))
                {
                    return false;
                }
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (tab.Length > 1)
            {
                stopwatch.Start();
                for (int i = 1; i < tab.Length; i++)
                {
                    for (int j = i; j > 0; j--)
                    {
                        if (tab[j] < tab[j - 1])
                        {
                            int x = tab[j];
                            tab[j] = tab[j - 1];
                            tab[j - 1] = x;
                        }
                    }
                }
                stopwatch.Stop();
                label1.Text = "Czas sortowania: " + stopwatch.ElapsedMilliseconds + " ms";
            }
            textBox1.Text = string.Join(", ", tab);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            randNum = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] tempTab = new int[randNum];
            for (int i = 0; i < randNum; i++)
            {
                tempTab[i] = random.Next(0, maxRand);
            }
            tab = tempTab;
            textBox1.Text = string.Join(", ", tab);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (tab.Length > 1)
            {
                for (int i = tab.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                        if (tab[j] > tab[j + 1])
                        {
                            int x = tab[j];
                            tab[j] = tab[j + 1];
                            tab[j + 1] = x;
                        }
                }
            }
            stopwatch.Stop();
            label1.Text = "Czas sortowania: " + stopwatch.ElapsedMilliseconds + " ms";
            textBox1.Text = string.Join(", ", tab);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (stringCheck(textBox2.Text))
            {
                string[] stringArray = textBox2.Text.Split(',');
                int[] intArray = Array.ConvertAll(stringArray, s => int.Parse(s.Trim()));
                tab = intArray;
                textBox1.Text = string.Join(", ", tab);
            }
            else
            {
                MessageBox.Show("Źle podane dane, proszę o wpisanie liczb według schematu: x, y, z");
            }
        }
        private void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;
            int[] L = new int[n1];
            int[] R = new int[n2];
            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, middle + 1, R, 0, n2);
            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MergeSort(tab, 0, tab.Length - 1);
            stopwatch.Stop();
            label1.Text = "Czas sortowania: " + stopwatch.ElapsedMilliseconds + " ms";
            textBox1.Text = string.Join(", ", tab);
        }
        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(tab, 0, tab.Length - 1);
            stopwatch.Stop();
            label1.Text = "Czas sortowania: " + stopwatch.ElapsedMilliseconds + " ms";
            textBox1.Text = string.Join(", ", tab);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[maxRand - 0 + 1];
            int[] tempArray = new int[tab.Length];
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < tab.Length; i++)
            {
                numbers[tab[i]] += 1;
            }
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = numbers[i];
                for (int z = 0; z < x; z++)
                {
                    tempArray[j] = i;
                    j += 1;
                }
            }
            tab = tempArray;
            stopwatch.Stop();
            label1.Text = "Czas sortowania: " + stopwatch.ElapsedMilliseconds + " ms";
            textBox1.Text = string.Join(", ", tab);
        }

    }
}
