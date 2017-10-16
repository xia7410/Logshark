﻿using LogParsers.Base.ParserBuilders;
using Logshark.ArtifactProcessors.TableauServerLogProcessor.Parsing.Parsers;
using System;
using System.Collections.Generic;

namespace Logshark.ArtifactProcessors.TableauServerLogProcessor.Parsing.ParserBuilders
{
    /// <summary>
    /// Contains the mapping context between files within the "httpd" directory in the logs and their associated parsers.
    /// </summary>
    internal sealed class HttpdParserBuilder : BaseParserBuilder, IParserBuilder
    {
        private static readonly IDictionary<string, Type> fileMap =
            new Dictionary<string, Type>
            {
                { @"^access.*log", typeof(HttpdParser) },
                { @"^error.*log", typeof(HttpdErrorParser) }
            };

        protected override IDictionary<string, Type> FileMap
        {
            get { return fileMap; }
        }
    }
}