using System.Windows.Forms;

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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.remind = new System.Windows.Forms.Button();
            this.del_all = new System.Windows.Forms.Button();
            this.del_one = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_print.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_print.Location = new System.Drawing.Point(16, 151);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.ReadOnly = true;
            this.textBox_print.Size = new System.Drawing.Size(310, 41);
            this.textBox_print.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_input.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_input.FlatAppearance.BorderSize = 2;
            this.button_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_input.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_input.Location = new System.Drawing.Point(233, 206);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(93, 94);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "계산";
            this.button_input.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_input.UseVisualStyleBackColor = false;
            this.button_input.Click += new System.EventHandler(this.button_input_click);
            // 
            // textBox_input
            // 
            this.textBox_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_input.Location = new System.Drawing.Point(16, 59);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(311, 86);
            this.textBox_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elice DigitalCoding ver.H", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "심플한 계산기";
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plus.Location = new System.Drawing.Point(16, 256);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(93, 44);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.plus.UseVisualStyleBackColor = false;
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.Location = new System.Drawing.Point(124, 256);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(93, 44);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.minus.UseVisualStyleBackColor = false;
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mult.FlatAppearance.BorderSize = 0;
            this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mult.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mult.Location = new System.Drawing.Point(16, 306);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(93, 44);
            this.mult.TabIndex = 6;
            this.mult.Text = "*";
            this.mult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mult.UseVisualStyleBackColor = false;
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.div.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.div.FlatAppearance.BorderSize = 0;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.div.Location = new System.Drawing.Point(124, 306);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(93, 44);
            this.div.TabIndex = 7;
            this.div.Text = "/";
            this.div.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.div.UseVisualStyleBackColor = false;
            // 
            // remind
            // 
            this.remind.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.remind.FlatAppearance.BorderSize = 0;
            this.remind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remind.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remind.Location = new System.Drawing.Point(232, 306);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(93, 44);
            this.remind.TabIndex = 8;
            this.remind.Text = "%";
            this.remind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.remind.UseVisualStyleBackColor = false;
            // 
            // del_all
            // 
            this.del_all.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del_all.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.del_all.FlatAppearance.BorderSize = 0;
            this.del_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_all.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.del_all.Location = new System.Drawing.Point(15, 206);
            this.del_all.Name = "del_all";
            this.del_all.Size = new System.Drawing.Size(93, 44);
            this.del_all.TabIndex = 9;
            this.del_all.Text = "C";
            this.del_all.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.del_all.UseVisualStyleBackColor = false;
            // 
            // del_one
            // 
            this.del_one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del_one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.del_one.FlatAppearance.BorderSize = 0;
            this.del_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_one.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.del_one.Location = new System.Drawing.Point(125, 206);
            this.del_one.Name = "del_one";
            this.del_one.Size = new System.Drawing.Size(93, 44);
            this.del_one.TabIndex = 10;
            this.del_one.Text = "<-";
            this.del_one.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.del_one.UseVisualStyleBackColor = false;
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sign.FlatAppearance.BorderSize = 0;
            this.sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sign.Location = new System.Drawing.Point(232, 356);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(93, 44);
            this.sign.TabIndex = 11;
            this.sign.Text = "+ / -";
            this.sign.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sign.UseVisualStyleBackColor = false;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.history.FlatAppearance.BorderSize = 0;
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.history.Location = new System.Drawing.Point(16, 356);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(200, 44);
            this.history.TabIndex = 12;
            this.history.Text = "내역 확인";
            this.history.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.history.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(347, 419);
            this.Controls.Add(this.history);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.del_one);
            this.Controls.Add(this.del_all);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
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
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button remind;
        private System.Windows.Forms.Button del_all;
        private System.Windows.Forms.Button del_one;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button history;
    }
}

