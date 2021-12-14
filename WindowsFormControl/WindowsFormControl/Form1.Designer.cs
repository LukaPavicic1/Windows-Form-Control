
namespace WindowsFormControl
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
            this.btnposalji = new System.Windows.Forms.Button();
            this.chkdorucak = new System.Windows.Forms.CheckBox();
            this.chkrucak = new System.Windows.Forms.CheckBox();
            this.chkvecera = new System.Windows.Forms.CheckBox();
            this.txtbxodabrano = new System.Windows.Forms.TextBox();
            this.chkposalji = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnposalji
            // 
            this.btnposalji.Location = new System.Drawing.Point(86, 328);
            this.btnposalji.Name = "btnposalji";
            this.btnposalji.Size = new System.Drawing.Size(116, 78);
            this.btnposalji.TabIndex = 0;
            this.btnposalji.Text = "Pošalji";
            this.btnposalji.UseVisualStyleBackColor = true;
            this.btnposalji.Click += new System.EventHandler(this.btnposalji_Click);
            // 
            // chkdorucak
            // 
            this.chkdorucak.AutoSize = true;
            this.chkdorucak.Location = new System.Drawing.Point(86, 146);
            this.chkdorucak.Name = "chkdorucak";
            this.chkdorucak.Size = new System.Drawing.Size(67, 17);
            this.chkdorucak.TabIndex = 1;
            this.chkdorucak.Text = "Doručak";
            this.chkdorucak.UseVisualStyleBackColor = true;
            // 
            // chkrucak
            // 
            this.chkrucak.AutoSize = true;
            this.chkrucak.Location = new System.Drawing.Point(86, 198);
            this.chkrucak.Name = "chkrucak";
            this.chkrucak.Size = new System.Drawing.Size(58, 17);
            this.chkrucak.TabIndex = 2;
            this.chkrucak.Text = "Ručak";
            this.chkrucak.UseVisualStyleBackColor = true;
            // 
            // chkvecera
            // 
            this.chkvecera.AutoSize = true;
            this.chkvecera.Location = new System.Drawing.Point(86, 251);
            this.chkvecera.Name = "chkvecera";
            this.chkvecera.Size = new System.Drawing.Size(60, 17);
            this.chkvecera.TabIndex = 3;
            this.chkvecera.Text = "Večera";
            this.chkvecera.UseVisualStyleBackColor = true;
            // 
            // txtbxodabrano
            // 
            this.txtbxodabrano.Location = new System.Drawing.Point(205, 139);
            this.txtbxodabrano.Multiline = true;
            this.txtbxodabrano.Name = "txtbxodabrano";
            this.txtbxodabrano.Size = new System.Drawing.Size(402, 159);
            this.txtbxodabrano.TabIndex = 4;
            // 
            // chkposalji
            // 
            this.chkposalji.AutoSize = true;
            this.chkposalji.Location = new System.Drawing.Point(221, 328);
            this.chkposalji.Name = "chkposalji";
            this.chkposalji.Size = new System.Drawing.Size(56, 17);
            this.chkposalji.TabIndex = 5;
            this.chkposalji.Text = "Pošalji";
            this.chkposalji.UseVisualStyleBackColor = true;
            this.chkposalji.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkposalji);
            this.Controls.Add(this.txtbxodabrano);
            this.Controls.Add(this.chkvecera);
            this.Controls.Add(this.chkrucak);
            this.Controls.Add(this.chkdorucak);
            this.Controls.Add(this.btnposalji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnposalji;
        private System.Windows.Forms.CheckBox chkdorucak;
        private System.Windows.Forms.CheckBox chkrucak;
        private System.Windows.Forms.CheckBox chkvecera;
        private System.Windows.Forms.TextBox txtbxodabrano;
        private System.Windows.Forms.CheckBox chkposalji;
    }
}

