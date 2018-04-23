﻿@ModelType System.Collections.IEnumerable
<script type="text/javascript">
    function OnClick(s, e) {
        var actionParams = $("form").attr("action").split("?OutputFormat=");
        actionParams[1] = s.GetMainElement().getAttribute("OutputFormatAttribute");
        $("form").attr("action", actionParams.join("?OutputFormat="));
    }
</script>
@Using (Html.BeginForm("ExportTo", "Home"))

    @<table>
        <tr>
            <td>
                @Html.DevExpress().Button( _
               Sub(btn)
                   btn.Name = "btnExportToCSV"
                   btn.Attributes("OutputFormatAttribute") = "CSV"
                   btn.Text = "CSV"
                   btn.UseSubmitBehavior = True
                   btn.ClientSideEvents.Click = "OnClick"
               End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button( _
               Sub(btn)
                   btn.Name = "btnExportToPDF"
                   btn.Attributes("OutputFormatAttribute") = "PDF"
                   btn.Text = "PDF"
                   btn.UseSubmitBehavior = True
                   btn.ClientSideEvents.Click = "OnClick"
               End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button( _
               Sub(btn)
                   btn.Name = "btnExportToRTF"
                   btn.Attributes("OutputFormatAttribute") = "RTF"
                   btn.Text = "RTF"
                   btn.UseSubmitBehavior = True
                   btn.ClientSideEvents.Click = "OnClick"
               End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button( _
               Sub(btn)
                   btn.Name = "btnExportToXLS"
                   btn.Attributes("OutputFormatAttribute") = "XLS"
                   btn.Text = "XLS"
                   btn.UseSubmitBehavior = True
                   btn.ClientSideEvents.Click = "OnClick"
               End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button( _
               Sub(btn)
                   btn.Name = "btnExportToXLSX"
                   btn.Attributes("OutputFormatAttribute") = "XLSX"
                   btn.Text = "CSV"
                   btn.UseSubmitBehavior = True
                   btn.ClientSideEvents.Click = "OnClick"
               End Sub).GetHtml()
            </td>
        </tr>
    </table>
    
    @Html.Partial("TypedListDataBindingPartial", Model)
End Using