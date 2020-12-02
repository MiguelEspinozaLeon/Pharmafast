namespace Pharmafast
{
    partial class RegistroProveedor
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
            base.Dispose(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdpro = new System.Windows.Forms.TextBox();
            this.textBoxnombrepro = new System.Windows.Forms.TextBox();
            this.textBoxtelpro = new System.Windows.Forms.TextBox();
            this.textBoxdirepro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttoncomfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIdpro
            // 
            this.textBoxIdpro.Location = new System.Drawing.Point(98, 14);
            this.textBoxIdpro.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxIdpro.Name = "textBoxIdpro";
            this.textBoxIdpro.Size = new System.Drawing.Size(172, 20);
            this.textBoxIdpro.TabIndex = 19;
            this.textBoxIdpro.TextChanged += new System.EventHandler(this.textBoxIdpro_TextChanged);
            this.textBoxIdpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdpro_KeyPress);
            // 
            // textBoxnombrepro
            // 
            this.textBoxnombrepro.Location = new System.Drawing.Point(98, 50);
            this.textBoxnombrepro.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxnombrepro.Name = "textBoxnombrepro";
            this.textBoxnombrepro.Size = new System.Drawing.Size(172, 20);
            this.textBoxnombrepro.TabIndex = 20;
            this.textBoxnombrepro.TextChanged += new System.EventHandler(this.textBoxnombrepro_TextChanged);
            this.textBoxnombrepro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnombrepro_KeyPress);
            // 
            // textBoxtelpro
            // 
            this.textBoxtelpro.Location = new System.Drawing.Point(98, 91);
            this.textBoxtelpro.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxtelpro.Name = "textBoxtelpro";
            this.textBoxtelpro.Size = new System.Drawing.Size(172, 20);
            this.textBoxtelpro.TabIndex = 21;
            this.textBoxtelpro.TextChanged += new System.EventHandler(this.textBoxtelpro_TextChanged);
            this.textBoxtelpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtelpro_KeyPress);
            // 
            // textBoxdirepro
            // 
            this.textBoxdirepro.Location = new System.Drawing.Point(98, 137);
            this.textBoxdirepro.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxdirepro.Name = "textBoxdirepro";
            this.textBoxdirepro.Size = new System.Drawing.Size(172, 20);
            this.textBoxdirepro.TabIndex = 22;
            this.textBoxdirepro.TextChanged += new System.EventHandler(this.textBoxdirepro_TextChanged);
            this.textBoxdirepro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxdirepro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Direccion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttoncomfirmar
            // 
            this.buttoncomfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttoncomfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncomfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncomfirmar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncomfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttoncomfirmar.Image = ((System.Drawing.Image)(resources.GetObject("buttoncomfirmar.Image")));
            this.buttoncomfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncomfirmar.Location = new System.Drawing.Point(117, 187);
            this.buttoncomfirmar.Margin = new System.Windows.Forms.Padding(1);
            this.buttoncomfirmar.Name = "buttoncomfirmar";
            this.buttoncomfirmar.Size = new System.Drawing.Size(112, 49);
            this.buttoncomfirmar.TabIndex = 26;
            this.buttoncomfirmar.Text = "Confirmar";
            this.buttoncomfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoncomfirmar.UseVisualStyleBackColor = false;
            this.buttoncomfirmar.Click += new System.EventHandler(this.buttoncomfirmar_Click);
            // 
            // RegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 246);
            this.Controls.Add(this.buttoncomfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxdirepro);
            this.Controls.Add(this.textBoxtelpro);
            this.Controls.Add(this.textBoxnombrepro);
            this.Controls.Add(this.textBoxIdpro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroProveedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroProveedor_FormClosed);
            this.Load += new System.EventHandler(this.RegistroProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdpro;
        private System.Windows.Forms.TextBox textBoxnombrepro;
        private System.Windows.Forms.TextBox textBoxtelpro;
        private System.Windows.Forms.TextBox textBoxdirepro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttoncomfirmar;
    }
}