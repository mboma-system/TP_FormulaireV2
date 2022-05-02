using app_form_blazor.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_form_blazor.Pages
{
    public class FormulaireBase : ComponentBase
    {
        protected bool afficheCheck = false;

    public Utilisateur user = new ();

        protected override void OnInitialized()
        {

        }
        protected override void OnParametersSet()
        {

        }
        protected async Task Validate()
        {
            afficheCheck = true;
            await Task.CompletedTask;

        }


    }

}
