#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f383d6dcb2f14b912c43f67096489c87c47f6a17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f383d6dcb2f14b912c43f67096489c87c47f6a17", @"/Views/Categories/Create.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Add a new Category</h4>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
Write(Html.LabelFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
Write(Html.TextBoxFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add new Category\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 15 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 16 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
Write(Html.ActionLink("Show all Categories", "Index", "Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 17 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Create.cshtml"
Write(Html.ActionLink("Back to main", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
