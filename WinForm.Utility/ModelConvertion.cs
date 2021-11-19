using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace WinForm.Utility
{
    public static class ModelConvertion
    {
        public static TModel DataRowToModel<TModel>(this DataRow dataRow)
        {
            Type modelType = typeof(TModel);
            TModel model = (TModel)Activator.CreateInstance(modelType);
            foreach (var prop in modelType.GetProperties())
            {
                prop.SetValue(model, dataRow[prop.Name]);
            }
            return model;
        }
    }
}
