using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Quiz2 {
    public partial class Reg : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            lb_Msg.Text = tb_CTEL.Text;
        }
    }
}