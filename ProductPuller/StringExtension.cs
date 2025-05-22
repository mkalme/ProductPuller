using System;

namespace ProductPuller {
    public static class StringExtension {
        public static string RemoveLast(this string text, int count) { 
            return text.Substring(0, text.Length - count);
        }

        public static int FindIndex(this string[] lines, string text) {
            for (int i = 0; i < lines.Length; i++) {
                if (lines[i].Equals(text, StringComparison.OrdinalIgnoreCase)) return i;
            }

            return -1;
        }
    }
}
