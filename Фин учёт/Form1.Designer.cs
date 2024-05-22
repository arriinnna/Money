namespace Фин_учёт
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            txtBudget = new TextBox();
            label2 = new Label();
            txtlncome = new TextBox();
            label3 = new Label();
            txtExpense = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAddlncome = new Button();
            btnSubtractExpense = new Button();
            label6 = new Label();
            txtCurrentBudget = new TextBox();
            btnAddBudget = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Peru;
            monthCalendar1.Location = new Point(618, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = SystemColors.ButtonShadow;
            monthCalendar1.TitleForeColor = SystemColors.ControlDarkDark;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(365, 38);
            label1.Name = "label1";
            label1.Size = new Size(229, 23);
            label1.TabIndex = 1;
            label1.Text = "Остаток бюджета на месяц";
            label1.Click += label1_Click;
            // 
            // txtBudget
            // 
            txtBudget.BackColor = Color.FromArgb(255, 255, 192);
            txtBudget.Location = new Point(31, 72);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(100, 23);
            txtBudget.TabIndex = 2;
            txtBudget.TextChanged += txtBudget_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(31, 123);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 3;
            label2.Text = "Доход";
            // 
            // txtlncome
            // 
            txtlncome.BackColor = Color.FromArgb(255, 255, 192);
            txtlncome.Location = new Point(31, 146);
            txtlncome.Name = "txtlncome";
            txtlncome.Size = new Size(100, 23);
            txtlncome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(365, 123);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 5;
            label3.Text = "Расходы";
            // 
            // txtExpense
            // 
            txtExpense.BackColor = Color.FromArgb(255, 255, 192);
            txtExpense.Location = new Point(365, 147);
            txtExpense.Name = "txtExpense";
            txtExpense.Size = new Size(100, 23);
            txtExpense.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(31, 208);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 8;
            label4.Text = "Предстоящие доходы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(365, 205);
            label5.Name = "label5";
            label5.Size = new Size(192, 23);
            label5.TabIndex = 9;
            label5.Text = "Предстоящие расходы";
            // 
            // btnAddlncome
            // 
            btnAddlncome.BackColor = Color.LemonChiffon;
            btnAddlncome.Location = new Point(149, 145);
            btnAddlncome.Name = "btnAddlncome";
            btnAddlncome.Size = new Size(67, 23);
            btnAddlncome.TabIndex = 11;
            btnAddlncome.Text = "Добавить";
            btnAddlncome.UseVisualStyleBackColor = false;
            btnAddlncome.Click += btnAddlncome_Click;
            // 
            // btnSubtractExpense
            // 
            btnSubtractExpense.BackColor = Color.LemonChiffon;
            btnSubtractExpense.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSubtractExpense.ForeColor = SystemColors.ActiveCaptionText;
            btnSubtractExpense.Location = new Point(478, 146);
            btnSubtractExpense.Name = "btnSubtractExpense";
            btnSubtractExpense.Size = new Size(67, 23);
            btnSubtractExpense.TabIndex = 12;
            btnSubtractExpense.Text = "Добавить";
            btnSubtractExpense.UseVisualStyleBackColor = false;
            btnSubtractExpense.Click += btnSubtractExpense_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(31, 38);
            label6.Name = "label6";
            label6.Size = new Size(207, 23);
            label6.TabIndex = 13;
            label6.Text = "Ввод текущего бюджета";
            // 
            // txtCurrentBudget
            // 
            txtCurrentBudget.BackColor = Color.FromArgb(255, 255, 192);
            txtCurrentBudget.Font = new Font("Segoe UI", 11F);
            txtCurrentBudget.Location = new Point(365, 72);
            txtCurrentBudget.MaximumSize = new Size(101, 23);
            txtCurrentBudget.MinimumSize = new Size(99, 22);
            txtCurrentBudget.Name = "txtCurrentBudget";
            txtCurrentBudget.ReadOnly = true;
            txtCurrentBudget.ScrollBars = ScrollBars.Both;
            txtCurrentBudget.Size = new Size(100, 23);
            txtCurrentBudget.TabIndex = 14;
            txtCurrentBudget.TextChanged += txtCurrentBudget_TextChanged;
            // 
            // btnAddBudget
            // 
            btnAddBudget.BackColor = Color.LemonChiffon;
            btnAddBudget.Location = new Point(144, 71);
            btnAddBudget.Name = "btnAddBudget";
            btnAddBudget.Size = new Size(67, 24);
            btnAddBudget.TabIndex = 15;
            btnAddBudget.Text = "Добавить";
            btnAddBudget.UseVisualStyleBackColor = false;
            btnAddBudget.Click += btnAddBudget_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LemonChiffon;
            richTextBox1.Location = new Point(365, 242);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(180, 96);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.LemonChiffon;
            richTextBox2.Location = new Point(31, 242);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(180, 96);
            richTextBox2.TabIndex = 17;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(btnAddBudget);
            Controls.Add(txtCurrentBudget);
            Controls.Add(label6);
            Controls.Add(btnSubtractExpense);
            Controls.Add(btnAddlncome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtExpense);
            Controls.Add(label3);
            Controls.Add(txtlncome);
            Controls.Add(label2);
            Controls.Add(txtBudget);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private TextBox txtBudget;
        private Label label2;
        private TextBox txtlncome;
        private Label label3;
        private TextBox txtExpense;
        private Label label4;
        private Label label5;
        private Button btnAddlncome;
        private Button btnSubtractExpense;
        private Label label6;
        private TextBox txtCurrentBudget;
        private Button btnAddBudget;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}
