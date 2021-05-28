using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class UserControlHome : UserControl
    {
        
        public UserControlHome()
        {
            InitializeComponent();
            imgPaths = new List<string>();

            string folderPath = GetHomeImagePath();
            GetHomeImagePath();
            foreach (string imgPath in Directory.GetFiles(folderPath))
            {
                imgPaths.Add(imgPath);
            }
        }
        public string GetHomeImagePath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            string imgPath = currentPath + @"\HomeImages";
            return imgPath;
        }
        public List<string> imgPaths;

        int index = 0;
        private void timerHome_Tick(object sender, EventArgs e)
        {

            Image img = null;
            if (index < imgPaths.Count) img = Image.FromFile(imgPaths[index]);
            pictureBoxHome.Image = img;

            index++;
            if (index == imgPaths.Count) index = 0;
        }

       //tét
    }
}
