namespace ProjektListy
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(722, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // AddFirst
            // 
            this.AddFirst.CausesValidation = false;
            this.AddFirst.Location = new System.Drawing.Point(378, 151);
            this.AddFirst.Name = "AddFirst";
            this.AddFirst.Size = new System.Drawing.Size(90, 39);
            this.AddFirst.TabIndex = 2;
            this.AddFirst.Text = "AddFirst";
            this.AddFirst.UseVisualStyleBackColor = true;
            this.AddFirst.Click += new System.EventHandler(this.AddFirst_Click);
            // 
            // AddLast
            // 
            this.AddLast.Location = new System.Drawing.Point(474, 151);
            this.AddLast.Name = "AddLast";
            this.AddLast.Size = new System.Drawing.Size(90, 39);
            this.AddLast.TabIndex = 3;
            this.AddLast.Text = "AddLast";
            this.AddLast.UseVisualStyleBackColor = true;
            this.AddLast.Click += new System.EventHandler(this.AddLast_Click);
            // 
            // RemoveFirst
            // 
            this.RemoveFirst.Location = new System.Drawing.Point(378, 196);
            this.RemoveFirst.Name = "RemoveFirst";
            this.RemoveFirst.Size = new System.Drawing.Size(90, 39);
            this.RemoveFirst.TabIndex = 4;
            this.RemoveFirst.Text = "RemoveFirst";
            this.RemoveFirst.UseVisualStyleBackColor = true;
            this.RemoveFirst.Click += new System.EventHandler(this.RemoveFirst_Click);
            // 
            // RemoveLast
            // 
            this.RemoveLast.Location = new System.Drawing.Point(474, 196);
            this.RemoveLast.Name = "RemoveLast";
            this.RemoveLast.Size = new System.Drawing.Size(90, 39);
            this.RemoveLast.TabIndex = 5;
            this.RemoveLast.Text = "RemoveLast";
            this.RemoveLast.UseVisualStyleBackColor = true;
            this.RemoveLast.Click += new System.EventHandler(this.RemoveLast_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(600, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(600, 209);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(100, 58);
            this.Get.TabIndex = 7;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(600, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(39, 112);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(199, 201);
            this.treeView1.TabIndex = 9;
            // 
            // ShowTree
            // 
            this.ShowTree.Location = new System.Drawing.Point(39, 366);
            this.ShowTree.Name = "ShowTree";
            this.ShowTree.Size = new System.Drawing.Size(100, 53);
            this.ShowTree.TabIndex = 10;
            this.ShowTree.Text = "AddToTree";
            this.ShowTree.UseVisualStyleBackColor = true;
            this.ShowTree.Click += new System.EventHandler(this.ShowTree_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 340);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // RemoveFromTree
            // 
            this.RemoveFromTree.Location = new System.Drawing.Point(145, 366);
            this.RemoveFromTree.Name = "RemoveFromTree";
            this.RemoveFromTree.Size = new System.Drawing.Size(100, 53);
            this.RemoveFromTree.TabIndex = 12;
            this.RemoveFromTree.Text = "RemoveFromTree";
            this.RemoveFromTree.UseVisualStyleBackColor = true;
            this.RemoveFromTree.Click += new System.EventHandler(this.RemoveFromTree_Click);
            // 
            // PreOrder
            // 
            this.PreOrder.Location = new System.Drawing.Point(260, 139);
            this.PreOrder.Name = "PreOrder";
            this.PreOrder.Size = new System.Drawing.Size(75, 50);
            this.PreOrder.TabIndex = 13;
            this.PreOrder.Text = "PreOrder";
            this.PreOrder.UseVisualStyleBackColor = true;
            this.PreOrder.Click += new System.EventHandler(this.PreOrder_Click);
            // 
            // InOrder
            // 
            this.InOrder.Location = new System.Drawing.Point(260, 195);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(75, 50);
            this.InOrder.TabIndex = 14;
            this.InOrder.Text = "InOrder";
            this.InOrder.UseVisualStyleBackColor = true;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // PostOrder
            // 
            this.PostOrder.Location = new System.Drawing.Point(260, 251);
            this.PostOrder.Name = "PostOrder";
            this.PostOrder.Size = new System.Drawing.Size(75, 50);
            this.PostOrder.TabIndex = 15;
            this.PostOrder.Text = "PostOrder";
            this.PostOrder.UseVisualStyleBackColor = true;
            this.PostOrder.Click += new System.EventHandler(this.PostOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PostOrder);
            this.Controls.Add(this.InOrder);
            this.Controls.Add(this.PreOrder);
            this.Controls.Add(this.RemoveFromTree);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ShowTree);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RemoveLast);
            this.Controls.Add(this.RemoveFirst);
            this.Controls.Add(this.AddLast);
            this.Controls.Add(this.AddFirst);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

