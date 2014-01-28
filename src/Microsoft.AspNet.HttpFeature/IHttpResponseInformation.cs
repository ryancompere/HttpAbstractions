﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.AspNet.HttpFeature
{
    public interface IHttpResponseInformation
    {
        int StatusCode { get; set; }
        string ReasonPhrase { get; set; }
        IDictionary<string, string[]> Headers { get; set; }
        Stream Body { get; set; }
        void OnSendingHeaders(Action<object> callback, object state);
    }
}