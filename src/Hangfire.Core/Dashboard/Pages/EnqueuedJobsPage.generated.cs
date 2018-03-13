﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    
    #line 2 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class EnqueuedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
  
    Layout = new LayoutPage(Queue.ToUpperInvariant());

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.EnqueuedCount(Queue));
    var enqueuedJobs = monitor.EnqueuedJobs(Queue, pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 23 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        ");


            
            #line 26 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
   Write(Html.Breadcrumbs(Queue.ToUpperInvariant(), new Dictionary<string, string>
        {
            { "Queues", Url.LinkToQueues() }
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <h1 class=\"page-header\">");


            
            #line 31 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                           Write(Queue.ToUpperInvariant());

            
            #line default
            #line hidden
WriteLiteral(" <small>");


            
            #line 31 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                                            Write(Strings.EnqueuedJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</small></h1>\r\n\r\n");


            
            #line 33 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 36 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
           Write(Strings.EnqueuedJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 38 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-default\"\r\n                            data-url=\"");


            
            #line 44 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                 Write(Url.To("/jobs/enqueued/delete"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 45 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                          Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-confirm=\"");


            
            #line 46 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                     Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-remove\"></span>\r\n                        ");


            
            #line 49 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                   Write(Strings.Common_DeleteSelected);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n                    ");


            
            #line 52 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
               Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>

                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                        <tr>
                            <th class=""min-width"">
                                <input type=""checkbox"" class=""js-jobs-list-select-all""/>
                            </th>
                            <th class=""min-width"">");


            
            #line 62 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                             Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th class=\"min-width\">");


            
            #line 63 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                             Write(Strings.Common_State);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");


            
            #line 64 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                           Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th class=\"align-right\">");


            
            #line 65 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                               Write(Strings.Common_Enqueued);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        </tr>\r\n                        </thead>\r\n         " +
"               <tbody>\r\n");


            
            #line 69 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                         foreach (var job in enqueuedJobs)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr class=\"js-jobs-list-row hover ");


            
            #line 71 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                                          Write(job.Value == null || !job.Value.InEnqueuedState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                <td>\r\n");


            
            #line 73 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                     if (job.Value != null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input type=\"checkbox\" class=\"js-jobs-lis" +
"t-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 75 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                                                                                             Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");


            
            #line 76 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                                <td class=" +
"\"min-width\">\r\n                                    ");


            
            #line 79 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                               Write(Html.JobIdLink(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 80 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                     if (job.Value != null && !job.Value.InEnqueuedState)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span title=\"");


            
            #line 82 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                                Write(Strings.Common_JobStateChanged_Text);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 83 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n");


            
            #line 85 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                 if (job.Value == null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <td colspan=\"3\"><em>");


            
            #line 87 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                                   Write(Strings.Common_JobExpired);

            
            #line default
            #line hidden
WriteLiteral("</em></td>\r\n");


            
            #line 88 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"min-width\">\r\n                     " +
"                   ");


            
            #line 92 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                   Write(Html.StateLabel(job.Value.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </td>\r\n");



WriteLiteral("                                    <td class=\"word-break\">\r\n                    " +
"                    ");


            
            #line 95 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                   Write(Html.JobNameLink(job.Key, job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </td>\r\n");



WriteLiteral("                                    <td class=\"align-right\">\r\n");


            
            #line 98 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                         if (job.Value.EnqueuedAt.HasValue)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 100 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.Value.EnqueuedAt.Value));

            
            #line default
            #line hidden
            
            #line 100 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                                                                          
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 104 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 105 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n");


            
            #line 107 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </tr>\r\n");


            
            #line 109 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n\r\n                ");


            
            #line 114 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
           Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 116 "..\..\Dashboard\Pages\EnqueuedJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591