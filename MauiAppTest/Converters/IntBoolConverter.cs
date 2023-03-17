using System.Globalization;

namespace MauiAppTest.Converters
{
    public class IntBoolConverter : IValueConverter
    {
        /// <summary>
        /// 소스에서 타겟으로 값이 넘어갈때 사용
        /// </summary>

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value != 0;
        }

        /// <summary>
        /// 대상에서 소스로
        /// OneWay는 구현할 필요 없으므로 null을 리턴하도록
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
