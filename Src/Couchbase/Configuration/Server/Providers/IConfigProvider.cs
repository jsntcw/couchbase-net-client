﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couchbase.IO;

namespace Couchbase.Configuration.Server.Providers
{
    internal interface IConfigProvider
    {
        IConfigInfo GetCached();

        IConfigInfo GetConfig();

        void Start();

        void RegisterListener(IConfigListener listener);

        void UnRegisterListener(IConfigListener listener);
    }

    internal interface IConfigListener
    {
        string Name { get; }

        void NotifyConfigChanged(IConfigInfo configInfo);

        void NotifyConfigChanged(IConfigInfo configInfo, IConnectionPool connectionPool);
    }
}
