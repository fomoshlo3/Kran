namespace UKran
{
    public partial class MainForm : Form
    {
        
        public int YAxisBorder
        {
            private get;
            set;
        }   

        public int XAxisBorder
        {
            private get;
            set;
        }

        public MainForm()
        {
            InitializeComponent();
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            YAxisBorder = Height - 60;
            XAxisBorder = Width - 140;
        }

        private bool _Clicked = false;

        private void CmdStart_Click(object sender, EventArgs e)
        {
            if (!_Clicked)
            {
                TimKran.Enabled = true;
                CmdStart.Text = "Pause";
                _Clicked = true;
            }
            else if(_Clicked/* || CheckedChanged of the Radiobuttons wäre vielleicht mit einer Groupbox verwirklichbar */)
            {
                TimKran.Enabled = false;
                CmdStart.Text = "Start";
                _Clicked = false;
            }
        }

        private void TimKran_Tick(object sender, EventArgs e)
        {
            if (OptHakenAus.Checked)
            {
                if (PnHaken.Height < (YAxisBorder - PnHaken.Location.Y))
                {
                    PnHaken.Size = new Size(PnHaken.Width, PnHaken.Height + 20);
                }
            }
            else if (OptHakenEin.Checked)
            {
                if (PnHaken.Height > 0)
                {
                    PnHaken.Size = new Size(PnHaken.Width, PnHaken.Height - 20);
                }
            }
            else if (OptAuslegerAus.Checked)
            {
                if (PnHaken.Location.X - 20 > 0)
                {
                    PnAusleger.Size = new Size(PnAusleger.Width + 20, PnAusleger.Height);
                    PnAusleger.Location = new Point(PnAusleger.Location.X - 20, PnAusleger.Location.Y);
                    PnHaken.Location = PnAusleger.Location;
                }
            }
            else if (OptAuslegerEin.Checked)
            {
                if (PnAusleger.Width > 20)
                {
                    PnAusleger.Size = new Size(PnAusleger.Width - 20, PnAusleger.Height);
                    PnAusleger.Location = new Point(PnAusleger.Location.X + 20, PnAusleger.Location.Y);
                    PnHaken.Location = PnAusleger.Location;
                }
            }
            else if (OptKranAus.Checked)
            {
                if (PnKran.Location.Y - 20 > 0)
                {
                    PnKran.Size = new Size(PnKran.Size.Width, PnKran.Size.Height + 20);
                    PnKran.Location = new Point(PnKran.Location.X, PnKran.Location.Y - 20);
                    PnAusleger.Location = new Point(PnAusleger.Location.X, PnKran.Location.Y);
                    PnHaken.Location = PnAusleger.Location;
                }
            }
            else if (OptKranEin.Checked)
            {
                if (PnAusleger.Location.Y + PnHaken.Height + 20 < PnKranFuss.Location.Y)
                {
                    PnKran.Size = new Size(PnKran.Size.Width, PnKran.Size.Height - 20);
                    PnKran.Location = new Point(PnKran.Location.X, PnKran.Location.Y + 20);
                    PnAusleger.Location = new Point(PnAusleger.Location.X, PnKran.Location.Y);
                    PnHaken.Location = PnAusleger.Location;
                }
            }
            else if (OptKranLinks.Checked)
            {
                if (PnAusleger.Location.X - 20 > 0 && PnKranFuss.Location.X - 20 > 0)
                {
                    PnKranFuss.Location = new Point(PnKranFuss.Location.X - 20, PnKranFuss.Location.Y);
                    PnKran.Location = new Point(PnKran.Location.X - 20, PnKran.Location.Y);
                    PnHaken.Location = new Point(PnHaken.Location.X - 20, PnHaken.Location.Y);
                    PnAusleger.Location = PnHaken.Location;
                }
            }
            else
            {
                if (PnKranFuss.Location.X + PnKranFuss.Width < XAxisBorder)
                {
                    PnKranFuss.Location = new Point(PnKranFuss.Location.X + 20, PnKranFuss.Location.Y);
                    PnKran.Location = new Point(PnKran.Location.X + 20, PnKran.Location.Y);
                    PnHaken.Location = new Point(PnHaken.Location.X + 20, PnHaken.Location.Y);
                    PnAusleger.Location = PnHaken.Location;
                }
            }
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void CmdHakenAus_Click(object sender, EventArgs e)
        //{    
        //    if(PnHaken.Height < (YAxisBorder - PnHaken.Location.Y)) 
        //    {
        //        PnHaken.Size = new Size(PnHaken.Width, PnHaken.Height + 20);
        //    }
        //}

        //private void CmdHakenEin_Click(object sender, EventArgs e)
        //{
        //    if(PnHaken.Height > 0)
        //    {
        //        PnHaken.Size = new Size(PnHaken.Width, PnHaken.Height - 20);
        //    }
        //}

        //private void CmdAuslegerAus_Click(object sender, EventArgs e)
        //{
        //    if(PnHaken.Location.X - 20 > 0)
        //    {
        //        PnAusleger.Size = new Size(PnAusleger.Width + 20, PnAusleger.Height);
        //        PnAusleger.Location = new Point(PnAusleger.Location.X - 20, PnAusleger.Location.Y);
        //        PnHaken.Location = PnAusleger.Location;
        //    }
        //}

        //private void CmdAuslegerEin_Click(object sender, EventArgs e)
        //{
        //    if (PnAusleger.Width > 20)
        //    {
        //        PnAusleger.Size = new Size(PnAusleger.Width - 20, PnAusleger.Height);
        //        PnAusleger.Location = new Point(PnAusleger.Location.X + 20, PnAusleger.Location.Y);
        //        PnHaken.Location = PnAusleger.Location;
        //    }
            
        //}

        //private void CmdKranRechts_Click(object sender, EventArgs e)
        //{
        //    if (PnKranFuss.Location.X + PnKranFuss.Width < XAxisBorder)
        //    {
        //        PnKranFuss.Location = new Point(PnKranFuss.Location.X + 20, PnKranFuss.Location.Y);
        //        PnKran.Location = new Point(PnKran.Location.X + 20, PnKran.Location.Y);
        //        PnHaken.Location = new Point(PnHaken.Location.X + 20, PnHaken.Location.Y);
        //        PnAusleger.Location = PnHaken.Location;
        //    }
            
        //}

        //private void CmdKranLinks_Click(object sender, EventArgs e)
        //{
        //    if (PnAusleger.Location.X - 20 > 0 && PnKranFuss.Location.X -20 > 0)
        //    {
        //        PnKranFuss.Location = new Point(PnKranFuss.Location.X - 20, PnKranFuss.Location.Y);
        //        PnKran.Location = new Point(PnKran.Location.X - 20, PnKran.Location.Y);
        //        PnHaken.Location = new Point(PnHaken.Location.X - 20, PnHaken.Location.Y);
        //        PnAusleger.Location = PnHaken.Location;
        //    }
        //}

        //private void CmdKranAus_Click(object sender, EventArgs e)
        //{
        //    if (PnKran.Location.Y -20 > 0)
        //    {
        //        PnKran.Size = new Size(PnKran.Size.Width, PnKran.Size.Height + 20);
        //        PnKran.Location = new Point(PnKran.Location.X, PnKran.Location.Y - 20);
        //        PnAusleger.Location = new Point(PnAusleger.Location.X, PnKran.Location.Y);
        //        PnHaken.Location = PnAusleger.Location;
        //    }
        //}

        //private void CmdKranEin_Click(object sender, EventArgs e)
        //{
        //    if (PnAusleger.Location.Y + PnHaken.Height + 20 < PnKranFuss.Location.Y)
        //    {
        //        PnKran.Size = new Size(PnKran.Size.Width, PnKran.Size.Height - 20);
        //        PnKran.Location = new Point(PnKran.Location.X, PnKran.Location.Y + 20);
        //        PnAusleger.Location = new Point(PnAusleger.Location.X, PnKran.Location.Y);
        //        PnHaken.Location = PnAusleger.Location;
        //    }  
        //}

       
    }
}