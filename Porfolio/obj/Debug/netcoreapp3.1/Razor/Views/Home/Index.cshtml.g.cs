#pragma checksum "C:\Users\mkbew\source\repos\PorfolioRdy\Porfolio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7dc6558d8b59c426ed9604532a081e7f893ae7"
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
#nullable restore
#line 1 "C:\Users\mkbew\source\repos\PorfolioRdy\Porfolio\Views\_ViewImports.cshtml"
using Porfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mkbew\source\repos\PorfolioRdy\Porfolio\Views\_ViewImports.cshtml"
using Porfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7dc6558d8b59c426ed9604532a081e7f893ae7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8753161a627d289f778e0baecee885df6eb99b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7dc6558d8b59c426ed9604532a081e7f893ae73941", async() => {
                WriteLiteral(@"
    <!-- Masthead-->
    <header class=""masthead"">
        <div class=""container h-100"">
            <div class=""row h-100 align-items-center justify-content-center text-center"">
                <div class=""col-lg-10 align-self-end"">
                    <h1 class=""text-uppercase text-white font-weight-bold"">Hi! Welcome to my website!</h1>
                    <hr class=""divider my-4"" />
                </div>
                <div class=""col-lg-8 align-self-baseline"">
                    <p class=""text-white-75 font-weight-light mb-5"">
                        Welcome my name is Jakub and I'm self-taught Backend Programmer, Paramedic, Public Health Specialist, Gaming enthusiast and Artist.
                        On this page you can learn a lot about me!
                    </p>
                    <a class=""btn btn-primary btn-xl js-scroll-trigger"" href=""#about"">About Me</a>
                </div>
            </div>
        </div>
    </header>
    <!-- About-->
    <section class=""page-section bg-primary"" id");
                WriteLiteral(@"=""about"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-8 text-center"">
                    <h2 class=""text-white mt-0"">Jakub Pawelec</h2>
                    <hr class=""divider light my-4"" />
                    <p class=""text-white-50 mb-4"">
                        I am 24 years old paramedic, programmer and ex-police officer. Thanks to experience in various professions I am prepared for unforeseen changes and unconventional
                        tasks at work. Experience in health care and the Police confirms my resistance to stress and clear thinking
                        under pressure. Working as a bartender requires very good communication with team and freedom in contact
                        with client. In addition, I can adapt to many variables and acquire new skills in a short time. I have been
                        interested in programming for many years and since 2018 I have been learning to work in languages such");
                WriteLiteral(@" as
                        Java (Spring and Hibernate), SQL and C# (.Net).
                    </p>
                    <a class=""btn btn-light btn-xl js-scroll-trigger"" href=""#services"">My Skills</a>
                </div>
            </div>
        </div>
    </section>
    <!-- Services-->
    <section class=""page-section"" id=""services"">
        <div class=""container"">
            <h2 class=""text-center mt-0"">Some of my skills (But not all)!</h2>
            <hr class=""divider my-4"" />
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 text-center"">
                    <div class=""mt-5"">
                        <i class=""fas fa-4x fa-laptop-code text-primary mb-4""></i>
                        <h3 class=""h4 mb-2"">Programming Languages</h3>
                        <p class=""text-muted mb-0"">C# (.Net), Java (Spring, Hibernate)</p>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 text-center"">
                    <div class=""mt-5"">
      ");
                WriteLiteral(@"                  <i class=""fas fa-4x fa-database text-primary mb-4""></i>
                        <h3 class=""h4 mb-2"">Databases</h3>
                        <p class=""text-muted mb-0"">Ms-SQL, MySQL</p>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 text-center"">
                    <div class=""mt-5"">
                        <i class=""fas fa-4x fa-toolbox text-primary mb-4""></i>
                        <h3 class=""h4 mb-2"">Tools</h3>
                        <p class=""text-muted mb-0"">GIT, Postman</p>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 text-center"">
                    <div class=""mt-5"">
                        <i class=""fas fa-4x fa-window-restore text-primary mb-4""></i>
                        <h3 class=""h4 mb-2"">Software</h3>
                        <p class=""text-muted mb-0"">Visual Studio, Eclipse, IntelliJ IDEA</p>
                    </div>
                </div>
            </div>
        </div>
 ");
                WriteLiteral(@"   </section>
    <!-- Portfolio-->
    <div id=""portfolio"">
            <h2 class=""text-center mt-0"">My portfolio</h2>
            <hr class=""divider my-4"" />
        <div class=""container-fluid p-0"">
            <div class=""row no-gutters"">
                <div class=""col-lg-4 col-sm-6"">
                    <a class=""portfolio-box""");
                BeginWriteAttribute("href", " href=\"", 4485, "\"", 4519, 1);
#nullable restore
#line 87 "C:\Users\mkbew\source\repos\PorfolioRdy\Porfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 4492, Url.Action("Index", "Git"), 4492, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <img class=\"img-fluid\" src=\"assets/img/portfolio/thumbnails/1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4612, "\"", 4618, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""portfolio-box-caption"">
                            <div class=""project-category text-white-50"">GitHub</div>
                            <div class=""project-name"">My projects i one place!</div>
                        </div>
                    </a>
                </div>
                <div class=""col-lg-4 col-sm-6"">
                    <a class=""portfolio-box""");
                BeginWriteAttribute("href", " href=\"", 5024, "\"", 5061, 1);
#nullable restore
#line 96 "C:\Users\mkbew\source\repos\PorfolioRdy\Porfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 5031, Url.Action("Index", "Course"), 5031, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <img class=\"img-fluid\" src=\"assets/img/portfolio/thumbnails/2.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 5154, "\"", 5160, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""portfolio-box-caption"">
                            <div class=""project-category text-white-50"">Achievements</div>
                            <div class=""project-name"">My courses certificates,achivements and more</div>
                        </div>
                    </a>
                </div>
                <div class=""col-lg-4 col-sm-6"">
                    <a class=""portfolio-box""");
                BeginWriteAttribute("href", " href=\"", 5592, "\"", 5632, 1);
#nullable restore
#line 105 "C:\Users\mkbew\source\repos\PorfolioRdy\Porfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 5599, Url.Action("Index", "Education"), 5599, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <img class=\"img-fluid\" src=\"assets/img/portfolio/thumbnails/3.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 5725, "\"", 5731, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""portfolio-box-caption"">
                            <div class=""project-category text-white-50"">Education and Hobbies</div>
                            <div class=""project-name"">Information about completed education</div>
                        </div>
                    </a>
                </div>
");
                WriteLiteral(@"            </div>
        </div>
    </div>
    <!-- Call to action-->
    <section class=""page-section bg-dark text-white"">
        <div class=""container text-center"">
            <h2 class=""mb-4"">If you need it download my CV!</h2>
            <a class=""btn btn-light btn-xl"" href=""https://drive.google.com/file/d/1CN0KnH3tRjfrA4W-awA8U4lKq1GmszV-/view?usp=sharing"">Download Now!</a>
        </div>
    </section>
    <!-- Contact-->
    <section class=""page-section"" id=""contact"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-8 text-center"">
                    <h2 class=""mt-0"">Let's Get In Touch!</h2>
                    <hr class=""divider my-4"" />
                    <p class=""text-muted mb-5"">If you want to contact me give me a call or send me an email!</p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-4 ml-auto text-center mb-5 mb-lg-0"">
                    <i class=""fas fa");
                WriteLiteral(@"-phone fa-3x mb-3 text-muted""></i>
                    <div>721-126-264</div>
                </div>
                <div class=""col-lg-4 mr-auto text-center"">
                    <i class=""fab fa-linkedin fa-3x mb-3 text-muted""></i>
                    <div><a class=""d-block"" href=""https://www.linkedin.com/in/jakubpawelec-6b14971a0/""> https://www.linkedin.com/in/jakubpawelec-6b14971a0/ </a></div>
                </div>
                <div class=""col-lg-4 mr-auto text-center"">
                    <i class=""fas fa-envelope fa-3x mb-3 text-muted""></i>
                    <!-- Make sure to change the email address in BOTH the anchor text and the link target below!-->
                    <a class=""d-block"" href=""mailto:jakub.pawelec1112@gmail.com"">jakub.pawelec1112@gmail.com</a>
                </div>
            </div>
        </div>
    </section>
    <!-- Footer-->
    <footer class=""bg-light py-5"">
        <div class=""container""><div class=""small text-center text-muted"">Jakub Pawelec 2020</div></div>
    </f");
                WriteLiteral(@"ooter>
    <!-- Bootstrap core JS-->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js""></script>
    <!-- Third party plugin JS-->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js""></script>
    <!-- Core theme JS-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7dc6558d8b59c426ed9604532a081e7f893ae714730", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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