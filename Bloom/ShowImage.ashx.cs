using System;
using System.Configuration;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace Bloom
{
    /// <summary>
    /// Summary description for ShowImage
    /// </summary>
    public class ShowImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            Int32 empno;
            if (context.Request.QueryString["ImgId"] != null)
                empno = Convert.ToInt32(context.Request.QueryString["ImgId"]);
            else
                throw new ArgumentException("No parameter specified");

           
            Stream strm = ShowEmpImage(empno);
            byte[] buffer = new byte[4096];
            int byteSeq = strm.Read(buffer,0, (int)strm.Length);

            while (byteSeq > 0)
            {
                context.Response.ContentType = "image/pjpeg";
                context.Response.OutputStream.Write(buffer, 0 , byteSeq);
                byteSeq = strm.Read(buffer, 0, 4096);
            }
           //context.Response.BinaryWrite(buffer);
            
        }

        public Stream ShowEmpImage(int empno)
        {
            Upload upl = new Upload();
            upl.Search(empno);
            object img = upl.Image;
            try
            {
                return new MemoryStream((byte[])img);
            }
            catch
            {
                return null;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}
