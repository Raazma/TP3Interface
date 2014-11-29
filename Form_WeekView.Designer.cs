namespace PasswordKeeper
{
    partial class Form_WeekView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WeekView));
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.PN_Scroll = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Content = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Hours = new PasswordKeeper.DoubleBufferPanel();
            this.CM_Heure = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.couleurDeFondToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.policeEtCouleurDeCaractèresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.PN_DaysHeader = new PasswordKeeper.DoubleBufferPanel();
            this.CM_Jour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.choixDeLaDateDeLaSemaineCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.policeEtCouleurDeCaractèresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UCS_Zoom = new UC_Slider.UC_Slider();
            this.CM_Event = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporterDuneSemaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupliquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaqueJoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaqueMoisPourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaqueAnnéesPourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Calendrier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDesLignesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demiHeureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeEtCouleurDeCaractèresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.T_Titre = new System.Windows.Forms.Timer(this.components);
            this.PN_Frame.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.CM_Heure.SuspendLayout();
            this.CM_Jour.SuspendLayout();
            this.CM_Event.SuspendLayout();
            this.CM_Calendrier.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Frame
            // 
            this.PN_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Frame.BackColor = System.Drawing.Color.Orange;
            this.PN_Frame.Controls.Add(this.PN_Scroll);
            this.PN_Frame.Controls.Add(this.FBTN_DecrementWeek);
            this.PN_Frame.Controls.Add(this.FBTN_IncrementWeek);
            this.PN_Frame.Controls.Add(this.PN_DaysHeader);
            this.PN_Frame.Controls.Add(this.UCS_Zoom);
            this.PN_Frame.Location = new System.Drawing.Point(0, 0);
            this.PN_Frame.Name = "PN_Frame";
            this.PN_Frame.Size = new System.Drawing.Size(743, 589);
            this.PN_Frame.TabIndex = 4;
            this.PN_Frame.MouseEnter += new System.EventHandler(this.UCS_Zoom_MouseLeave);
            // 
            // PN_Scroll
            // 
            this.PN_Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Scroll.AutoScroll = true;
            this.PN_Scroll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PN_Scroll.Controls.Add(this.PN_Content);
            this.PN_Scroll.Controls.Add(this.PN_Hours);
            this.PN_Scroll.Location = new System.Drawing.Point(3, 34);
            this.PN_Scroll.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Scroll.Name = "PN_Scroll";
            this.PN_Scroll.Size = new System.Drawing.Size(737, 552);
            this.PN_Scroll.TabIndex = 1;
            this.PN_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PN_Scroll_Scroll);
            this.PN_Scroll.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Scroll_Paint);
            this.PN_Scroll.Resize += new System.EventHandler(this.PN_Scroll_Resize);
            // 
            // PN_Content
            // 
            this.PN_Content.Location = new System.Drawing.Point(36, 0);
            this.PN_Content.Name = "PN_Content";
            this.PN_Content.Size = new System.Drawing.Size(628, 522);
            this.PN_Content.TabIndex = 0;
            this.PN_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Content_Paint);
            this.PN_Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseClick);
            this.PN_Content.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDoubleClick);
            this.PN_Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDown);
            this.PN_Content.MouseEnter += new System.EventHandler(this.UCS_Zoom_MouseLeave);
            this.PN_Content.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseMove);
            this.PN_Content.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseUp);
            this.PN_Content.Resize += new System.EventHandler(this.PN_Content_Resize);
            // 
            // PN_Hours
            // 
            this.PN_Hours.BackColor = System.Drawing.Color.LightGray;
            this.PN_Hours.ContextMenuStrip = this.CM_Heure;
            this.PN_Hours.Location = new System.Drawing.Point(0, 0);
            this.PN_Hours.Name = "PN_Hours";
            this.PN_Hours.Size = new System.Drawing.Size(36, 518);
            this.PN_Hours.TabIndex = 1;
            this.PN_Hours.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hours_Paint);
            this.PN_Hours.MouseHover += new System.EventHandler(this.PN_Hours_MouseHover);
            // 
            // CM_Heure
            // 
            this.CM_Heure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurDeFondToolStripMenuItem2,
            this.policeEtCouleurDeCaractèresToolStripMenuItem2});
            this.CM_Heure.Name = "CM_Heure";
            this.CM_Heure.Size = new System.Drawing.Size(244, 70);
            // 
            // couleurDeFondToolStripMenuItem2
            // 
            this.couleurDeFondToolStripMenuItem2.Name = "couleurDeFondToolStripMenuItem2";
            this.couleurDeFondToolStripMenuItem2.Size = new System.Drawing.Size(243, 22);
            this.couleurDeFondToolStripMenuItem2.Text = "Couleur de fond…";
            this.couleurDeFondToolStripMenuItem2.Click += new System.EventHandler(this.couleurDeFondToolStripMenuItem2_Click);
            // 
            // policeEtCouleurDeCaractèresToolStripMenuItem2
            // 
            this.policeEtCouleurDeCaractèresToolStripMenuItem2.Name = "policeEtCouleurDeCaractèresToolStripMenuItem2";
            this.policeEtCouleurDeCaractèresToolStripMenuItem2.Size = new System.Drawing.Size(243, 22);
            this.policeEtCouleurDeCaractèresToolStripMenuItem2.Text = "Police et couleur de caractères...";
            // 
            // FBTN_DecrementWeek
            // 
            this.FBTN_DecrementWeek.BackgroundImage = global::PasswordKeeper.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_DecrementWeek.ImageClick = global::PasswordKeeper.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.ImageDisable = global::PasswordKeeper.Properties.Resources.ICON_Left_Disable;
            this.FBTN_DecrementWeek.ImageNeutral = global::PasswordKeeper.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.ImageOver = global::PasswordKeeper.Properties.Resources.ICON_Left_Over;
            this.FBTN_DecrementWeek.Location = new System.Drawing.Point(3, 2);
            this.FBTN_DecrementWeek.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_DecrementWeek.Name = "FBTN_DecrementWeek";
            this.FBTN_DecrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_DecrementWeek.TabIndex = 2;
            this.FBTN_DecrementWeek.Click += new System.EventHandler(this.FBTN_DecrementWeek_Click);
            this.FBTN_DecrementWeek.MouseEnter += new System.EventHandler(this.UCS_Zoom_MouseLeave);
            // 
            // FBTN_IncrementWeek
            // 
            this.FBTN_IncrementWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBTN_IncrementWeek.BackgroundImage = global::PasswordKeeper.Properties.Resources.ICON_Right_Neutral;
            this.FBTN_IncrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_IncrementWeek.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.FBTN_IncrementWeek.ImageClick = global::PasswordKeeper.Properties.Resources.ICON_Right_Click;
            this.FBTN_IncrementWeek.ImageDisable = global::PasswordKeeper.Properties.Resources.ICON_Right_Disable;
            this.FBTN_IncrementWeek.ImageNeutral = global::PasswordKeeper.Properties.Resources.ICON_Right_Neutral;
            this.FBTN_IncrementWeek.ImageOver = global::PasswordKeeper.Properties.Resources.ICON_Right_Over;
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(708, 2);
            this.FBTN_IncrementWeek.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_IncrementWeek.TabIndex = 3;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // PN_DaysHeader
            // 
            this.PN_DaysHeader.BackColor = System.Drawing.Color.Orange;
            this.PN_DaysHeader.ContextMenuStrip = this.CM_Jour;
            this.PN_DaysHeader.Location = new System.Drawing.Point(39, 2);
            this.PN_DaysHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PN_DaysHeader.Name = "PN_DaysHeader";
            this.PN_DaysHeader.Size = new System.Drawing.Size(628, 32);
            this.PN_DaysHeader.TabIndex = 0;
            this.PN_DaysHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_DaysHeader_Paint);
            this.PN_DaysHeader.MouseEnter += new System.EventHandler(this.UCS_Zoom_MouseLeave);
            // 
            // CM_Jour
            // 
            this.CM_Jour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choixDeLaDateDeLaSemaineCouranteToolStripMenuItem,
            this.couleurDeFondToolStripMenuItem1,
            this.policeEtCouleurDeCaractèresToolStripMenuItem1});
            this.CM_Jour.Name = "CM_Jour";
            this.CM_Jour.Size = new System.Drawing.Size(293, 70);
            // 
            // choixDeLaDateDeLaSemaineCouranteToolStripMenuItem
            // 
            this.choixDeLaDateDeLaSemaineCouranteToolStripMenuItem.Name = "choixDeLaDateDeLaSemaineCouranteToolStripMenuItem";
            this.choixDeLaDateDeLaSemaineCouranteToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.choixDeLaDateDeLaSemaineCouranteToolStripMenuItem.Text = "Choix de la date de la semaine courante…";
            // 
            // couleurDeFondToolStripMenuItem1
            // 
            this.couleurDeFondToolStripMenuItem1.Name = "couleurDeFondToolStripMenuItem1";
            this.couleurDeFondToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.couleurDeFondToolStripMenuItem1.Text = "Couleur de fond…";
            this.couleurDeFondToolStripMenuItem1.Click += new System.EventHandler(this.couleurDeFondToolStripMenuItem1_Click);
            // 
            // policeEtCouleurDeCaractèresToolStripMenuItem1
            // 
            this.policeEtCouleurDeCaractèresToolStripMenuItem1.Name = "policeEtCouleurDeCaractèresToolStripMenuItem1";
            this.policeEtCouleurDeCaractèresToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.policeEtCouleurDeCaractèresToolStripMenuItem1.Text = "Police et couleur de caractères...";
            // 
            // UCS_Zoom
            // 
            this.UCS_Zoom.BackColor = System.Drawing.Color.Transparent;
            this.UCS_Zoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UCS_Zoom.BarDisableImage = ((System.Drawing.Image)(resources.GetObject("UCS_Zoom.BarDisableImage")));
            this.UCS_Zoom.BarEnableImage = ((System.Drawing.Image)(resources.GetObject("UCS_Zoom.BarEnableImage")));
            this.UCS_Zoom.CursorDisableImage = ((System.Drawing.Image)(resources.GetObject("UCS_Zoom.CursorDisableImage")));
            this.UCS_Zoom.CursorEnableImage = ((System.Drawing.Image)(resources.GetObject("UCS_Zoom.CursorEnableImage")));
            this.UCS_Zoom.CursorOverImage = ((System.Drawing.Image)(resources.GetObject("UCS_Zoom.CursorOverImage")));
            this.UCS_Zoom.Location = new System.Drawing.Point(0, -37);
            this.UCS_Zoom.Maximum = 100;
            this.UCS_Zoom.Minimum = 0;
            this.UCS_Zoom.Name = "UCS_Zoom";
            this.UCS_Zoom.Size = new System.Drawing.Size(18, 200);
            this.UCS_Zoom.TabIndex = 0;
            this.UCS_Zoom.Value = 0;
            this.UCS_Zoom.ValueChanged += new UC_Slider.UC_Slider.ValueChangedHandler(this.UCS_Zoom_ValueChanged);
            this.UCS_Zoom.MouseLeave += new System.EventHandler(this.UCS_Zoom_MouseLeave);
            // 
            // CM_Event
            // 
            this.CM_Event.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.reporterDuneSemaineToolStripMenuItem,
            this.dupliquerToolStripMenuItem});
            this.CM_Event.Name = "contextMenuStrip1";
            this.CM_Event.Size = new System.Drawing.Size(200, 92);
            this.CM_Event.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.effacerToolStripMenuItem.Text = "Effacer...";
            this.effacerToolStripMenuItem.Click += new System.EventHandler(this.effacerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modifierToolStripMenuItem.Text = "Modifier…";
            // 
            // reporterDuneSemaineToolStripMenuItem
            // 
            this.reporterDuneSemaineToolStripMenuItem.Name = "reporterDuneSemaineToolStripMenuItem";
            this.reporterDuneSemaineToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.reporterDuneSemaineToolStripMenuItem.Text = "Reporter d’une semaine";
            // 
            // dupliquerToolStripMenuItem
            // 
            this.dupliquerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaqueJoursToolStripMenuItem,
            this.chaqueToolStripMenuItem,
            this.chaqueMoisPourToolStripMenuItem,
            this.chaqueAnnéesPourToolStripMenuItem});
            this.dupliquerToolStripMenuItem.Name = "dupliquerToolStripMenuItem";
            this.dupliquerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dupliquerToolStripMenuItem.Text = "Dupliquer…";
            // 
            // chaqueJoursToolStripMenuItem
            // 
            this.chaqueJoursToolStripMenuItem.Name = "chaqueJoursToolStripMenuItem";
            this.chaqueJoursToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chaqueJoursToolStripMenuItem.Text = "Chaque Jour Pour...";
            // 
            // chaqueToolStripMenuItem
            // 
            this.chaqueToolStripMenuItem.Name = "chaqueToolStripMenuItem";
            this.chaqueToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chaqueToolStripMenuItem.Text = "Chaque Semaine Pour...";
            // 
            // chaqueMoisPourToolStripMenuItem
            // 
            this.chaqueMoisPourToolStripMenuItem.Name = "chaqueMoisPourToolStripMenuItem";
            this.chaqueMoisPourToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chaqueMoisPourToolStripMenuItem.Text = "Chaque Mois Pour...";
            // 
            // chaqueAnnéesPourToolStripMenuItem
            // 
            this.chaqueAnnéesPourToolStripMenuItem.Name = "chaqueAnnéesPourToolStripMenuItem";
            this.chaqueAnnéesPourToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chaqueAnnéesPourToolStripMenuItem.Text = "Chaque Années Pour...";
            // 
            // CM_Calendrier
            // 
            this.CM_Calendrier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.couleurDeFondToolStripMenuItem,
            this.couleurDesLignesToolStripMenuItem,
            this.policeEtCouleurDeCaractèresToolStripMenuItem});
            this.CM_Calendrier.Name = "CM_Calendrier";
            this.CM_Calendrier.Size = new System.Drawing.Size(244, 92);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter...";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // couleurDeFondToolStripMenuItem
            // 
            this.couleurDeFondToolStripMenuItem.Name = "couleurDeFondToolStripMenuItem";
            this.couleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.couleurDeFondToolStripMenuItem.Text = "Couleur de fond…";
            // 
            // couleurDesLignesToolStripMenuItem
            // 
            this.couleurDesLignesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalesToolStripMenuItem,
            this.verticalesToolStripMenuItem});
            this.couleurDesLignesToolStripMenuItem.Name = "couleurDesLignesToolStripMenuItem";
            this.couleurDesLignesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.couleurDesLignesToolStripMenuItem.Text = "Couleur des lignes";
            // 
            // horizontalesToolStripMenuItem
            // 
            this.horizontalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heuresToolStripMenuItem,
            this.demiHeureToolStripMenuItem});
            this.horizontalesToolStripMenuItem.Name = "horizontalesToolStripMenuItem";
            this.horizontalesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.horizontalesToolStripMenuItem.Text = "Horizontales";
            // 
            // heuresToolStripMenuItem
            // 
            this.heuresToolStripMenuItem.Name = "heuresToolStripMenuItem";
            this.heuresToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.heuresToolStripMenuItem.Text = "Heures...";
            // 
            // demiHeureToolStripMenuItem
            // 
            this.demiHeureToolStripMenuItem.Name = "demiHeureToolStripMenuItem";
            this.demiHeureToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.demiHeureToolStripMenuItem.Text = "Demi-Heure...";
            // 
            // verticalesToolStripMenuItem
            // 
            this.verticalesToolStripMenuItem.Name = "verticalesToolStripMenuItem";
            this.verticalesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.verticalesToolStripMenuItem.Text = "Verticales...";
            // 
            // policeEtCouleurDeCaractèresToolStripMenuItem
            // 
            this.policeEtCouleurDeCaractèresToolStripMenuItem.Name = "policeEtCouleurDeCaractèresToolStripMenuItem";
            this.policeEtCouleurDeCaractèresToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.policeEtCouleurDeCaractèresToolStripMenuItem.Text = "Police et couleur de caractères...";
            // 
            // T_Titre
            // 
            this.T_Titre.Interval = 500;
            this.T_Titre.Tick += new System.EventHandler(this.T_Titre_Tick);
            // 
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 589);
            this.Controls.Add(this.PN_Frame);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 498);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.Resize += new System.EventHandler(this.Form_WeekView_Resize);
            this.PN_Frame.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
            this.CM_Heure.ResumeLayout(false);
            this.CM_Jour.ResumeLayout(false);
            this.CM_Event.ResumeLayout(false);
            this.CM_Calendrier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel PN_DaysHeader;
        private DoubleBufferPanel PN_Scroll;
        private DoubleBufferPanel PN_Content;
        private DoubleBufferPanel PN_Hours;
        private FlashButton.FlashButton FBTN_DecrementWeek;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private System.Windows.Forms.Panel PN_Frame;
        private System.Windows.Forms.ContextMenuStrip CM_Event;
        private System.Windows.Forms.ToolStripMenuItem effacerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_Calendrier;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.Timer T_Titre;
        private UC_Slider.UC_Slider UCS_Zoom;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporterDuneSemaineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupliquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_Heure;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem policeEtCouleurDeCaractèresToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip CM_Jour;
        private System.Windows.Forms.ToolStripMenuItem choixDeLaDateDeLaSemaineCouranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem policeEtCouleurDeCaractèresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chaqueJoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaqueMoisPourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaqueAnnéesPourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDesLignesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demiHeureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeEtCouleurDeCaractèresToolStripMenuItem;


    }
}