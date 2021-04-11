using Employee.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFuAgency.Binder
{
    public class CostumBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName);
            var result = value.FirstValue;
            if(!int.TryParse(result,out var id))
            {
                return Task.CompletedTask;
            }
            var model = new ImpiegatoModel()
            {
                Id = id,
                EntrepriseId = "entrid7895",
                Nome = "Antonio",
                Cognome = "Varisco",
                Qualifica = "Trader azionista",
                Telefono = "888656256"

            };
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
