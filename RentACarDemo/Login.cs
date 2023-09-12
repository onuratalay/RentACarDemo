using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private RentACarContext context = new RentACarContext();
        //public bool LoginUser(string username, string password)
        //{
        //    var query = from user in context.
        //        where user.Username == username && user.Password == password
        //        select user;

        //    if (query.Any())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
