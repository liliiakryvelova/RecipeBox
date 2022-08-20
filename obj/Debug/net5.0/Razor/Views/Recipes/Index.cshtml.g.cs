#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bfba5d4554a1c6925710d01e3e133ba11fb081c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Index), @"mvc.1.0.view", @"/Views/Recipes/Index.cshtml")]
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
#line 4 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bfba5d4554a1c6925710d01e3e133ba11fb081c", @"/Views/Recipes/Index.cshtml")]
    public class Views_Recipes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RecipeBox.Models.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Recipes</h1>\r\n\r\n<p>  \r\n    ");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</p>  \r\n");
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
 using (Html.BeginForm())  
{  

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>  \r\n        Search By Name : ");
#nullable restore
#line 16 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
                    Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n        <input type=\"submit\" value=\"Search\" /></p>  \r\n");
#nullable restore
#line 18 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n\r\n    <tr>\r\n      <th>\r\n       ");
#nullable restore
#line 24 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
  Write(Html.DisplayNameFor(model => model.RecipeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
#nullable restore
#line 27 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
   Write(Html.ActionLink("Rate", "Index", new { sortOrder=ViewBag.RateSortParm}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
#nullable restore
#line 30 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Ingredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </th>\r\n      <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
     foreach (Recipe recipe in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => recipe.RecipeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => recipe.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n              ");
#nullable restore
#line 45 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
         Write(Html.DisplayFor(modelItem => recipe.Ingredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span>");
#nullable restore
#line 48 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
                 Write(Html.ActionLink("Edit", "Edit", new { id = recipe.RecipeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>|\r\n                <span>");
#nullable restore
#line 49 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
                 Write(Html.ActionLink("Delete", "Delete", new { id = recipe.RecipeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>|\r\n                <span>");
#nullable restore
#line 50 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
                 Write(Html.ActionLink("Details", "Details", new { id = recipe.RecipeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n<p>");
#nullable restore
#line 56 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
Write(Html.ActionLink("Add new recipe", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 57 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RecipeBox.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591