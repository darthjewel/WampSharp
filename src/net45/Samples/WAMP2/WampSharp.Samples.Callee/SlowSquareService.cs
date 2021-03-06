﻿using System.Threading;
using WampSharp.V2.Rpc;

namespace WampSharp.Samples.Callee
{
    [Sample("slowsquare")]
    public class SlowSquareService
    {
        [WampProcedure("com.math.slowsquare")]
        public int SlowSquare(int x)
        {
            Thread.Sleep(1000);
            return x * x;
        }

        [WampProcedure("com.math.square")]
        public int Square(int x)
        {
            return x * x;
        }
    }
}