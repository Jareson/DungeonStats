#pragma checksum "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5bdd866930f1712af39b12f11e0bfd9ab99864"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StatRoller.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using StatRoller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\DungeonStats\StatRoller\StatRoller\_Imports.razor"
using StatRoller.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\FetchData.razor"
using StatRoller.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
