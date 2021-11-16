
namespace iktat
{
    partial class IktatForm
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
            this.dtpErkezett = new System.Windows.Forms.DateTimePicker();
            this.cbxCimzett = new System.Windows.Forms.ComboBox();
            this.tbxTargy = new System.Windows.Forms.TextBox();
            this.rtbLeiras = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpErkezett
            // 
            this.dtpErkezett.Location = new System.Drawing.Point(40, 45);
            this.dtpErkezett.Name = "dtpErkezett";
            this.dtpErkezett.Size = new System.Drawing.Size(200, 20);
            this.dtpErkezett.TabIndex = 0;
            // 
            // cbxCimzett
            // 
            this.cbxCimzett.FormattingEnabled = true;
            this.cbxCimzett.Location = new System.Drawing.Point(40, 85);
            this.cbxCimzett.Name = "cbxCimzett";
            this.cbxCimzett.Size = new System.Drawing.Size(200, 21);
            this.cbxCimzett.TabIndex = 1;
            // 
            // tbxTargy
            // 
            this.tbxTargy.Location = new System.Drawing.Point(40, 136);
            this.tbxTargy.Name = "tbxTargy";
            this.tbxTargy.Size = new System.Drawing.Size(200, 20);
            this.tbxTargy.TabIndex = 2;
            // 
            // rtbLeiras
            // 
            this.rtbLeiras.Location = new System.Drawing.Point(40, 184);
            this.rtbLeiras.Name = "rtbLeiras";
            this.rtbLeiras.Size = new System.Drawing.Size(200, 146);
            this.rtbLeiras.TabIndex = 3;
            this.rtbLeiras.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Érkezett";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Címzett";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tárgy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leírás";
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(40, 368);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 5;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // IktatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLeiras);
            this.Controls.Add(this.tbxTargy);
            this.Controls.Add(this.cbxCimzett);
            this.Controls.Add(this.dtpErkezett);
            this.Name = "IktatForm";
            this.Text = "IktatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IktatForm_FormClosed);
            this.Load += new System.EventHandler(this.IktatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpErkezett;
        private System.Windows.Forms.ComboBox cbxCimzett;
        private System.Windows.Forms.TextBox tbxTargy;
        private System.Windows.Forms.RichTextBox rtbLeiras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnOK;
    }
}