<<<<<<< HEAD
#pragma checksum "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b615c5255e1df4ff3b6dd58613209c57e2ab88f"
=======
#pragma checksum "C:\Users\bella\source\repos\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaef733c25f985f0a6a739d84fd4514704db9ba5"
>>>>>>> 7134126408c0427a8747aa9f0721072147368d80
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend_Project.Pages.Haandvaerker.Pages_Haandvaerker_Details), @"mvc.1.0.razor-page", @"/Pages/Haandvaerker/Details.cshtml")]
namespace Frontend_Project.Pages.Haandvaerker
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\_ViewImports.cshtml"
using Frontend_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaef733c25f985f0a6a739d84fd4514704db9ba5", @"/Pages/Haandvaerker/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32472b6f377abfb1f156d3c4a46fec0bff21361d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Haandvaerker_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Haandvaerker/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Haandvaerker/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Haandvaerker/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
  
    ViewData["Title"] = "Detaljeret oversigt";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <h1>Details</h1>\r\n\r\n    <div class=\"row\">\r\n        <h4>Håndværkeren ");
#nullable restore
#line 12 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
                    Write(Model.localModel.hvFornavn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <hr />
    <div class=""col col-sm col-lg col-xl col-md p-5"">
        <table class=""table table-hover"">
            <thead class=""thead-dark"">
            <tr>
                <th>
                    Fornavn
                </th>
                <th>
                    Efternavn
                </th>
                <th>
                    Ansættelsesdato
                </th>
                <th>
                    Fagområde
                </th>
                <th>
                    ID
                </th>
                <th>
                    Værtktøjskasse ID
                </th>
                <th></th>
            </tr>
            </thead>
            <tbody>
            <tr>
                <td>
                    ");
#nullable restore
#line 42 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
               Write(Model.localModel.hvFornavn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
               Write(Model.localModel.hvEfternavn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
               Write(Model.localModel.hvAnsaettelsedato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
               Write(Model.localModel.hvFagomraade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
               Write(Model.localModel.haandvaerkerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
               Write(Model.localModel.vaerktoejskasse);

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            }\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    </div>\r\n    <div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b615c5255e1df4ff3b6dd58613209c57e2ab88f8217", async() => {
=======
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    </div>\r\n    <div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef733c25f985f0a6a739d84fd4514704db9ba58226", async() => {
>>>>>>> 7134126408c0427a8747aa9f0721072147368d80
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
                                                            WriteLiteral(Model.localModel.haandvaerkerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b615c5255e1df4ff3b6dd58613209c57e2ab88f10513", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef733c25f985f0a6a739d84fd4514704db9ba510523", async() => {
>>>>>>> 7134126408c0427a8747aa9f0721072147368d80
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\mads6\source\repo\DISP_Delprojekt1\API\Frontend_Project\Pages\Haandvaerker\Details.cshtml"
                                                                 WriteLiteral(Model.localModel.haandvaerkerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b615c5255e1df4ff3b6dd58613209c57e2ab88f12817", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaef733c25f985f0a6a739d84fd4514704db9ba512828", async() => {
>>>>>>> 7134126408c0427a8747aa9f0721072147368d80
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_Project.Pages.Haandvaerker.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend_Project.Pages.Haandvaerker.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend_Project.Pages.Haandvaerker.DetailsModel>)PageContext?.ViewData;
        public Frontend_Project.Pages.Haandvaerker.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
