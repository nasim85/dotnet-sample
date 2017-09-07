using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public int addnumber(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        public int dividenumber(int a, int b)
        {
            int c;
            c = a-b;
            return c;
        }

    }
}