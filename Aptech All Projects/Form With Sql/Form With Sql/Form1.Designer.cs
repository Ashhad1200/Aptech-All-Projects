namespace Form_With_Sql
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            txtclass = new TextBox();
            txtfather = new TextBox();
            txtage = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 20);
            label1.Name = "label1";
            label1.Size = new Size(250, 46);
            label1.TabIndex = 0;
            label1.Text = "Data Entry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(200, 121);
            label2.Name = "label2";
            label2.Size = new Size(76, 34);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(200, 170);
            label3.Name = "label3";
            label3.Size = new Size(70, 34);
            label3.TabIndex = 2;
            label3.Text = "Class";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(200, 215);
            label4.Name = "label4";
            label4.Size = new Size(152, 34);
            label4.TabIndex = 3;
            label4.Text = "Father Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(200, 260);
            label5.Name = "label5";
            label5.Size = new Size(54, 34);
            label5.TabIndex = 4;
            label5.Text = "Age";
            label5.Click += label5_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(362, 127);
            txtname.Name = "txtname";
            txtname.Size = new Size(224, 23);
            txtname.TabIndex = 5;
            // 
            // txtclass
            // 
            txtclass.Location = new Point(362, 176);
            txtclass.Name = "txtclass";
            txtclass.Size = new Size(224, 23);
            txtclass.TabIndex = 6;
            // 
            // txtfather
            // 
            txtfather.Location = new Point(362, 221);
            txtfather.Name = "txtfather";
            txtfather.Size = new Size(224, 23);
            txtfather.TabIndex = 7;
            // 
            // txtage
            // 
            txtage.Location = new Point(362, 266);
            txtage.Name = "txtage";
            txtage.Size = new Size(224, 23);
            txtage.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(428, 313);
            button1.Name = "button1";
            button1.Size = new Size(158, 32);
            button1.TabIndex = 9;
            button1.Text = "Submit Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtage);
            Controls.Add(txtfather);
            Controls.Add(txtclass);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtname;
        private TextBox txtclass;
        private TextBox txtfather;
        private TextBox txtage;
        private Button button1;
    }
}