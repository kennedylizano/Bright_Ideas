#pragma checksum "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22415f69255b39f2691148f4c3c9ab04cf0ef1d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/_ViewImports.cshtml"
using Bright_Ideas;

#line default
#line hidden
#line 2 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/_ViewImports.cshtml"
using Bright_Ideas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22415f69255b39f2691148f4c3c9ab04cf0ef1d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92b01539aecc0bf189137c4a07844cc47ac2c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/newidea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Bright_Ideas: Bright Ideas";

#line default
#line hidden
            BeginContext(59, 10, true);
            WriteLiteral("\n\n\n<h1>Hi ");
            EndContext();
            BeginContext(70, 29, false);
#line 7 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
  Write(ViewBag.CurrentUser.UserAlias);

#line default
#line hidden
            EndContext();
            BeginContext(99, 80, true);
            WriteLiteral("</h1>\n<a class=\"btn btn-danger\" style=\"float: right;\" href=\"logout\">Log Out</a>\n");
            EndContext();
            BeginContext(179, 388, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22415f69255b39f2691148f4c3c9ab04cf0ef1d84785", async() => {
                BeginContext(239, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(245, 23, false);
#line 10 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(268, 292, true);
                WriteLiteral(@"
    <fieldset>
        <label class=""btn btn-warning"" for=""UserIdea"">Post Idea:</label>
        <div>
        <textarea id=""UserIdea"" type=""text"" name=""UserIdea""></textarea>

        </div>
        <input  class=""btn btn-secondary"" type=""submit"" name=""submit"" value=""Post!"">
    </fieldset>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(567, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 20 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
  
    foreach (var idea in ViewBag.AllIdeas)
    {

#line default
#line hidden
            BeginContext(620, 72, true);
            WriteLiteral("        <div class=\"container\">\n  \n\n        <h3><a class=\"btn btn-light\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 692, "\"", 718, 2);
            WriteAttributeValue("", 699, "/users/", 699, 7, true);
#line 26 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
WriteAttributeValue("", 706, idea.UserId, 706, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(719, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(721, 20, false);
#line 26 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
                                                           Write(idea.Owner.UserAlias);

#line default
#line hidden
            EndContext();
            BeginContext(741, 57, true);
            WriteLiteral("</a>:</h3>\n        \n        <p class=\"alert alert-info\" >");
            EndContext();
            BeginContext(799, 13, false);
#line 28 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
                                Write(idea.UserIdea);

#line default
#line hidden
            EndContext();
            BeginContext(812, 55, true);
            WriteLiteral("</p>\n        </div>\n        <p class=\"btn btn-light\" >\n");
            EndContext();
#line 31 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
             if(idea.UserId == ViewBag.CurrentUser.UserId)
            {

#line default
#line hidden
            BeginContext(940, 41, true);
            WriteLiteral("                <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 981, "\"", 1012, 2);
            WriteAttributeValue("", 988, "/deleteidea/", 988, 12, true);
#line 33 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
WriteAttributeValue("", 1000, idea.IdeaId, 1000, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1013, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 34 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1039, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 35 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
          
            bool print = true;
            foreach (var like in idea.LikedBy)
            {
                if (like.UserId == ViewBag.CurrentUser.UserId)
                    {
                        print = false; 
                    }
            }
            if(print)
            {

#line default
#line hidden
            BeginContext(1339, 42, true);
            WriteLiteral("                <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1381, "\"", 1406, 2);
            WriteAttributeValue("", 1388, "/like/", 1388, 6, true);
#line 46 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
WriteAttributeValue("", 1394, idea.IdeaId, 1394, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1407, 10, true);
            WriteLiteral(">Like</a>\n");
            EndContext();
#line 47 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1462, 66, true);
            WriteLiteral("                <span class=\"btn btn-info\" >Already Liked!</span>\n");
            EndContext();
#line 51 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1552, 36, true);
            WriteLiteral("          <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1588, "\"", 1621, 2);
            WriteAttributeValue("", 1595, "/bright_ideas/", 1595, 14, true);
#line 53 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
WriteAttributeValue("", 1609, idea.IdeaId, 1609, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1622, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1624, 18, false);
#line 53 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
                                                                  Write(idea.LikedBy.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1642, 27, true);
            WriteLiteral(" People</a> Like this.</p>\n");
            EndContext();
#line 54 "/Users/kennedyyersi/Desktop/Bright_Ideas/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1677, 1, true);
            WriteLiteral("\n");
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