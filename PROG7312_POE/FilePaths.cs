using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    /// <summary>
    /// Class for filepath locations
    /// </summary>
    class FilePaths
    {
        //string to get current directory of application
        private readonly string currentDirectory = System.IO.Directory.GetCurrentDirectory();

        #region OBJECTS
        /// <summary>
        /// all objects were custom created in Blender 3.4
        /// </summary>
        //---------------------------------------------------------------------------------------//
        private readonly string ShelfPath = @"\3D Assests\shelve.obj";
        /// <summary>
        /// method to get empty shelf object
        /// </summary>
        /// <returns></returns>
        public string Shelf()
        {
            return currentDirectory + ShelfPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string FullShelfPath = @"\3D Assests\fullshelf.obj";
        /// <summary>
        /// method to get full shelf object
        /// </summary>
        /// <returns></returns>
        public string FullShelf()
        {
            return currentDirectory + FullShelfPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string BookPath = @"\3D Assests\book";
        /// <summary>
        /// method to get book object
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string Book(int num)
        {
            return currentDirectory + BookPath + num + ".obj";
        }
        //---------------------------------------------------------------------------------------//
        #endregion


        #region IMAGES
        /// <summary>
        /// all images were custom created using Sketchbook Pro
        /// </summary>
        //---------------------------------------------------------------------------------------//
        private readonly string OriginalCoverPath = @"\3D Assests\OGCoverBase";
        /// <summary>
        /// method to get specified original book cover image
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string OriginalCover(int num) 
        {
            return currentDirectory + OriginalCoverPath + num + ".png";
        }
        //---------------------------------------------------------------------------------------//
        private readonly string TextCoverPath = @"\3D Assests\CoverBase";
        /// <summary>
        /// method to get specified book cover image with text
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string TextCover(int num) 
        {
            return currentDirectory + TextCoverPath + num + ".png";
        }
        //---------------------------------------------------------------------------------------//
        private readonly string HeartFullPath = @"\Image Assests\Heart Full.png";
        /// <summary>
        /// method to get heart full image
        /// </summary>
        /// <returns></returns>
        public string HeartFullImage()
        {
            return currentDirectory + HeartFullPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string HeartBrokenPath = @"\Image Assests\Heart Broken.png";
        /// <summary>
        /// method to get heart broken image
        /// </summary>
        /// <returns></returns>
        public string HeartBrokenImage()
        {
            return currentDirectory + HeartBrokenPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string HeartGreyPath = @"\Image Assests\Heart Grey.png";
        /// <summary>
        /// method to get heart grey image
        /// </summary>
        /// <returns></returns>
        public string HeartGreyImage()
        {
            return currentDirectory + HeartGreyPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string OnePath = @"\Image Assests\One image.png";
        /// <summary>
        /// method to get one number image
        /// </summary>
        /// <returns></returns>
        public string OneImage()
        {
            return currentDirectory + OnePath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string TwoPath = @"\Image Assests\Two image.png";
        /// <summary>
        /// method to get two number image
        /// </summary>
        /// <returns></returns>
        public string TwoImage()
        {
            return currentDirectory + TwoPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string ThreePath = @"\Image Assests\Three image.png";
        /// <summary>
        /// method to get three number image
        /// </summary>
        /// <returns></returns>
        public string ThreeImage()
        {
            return currentDirectory + ThreePath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string GoIamgePath = @"\Image Assests\Go image.png";
        /// <summary>
        /// method to get go text image
        /// </summary>
        /// <returns></returns>
        public string GoImage()
        {
            return currentDirectory + GoIamgePath;
        }
        //---------------------------------------------------------------------------------------//
        #endregion


        #region AUDIO
        //---------------------------------------------------------------------------------------//
        private readonly string StartScreenPath = @"\Sound Assests\Start Screen.wav";
        /// <summary>
        /// method to get start screen background audio
        /// source :https://youtu.be/34-Im71tqpI?list=PLWJhE2gHTuXLq1HtinYhnDo-C8VW9vKvk
        /// </summary>
        /// <returns></returns>
        public string StartScreenAudio() 
        { 
            return currentDirectory + StartScreenPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string StartButtonPath = @"\Sound Assests\Start Button.wav";
        /// <summary>
        /// method to get start screen button audio
        /// source: https://www.youtube.com/watch?v=-D2iL1GYdx0
        /// </summary>
        /// <returns></returns>
        public string StartButtonAudio()
        {
            return currentDirectory + StartButtonPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string ReplaceBooksPath = @"\Sound Assests\Replacing Books.wav";
        /// <summary>
        /// method to get replacing books background audio
        /// source: https://youtu.be/kvi0nyk5fMc?list=PLWJhE2gHTuXLq1HtinYhnDo-C8VW9vKvk
        /// </summary>
        /// <returns></returns>
        public string ReplaceBooksAudio()
        {
            return currentDirectory + ReplaceBooksPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string BookPlacePath = @"\Sound Assests\Book Place.wav";
        /// <summary>
        /// method to get book placing effect audio
        /// source: https://www.youtube.com/watch?v=22N8Rf6rSVg
        /// </summary>
        /// <returns></returns>
        public string BookPlaceAudio()
        {
            return currentDirectory + BookPlacePath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string DefeatPath = @"\Sound Assests\Defeat.wav";
        /// <summary>
        /// method to get defeat background audio
        /// source: https://youtu.be/DwXUWL9Kqhs?list=PLWJhE2gHTuXLq1HtinYhnDo-C8VW9vKvk
        /// </summary>
        /// <returns></returns>
        public string DefeatAudio()
        {
            return currentDirectory + DefeatPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string VictoryPath = @"\Sound Assests\Victory.wav";
        /// <summary>
        /// method to get vicotry background audio
        /// source: https://youtu.be/usj0k7aXtq8?list=PLWJhE2gHTuXLq1HtinYhnDo-C8VW9vKvk
        /// </summary>
        /// <returns></returns>
        public string VictoryAudio()
        {
            return currentDirectory + VictoryPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string BeepPath = @"\Sound Assests\Beep.wav";
        /// <summary>
        /// method to get beep audio
        /// custom made with Chrome Music Lab
        /// </summary>
        /// <returns></returns>
        public string BeepAudio()
        {
            return currentDirectory + BeepPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string LifeLossPath = @"\Sound Assests\Life Loss.wav";
        /// <summary>
        /// method to get life loss audio
        /// custom made with Chrome Music Lab
        /// </summary>
        /// <returns></returns>
        public string LifeLossAudio()
        {
            return currentDirectory + LifeLossPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string ButtonPath = @"\Sound Assests\Button Press.wav";
        /// <summary>
        /// method to get button click audio
        /// source: https://www.youtube.com/watch?v=-D2iL1GYdx0
        /// </summary>
        /// <returns></returns>
        public string ButtonAudio()
        {
            return currentDirectory + ButtonPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string TickPath = @"\Sound Assests\Time Tick.wav";
        /// <summary>
        /// method to get time tick audio
        /// custom made with Chrome Music Lab
        /// </summary>
        /// <returns></returns>
        public string TimeTickAudio()
        {
            return currentDirectory + TickPath;
        }
        //---------------------------------------------------------------------------------------//
        private readonly string GoAudioPath = @"\Sound Assests\go audio.wav";
        /// <summary>
        /// method to get time tick audio
        /// custom made with Chrome Music Lab
        /// </summary>
        /// <returns></returns>
        public string GoAudio()
        {
            return currentDirectory + GoAudioPath;
        }
        //---------------------------------------------------------------------------------------//
        #endregion
    }
}
//-----------------------------------------------oO END OF FILE Oo----------------------------------------------------------------------//