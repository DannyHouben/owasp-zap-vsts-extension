﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owasp_zap_vsts_tool.Models
{
    internal class Issue
    {
        internal string IssueDescription { get; set; }
        internal string RiskDescription { get; set; }
        internal string OriginalSiteUrl { get; set; }
        internal string TargetUrl { get; set; }
        internal string Description { get; set; }
        internal string Solution { get; set; }
        internal List<IssueInstance> Instances { get; set; }


    }

    internal class IssueInstance
    {
        internal string Uri { get; set; }
        internal string Evidence { get; set; }
    }
}
