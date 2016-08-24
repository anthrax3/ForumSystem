﻿namespace ForumSystem.Web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(
                new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.flatly.css", 
                    "~/Content/custom/site.css", 
                    "~/Content/custom/site.common.css", 
                    "~/Content/custom/forum.css", 
                    "~/Content/MvcGrid/mvc-grid.css"));
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery/jquery-{version}.js", 
                    "~/Scripts/jquery/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/administration-scripts").Include("~/Scripts/MvcGrid/mvc-grid.js"));

            bundles.Add(new ScriptBundle("~/bundles/renderGrid").Include("~/Scripts/custom/MvcGrid/renderGrid.js"));
        }
    }
}