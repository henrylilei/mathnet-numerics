﻿// <copyright file="IFourierTransformProvider.cs" company="Math.NET">
// Math.NET Numerics, part of the Math.NET Project
// http://numerics.mathdotnet.com
// http://github.com/mathnet/mathnet-numerics
//
// Copyright (c) 2009-2016 Math.NET
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

namespace MathNet.Numerics.Providers.FourierTransform
{

#if !NOSYSNUMERICS
    using Complex = System.Numerics.Complex;
#endif

    public enum FourierTransformScaling : int
    {
        NoScaling = 0,
        SymmetricScaling = 1,
        AsymmetricScaling = 2
    }

    public interface IFourierTransformProvider
    {
        /// <summary>
        /// Initialize and verify that the provided is indeed available. If not, fall back to alternatives like the managed provider
        /// </summary>
        void InitializeVerify();

        void ForwardInplace(Complex[] complex, FourierTransformScaling scaling);
        void BackwardInplace(Complex[] complex, FourierTransformScaling scaling);

        Complex[] Forward(Complex[] complexTimeSpace, FourierTransformScaling scaling);
        Complex[] Backward(Complex[] complexFrequenceSpace, FourierTransformScaling scaling);
    }
}
