﻿using PlayerConceptDesign.Model;
using System.IO;
using System.Windows.Media.Imaging;
using PlayerConceptDesign.Settings;

namespace PlayerConceptDesign.ViewModel
{
    public class Cover
    {
       
        public class SizeCover : INPropertyChanged
        {
            private double Height_;
            public double Height
            {
                get { return Height_; }
                set { if (value != Height_) Height_ = value; OnPropertyChanged(nameof(Height)); }
            }
            private double Width_;
            public double Width
            {
                get { return Width_; }
                set { if (value != Width_) Width_ = value; OnPropertyChanged(nameof(Width)); }
            }
        }

        public static SizeCover[] sizeCover { get; set; }

        static Cover()
        {
            Init();
        }

        public static void Init()
        {
            sizeCover = new SizeCover[SettingsManager.AppSettings.Files.Count];
            for (int i = 0; i < SettingsManager.AppSettings.Files.Count; i++)
                sizeCover[i] = new SizeCover
                {
                    Width = SettingsManager.AppSettings.SizeCover,
                    Height = SettingsManager.AppSettings.SizeCover * 1.11
                };
        }

        public static BitmapImage GetCoverFile(TagLib.File file)
        {
            TagLib.IPicture ipicture = file.Tag.Pictures[0];
            MemoryStream memorystream = new MemoryStream(ipicture.Data.Data);
            memorystream.Seek(0, SeekOrigin.Begin);
            BitmapImage BitmapImage = new BitmapImage();
            BitmapImage.BeginInit();
            BitmapImage.StreamSource = memorystream;
            BitmapImage.EndInit();
            return BitmapImage;
        }
    }
}
