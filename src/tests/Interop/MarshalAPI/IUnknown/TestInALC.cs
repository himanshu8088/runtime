// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.IO;
using System.Reflection;

namespace TestInALC
{
    class Test
    {
        static int Main(string[] args)
        {
            string currentAssemblyDirectory = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath);
            string testAssemblyFullPath = Path.Combine(currentAssemblyDirectory, "IUnknownTest.dll");
            return TestLibrary.Utilities.ExecuteAndUnload(testAssemblyFullPath, args);
        }
    }
}
