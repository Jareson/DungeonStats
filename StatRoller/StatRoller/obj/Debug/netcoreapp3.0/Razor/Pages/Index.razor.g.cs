#pragma checksum "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c33c5f187ba11a0117a95c465d9f834ed61dcb"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Roll Your Stats</h1>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
                                          rollStats

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Roll Out");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
    currentStats[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
    currentStats[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
    currentStats[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, 
#nullable restore
#line 11 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
    currentStats[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 12 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
    currentStats[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 13 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
    currentStats[5]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Code\DungeonStats\StatRoller\StatRoller\Pages\Index.razor"
       
    int[] currentStats = { 0, 0, 0, 0, 0, 0 };

    void rollStats()
    {

        currentStats = currentStats.Select(x => x = diceArray()).ToArray();
    }

    int diceArray()
    {     

        int[] rolledDice = new int[] { new Random().Next(1,7), new Random().Next(1,7), new Random().Next(1,7), new Random().Next(1,7) };

        Array.Sort(rolledDice);
        Array.Reverse(rolledDice);
        var testSet = rolledDice[0..3];

        return rolledDice[0..3].Sum();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
