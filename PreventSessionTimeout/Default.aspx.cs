using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PreventSessionTimeout
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.AddKeepAlive();
        }

        private void AddKeepAlive()
        {
            int milliSecondsTimeout = (this.Session.Timeout * 60) - 30;

            string script = @"
<script type='text/javascript'>
//Number of Reconnects
var count = 0;
//Maxinum reconnects setting
var max = 5;

function Reconnect(){

count++;

if(count < max)
{
    window.status = 'Link to Server Refreshed ' + count.toString() + ' time(s)';
    
    var img = new Image(1,1);

    img.src= '/Reconnect.aspx';
}

}
window.setInterval('Reconnect()', " +
                                     milliSecondsTimeout.ToString() + @"); //set to length required

</script>
";

            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Refresh", script, false);
        }

    }
}