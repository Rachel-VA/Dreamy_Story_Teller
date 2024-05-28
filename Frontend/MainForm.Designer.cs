namespace StoryGeneratorFrontEnd
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private bool _isSynthesizerDisposed = false;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                // Disposing the speech synthesizer asynchronously
                if (!_isSynthesizerDisposed)
                {
                    _isSynthesizerDisposed = true;
                    DisposeSynthesizerAsync().GetAwaiter().GetResult();
                }
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainFormTitleLabel = new Label();
            buttonGenerateStory = new Button();
            StoryGeneratorRichBox = new RichTextBox();
            promptRichBox = new RichTextBox();
            MainPanel = new Panel();
            hScrollBar1 = new HScrollBar();
            pictureBox1 = new PictureBox();
            InstructionLabel = new Label();
            InstructionRichTextBox = new RichTextBox();
            genreComboBox = new ComboBox();
            ReadStoryButton = new Button();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainFormTitleLabel
            // 
            mainFormTitleLabel.AutoSize = true;
            mainFormTitleLabel.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormTitleLabel.ForeColor = Color.DarkCyan;
            mainFormTitleLabel.Location = new Point(214, 9);
            mainFormTitleLabel.Name = "mainFormTitleLabel";
            mainFormTitleLabel.Size = new Size(1011, 57);
            mainFormTitleLabel.TabIndex = 1;
            mainFormTitleLabel.Text = "Welcome To The Dreamy Story Teller ";
            // 
            // buttonGenerateStory
            // 
            buttonGenerateStory.BackColor = Color.DarkOrchid;
            buttonGenerateStory.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateStory.ForeColor = Color.LightGray;
            buttonGenerateStory.Location = new Point(1278, 586);
            buttonGenerateStory.Name = "buttonGenerateStory";
            buttonGenerateStory.Size = new Size(240, 117);
            buttonGenerateStory.TabIndex = 2;
            buttonGenerateStory.Text = "Generate Story";
            buttonGenerateStory.UseVisualStyleBackColor = false;
            buttonGenerateStory.Click += buttonGenerateStory_Click;
            // 
            // StoryGeneratorRichBox
            // 
            StoryGeneratorRichBox.Location = new Point(496, 0);
            StoryGeneratorRichBox.Name = "StoryGeneratorRichBox";
            StoryGeneratorRichBox.Size = new Size(1022, 480);
            StoryGeneratorRichBox.TabIndex = 3;
            StoryGeneratorRichBox.Text = "";
            // 
            // promptRichBox
            // 
            promptRichBox.Location = new Point(496, 586);
            promptRichBox.Name = "promptRichBox";
            promptRichBox.Size = new Size(776, 117);
            promptRichBox.TabIndex = 4;
            promptRichBox.Text = "";
            promptRichBox.TextChanged += promptRichBox_TextChanged;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(ReadStoryButton);
            MainPanel.Controls.Add(hScrollBar1);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(InstructionLabel);
            MainPanel.Controls.Add(InstructionRichTextBox);
            MainPanel.Controls.Add(StoryGeneratorRichBox);
            MainPanel.Controls.Add(buttonGenerateStory);
            MainPanel.Controls.Add(promptRichBox);
            MainPanel.Controls.Add(genreComboBox);
            MainPanel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainPanel.Location = new Point(1, 86);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1540, 762);
            MainPanel.TabIndex = 5;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(1530, 51);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 17);
            hScrollBar1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 415);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.BackColor = Color.Teal;
            InstructionLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstructionLabel.ForeColor = Color.Lavender;
            InstructionLabel.Location = new Point(138, 421);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(218, 47);
            InstructionLabel.TabIndex = 6;
            InstructionLabel.Text = "Instruction: ";
            // 
            // InstructionRichTextBox
            // 
            InstructionRichTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstructionRichTextBox.Location = new Point(3, 464);
            InstructionRichTextBox.Name = "InstructionRichTextBox";
            InstructionRichTextBox.Size = new Size(487, 239);
            InstructionRichTextBox.TabIndex = 5;
            InstructionRichTextBox.Text = resources.GetString("InstructionRichTextBox.Text");
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Fantasy", "Sci-Fi", "Mystery", "Adventure" });
            genreComboBox.Location = new Point(613, 513);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(222, 38);
            genreComboBox.TabIndex = 9;
            genreComboBox.Text = "Select a Genre";
            // 
            // ReadStoryButton
            // 
            ReadStoryButton.Location = new Point(942, 513);
            ReadStoryButton.Name = "ReadStoryButton";
            ReadStoryButton.Size = new Size(179, 37);
            ReadStoryButton.TabIndex = 10;
            ReadStoryButton.Text = "Read Story";
            ReadStoryButton.UseVisualStyleBackColor = true;
            ReadStoryButton.Click += ReadStoryButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 818);
            Controls.Add(MainPanel);
            Controls.Add(mainFormTitleLabel);
            Name = "MainForm";
            Text = "Dreamy Story Teller App";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainFormTitleLabel;
        private Button buttonGenerateStory;
        private RichTextBox StoryGeneratorRichBox;
        private RichTextBox promptRichBox;
        private Panel MainPanel;
        private Label InstructionLabel;
        private RichTextBox InstructionRichTextBox;
        private PictureBox pictureBox1;
        private HScrollBar hScrollBar1;
        private ComboBox genreComboBox;
        private Button ReadStoryButton;
    }
}
