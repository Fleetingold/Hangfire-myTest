using Hangfire;
using Hangfire.Dashboard;
using Hangfire.SqlServer;
using Microsoft.Owin;
using MvcSample;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace MvcSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"server=192.168.1.250;database=Hangfire;uid=sa;pwd=abc-123;Pooling=False;")
                .UseMsmqQueues(@".\Private$\hangfire{0}", "default", "critical")
                .UseDashboardMetric(SqlServerStorage.ActiveConnections)
                .UseDashboardMetric(SqlServerStorage.TotalConnections)
                .UseDashboardMetric(DashboardMetrics.FailedCount);
            
            app.UseHangfireDashboard();
        }
    }
}
