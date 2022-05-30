#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\BP202\ASP\2. 30-05-2022\StartBootstrap\StartBootstrap\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6efad7ba4cd427a517aff4981740fed0170001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6efad7ba4cd427a517aff4981740fed0170001", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"      <!-- Masthead-->
        <header class=""masthead bg-primary text-white text-center"">
            <div class=""container d-flex align-items-center flex-column"">
                <!-- Masthead Avatar Image-->
                <img class=""masthead-avatar mb-5"" src=""assets/img/avataaars.svg""");
            BeginWriteAttribute("alt", " alt=\"", 291, "\"", 297, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                <!-- Masthead Heading-->
                <h1 class=""masthead-heading text-uppercase mb-0"">Start Bootstrap</h1>
                <!-- Icon Divider-->
                <div class=""divider-custom divider-light"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- Masthead Subheading-->
                <p class=""masthead-subheading font-weight-light mb-0"">Graphic Artist - Web Designer - Illustrator</p>
            </div>
        </header>
        <!-- Portfolio Section-->
        <section class=""page-section portfolio"" id=""portfolio"">
            <div class=""container"">
                <!-- Portfolio Section Heading-->
                <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Portfolio</h2>
                <!-- Icon Divider-->
                <div class=""divider-");
            WriteLiteral(@"custom"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- Portfolio Grid Items-->
                <div class=""row justify-content-center"">
                    <!-- Portfolio Item 1-->
                    <div class=""col-md-6 col-lg-4 mb-5"">
                        <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal1"">
                            <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                            </div>
                            <img class=""img-fluid"" src=""assets/img/portfolio/cabin.png""");
            BeginWriteAttribute("alt", " alt=\"", 2264, "\"", 2270, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <!-- Portfolio Item 2-->
                    <div class=""col-md-6 col-lg-4 mb-5"">
                        <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal2"">
                            <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                            </div>
                            <img class=""img-fluid"" src=""assets/img/portfolio/cake.png""");
            BeginWriteAttribute("alt", " alt=\"", 2933, "\"", 2939, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <!-- Portfolio Item 3-->
                    <div class=""col-md-6 col-lg-4 mb-5"">
                        <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal3"">
                            <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                            </div>
                            <img class=""img-fluid"" src=""assets/img/portfolio/circus.png""");
            BeginWriteAttribute("alt", " alt=\"", 3604, "\"", 3610, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <!-- Portfolio Item 4-->
                    <div class=""col-md-6 col-lg-4 mb-5 mb-lg-0"">
                        <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal4"">
                            <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                            </div>
                            <img class=""img-fluid"" src=""assets/img/portfolio/game.png""");
            BeginWriteAttribute("alt", " alt=\"", 4281, "\"", 4287, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <!-- Portfolio Item 5-->
                    <div class=""col-md-6 col-lg-4 mb-5 mb-md-0"">
                        <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal5"">
                            <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                            </div>
                            <img class=""img-fluid"" src=""assets/img/portfolio/safe.png""");
            BeginWriteAttribute("alt", " alt=\"", 4958, "\"", 4964, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <!-- Portfolio Item 6-->
                    <div class=""col-md-6 col-lg-4"">
                        <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal6"">
                            <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                            </div>
                            <img class=""img-fluid"" src=""assets/img/portfolio/submarine.png""");
            BeginWriteAttribute("alt", " alt=\"", 5627, "\"", 5633, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- About Section-->
        <section class=""page-section bg-primary text-white mb-0"" id=""about"">
            <div class=""container"">
                <!-- About Section Heading-->
                <h2 class=""page-section-heading text-center text-uppercase text-white"">About</h2>
                <!-- Icon Divider-->
                <div class=""divider-custom divider-light"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- About Section Content-->
                <div class=""row"">
                    <div class=""col-lg-4 ml-auto""><p class=""lead"">Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source files including HTML, CSS, and Java");
            WriteLiteral(@"Script as well as optional SASS stylesheets for easy customization.</p></div>
                    <div class=""col-lg-4 mr-auto""><p class=""lead"">You can create your own custom avatar for the masthead, change the icon in the dividers, and add your email address to the contact form to make it fully functional!</p></div>
                </div>
                <!-- About Section Button-->
                <div class=""text-center mt-4"">
                    <a class=""btn btn-xl btn-outline-light"" href=""https://startbootstrap.com/theme/freelancer/"">
                        <i class=""fas fa-download mr-2""></i>
                        Free Download!
                    </a>
                </div>
            </div>
        </section>
        <!-- Contact Section-->
        <section class=""page-section"" id=""contact"">
            <div class=""container"">
                <!-- Contact Section Heading-->
                <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>
           ");
            WriteLiteral(@"     <!-- Icon Divider-->
                <div class=""divider-custom"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- Contact Section Form-->
                <div class=""row"">
                    <div class=""col-lg-8 mx-auto"">
                        <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19.-->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6efad7ba4cd427a517aff4981740fed017000113454", async() => {
                WriteLiteral(@"
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Name</label>
                                    <input class=""form-control"" id=""name"" type=""text"" placeholder=""Name"" required=""required"" data-validation-required-message=""Please enter your name."" />
                                    <p class=""help-block text-danger""></p>
                                </div>
                            </div>
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Email Address</label>
                                    <input class=""form-control"" id=""email"" type=""email"" placeholder=""Email Address"" required=""required"" data-validation-required-message=""Please enter your email address."" />
                                    <p clas");
                WriteLiteral(@"s=""help-block text-danger""></p>
                                </div>
                            </div>
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Phone Number</label>
                                    <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""Phone Number"" required=""required"" data-validation-required-message=""Please enter your phone number."" />
                                    <p class=""help-block text-danger""></p>
                                </div>
                            </div>
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Message</label>
                                    <textarea class=""form-control"" id=""message"" rows=""5"" placeholder=""Message"" required=""requir");
                WriteLiteral(@"ed"" data-validation-required-message=""Please enter a message.""></textarea>
                                    <p class=""help-block text-danger""></p>
                                </div>
                            </div>
                            <br />
                            <div id=""success""></div>
                            <div class=""form-group""><button class=""btn btn-primary btn-xl"" id=""sendMessageButton"" type=""submit"">Send</button></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </section>\n     \n");
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
