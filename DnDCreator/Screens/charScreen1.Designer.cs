namespace DnDCreator
{
    partial class charScreen1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.backgBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // raceBox
            // 
            this.raceBox.BackColor = System.Drawing.Color.Silver;
            this.raceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Items.AddRange(new object[] {
            "Gnome",
            "Elf",
            "Human",
            "Tiefling",
            "Half-Orc",
            "Half-Elf",
            "Dragonborn",
            "Dwarf",
            "Halfling "});
            this.raceBox.Location = new System.Drawing.Point(71, 111);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(194, 21);
            this.raceBox.TabIndex = 0;
            this.raceBox.Text = "RACE";
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.Silver;
            this.typeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Rouge",
            "Fighter",
            "Ranger",
            "Barbarian",
            "Warlock",
            "Paladin",
            "Monk ",
            "Bard",
            "Wizard",
            "Sorcerer ",
            "Druid ",
            "Cleric"});
            this.typeBox.Location = new System.Drawing.Point(71, 219);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(194, 21);
            this.typeBox.TabIndex = 1;
            this.typeBox.Text = "CLASS";
            // 
            // backgBox
            // 
            this.backgBox.BackColor = System.Drawing.Color.Silver;
            this.backgBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgBox.FormattingEnabled = true;
            this.backgBox.Items.AddRange(new object[] {
            "Acolyte ",
            "Charlatan ",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Gladiator ",
            "Guild Merchant",
            "Hermit ",
            "Knight",
            "Noble ",
            "Outlander",
            "Pirate",
            "Sage ",
            "Sailor ",
            "Soldier",
            "Urchin "});
            this.backgBox.Location = new System.Drawing.Point(71, 323);
            this.backgBox.Name = "backgBox";
            this.backgBox.Size = new System.Drawing.Size(194, 21);
            this.backgBox.TabIndex = 2;
            this.backgBox.Text = "BACKGROUND";
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Silver;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoLabel.Location = new System.Drawing.Point(358, 111);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(200, 233);
            this.infoLabel.TabIndex = 3;
            // 
            // charScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnDCreator.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.backgBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.raceBox);
            this.Name = "charScreen1";
            this.Size = new System.Drawing.Size(650, 459);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox backgBox;
        private System.Windows.Forms.Label infoLabel;
    }
}
