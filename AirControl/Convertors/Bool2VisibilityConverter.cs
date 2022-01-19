﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace AirControl.Convertors
{
    public class Bool2VisibilityConverter : MarkupExtension, IValueConverter
    {
        public bool UseHidden { get; set; }


        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool flag)
            {
                return flag ? Visibility.Visible : UseHidden ? Visibility.Hidden : Visibility.Collapsed;
            }
            else
            {
                return UseHidden ? Visibility.Hidden : Visibility.Collapsed;
            }
        }

        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return default;
        }
    }
}