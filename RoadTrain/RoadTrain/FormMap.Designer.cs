namespace RoadTrain
{
    partial class FormMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStripRoadTrain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBodyColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxRoadTrain = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.buttonCreateModif = new System.Windows.Forms.Button();
            this.statusStripRoadTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoadTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripRoadTrain
            // 
            this.statusStripRoadTrain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripRoadTrain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSpeed,
            this.toolStripStatusLabelWeight,
            this.toolStripStatusLabelBodyColor});
            this.statusStripRoadTrain.Location = new System.Drawing.Point(0, 427);
            this.statusStripRoadTrain.Name = "statusStripRoadTrain";
            this.statusStripRoadTrain.Size = new System.Drawing.Size(882, 26);
            this.statusStripRoadTrain.TabIndex = 0;
            this.statusStripRoadTrain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSpeed
            // 
            this.toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            this.toolStripStatusLabelSpeed.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabelSpeed.Text = "Скорость:";
            // 
            // toolStripStatusLabelWeight
            // 
            this.toolStripStatusLabelWeight.Name = "toolStripStatusLabelWeight";
            this.toolStripStatusLabelWeight.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabelWeight.Text = "Вес:";
            // 
            // toolStripStatusLabelBodyColor
            // 
            this.toolStripStatusLabelBodyColor.Name = "toolStripStatusLabelBodyColor";
            this.toolStripStatusLabelBodyColor.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabelBodyColor.Text = "Цвет";
            // 
            // pictureBoxRoadTrain
            // 
            this.pictureBoxRoadTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRoadTrain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRoadTrain.Name = "pictureBoxRoadTrain";
            this.pictureBoxRoadTrain.Size = new System.Drawing.Size(882, 427);
            this.pictureBoxRoadTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRoadTrain.TabIndex = 1;
            this.pictureBoxRoadTrain.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Location = new System.Drawing.Point(23, 383);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(94, 29);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::RoadTrain.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(771, 383);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::RoadTrain.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(807, 383);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::RoadTrain.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(807, 347);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::RoadTrain.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(840, 384);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта",
            "Дорога"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(23, 12);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSelectorMap.TabIndex = 10;
            this.comboBoxSelectorMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectorMap_SelectedIndexChanged);
            // 
            // buttonCreateModif
            // 
            this.buttonCreateModif.Location = new System.Drawing.Point(145, 383);
            this.buttonCreateModif.Name = "buttonCreateModif";
            this.buttonCreateModif.Size = new System.Drawing.Size(129, 29);
            this.buttonCreateModif.TabIndex = 11;
            this.buttonCreateModif.Text = "Модификация";
            this.buttonCreateModif.UseVisualStyleBackColor = true;
            this.buttonCreateModif.Click += new System.EventHandler(this.ButtonCreateModif_Click);
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonCreateModif);
            this.Controls.Add(this.comboBoxSelectorMap);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxRoadTrain);
            this.Controls.Add(this.statusStripRoadTrain);
            this.Name = "FormMap";
            this.Text = "Карта";
            this.statusStripRoadTrain.ResumeLayout(false);
            this.statusStripRoadTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoadTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStripRoadTrain;
        private ToolStripStatusLabel toolStripStatusLabelSpeed;
        private ToolStripStatusLabel toolStripStatusLabelWeight;
        private ToolStripStatusLabel toolStripStatusLabelBodyColor;
        private PictureBox pictureBoxRoadTrain;
        private Button buttonCreate;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonUp;
        private Button buttonRight;
        private ComboBox comboBoxSelectorMap;
        private Button buttonCreateModif;
    }
}