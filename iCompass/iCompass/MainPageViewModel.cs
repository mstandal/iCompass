using System;
using System.Numerics;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace iCompass
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private SensorSpeed speed = SensorSpeed.UI;
        private double compassHeadingValue;
        private string headingCardinal;
        private int headingGraphicRotation;
        private const int headingGraphicRotationOffset = 45;

        public event PropertyChangedEventHandler PropertyChanged;

        public string HeadingAsText
        {
            get { return compassHeadingValue.ToString() + "°" + " " + headingCardinal; }
            set { }
        }

        public int HeadingGraphicRotation
        {
            get { return headingGraphicRotation; }
            set { }
        }

        public bool IsMonitoring
        {
            get { return Compass.IsMonitoring; }
            set { ToggleCompass(null); }
        }


        public MainPageViewModel()
        {
            Compass.ReadingChanged += Compass_ReadingChanged;
            headingCardinal = "N";
            headingGraphicRotation = -headingGraphicRotationOffset;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            CompassData data = e.Reading;
            UpdateBindingMemberValues(data.HeadingMagneticNorth);
        }

        private void UpdateBindingMemberValues(double Heading)
        {
            headingCardinal = CompassRoseCardinalCalculator.GetCardinalFromHeading(Math.Round(Heading,1));
            compassHeadingValue = Math.Round(Heading);
            headingGraphicRotation = (int) NorthGraphicRotationCalculator.GetRotationFromHeading(compassHeadingValue) - headingGraphicRotationOffset;

            OnPropertyChanged("HeadingGraphicRotation");            
            OnPropertyChanged("HeadingAsText");            
        }

        public void ToggleCompass(string obj)
        {
            try
            {
                if (Compass.IsMonitoring)
                    Compass.Stop();
                else
                    Compass.Start(speed);                    
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

    }
}