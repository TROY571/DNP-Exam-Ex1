// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VolumeWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using VolumeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\_Imports.razor"
using VolumeWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\Pages\Calculator.razor"
using VolumeWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\Pages\Calculator.razor"
using VolumeWebService.VolumeCalculator;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\10211\OneDrive\桌面\Study\DNP1\VolumeWeb\VolumeWeb\Pages\Calculator.razor"
       
    private VolumeResult newCylinderItem = new VolumeResult();
    private VolumeResult newConeItem = new VolumeResult();

    private async void AddCylinder()
    {
        try
        {
            await resultService.CalculateVolumeCylinder(newCylinderItem.height, newCylinderItem.radius);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private async void AddCone()
    {
        try
        {
            await resultService.CalculateVolumeCone(newConeItem.height, newConeItem.radius);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IResultService resultService { get; set; }
    }
}
#pragma warning restore 1591