﻿using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Microsoft VSTS Authentication")]
[assembly: AssemblyDescription("Microsoft Visual Studio Team Services Authentication Library for Windows")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("https://github.com/Microsoft/Git-Credential-Manager-for-Windows")]
[assembly: AssemblyCopyright("Copyright © Microsoft Corporation 2018. All rights reserved.")]
[assembly: AssemblyTrademark("Microsoft Corporation")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("c1daabc1-b493-459d-bb4f-04fbefb1ba13")]
[assembly: AssemblyVersion("4.4.0.0")]
[assembly: AssemblyFileVersion("4.4.0.0")]
[assembly: NeutralResourcesLanguage("en-US")]

// Only expose internals when the binary isn't signed.
#if !SIGNED
[assembly: InternalsVisibleTo("Microsoft.Vsts.Authentication.Test")]
#endif
