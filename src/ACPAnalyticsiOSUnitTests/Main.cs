﻿/*
    Copyright 2020 Adobe
    All Rights Reserved.
    NOTICE: Adobe permits you to use, modify, and distribute this file in
    accordance with the terms of the Adobe license agreement accompanying
    it. If you have received this file from a source other than Adobe,
    then your use, modification, or distribution of it requires the prior
    written permission of Adobe.
    This file has been modified from its original form. The original
    license can be viewed in the NOTICES.txt file.
*/

using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace ACPAnalyticsiOSUnitTests
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "UnitTestAppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "UnitTestAppDelegate");
        }
    }
}
