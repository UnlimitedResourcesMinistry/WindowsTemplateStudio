// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace TemplateValidator
{
    public class CommandLineOptions
    {
        [Option('f', "file", DefaultValue = false, HelpText = "Verify a single config file.")]
        public string File { get; set; }

        [OptionList('d', "directories", DefaultValue = false, HelpText = "Verify all the templates in the defined directories.")]
        public List<string> Directories { get; set; }

        // Warnings should be used to provide guidance in the output but for issues that are optional to address.
        [Option("nowarn", DefaultValue = false, HelpText = "Do not show warnings.")]
        public bool NoWarnings { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
