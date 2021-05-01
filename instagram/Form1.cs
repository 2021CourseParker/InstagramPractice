using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CommentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(InstagramEntities db = new InstagramEntities())
            {
                var qury = from st in db.users
                           select st;

                List < users > allUsers = qury.ToList<users>();
                foreach (var v in allUsers)
                {
                    UserNameListBox.Items.Add(v.username);
                }

                UserNameListBox.SetSelected(0, true);


            }
        }

        private void SwitchUserButton_Click(object sender, EventArgs e)
        {
        //    using (InstagramEntities db = new InstagramEntities())
        //    {
              
        //        MessageBox.Show(UserNameListBox.SelectedItem.ToString());

        //  }
        }
    }
}
