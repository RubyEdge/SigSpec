﻿using NJsonSchema;

namespace SigSpec.Core
{
    public class SigSpecParameter : JsonSchema
    {
        public bool Optional { get; set; }

        public bool IsValueType { get; set; }
    }
}
