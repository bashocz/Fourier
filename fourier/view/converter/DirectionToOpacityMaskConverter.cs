﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Globalization;
using Fourier.Domain;

namespace Fourier
{
    public class DirectionToOpacityMaskConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isFromCenter = (bool)value;
            int stopIndex = int.Parse(parameter.ToString());
            if (isFromCenter && (stopIndex == 0))
                return Color.FromArgb(0, 0, 0, 0);
            if (!isFromCenter && (stopIndex == 0))
                return Color.FromArgb(0, 255, 255, 255);
            if (isFromCenter)
                return Colors.White;
            return Colors.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
