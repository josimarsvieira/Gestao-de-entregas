#pragma checksum "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d423367ec503173da44022ecc9b0df1dd94721"
// <auto-generated/>
#pragma warning disable 1591
namespace Gestao_de_Entregas.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Gestao_de_Entregas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\_Imports.razor"
using Gestao_de_Entregas.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "sidebar");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenComponent<Gestao_de_Entregas.Shared.NavMenu>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "main");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "top-row px-4 auth");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<Gestao_de_Entregas.Shared.LoginDisplay>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">Sobre nós</a>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "content px-4");
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.AddContent(22, 
#nullable restore
#line 18 "C:\Users\josim\source\Gerenciador de Entregas\Gestao de Entregas\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
            }
            ));
            __builder.AddAttribute(26, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<div>\r\n        </div>\r\n\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "main");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "top-row px-4 auth");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Gestao_de_Entregas.Shared.LoginDisplay>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.AddMarkupContent(37, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">Sobre nós</a>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n            ");
                __builder2.AddMarkupContent(39, "<div class=\"content px-4\">\r\n                <p>\r\n                    <h2>Você não está logado</h2>\r\n                </p>\r\n            </div>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
