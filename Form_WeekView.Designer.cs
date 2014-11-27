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
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.CM_Event = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Calendrier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.T_Titre = new System.Windows.Forms.Timer(this.components);
            this.PN_Scroll = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Content = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Hours = new PasswordKeeper.DoubleBufferPanel();
            this.PN_DaysHeader = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Frame.SuspendLayout();
            this.CM_Event.SuspendLayout();
            this.CM_Calendrier.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Frame
            // 
            this.PN_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Frame.BackColor = System.Drawing.Color.DarkGreen;
            this.PN_Frame.Controls.Add(this.PN_Scroll);
            this.PN_Frame.Controls.Add(this.FBTN_DecrementWeek);
            this.PN_Frame.Controls.Add(this.FBTN_IncrementWeek);
            this.PN_Frame.Controls.Add(this.PN_DaysHeader);
            this.PN_Frame.Location = new System.Drawing.Point(0, 0);
            this.PN_Frame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PN_Frame.Name = "PN_Frame";
            this.PN_Frame.Size = new System.Drawing.Size(991, 725);
            this.PN_Frame.TabIndex = 4;
            // 
            // FBTN_DecrementWeek
            // 
            this.FBTN_DecrementWeek.BackgroundImage = global::PasswordKeeper.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_DecrementWeek.ImageClick = global::PasswordKeeper.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.ImageDisable = global::PasswordKeeper.Properties.Resources.ICON_Left_Disable;
            this.FBTN_DecrementWeek.ImageNeutral = global::PasswordKeeper.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.ImageOver = global::PasswordKeeper.Properties.Resources.ICON_Left_Over;
            this.FBTN_DecrementWeek.Location = new System.Drawing.Point(4, 2);
            this.FBTN_DecrementWeek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FBTN_DecrementWeek.Name = "FBTN_DecrementWeek";
            this.FBTN_DecrementWeek.Size = new System.Drawing.Size(43, 39);
            this.FBTN_DecrementWeek.TabIndex = 2;
            this.FBTN_DecrementWeek.Click += new System.EventHandler(this.FBTN_DecrementWeek_Click);
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
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(944, 2);
            this.FBTN_IncrementWeek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(43, 39);
            this.FBTN_IncrementWeek.TabIndex = 3;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // CM_Event
            // 
            this.CM_Event.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerToolStripMenuItem});
            this.CM_Event.Name = "contextMenuStrip1";
            this.CM_Event.Size = new System.Drawing.Size(125, 28);
            this.CM_Event.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.effacerToolStripMenuItem.Text = "Effacer";
            this.effacerToolStripMenuItem.Click += new System.EventHandler(this.effacerToolStripMenuItem_Click);
            // 
            // CM_Calendrier
            // 
            this.CM_Calendrier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.CM_Calendrier.Name = "CM_Calendrier";
            this.CM_Calendrier.Size = new System.Drawing.Size(128, 28);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // T_Titre
            // 
            this.T_Titre.Interval = 500;
            this.T_Titre.Tick += new System.EventHandler(this.T_Titre_Tick);
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
            this.PN_Scroll.Location = new System.Drawing.Point(4, 42);
            this.PN_Scroll.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Scroll.Name = "PN_Scroll";
            this.PN_Scroll.Size = new System.Drawing.Size(983, 679);
            this.PN_Scroll.TabIndex = 1;
            this.PN_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PN_Scroll_Scroll);
            this.PN_Scroll.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Scroll_Paint);
            this.PN_Scroll.Resize += new System.EventHandler(this.PN_Scroll_Resize);
            // 
            // PN_Content
            // 
            this.PN_Content.Location = new System.Drawing.Point(48, 0);
            this.PN_Content.Margin = new System.Windows.Forms.Padding(4);
            this.PN_Content.Name = "PN_Content";
            this.PN_Content.Size = new System.Drawing.Size(837, 642);
            this.PN_Content.TabIndex = 0;
            this.PN_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Content_Paint);
            this.PN_Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseClick);
            this.PN_Content.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDoubleClick);
            this.PN_Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDown);
            this.PN_Content.MouseEnter += new System.EventHandler(this.PN_Scroll_MouseEnter);
            this.PN_Content.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseMove);
            this.PN_Content.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseUp);
            this.PN_Content.Resize += new System.EventHandler(this.PN_Content_Resize);
            // 
            // PN_Hours
            // 
            this.PN_Hours.BackColor = System.Drawing.Color.GreenYellow;
            this.PN_Hours.Location = new System.Drawing.Point(0, 0);
            this.PN_Hours.Margin = new System.Windows.Forms.Padding(4);
            this.PN_Hours.Name = "PN_Hours";
            this.PN_Hours.Size = new System.Drawing.Size(48, 638);
            this.PN_Hours.TabIndex = 1;
            this.PN_Hours.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hours_Paint);
            // 
            // PN_DaysHeader
            // 
            this.PN_DaysHeader.BackColor = System.Drawing.Color.GreenYellow;
            this.PN_DaysHeader.Location = new System.Drawing.Point(52, 2);
            this.PN_DaysHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PN_DaysHeader.Name = "PN_DaysHeader";
            this.PN_DaysHeader.Size = new System.Drawing.Size(837, 39);
            this.PN_DaysHeader.TabIndex = 0;
            this.PN_DaysHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_DaysHeader_Paint);
            // 
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 725);
            this.Controls.Add(this.PN_Frame);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 605);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.PN_Frame.ResumeLayout(false);
            this.CM_Event.ResumeLayout(false);
            this.CM_Calendrier.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
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

    }
}