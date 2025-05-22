using System;

namespace ProductPuller.Gui {
    public partial class InputForm : Form {
        public List<Product> Products { get; set; } = new List<Product>();
        
        private ProductCatalogExporter _exporter = new ProductCatalogExporter();
        private PageParser _pageParser = new PageParser();

        private float[] _manuallyEnteredNutrition = new float[7];
        private bool _manuallyEnterNutrition = false;

        public InputForm() {
            InitializeComponent();
        }

        private void ManuallyEnterNutritionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            NutritionInputForm form = new NutritionInputForm(_manuallyEnteredNutrition);
            form.ShowDialog();
            if (form.DialogClosed) return;

            _manuallyEnteredNutrition = form.Inputs;
            _manuallyEnterNutrition = true;
        }
        private void ResetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            _manuallyEnterNutrition = false;
            _manuallyEnteredNutrition = new float[7];
        }

        private void ParseButton_Click(object sender, EventArgs e) {
            (string[], float[]) values;
            try {
                values = _pageParser.Parse(HighlightedPaheRichTextBox.Text);
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NameTextBox.Text = values.Item1[0];
            PriceTextBox.Text = values.Item1[1];
            WeightTextBox.Text = values.Item1[2];

            _manuallyEnterNutrition = true;
            _manuallyEnteredNutrition = values.Item2;
        }

        private void AddButton_Click(object sender, EventArgs e) {
            try {
                Add();
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add() {
            Product product = new Product() {
                Link = LinkTextBox.Text,
                Name = NameTextBox.Text,
                Price = decimal.Parse(PriceTextBox.Text.Replace(".", ",")),
                Type = "StoreBought",
                WeightInGrams = int.Parse(WeightTextBox.Text),
                IsVegan = IsVeganCheckBox.Checked,
                IsGlutenFree = IsGlutenFreeCheckBox.Checked,
                IsDairy = IsDairyCheckBox.Checked
            };

            if (_manuallyEnterNutrition) {
                product.SetNutritionFromArray(_manuallyEnteredNutrition);
            } else {
                product.SetNutritionFromArray(_pageParser.NutrientParser.ParseNutritionFromText(NutritionRichTextBox.Text));
            }

            Products.Add(product);

            LinkTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            PriceTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            NutritionRichTextBox.Text = string.Empty;
            IsVeganCheckBox.Checked = false;
            IsDairyCheckBox.Checked = false;

            HighlightedPaheRichTextBox.Text = string.Empty;

            _manuallyEnterNutrition = false;
            _manuallyEnteredNutrition = new float[7];

            AddedItemCountLabel.Text = $"{Products.Count} items added";
        }

        private void ExportButton_Click(object sender, EventArgs e) {
            Clipboard.SetText(_exporter.Export(Products));
        }
    }
}