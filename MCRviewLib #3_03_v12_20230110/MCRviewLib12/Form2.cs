using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCRviewLib12
{
    public partial class Form2 : Form
    {
        public View12 tpfrm ;
        private int X;
        private int Y;
        private int butID;
        public int getX()
        {
            return X;
        }
        public void setX(int paramx)
        {
            X = paramx;
        }
        public int getY()
        {
            return Y;
        }
        public void setY(int paramy)
        {
            Y = paramy;
        }
        public int getbutID()
        {
            return butID;
        }
        public void setbutID(int butID)
        {
            this.butID = butID;
        }
        public Form2(View12 frm)
        {
            tpfrm = frm;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.Location = new System.Drawing.Point(100, 100); this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(X, Y);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (this.butID == 1)
            {
                View12.dateselect = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd hh:mm:ss");
                tpfrm.textBox16.Text = View12.dateselect;
            }
            else if (this.butID == 2)
            {
                View12.searchdate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                View12.searchtime = monthCalendar1.SelectionStart.ToString("hh:mm:ss");
                tpfrm.textBox21.Text = View12.searchdate;
                tpfrm.textBox22.Text = View12.searchtime;
            }
            //MessageBox.Show(monthCalendar1.SelectionStart.ToString("yyyy-MM-dd  hh:mm:ss"));
            
            this.Close();
        }
    }
}
