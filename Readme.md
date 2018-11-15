<!-- default file list -->
*Files to look at*:

* **[HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))**
* [Model.cs](./CS/Models/Model.cs) (VB: [Model.vb](./VB/Models/Model.vb))
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [TypedListDataBindingPartial.cshtml](./CS/Views/Home/TypedListDataBindingPartial.cshtml)
<!-- default file list end -->
# How to export only selected GridView rows to different output text formats


<p>This example is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18639">KA18639: How to export GridView rows and keep end-user modifications (such as sorting, grouping, filtering, selection)</a> KB Article. Refer to the Article for an explanation.</p>


<h3>Description</h3>

settings.SettingsExport.ExportedRowType = DevExpress.Web.GridViewExportedRowType.Selected; --&gt;&nbsp;&nbsp;settings.SettingsExport.ExportSelectedRowsOnly = true;

<br/>


