using System.Drawing;

namespace WinDropShot
{
    public class CaptureController
    {
        readonly ScreenCapture _sc = new ScreenCapture();
        //test capture
        readonly Rectangle _rc = new Rectangle(10,10,10,10);
        
        public Image GrabRect5()
        {
            var img = _sc.CaptureMemRectangle(_rc);
            return img;
        }
    }
}