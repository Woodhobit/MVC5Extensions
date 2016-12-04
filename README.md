# MVC5Extensions

Extensions for unsing in ASP.NET MVC 5

# Alert Extension

Add the following markup (the _Layout.cshtml is the best place)

 @if (TempData.GetAlerts().Any())
{
    <div class="alert-container">
        @foreach (var alert in TempData.GetAlerts())
        {
            <div class="alert @alert.AlertClass alert-dismissable">
                <button type="button" class="close" data-dismiss="alert"
                        aria-hidden="true">
                    &times;
                </button>
                @alert.Message
            </div>
        }
    </div>
}

And then in the controller action you can use

return RedirectToAction("Index").WithSuccess("The item was successfully edited");

or

return this.View("Index").WithError("There is no data to save");
