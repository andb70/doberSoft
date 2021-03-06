﻿using doberSoft.Sensors.Core;
using doberSoft.Sensors.Core.ScaleFunctions;

namespace doberSoft.Sensors.ScaleFunctions
{
    public class NumericScale : IScale<decimal, decimal>
    {

        public NumericScale(int minIn, int maxIn, decimal minOut, decimal maxOut)
        {
            Parameters = new ScaleParameters()
            {
                MinIn = minIn,
                MaxIn = maxIn,
                MinOut = minOut,
                MaxOut = maxOut
            };
        }

        public IScaleParameters Parameters { get; private set; }

        public decimal Scale(IInput<decimal>[] inputs)
        {
            return (inputs[0].GetValue() - Parameters.MinIn) / (Parameters.MaxIn - Parameters.MinIn) * (Parameters.MaxOut - Parameters.MinOut) + Parameters.MinOut;
        }
    }
}
