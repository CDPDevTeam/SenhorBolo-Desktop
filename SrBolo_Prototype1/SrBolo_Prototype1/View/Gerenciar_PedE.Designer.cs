namespace SrBolo_Prototype1
{
    partial class Gerenciar_PedE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar_PedE));
            this.PanelGerRec = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtGerRecSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.GridViewRec = new System.Windows.Forms.DataGridView();
            this.ButtonExibir = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PanelPedidos = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGerenciar_PedF = new Guna.UI2.WinForms.Guna2Button();
            this.btnGerenciar_PedE = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReceita = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanelProduto = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGerenciar_Prod = new Guna.UI2.WinForms.Guna2Button();
            this.btnCad_Prod = new Guna.UI2.WinForms.Guna2Button();
            this.BtnProduto = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanelFuncionario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGerenciar_Func = new Guna.UI2.WinForms.Guna2Button();
            this.btnCad_Func = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFuncionario = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.LogoMrCake = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.PanelGerRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRec)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelPedidos.SuspendLayout();
            this.PanelProduto.SuspendLayout();
            this.PanelFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMrCake)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGerRec
            // 
            this.PanelGerRec.BorderRadius = 40;
            this.PanelGerRec.Controls.Add(this.lblAviso);
            this.PanelGerRec.Controls.Add(this.lblTitle);
            this.PanelGerRec.Controls.Add(this.txtGerRecSearch);
            this.PanelGerRec.Controls.Add(this.GridViewRec);
            this.PanelGerRec.Controls.Add(this.ButtonExibir);
            this.PanelGerRec.Location = new System.Drawing.Point(145, 82);
            this.PanelGerRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelGerRec.Name = "PanelGerRec";
            this.PanelGerRec.ShadowDecoration.Parent = this.PanelGerRec;
            this.PanelGerRec.Size = new System.Drawing.Size(1371, 875);
            this.PanelGerRec.TabIndex = 21;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.White;
            this.lblAviso.ForeColor = System.Drawing.Color.Black;
            this.lblAviso.Location = new System.Drawing.Point(21, 779);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(401, 20);
            this.lblAviso.TabIndex = 37;
            this.lblAviso.Text = "*Para realizar uma operação, clique no campo desejado";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 37);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Pedidos Ecommerce";
            // 
            // txtGerRecSearch
            // 
            this.txtGerRecSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGerRecSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGerRecSearch.BorderRadius = 20;
            this.txtGerRecSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGerRecSearch.DefaultText = "";
            this.txtGerRecSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGerRecSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGerRecSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGerRecSearch.DisabledState.Parent = this.txtGerRecSearch;
            this.txtGerRecSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGerRecSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtGerRecSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGerRecSearch.FocusedState.Parent = this.txtGerRecSearch;
            this.txtGerRecSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerRecSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGerRecSearch.HoverState.Parent = this.txtGerRecSearch;
            this.txtGerRecSearch.Location = new System.Drawing.Point(896, 18);
            this.txtGerRecSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGerRecSearch.Name = "txtGerRecSearch";
            this.txtGerRecSearch.PasswordChar = '\0';
            this.txtGerRecSearch.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGerRecSearch.PlaceholderText = "Digite ID, Data ou Email";
            this.txtGerRecSearch.SelectedText = "";
            this.txtGerRecSearch.ShadowDecoration.Parent = this.txtGerRecSearch;
            this.txtGerRecSearch.Size = new System.Drawing.Size(454, 46);
            this.txtGerRecSearch.TabIndex = 25;
            this.txtGerRecSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGerRecSearch_KeyDown);
            // 
            // GridViewRec
            // 
            this.GridViewRec.AllowUserToAddRows = false;
            this.GridViewRec.AllowUserToDeleteRows = false;
            this.GridViewRec.AllowUserToResizeColumns = false;
            this.GridViewRec.AllowUserToResizeRows = false;
            this.GridViewRec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewRec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewRec.BackgroundColor = System.Drawing.Color.White;
            this.GridViewRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewRec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridViewRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewRec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewRec.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewRec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridViewRec.Location = new System.Drawing.Point(25, 69);
            this.GridViewRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewRec.Name = "GridViewRec";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewRec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewRec.RowHeadersVisible = false;
            this.GridViewRec.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GridViewRec.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewRec.RowTemplate.Height = 28;
            this.GridViewRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewRec.Size = new System.Drawing.Size(1325, 665);
            this.GridViewRec.TabIndex = 23;
            this.GridViewRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRec_CellContentClick);
            // 
            // ButtonExibir
            // 
            this.ButtonExibir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ButtonExibir.CheckedState.Parent = this.ButtonExibir;
            this.ButtonExibir.CustomImages.Parent = this.ButtonExibir;
            this.ButtonExibir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExibir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExibir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExibir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExibir.DisabledState.Parent = this.ButtonExibir;
            this.ButtonExibir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.ButtonExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonExibir.ForeColor = System.Drawing.Color.White;
            this.ButtonExibir.HoverState.Parent = this.ButtonExibir;
            this.ButtonExibir.Location = new System.Drawing.Point(1170, 754);
            this.ButtonExibir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExibir.Name = "ButtonExibir";
            this.ButtonExibir.ShadowDecoration.Parent = this.ButtonExibir;
            this.ButtonExibir.Size = new System.Drawing.Size(180, 51);
            this.ButtonExibir.TabIndex = 22;
            this.ButtonExibir.Text = "Exibir";
            this.ButtonExibir.Click += new System.EventHandler(this.ButtonExibir_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.PanelPedidos);
            this.PanelMenu.Controls.Add(this.BtnReceita);
            this.PanelMenu.Controls.Add(this.PanelProduto);
            this.PanelMenu.Controls.Add(this.BtnProduto);
            this.PanelMenu.Controls.Add(this.PanelFuncionario);
            this.PanelMenu.Controls.Add(this.BtnFuncionario);
            this.PanelMenu.Controls.Add(this.guna2GradientPanel2);
            this.PanelMenu.Controls.Add(this.LogoMrCake);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.PanelMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.ShadowDecoration.Parent = this.PanelMenu;
            this.PanelMenu.Size = new System.Drawing.Size(144, 901);
            this.PanelMenu.TabIndex = 22;
            // 
            // PanelPedidos
            // 
            this.PanelPedidos.Controls.Add(this.btnGerenciar_PedF);
            this.PanelPedidos.Controls.Add(this.btnGerenciar_PedE);
            this.PanelPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPedidos.Location = new System.Drawing.Point(0, 746);
            this.PanelPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelPedidos.Name = "PanelPedidos";
            this.PanelPedidos.ShadowDecoration.Parent = this.PanelPedidos;
            this.PanelPedidos.Size = new System.Drawing.Size(144, 182);
            this.PanelPedidos.TabIndex = 12;
            // 
            // btnGerenciar_PedF
            // 
            this.btnGerenciar_PedF.CheckedState.Parent = this.btnGerenciar_PedF;
            this.btnGerenciar_PedF.CustomImages.Parent = this.btnGerenciar_PedF;
            this.btnGerenciar_PedF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_PedF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_PedF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciar_PedF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciar_PedF.DisabledState.Parent = this.btnGerenciar_PedF;
            this.btnGerenciar_PedF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar_PedF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnGerenciar_PedF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGerenciar_PedF.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar_PedF.HoverState.Parent = this.btnGerenciar_PedF;
            this.btnGerenciar_PedF.Location = new System.Drawing.Point(0, 91);
            this.btnGerenciar_PedF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerenciar_PedF.Name = "btnGerenciar_PedF";
            this.btnGerenciar_PedF.ShadowDecoration.Parent = this.btnGerenciar_PedF;
            this.btnGerenciar_PedF.Size = new System.Drawing.Size(144, 91);
            this.btnGerenciar_PedF.TabIndex = 2;
            this.btnGerenciar_PedF.Text = "Gerenciar Pedidos Loja Física";
            this.btnGerenciar_PedF.Click += new System.EventHandler(this.btnGerenciar_PedF_Click);
            // 
            // btnGerenciar_PedE
            // 
            this.btnGerenciar_PedE.CheckedState.Parent = this.btnGerenciar_PedE;
            this.btnGerenciar_PedE.CustomImages.Parent = this.btnGerenciar_PedE;
            this.btnGerenciar_PedE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_PedE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_PedE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciar_PedE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciar_PedE.DisabledState.Parent = this.btnGerenciar_PedE;
            this.btnGerenciar_PedE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar_PedE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnGerenciar_PedE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGerenciar_PedE.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar_PedE.HoverState.Parent = this.btnGerenciar_PedE;
            this.btnGerenciar_PedE.Location = new System.Drawing.Point(0, 0);
            this.btnGerenciar_PedE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerenciar_PedE.Name = "btnGerenciar_PedE";
            this.btnGerenciar_PedE.ShadowDecoration.Parent = this.btnGerenciar_PedE;
            this.btnGerenciar_PedE.Size = new System.Drawing.Size(144, 91);
            this.btnGerenciar_PedE.TabIndex = 1;
            this.btnGerenciar_PedE.Text = "Gerenciar Pedidos Ecommerce";
            // 
            // BtnReceita
            // 
            this.BtnReceita.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnReceita.CheckedState.Parent = this.BtnReceita;
            this.BtnReceita.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReceita.HoverState.ImageSize = new System.Drawing.Size(128, 90);
            this.BtnReceita.HoverState.Parent = this.BtnReceita;
            this.BtnReceita.Image = ((System.Drawing.Image)(resources.GetObject("BtnReceita.Image")));
            this.BtnReceita.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnReceita.ImageRotate = 0F;
            this.BtnReceita.ImageSize = new System.Drawing.Size(128, 90);
            this.BtnReceita.Location = new System.Drawing.Point(0, 634);
            this.BtnReceita.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReceita.Name = "BtnReceita";
            this.BtnReceita.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnReceita.PressedState.Parent = this.BtnReceita;
            this.BtnReceita.ShadowDecoration.Parent = this.BtnReceita;
            this.BtnReceita.Size = new System.Drawing.Size(144, 112);
            this.BtnReceita.TabIndex = 11;
            this.BtnReceita.Click += new System.EventHandler(this.BtnReceita_Click);
            // 
            // PanelProduto
            // 
            this.PanelProduto.Controls.Add(this.btnGerenciar_Prod);
            this.PanelProduto.Controls.Add(this.btnCad_Prod);
            this.PanelProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProduto.Location = new System.Drawing.Point(0, 496);
            this.PanelProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelProduto.Name = "PanelProduto";
            this.PanelProduto.ShadowDecoration.Parent = this.PanelProduto;
            this.PanelProduto.Size = new System.Drawing.Size(144, 138);
            this.PanelProduto.TabIndex = 5;
            // 
            // btnGerenciar_Prod
            // 
            this.btnGerenciar_Prod.CheckedState.Parent = this.btnGerenciar_Prod;
            this.btnGerenciar_Prod.CustomImages.Parent = this.btnGerenciar_Prod;
            this.btnGerenciar_Prod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_Prod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_Prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciar_Prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciar_Prod.DisabledState.Parent = this.btnGerenciar_Prod;
            this.btnGerenciar_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar_Prod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnGerenciar_Prod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGerenciar_Prod.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar_Prod.HoverState.Parent = this.btnGerenciar_Prod;
            this.btnGerenciar_Prod.Location = new System.Drawing.Point(0, 70);
            this.btnGerenciar_Prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerenciar_Prod.Name = "btnGerenciar_Prod";
            this.btnGerenciar_Prod.ShadowDecoration.Parent = this.btnGerenciar_Prod;
            this.btnGerenciar_Prod.Size = new System.Drawing.Size(144, 70);
            this.btnGerenciar_Prod.TabIndex = 2;
            this.btnGerenciar_Prod.Text = "Gerenciar Produto";
            this.btnGerenciar_Prod.Click += new System.EventHandler(this.btnGerenciar_Prod_Click);
            // 
            // btnCad_Prod
            // 
            this.btnCad_Prod.CheckedState.Parent = this.btnCad_Prod;
            this.btnCad_Prod.CustomImages.Parent = this.btnCad_Prod;
            this.btnCad_Prod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCad_Prod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCad_Prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCad_Prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCad_Prod.DisabledState.Parent = this.btnCad_Prod;
            this.btnCad_Prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCad_Prod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnCad_Prod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCad_Prod.ForeColor = System.Drawing.Color.White;
            this.btnCad_Prod.HoverState.Parent = this.btnCad_Prod;
            this.btnCad_Prod.Location = new System.Drawing.Point(0, 0);
            this.btnCad_Prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCad_Prod.Name = "btnCad_Prod";
            this.btnCad_Prod.ShadowDecoration.Parent = this.btnCad_Prod;
            this.btnCad_Prod.Size = new System.Drawing.Size(144, 70);
            this.btnCad_Prod.TabIndex = 0;
            this.btnCad_Prod.Text = "Cadastrar Produto";
            this.btnCad_Prod.Click += new System.EventHandler(this.btnCad_Prod_Click);
            // 
            // BtnProduto
            // 
            this.BtnProduto.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnProduto.CheckedState.Parent = this.BtnProduto;
            this.BtnProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProduto.HoverState.ImageSize = new System.Drawing.Size(128, 90);
            this.BtnProduto.HoverState.Parent = this.BtnProduto;
            this.BtnProduto.Image = ((System.Drawing.Image)(resources.GetObject("BtnProduto.Image")));
            this.BtnProduto.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnProduto.ImageRotate = 0F;
            this.BtnProduto.ImageSize = new System.Drawing.Size(128, 90);
            this.BtnProduto.Location = new System.Drawing.Point(0, 384);
            this.BtnProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnProduto.PressedState.Parent = this.BtnProduto;
            this.BtnProduto.ShadowDecoration.Parent = this.BtnProduto;
            this.BtnProduto.Size = new System.Drawing.Size(144, 112);
            this.BtnProduto.TabIndex = 4;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // PanelFuncionario
            // 
            this.PanelFuncionario.Controls.Add(this.btnGerenciar_Func);
            this.PanelFuncionario.Controls.Add(this.btnCad_Func);
            this.PanelFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFuncionario.Location = new System.Drawing.Point(0, 246);
            this.PanelFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelFuncionario.Name = "PanelFuncionario";
            this.PanelFuncionario.ShadowDecoration.Parent = this.PanelFuncionario;
            this.PanelFuncionario.Size = new System.Drawing.Size(144, 138);
            this.PanelFuncionario.TabIndex = 3;
            // 
            // btnGerenciar_Func
            // 
            this.btnGerenciar_Func.CheckedState.Parent = this.btnGerenciar_Func;
            this.btnGerenciar_Func.CustomImages.Parent = this.btnGerenciar_Func;
            this.btnGerenciar_Func.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_Func.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerenciar_Func.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerenciar_Func.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerenciar_Func.DisabledState.Parent = this.btnGerenciar_Func;
            this.btnGerenciar_Func.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar_Func.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnGerenciar_Func.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGerenciar_Func.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar_Func.HoverState.Parent = this.btnGerenciar_Func;
            this.btnGerenciar_Func.Location = new System.Drawing.Point(0, 69);
            this.btnGerenciar_Func.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerenciar_Func.Name = "btnGerenciar_Func";
            this.btnGerenciar_Func.ShadowDecoration.Parent = this.btnGerenciar_Func;
            this.btnGerenciar_Func.Size = new System.Drawing.Size(144, 69);
            this.btnGerenciar_Func.TabIndex = 3;
            this.btnGerenciar_Func.Text = "Gerenciar Funcionário";
            this.btnGerenciar_Func.Click += new System.EventHandler(this.btnGerenciar_Func_Click);
            // 
            // btnCad_Func
            // 
            this.btnCad_Func.CheckedState.Parent = this.btnCad_Func;
            this.btnCad_Func.CustomImages.Parent = this.btnCad_Func;
            this.btnCad_Func.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCad_Func.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCad_Func.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCad_Func.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCad_Func.DisabledState.Parent = this.btnCad_Func;
            this.btnCad_Func.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCad_Func.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnCad_Func.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCad_Func.ForeColor = System.Drawing.Color.White;
            this.btnCad_Func.HoverState.Parent = this.btnCad_Func;
            this.btnCad_Func.Location = new System.Drawing.Point(0, 0);
            this.btnCad_Func.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCad_Func.Name = "btnCad_Func";
            this.btnCad_Func.ShadowDecoration.Parent = this.btnCad_Func;
            this.btnCad_Func.Size = new System.Drawing.Size(144, 69);
            this.btnCad_Func.TabIndex = 0;
            this.btnCad_Func.Text = "Cadastrar Funcionário";
            this.btnCad_Func.Click += new System.EventHandler(this.btnCad_Func_Click);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFuncionario.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnFuncionario.CheckedState.Parent = this.BtnFuncionario;
            this.BtnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFuncionario.HoverState.ImageSize = new System.Drawing.Size(128, 90);
            this.BtnFuncionario.HoverState.Parent = this.BtnFuncionario;
            this.BtnFuncionario.Image = global::SrBolo_Prototype1.Properties.Resources.IMGBtnFunc;
            this.BtnFuncionario.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnFuncionario.ImageRotate = 0F;
            this.BtnFuncionario.ImageSize = new System.Drawing.Size(128, 90);
            this.BtnFuncionario.Location = new System.Drawing.Point(0, 134);
            this.BtnFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.PressedState.Image = global::SrBolo_Prototype1.Properties.Resources.IMGBtnFunc;
            this.BtnFuncionario.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnFuncionario.PressedState.Parent = this.BtnFuncionario;
            this.BtnFuncionario.ShadowDecoration.Parent = this.BtnFuncionario;
            this.BtnFuncionario.Size = new System.Drawing.Size(144, 112);
            this.BtnFuncionario.TabIndex = 2;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Location = new System.Drawing.Point(166, 161);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(234, 125);
            this.guna2GradientPanel2.TabIndex = 1;
            // 
            // LogoMrCake
            // 
            this.LogoMrCake.BackColor = System.Drawing.Color.Transparent;
            this.LogoMrCake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoMrCake.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoMrCake.FillColor = System.Drawing.Color.Transparent;
            this.LogoMrCake.Image = global::SrBolo_Prototype1.Properties.Resources.Senhor_Bolo___Marrom;
            this.LogoMrCake.ImageRotate = 0F;
            this.LogoMrCake.Location = new System.Drawing.Point(0, 0);
            this.LogoMrCake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoMrCake.Name = "LogoMrCake";
            this.LogoMrCake.ShadowDecoration.Parent = this.LogoMrCake;
            this.LogoMrCake.Size = new System.Drawing.Size(144, 134);
            this.LogoMrCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMrCake.TabIndex = 0;
            this.LogoMrCake.TabStop = false;
            this.LogoMrCake.Click += new System.EventHandler(this.LogoMrCake_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(1433, 44);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 22);
            this.lblHora.TabIndex = 44;
            this.lblHora.Text = ":Hora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(1434, 17);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(64, 22);
            this.lblData.TabIndex = 43;
            this.lblData.Text = ":Data:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(184, 46);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = ":Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(184, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 25);
            this.lblNome.TabIndex = 41;
            this.lblNome.Text = ":Nome:";
            // 
            // Gerenciar_PedE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 901);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.PanelGerRec);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gerenciar_PedE";
            this.Text = "Editar_Rec";
            this.Load += new System.EventHandler(this.Gerenciar_PedE_Load);
            this.PanelGerRec.ResumeLayout(false);
            this.PanelGerRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRec)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelPedidos.ResumeLayout(false);
            this.PanelProduto.ResumeLayout(false);
            this.PanelFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMrCake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelGerRec;
        private Guna.UI2.WinForms.Guna2TextBox txtGerRecSearch;
        private System.Windows.Forms.DataGridView GridViewRec;
        private Guna.UI2.WinForms.Guna2Button ButtonExibir;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel PanelPedidos;
        private Guna.UI2.WinForms.Guna2Button btnGerenciar_PedF;
        private Guna.UI2.WinForms.Guna2Button btnGerenciar_PedE;
        private Guna.UI2.WinForms.Guna2ImageButton BtnReceita;
        private Guna.UI2.WinForms.Guna2Panel PanelProduto;
        private Guna.UI2.WinForms.Guna2Button btnGerenciar_Prod;
        private Guna.UI2.WinForms.Guna2Button btnCad_Prod;
        private Guna.UI2.WinForms.Guna2ImageButton BtnProduto;
        private Guna.UI2.WinForms.Guna2Panel PanelFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnGerenciar_Func;
        private Guna.UI2.WinForms.Guna2Button btnCad_Func;
        private Guna.UI2.WinForms.Guna2ImageButton BtnFuncionario;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox LogoMrCake;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
    }
}