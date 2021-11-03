
namespace RandomGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numMax = new System.Windows.Forms.TextBox();
            this.numMin = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.bGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 381);
            this.panel1.TabIndex = 0;
            // 
            // numMax
            // 
            this.numMax.BackColor = System.Drawing.Color.PaleTurquoise;
            this.numMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMax.Location = new System.Drawing.Point(184, 291);
            this.numMax.MaxLength = 8;
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(71, 20);
            this.numMax.TabIndex = 8;
            // 
            // numMin
            // 
            this.numMin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.numMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMin.Location = new System.Drawing.Point(6, 291);
            this.numMin.MaxLength = 8;
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(71, 20);
            this.numMin.TabIndex = 7;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResult.Location = new System.Drawing.Point(90, 123);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 37);
            this.labelResult.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum";
            // 
            // bClose
            // 
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bClose.Location = new System.Drawing.Point(222, -1);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(41, 32);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Exit";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bGenerate
            // 
            this.bGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bGenerate.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.bGenerate.FlatAppearance.BorderSize = 0;
            this.bGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.bGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGenerate.Location = new System.Drawing.Point(0, 317);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(262, 62);
            this.bGenerate.TabIndex = 0;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RandomGenerator.Images.DarkBlueBackground;
            this.ClientSize = new System.Drawing.Size(264, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox numMax;
        private System.Windows.Forms.TextBox numMin;
    }
}

