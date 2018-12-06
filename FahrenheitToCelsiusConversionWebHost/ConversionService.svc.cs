using FahrenheitToCelsiusConversionWebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FahrenheitToCelsiusConversionWebHost

{
    public class ConversionService : IConversionService

    {

        public double FahrenheitToCelsius(double farenheitDegrees)

        {
            double r;
            return r=5.0 / 9 * (farenheitDegrees - 32);

        }

        public double CelsiusToFahrenheit(double celsiusDegrees)

        {

            return 9.0 / 5 * celsiusDegrees + 32;

        }

    }

}
