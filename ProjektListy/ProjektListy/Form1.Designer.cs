﻿namespace ProjektListy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddFirst = new System.Windows.Forms.Button();
            this.AddLast = new System.Windows.Forms.Button();
            this.RemoveFirst = new System.Windows.Forms.Button();
            this.RemoveLast = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Get = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ShowTree = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RemoveFromTree = new System.Windows.Forms.Button();
            this.PreOrder = new System.Windows.Forms.Button();
            this.InOrder = new System.Windows.Forms.Button();
            this.PostOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowList = new System.Windows.Forms.Button();
            this.ChodzenieGraf = new System.Windows.Forms.Button();
            this.CzestoscText = new System.Windows.Forms.TextBox();
            this.StworzDictionary = new System.Windows.Forms.Button();
            this.KodowanieHuffmana = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1000, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // AddFirst
            // 
            this.AddFirst.CausesValidation = false;
            this.AddFirst.Location = new System.Drawing.Point(6, 57);
            this.AddFirst.Name = "AddFirst";
            this.AddFirst.Size = new System.Drawing.Size(90, 39);
            this.AddFirst.TabIndex = 2;
            this.AddFirst.Text = "AddFirst";
            this.AddFirst.UseVisualStyleBackColor = true;
            this.AddFirst.Click += new System.EventHandler(this.AddFirst_Click);
            // 
            // AddLast
            // 
            this.AddLast.Location = new System.Drawing.Point(6, 102);
            this.AddLast.Name = "AddLast";
            this.AddLast.Size = new System.Drawing.Size(90, 39);
            this.AddLast.TabIndex = 3;
            this.AddLast.Text = "AddLast";
            this.AddLast.UseVisualStyleBackColor = true;
            this.AddLast.Click += new System.EventHandler(this.AddLast_Click);
            // 
            // RemoveFirst
            // 
            this.RemoveFirst.Location = new System.Drawing.Point(102, 57);
            this.RemoveFirst.Name = "RemoveFirst";
            this.RemoveFirst.Size = new System.Drawing.Size(90, 39);
            this.RemoveFirst.TabIndex = 4;
            this.RemoveFirst.Text = "RemoveFirst";
            this.RemoveFirst.UseVisualStyleBackColor = true;
            this.RemoveFirst.Click += new System.EventHandler(this.RemoveFirst_Click);
            // 
            // RemoveLast
            // 
            this.RemoveLast.Location = new System.Drawing.Point(102, 102);
            this.RemoveLast.Name = "RemoveLast";
            this.RemoveLast.Size = new System.Drawing.Size(90, 39);
            this.RemoveLast.TabIndex = 5;
            this.RemoveLast.Text = "RemoveLast";
            this.RemoveLast.UseVisualStyleBackColor = true;
            this.RemoveLast.Click += new System.EventHandler(this.RemoveLast_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(224, 83);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(59, 31);
            this.Get.TabIndex = 7;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(19, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(416, 359);
            this.treeView1.TabIndex = 9;
            // 
            // ShowTree
            // 
            this.ShowTree.Location = new System.Drawing.Point(110, 423);
            this.ShowTree.Name = "ShowTree";
            this.ShowTree.Size = new System.Drawing.Size(100, 53);
            this.ShowTree.TabIndex = 10;
            this.ShowTree.Text = "AddToTree";
            this.ShowTree.UseVisualStyleBackColor = true;
            this.ShowTree.Click += new System.EventHandler(this.ShowTree_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(159, 397);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // RemoveFromTree
            // 
            this.RemoveFromTree.Location = new System.Drawing.Point(216, 423);
            this.RemoveFromTree.Name = "RemoveFromTree";
            this.RemoveFromTree.Size = new System.Drawing.Size(100, 53);
            this.RemoveFromTree.TabIndex = 12;
            this.RemoveFromTree.Text = "RemoveFromTree";
            this.RemoveFromTree.UseVisualStyleBackColor = true;
            this.RemoveFromTree.Click += new System.EventHandler(this.RemoveFromTree_Click);
            // 
            // PreOrder
            // 
            this.PreOrder.Location = new System.Drawing.Point(441, 78);
            this.PreOrder.Name = "PreOrder";
            this.PreOrder.Size = new System.Drawing.Size(110, 87);
            this.PreOrder.TabIndex = 13;
            this.PreOrder.Text = "PreOrder";
            this.PreOrder.UseVisualStyleBackColor = true;
            this.PreOrder.Click += new System.EventHandler(this.PreOrder_Click);
            // 
            // InOrder
            // 
            this.InOrder.Location = new System.Drawing.Point(441, 171);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(110, 87);
            this.InOrder.TabIndex = 14;
            this.InOrder.Text = "InOrder";
            this.InOrder.UseVisualStyleBackColor = true;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // PostOrder
            // 
            this.PostOrder.Location = new System.Drawing.Point(441, 264);
            this.PostOrder.Name = "PostOrder";
            this.PostOrder.Size = new System.Drawing.Size(110, 87);
            this.PostOrder.TabIndex = 15;
            this.PostOrder.Text = "PostOrder";
            this.PostOrder.UseVisualStyleBackColor = true;
            this.PostOrder.Click += new System.EventHandler(this.PostOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.PostOrder);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.InOrder);
            this.groupBox1.Controls.Add(this.ShowTree);
            this.groupBox1.Controls.Add(this.PreOrder);
            this.groupBox1.Controls.Add(this.RemoveFromTree);
            this.groupBox1.Location = new System.Drawing.Point(39, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 486);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowList);
            this.groupBox2.Controls.Add(this.AddFirst);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.RemoveFirst);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.Get);
            this.groupBox2.Controls.Add(this.AddLast);
            this.groupBox2.Controls.Add(this.RemoveLast);
            this.groupBox2.Location = new System.Drawing.Point(623, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // ShowList
            // 
            this.ShowList.Location = new System.Drawing.Point(312, 57);
            this.ShowList.Name = "ShowList";
            this.ShowList.Size = new System.Drawing.Size(75, 57);
            this.ShowList.TabIndex = 9;
            this.ShowList.Text = "ShowList";
            this.ShowList.UseVisualStyleBackColor = true;
            this.ShowList.Click += new System.EventHandler(this.ShowList_Click);
            // 
            // ChodzenieGraf
            // 
            this.ChodzenieGraf.Location = new System.Drawing.Point(740, 283);
            this.ChodzenieGraf.Name = "ChodzenieGraf";
            this.ChodzenieGraf.Size = new System.Drawing.Size(75, 23);
            this.ChodzenieGraf.TabIndex = 18;
            this.ChodzenieGraf.Text = "button1";
            this.ChodzenieGraf.UseVisualStyleBackColor = true;
            this.ChodzenieGraf.Click += new System.EventHandler(this.ChodzenieGraf_Click);
            // 
            // CzestoscText
            // 
            this.CzestoscText.Location = new System.Drawing.Point(782, 397);
            this.CzestoscText.Name = "CzestoscText";
            this.CzestoscText.Size = new System.Drawing.Size(147, 20);
            this.CzestoscText.TabIndex = 19;
            // 
            // StworzDictionary
            // 
            this.StworzDictionary.Location = new System.Drawing.Point(804, 423);
            this.StworzDictionary.Name = "StworzDictionary";
            this.StworzDictionary.Size = new System.Drawing.Size(102, 23);
            this.StworzDictionary.TabIndex = 20;
            this.StworzDictionary.Text = "CreateDictionary";
            this.StworzDictionary.UseVisualStyleBackColor = true;
            this.StworzDictionary.Click += new System.EventHandler(this.StworzDictionary_Click);
            // 
            // KodowanieHuffmana
            // 
            this.KodowanieHuffmana.Location = new System.Drawing.Point(697, 460);
            this.KodowanieHuffmana.Name = "KodowanieHuffmana";
            this.KodowanieHuffmana.Size = new System.Drawing.Size(118, 23);
            this.KodowanieHuffmana.TabIndex = 21;
            this.KodowanieHuffmana.Text = "KodowanieHuffmana";
            this.KodowanieHuffmana.UseVisualStyleBackColor = true;
            this.KodowanieHuffmana.Click += new System.EventHandler(this.KodowanieHuffmana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1051, 632);
            this.Controls.Add(this.KodowanieHuffmana);
            this.Controls.Add(this.StworzDictionary);
            this.Controls.Add(this.CzestoscText);
            this.Controls.Add(this.ChodzenieGraf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Listy i drzewa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddFirst;
        private System.Windows.Forms.Button AddLast;
        private System.Windows.Forms.Button RemoveFirst;
        private System.Windows.Forms.Button RemoveLast;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button ShowTree;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button RemoveFromTree;
        private System.Windows.Forms.Button PreOrder;
        private System.Windows.Forms.Button InOrder;
        private System.Windows.Forms.Button PostOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ShowList;
        private System.Windows.Forms.Button ChodzenieGraf;
        private System.Windows.Forms.TextBox CzestoscText;
        private System.Windows.Forms.Button StworzDictionary;
        private System.Windows.Forms.Button KodowanieHuffmana;
    }
}

