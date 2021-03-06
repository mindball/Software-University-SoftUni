﻿namespace MVC.Framework.Helpers
{
    public static class ControllerHelpers
    {
        public static string GetFullQualifiedName(string controller, string action)
        {
            return string.Format(
                "{0}.{1}.{2}.{3}, {0}",
                MvcContext.Get.AssemblyName,
                MvcContext.Get.ViewsFolder,
                controller,
                action);
        }

        public static string GetControllerName(object controller)
        {
            return controller.GetType()
                .Name
                .Replace(MvcContext.Get.ControllerSuffix, string.Empty);
        }
    }
}