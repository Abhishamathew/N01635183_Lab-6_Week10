namespace WinForms.Inventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            addbtn = new Button();
            deletebtn = new Button();
            exitbtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(62, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(438, 284);
            listBox1.TabIndex = 0;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(610, 53);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 29);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(610, 125);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 2;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(610, 201);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(94, 29);
            exitbtn.TabIndex = 3;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 369);
            Controls.Add(exitbtn);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Inventory";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button addbtn;
        private Button deletebtn;
        private Button exitbtn;
    }
}
