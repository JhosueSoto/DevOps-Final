// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Parcial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Parcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\jhosu\OneDrive\Desktop\Parcial\_Imports.razor"
using Parcial.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Registrar")]
    public partial class Registrar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "c:\Users\jhosu\OneDrive\Desktop\Parcial\Pages\Registrar.razor"
       
    public class api
    {
        public string Nombres { get; set; } = "";
        public string Apellido1 { get; set; } = "";
    }
    api datos = new api();
    string call = "";
    private async Task resultado()
    {
        datos = await http.GetJsonAsync<api>("https://api.adamix.net/apec/cedula/" + call);
    }
    string placa, modelo, marca, color, descripcion, lugar;
    bool dec = false;
    int id;
    void addpers()
    {
        if(dec==false)
        {
            var db = new DB();
            var carro = new vehiculo();
            var pers = new persona();

            carro.placa = placa;
            carro.modelo = modelo;
            carro.marca = marca;
            carro.color = color;
            carro.descripcion = descripcion;
            id = carro.vehiculoid;
            db.Add(carro);
            db.SaveChanges();

            pers.nombre = datos.Nombres;
            pers.apellido = datos.Apellido1;
            pers.lugar = lugar;
            db.Add(pers);
            db.SaveChanges();
        }
        else
        {
            var db = new DB();
            var pers = new persona();

            pers.nombre = datos.Nombres;
            pers.apellido = datos.Apellido1;
            pers.lugar = lugar;
            db.Add(pers);
            db.SaveChanges();
        }

    }
    void todo()
    {
        dec = true;
        var db = new DB();
        var carro = new vehiculo();

        carro.placa = placa;
        carro.modelo = modelo;
        carro.marca = marca;
        carro.color = color;
        carro.descripcion = descripcion;
        id = carro.vehiculoid;
        db.Add(carro);
        db.SaveChanges();

        do
        {
            var pers = new persona();

            pers.nombre = datos.Nombres;
            pers.apellido = datos.Apellido1;
            pers.lugar = lugar;
            db.Add(pers);
        } while (dec == false);
        db.SaveChanges();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
