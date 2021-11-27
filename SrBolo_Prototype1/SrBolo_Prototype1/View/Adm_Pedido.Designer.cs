
namespace SrBolo_Prototype1.View
{
    partial class Adm_Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm_Pedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPFFunc = new System.Windows.Forms.Label();
            this.lblDataPed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridViewBolosPed = new System.Windows.Forms.DataGridView();
            this.btnFechar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblIdPed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBolosPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF do Funcionário";
            // 
            // lblCPFFunc
            // 
            this.lblCPFFunc.AutoSize = true;
            this.lblCPFFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFFunc.Location = new System.Drawing.Point(40, 130);
            this.lblCPFFunc.Name = "lblCPFFunc";
            this.lblCPFFunc.Size = new System.Drawing.Size(64, 25);
            this.lblCPFFunc.TabIndex = 3;
            this.lblCPFFunc.Text = ":CPF:";
            // 
            // lblDataPed
            // 
            this.lblDataPed.AutoSize = true;
            this.lblDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPed.Location = new System.Drawing.Point(350, 130);
            this.lblDataPed.Name = "lblDataPed";
            this.lblDataPed.Size = new System.Drawing.Size(62, 25);
            this.lblDataPed.TabIndex = 5;
            this.lblDataPed.Text = ":data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bolos do Pedido";
            // 
            // GridViewBolosPed
            // 
            this.GridViewBolosPed.AllowUserToAddRows = false;
            this.GridViewBolosPed.AllowUserToDeleteRows = false;
            this.GridViewBolosPed.AllowUserToResizeColumns = false;
            this.GridViewBolosPed.AllowUserToResizeRows = false;
            this.GridViewBolosPed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewBolosPed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridViewBolosPed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewBolosPed.BackgroundColor = System.Drawing.Color.White;
            this.GridViewBolosPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewBolosPed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridViewBolosPed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewBolosPed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewBolosPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewBolosPed.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewBolosPed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridViewBolosPed.Location = new System.Drawing.Point(39, 208);
            this.GridViewBolosPed.Name = "GridViewBolosPed";
            this.GridViewBolosPed.RowHeadersVisible = false;
            this.GridViewBolosPed.RowHeadersWidth = 50;
            this.GridViewBolosPed.RowTemplate.Height = 24;
            this.GridViewBolosPed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewBolosPed.Size = new System.Drawing.Size(600, 202);
            this.GridViewBolosPed.TabIndex = 9;
            this.GridViewBolosPed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBolosPed_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.CheckedState.Parent = this.btnFechar;
            this.btnFechar.CustomImages.Parent = this.btnFechar;
            this.btnFechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFechar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFechar.DisabledState.Parent = this.btnFechar;
            this.btnFechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnFechar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.HoverState.Parent = this.btnFechar;
            this.btnFechar.Location = new System.Drawing.Point(501, 457);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.ShadowDecoration.Parent = this.btnFechar;
            this.btnFechar.Size = new System.Drawing.Size(138, 41);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblIdPed
            // 
            this.lblIdPed.AutoSize = true;
            this.lblIdPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPed.Location = new System.Drawing.Point(197, 35);
            this.lblIdPed.Name = "lblIdPed";
            this.lblIdPed.Size = new System.Drawing.Size(77, 36);
            this.lblIdPed.TabIndex = 11;
            this.lblIdPed.Text = ":#id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Adm_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 536);
            this.Controls.Add(this.lblIdPed);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.GridViewBolosPed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDataPed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCPFFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adm_Pedido";
            this.Text = "Conf_DetalhePed";
            this.Load += new System.EventHandler(this.Adm_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBolosPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPFFunc;
        private System.Windows.Forms.Label lblDataPed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridViewBolosPed;
        private Guna.UI2.WinForms.Guna2GradientButton btnFechar;
        private System.Windows.Forms.Label lblIdPed;
    }
}