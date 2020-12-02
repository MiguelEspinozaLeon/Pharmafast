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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moduloproveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttoneditar = new System.Windows.Forms.Button();
            this.comboBoxproovedor = new System.Windows.Forms.ComboBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(62, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(473, 152);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(223, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoneditar
            // 
            this.buttoneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttoneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneditar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttoneditar.Image = ((System.Drawing.Image)(resources.GetObject("buttoneditar.Image")));
            this.buttoneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneditar.Location = new System.Drawing.Point(322, 330);
            this.buttoneditar.Margin = new System.Windows.Forms.Padding(1);
            this.buttoneditar.Name = "buttoneditar";
            this.buttoneditar.Size = new System.Drawing.Size(93, 45);
            this.buttoneditar.TabIndex = 6;
            this.buttoneditar.Text = "Editar";
            this.buttoneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneditar.UseVisualStyleBackColor = false;
            this.buttoneditar.Click += new System.EventHandler(this.buttoneditar_Click);
            // 
            // comboBoxproovedor
            // 
            this.comboBoxproovedor.FormattingEnabled = true;
            this.comboBoxproovedor.Location = new System.Drawing.Point(234, 39);
            this.comboBoxproovedor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxproovedor.Name = "comboBoxproovedor";
            this.comboBoxproovedor.Size = new System.Drawing.Size(303, 21);
            this.comboBoxproovedor.TabIndex = 8;
            this.comboBoxproovedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxproovedor_SelectedIndexChanged);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttoneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneliminar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttoneliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttoneliminar.Image")));
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneliminar.Location = new System.Drawing.Point(426, 330);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(1);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(111, 45);
            this.buttoneliminar.TabIndex = 9;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista de proveedores";
            // 
            // Moduloproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.comboBoxproovedor);
            this.Controls.Add(this.buttoneditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Moduloproveedor";
            this.Text = "Proveedores";
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
        private System.Windows.Forms.ComboBox comboBoxproovedor;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Label label2;
    }
}