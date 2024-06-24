namespace SistemaGestionUI.FormProductoVendido;

partial class FormSellProduct
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
        lblSellProduct = new Label();
        btnUpdate = new Button();
        btnAdd = new Button();
        dgvSellProduct = new DataGridView();
        btnIni = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvSellProduct).BeginInit();
        SuspendLayout();
        // 
        // lblSellProduct
        // 
        lblSellProduct.AutoSize = true;
        lblSellProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblSellProduct.ForeColor = Color.Blue;
        lblSellProduct.Location = new Point(49, 45);
        lblSellProduct.Margin = new Padding(4, 0, 4, 0);
        lblSellProduct.Name = "lblSellProduct";
        lblSellProduct.Size = new Size(290, 40);
        lblSellProduct.TabIndex = 0;
        lblSellProduct.Text = "Productos vendidos";
        // 
        // btnUpdate
        // 
        btnUpdate.ForeColor = Color.Blue;
        btnUpdate.Location = new Point(440, 148);
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
        btnAdd.Location = new Point(860, 148);
        btnAdd.Margin = new Padding(4, 5, 4, 5);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(107, 38);
        btnAdd.TabIndex = 2;
        btnAdd.Text = "Agregar";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvSellProduct
        // 
        dgvSellProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSellProduct.Location = new Point(49, 245);
        dgvSellProduct.Margin = new Padding(4, 5, 4, 5);
        dgvSellProduct.Name = "dgvSellProduct";
        dgvSellProduct.RowHeadersWidth = 62;
        dgvSellProduct.RowTemplate.Height = 25;
        dgvSellProduct.Size = new Size(919, 453);
        dgvSellProduct.TabIndex = 3;
        dgvSellProduct.CellClick += dgvSellProduct_CellClick;
        // 
        // btnIni
        // 
        btnIni.ForeColor = Color.Blue;
        btnIni.Location = new Point(49, 148);
        btnIni.Margin = new Padding(4, 5, 4, 5);
        btnIni.Name = "btnIni";
        btnIni.Size = new Size(107, 38);
        btnIni.TabIndex = 4;
        btnIni.Text = "Inicio";
        btnIni.UseVisualStyleBackColor = true;
        btnIni.Click += btnIni_Click;
        // 
        // FormSellProduct
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1071, 750);
        Controls.Add(btnIni);
        Controls.Add(dgvSellProduct);
        Controls.Add(btnAdd);
        Controls.Add(btnUpdate);
        Controls.Add(lblSellProduct);
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormSellProduct";
        Text = "Productos vendidos";
        Load += FormSellProduct_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSellProduct).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSellProduct;
    private Button btnUpdate;
    private Button btnAdd;
    private DataGridView dgvSellProduct;
    private Button btnIni;
}