﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Tools.Response response = new Tools.Response();
        div.InnerHtml= "你好="+response.getEncode("你好");
        
    }
}