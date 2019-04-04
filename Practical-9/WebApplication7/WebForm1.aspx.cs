using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        serviceCalc.WebService1 calc = new serviceCalc.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.Add(Convert.ToInt16(txtA.Text),Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {

            lblResult.Text = calc.Sub(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {

            lblResult.Text = calc.Mul(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {

            lblResult.Text = calc.Div(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }
    }
}