﻿using doberSoft.protoMetrics03.layer0;

namespace doberSoft.protoMetrics03.ScaleFunctions
{
    class LinearScale : IScale<int, decimal>
    {

        public LinearScale(int minIn, int maxIn, decimal minOut, decimal maxOut)
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

        public decimal Scale(IInput<int>[] inputs)
        {
            return (inputs[0].GetValue() - Parameters.MinIn) / (Parameters.MaxIn - Parameters.MinIn) * (Parameters.MaxOut - Parameters.MinOut) + Parameters.MinOut;
        }
    }
}