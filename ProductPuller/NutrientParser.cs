using System;

namespace ProductPuller {
    public class NutrientParser {
        public float[] ParseNutritionFromText(string text) {
            string[] lines = text.Replace(".", ",").Split('\n');

            int startIndex = 0;
            if (text.StartsWith("Nutrition")) startIndex = 1;
            else if (text.StartsWith("\n")) startIndex = 2;

            return new float[] {
                float.Parse(lines[startIndex].Split("kJ/ ")[1].RemoveLast(5)),
                float.Parse(lines[startIndex + 1].Split('\t')[1].RemoveLast(2)),
                float.Parse(lines[startIndex + 2].Split('\t')[1].RemoveLast(2)),
                float.Parse(lines[startIndex + 3].Split('\t')[1].RemoveLast(2)),
                float.Parse(lines[startIndex + 4].Split('\t')[1].RemoveLast(2)),
                float.Parse(lines[startIndex + 5].Split('\t')[1].RemoveLast(2)),
                float.Parse(lines[startIndex + 6].Split('\t')[1].RemoveLast(2))
            };
        }
    }
}
