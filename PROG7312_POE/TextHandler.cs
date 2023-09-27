using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROG7312_POE
{
    /// <summary>
    /// class for handling the addition of text to image files
    /// </summary>
    public class TextHandler
    {
        #region Declarations
        //---------------------------------------------------------------------------------------//
        //class for getting filepaths
        FilePaths filePaths = new FilePaths();

        // Create a single instance of Random
        private static readonly Random rand = new Random();
        //---------------------------------------------------------------------------------------//
        #endregion

        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// method to add call numbers to the book cover image files
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string AddTextToImage(int index)
        {
            string callNumber = "";
            try
            { 
                //get original book cover image
                Image pngImage = Image.FromFile(filePaths.OriginalCover(index));

                //Initialize Bitmap with same size as the image
                Bitmap bitmap = new Bitmap(pngImage.Width, pngImage.Height, pngImage.PixelFormat);

                //Create a new graphic with the bitmpa
                Graphics graphic = Graphics.FromImage(bitmap);

                //add the image to the graphic
                graphic.DrawImage(pngImage, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

                //generate call number
                double number = GenerateNumbers();
                string letter = GenerateLetters();
                string text = number.ToString("000.000") + "\n  " + letter;

                //adjust font size based on DPI (source ChatGPT).
                float dpiY = graphic.DpiY;
                float fontSize = 16 * 96f / dpiY;

                //create text and add to graphic
                Font font = new Font("Arial", fontSize);
                PointF point = new PointF(120, 285f);
                SizeF textSize = graphic.MeasureString(text, font);
                graphic.TranslateTransform(point.X, point.Y);
                graphic.RotateTransform(-90);
                graphic.ScaleTransform(-1, 1);
                graphic.FillRectangle(Brushes.White, new RectangleF(new PointF(0, 0), textSize));
                graphic.DrawString(text, font, Brushes.Black, new PointF(0, 0));

                //Save the file
                bitmap.Save(filePaths.TextCover(index));
            
                //dispose of the bitmap and image
                bitmap.Dispose();
                pngImage.Dispose();

                //return generated call number
                callNumber = number.ToString("000.000") + " " + letter;
                return callNumber;
            }
            catch (Exception ex) 
            {
                ErrorWindow errorWindow = new ErrorWindow(ex.Message);
                errorWindow.ShowDialog();
            }
            return callNumber;
        }
        //---------------------------------------------------------------------------------------//


        #region Geration
        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// method for generating random numbers in 000.000 format
        /// </summary>
        /// <returns></returns>
        private double GenerateNumbers()
        {
            double randomDouble = rand.NextDouble() * (999.999);
            randomDouble = Math.Round(randomDouble, 3);
            return randomDouble;
        }
        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// method for generating 3 random letters
        /// </summary>
        /// <returns></returns>
        private string GenerateLetters()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string randomString = "";
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(alphabet.Length);
                randomString += alphabet[index];
            }
            return randomString;
        }
        //---------------------------------------------------------------------------------------//
        #endregion
    }
}
//-----------------------------------------------oO END OF FILE Oo----------------------------------------------------------------------//