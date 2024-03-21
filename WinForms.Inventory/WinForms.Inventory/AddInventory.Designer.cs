namespace WinForms.Inventory
{
    partial class AddInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemNumbertxt = new TextBox();
            Desctxt = new TextBox();
            pricetxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            savebtn = new Button();
            cancelbtn = new Button();
            SuspendLayout();
            // 
            // ItemNumbertxt
            // 
            ItemNumbertxt.Location = new Point(327, 65);
            ItemNumbertxt.Name = "ItemNumbertxt";
            ItemNumbertxt.Size = new Size(125, 27);
            ItemNumbertxt.TabIndex = 0;
            // 
            // Desctxt
            // 
            Desctxt.Location = new Point(327, 132);
            Desctxt.Name = "Desctxt";
            Desctxt.Size = new Size(125, 27);
            Desctxt.TabIndex = 1;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(327, 205);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(125, 27);
            pricetxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Item no:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 136);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 209);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(340, 306);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(94, 29);
            savebtn.TabIndex = 6;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(532, 306);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(94, 29);
            cancelbtn.TabIndex = 7;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pricetxt);
            Controls.Add(Desctxt);
            Controls.Add(ItemNumbertxt);
            Name = "AddInventory";
            Text = "New Inventory Item";
            Load += AddInventory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemNumbertxt;
        private TextBox Desctxt;
        private TextBox pricetxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button savebtn;
        private Button cancelbtn;
    }
}