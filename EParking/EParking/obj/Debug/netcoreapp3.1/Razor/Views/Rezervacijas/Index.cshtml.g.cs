#pragma checksum "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3a74132aedff706af1f7d301fc57886cb5cbe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rezervacijas_Index), @"mvc.1.0.view", @"/Views/Rezervacijas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3a74132aedff706af1f7d301fc57886cb5cbe0", @"/Views/Rezervacijas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9d2b27e3bc513b5f3faba365c4e8f4e6e3a8ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Rezervacijas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<EParking.Models.Rezervacija,IEnumerable<EParking.Models.Mjesto>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "StalniGostUzastopno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "StalniGostMjesecno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "OsobaSInvaliditetom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:50px; width:200px; font-size:15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("javascript: Provjera();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rezervacijas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "provjeriKorisnika", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    table {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    td, th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #dddddd;
    }

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

    .button-corner {
        display: inline-block;
        background-color: mediumaquamarine;
        border-radius: 10px;
        border: 4px double #cccccc;
        color: black;
        text-align: center;
        font-size: 12px;
        -webkit-transition: all 0.5s;
        -moz-transit");
            WriteLiteral(@"ion: all 0.5s;
        -o-transition: all 0.5s;
        transition: all 0.5s;
        cursor: pointer;
        position: absolute;
        bottom: 20px;
        right: 20px;
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

.skyblue
{
  top:20%;
  left:20%;
  z-index:1000;
  position:absolute;
  background-color:skyblue;
  display:compact;
}

    .showPopUp {
        background-color: #e6fff2;
        filter: alpha(opacity=100);
        opacity: 1;
        width: 100%;
        height: 100%;
        z-index: auto;
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
     ");
            WriteLiteral(@"   bottom: 0;
        margin: auto
    }


.hidepopup
{
  display:none;
}
    .brown {
        background-color:#e6fff2;
        filter: alpha(opacity=100);
        opacity: 1;
        width: 100%;
        height: 100%;
        z-index: auto;
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        margin: auto
    }
    .vrijeme {
        display: inline-block;
    }

    .vrijemeLabela {
        display: block;
    }


</style>






<div id=""skybluediv"" style=""width:500px;height:700px;border-color:blue;border-style:solid"" align=""center"" class=""hidepopup"">

    <p align=""center"" style=""margin-top:20px; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:20px"">
        <b>Kategorija</b>
    </p>
    <hr style=""height:3px;border:none;color:#333;background-color:#333;"" />

    <div id=""grid-gap"">
        <div>
            <img onclick=""jav");
            WriteLiteral(@"ascript: HidePopup('Auto', src);"" value=""0"" src=""https://s3.caradvice.com.au/wp-content/uploads/2013/10/Ferrari-F12-Berlinetta.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Auto</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Kamion', src);"" value=""1"" src=""https://tse1.mm.bing.net/th?id=OIP.oi8i4c7L23Afj-nDN_5a5gHaE7&pid=Api&P=0&w=317&h=212"" width=""200px"" height=""130px"" />
            <br />
            <b>Kamion</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Motocikl', src);"" value=""2"" src=""http://s1.cdn.autoevolution.com/images/news/bike-xxx-2015-yamaha-yzf-r1-endurance-world-championship-edition-shows-up-photo-gallery-92613_1.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Motocikl</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Biciklo', src);"" 
                 value=""3"" src=""http://www.bicycleretailer.com/sites/default/files/images/article");
            WriteLiteral(@"/Farrier%2024%20Print.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Biciklo</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Kombi', src);"" value=""4"" src=""https://www.carscoops.com/wp-content/uploads/2019/12/Murder-Van.jpg"" width=""200px"" height=""130px"" />
            <br />
            <b>Kombi</b>
        </div>
        <div>
            <img onclick=""javascript: HidePopup('Kamp kucica', src);"" value=""5"" src=""https://www.fraserway.com/sites/default/files/2019-01/2018_Rentals_ClassC_Large_1070x680.png"" width=""200px"" height=""130px"" />
            <br />
            <b>Kamp kucica</b>
        </div>
    </div>


    <button class=""button-corner"" onclick=""javascript: HidePopup();""> <b>Zatvori</b></button>
</div>

<div id=""errorDiv"" style=""width:250px;height:200px;border-color:blue;border-style:solid"" align=""center"" class=""hidepopup"">
    <p><b>Greška</b></p>
    <hr />
    <p>Pogrešan unos!</p>
    <button class=""button-corner"" onc");
            WriteLiteral(@"lick=""javascript: Zatvori();""> <b>Zatvori</b></button>
</div>

    <h1 style=""padding-bottom:50px"">Rezervacija</h1>

    <div>
        <table id=""tabelaMjesta"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 205 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.ElementAt(0).Sprat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 208 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.ElementAt(0).Red));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 211 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.ElementAt(0).Kolona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Vrsta vozila\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 220 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                 foreach (var item in Model.Item2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td name=\"sprat\">\r\n                            ");
#nullable restore
#line 224 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Sprat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td name=\"red\">\r\n                            ");
#nullable restore
#line 227 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Red));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td name=\"kolona\">\r\n                            ");
#nullable restore
#line 230 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Kolona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 234 "C:\Users\muhar\source\repos\EParking\EParking\Views\Rezervacijas\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3a74132aedff706af1f7d301fc57886cb5cbe015260", async() => {
                WriteLiteral(@"
        <div style=""padding-top:150px"">
            <b style=""padding-right:10px ; font-size:17px"">Kategorija: </b>
            <br />
            <button onclick=""javascript: Display();""><b>Izaberi kategoriju</b></button>

            <img style=""margin-left:40px"" id=""slikakategorije"" src=""https://s3.caradvice.com.au/wp-content/uploads/2013/10/Ferrari-F12-Berlinetta.jpg"" width=""200px"" height=""100px"" />
            <hr />
        </div>


        <div style=""padding-top:20px"">
            <b style=""padding-right:10px ; font-size:17px"">Mjesto: </b>

            <input id=""sprat"" style=""text-align:center"" type=""number"" min=""0"" max=""59"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkeydown=""return false"">
            <input id=""red"" style=""text-align:center"" type=""number"" min=""0"" max=""59"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkeydown=""return false"">
            <input id=""kolona"" style=""text-align:center"" type=""number"" min=""0"" max=""59"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkey");
                WriteLiteral(@"down=""return false"">

            <hr />
        </div>




        <div style=""padding-top:20px"">



            <b style=""padding-right:10px ; font-size:17px"">Popust: </b>

            <select style=""font-size:14px; margin-right:35px"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3a74132aedff706af1f7d301fc57886cb5cbe016931", async() => {
                    WriteLiteral("\r\n                    Stalni gost uzastopno\r\n                ");
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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3a74132aedff706af1f7d301fc57886cb5cbe018230", async() => {
                    WriteLiteral("\r\n                    Stalni gost mjesečno\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3a74132aedff706af1f7d301fc57886cb5cbe019528", async() => {
                    WriteLiteral("\r\n                    Osoba s invaliditetom\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            </select>

            <button onclick=""https://www.yModelutube.com/""><b>Pokreni igricu za popust</b></button>

        </div>
        <hr />

        <div>
            <p style=""font-size:17px""><b>Vrijeme rezervacije: </b></p>
            <div class=""vrijeme"">
                <label class=""vrijemeLabela"">Početak rezervacije: </label>
                <div class=""vrijeme"">

                    <input id=""pocetakSati"" style=""text-align:center"" type=""number"" min=""0"" max=""23"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkeydown=""return false"" />
                </div>
                <div class=""vrijeme""><b>:</b></div>
                <div class=""vrijeme"">
                    <input id=""pocetakMinute"" style=""text-align:center"" type=""number"" min=""0"" max=""59"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkeydown=""return false"">
                </div>
            </div>
            <div style=""margin-left:30px"" class=""vrijeme"">
                <label class=""vrijemeLabela"">Kraj");
                WriteLiteral(@" rezervacije: </label>
                <div class=""vrijeme"">

                    <input id=""krajSati"" style=""text-align:center"" type=""number"" min=""0"" max=""23"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkeydown=""return false"">
                </div>
                <div class=""vrijeme""><b>:</b></div>
                <div class=""vrijeme"">
                    <input id=""krajMinute"" style=""text-align:center"" type=""number"" min=""0"" max=""59"" step=""1"" value=""0"" size=""3"" name=""cantitate"" onkeydown=""return false"">
                </div>
            </div>
        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3a74132aedff706af1f7d301fc57886cb5cbe023748", async() => {
                WriteLiteral("<b>Završi rezervaciju</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"    

    <script type=""text/javascript"">

        var izabranaKategorija

        function Zatvori() {
            document.getElementById(""errorDiv"").className = ""hidepopup""
        }
        function Display() {
            document.getElementById(""skybluediv"").className = ""brown""
        }
        function HidePopup(kategorija, slika) {
            document.getElementById(""skybluediv"").className = ""hidepopup""
            image = document.getElementById(""slikakategorije"")
            image.src = slika
            izabranaKategorija = kategorija
        }
        function Provjera() {

            var sprat = document.getElementById(""sprat"").value
            var red = document.getElementById(""red"").value
            var kolona = document.getElementById(""kolona"").value
            var tabela = document.getElementById(""tabelaMjesta"")
            var ureduMjesto = false
            

            var rows = tabela.rows
            
            var n1 = rows.length
            for ");
            WriteLiteral(@"(i = 1; i < n1; i++) {

                var x = rows[i].cells.item(0).innerHTML;
                var y = rows[i].cells.item(1).innerHTML;
                var z = rows[i].cells.item(2).innerHTML;
                var kat = rows[i].cells.item(3).innerText;
                if (parseInt(x, 10) == sprat && parseInt(y, 10) == red && parseInt(z, 10) == kolona && kat == izabranaKategorija) {
                        ureduMjesto = true
                        break
                    }                    

             }
            if (ureduMjesto == false) {
                document.getElementById(""errorDiv"").className = ""showPopUp""

            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<EParking.Models.Rezervacija,IEnumerable<EParking.Models.Mjesto>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
