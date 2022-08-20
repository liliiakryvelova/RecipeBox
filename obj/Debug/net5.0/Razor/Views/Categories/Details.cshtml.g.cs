#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "588f61d70037b900c908edf84dfa96ef74f877f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Details), @"mvc.1.0.view", @"/Views/Categories/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588f61d70037b900c908edf84dfa96ef74f877f7", @"/Views/Categories/Details.cshtml")]
    public class Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Category Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This category does not contain any recipes</p>\r\n");
#nullable restore
#line 14 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Recipes the category contains:</h4>\r\n    <ul>\r\n");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
       foreach(var join in Model.JoinEntities)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 21 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
       Write(join.Recipe.RecipeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
         using (Html.BeginForm("DeleteCategory", "Items"))
        {
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
     Write(Html.Hidden("joinId", @join.RecipeCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("          <input type=\"submit\" value=\"Delete\"/>\r\n");
#nullable restore
#line 26 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
         
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 29 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 31 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 32 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Edit Category", "Edit", new { id = Model.CategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 33 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Delete Category", "Delete", new { id = Model.CategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 34 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Categories\Details.cshtml"
Write(Html.ActionLink("Add a Recipe", "AddRecipe", new { id = Model.CategoryId }));

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
