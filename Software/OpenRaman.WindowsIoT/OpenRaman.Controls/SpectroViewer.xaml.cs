using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace OpenRaman.Controls
{
    public sealed partial class SpectroViewer : UserControl
    {
        private int _StartWaveLenght = 400;
        private int _EndWaveLenght = 1000;
        private List<double> _Values;
        public int StartWaveLenght { get => _StartWaveLenght; set => _StartWaveLenght = value; }
        public int EndWaveLenght { get => _EndWaveLenght; set => _EndWaveLenght = value; }
        private double _Peak;
        public List<double> Points
        {
            get => _Values;
            set
            {
                _Values = value;
            }
        }

        public double Peak { get => _Peak; set => _Peak = value; }

        public void AddRange(double[] Points)
        {
            Clear();
            for(int i = 0; i < Points.Length; i++)
            {
                if (_Peak > Points[i])
                    _Peak = Points[i];
                _Values.Add(Points[i]);
            }
            Plot();
        }
        public SpectroViewer()
        {
            this.InitializeComponent();
            _Values = new List<double>();
        }
        
        public void Plot()
        {
            SpectroLine.Points.Clear();
            foreach(var p in _Values)
            {
                SpectroLine.Points.Add(new Point(ScaleX(SpectroLine.Points.Count),ScaleY(p)));
            }
        }
        public void Clear()
        {
            SpectroLine.Points.Clear();
            _Values.Clear();
        }
        private double ScaleX(double Value)
        {
            return Value * (CropArea.Width / _Values.Count);
        }
        private double ScaleY(double Value)
        {
            return Value * (CropArea.Height / _Peak);
        }
        private void OnResize(object sender, SizeChangedEventArgs e)
        {
            Plot();
        }
    }
}
