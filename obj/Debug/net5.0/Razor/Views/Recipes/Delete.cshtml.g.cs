#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705d6522a174539735049e348720de64949892a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Delete), @"mvc.1.0.view", @"/Views/Recipes/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705d6522a174539735049e348720de64949892a3", @"/Views/Recipes/Delete.cshtml")]
    public class Views_Recipes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Are you sure you want to delete this Recipe?</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.RecipeName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.RecipeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lilia\Epicodus\ASP.NET\Best_Restaurant\RecipeBox\Views\Recipes\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index", "Recipes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
