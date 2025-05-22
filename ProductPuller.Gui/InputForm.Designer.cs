namespace ProductPuller.Gui {
    partial class InputForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LinkLabel = new System.Windows.Forms.Label();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NutritionLabel = new System.Windows.Forms.Label();
            this.NutritionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddedItemCountLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.IsVeganCheckBox = new System.Windows.Forms.CheckBox();
            this.IsGlutenFreeCheckBox = new System.Windows.Forms.CheckBox();
            this.IsDairyCheckBox = new System.Windows.Forms.CheckBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ManuallyEnterNutritionLink = new System.Windows.Forms.LinkLabel();
            this.ResetLink = new System.Windows.Forms.LinkLabel();
            this.HighlightedPageLabel = new System.Windows.Forms.Label();
            this.HighlightedPaheRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(12, 9);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(29, 15);
            this.LinkLabel.TabIndex = 0;
            this.LinkLabel.Text = "Link";
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(15, 25);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(339, 23);
            this.LinkTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 71);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(339, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(15, 119);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(339, 23);
            this.PriceTextBox.TabIndex = 5;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 103);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 15);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price";
            // 
            // NutritionLabel
            // 
            this.NutritionLabel.AutoSize = true;
            this.NutritionLabel.Location = new System.Drawing.Point(12, 199);
            this.NutritionLabel.Name = "NutritionLabel";
            this.NutritionLabel.Size = new System.Drawing.Size(55, 15);
            this.NutritionLabel.TabIndex = 8;
            this.NutritionLabel.Text = "Nutrition";
            // 
            // NutritionRichTextBox
            // 
            this.NutritionRichTextBox.Location = new System.Drawing.Point(15, 217);
            this.NutritionRichTextBox.Name = "NutritionRichTextBox";
            this.NutritionRichTextBox.Size = new System.Drawing.Size(339, 96);
            this.NutritionRichTextBox.TabIndex = 9;
            this.NutritionRichTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddedItemCountLabel
            // 
            this.AddedItemCountLabel.AutoSize = true;
            this.AddedItemCountLabel.Location = new System.Drawing.Point(149, 390);
            this.AddedItemCountLabel.Name = "AddedItemCountLabel";
            this.AddedItemCountLabel.Size = new System.Drawing.Size(81, 15);
            this.AddedItemCountLabel.TabIndex = 15;
            this.AddedItemCountLabel.Text = "0 items added";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(15, 385);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(128, 23);
            this.ExportButton.TabIndex = 14;
            this.ExportButton.Text = "Export to clipboard";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // IsVeganCheckBox
            // 
            this.IsVeganCheckBox.AutoSize = true;
            this.IsVeganCheckBox.Location = new System.Drawing.Point(265, 324);
            this.IsVeganCheckBox.Name = "IsVeganCheckBox";
            this.IsVeganCheckBox.Size = new System.Drawing.Size(69, 19);
            this.IsVeganCheckBox.TabIndex = 10;
            this.IsVeganCheckBox.Text = "Is vegan";
            this.IsVeganCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsGlutenFreeCheckBox
            // 
            this.IsGlutenFreeCheckBox.AutoSize = true;
            this.IsGlutenFreeCheckBox.Checked = true;
            this.IsGlutenFreeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsGlutenFreeCheckBox.Location = new System.Drawing.Point(265, 345);
            this.IsGlutenFreeCheckBox.Name = "IsGlutenFreeCheckBox";
            this.IsGlutenFreeCheckBox.Size = new System.Drawing.Size(94, 19);
            this.IsGlutenFreeCheckBox.TabIndex = 11;
            this.IsGlutenFreeCheckBox.Text = "Is gluten free";
            this.IsGlutenFreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsDairyCheckBox
            // 
            this.IsDairyCheckBox.AutoSize = true;
            this.IsDairyCheckBox.Location = new System.Drawing.Point(265, 366);
            this.IsDairyCheckBox.Name = "IsDairyCheckBox";
            this.IsDairyCheckBox.Size = new System.Drawing.Size(63, 19);
            this.IsDairyCheckBox.TabIndex = 12;
            this.IsDairyCheckBox.Text = "Is dairy";
            this.IsDairyCheckBox.UseVisualStyleBackColor = true;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(15, 165);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(339, 23);
            this.WeightTextBox.TabIndex = 7;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(12, 149);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(45, 15);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight";
            // 
            // ManuallyEnterNutritionLink
            // 
            this.ManuallyEnterNutritionLink.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.ManuallyEnterNutritionLink.AutoSize = true;
            this.ManuallyEnterNutritionLink.LinkColor = System.Drawing.Color.DimGray;
            this.ManuallyEnterNutritionLink.Location = new System.Drawing.Point(221, 199);
            this.ManuallyEnterNutritionLink.Name = "ManuallyEnterNutritionLink";
            this.ManuallyEnterNutritionLink.Size = new System.Drawing.Size(135, 15);
            this.ManuallyEnterNutritionLink.TabIndex = 16;
            this.ManuallyEnterNutritionLink.TabStop = true;
            this.ManuallyEnterNutritionLink.Text = "Manually enter nutrition";
            this.ManuallyEnterNutritionLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.ManuallyEnterNutritionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManuallyEnterNutritionLink_LinkClicked);
            // 
            // ResetLink
            // 
            this.ResetLink.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.ResetLink.AutoSize = true;
            this.ResetLink.LinkColor = System.Drawing.Color.DimGray;
            this.ResetLink.Location = new System.Drawing.Point(169, 199);
            this.ResetLink.Name = "ResetLink";
            this.ResetLink.Size = new System.Drawing.Size(35, 15);
            this.ResetLink.TabIndex = 17;
            this.ResetLink.TabStop = true;
            this.ResetLink.Text = "Reset";
            this.ResetLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.ResetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetLink_LinkClicked);
            // 
            // HighlightedPageLabel
            // 
            this.HighlightedPageLabel.AutoSize = true;
            this.HighlightedPageLabel.Location = new System.Drawing.Point(368, 8);
            this.HighlightedPageLabel.Name = "HighlightedPageLabel";
            this.HighlightedPageLabel.Size = new System.Drawing.Size(128, 15);
            this.HighlightedPageLabel.TabIndex = 18;
            this.HighlightedPageLabel.Text = "Copy highlighted page";
            // 
            // HighlightedPaheRichTextBox
            // 
            this.HighlightedPaheRichTextBox.Location = new System.Drawing.Point(372, 25);
            this.HighlightedPaheRichTextBox.Name = "HighlightedPaheRichTextBox";
            this.HighlightedPaheRichTextBox.Size = new System.Drawing.Size(339, 163);
            this.HighlightedPaheRichTextBox.TabIndex = 19;
            this.HighlightedPaheRichTextBox.Text = "";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(372, 199);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 20;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 424);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.HighlightedPaheRichTextBox);
            this.Controls.Add(this.HighlightedPageLabel);
            this.Controls.Add(this.ResetLink);
            this.Controls.Add(this.ManuallyEnterNutritionLink);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.IsDairyCheckBox);
            this.Controls.Add(this.IsGlutenFreeCheckBox);
            this.Controls.Add(this.IsVeganCheckBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.AddedItemCountLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NutritionRichTextBox);
            this.Controls.Add(this.NutritionLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.LinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LinkLabel;
        private TextBox LinkTextBox;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private Label NutritionLabel;
        private RichTextBox NutritionRichTextBox;
        private Button AddButton;
        private Label AddedItemCountLabel;
        private Button ExportButton;
        private CheckBox IsVeganCheckBox;
        private CheckBox IsGlutenFreeCheckBox;
        private CheckBox IsDairyCheckBox;
        private TextBox WeightTextBox;
        private Label WeightLabel;
        private LinkLabel ManuallyEnterNutritionLink;
        private LinkLabel ResetLink;
        private Label HighlightedPageLabel;
        private RichTextBox HighlightedPaheRichTextBox;
        private Button ParseButton;
    }
}