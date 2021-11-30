
namespace MySqlTeszt
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
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Gyartmany = new System.Windows.Forms.TextBox();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.numericUpDown_Urtartalom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Urtartalom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(413, 113);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(121, 30);
            this.button_Update.TabIndex = 11;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(209, 113);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(146, 30);
            this.button_Insert.TabIndex = 12;
            this.button_Insert.Text = "Új";
            this.button_Insert.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(33, 113);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(138, 30);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // textBox_Gyartmany
            // 
            this.textBox_Gyartmany.Location = new System.Drawing.Point(210, 63);
            this.textBox_Gyartmany.Name = "textBox_Gyartmany";
            this.textBox_Gyartmany.Size = new System.Drawing.Size(145, 20);
            this.textBox_Gyartmany.TabIndex = 10;
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(34, 63);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(137, 20);
            this.textBox_Rendszam.TabIndex = 9;
            // 
            // numericUpDown_Urtartalom
            // 
            this.numericUpDown_Urtartalom.Location = new System.Drawing.Point(414, 63);
            this.numericUpDown_Urtartalom.Name = "numericUpDown_Urtartalom";
            this.numericUpDown_Urtartalom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Urtartalom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Űrtartalom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gyártmány";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rendszám";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 280);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_Gyartmany);
            this.Controls.Add(this.textBox_Rendszam);
            this.Controls.Add(this.numericUpDown_Urtartalom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Urtartalom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_Gyartmany;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.NumericUpDown numericUpDown_Urtartalom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

