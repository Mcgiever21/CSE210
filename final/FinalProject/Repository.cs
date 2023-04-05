namespace Vehicle_Security
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    
    public class Repository
    {
        protected string _FileFolderName = ""; // _FileFolderName = DateTime.Now.ToString("yyyy-MM-dd"); can be used here for each instance
        protected string _DateTime = "";
        //string _FileType = "";
        protected string _FileNameText;

    }

    public class VideoSave : Repository
    {
        private string _FileNameRecord;
        //mp4 file? dependant upon device software (to code later to match hardware)
        public void videoSave(string data)//change string data to video data type later.
        {
            _DateTime = System.DateTime.Now.ToString();
            _FileFolderName = DateTime.Now.ToString("yyyy-MM-dd"); // each time method is called
            _FileNameRecord = _DateTime;
            Directory.CreateDirectory($"C:\\Users\\matt-\\Documents\\CSE210\\final\\FinalProject\\{_FileFolderName}");
            string path = $"C:\\Users\\matt-\\Documents\\CSE210\\final\\FinalProject\\{_FileFolderName}\\{_FileNameRecord}";
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine(data);
            }
            
        }
    }

    public class AudioSave : Repository
    {
        private string _FileNameAudio;
        public void audioSave(string data)//change string data to audio data type later.
        {
            _DateTime = System.DateTime.Now.ToString();
            _FileFolderName = DateTime.Now.ToString("yyyy-MM-dd");
            _FileNameAudio = _FileFolderName;
            string path = $"C:\\Users\\matt-\\Documents\\CSE210\\final\\FinalProject\\{_FileFolderName}\\{_FileNameAudio}";
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine(data);
            }
        }
        //mp3 file? (to code later to match hardware)
    }

    public class LsSave : Repository
    {
        private string _FileName = "LSVIAGPS";
        
        public void lsSave(string LS_Data)
        {
            string path = $"C:\\Users\\matt-\\Documents\\CSE210\\final\\FinalProject\\{_FileFolderName}\\{_FileName}";
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine(LS_Data);
            }
            //text file
        }
    }
}