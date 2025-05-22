using System;

namespace ProductPuller {
    public class PageParser {
        public NutrientParser NutrientParser { get; set; } = new NutrientParser();

        public (string[], float[]) Parse(string text) {
            int count = 0;

            string[] lines = text.Split("\n", StringSplitOptions.TrimEntries);
            string[] output = new string[3];

            int nameIndex = lines.FindIndex("€ /pcs.");
            if (nameIndex == -1) {
                nameIndex = lines.FindIndex("€ /kg");
            }

            if (nameIndex == -1) {
                throw new Exception(lines[18] + "\n" + lines[19] + "\n" + lines[20]);
            }

            output[0] = lines[nameIndex - 3];
            output[1] = $"{lines[nameIndex - 2]}.{lines[nameIndex - 1]}";

            count++;

            int amountIndex = lines.FindIndex("Amount");
            if (amountIndex >= 0) {
                int remove = lines[amountIndex].EndsWith("kg") ? 3 : 2;
                output[2] = (float.Parse(lines[amountIndex + 1].Replace(".", ",").RemoveLast(remove)) * 1000).ToString();
            } else {
                output[2] = "1000";
            }

            count++;

            int nutritionIndex = lines.FindIndex("Nutrition	Amount per 100g/ml");
            if (nutritionIndex == -1) {
                throw new Exception("Nutrition error");
            }
            
            float[] values = NutrientParser.ParseNutritionFromText(string.Join("\n", lines, nutritionIndex + 1, 7));

            return (output, values);
        }
    }
}
