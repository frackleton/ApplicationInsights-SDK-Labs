﻿using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Wcf.Implementation;
using System;
using System.ServiceModel;

namespace Microsoft.ApplicationInsights.Wcf
{
    /// <summary>
    /// Provides extensions methods for accessing Application Insights Objects
    /// </summary>
    public static class OperationContextExtensions
    {
        /// <summary>
        /// Obtains a reference to the request telemetry object generated by
        /// the Application Insights WCF SDK.
        /// </summary>
        /// <param name="context">The WCF OperationContext instance
        /// associated with the current request</param>
        /// <returns>The request object or null</returns>
        public static RequestTelemetry GetRequestTelemetry(this OperationContext context)
        {
            if ( context == null )
                return null;
            var icontext = WcfOperationContext.FindContext(context);

            return icontext != null ? icontext.Request : null;
        }
    }
}
