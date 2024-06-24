namespace SistemaGestionUI;

partial class FormInit
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
        btnUser = new Button();
        btnProduct = new Button();
        btnSellProduct = new Button();
        btnSell = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // btnUser
        // 
        btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnUser.ForeColor = Color.Blue;
        btnUser.Location = new Point(38, 214);
        btnUser.Name = "btnUser";
        btnUser.Size = new Size(146, 67);
        btnUser.TabIndex = 1;
        btnUser.Text = "Usuarios";
        btnUser.UseVisualStyleBackColor = true;
        btnUser.Click += btnUser_Click;
        // 
        // btnProduct
        // 
        btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnProduct.ForeColor = Color.Blue;
        btnProduct.Location = new Point(233, 214);
        btnProduct.Name = "btnProduct";
        btnProduct.Size = new Size(134, 67);
        btnProduct.TabIndex = 2;
        btnProduct.Text = "Productos";
        btnProduct.UseVisualStyleBackColor = true;
        btnProduct.Click += btnProduct_Click;
        // 
        // btnSellProduct
        // 
        btnSellProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSellProduct.ForeColor = Color.Blue;
        btnSellProduct.Location = new Point(411, 214);
        btnSellProduct.Name = "btnSellProduct";
        btnSellProduct.Size = new Size(151, 67);
        btnSellProduct.TabIndex = 3;
        btnSellProduct.Text = "Productos vendidos";
        btnSellProduct.UseVisualStyleBackColor = true;
        btnSellProduct.Click += btnSellProduct_Click;
        // 
        // btnSell
        // 
        btnSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSell.ForeColor = Color.Blue;
        btnSell.Location = new Point(610, 214);
        btnSell.Name = "btnSell";
        btnSell.Size = new Size(141, 67);
        btnSell.TabIndex = 4;
        btnSell.Text = "Ventas";
        btnSell.UseVisualStyleBackColor = true;
        btnSell.Click += btnSell_Click;
        // 
        // btnExit
        // 
        btnExit.ForeColor = Color.Blue;
        btnExit.Location = new Point(368, 399);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(75, 23);
        btnExit.TabIndex = 5;
        btnExit.Text = "Salir";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // FormInit
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnExit);
        Controls.Add(btnSell);
        Controls.Add(btnSellProduct);
        Controls.Add(btnProduct);
        Controls.Add(btnUser);
        Name = "FormInit";
        Text = "Sistema de Gestiones";
        ResumeLayout(false);
    }

    #endregion
    private Button btnUser;
    private Button btnProduct;
    private Button btnSellProduct;
    private Button btnSell;
    private Button btnExit;
}