#pragma checksum "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\KategorijaVozila.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40bc5f4b7e3ec5457982200d8aca0b9849602d40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rezervacijas_KategorijaVozila), @"mvc.1.0.view", @"/Views/Rezervacijas/KategorijaVozila.cshtml")]
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
#nullable restore
#line 1 "C:\Users\muhar\source\repos\EParking\EParking\Views\_ViewImports.cshtml"
using EParking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhar\source\repos\EParking\EParking\Views\_ViewImports.cshtml"
using EParking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40bc5f4b7e3ec5457982200d8aca0b9849602d40", @"/Views/Rezervacijas/KategorijaVozila.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9d2b27e3bc513b5f3faba365c4e8f4e6e3a8ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Rezervacijas_KategorijaVozila : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EParking.Models.IzabranaKategorijaVozila>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("vozilo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KategorijaVozila", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\KategorijaVozila.cshtml"
  
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    button {
        display: inline-block;
        background-color: mediumaquamarine;
        border-radius: 10px;
        border: 4px double #cccccc;
        color: black;
        text-align: center;
        font-size: 12px;
        -webkit-transition: all 0.5s;
        -moz-transition: all 0.5s;
        -o-transition: all 0.5s;
        transition: all 0.5s;
        cursor: pointer;
    }



    #insertitem {
        width: 100%;
        padding: 2px;
        font-size: 20px;
        cursor: pointer;
    }


    #grid-gap {
        display: grid;
        grid-template-columns: auto auto;
        grid-gap: 20px;
        margin: 20px
    }

    div.cell {
        background: LightBlue;
        border: 1px solid Blue;
        padding: 10px;
    }
</style>


<style type=""text/css"">

    .skyblue {
        top: 20%;
        left: 20%;
        z-index: 1000;
        position: absolute;
        background-color: skyblue;
        display: compact;
    }");
            WriteLiteral(@"
</style>


<div id=""skybluediv"" style=""width:500px;height:800;border-color:mediumaquamarine;border-style:solid"" align=""center"">

    <p align=""center"" style=""margin-top:20px; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:20px"">
        <b>Kategorija</b>
    </p>
    <hr style=""height:3px;border:none;color:#333;background-color:#333;"" />

    <div id=""grid-gap"">
        <div>
            <img onclick=""javascript: HidePopup('Automobil');"" value=""0"" src=""https://s3.caradvice.com.au/wp-content/uploads/2013/10/Ferrari-F12-Berlinetta.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Auto</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Kamion');"" value=""1"" src=""https://tse1.mm.bing.net/th?id=OIP.oi8i4c7L23Afj-nDN_5a5gHaE7&pid=Api&P=0&w=317&h=212"" width=""200px"" height=""130px"" />
            <br />
            <b>Kamion</b>
        </div>
        <div>
      ");
            WriteLiteral(@"      <img onclick=""javascript: HidePopup('Motocikl');"" value=""2"" src=""http://s1.cdn.autoevolution.com/images/news/bike-xxx-2015-yamaha-yzf-r1-endurance-world-championship-edition-shows-up-photo-gallery-92613_1.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Motocikl</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Biciklo');""
                 value=""3"" src=""http://www.bicycleretailer.com/sites/default/files/images/article/Farrier%2024%20Print.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Biciklo</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Kombi');"" value=""4"" src=""http://www.thetruthaboutcars.com/wp-content/uploads/2012/02/IMG_4338.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Kombi</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Kamp kucica');"" value=""5"" src=""https://www.fraserway.com/sites/default/files/2019-01/2018_");
            WriteLiteral(@"Rentals_ClassC_Large_1070x680.png"" width=""200px"" height=""130px"" />
            <br />
            <b>Kamp kucica</b>

        </div>
        <div>
            <img onclick=""javascript: HidePopup('Autobus');"" value=""5"" src=""https://tse3.mm.bing.net/th?id=OIP.GUmNYHqEHflWW8Ao5FgWnQHaE8&pid=Api&P=0&w=298&h=199.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Autobus</b>
        </div>
    </div>





</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40bc5f4b7e3ec5457982200d8aca0b9849602d408650", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40bc5f4b7e3ec5457982200d8aca0b9849602d408912", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 115 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\KategorijaVozila.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div style=\"margin-top:50px\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40bc5f4b7e3ec5457982200d8aca0b9849602d4010666", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 117 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\KategorijaVozila.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Vozilo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <div style=\"margin-top:30px\">\r\n        <input type=\"submit\" value=\"Dalje\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<script type=\"text/javascript\">\r\n    function HidePopup(ime) {\r\n        document.getElementById(\"vozilo\").value = ime\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EParking.Models.IzabranaKategorijaVozila> Html { get; private set; }
    }
}
#pragma warning restore 1591