#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5feb298c328d9162afe961e823853dbe6637054c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5feb298c328d9162afe961e823853dbe6637054c", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56ba27eb6fec7ae87fa28a804f73058ba5f137b", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\Student\Detail.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Detail";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n              <h1>");
#nullable restore
#line 12 "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\Student\Detail.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\Student\Detail.cshtml"
                         Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n              <h3>Point: ");
#nullable restore
#line 13 "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\UniversityApp\UniversityApp\Views\Student\Detail.cshtml"
                    Write(Model.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591