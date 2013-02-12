﻿using System;
using System.Web.Optimization;

namespace WIGDashboard.Optimization
{
    public class ScriptBundleWithoutRename : Bundle
    {
        public ScriptBundleWithoutRename(string virtualPath, string cdnPath = (string) null)
            : base(virtualPath, cdnPath, new IBundleTransform[] {
                new JsMinifyWithRename()
            })
        {
            ConcatenationToken = ";";
        }
    }
}