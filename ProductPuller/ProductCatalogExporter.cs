using System;
using Newtonsoft.Json.Linq;

namespace ProductPuller {
    public class ProductCatalogExporter {
        public string Export(IEnumerable<Product> products) {
            JArray array = new JArray();

            foreach (Product product in products) { 
                array.Add(CreateProductObject(product));
            }

            return array.ToString();
        }

        private static JObject CreateProductObject(Product product) { 
            JObject output = new JObject();

            output.Add("Name", product.Name);
            output.Add("Category", product.Category);
            output.Add("Type", product.Type);

            output.Add("TotalWeightInGrams", product.WeightInGrams);
            output.Add("Cost", product.Price);
            output.Add("Link", product.Link);

            JArray nutritionArray = new JArray() {
                CreateJObject("kcal", product.Kcal),
                CreateJObject("fat", product.Fat ),
                CreateJObject("saturated_fat", product.SaturatedFat ),
                CreateJObject("carbs", product.Carbs ),
                CreateJObject("sugars", product.Sugars),
                CreateJObject("protein", product.Protein),
                CreateJObject("salt", product.Salt)
            };
            output.Add("NutritionalComposition", nutritionArray);

            output.Add("IsVegan", product.IsVegan);
            output.Add("IsGlutenFree", product.IsGlutenFree);
            output.Add("IsDairy", product.IsDairy);

            return output;
        }
        private static JObject CreateJObject(string name, JToken value) {
            JObject output = new JObject();

            output.Add(name, value);

            return output;
        }
    }
}
