﻿//----------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace Microsoft.IdentityModel.Clients.ActiveDirectory
{
    [SecurityCritical]
    internal class PlatformInformation : PlatformInformationBase
    {
        [SecurityCritical]
        public override string GetProductName()
        {
            return "PCL.iOS";
        }
        [SecurityCritical]
        public override string GetEnvironmentVariable(string variable)
        {
            // TODO: Update
            return null;
        }
        [SecurityCritical]
        public override Task<string> GetUserPrincipalNameAsync()
        {
            // TODO: Update
            return null;
        }
        [SecurityCritical]
        public override string GetProcessorArchitecture()
        {
            return null;
        }
        [SecurityCritical]
        public override string GetOperatingSystem()
        {
            return null;
        }
        [SecurityCritical]
        public override string GetDeviceModel()
        {
            return null;
        }
        [SecurityCritical]
        public override string GetAssemblyFileVersionAttribute()
        {
            // TODO: Check if assembly file version can be read in iOS assembly as well or not. For now, we use assembly version instead.
            return typeof(AdalIdHelper).GetTypeInfo().Assembly.GetName().Version.ToString();
        }

        [SecurityCritical]
        public override string GetApplicationName()
        {
            return NSBundle.MainBundle.BundleIdentifier;
        }
        [SecurityCritical]
        public override string GetApplicationVersion()
        {
            return NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString();
        }
        [SecurityCritical]
        public override string GetDeviceId()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}
