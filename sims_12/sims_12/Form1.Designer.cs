namespace sims_12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_now = new System.Windows.Forms.Label();
            this.label_out = new System.Windows.Forms.Label();
            this.label_clients = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_now);
            this.panel1.Controls.Add(this.label_out);
            this.panel1.Controls.Add(this.label_clients);
            this.panel1.Controls.Add(this.label_money);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 261);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "You lose!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label_now
            // 
            this.label_now.AutoSize = true;
            this.label_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_now.Location = new System.Drawing.Point(13, 115);
            this.label_now.Name = "label_now";
            this.label_now.Size = new System.Drawing.Size(88, 16);
            this.label_now.TabIndex = 5;
            this.label_now.Text = "Clients now: 0";
            // 
            // label_out
            // 
            this.label_out.AutoSize = true;
            this.label_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_out.Location = new System.Drawing.Point(12, 137);
            this.label_out.Name = "label_out";
            this.label_out.Size = new System.Drawing.Size(79, 16);
            this.label_out.TabIndex = 4;
            this.label_out.Text = "Insurance: 0";
            // 
            // label_clients
            // 
            this.label_clients.AutoSize = true;
            this.label_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clients.Location = new System.Drawing.Point(13, 91);
            this.label_clients.Name = "label_clients";
            this.label_clients.Size = new System.Drawing.Size(77, 16);
            this.label_clients.TabIndex = 3;
            this.label_clients.Text = "All clients: 0";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_money.Location = new System.Drawing.Point(13, 9);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(82, 20);
            this.label_money.TabIndex = 1;
            this.label_money.Text = "Money: 20";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(105, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_out;
        private System.Windows.Forms.Label label_clients;
        private System.Windows.Forms.Label label_now;
        private System.Windows.Forms.Label label1;
    }
}

