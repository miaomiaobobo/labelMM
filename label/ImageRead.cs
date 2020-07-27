using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace label
{
    class ImageRead
    {
        public static void read(string img_name, PictureBox pictureBox1)
        {
            FileStream fileStream = new FileStream(img_name, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fileStream);
            fileStream.Close();
            fileStream.Dispose();
        }

        public static Image justread(string img_name)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(img_name);
            System.Drawing.Image bmp = new System.Drawing.Bitmap(img);
            img.Dispose();
            return bmp;
        }


    }
}
