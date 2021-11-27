namespace SrBolo_Prototype1
{
    partial class Gerenciar_Prod
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar_Prod));
            this.PanelGerProd = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtGerProdSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.GridViewProd = new System.Windows.Forms.DataGridView();
            this.ButtonAdc = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonExc = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnDesc = new Guna.UI2.WinForms.Guna2Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelGerProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProd)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelPedidos.SuspendLayout();
            this.PanelProduto.SuspendLayout();
            this.PanelFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMrCake)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGerProd
            // 
            this.PanelGerProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGerProd.BorderRadius = 40;
            this.PanelGerProd.Controls.Add(this.lblAviso);
            this.PanelGerProd.Controls.Add(this.lblTitle);
            this.PanelGerProd.Controls.Add(this.txtGerProdSearch);
            this.PanelGerProd.Controls.Add(this.ButtonEdit);
            this.PanelGerProd.Controls.Add(this.GridViewProd);
            this.PanelGerProd.Controls.Add(this.ButtonAdc);
            this.PanelGerProd.Controls.Add(this.ButtonExc);
            this.PanelGerProd.Location = new System.Drawing.Point(129, 66);
            this.PanelGerProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelGerProd.Name = "PanelGerProd";
            this.PanelGerProd.ShadowDecoration.Parent = this.PanelGerProd;
            this.PanelGerProd.Size = new System.Drawing.Size(1219, 700);
            this.PanelGerProd.TabIndex = 3;
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.White;
            this.lblAviso.ForeColor = System.Drawing.Color.Black;
            this.lblAviso.Location = new System.Drawing.Point(15, 625);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(362, 17);
            this.lblAviso.TabIndex = 39;
            this.lblAviso.Text = "*Para realizar uma operação, clique no campo desejado";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 31);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Estoque de Produtos";
            // 
            // txtGerProdSearch
            // 
            this.txtGerProdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGerProdSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtGerProdSearch.BorderRadius = 20;
            this.txtGerProdSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGerProdSearch.DefaultText = "";
            this.txtGerProdSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGerProdSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGerProdSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGerProdSearch.DisabledState.Parent = this.txtGerProdSearch;
            this.txtGerProdSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGerProdSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtGerProdSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGerProdSearch.FocusedState.Parent = this.txtGerProdSearch;
            this.txtGerProdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerProdSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGerProdSearch.HoverState.Parent = this.txtGerProdSearch;
            this.txtGerProdSearch.Location = new System.Drawing.Point(796, 14);
            this.txtGerProdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGerProdSearch.Name = "txtGerProdSearch";
            this.txtGerProdSearch.PasswordChar = '\0';
            this.txtGerProdSearch.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGerProdSearch.PlaceholderText = "Digite ID ou Nome";
            this.txtGerProdSearch.SelectedText = "";
            this.txtGerProdSearch.ShadowDecoration.Parent = this.txtGerProdSearch;
            this.txtGerProdSearch.Size = new System.Drawing.Size(404, 37);
            this.txtGerProdSearch.TabIndex = 25;
            this.txtGerProdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGerProdSearch_KeyDown);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ButtonEdit.CheckedState.Parent = this.ButtonEdit;
            this.ButtonEdit.CustomImages.Parent = this.ButtonEdit;
            this.ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEdit.DisabledState.Parent = this.ButtonEdit;
            this.ButtonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(133)))), ((int)(((byte)(129)))));
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.HoverState.Parent = this.ButtonEdit;
            this.ButtonEdit.Location = new System.Drawing.Point(849, 600);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(160, 41);
            this.ButtonEdit.TabIndex = 24;
            this.ButtonEdit.Text = "Editar";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // GridViewProd
            // 
            this.GridViewProd.AllowUserToAddRows = false;
            this.GridViewProd.AllowUserToDeleteRows = false;
            this.GridViewProd.AllowUserToResizeColumns = false;
            this.GridViewProd.AllowUserToResizeRows = false;
            this.GridViewProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewProd.BackgroundColor = System.Drawing.Color.White;
            this.GridViewProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridViewProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridViewProd.Location = new System.Drawing.Point(22, 55);
            this.GridViewProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewProd.Name = "GridViewProd";
            this.GridViewProd.RowHeadersVisible = false;
            this.GridViewProd.RowHeadersWidth = 62;
            this.GridViewProd.RowTemplate.Height = 28;
            this.GridViewProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewProd.Size = new System.Drawing.Size(1178, 532);
            this.GridViewProd.TabIndex = 23;
            // 
            // ButtonAdc
            // 
            this.ButtonAdc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ButtonAdc.CheckedState.Parent = this.ButtonAdc;
            this.ButtonAdc.CustomImages.Parent = this.ButtonAdc;
            this.ButtonAdc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdc.DisabledState.Parent = this.ButtonAdc;
            this.ButtonAdc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.ButtonAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonAdc.ForeColor = System.Drawing.Color.White;
            this.ButtonAdc.HoverState.Parent = this.ButtonAdc;
            this.ButtonAdc.Location = new System.Drawing.Point(1040, 600);
            this.ButtonAdc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdc.Name = "ButtonAdc";
            this.ButtonAdc.ShadowDecoration.Parent = this.ButtonAdc;
            this.ButtonAdc.Size = new System.Drawing.Size(160, 41);
            this.ButtonAdc.TabIndex = 22;
            this.ButtonAdc.Text = "Adicionar";
            this.ButtonAdc.Click += new System.EventHandler(this.ButtonAdc_Click);
            // 
            // ButtonExc
            // 
            this.ButtonExc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ButtonExc.CheckedState.Parent = this.ButtonExc;
            this.ButtonExc.CustomImages.Parent = this.ButtonExc;
            this.ButtonExc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExc.DisabledState.Parent = this.ButtonExc;
            this.ButtonExc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ButtonExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExc.ForeColor = System.Drawing.Color.White;
            this.ButtonExc.HoverState.Parent = this.ButtonExc;
            this.ButtonExc.Location = new System.Drawing.Point(655, 600);
            this.ButtonExc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExc.Name = "ButtonExc";
            this.ButtonExc.ShadowDecoration.Parent = this.ButtonExc;
            this.ButtonExc.Size = new System.Drawing.Size(160, 41);
            this.ButtonExc.TabIndex = 21;
            this.ButtonExc.Text = "Excluir";
            this.ButtonExc.Click += new System.EventHandler(this.ButtonExc_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.BtnDesc);
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
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.ShadowDecoration.Parent = this.PanelMenu;
            this.PanelMenu.Size = new System.Drawing.Size(128, 721);
            this.PanelMenu.TabIndex = 16;
            // 
            // BtnDesc
            // 
            this.BtnDesc.CheckedState.Parent = this.BtnDesc;
            this.BtnDesc.CustomImages.Parent = this.BtnDesc;
            this.BtnDesc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDesc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDesc.DisabledState.Parent = this.BtnDesc;
            this.BtnDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDesc.FillColor = System.Drawing.Color.Salmon;
            this.BtnDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDesc.ForeColor = System.Drawing.Color.White;
            this.BtnDesc.HoverState.Parent = this.BtnDesc;
            this.BtnDesc.Location = new System.Drawing.Point(0, 685);
            this.BtnDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDesc.Name = "BtnDesc";
            this.BtnDesc.ShadowDecoration.Parent = this.BtnDesc;
            this.BtnDesc.Size = new System.Drawing.Size(128, 36);
            this.BtnDesc.TabIndex = 59;
            this.BtnDesc.Text = "Desconectar";
            this.BtnDesc.Click += new System.EventHandler(this.BtnDesc_Click);
            // 
            // PanelPedidos
            // 
            this.PanelPedidos.Controls.Add(this.btnGerenciar_PedF);
            this.PanelPedidos.Controls.Add(this.btnGerenciar_PedE);
            this.PanelPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPedidos.Location = new System.Drawing.Point(0, 597);
            this.PanelPedidos.Name = "PanelPedidos";
            this.PanelPedidos.ShadowDecoration.Parent = this.PanelPedidos;
            this.PanelPedidos.Size = new System.Drawing.Size(128, 146);
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
            this.btnGerenciar_PedF.Location = new System.Drawing.Point(0, 73);
            this.btnGerenciar_PedF.Name = "btnGerenciar_PedF";
            this.btnGerenciar_PedF.ShadowDecoration.Parent = this.btnGerenciar_PedF;
            this.btnGerenciar_PedF.Size = new System.Drawing.Size(128, 73);
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
            this.btnGerenciar_PedE.Name = "btnGerenciar_PedE";
            this.btnGerenciar_PedE.ShadowDecoration.Parent = this.btnGerenciar_PedE;
            this.btnGerenciar_PedE.Size = new System.Drawing.Size(128, 73);
            this.btnGerenciar_PedE.TabIndex = 1;
            this.btnGerenciar_PedE.Text = "Gerenciar Pedidos Ecommerce";
            this.btnGerenciar_PedE.Click += new System.EventHandler(this.btnGerenciar_PedE_Click);
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
            this.BtnReceita.Location = new System.Drawing.Point(0, 507);
            this.BtnReceita.Name = "BtnReceita";
            this.BtnReceita.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnReceita.PressedState.Parent = this.BtnReceita;
            this.BtnReceita.ShadowDecoration.Parent = this.BtnReceita;
            this.BtnReceita.Size = new System.Drawing.Size(128, 90);
            this.BtnReceita.TabIndex = 11;
            this.BtnReceita.Click += new System.EventHandler(this.BtnReceita_Click);
            // 
            // PanelProduto
            // 
            this.PanelProduto.Controls.Add(this.btnGerenciar_Prod);
            this.PanelProduto.Controls.Add(this.btnCad_Prod);
            this.PanelProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProduto.Location = new System.Drawing.Point(0, 397);
            this.PanelProduto.Name = "PanelProduto";
            this.PanelProduto.ShadowDecoration.Parent = this.PanelProduto;
            this.PanelProduto.Size = new System.Drawing.Size(128, 110);
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
            this.btnGerenciar_Prod.Location = new System.Drawing.Point(0, 56);
            this.btnGerenciar_Prod.Name = "btnGerenciar_Prod";
            this.btnGerenciar_Prod.ShadowDecoration.Parent = this.btnGerenciar_Prod;
            this.btnGerenciar_Prod.Size = new System.Drawing.Size(128, 56);
            this.btnGerenciar_Prod.TabIndex = 2;
            this.btnGerenciar_Prod.Text = "Gerenciar Produto";
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
            this.btnCad_Prod.Name = "btnCad_Prod";
            this.btnCad_Prod.ShadowDecoration.Parent = this.btnCad_Prod;
            this.btnCad_Prod.Size = new System.Drawing.Size(128, 56);
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
            this.BtnProduto.Location = new System.Drawing.Point(0, 307);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnProduto.PressedState.Parent = this.BtnProduto;
            this.BtnProduto.ShadowDecoration.Parent = this.BtnProduto;
            this.BtnProduto.Size = new System.Drawing.Size(128, 90);
            this.BtnProduto.TabIndex = 4;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // PanelFuncionario
            // 
            this.PanelFuncionario.Controls.Add(this.btnGerenciar_Func);
            this.PanelFuncionario.Controls.Add(this.btnCad_Func);
            this.PanelFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFuncionario.Location = new System.Drawing.Point(0, 197);
            this.PanelFuncionario.Name = "PanelFuncionario";
            this.PanelFuncionario.ShadowDecoration.Parent = this.PanelFuncionario;
            this.PanelFuncionario.Size = new System.Drawing.Size(128, 110);
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
            this.btnGerenciar_Func.Location = new System.Drawing.Point(0, 55);
            this.btnGerenciar_Func.Name = "btnGerenciar_Func";
            this.btnGerenciar_Func.ShadowDecoration.Parent = this.btnGerenciar_Func;
            this.btnGerenciar_Func.Size = new System.Drawing.Size(128, 55);
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
            this.btnCad_Func.Name = "btnCad_Func";
            this.btnCad_Func.ShadowDecoration.Parent = this.btnCad_Func;
            this.btnCad_Func.Size = new System.Drawing.Size(128, 55);
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
            this.BtnFuncionario.Location = new System.Drawing.Point(0, 107);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.PressedState.Image = global::SrBolo_Prototype1.Properties.Resources.IMGBtnFunc;
            this.BtnFuncionario.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnFuncionario.PressedState.Parent = this.BtnFuncionario;
            this.BtnFuncionario.ShadowDecoration.Parent = this.BtnFuncionario;
            this.BtnFuncionario.Size = new System.Drawing.Size(128, 90);
            this.BtnFuncionario.TabIndex = 2;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Location = new System.Drawing.Point(148, 129);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(208, 100);
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
            this.LogoMrCake.Name = "LogoMrCake";
            this.LogoMrCake.ShadowDecoration.Parent = this.LogoMrCake;
            this.LogoMrCake.Size = new System.Drawing.Size(128, 107);
            this.LogoMrCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMrCake.TabIndex = 0;
            this.LogoMrCake.TabStop = false;
            this.LogoMrCake.Click += new System.EventHandler(this.LogoMrCake_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(1274, 34);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 18);
            this.lblHora.TabIndex = 52;
            this.lblHora.Text = ":Hora:";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(1200, 12);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 18);
            this.lblData.TabIndex = 51;
            this.lblData.Text = ":Data:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(164, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = ":Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(164, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(69, 20);
            this.lblNome.TabIndex = 49;
            this.lblNome.Text = ":Nome:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Gerenciar_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.PanelGerProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gerenciar_Prod";
            this.Text = "Gerenciar_Prod";
            this.Load += new System.EventHandler(this.Gerenciar_Prod_Load);
            this.PanelGerProd.ResumeLayout(false);
            this.PanelGerProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProd)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelPedidos.ResumeLayout(false);
            this.PanelProduto.ResumeLayout(false);
            this.PanelFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMrCake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelGerProd;
        private Guna.UI2.WinForms.Guna2TextBox txtGerProdSearch;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private System.Windows.Forms.DataGridView GridViewProd;
        private Guna.UI2.WinForms.Guna2Button ButtonAdc;
        private Guna.UI2.WinForms.Guna2Button ButtonExc;
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
        private Guna.UI2.WinForms.Guna2Button BtnDesc;
        private System.Windows.Forms.Timer timer1;
    }
}