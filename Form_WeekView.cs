using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Slider;


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Agenda Compacte:
//
//  Auteur: Nicolas Chourot
//  Date:   Novembre 2014
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Ce source constitution la plate forme de déaprt pour le TP#3
//  INTIALEZ LES PORTIONS DE CODE QUE VOUS AVEZ MODIFIÉ ET/OU AJOUTÉ
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PasswordKeeper
{
    public partial class Form_WeekView : Form
    {

        public string ConnexionString; 
        private DateTime _CurrentWeek;
        private Events Events = new Events();
        private int minInterval = 5;
        public DateTime CurrentWeek
        {
            set 
            { 
                // calculer la date du dimanche de la semaine courante
                _CurrentWeek = value.AddDays(-(int)value.DayOfWeek);
            }
            get { return _CurrentWeek; }
        }

        public Form_WeekView()
        {
            InitializeComponent();
            // Ici on assume que la BD est dans le même répertoire que l'éxécutable
            // faire attention de copier la bd dans le répertoire release et/ou debug selon le cas
            string DB_URL = System.IO.Path.GetFullPath(@"DB_AGENDA.MDF");
            ConnexionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='" + DB_URL + "';Integrated Security=True";
            CurrentWeek = DateTime.Now;
            PN_Hours.Height = PN_Content.Height = 2400;
            

        }

        private void Form_WeekView_Load(object sender, EventArgs e)
        {
            PN_Scroll.Focus();
            GotoCurrentWeek();
            T_Titre.Enabled = true;
            this.Text = "Agenda compacte - " + DateTime.Now.ToString();
            AdjustZoom();
        }

        private void PN_Scroll_MouseEnter(Object sender, EventArgs e)
        {
            // pour s'assurer que le mousewheel event sera intercepté
          
            PN_Scroll.Focus();

        }

      
        private void GetWeekEvents()
        {
            TableEvents tableEvents = new TableEvents(ConnexionString);
            DateTime date = _CurrentWeek;
            Events.Clear();
            for (int day = 0; day < 7; day++)
            {
                tableEvents.GetDateEvents(date);
                while (tableEvents.NextEventRecord())
                {
                    tableEvents.currentEventRecord.ParentPanel = PN_Content;
                    Events.Add(tableEvents.currentEventRecord);
                }
                tableEvents.EndQuerySQL();
                date = date.AddDays(1);
            }
        }

        private void Fill_Agenda(Graphics DC)
        {
            Brush brush = new SolidBrush(Color.Black);
            Pen pen1 = new Pen(Color.LightGray, 1);
            Pen pen2 = new Pen(Color.LightGray, 1);
            pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            for (int hour = 0; hour < 24; hour++)
            {
                DC.DrawLine(pen1, 0, Event.HourToPixel(hour + 1,  0, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour + 1,  0, PN_Hours.Height));
                DC.DrawLine(pen2, 0, Event.HourToPixel(hour, 30, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour, 30, PN_Hours.Height));
            }
            Point location;
            for (int dayNum = 0; dayNum < 7; dayNum++)
            {
                location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * dayNum), 0);
                DC.DrawLine(pen1, location.X, 0, location.X, PN_Content.Height);
            }
            location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * 7), 0);
            DC.DrawLine(pen1, location.X - 1, 0, location.X - 1, PN_Content.Height);
            Events.Draw(DC);
            PN_Scroll.Focus();
        }

        private void PN_Content_Paint(object sender, PaintEventArgs e)
        {
            Fill_Agenda(e.Graphics);
        }

        private void Fill_Days_Header(Graphics DC)
        {
            Point location;
            DateTime date = _CurrentWeek;
            string[] dayNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames;//[col].Substring(0, 3).ToUpper();
            Brush brush = new SolidBrush(Color.Snow);
            Pen pen = new Pen(Color.Snow, 1);
            for (int dayNum = 0; dayNum < 7; dayNum++)
            {
                
                location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * dayNum), 0);
                if (DateTime.Parse(date.Date.ToShortDateString()) == DateTime.Parse(DateTime.Now.Date.ToShortDateString()))
                {
                    Rectangle border = new Rectangle(location.X,location.Y,(int)Math.Round(PN_DaysHeader.Width / 7f * (dayNum+1))-location.X,PN_DaysHeader.Height);
                    using (Brush B = new SolidBrush(Color.DarkOrange))
                    {
                        DC.FillRectangle(B, border);
                    }
                    
                }
                String headerText = dayNames[dayNum];
                String headerDate = date.ToShortDateString();
                DC.DrawLine(pen, location.X, 0, location.X, PN_DaysHeader.Height);
                DC.DrawString(headerText, PN_DaysHeader.Font, brush, location);
                DC.DrawString(headerDate, PN_DaysHeader.Font, brush, location.X, location.Y + 14);
                date = date.AddDays(1);
            }
            location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * 7), 0);
            DC.DrawLine(pen, location.X - 1, 0, location.X - 1, PN_DaysHeader.Height);
        }

        private void Fill_Hours_Header(Graphics DC)
        {
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);
            for (int hour = 0; hour <= 24; hour++)
            {
               
                Point location = new Point(0, Event.HourToPixel(hour, 0, PN_Hours.Height));
                if(DateTime.Now.Hour==hour)
                {
                    Rectangle border = new Rectangle(location.X, location.Y, PN_Hours.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height) - location.Y);
                    
                    using (Brush B = new SolidBrush(Color.DimGray))
                    {
                        DC.FillRectangle(B, border);
                    }
                }
                String headerText = (hour < 10? "0": "") + hour.ToString() + ":00";
                DC.DrawString(headerText, PN_DaysHeader.Font, brush, location); 
                DC.DrawLine(pen, 0,Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Hours.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
            }
        }

        private void PN_DaysHeader_Paint(object sender, PaintEventArgs e)
        {
            Fill_Days_Header(e.Graphics);
        }

        private void PN_Hours_Paint(object sender, PaintEventArgs e)
        {
            Fill_Hours_Header(e.Graphics);
        }

        private void AdjustMinInterval()
        {
            minInterval = 5;
            while (Event.HourToPixel(0, minInterval, PN_Content.Height) < 5)
                minInterval += 5;
        }
        private void PN_Scroll_Resize(object sender, EventArgs e)
        {
            PN_Content.Width = PN_Scroll.Width - 70;
            PN_DaysHeader.Width = PN_Content.Width;
            PN_DaysHeader.Width = PN_Content.Width;
            PN_DaysHeader.Refresh();
            PN_Content.Refresh();
        }

        private void PN_Scroll_Scroll(object sender, ScrollEventArgs e)
        {
            PN_DaysHeader.Refresh();
            PN_Content.Refresh();
        }


        Point lastMouseLocation;
        Point firstMouseLocation; 
        bool mouseIsDown = false;
        Pen pen = new Pen(Color.Blue, 1);

        private int RoundToMinutes(int pixel, int interval)
        {
            int pixel_interval = Event.HourToPixel(0, interval, PN_Content.Height);
            if (pixel_interval > 5)
            {
                int half_interval = (int)Math.Round(pixel_interval / 2f);

                int minutes = Event.PixelToMinutes(pixel + half_interval, PN_Content.Height);
                minutes = (int)Math.Truncate((float)minutes / interval) * interval;
                int hour = (int)Math.Truncate(minutes / 60f);
                minutes = minutes - hour * 60;
                return Event.HourToPixel(hour, minutes, PN_Content.Height);
            }
            else
                return pixel;
        }
        bool rightButtonDown = false;
        int AnchorDeltaMinutes;
        private void PN_Content_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rightButtonDown)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    mouseIsDown = true;
                    firstMouseLocation = lastMouseLocation = e.Location;
                    //Events.DeSelectAll();
                    if (Events.TargetEvent != null)
                    {
                        switch (Events.TargetPart)
                        {
                            case TargetPart.Top:
                                firstMouseLocation.Y =
                                lastMouseLocation.Y = RoundToMinutes(Event.HourToPixel(Events.TargetEvent.Starting.Hour, Events.TargetEvent.Starting.Minute, PN_Content.Height), minInterval);
                                break;
                            case TargetPart.Bottom:
                                firstMouseLocation.Y =
                                lastMouseLocation.Y = RoundToMinutes(Event.HourToPixel(Events.TargetEvent.Ending.Hour, Events.TargetEvent.Ending.Minute, PN_Content.Height), minInterval);
                                break;
                            case TargetPart.Inside:
                                int StartingMinutes = Events.TargetEvent.Starting.Hour * 60 + Events.TargetEvent.Starting.Minute;
                                AnchorDeltaMinutes = Event.PixelToMinutes(e.Location.Y, PN_Content.Height) - StartingMinutes;
                                break;
                            default: break;
                        }
                        //Events.TargetEvent.Selected = true;
                        PN_Content.Refresh();
                    }
                }
                else
                    if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        rightButtonDown = true;
                    }
            }
            else
                rightButtonDown = false;
        }

        private void AjustCurrentWeek()
        {
            DateTime Target = new DateTime(Events.TargetEvent.Starting.Year, Events.TargetEvent.Starting.Month, Events.TargetEvent.Starting.Day, 0, 0, 0);
            DateTime CW = new DateTime(_CurrentWeek.Year, _CurrentWeek.Month, _CurrentWeek.Day, 0, 0, 0);
            int delta = (int)(Target - CW).TotalDays;
            if (delta > 6)
            {
                Event currentTarget = Events.TargetEvent.Klone();
                Increment_Week();
                Events.Add(currentTarget);
                currentTarget.Draw(PN_Content.CreateGraphics());
                Events.TargetEvent = currentTarget;
                Cursor.Position = new Point(Cursor.Position.X - 7 * (int)(PN_Content.Width / 7F), Cursor.Position.Y);
            }
            if (delta < 0)
            {
                Event currentTarget = Events.TargetEvent.Klone();
                Decrement_Week();
                Events.Add(currentTarget);
                currentTarget.Draw(PN_Content.CreateGraphics());
                Events.TargetEvent = currentTarget;
                Cursor.Position = new Point(Cursor.Position.X + 7 * (int)(PN_Content.Width / 7F), Cursor.Position.Y);
            }
        }

        private void AdjustScroll(int value)
        {
            int PN_Scroll_Mouse_Location = value - PN_Scroll.VerticalScroll.Value;
            int hour_heigth = Event.HourToPixel(1, 0, PN_Scroll.Height);

            if (PN_Scroll_Mouse_Location < 0)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + hour_heigth);
                if ((PN_Scroll.VerticalScroll.Value - hour_heigth) > hour_heigth)
                    PN_Scroll.VerticalScroll.Value -= hour_heigth;
            }
            if (PN_Scroll_Mouse_Location > PN_Scroll.Height)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - hour_heigth);
                if ((PN_Scroll.VerticalScroll.Value + hour_heigth) < PN_Content.Height)
                    PN_Scroll.VerticalScroll.Value += hour_heigth;
            }
        }

        private static DateTime Klone( DateTime x)
        {
            return new DateTime(x.Year, x.Month, x.Day, x.Hour, x.Minute, 0);
        }

        private void PN_Content_MouseMove(object sender, MouseEventArgs e)
        {
            int MouseVerticalLocation = RoundToMinutes(e.Location.Y, minInterval);
            if (mouseIsDown)
            {
                AdjustScroll(e.Location.Y);
                if (Events.TargetEvent != null)
                {
                    //Events.TargetEvent.Selected = true;
                    DateTime Moving = LocationToDateTime(new Point(RoundToMinutes(firstMouseLocation.X, minInterval), MouseVerticalLocation));
                    switch (Events.TargetPart)
                    {
                        case TargetPart.Top:
                            if (Moving > Events.TargetEvent.Ending)
                            {
                                Events.TargetPart = TargetPart.Bottom;
                                Events.TargetEvent.Starting = Klone(Events.TargetEvent.Ending);
                                Events.TargetEvent.Ending = Moving;
                            }
                            else
                                Events.TargetEvent.Starting = Moving;
                            break;
                        case TargetPart.Bottom:

                            if (Moving < Events.TargetEvent.Starting)
                            {
                                Events.TargetPart = TargetPart.Top;
                                Events.TargetEvent.Ending = Klone(Events.TargetEvent.Starting);
                                Events.TargetEvent.Starting = Moving;
                            }
                            else
                                Events.TargetEvent.Ending = Moving;
                            break;
                        case TargetPart.Inside:

                            int StartingMinutes = Events.TargetEvent.Starting.Hour * 60 + Events.TargetEvent.Starting.Minute;
                            int movingMinutes = (int)Math.Max(Moving.Hour * 60 + Moving.Minute - AnchorDeltaMinutes, 0);
                            DateTime start = Events.TargetEvent.Starting;
                            Events.TargetEvent.Starting = new DateTime(LocationToDateTime(new Point(e.Location.X, 10)).Year, LocationToDateTime(new Point(e.Location.X, 10)).Month, LocationToDateTime(new Point(e.Location.X, 10)).Day, (int)Math.Truncate(movingMinutes / 60F), movingMinutes - (int)Math.Truncate(movingMinutes / 60F) * 60, 0);
                            int EndingMinutes = Events.TargetEvent.Ending.Hour * 60 + Events.TargetEvent.Ending.Minute;
                            int deltaHours = (int)Math.Truncate((EndingMinutes - StartingMinutes) / 60F);
                            int deltaMinutes = (EndingMinutes - StartingMinutes) - 60 * deltaHours;
                            EndingMinutes = Events.TargetEvent.Starting.Hour * 60 + Events.TargetEvent.Starting.Minute + deltaHours * 60 + deltaMinutes;
                            Events.TargetEvent.Ending = new DateTime(LocationToDateTime(new Point(e.Location.X, 10)).Year,
                                                                         LocationToDateTime(new Point(e.Location.X, 10)).Month,
                                                                         LocationToDateTime(new Point(e.Location.X, 10)).Day,
                                                                         (int)Math.Min(Math.Truncate(EndingMinutes / 60F), 23),
                                                                         EndingMinutes - (int)Math.Truncate(EndingMinutes / 60F) * 60, 0);
                            AjustCurrentWeek();
                            break;
                        default: break;
                    }
                    PN_Content.Refresh();
                }
                else
                {
                    //Events.DeSelectAll();
                    int day = (int)Math.Truncate(firstMouseLocation.X / (PN_Content.Width / 7F));
                    PN_Content.Cursor = Cursors.Cross;
                    Point top = new Point((int)Math.Round(day * PN_Content.Width / 7F), RoundToMinutes(firstMouseLocation.Y, minInterval));
                    Rectangle border = new Rectangle(top.X + 1, (int)Math.Min(top.Y, MouseVerticalLocation), (int)Math.Round(PN_Content.Width / 7F) - 2, (int)Math.Abs(MouseVerticalLocation - top.Y));
                    PN_Content.Refresh();
                    PN_Content.CreateGraphics().DrawRectangle(pen, border);
                }
            }
            else
            {
                Events.UpdateTarget(e.Location);
                if (Events.TargetEvent != null)
                    PN_Content.ContextMenuStrip = CM_Event;
                else
                    PN_Content.ContextMenuStrip = CM_Calendrier;

            }
            lastMouseLocation = e.Location;

        }

        private void ConludeMouseEvent()
        {
            if (mouseIsDown)
            {
                mouseIsDown = false;

                if (Events.TargetEvent != null)
                {
                    if (Events.TargetEvent.Starting > Events.TargetEvent.Ending)
                    {
                        Events.TargetPart = TargetPart.Top;
                        DateTime d = Events.TargetEvent.Starting;
                        Events.TargetEvent.Starting = Events.TargetEvent.Ending;
                        Events.TargetEvent.Ending = d;
                    }

                    TimeSpan delta = Events.TargetEvent.Ending.Subtract(Events.TargetEvent.Starting);
                    if (delta.Minutes < 30 && delta.Hours == 0)
                    {
                        Events.TargetEvent.Ending = Events.TargetEvent.Starting + new TimeSpan(0, 30, 0);
                    }
                    TableEvents tableEvents = new TableEvents(ConnexionString);
                    tableEvents.UpdateEventRecord(Events.TargetEvent);
                    //ScrollToEvent(Events.TargetEvent);
                    //Events.TargetEvent.Selected = true;
                }
                else
                { // Create a new Event...

                    if (firstMouseLocation.Y != lastMouseLocation.Y)
                    {
                        DLG_Events dlg = new DLG_Events();
                        Event Event = new Event();
                        Event.Starting = LocationToDateTime(firstMouseLocation);
                        DateTime date = LocationToDateTime(lastMouseLocation);
                        Event.Ending = new DateTime(Event.Starting.Year, Event.Starting.Month, Event.Starting.Day, date.Hour, date.Minute, 0);

                        // Validate starting and ending coherence
                        if (Event.Starting > Event.Ending)
                        {
                            Events.TargetPart = TargetPart.Top;
                            DateTime d = Event.Starting;
                            Event.Starting = Event.Ending;
                            Event.Ending = d;

                        }
                        TimeSpan delta = Event.Ending.Subtract(Event.Starting);
                        if (delta.Minutes < 30 && delta.Hours == 0)
                        {
                            Event.Ending = Event.Starting + new TimeSpan(0, 30, 0);
                        }

                        dlg.Event = Event.Klone();
                        if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            TableEvents tableEvents = new TableEvents(ConnexionString);
                            tableEvents.AddEvent(dlg.Event);
                            //ScrollToEvent(dlg.Event);
                            //DuplicateEvent(dlg.Event, dlg.Period_Code, dlg.Frequency);
                        }
                    }
                    PN_Content.Refresh();
                }
            }
        }

        private DateTime LocationToDateTime(Point location)
        {
            DateTime date = new DateTime(_CurrentWeek.Year, _CurrentWeek.Month, _CurrentWeek.Day);
            int adjust = (location.X < 0? (int)(PN_Content.Width / 7F) : 0);
            int days = (int)(Math.Truncate((location.X - adjust) / (PN_Content.Width / 7F)));

            date = date.AddDays(days);
            int Minutes = (int)Math.Max(Event.PixelToMinutes(RoundToMinutes(location.Y, minInterval), PN_Content.Height), 0);
            int Hours = (int)Math.Min((int)Math.Truncate(Minutes / 60f), 23);
            Minutes = Minutes - Hours * 60;
            if (Minutes >= 60)
                Minutes = 59;
            return new DateTime(date.Year, date.Month, date.Day, Hours, Minutes, 0); 
        }
         
        

        private void PN_Content_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Right)
                ConludeMouseEvent();
        }


        private void Decrement_Week()
        {
            _CurrentWeek = _CurrentWeek.AddDays(-7);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }
        private void Increment_Week()
        {
            _CurrentWeek = _CurrentWeek.AddDays(7);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }

        private void GotoCurrentWeek()
        {
            CurrentWeek = DateTime.Now;
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
            PN_Scroll.VerticalScroll.Value = Event.HourToPixel((int)Math.Max(DateTime.Now.Hour - 3, 0), 0, PN_Hours.Height);
        }

        private void FBTN_DecrementWeek_Click(object sender, EventArgs e)
        {
            Decrement_Week();
        }

        private void FBTN_IncrementWeek_Click(object sender, EventArgs e)
        {
            Increment_Week();
        }

        private void PN_Content_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((Events.TargetEvent != null) && (Events.TargetPart == TargetPart.Inside))
            {
                DLG_Events dlg = new DLG_Events();
                dlg.Event = Events.TargetEvent;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dlg.delete)
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.DeleteEvent(dlg.Event);
                        Events.TargetEvent = null;
                        mouseIsDown = false;
                    }
                    else
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.UpdateEventRecord(dlg.Event);
                    }
                    GetWeekEvents();
                    PN_Content.Refresh();
                }
            }
        }

        private void PN_Content_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Right:
                    //action
                    break;
                case Keys.Up:
                case Keys.Left:
                    //action
                    break;
                
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.OemMinus: // Incrémenter d'un mois la semaine courrante

                    // Fonction temporaire pour voir comment dézommer
                    if (!mouseIsDown)
                    {
                    //    if (PN_Content.Height > (PN_Frame.Height))
                    //    {
                    //        PN_Content.Height -= 200;
                    //        PN_Hours.Height -= 200;
                    //        PN_Content.Refresh();
                    //        PN_Hours.Refresh();
                    //    }
                        UCS_Zoom.Value-=2;
                    }
                    break;
                case Keys.Right: // Incrémenter d'une semaine la semaine courrante
                    if(!mouseIsDown)
                        Increment_Week();
                   
                   break;
                case Keys.Oemplus: // Décrémenter d'un mois la semaine courrante

                    // Fonction temporaire pour voir comment zommer
                   if (!mouseIsDown)
                   {
                       //if (PN_Content.Height < PN_Frame.Height *12)
                       //{
                       //    PN_Content.Height += 200;
                       //    PN_Hours.Height += 200;
                       //    PN_Content.Refresh();
                       //    PN_Hours.Refresh();
                       //}
                       UCS_Zoom.Value+=2;
                   }
                   break;
                case Keys.Left:// Décrémenter d'une semaine la semaine courrante
                   if (!mouseIsDown)
                       Decrement_Week();                 
                   break;

                case Keys.Space :
                   if (!mouseIsDown)
                       GotoCurrentWeek();
                   break;
                case Keys.F1:
                   A_Propos form = new A_Propos();
                   //this.Hide();
                   form.ShowDialog();                  
                  // this.Show();
                   break;

                case  Keys.Q | Keys.Alt:
                   this.Close();
                   break;

                case Keys.Up :
                   IncrementMonth();
                     break;
                case Keys.Down:
                     DecrementMonth();
                     break;

                     string[] tab;
                     tab = tab.Where(val => val != "Allo").ToArray();
            }

            
            
            bool result = base.ProcessCmdKey(ref msg, keyData);
            PN_Scroll.Focus();
            return result;
        }
        private void IncrementMonth()
        {
            _CurrentWeek = _CurrentWeek.AddDays(30);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        
        
        }
        private void DecrementMonth()
        {
            _CurrentWeek = _CurrentWeek.AddDays(-30);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }
        private void PN_Content_Resize(object sender, EventArgs e)
        {
            AdjustMinInterval();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void PN_Content_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if (Events.TargetEvent!=null && Events.TargetPart==TargetPart.Inside)
                {
                    CM_Event.Show(Cursor.Position);
                }
                else if(Events.TargetEvent==null)
                {
                    CM_Calendrier.Show(Cursor.Position);
                }
                
            }
        }

        private void effacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?") == System.Windows.Forms.DialogResult.OK)
            {
                TableEvents tableEvents = new TableEvents(ConnexionString);
                //Events.UpdateTarget(Cursor.Position);
                //if (Events.TargetEvent != null && Events.TargetPart == TargetPart.Inside)
                {
                    tableEvents.DeleteEvent(Events.TargetEvent);
                    Events.TargetEvent = null;
                    GetWeekEvents();
                    PN_Content.Refresh();
                }
                
                
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                DLG_Events dlg = new DLG_Events();
                dlg.Event = Events.TargetEvent;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dlg.delete)
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.DeleteEvent(dlg.Event);
                        Events.TargetEvent = null;
                        mouseIsDown = false;
                    }
                    else
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.UpdateEventRecord(dlg.Event);
                    }
                    GetWeekEvents();
                    PN_Content.Refresh();
                }
            
        }

        private void PN_Scroll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void T_Titre_Tick(object sender, EventArgs e)
        {
            this.Text = "Agenda compacte - " + DateTime.Now.ToString();
        }
        private void PN_Hours_MouseHover(object sender, EventArgs e)
        {
            UCS_Zoom.Visible = true;
            UCS_Zoom.Enabled = true;
            UCS_Zoom.BackColor = Color.LightGray;
            UCS_Zoom.BringToFront();
            Point Po = new Point((PN_Hours.Location.X + PN_Hours.Width / 2 - UCS_Zoom.Width / 2), ((this.PointToClient(Cursor.Position).Y - (UCS_Zoom.Height / 2)) > PN_Scroll.Location.Y) ? ((this.PointToClient(Cursor.Position).Y - (UCS_Zoom.Height / 2)) + UCS_Zoom.Height < PN_Scroll.Location.Y + PN_Scroll.Height) ? (this.PointToClient(Cursor.Position).Y - (UCS_Zoom.Height / 2)) : PN_Scroll.Location.Y + PN_Scroll.Height-UCS_Zoom.Height : PN_Scroll.Location.Y);          
            UCS_Zoom.Location = Po;
                      
        }
        private void UCS_Zoom_MouseLeave(object sender, EventArgs e)
        {
            UCS_Zoom.Visible = false;
            UCS_Zoom.Enabled = false;
            UCS_Zoom.SendToBack();
        }
        private void UCS_Zoom_ValueChanged(object sender, EventArgs e)
        {

            AdjustZoom();
        }
            

        private void Form_WeekView_Resize(object sender, EventArgs e)
        {
            AdjustZoom();
            //if(PN_Content.Height<PN_Scroll.Height)
            //{
            //    PN_Content.Height = PN_Scroll.Height;
            //    PN_Hours.Height = PN_Scroll.Height;
            //}
        }
        private void AdjustZoom()
        {
            PN_Content.Height = (int)(PN_Scroll.Height + (PN_Frame.Height * 12 - PN_Scroll.Height) * ((float)UCS_Zoom.Value / 100));
            PN_Hours.Height = (int)(PN_Scroll.Height + (PN_Frame.Height * 12 - PN_Scroll.Height) * ((float)UCS_Zoom.Value / 100));
            PN_Content.Refresh();
            PN_Hours.Refresh();
        }
    }
}
