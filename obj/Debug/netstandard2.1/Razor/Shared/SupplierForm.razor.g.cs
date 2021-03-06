#pragma checksum "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e801fca12ea6678aaa3e868c840a05f433bd067"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorClientApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorClientApp\_Imports.razor"
using BlazorClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorClientApp\_Imports.razor"
using BlazorClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\BlazorClientApp\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\BlazorClientApp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projects\BlazorClientApp\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\BlazorClientApp\_Imports.razor"
using BlazorClientApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Projects\BlazorClientApp\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Projects\BlazorClientApp\_Imports.razor"
using BlazorClientApp.Repository;

#line default
#line hidden
#nullable disable
    public partial class SupplierForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "   \r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                      Supplier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        \r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<label>Company Name:</label>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                             Supplier.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.CompanyName = __value, Supplier.CompanyName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.CompanyName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __Blazor.BlazorClientApp.Shared.SupplierForm.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 12 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                          ()=>Supplier.CompanyName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.AddMarkupContent(33, "<label>Contact Name:</label>\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                             Supplier.ContactName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.ContactName = __value, Supplier.ContactName))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.ContactName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddMarkupContent(44, "\r\n                ");
                __Blazor.BlazorClientApp.Shared.SupplierForm.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 21 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                          ()=>Supplier.ContactName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.AddMarkupContent(53, "<label>Contact Title:</label>\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                             Supplier.ContactTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.ContactTitle = __value, Supplier.ContactTitle))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.ContactTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.AddMarkupContent(66, "<label>Address:</label>\r\n                ");
                __builder2.OpenElement(67, "div");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.Address = __value, Supplier.Address))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.OpenElement(76, "div");
                __builder2.AddMarkupContent(77, "\r\n                    ");
                __Blazor.BlazorClientApp.Shared.SupplierForm.TypeInference.CreateValidationMessage_2(__builder2, 78, 79, 
#nullable restore
#line 35 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                              ()=>Supplier.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.AddMarkupContent(86, "<label>City:</label>\r\n                ");
                __builder2.OpenElement(87, "div");
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.City = __value, Supplier.City))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n                ");
                __builder2.AddMarkupContent(100, "<label>Region:</label>\r\n                ");
                __builder2.OpenElement(101, "div");
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(103);
                __builder2.AddAttribute(104, "class", "form-control");
                __builder2.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.Region

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.Region = __value, Supplier.Region))));
                __builder2.AddAttribute(107, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.Region));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-group");
                __builder2.AddMarkupContent(113, "\r\n                ");
                __builder2.AddMarkupContent(114, "<label>Postal Code:</label>\r\n                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddMarkupContent(116, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(117);
                __builder2.AddAttribute(118, "class", "form-control");
                __builder2.AddAttribute(119, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.PostalCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.PostalCode = __value, Supplier.PostalCode))));
                __builder2.AddAttribute(121, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.PostalCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                ");
                __builder2.OpenElement(124, "div");
                __builder2.AddMarkupContent(125, "\r\n                    ");
                __Blazor.BlazorClientApp.Shared.SupplierForm.TypeInference.CreateValidationMessage_3(__builder2, 126, 127, 
#nullable restore
#line 56 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                              ()=>Supplier.PostalCode

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(128, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n            ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group");
                __builder2.AddMarkupContent(133, "\r\n                ");
                __builder2.AddMarkupContent(134, "<label>Country:</label>\r\n                ");
                __builder2.OpenElement(135, "div");
                __builder2.AddMarkupContent(136, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(137);
                __builder2.AddAttribute(138, "class", "form-control");
                __builder2.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.Country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.Country = __value, Supplier.Country))));
                __builder2.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.Country));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n            ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "form-group");
                __builder2.AddMarkupContent(147, "\r\n                ");
                __builder2.AddMarkupContent(148, "<label>Phone:</label>\r\n                ");
                __builder2.OpenElement(149, "div");
                __builder2.AddMarkupContent(150, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(151);
                __builder2.AddAttribute(152, "class", "form-control");
                __builder2.AddAttribute(153, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(154, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.Phone = __value, Supplier.Phone))));
                __builder2.AddAttribute(155, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n                ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "form-group");
                __builder2.AddMarkupContent(160, "\r\n                    ");
                __builder2.AddMarkupContent(161, "<label>Fax:</label>\r\n                    ");
                __builder2.OpenElement(162, "div");
                __builder2.AddMarkupContent(163, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(164);
                __builder2.AddAttribute(165, "class", "form-control");
                __builder2.AddAttribute(166, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                     Supplier.Fax

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(167, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.Fax = __value, Supplier.Fax))));
                __builder2.AddAttribute(168, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.Fax));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(169, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n            ");
                __builder2.OpenElement(173, "div");
                __builder2.AddAttribute(174, "class", "form-group");
                __builder2.AddMarkupContent(175, "\r\n                ");
                __builder2.AddMarkupContent(176, "<label>Home Page:</label>\r\n                ");
                __builder2.OpenElement(177, "div");
                __builder2.AddMarkupContent(178, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(179);
                __builder2.AddAttribute(180, "class", "form-control");
                __builder2.AddAttribute(181, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                                                                 Supplier.HomePage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(182, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.HomePage = __value, Supplier.HomePage))));
                __builder2.AddAttribute(183, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.HomePage));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(184, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(187, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(188);
                __builder2.AddAttribute(189, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 84 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(190, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(191, "Save");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(192, "\r\n        <input type=\"reset\" class=\"btn btn-danger\" value=\"Clear\">\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(193, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Projects\BlazorClientApp\Shared\SupplierForm.razor"
      
    [Parameter] public Supplier Supplier { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorClientApp.Shared.SupplierForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
