#pragma checksum "C:\Users\PauloCampez\source\repos\PauloCampez\stunning-eureka\Stunnig.API\Stunning.MVC\Views\Funcionario\_PartialFiltros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd70b8bd7077e68e7ef1882a95d36efa40d50b9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario__PartialFiltros), @"mvc.1.0.view", @"/Views/Funcionario/_PartialFiltros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionario/_PartialFiltros.cshtml", typeof(AspNetCore.Views_Funcionario__PartialFiltros))]
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
#line 1 "C:\Users\PauloCampez\source\repos\PauloCampez\stunning-eureka\Stunnig.API\Stunning.MVC\Views\_ViewImports.cshtml"
using Stunning.MVC;

#line default
#line hidden
#line 2 "C:\Users\PauloCampez\source\repos\PauloCampez\stunning-eureka\Stunnig.API\Stunning.MVC\Views\_ViewImports.cshtml"
using Stunning.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd70b8bd7077e68e7ef1882a95d36efa40d50b9d", @"/Views/Funcionario/_PartialFiltros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71aabf86402b066cfb517f753b7798d94a76c5e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario__PartialFiltros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "UF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Funcionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 111, true);
            WriteLiteral("<div class=\"search-funcionario text-white py-3\" id=\"search-funcionario\">\r\n    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(111, 5188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd70b8bd7077e68e7ef1882a95d36efa40d50b9d5805", async() => {
                BeginContext(165, 1685, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card acik-renk-form"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-md-8"">
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""text"" class=""form-control"" placeholder=""Nome"" id=""Nome"" name=""Nome"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        <input type=""text"" class=""form-control"" placeholder=""CPF"" id=""CPF"" name=""CPF"">
                                    </div>
                                </div>
                            </d");
                WriteLiteral(@"iv>
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""text"" class=""form-control"" placeholder=""Cargo"" id=""Cargo"" name=""Cargo"">
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        ");
                EndContext();
                BeginContext(1850, 342, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd70b8bd7077e68e7ef1882a95d36efa40d50b9d7971", async() => {
                    BeginContext(2057, 46, true);
                    WriteLiteral("\r\n                                            ");
                    EndContext();
                    BeginContext(2103, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd70b8bd7077e68e7ef1882a95d36efa40d50b9d8421", async() => {
                        BeginContext(2120, 12, true);
                        WriteLiteral("Selecione UF");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2141, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 35 "C:\Users\PauloCampez\source\repos\PauloCampez\stunning-eureka\Stunnig.API\Stunning.MVC\Views\Funcionario\_PartialFiltros.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.UfNasc,"Selecione UF"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2192, 3100, true);
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""text"" class=""form-control"" placeholder=""Status"" id=""Status"" name=""Status"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Range Data -->
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""date"" class=""form-control""  asp-format=""{0:dd/MM/yyyy HH:mm}"" placeholder=""Data Inicio"" id=""DataInicio"" name=""Da");
                WriteLiteral(@"taInicio"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""date"" class=""form-control""  asp-format=""{0:dd/MM/yyyy HH:mm}"" placeholder=""Data Fim""  id=""DataFim"" name=""DataFim"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Range Salario -->
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""text"" class");
                WriteLiteral(@"=""form-control money"" placeholder=""Salario Inicio""  id=""SalarioInicio"" name=""SalarioInicio"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-4"">  
                                    <div class=""form-group "">
                                        <div class=""form-group "">
                                            <input type=""text"" class=""form-control money"" placeholder=""Salario Fim"" id=""SalarioFim"" name=""SalarioFim"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <input type=""submit"" class=""btn btn-warning  pl-5 pr-5"" value=""Buscar""/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
                WriteLiteral("            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5299, 24, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
