
namespace Cliente
{
    partial class Cliente_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Conecatar = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Encender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto :";
            // 
            // Btn_Conecatar
            // 
            this.Btn_Conecatar.Location = new System.Drawing.Point(362, 22);
            this.Btn_Conecatar.Name = "Btn_Conecatar";
            this.Btn_Conecatar.Size = new System.Drawing.Size(115, 43);
            this.Btn_Conecatar.TabIndex = 2;
            this.Btn_Conecatar.Text = "Conectar";
            this.Btn_Conecatar.UseVisualStyleBackColor = true;
            this.Btn_Conecatar.Click += new System.EventHandler(this.Btn_Conecatar_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(103, 31);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(241, 34);
            this.txtIP.TabIndex = 4;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(103, 91);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(133, 34);
            this.txtPuerto.TabIndex = 5;
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Location = new System.Drawing.Point(272, 155);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(115, 47);
            this.Btn_Apagar.TabIndex = 8;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = true;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Btn_Encender
            // 
            this.Btn_Encender.Location = new System.Drawing.Point(84, 155);
            this.Btn_Encender.Name = "Btn_Encender";
            this.Btn_Encender.Size = new System.Drawing.Size(115, 47);
            this.Btn_Encender.TabIndex = 9;
            this.Btn_Encender.Text = "Encender";
            this.Btn_Encender.UseVisualStyleBackColor = true;
            this.Btn_Encender.Click += new System.EventHandler(this.Btn_Encender_Click);
            // 
            // Cliente_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 219);
            this.Controls.Add(this.Btn_Encender);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.Btn_Conecatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 268);
            this.MinimumSize = new System.Drawing.Size(512, 268);
            this.Name = "Cliente_Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Forms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Conecatar;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Button Btn_Encender;
    }
}

