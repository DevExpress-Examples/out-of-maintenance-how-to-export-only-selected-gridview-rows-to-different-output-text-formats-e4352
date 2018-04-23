using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using Export.Models;

namespace Export.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            if(Session["TypedListModel"] == null)
                Session["TypedListModel"] = InMemoryModel.GetTypedListModel();

            return View(Session["TypedListModel"]);
        }

        public ActionResult TypedListDataBindingPartial() {
            return PartialView(Session["TypedListModel"]);
        }

        public ActionResult ExportTo(string OutputFormat) {
            var model = Session["TypedListModel"];

            switch(OutputFormat.ToUpper()) {
                case "CSV":
                    return GridViewExtension.ExportToCsv(GridViewHelper.ExportGridViewSettings, model);
                case "PDF":
                    return GridViewExtension.ExportToPdf(GridViewHelper.ExportGridViewSettings, model);
                case "RTF":
                    return GridViewExtension.ExportToRtf(GridViewHelper.ExportGridViewSettings, model);
                case "XLS":
                    return GridViewExtension.ExportToXls(GridViewHelper.ExportGridViewSettings, model);
                case "XLSX":
                    return GridViewExtension.ExportToXlsx(GridViewHelper.ExportGridViewSettings, model);
                default:
                    return RedirectToAction("Index");
            }
        }

    }
}
public static class GridViewHelper {
    private static GridViewSettings exportGridViewSettings;
    
    public static GridViewSettings ExportGridViewSettings {
        get {
            if(exportGridViewSettings == null)
                exportGridViewSettings = CreateExportGridViewSettings();
            return exportGridViewSettings;
        }
    }
    
    private static GridViewSettings CreateExportGridViewSettings() {
        GridViewSettings settings = new GridViewSettings();

        settings.Name = "gvTypedListDataBinding";
        settings.CallbackRouteValues = new { Controller = "Home", Action = "TypedListDataBindingPartial" };

        settings.KeyFieldName = "ID";
        settings.Settings.ShowFilterRow = true;

        settings.CommandColumn.Visible = true;
        settings.CommandColumn.ShowSelectCheckbox = true;

        settings.SettingsExport.ExportSelectedRowsOnly = true;

        settings.Columns.Add("ID");
        settings.Columns.Add("Text");
        settings.Columns.Add("Quantity");
        settings.Columns.Add("Price");

        return settings;
    }
}