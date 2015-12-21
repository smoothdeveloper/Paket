﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("2.37.0")>]
[<assembly: AssemblyFileVersionAttribute("2.37.0")>]
[<assembly: AssemblyInformationalVersionAttribute("2.37.0-alpha003")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.37.0"