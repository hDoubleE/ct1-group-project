#pragma checksum "C:\Users\trevor.heehs\source\repos\ct1-group-project\BlazorApp.Client\Pages\AddEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5789a1648b77716b3a0ddfccb7787834f582ff0e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorApp.Client;
    using BlazorApp.Client.Shared;
    using BlazorApp.Shared.Models;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/addemployee")]
    public class AddEmployee : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 40 "C:\Users\trevor.heehs\source\repos\ct1-group-project\BlazorApp.Client\Pages\AddEmployee.cshtml"
            
Employee emp = new Employee();
protected async Task CreateEmployee()
{
    await Http.SendJsonAsync(HttpMethod.Post, "/api/Employee/Create", emp);
    UriHelper.NavigateTo("/fetchemployee");
}
void cancel()
{
    UriHelper.NavigateTo("/fetchemployee");
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591