﻿using System;
using System.Collections.Generic;

namespace WaterWatchPreProcessor.Dtos
{
    public class SavedState
    {
        public Dictionary<string, DateTime> LastSeenBySensorSerial { get; set; } =
            new Dictionary<string, DateTime>(StringComparer.InvariantCultureIgnoreCase);
    }
}
