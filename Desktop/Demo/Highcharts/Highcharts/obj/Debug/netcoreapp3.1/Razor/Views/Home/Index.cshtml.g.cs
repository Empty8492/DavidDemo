#pragma checksum "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef826ebe518cb3dcf52c5c8f47745264251c16c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef826ebe518cb3dcf52c5c8f47745264251c16c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Highcharts.Models.Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/highcharts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef826ebe518cb3dcf52c5c8f47745264251c16c4369", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ef826ebe518cb3dcf52c5c8f47745264251c16c5408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""container"" style=""width: 600px;height:400px;""></div>
<div>
    <span>国家:</span><input type=""text"" name=""Name"" id=""Name"" />
    <span>1月:</span><input type=""number"" name=""January"" id=""January"" />
    <span>2月:</span><input type=""number"" name=""February"" id=""February"" />
    <span>3月:</span><input type=""number"" name=""March"" id=""March"" />
    <button onclick=""insertdata()"">添加</button>
</div>
<div>
    <select id=""selectID"" onchange=""countries(this.value)"">
        <option>请选择国家</option>
");
#nullable restore
#line 15 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 756, "\"", 772, 1);
#nullable restore
#line 17 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
WriteAttributeValue("", 764, item.ID, 764, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 18 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
    <span>1月:</span><input type=""number"" name=""January"" id=""XJanuary"" />
    <span>2月:</span><input type=""number"" name=""February"" id=""XFebruary"" />
    <span>3月:</span><input type=""number"" name=""March"" id=""XMarch"" />
    <button onclick=""Update()"">修改</button>
    <button onclick=""Delete02()"">删除</button>
</div>
<div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>国家</td>
                <td>一月</td>
                <td>二月</td>
                <td>三月</td>
                <td>操作</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
               Write(item.January);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
               Write(item.February);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
               Write(item.March);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button");
            BeginWriteAttribute("onclick", " onclick=\"", 1680, "\"", 1708, 3);
            WriteAttributeValue("", 1690, "Delete01(", 1690, 9, true);
#nullable restore
#line 45 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
WriteAttributeValue("", 1699, item.ID, 1699, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1707, ")", 1707, 1, true);
            EndWriteAttribute();
            WriteLiteral(">删除</button></td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Hexianzhang\Desktop\Highcharts\Highcharts\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef826ebe518cb3dcf52c5c8f47745264251c16c10832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef826ebe518cb3dcf52c5c8f47745264251c16c11872", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(function () {
        $.ajax({
            url: ""api/Users"",
            type: ""get"",
            success: function (data) {
                //console.log(data);
                var jsondata = JSON.parse(data);
                //console.log(jsondata);
                var options = {
                    chart: {
                        type: 'column'
                    },
                    title: {
                        text: '图表'
                    },
                    xAxis: {
                        categories: ['一月', '二月', '三月'],
                        crosshair: true
                    },
                    yAxis: {
                        title: {
                            text: '-------------'
                        }
                    },
                    tooltip: {
                        headerFormat: '<span style=""font-size:10px"">{point.key}</span><table>',
                        pointFormat: '<tr><td style=""color:{series.color};padding:");
            WriteLiteral(@"10"">{series.name}: </td>' +
                            '<td style=""padding:10""><b>{point.y:.1f} mm</b></td></tr>',
                        footerFormat: '</table>',
                        shared: true,
                        useHTML: true
                    },
                    series: jsondata
                };
                var chart = Highcharts.chart('container', options);
            }
        })
    })
    function insertdata() {
        var name = $(""#Name"").val();
        var january = $(""#January"").val();
        var february = $(""#February"").val();
        var march = $(""#March"").val();
        var param = { ""Name"": name, ""January"": parseInt(january, 10), ""February"": parseInt(february, 10), ""March"": parseInt(march, 10) };
        $.ajax({
            url: ""api/Users"",
            type: ""post"",
            data: param,
            //contentType: 'application/json',
            success: function (data) {
                alert(""成功添加数据"");
                window.location");
            WriteLiteral(@".reload();
            }
        })
    }
    function countries(id) {
        $.ajax({
            url: ""api/Users/GetMonthDatagetByCountryId?id="" + id,
            type: ""get"",
            success: function (data) {
                var jsondata = JSON.parse(data);
                $(""#XJanuary"").val(jsondata[0].January);
                $(""#XFebruary"").val(jsondata[0].February);
                $(""#XMarch"").val(jsondata[0].March);
            }
        })
    }
    function Update() {
        var id = $(""#selectID"").val();
        var january = $(""#XJanuary"").val();
        var february = $(""#XFebruary"").val();
        var march = $(""#XMarch"").val();
        var param = { ""Id"": id, ""January"": parseInt(january, 10), ""February"": parseInt(february, 10), ""March"": parseInt(march, 10) };
        $.ajax({
            url: ""api/Users"",
            type: ""Put"",
            data: param,
            success: function (data) {
                alert(""成功修改数据"");
                window.location.r");
            WriteLiteral(@"eload();
            }
        })
    }
    function Delete01(Id) {
        var param = { ""Id"": Id };
        $.ajax({
            url: ""api/Users"",
            type: ""Delete"",
            data: param,
            success: function (data) {
                alert(""成功删除数据"");
                window.location.reload();
            }
        })
    } function Delete02() {
        var id = $(""#selectID"").val();
        var param = { ""Id"": id };
        $.ajax({
            url: ""api/Users"",
            type: ""Delete"",
            data: param,
            success: function (data) {
                alert(""成功删除数据"");
                window.location.reload();
            }
        })
    }
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Highcharts.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
