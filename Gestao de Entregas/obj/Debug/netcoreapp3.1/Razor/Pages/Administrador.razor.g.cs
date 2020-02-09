#pragma checksum "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3006d975cde9a810a8026afe3c547d60cba84054"
// <auto-generated/>
#pragma warning disable 1591
namespace Gestao_de_Entregas.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Gestao_de_Entregas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\_Imports.razor"
using Gestao_de_Entregas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
using Gestao_de_Entregas.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administrador")]
    public partial class Administrador : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administração</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Email</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 23 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
         foreach (var user in ColUsers)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                     user.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                     user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                     user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                      (() => EditaUser(user))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n                        Editar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 36 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 40 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
 if (MostraPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "    \r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal");
            __builder.AddAttribute(35, "tabindex", "-1");
            __builder.AddAttribute(36, "style", "display:block");
            __builder.AddAttribute(37, "role", "dialog");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-dialog");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal-content");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-header");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddMarkupContent(48, "<h3 class=\"modal-title\">Cria/Edita Usuário</h3>\r\n                    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "close");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                                  FechaPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.AddMarkupContent(54, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                \r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-body");
            __builder.AddMarkupContent(59, "\r\n                    \r\n");
#nullable restore
#line 55 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                     if (objUser.Id != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                        ");
            __builder.OpenElement(61, "p");
            __builder.AddContent(62, 
#nullable restore
#line 57 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                            objUser.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 58 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "                    \r\n");
#nullable restore
#line 60 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                     if (objUser.Id != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                        ");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, 
#nullable restore
#line 62 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                            objUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 63 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                        ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddAttribute(72, "type", "text");
            __builder.AddAttribute(73, "placeholder", "Nome");
            __builder.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                                                          objUser.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 67 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "                    ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "class", "form-control");
            __builder.AddAttribute(80, "type", "text");
            __builder.AddAttribute(81, "placeholder", "Email");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                                                       objUser.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "class", "form-control");
            __builder.AddAttribute(87, "type", "password");
            __builder.AddAttribute(88, "placeholder", "Password");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "select");
            __builder.AddAttribute(93, "class", "form-control");
            __builder.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                         CurrentUserRole

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentUserRole = __value, CurrentUserRole));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 71 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                         foreach (var option in Options)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                            ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", 
#nullable restore
#line 73 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                            option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(100, "\r\n                                ");
            __builder.AddContent(101, 
#nullable restore
#line 74 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                 option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 76 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    <br><br>\r\n                    \r\n                    ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "class", "btn btn-primary");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                              SalvaUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "\r\n                        Salvar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    \r\n");
#nullable restore
#line 84 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                     if (objUser.Id != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(111, "                        \r\n                        ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "class", "btn btn-danger");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                                 DeletaUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(115, "\r\n                            Deletar\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 90 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "                    <br>\r\n                    ");
            __builder.OpenElement(118, "span");
            __builder.AddAttribute(119, "style", "color:red");
            __builder.AddContent(120, 
#nullable restore
#line 92 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                             strError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 97 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(126, "button");
            __builder.AddAttribute(127, "class", "btn btn-success");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                          AdicionaNovoUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(129, "Adicionar Usuário");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(131);
            __builder.AddAttribute(132, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(133, "\r\n");
#nullable restore
#line 103 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(134, "            ");
                __builder2.OpenElement(135, "p");
                __builder2.AddMarkupContent(136, "Você esta com perfil : ");
                __builder2.AddContent(137, 
#nullable restore
#line 105 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                       ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(138, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n");
#nullable restore
#line 106 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(140, "            ");
                __builder2.OpenElement(141, "p");
                __builder2.AddMarkupContent(142, "Você não esta logado como um perfil de : ");
                __builder2.AddContent(143, 
#nullable restore
#line 109 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
                                                         ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(144, ".");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n");
#nullable restore
#line 110 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(146, "    ");
            }
            ));
            __builder.AddAttribute(147, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(148, "\r\n        ");
                __builder2.AddMarkupContent(149, "<p>Você não esta logado.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\josim\source\Gerenciador de entregas\Gestao de Entregas\Pages\Administrador.razor"
       

    // Propriedade usada para adicionar ou editar o usuário atual
    ApplicationUser objUser = new ApplicationUser();

    // Obtem a role selecionada para o usuário atual
    string CurrentUserRole { get; set; } = "User";

    // Coleção para exibir os usuários existentes
    List<ApplicationUser> ColUsers = new List<ApplicationUser>();

    // Opções para exibir as roles na lista suspensa quando editar um usuário
    List<string> Options = new List<string>() { "User", "Admin" };

    // Trata erros
    string strError = "";

    // Habilita a exibição do Popup
    bool MostraPopup = false;

    void AdicionaNovoUser()
    {
        // cria um novo usuário
        objUser = new ApplicationUser();
        objUser.PasswordHash = "*****";
        // Definie o id como vazio
        objUser.Id = "";
        // abre o popup
        MostraPopup = true;
    }

    async Task SalvaUser()
    {
        try
        {
            // É um usuário existente?
            if (objUser.Id != "")
            {
                // obtem o usuário
                var user = await _UserManager.FindByIdAsync(objUser.Id);
                // atualiza Email
                user.Email = objUser.Email;
                // atualiza o usuário
                await _UserManager.UpdateAsync(user);
                // somente atualiza a senha se o o valor atual
                // não for o valor padrão
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken = await _UserManager.GeneratePasswordResetTokenAsync(user);
                    var passworduser = await _UserManager.ResetPasswordAsync(user, resetToken, objUser.PasswordHash);
                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError = passworduser.Errors.FirstOrDefault().Description;
                        }
                        else
                        {
                            strError = "Erro na senha...";
                        }
                        // mantem o popup aberto
                        return;
                    }
                }
                // trata os perfis
                // O usuário esta no perfil admin ?
                var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
                // O perfil Administrator foi selecionado
                // mas o usuário náo é um  Administrator?
                if ((CurrentUserRole == ADMINISTRATION_ROLE) & (!UserResult))
                {
                    // Poe o admin no perfil Administrator
                    await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    // O perifl Administrator não foi selecionado
                    // mas o usuário é um Administrator ?
                    if ((CurrentUserRole != ADMINISTRATION_ROLE) & (UserResult))
                    {
                        // Remove o usuário do perfil Administrator
                        await _UserManager.RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                    }
                }
            }
            else
            {
                // Insere um novo user
                var NewUser = new ApplicationUser
                {
                    UserName = objUser.UserName,
                    Email = objUser.Email
                };

                var CreateResult = await _UserManager.CreateAsync(NewUser, objUser.PasswordHash);

                if (!CreateResult.Succeeded)
                {
                    if (CreateResult.Errors.FirstOrDefault() != null)
                    {
                        strError = CreateResult.Errors.FirstOrDefault().Description;
                    }
                    else
                    {
                        strError = "Erro ao criar usuário...";
                    }
                    // mantem o popup aberto
                    return;

                }
                else
                {
                    // Trata os perfis
                    if (CurrentUserRole == ADMINISTRATION_ROLE)
                    {
                        // poe o admin no perfil Administrator
                        await _UserManager.AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
                    }
                }
            }
            // fecha o Popup
            MostraPopup = false;
            // Atualiza os usuarios
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }

    async Task EditaUser(ApplicationUser _ApplicationUser)
    {
        // Define o usuario selecionado como o atual
        objUser = _ApplicationUser;
        // Obtem o usuario
        var user = await _UserManager.FindByIdAsync(objUser.Id);

        if (user != null)
        {
            // O usuario esta no perfiel administrator ?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);

            if (UserResult)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            else
            {
                CurrentUserRole = "User";
            }
        }
        // Abre o popup
        MostraPopup = true;
    }

    async Task DeletaUser()
    {
        // Fecha o Popup
        MostraPopup = false;
        // Obtem o usuário
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Deleta o usuario
            await _UserManager.DeleteAsync(user);
        }
        // atualiza
        GetUsers();
    }

    void FechaPopup()
    {
        // fecha o popup
        MostraPopup = false;
    }

    public void GetUsers()
    {
        // limpa mensasgens de erro
        strError = "";
        // define a coleção para tratar os usuários
        ColUsers = new List<ApplicationUser>();
        // Obtem os usuários a partir de _UserManager
        var user = _UserManager.Users.Select(x => new ApplicationUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email = x.Email,
            PasswordHash = "*****"
        });
        foreach (var item in user)
        {
            ColUsers.Add(item);
        }
    }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    string ADMINISTRATION_ROLE = "Admin";

    System.Security.Claims.ClaimsPrincipal UsuarioAtual;

    protected override async Task OnInitializedAsync()
    {
        // Verifica se existe um ADMINISTRATION_ROLE
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            // Cria o perfil ADMINISTRATION_ROLE
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }
        // Verifica que o usuário chamado Admin@BlazorHelp.com é um Administrador
        var user = await _UserManager.FindByEmailAsync("josimarsv@outlook.com");
        if (user != null)
        {
            // O usuário Admin@BlazorHelp.com esta no perfil de administrador?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                // Põe o admin no perfil Administrator
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }
        // Obtem o usuário logado atual
        UsuarioAtual = (await authenticationStateTask).User;

        GetUsers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
