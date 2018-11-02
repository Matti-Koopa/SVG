using System.ComponentModel;
using System.Globalization;

namespace System.Drawing
{
    public class ColorConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, 
            object value)
        {
            if (value is string colorString)
                return ColorTranslator.FromHtml(colorString);

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, 
            object value, Type destinationType)
        {
            if (value is Color color && destinationType == typeof(string))
                return ColorTranslator.ToHtml(color);

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}