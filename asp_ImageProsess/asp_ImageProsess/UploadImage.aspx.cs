using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_ImageProsess
{
    public partial class UploadImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                if (fileUpload.PostedFile.ContentType.Contains("image"))
                {
                    string guid = Guid.NewGuid().ToString();//ne işe yarar bak.
                    string path = " ~/Pictures/" + guid + "." + fileUpload.PostedFile.ContentType.Split('/')[1];
                    fileUpload.SaveAs(Server.MapPath(path));

                    MemoryStream stream = new MemoryStream();
                    System.Drawing.Image image = System.Drawing.Image.FromFile(Server.MapPath(path));
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byteArray = stream.ToArray();

                    İmageProsessEntities db = new İmageProsessEntities();
                    Images saveImage = new Images
                    {
                        ImageFile = byteArray,
                        ImageFilePath = path
                    };
                    db.Images.Add(saveImage);
                    db.SaveChanges();
                }
            }
        }
    }
}