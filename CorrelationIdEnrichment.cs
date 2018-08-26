﻿using System;
using Serilog.Core;
using Serilog.Events;

namespace MhLabs.SerilogExtensions
{
    public class CorrelationIdEnrichment : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var value = LogValueResolver.Resolve(this);
            var property = new LogEventProperty("CorrelationId", new ScalarValue(value));
            logEvent.AddOrUpdateProperty(property);
        }
    }
}
