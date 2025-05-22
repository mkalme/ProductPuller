using System.Drawing;
using System.Drawing.Imaging;
using ProductPullerAutomatic;

namespace ProductPuller.AutomaticGui {
    public partial class ProductPullerForm : Form {
        public ProductScreenPuller ProductScreenPuller { get; set; } = new ProductScreenPuller();

        public List<Product> Products { get; set; } = new List<Product>();
        private ProductCatalogExporter _exporter = new ProductCatalogExporter();

        public ProductPullerForm() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) {
            Products.AddRange(ProductScreenPuller.PullProducts());

            AddedItemCountLabel.Text = $"{Products.Count} items added";

            Export();
        }

        private void ExportButton_Click(object sender, EventArgs e) {
            Export();
        }

        private void Export() {
            Clipboard.SetText(_exporter.Export(Products));
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            Products.Clear();

            AddedItemCountLabel.Text = $"{Products.Count} items added";
        }
    }
}