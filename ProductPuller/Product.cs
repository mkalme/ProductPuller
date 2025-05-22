using System;

namespace ProductPuller {
    public class Product {
        public string Name { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public int WeightInGrams { get; set; } = 0;

        public float Kcal { get; set; } = 0;
        public float Fat { get; set; } = 0;
        public float SaturatedFat { get; set; } = 0;
        public float Carbs { get; set; } = 0;
        public float Sugars { get; set; } = 0;
        public float Protein { get; set; } = 0;
        public float Salt { get; set; } = 0;

        public bool IsVegan { get; set; } = false;
        public bool IsGlutenFree { get; set; } = false;
        public bool IsDairy { get; set; } = false;

        public void SetNutritionFromArray(float[] array) {
            Kcal = array[0];
            Fat = array[1];
            SaturatedFat = array[2];
            Carbs = array[3];
            Sugars = array[4];
            Protein = array[5];
            Salt = array[6];
        }
    }
}
