using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC5Extensions.Alerts
{
    public class AlertDecoratorResult : ActionResult
    {
        public ActionResult InnerResult { get; set; }

        public string AlertClass { get; set; }

        public string Message { get; set; }

        public AlertDecoratorResult(ActionResult innerResult, string alertClass, string message)
        {
            this.InnerResult = innerResult;
            this.AlertClass = alertClass;
            this.Message = message;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var alerts = context.Controller.TempData.GetAlerts();
            alerts.Add(new Alert(this.AlertClass, this.Message));
            this.InnerResult.ExecuteResult(context);
        }
    }
}
