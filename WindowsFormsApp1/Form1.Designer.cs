﻿using System.Windows.Forms;

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
            this.textBox_print.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_print.Location = new System.Drawing.Point(12, 109);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.ReadOnly = true;
            this.textBox_print.Size = new System.Drawing.Size(280, 50);
            this.textBox_print.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_input.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_input.FlatAppearance.BorderSize = 2;
            this.button_input.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.button_input.Location = new System.Drawing.Point(206, 166);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(91, 76);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "계산";
            this.button_input.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_input.UseVisualStyleBackColor = false;
            this.button_input.Click += new System.EventHandler(this.button_input_click);
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_input.Location = new System.Drawing.Point(12, 53);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(280, 50);
            this.textBox_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "김윤정 계산기";
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.plus.Location = new System.Drawing.Point(12, 207);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(91, 35);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operator_btn_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.minus.Location = new System.Drawing.Point(109, 207);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(91, 35);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operator_btn_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mult.FlatAppearance.BorderSize = 0;
            this.mult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.mult.Location = new System.Drawing.Point(12, 248);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(91, 35);
            this.mult.TabIndex = 6;
            this.mult.Text = "x";
            this.mult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.operator_btn_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.div.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.div.FlatAppearance.BorderSize = 0;
            this.div.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.div.Location = new System.Drawing.Point(109, 248);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(91, 35);
            this.div.TabIndex = 7;
            this.div.Text = "/";
            this.div.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operator_btn_Click);
            // 
            // remind
            // 
            this.remind.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.remind.FlatAppearance.BorderSize = 0;
            this.remind.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remind.Location = new System.Drawing.Point(206, 248);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(91, 35);
            this.remind.TabIndex = 8;
            this.remind.Text = "%";
            this.remind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.remind.UseVisualStyleBackColor = false;
            this.remind.Click += new System.EventHandler(this.operator_btn_Click);
            // 
            // del_all
            // 
            this.del_all.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del_all.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.del_all.FlatAppearance.BorderSize = 0;
            this.del_all.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.del_all.Location = new System.Drawing.Point(12, 165);
            this.del_all.Name = "del_all";
            this.del_all.Size = new System.Drawing.Size(91, 36);
            this.del_all.TabIndex = 9;
            this.del_all.Text = "C";
            this.del_all.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.del_all.UseVisualStyleBackColor = false;
            this.del_all.Click += new System.EventHandler(this.del_all_Click);
            // 
            // del_one
            // 
            this.del_one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del_one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.del_one.FlatAppearance.BorderSize = 0;
            this.del_one.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.del_one.Location = new System.Drawing.Point(109, 166);
            this.del_one.Name = "del_one";
            this.del_one.Size = new System.Drawing.Size(91, 35);
            this.del_one.TabIndex = 10;
            this.del_one.Text = "<-";
            this.del_one.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.del_one.UseVisualStyleBackColor = false;
            this.del_one.Click += new System.EventHandler(this.del_one_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sign.FlatAppearance.BorderSize = 0;
            this.sign.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.sign.Location = new System.Drawing.Point(206, 289);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(91, 35);
            this.sign.TabIndex = 11;
            this.sign.Text = "+ / -";
            this.sign.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.history.FlatAppearance.BorderSize = 0;
            this.history.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.history.Location = new System.Drawing.Point(12, 289);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(188, 35);
            this.history.TabIndex = 12;
            this.history.Text = "계산 기록";
            this.history.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(304, 335);
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
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_print);
            this.Controls.Add(this.textBox_input);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "Form1";
            this.Text = "김윤정 계산기";
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

