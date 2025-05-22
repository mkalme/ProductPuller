using System.Drawing;

namespace ProductPullerAutomatic {
    public class ImageMatcher {
        public Point TopLeft { get; set; } = new Point(280, 100);
        public Point BottomRight { get; set; } = new Point(760, 900);
        public LockedBitmap ImageToFind { get; set; }

        public ImageMatcher() {
            ImageToFind = new LockedBitmap(new Bitmap("ImageToFind\\ImageToFind.png"));
        }

        public Point[] FindMatches(Bitmap screenshot) {
            TopLeft = new Point(280, 100);
            BottomRight = new Point(760, 900);

            LockedBitmap locked = new LockedBitmap(screenshot);
            List<Point> pointsFound = new List<Point>();

            bool inImage = false;
            float nonSimilarity = 0;
            Point pointInImage = new Point();

            for (int y = TopLeft.Y; y < BottomRight.Y; y++) {
                for (int x = TopLeft.X; x < BottomRight.X; x++) {
                    Point inImagePoint = new Point();
                    if (inImage) {
                        inImagePoint = new Point(x - pointInImage.X, y - pointInImage.Y);
                    }

                    if (PixelTaken(pointsFound, x, y)) {
                        if (inImage) { 
                            inImage = false;
                            nonSimilarity = 0;
                        }

                        continue;
                    }

                    float similarity = CompareSimilarity(locked.GetPixel(x, y), ImageToFind.GetPixel(inImagePoint.X, inImagePoint.Y));
                    nonSimilarity += 1 - similarity;

                    if (nonSimilarity <= 10) {
                        if (!inImage) {
                            if (BottomRight.X - x < ImageToFind.Width || BottomRight.Y - y < ImageToFind.Height) {
                                continue;
                            }

                            inImage = true;
                            pointInImage = new Point(x, y);
                        }

                        if (x == pointInImage.X + ImageToFind.Width - 1) {
                            if (y == pointInImage.Y + ImageToFind.Height - 1) {
                                pointsFound.Add(pointInImage);
                                inImage = false;
                                nonSimilarity = 0;

                                x = pointInImage.X + ImageToFind.Width;
                                y = pointInImage.Y;
                            } else {
                                x = pointInImage.X - 1;
                                y++;
                            }
                        }
                    } else {
                        if (inImage) {
                            x = pointInImage.X;
                            y = pointInImage.Y;
                        }

                        inImage = false;
                        nonSimilarity = 0;
                    }
                }
            }

            return pointsFound.ToArray();
        }

        private bool PixelTaken(List<Point> pointsFound, int x, int y) {
            foreach (Point p in pointsFound) {
                if (x >= p.X && x < p.X + ImageToFind.Width && y >= p.Y && y < p.Y + ImageToFind.Height) return true;
            }

            return false;
        }

        private static float CompareSimilarity(Color one, Color second) {
            return 1 - Math.Abs(one.GetBrightness() - second.GetBrightness());
        }
    }
}