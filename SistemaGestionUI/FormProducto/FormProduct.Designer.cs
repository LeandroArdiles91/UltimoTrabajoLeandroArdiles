namespace SistemaGestionUI.FormProducto
{
    partial class FormProduct
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
            lblProduct = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnIni = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.Blue;
            lblProduct.Location = new Point(73, 65);
            lblProduct.Margin = new Padding(4, 0, 4, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(157, 40);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Productos";
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Blue;
            btnUpdate.Location = new Point(497, 140);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 38);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(974, 140);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(73, 222);
            dgvProduct.Margin = new Padding(4, 5, 4, 5);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(1009, 518);
            dgvProduct.TabIndex = 3;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnIni
            // 
            btnIni.ForeColor = Color.Blue;
            btnIni.Location = new Point(73, 140);
            btnIni.Margin = new Padding(4, 5, 4, 5);
            btnIni.Name = "btnIni";
            btnIni.Size = new Size(107, 38);
            btnIni.TabIndex = 4;
            btnIni.Text = "Inicio";
            btnIni.UseVisualStyleBackColor = true;
            btnIni.Click += btnIni_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 813);
            Controls.Add(btnIni);
            Controls.Add(dgvProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(lblProduct);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormProduct";
            Text = "Productos";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private Button btnIni;
    }
}