namespace Pharmafast
{
    partial class Moduloproveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttoneditar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxproovedor = new System.Windows.Forms.ComboBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(473, 152);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(259, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoneditar
            // 
            this.buttoneditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneditar.Location = new System.Drawing.Point(402, 351);
            this.buttoneditar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttoneditar.Name = "buttoneditar";
            this.buttoneditar.Size = new System.Drawing.Size(62, 24);
            this.buttoneditar.TabIndex = 6;
            this.buttoneditar.Text = "Editar";
            this.buttoneditar.UseVisualStyleBackColor = true;
            this.buttoneditar.Click += new System.EventHandler(this.buttoneditar_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(473, 351);
            this.button5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 24);
            this.button5.TabIndex = 7;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBoxproovedor
            // 
            this.comboBoxproovedor.FormattingEnabled = true;
            this.comboBoxproovedor.Location = new System.Drawing.Point(234, 39);
            this.comboBoxproovedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxproovedor.Name = "comboBoxproovedor";
            this.comboBoxproovedor.Size = new System.Drawing.Size(303, 21);
            this.comboBoxproovedor.TabIndex = 8;
            this.comboBoxproovedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxproovedor_SelectedIndexChanged);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(330, 351);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(62, 24);
            this.buttoneliminar.TabIndex = 9;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click_1);
            // 
            // Moduloproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(607, 381);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.comboBoxproovedor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttoneditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Moduloproveedor";
            this.Text = "Moduloproveedor";
            this.Load += new System.EventHandler(this.Moduloproveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttoneditar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxproovedor;
        private System.Windows.Forms.Button buttoneliminar;
    }
}