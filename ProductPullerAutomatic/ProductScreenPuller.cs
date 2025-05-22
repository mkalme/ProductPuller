using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ProductPuller;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ProductPullerAutomatic {
    public class ProductScreenPuller {
        public ImageMatcher ImageMatcher { get; set; } = new ImageMatcher();
        public KeyboardOperations KeyboardOperations { get; set; } = new KeyboardOperations();
        public PageParser PageParser { get; set; } = new PageParser();

        public List<Product> PullProducts() {
            List<Product> products = new List<Product>();

            BringToFront(Process.GetProcessesByName("chrome")[0]);

            KeyboardOperations.Send(KeyboardOperations.ScanCodeShort.CONTROL);
            for (int j = 0; j < 6; j++) {
                KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.SUBTRACT);
            }
            KeyboardOperations.SendRelease(KeyboardOperations.ScanCodeShort.CONTROL);

            Thread.Sleep(1000);

            Point[] matches = ImageMatcher.FindMatches(TakeScreenshot());

            foreach (Point point in matches) {
                Point newP = new Point(point.X + 25, point.Y - 75);

                MouseOperations.SetCursorPosition(new MouseOperations.MousePoint(newP.X, newP.Y));

                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);

                Thread.Sleep(50);
            }

            Thread.Sleep(1000);

            for (int i = 0; i < matches.Length; i++) {
                KeyboardOperations.Send(KeyboardOperations.ScanCodeShort.CONTROL);
                if (i == 0) {
                    KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.TAB);
                } else {
                    KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.KEY_W);
                }

                Thread.Sleep(i == 0 ? 2000 : 200);

                KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.KEY_A);
                Thread.Sleep(50);
                
                KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.KEY_C);
                Thread.Sleep(50);

                (string[], float[]) parsed = PageParser.Parse(Clipboard.GetText());

                Product product = new Product() { 
                    Type = "StoreBought",
                    IsGlutenFree = true,
                };
                product.Name = parsed.Item1[0];
                product.Price = decimal.Parse(parsed.Item1[1].Replace(".", ","));
                product.WeightInGrams = int.Parse(parsed.Item1[2]);

                product.SetNutritionFromArray(parsed.Item2);

                KeyboardOperations.SendRelease(KeyboardOperations.ScanCodeShort.CONTROL);
                KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.F6);

                CopyToClipboard();
                Thread.Sleep(100);

                product.Link = Clipboard.GetText();

                products.Add(product);

                if (i == matches.Length - 1) {
                    KeyboardOperations.Send(KeyboardOperations.ScanCodeShort.CONTROL);
                    KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.KEY_W);
                    KeyboardOperations.SendRelease(KeyboardOperations.ScanCodeShort.CONTROL);
                }
            }

            KeyboardOperations.Send(KeyboardOperations.ScanCodeShort.CONTROL);
            for (int j = 0; j < 6; j++) {
                KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.ADD);
            }
            KeyboardOperations.SendRelease(KeyboardOperations.ScanCodeShort.CONTROL);

            return products;
        }

        private void CopyToClipboard() {
            KeyboardOperations.Send(KeyboardOperations.ScanCodeShort.CONTROL);
            KeyboardOperations.SendOnce(KeyboardOperations.ScanCodeShort.KEY_C);
            KeyboardOperations.SendRelease(KeyboardOperations.ScanCodeShort.CONTROL);
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private void BringToFront(Process pTemp) {
            SetForegroundWindow(pTemp.MainWindowHandle);
        }

        private static Bitmap TakeScreenshot() {
            try {
                Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                return captureBitmap;
            } catch (Exception ex) {
                MessageBox.Show("Error! " + ex.Message);
                return null;
            }
        }
    }
}
