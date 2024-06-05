﻿namespace PRORR.Utility
{
    public struct FloatRange
    {
        public float Min { get; private set; }
        public float Max { get; private set; }

        public FloatRange(float min, float max)
        {
            Min = min;
            Max = max;
        }
    }
}
