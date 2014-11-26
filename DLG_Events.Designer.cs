namespace Compact_Agenda
{
    partial class DLG_Events
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
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_Starting = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_Ending = new System.Windows.Forms.DateTimePicker();
            this.FB_Abort = new FlashButton.FlashButton();
            this.FB_Ok = new FlashButton.FlashButton();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(93, 15);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(132, 22);
            this.TBX_Title.TabIndex = 0;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(93, 47);
            this.TBX_Description.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(385, 104);
            this.TBX_Description.TabIndex = 1;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(93, 159);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(165, 22);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.ValueChanged += new System.EventHandler(this.DTP_Date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // DTP_Starting
            // 
            this.DTP_Starting.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Starting.Location = new System.Drawing.Point(93, 191);
            this.DTP_Starting.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_Starting.Name = "DTP_Starting";
            this.DTP_Starting.Size = new System.Drawing.Size(107, 22);
            this.DTP_Starting.TabIndex = 4;
            this.DTP_Starting.ValueChanged += new System.EventHandler(this.DTP_Starting_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Début";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fin";
            // 
            // DTP_Ending
            // 
            this.DTP_Ending.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Ending.Location = new System.Drawing.Point(93, 223);
            this.DTP_Ending.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_Ending.Name = "DTP_Ending";
            this.DTP_Ending.Size = new System.Drawing.Size(107, 22);
            this.DTP_Ending.TabIndex = 45;
            this.DTP_Ending.ValueChanged += new System.EventHandler(this.DTP_Ending_ValueChanged);
            // 
            // FB_Abort
            // 
            this.FB_Abort.BackgroundImage = global::Compact_Agenda.Properties.Resources.Abort;
            this.FB_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Abort.ImageClick = global::Compact_Agenda.Properties.Resources.Abort_Click;
            this.FB_Abort.ImageDisable = global::Compact_Agenda.Properties.Resources.Abort_Disable;
            this.FB_Abort.ImageNeutral = global::Compact_Agenda.Properties.Resources.Abort;
            this.FB_Abort.ImageOver = global::Compact_Agenda.Properties.Resources.Abort;
            this.FB_Abort.Location = new System.Drawing.Point(311, 213);
            this.FB_Abort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Abort.Name = "FB_Abort";
            this.FB_Abort.Size = new System.Drawing.Size(48, 48);
            this.FB_Abort.TabIndex = 48;
            this.FB_Abort.Click += new System.EventHandler(this.FB_Abort_Click);
            // 
            // FB_Ok
            // 
            this.FB_Ok.BackColor = System.Drawing.Color.Transparent;
            this.FB_Ok.BackgroundImage = global::Compact_Agenda.Properties.Resources.Ok;
            this.FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ok.ImageClick = global::Compact_Agenda.Properties.Resources.Ok_Click;
            this.FB_Ok.ImageDisable = global::Compact_Agenda.Properties.Resources.Ok_Disable;
            this.FB_Ok.ImageNeutral = global::Compact_Agenda.Properties.Resources.Ok;
            this.FB_Ok.ImageOver = global::Compact_Agenda.Properties.Resources.Ok;
            this.FB_Ok.Location = new System.Drawing.Point(405, 213);
            this.FB_Ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(48, 48);
            this.FB_Ok.TabIndex = 47;
            this.FB_Ok.Click += new System.EventHandler(this.FB_Ok_Click);
            // 
            // CB_Type
            // 
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "Général",
            "Travail",
            "Loisir",
            "Santé",
            "Important",
            "Autre"});
            this.CB_Type.Location = new System.Drawing.Point(291, 15);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(121, 24);
            this.CB_Type.TabIndex = 49;
            this.CB_Type.SelectedIndexChanged += new System.EventHandler(this.CB_Type_SelectedIndexChanged);
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 265);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.FB_Abort);
            this.Controls.Add(this.FB_Ok);
            this.Controls.Add(this.DTP_Ending);
            this.Controls.Add(this.DTP_Starting);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLG_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DLG_Events";
            this.Load += new System.EventHandler(this.DLG_Events_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_Starting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_Ending;
        private FlashButton.FlashButton FB_Ok;
        private FlashButton.FlashButton FB_Abort;
        private System.Windows.Forms.ComboBox CB_Type;
    }
}