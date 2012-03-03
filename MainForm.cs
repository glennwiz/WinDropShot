using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinDropShot
{
    public partial class MainForm : Form
    {
        private ScreenCapture sc;
        private Rectangle rt = new Rectangle(10, 10, 100, 100);
        public MainForm()
        {
            MD5 md5Hasher = MD5.Create();
            LogController.DebugMessage("Object Mainform is created");
            CaptureController CC = new CaptureController();

            //check img agains a MD5 hash
            Image img = CC.GrabRect5();

           

            InitializeComponent();
        }
    }
}
