using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WinDropShot
{
    public class ScreenCapture
    {
        private Image CaptureImage(Rectangle LocationAndsizeRectangle)
        {
            if ((LocationAndsizeRectangle.Height <= 0) || LocationAndsizeRectangle.Width <= 0)
                return null; 

            var handle = User32.GetDesktopWindow();
            var screenLoc = User32.GetWindowDC(handle);
            var memDevice = Gdi32.CreateCompatibleDC(screenLoc);
            var bitmap = Gdi32.CreateCompatibleBitmap(screenLoc, LocationAndsizeRectangle.Width, LocationAndsizeRectangle.Height);
            var swap = Gdi32.SelectObject(memDevice, bitmap);

            Gdi32.BitBlt(memDevice, 0, 0, LocationAndsizeRectangle.Width, LocationAndsizeRectangle.Height,
                         screenLoc, LocationAndsizeRectangle.Left, LocationAndsizeRectangle.Top, Gdi32.Srccopy);
            Gdi32.SelectObject(memDevice, swap);
            Gdi32.DeleteDC(memDevice);
            User32.ReleaseDC(handle, screenLoc);

            var img = Image.FromHbitmap(bitmap);
            Gdi32.DeleteObject(bitmap);

            return img;
        }

        public void CaptureRectangleToFile(Rectangle rect, string filename, ImageFormat format)
        {
            var img = CaptureImage(rect);
            img.Save(filename, format);
        }
        
        public Image CaptureMemRectangle(Rectangle rect)
        {
            var img = CaptureImage(rect);
            return img;
        }
    }
}