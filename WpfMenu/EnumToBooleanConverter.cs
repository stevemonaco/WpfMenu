﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfMenu;

public class EnumToBooleanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string parameterString = parameter as string;
        if (parameterString is null)
            return DependencyProperty.UnsetValue;

        if (Enum.IsDefined(value.GetType(), value) == false)
            return DependencyProperty.UnsetValue;

        object parameterValue = Enum.Parse(value.GetType(), parameterString);

        return parameterValue.Equals(value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string parameterString = parameter as string;
        if (parameterString is null)
            return DependencyProperty.UnsetValue;

        return Enum.Parse(targetType, parameterString);
    }
}
