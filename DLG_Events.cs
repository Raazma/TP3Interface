using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public partial class DLG_Events : Form
    {
        public Event Event { get; set; }
        private bool blockUpdate;
        public bool delete = false;
        public DLG_Events()
        {
            InitializeComponent();
        }

        private void DLG_Events_Load(object sender, EventArgs e)
        {
            delete = false;
            EventToDLG();
        }

        public static DateTime Klone(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
        }

        private void EventToDLG()
        {
            if (Event != null)
            {
                TBX_Title.Text = Event.Title;
                TBX_Description.Text = Event.Description;
                blockUpdate = true;
                DTP_Date.Value = Klone(Event.Starting);
                DTP_Starting.Value = Klone(Event.Starting);
                DTP_Ending.Value = Klone(Event.Ending);
                blockUpdate = false;
            }
            else
                Event = new Event();
        }

        private void TBX_Title_TextChanged(object sender, EventArgs e)
        {
            Event.Title = TBX_Title.Text;
        }

        private void TBX_Description_TextChanged(object sender, EventArgs e)
        {
            Event.Description = TBX_Description.Text;
        }

        private void DTP_Date_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                DTP_Starting.Value.Hour,
                                                DTP_Starting.Value.Minute,
                                                0);

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            DTP_Ending.Value.Hour,
                                            DTP_Ending.Value.Minute,
                                            0);
            }
        }

        private void DTP_Starting_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 DTP_Starting.Value.Hour,
                                                 DTP_Starting.Value.Minute,
                                                 0);
            }
        }

        private void DTP_Ending_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            DTP_Ending.Value.Hour,
                                            DTP_Ending.Value.Minute,
                                            0);
            }
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?") == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                delete = true;
                this.Close();
            }
        }
    }
}
