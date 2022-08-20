#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2cfa55606d82e279f276a90f27f00525956a58d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
#line 4 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2cfa55606d82e279f276a90f27f00525956a58d", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecipeBox.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Categories</h1>\r\n \r\n");
#nullable restore
#line 10 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
 if(@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There is no categories.</p>\r\n");
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ol>\r\n");
#nullable restore
#line 16 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
     foreach(var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 18 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
     Write(Html.ActionLink($"{category.CategoryName}", "Details", new { id = category.CategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ol>\r\n");
#nullable restore
#line 21 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 23 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
Write(Html.ActionLink("Add new recipe", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 24 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecipeBox.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591