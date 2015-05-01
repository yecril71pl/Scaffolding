// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.Versioning;
using Microsoft.Framework.Runtime;

namespace Microsoft.Framework.CodeGeneration.Core.FunctionalTest
{
    // Represents an application environment that overrides the base path of the original
    // application environment in order to make it point to the test application folder.
    public class TestApplicationEnvironment : IApplicationEnvironment
    {
        private readonly IApplicationEnvironment _originalAppEnvironment;
        private readonly string _applicationBasePath;
        private readonly string _appName;

        public TestApplicationEnvironment(IApplicationEnvironment originalAppEnvironment,
            string appBasePath, string appName)
        {
            _originalAppEnvironment = originalAppEnvironment;
            _applicationBasePath = appBasePath;
            _appName = appName;
        }

        public string ApplicationName
        {
            get { return _appName; }
        }

        public string Version
        {
            get { return _originalAppEnvironment.Version; }
        }

        public string ApplicationBasePath
        {
            get { return _applicationBasePath; }
        }

        public string Configuration
        {
            get
            {
                return _originalAppEnvironment.Configuration;
            }
        }

        public FrameworkName RuntimeFramework
        {
            get { return _originalAppEnvironment.RuntimeFramework; }
        }
    }
}