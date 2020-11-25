
namespace Programming_Exercise_5
{
    partial class luckyNumberFinderForm
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
            this.luckyButton = new System.Windows.Forms.Button();
            this.clrDropDownList = new System.Windows.Forms.ComboBox();
            this.shapeDropDownList = new System.Windows.Forms.ComboBox();
            this.clrLabel = new System.Windows.Forms.Label();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.multiplierDescrLabel = new System.Windows.Forms.Label();
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // luckyButton
            // 
            this.luckyButton.Location = new System.Drawing.Point(223, 311);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.Size = new System.Drawing.Size(332, 89);
            this.luckyButton.TabIndex = 0;
            this.luckyButton.Text = "&Let\'s Get Lucky!";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // clrDropDownList
            // 
            this.clrDropDownList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clrDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clrDropDownList.FormattingEnabled = true;
            this.clrDropDownList.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Orange",
            "Green"});
            this.clrDropDownList.Location = new System.Drawing.Point(334, 85);
            this.clrDropDownList.Name = "clrDropDownList";
            this.clrDropDownList.Size = new System.Drawing.Size(121, 21);
            this.clrDropDownList.TabIndex = 1;
            this.clrDropDownList.SelectedIndexChanged += new System.EventHandler(this.clrDropDownList_SelectedIndexChanged);
            // 
            // shapeDropDownList
            // 
            this.shapeDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeDropDownList.FormattingEnabled = true;
            this.shapeDropDownList.Items.AddRange(new object[] {
            "Triangle",
            "Square",
            "Circle",
            "Octagon"});
            this.shapeDropDownList.Location = new System.Drawing.Point(334, 136);
            this.shapeDropDownList.Name = "shapeDropDownList";
            this.shapeDropDownList.Size = new System.Drawing.Size(121, 21);
            this.shapeDropDownList.TabIndex = 2;
            this.shapeDropDownList.SelectedIndexChanged += new System.EventHandler(this.shapeDropDownList_SelectedIndexChanged);
            // 
            // clrLabel
            // 
            this.clrLabel.AutoSize = true;
            this.clrLabel.Location = new System.Drawing.Point(229, 88);
            this.clrLabel.Name = "clrLabel";
            this.clrLabel.Size = new System.Drawing.Size(81, 13);
            this.clrLabel.TabIndex = 3;
            this.clrLabel.Text = "Choose a color:";
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(223, 139);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(87, 13);
            this.shapeLabel.TabIndex = 4;
            this.shapeLabel.Text = "Choose a shape:";
            // 
            // multiplierDescrLabel
            // 
            this.multiplierDescrLabel.AutoSize = true;
            this.multiplierDescrLabel.Location = new System.Drawing.Point(235, 239);
            this.multiplierDescrLabel.Name = "multiplierDescrLabel";
            this.multiplierDescrLabel.Size = new System.Drawing.Size(75, 13);
            this.multiplierDescrLabel.TabIndex = 6;
            this.multiplierDescrLabel.Text = "Your multiplier:";
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplierLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiplierLabel.Location = new System.Drawing.Point(334, 235);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(121, 21);
            this.multiplierLabel.TabIndex = 8;
            this.multiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(217, 190);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(93, 13);
            this.numberLabel.TabIndex = 9;
            this.numberLabel.Text = "Choose a number:";
            // 
            // numberDropDownList
            // 
            this.numberDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberDropDownList.FormattingEnabled = true;
            this.numberDropDownList.Items.AddRange(new object[] {
            "7",
            "11",
            "13",
            "21",
            "42"});
            this.numberDropDownList.Location = new System.Drawing.Point(334, 187);
            this.numberDropDownList.Name = "numberDropDownList";
            this.numberDropDownList.Size = new System.Drawing.Size(121, 21);
            this.numberDropDownList.TabIndex = 10;
            this.numberDropDownList.SelectedIndexChanged += new System.EventHandler(this.numberDropDownList_SelectedIndexChanged);
            // 
            // luckyNumberFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberDropDownList);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.multiplierLabel);
            this.Controls.Add(this.multiplierDescrLabel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.clrLabel);
            this.Controls.Add(this.shapeDropDownList);
            this.Controls.Add(this.clrDropDownList);
            this.Controls.Add(this.luckyButton);
            this.Name = "luckyNumberFinderForm";
            this.Text = "Lucky Number Finder";
            this.Load += new System.EventHandler(this.luckyNumberFinderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luckyButton;
        private System.Windows.Forms.ComboBox clrDropDownList;
        private System.Windows.Forms.ComboBox shapeDropDownList;
        private System.Windows.Forms.Label clrLabel;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Label multiplierDescrLabel;
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ComboBox numberDropDownList;
    }
}

