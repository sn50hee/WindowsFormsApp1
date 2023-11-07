namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_print.Location = new System.Drawing.Point(11, 180);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.Size = new System.Drawing.Size(426, 54);
            this.textBox_print.TabIndex = 0;
            // 
            // button_input
            // 
            this.button_input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_input.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_input.Location = new System.Drawing.Point(167, 103);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(106, 44);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "계산";
            this.button_input.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_input.UseVisualStyleBackColor = false;
            this.button_input.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_input.Location = new System.Drawing.Point(11, 52);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(425, 27);
            this.textBox_input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "입력 예시: a + b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(449, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
    }
}

