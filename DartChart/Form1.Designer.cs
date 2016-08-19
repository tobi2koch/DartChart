namespace DartChart
{
    partial class punktestand
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mickeyMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.grpContent = new System.Windows.Forms.Panel();
            this.grpContentRight = new System.Windows.Forms.Panel();
            this.grpEingabe = new System.Windows.Forms.Panel();
            this.lblWurfNr3 = new System.Windows.Forms.Label();
            this.lblWurfNr2 = new System.Windows.Forms.Label();
            this.lblWurfNr1 = new System.Windows.Forms.Label();
            this.txtWurf3 = new System.Windows.Forms.TextBox();
            this.txtWurf2 = new System.Windows.Forms.TextBox();
            this.btnStandBerechnen = new System.Windows.Forms.Button();
            this.txtWurf1 = new System.Windows.Forms.TextBox();
            this.grpPunkte = new System.Windows.Forms.Panel();
            this.txtVorlageInput = new System.Windows.Forms.TextBox();
            this.lblVorlagePunkte = new System.Windows.Forms.Label();
            this.grpPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVorlageSpieler = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.Panel();
            this.lblSpielmodus = new System.Windows.Forms.Label();
            this.lblDurchgang = new System.Windows.Forms.Label();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.btnAnzSpieler = new System.Windows.Forms.Button();
            this.lblAnzahlSpieler = new System.Windows.Forms.Label();
            this.numAnzPlayer = new System.Windows.Forms.NumericUpDown();
            this.menu.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.grpContentRight.SuspendLayout();
            this.grpEingabe.SuspendLayout();
            this.grpPunkte.SuspendLayout();
            this.grpPlayer.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnzPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(483, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "&Spiel";
            this.spielToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.mickeyMouseToolStripMenuItem});
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.neuesSpielToolStripMenuItem.Text = "&Neues Spiel";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem2.Text = "&301";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem3.Text = "&501";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // mickeyMouseToolStripMenuItem
            // 
            this.mickeyMouseToolStripMenuItem.Name = "mickeyMouseToolStripMenuItem";
            this.mickeyMouseToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mickeyMouseToolStripMenuItem.Text = "&Mickey Mouse";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "&Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.grpContent);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.grpInfo);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(483, 612);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(483, 636);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu);
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.grpContentRight);
            this.grpContent.Controls.Add(this.grpPunkte);
            this.grpContent.Controls.Add(this.grpPlayer);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContent.Location = new System.Drawing.Point(0, 81);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(483, 531);
            this.grpContent.TabIndex = 10;
            // 
            // grpContentRight
            // 
            this.grpContentRight.Controls.Add(this.grpEingabe);
            this.grpContentRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpContentRight.Location = new System.Drawing.Point(179, 0);
            this.grpContentRight.Name = "grpContentRight";
            this.grpContentRight.Size = new System.Drawing.Size(304, 531);
            this.grpContentRight.TabIndex = 8;
            // 
            // grpEingabe
            // 
            this.grpEingabe.AutoSize = true;
            this.grpEingabe.Controls.Add(this.lblWurfNr3);
            this.grpEingabe.Controls.Add(this.lblWurfNr2);
            this.grpEingabe.Controls.Add(this.lblWurfNr1);
            this.grpEingabe.Controls.Add(this.txtWurf3);
            this.grpEingabe.Controls.Add(this.txtWurf2);
            this.grpEingabe.Controls.Add(this.btnStandBerechnen);
            this.grpEingabe.Controls.Add(this.txtWurf1);
            this.grpEingabe.Location = new System.Drawing.Point(0, 0);
            this.grpEingabe.Margin = new System.Windows.Forms.Padding(0);
            this.grpEingabe.Name = "grpEingabe";
            this.grpEingabe.Size = new System.Drawing.Size(300, 63);
            this.grpEingabe.TabIndex = 13;
            this.grpEingabe.Visible = false;
            // 
            // lblWurfNr3
            // 
            this.lblWurfNr3.AutoSize = true;
            this.lblWurfNr3.BackColor = System.Drawing.Color.White;
            this.lblWurfNr3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWurfNr3.Location = new System.Drawing.Point(213, 45);
            this.lblWurfNr3.Name = "lblWurfNr3";
            this.lblWurfNr3.Size = new System.Drawing.Size(13, 15);
            this.lblWurfNr3.TabIndex = 16;
            this.lblWurfNr3.Text = "3";
            // 
            // lblWurfNr2
            // 
            this.lblWurfNr2.AutoSize = true;
            this.lblWurfNr2.BackColor = System.Drawing.Color.White;
            this.lblWurfNr2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWurfNr2.Location = new System.Drawing.Point(137, 45);
            this.lblWurfNr2.Name = "lblWurfNr2";
            this.lblWurfNr2.Size = new System.Drawing.Size(13, 15);
            this.lblWurfNr2.TabIndex = 15;
            this.lblWurfNr2.Text = "2";
            // 
            // lblWurfNr1
            // 
            this.lblWurfNr1.AutoSize = true;
            this.lblWurfNr1.BackColor = System.Drawing.Color.White;
            this.lblWurfNr1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWurfNr1.Location = new System.Drawing.Point(61, 45);
            this.lblWurfNr1.Name = "lblWurfNr1";
            this.lblWurfNr1.Size = new System.Drawing.Size(13, 15);
            this.lblWurfNr1.TabIndex = 14;
            this.lblWurfNr1.Text = "1";
            // 
            // txtWurf3
            // 
            this.txtWurf3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWurf3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWurf3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtWurf3.ForeColor = System.Drawing.Color.SlateGray;
            this.txtWurf3.Location = new System.Drawing.Point(155, 6);
            this.txtWurf3.MaxLength = 3;
            this.txtWurf3.Name = "txtWurf3";
            this.txtWurf3.Size = new System.Drawing.Size(71, 41);
            this.txtWurf3.TabIndex = 2;
            this.txtWurf3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWurf3.WordWrap = false;
            this.txtWurf3.Enter += new System.EventHandler(this.inputBetreten_Enter);
            this.txtWurf3.Leave += new System.EventHandler(this.inputVerlassen_Leave);
            // 
            // txtWurf2
            // 
            this.txtWurf2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWurf2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWurf2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtWurf2.ForeColor = System.Drawing.Color.SlateGray;
            this.txtWurf2.Location = new System.Drawing.Point(79, 6);
            this.txtWurf2.MaxLength = 3;
            this.txtWurf2.Name = "txtWurf2";
            this.txtWurf2.Size = new System.Drawing.Size(71, 41);
            this.txtWurf2.TabIndex = 1;
            this.txtWurf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWurf2.WordWrap = false;
            this.txtWurf2.Enter += new System.EventHandler(this.inputBetreten_Enter);
            // 
            // btnStandBerechnen
            // 
            this.btnStandBerechnen.BackColor = System.Drawing.Color.SlateGray;
            this.btnStandBerechnen.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnStandBerechnen.FlatAppearance.BorderSize = 0;
            this.btnStandBerechnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandBerechnen.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandBerechnen.ForeColor = System.Drawing.Color.White;
            this.btnStandBerechnen.Location = new System.Drawing.Point(231, 6);
            this.btnStandBerechnen.Name = "btnStandBerechnen";
            this.btnStandBerechnen.Size = new System.Drawing.Size(66, 41);
            this.btnStandBerechnen.TabIndex = 3;
            this.btnStandBerechnen.Text = "GO";
            this.btnStandBerechnen.UseVisualStyleBackColor = false;
            this.btnStandBerechnen.Click += new System.EventHandler(this.btnStandBerechnen_Click);
            this.btnStandBerechnen.Leave += new System.EventHandler(this.inputVerlassen_Leave);
            // 
            // txtWurf1
            // 
            this.txtWurf1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWurf1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWurf1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtWurf1.ForeColor = System.Drawing.Color.SlateGray;
            this.txtWurf1.Location = new System.Drawing.Point(3, 6);
            this.txtWurf1.MaxLength = 3;
            this.txtWurf1.Name = "txtWurf1";
            this.txtWurf1.Size = new System.Drawing.Size(71, 41);
            this.txtWurf1.TabIndex = 0;
            this.txtWurf1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWurf1.WordWrap = false;
            this.txtWurf1.Enter += new System.EventHandler(this.inputBetreten_Enter);
            // 
            // grpPunkte
            // 
            this.grpPunkte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPunkte.Controls.Add(this.txtVorlageInput);
            this.grpPunkte.Controls.Add(this.lblVorlagePunkte);
            this.grpPunkte.Location = new System.Drawing.Point(121, 0);
            this.grpPunkte.MinimumSize = new System.Drawing.Size(60, 0);
            this.grpPunkte.Name = "grpPunkte";
            this.grpPunkte.Size = new System.Drawing.Size(60, 531);
            this.grpPunkte.TabIndex = 7;
            // 
            // txtVorlageInput
            // 
            this.txtVorlageInput.AcceptsReturn = true;
            this.txtVorlageInput.BackColor = System.Drawing.Color.White;
            this.txtVorlageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVorlageInput.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorlageInput.ForeColor = System.Drawing.Color.SlateGray;
            this.txtVorlageInput.Location = new System.Drawing.Point(434, 9);
            this.txtVorlageInput.Name = "txtVorlageInput";
            this.txtVorlageInput.Size = new System.Drawing.Size(100, 37);
            this.txtVorlageInput.TabIndex = 7;
            this.txtVorlageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVorlageInput.Visible = false;
            // 
            // lblVorlagePunkte
            // 
            this.lblVorlagePunkte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVorlagePunkte.AutoEllipsis = true;
            this.lblVorlagePunkte.BackColor = System.Drawing.Color.SlateGray;
            this.lblVorlagePunkte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVorlagePunkte.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblVorlagePunkte.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblVorlagePunkte.Location = new System.Drawing.Point(0, 7);
            this.lblVorlagePunkte.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblVorlagePunkte.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lblVorlagePunkte.MinimumSize = new System.Drawing.Size(60, 40);
            this.lblVorlagePunkte.Name = "lblVorlagePunkte";
            this.lblVorlagePunkte.Size = new System.Drawing.Size(60, 40);
            this.lblVorlagePunkte.TabIndex = 6;
            this.lblVorlagePunkte.Text = "301";
            this.lblVorlagePunkte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVorlagePunkte.Visible = false;
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.lblVorlageSpieler);
            this.grpPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPlayer.Location = new System.Drawing.Point(0, 0);
            this.grpPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.grpPlayer.MinimumSize = new System.Drawing.Size(120, 0);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(121, 531);
            this.grpPlayer.TabIndex = 6;
            // 
            // lblVorlageSpieler
            // 
            this.lblVorlageSpieler.AutoEllipsis = true;
            this.lblVorlageSpieler.BackColor = System.Drawing.Color.White;
            this.lblVorlageSpieler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVorlageSpieler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVorlageSpieler.Location = new System.Drawing.Point(0, 6);
            this.lblVorlageSpieler.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblVorlageSpieler.Name = "lblVorlageSpieler";
            this.lblVorlageSpieler.Size = new System.Drawing.Size(117, 40);
            this.lblVorlageSpieler.TabIndex = 5;
            this.lblVorlageSpieler.Text = "Spieler";
            this.lblVorlageSpieler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVorlageSpieler.Visible = false;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Black;
            this.grpInfo.Controls.Add(this.lblSpielmodus);
            this.grpInfo.Controls.Add(this.lblDurchgang);
            this.grpInfo.Controls.Add(this.lblGameMode);
            this.grpInfo.Controls.Add(this.btnAnzSpieler);
            this.grpInfo.Controls.Add(this.lblAnzahlSpieler);
            this.grpInfo.Controls.Add(this.numAnzPlayer);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Location = new System.Drawing.Point(0, 0);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(483, 81);
            this.grpInfo.TabIndex = 9;
            // 
            // lblSpielmodus
            // 
            this.lblSpielmodus.AutoSize = true;
            this.lblSpielmodus.BackColor = System.Drawing.Color.Black;
            this.lblSpielmodus.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielmodus.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblSpielmodus.Location = new System.Drawing.Point(209, 10);
            this.lblSpielmodus.Name = "lblSpielmodus";
            this.lblSpielmodus.Size = new System.Drawing.Size(0, 21);
            this.lblSpielmodus.TabIndex = 14;
            this.lblSpielmodus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDurchgang
            // 
            this.lblDurchgang.AutoSize = true;
            this.lblDurchgang.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurchgang.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDurchgang.Location = new System.Drawing.Point(410, 10);
            this.lblDurchgang.Name = "lblDurchgang";
            this.lblDurchgang.Size = new System.Drawing.Size(54, 21);
            this.lblDurchgang.TabIndex = 13;
            this.lblDurchgang.Text = "RUNDE";
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblGameMode.Location = new System.Drawing.Point(117, 10);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(92, 21);
            this.lblGameMode.TabIndex = 12;
            this.lblGameMode.Text = "SPIELMODUS";
            // 
            // btnAnzSpieler
            // 
            this.btnAnzSpieler.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnzSpieler.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAnzSpieler.FlatAppearance.BorderSize = 0;
            this.btnAnzSpieler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnzSpieler.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnzSpieler.ForeColor = System.Drawing.Color.White;
            this.btnAnzSpieler.Location = new System.Drawing.Point(77, 42);
            this.btnAnzSpieler.Name = "btnAnzSpieler";
            this.btnAnzSpieler.Size = new System.Drawing.Size(40, 28);
            this.btnAnzSpieler.TabIndex = 11;
            this.btnAnzSpieler.Text = "GO";
            this.btnAnzSpieler.UseVisualStyleBackColor = false;
            this.btnAnzSpieler.Click += new System.EventHandler(this.btnAnzSpieler_Click);
            // 
            // lblAnzahlSpieler
            // 
            this.lblAnzahlSpieler.AutoSize = true;
            this.lblAnzahlSpieler.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahlSpieler.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAnzahlSpieler.Location = new System.Drawing.Point(0, 10);
            this.lblAnzahlSpieler.Name = "lblAnzahlSpieler";
            this.lblAnzahlSpieler.Size = new System.Drawing.Size(73, 21);
            this.lblAnzahlSpieler.TabIndex = 9;
            this.lblAnzahlSpieler.Text = "# SPIELER";
            // 
            // numAnzPlayer
            // 
            this.numAnzPlayer.BackColor = System.Drawing.Color.White;
            this.numAnzPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAnzPlayer.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAnzPlayer.ForeColor = System.Drawing.Color.SlateGray;
            this.numAnzPlayer.Location = new System.Drawing.Point(0, 43);
            this.numAnzPlayer.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numAnzPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnzPlayer.Name = "numAnzPlayer";
            this.numAnzPlayer.Size = new System.Drawing.Size(71, 27);
            this.numAnzPlayer.TabIndex = 0;
            this.numAnzPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAnzPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnzPlayer.Enter += new System.EventHandler(this.numAnzPlayer_Enter);
            this.numAnzPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAnzPlayer_KeyPress);
            this.numAnzPlayer.Leave += new System.EventHandler(this.numAnzPlayer_Leave);
            // 
            // punktestand
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(483, 636);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "punktestand";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punktestand";
            this.Load += new System.EventHandler(this.punktestand_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContentRight.ResumeLayout(false);
            this.grpContentRight.PerformLayout();
            this.grpEingabe.ResumeLayout(false);
            this.grpEingabe.PerformLayout();
            this.grpPunkte.ResumeLayout(false);
            this.grpPunkte.PerformLayout();
            this.grpPlayer.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnzPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mickeyMouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel grpInfo;
        private System.Windows.Forms.Label lblAnzahlSpieler;
        private System.Windows.Forms.NumericUpDown numAnzPlayer;
        private System.Windows.Forms.Button btnAnzSpieler;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label lblDurchgang;
        private System.Windows.Forms.Panel grpContent;
        private System.Windows.Forms.Panel grpContentRight;
        private System.Windows.Forms.Panel grpPunkte;
        private System.Windows.Forms.TextBox txtVorlageInput;
        private System.Windows.Forms.Label lblVorlagePunkte;
        private System.Windows.Forms.FlowLayoutPanel grpPlayer;
        private System.Windows.Forms.Label lblVorlageSpieler;
        private System.Windows.Forms.Panel grpEingabe;
        private System.Windows.Forms.Button btnStandBerechnen;
        private System.Windows.Forms.TextBox txtWurf1;
        private System.Windows.Forms.TextBox txtWurf3;
        private System.Windows.Forms.TextBox txtWurf2;
        private System.Windows.Forms.Label lblSpielmodus;
        private System.Windows.Forms.Label lblWurfNr3;
        private System.Windows.Forms.Label lblWurfNr2;
        private System.Windows.Forms.Label lblWurfNr1;
    }
}

