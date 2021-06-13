#pragma checksum "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\ModelPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8e15e80c084b5caa1f33e63bbc97e677393e7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ModelPreview), @"mvc.1.0.view", @"/Views/Home/ModelPreview.cshtml")]
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
#line 1 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\_ViewImports.cshtml"
using ModelViewer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\_ViewImports.cshtml"
using ModelViewer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8e15e80c084b5caa1f33e63bbc97e677393e7f", @"/Views/Home/ModelPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9843c3a9f7dc892c1b49cb08e224960b59fa43c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ModelPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\ModelPreview.cshtml"
  
    ViewBag.Title = "Model Preview";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f8e15e80c084b5caa1f33e63bbc97e677393e7f3976", async() => {
                WriteLiteral("Wróć");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <h3>Użyj myszki aby obracać obiekt</h3>
<script>
    var scene = new THREE.Scene();
    var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
    var Loader = new THREE.OBJLoader();
    const light = new THREE.PointLight( 0xffffff, 4, 90 );
    light.position.set(50, 50, 50);
    scene.add(light);
    let obj;
    let mouseX, mouseY;
    let deltaX=0;
    let deltaY=0;
    let isDown;
    Loader.load(`/assets/");
#nullable restore
#line 19 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\ModelPreview.cshtml"
                    Write(ViewData["object"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`, (object) => {
        obj = object;
        scene.add(obj);
        renderer.render(scene, camera);
        render();
    });
    var renderer = new THREE.WebGLRenderer({ alpha: true });
    renderer.setClearColor(0x000000, 0);
    renderer.setSize(window.innerWidth, window.innerHeight);
    renderer.antialias = true;
    document.body.appendChild(renderer.domElement);
    camera.position.z = 12;
    document.addEventListener('mousemove',(e)=>{
        if(!isDown)
            return;
        
        e.preventDefault();
        deltaX = e.clientX - mouseX;
        deltaY = e.clientY - mouseY;
        mouseX = e.clientX;
        mouseY = e.clientY;

    });
    document.addEventListener('mousedown',(e)=>{
        e.preventDefault();
        isDown = true;
        mouseX = e.clientX;
        mouseY = e.clientY;
    });
    document.addEventListener('mouseup',(e)=>{
        e.preventDefault();
        isDown = false;
        deltaX = 0;
        deltaY = 0;
        mouseY = 0;");
            WriteLiteral("\r\n        mouseX = 0;\r\n    });\r\n    var render = () =>{\r\n        requestAnimationFrame(render);\r\n        obj.rotation.y += deltaX/100;\r\n        obj.rotation.x += deltaY/100;\r\n        renderer.render(scene, camera);\r\n    }\r\n</script>");
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
