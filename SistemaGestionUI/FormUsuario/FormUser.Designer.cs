namespace SistemaGestionUI.FormUsuario
{

    partial class FormUser
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
            btnAdd = new Button();
            btnUpdate = new Button();
            dgvUser = new DataGridView();
            btnIni = new Button();
            lblUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(471, 172);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Blue;
            btnUpdate.Location = new Point(924, 172);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 38);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(54, 270);
            dgvUser.Margin = new Padding(4, 5, 4, 5);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 62;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(977, 425);
            dgvUser.TabIndex = 2;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // btnIni
            // 
            btnIni.ForeColor = Color.Blue;
            btnIni.Location = new Point(54, 172);
            btnIni.Margin = new Padding(4, 5, 4, 5);
            btnIni.Name = "btnIni";
            btnIni.Size = new Size(107, 38);
            btnIni.TabIndex = 3;
            btnIni.Text = "Inicio";
            btnIni.UseVisualStyleBackColor = true;
            btnIni.Click += btnIni_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.Blue;
            lblUser.Location = new Point(54, 57);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(136, 40);
            lblUser.TabIndex = 4;
            lblUser.Text = "Usuarios";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblUser);
            Controls.Add(btnIni);
            Controls.Add(dgvUser);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormUser";
            Text = "Usuarios";
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private DataGridView dgvUser;
        private Button btnIni;
        private Label lblUser;
    }
}