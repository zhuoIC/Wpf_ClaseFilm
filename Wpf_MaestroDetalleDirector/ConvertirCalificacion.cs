using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using System.Windows.Data;
using System.Globalization;
namespace Wpf_MaestroDetalleDirector
{
    [ValueConversion(typeof(double), typeof(string))] // HAce las conversiones entre tipo
    class ConvertirCalificacion: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convierte la calificacion en letras
            string[] valores = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
            /*
            if (targetType == typeof(string) && value.GetType() == typeof(double))
            {
                return valores[(int)Math.Round((double)value)];
            }
            else
                return value;*/
            return valores[(int)Math.Round((double)value)];
        }

        public object ConvertBack(object value, Type targetType, object parameter,CultureInfo culture)
        {
            throw new NotImplementedException("Método ConvertBack no está codificado");
        }
    }
}
