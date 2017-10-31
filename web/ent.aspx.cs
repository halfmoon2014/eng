using System;
using System.Text;
using System.Net;
using System.IO;
public partial class ent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //由80端口转过来接收的第一个页面
        //需要判断是否是android，如果是还需要再请求
        //根据URL中是否存在/myapp/来判断
        if (Request.Url.AbsoluteUri.IndexOf("/myapp/") >= 0)          
        {
            string url = Request.Url.AbsoluteUri.Replace(Request.Url.Authority + Request.CurrentExecutionFilePath, "192.168.1.204:8081");
            //string url = Request.Url.AbsoluteUri.Replace(Request.Url.Authority + Request.CurrentExecutionFilePath, "192.168.1.100:8081");
            //Response.Write(url);
            //Response.End();
            //url = "http://192.168.1.204:8081/myapp/slogin?username=xz&password=1";
            //url = @"http://192.168.1.100:8081/dynamicWeb/slogin?username=xz&password=123";
            HttpWebResponse response = MyTy.HttpWebResponseUtility.CreatePostHttpResponse(url, Request.InputStream, null, Request.UserAgent, Request.ContentEncoding, null, Request.ContentType);
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            Response.Clear();
            Response.Write(reader.ReadToEnd());
            Response.Flush();
            Response.End();
        }
        else
        {
            Response.Write(Request.Url.AbsoluteUri);
            Response.End();
        }
       
        
    }
}