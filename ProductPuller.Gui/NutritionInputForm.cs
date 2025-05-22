using System;

namespace ProductPuller.Gui {
    public partial class NutritionInputForm : Form {
        public float[] Inputs { get; set; }
        public bool DialogClosed { get; private set; } = true;

        public NutritionInputForm(float[] inputs) {
            InitializeComponent();

            Inputs = inputs;

            KcalTextBox.Text = inputs[0].ToString();
            FatTextBox.Text = inputs[1].ToString();
            SaturatedFatTextBox.Text = inputs[2].ToString();
            CarbsTextBox.Text = inputs[3].ToString();
            SugarsTextBox.Text = inputs[4].ToString();
            ProteinTextBox.Text = inputs[5].ToString();
            SaltTextBox.Text = inputs[6].ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            try {
                Save();
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save() { 
            Inputs[0] = float.Parse(KcalTextBox.Text.Replace(".", ","));
            Inputs[1] = float.Parse(FatTextBox.Text.Replace(".", ","));
            Inputs[2] = float.Parse(SaturatedFatTextBox.Text.Replace(".", ","));
            Inputs[3] = float.Parse(CarbsTextBox.Text.Replace(".", ","));
            Inputs[4] = float.Parse(SugarsTextBox.Text.Replace(".", ","));
            Inputs[5] = float.Parse(ProteinTextBox.Text.Replace(".", ","));
            Inputs[6] = float.Parse(SaltTextBox.Text.Replace(".", ","));

            DialogClosed = false;
            Close();
        }
    }
}
