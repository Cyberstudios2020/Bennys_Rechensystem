
namespace Benny_s_App
{
    partial class Bennys_App
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbSelectExtras = new System.Windows.Forms.ComboBox();
            this.TxtListPrice = new System.Windows.Forms.TextBox();
            this.CbSelectDesign = new System.Windows.Forms.ComboBox();
            this.CbSelectPerformance = new System.Windows.Forms.ComboBox();
            this.DudSalePercent = new System.Windows.Forms.DomainUpDown();
            this.LblPercentLabel = new System.Windows.Forms.Label();
            this.CmdAddPart = new System.Windows.Forms.Button();
            this.LblPriceResult = new System.Windows.Forms.Label();
            this.LblPriceScineLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.LblCustomerLabel = new System.Windows.Forms.Label();
            this.LblPlateLabel = new System.Windows.Forms.Label();
            this.CbCustomers = new System.Windows.Forms.ComboBox();
            this.CbCustomersPlate = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuAnlegenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designEinstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxMustermannToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manfredFernandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdNewResult = new System.Windows.Forms.Button();
            this.LblWorkerLabel = new System.Windows.Forms.Label();
            this.LblWorkerName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbSelectExtras
            // 
            this.CbSelectExtras.FormattingEnabled = true;
            this.CbSelectExtras.Items.AddRange(new object[] {
            "",
            "Reperatur",
            "Repair-Kit",
            "Sonderleistung",
            "..."});
            this.CbSelectExtras.Location = new System.Drawing.Point(12, 167);
            this.CbSelectExtras.Name = "CbSelectExtras";
            this.CbSelectExtras.Size = new System.Drawing.Size(148, 21);
            this.CbSelectExtras.TabIndex = 3;
            // 
            // TxtListPrice
            // 
            this.TxtListPrice.Location = new System.Drawing.Point(12, 207);
            this.TxtListPrice.Name = "TxtListPrice";
            this.TxtListPrice.Size = new System.Drawing.Size(148, 20);
            this.TxtListPrice.TabIndex = 4;
            // 
            // CbSelectDesign
            // 
            this.CbSelectDesign.FormattingEnabled = true;
            this.CbSelectDesign.Items.AddRange(new object[] {
            "",
            "Scheibentönung",
            "Xenon Scheinwerfer",
            "Primärlack",
            "Sekundärlack",
            "Pearlglanz",
            "Kennzeichen",
            "Auspuff",
            "Stoßstange Vorne",
            "Stoßstange Hinten",
            "Seitenschweller",
            "Motorhaube",
            "Käfig",
            "..."});
            this.CbSelectDesign.Location = new System.Drawing.Point(12, 129);
            this.CbSelectDesign.Name = "CbSelectDesign";
            this.CbSelectDesign.Size = new System.Drawing.Size(148, 21);
            this.CbSelectDesign.TabIndex = 2;
            // 
            // CbSelectPerformance
            // 
            this.CbSelectPerformance.FormattingEnabled = true;
            this.CbSelectPerformance.Items.AddRange(new object[] {
            "",
            "Bremsen",
            "Federn",
            "Getriebe",
            "Motor",
            "Panzerung",
            "Turbolader"});
            this.CbSelectPerformance.Location = new System.Drawing.Point(12, 92);
            this.CbSelectPerformance.Name = "CbSelectPerformance";
            this.CbSelectPerformance.Size = new System.Drawing.Size(148, 21);
            this.CbSelectPerformance.TabIndex = 1;
            // 
            // DudSalePercent
            // 
            this.DudSalePercent.AllowDrop = true;
            this.DudSalePercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DudSalePercent.Items.Add("0");
            this.DudSalePercent.Items.Add("5");
            this.DudSalePercent.Items.Add("10");
            this.DudSalePercent.Items.Add("15");
            this.DudSalePercent.Items.Add("20");
            this.DudSalePercent.Items.Add("25");
            this.DudSalePercent.Items.Add("30");
            this.DudSalePercent.Items.Add("35");
            this.DudSalePercent.Items.Add("40");
            this.DudSalePercent.Items.Add("45");
            this.DudSalePercent.Items.Add("50");
            this.DudSalePercent.Items.Add("55");
            this.DudSalePercent.Items.Add("60");
            this.DudSalePercent.Items.Add("65");
            this.DudSalePercent.Items.Add("70");
            this.DudSalePercent.Items.Add("75");
            this.DudSalePercent.Items.Add("80");
            this.DudSalePercent.Items.Add("85");
            this.DudSalePercent.Items.Add("90");
            this.DudSalePercent.Items.Add("95");
            this.DudSalePercent.Items.Add("100");
            this.DudSalePercent.Location = new System.Drawing.Point(12, 242);
            this.DudSalePercent.Name = "DudSalePercent";
            this.DudSalePercent.ReadOnly = true;
            this.DudSalePercent.Size = new System.Drawing.Size(53, 20);
            this.DudSalePercent.TabIndex = 5;
            this.DudSalePercent.Text = "20";
            this.DudSalePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPercentLabel
            // 
            this.LblPercentLabel.AutoSize = true;
            this.LblPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercentLabel.Location = new System.Drawing.Point(67, 242);
            this.LblPercentLabel.Name = "LblPercentLabel";
            this.LblPercentLabel.Size = new System.Drawing.Size(23, 20);
            this.LblPercentLabel.TabIndex = 11;
            this.LblPercentLabel.Text = "%";
            // 
            // CmdAddPart
            // 
            this.CmdAddPart.Location = new System.Drawing.Point(12, 276);
            this.CmdAddPart.Name = "CmdAddPart";
            this.CmdAddPart.Size = new System.Drawing.Size(75, 23);
            this.CmdAddPart.TabIndex = 12;
            this.CmdAddPart.Text = "Hinzufügen";
            this.CmdAddPart.UseVisualStyleBackColor = true;
            this.CmdAddPart.Click += new System.EventHandler(this.CmdAddPart_Click);
            // 
            // LblPriceResult
            // 
            this.LblPriceResult.AutoSize = true;
            this.LblPriceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriceResult.Location = new System.Drawing.Point(184, 279);
            this.LblPriceResult.Name = "LblPriceResult";
            this.LblPriceResult.Size = new System.Drawing.Size(0, 20);
            this.LblPriceResult.TabIndex = 13;
            // 
            // LblPriceScineLabel
            // 
            this.LblPriceScineLabel.AutoSize = true;
            this.LblPriceScineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriceScineLabel.Location = new System.Drawing.Point(164, 207);
            this.LblPriceScineLabel.Name = "LblPriceScineLabel";
            this.LblPriceScineLabel.Size = new System.Drawing.Size(18, 20);
            this.LblPriceScineLabel.TabIndex = 14;
            this.LblPriceScineLabel.Text = "$";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(188, 92);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(238, 184);
            this.checkedListBox1.TabIndex = 7;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(351, 305);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(75, 23);
            this.CmdClose.TabIndex = 16;
            this.CmdClose.Text = "Schließen";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(93, 276);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 17;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblCustomerLabel
            // 
            this.LblCustomerLabel.AutoSize = true;
            this.LblCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerLabel.Location = new System.Drawing.Point(12, 27);
            this.LblCustomerLabel.Name = "LblCustomerLabel";
            this.LblCustomerLabel.Size = new System.Drawing.Size(59, 20);
            this.LblCustomerLabel.TabIndex = 20;
            this.LblCustomerLabel.Text = "Kunde:";
            // 
            // LblPlateLabel
            // 
            this.LblPlateLabel.AutoSize = true;
            this.LblPlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlateLabel.Location = new System.Drawing.Point(12, 55);
            this.LblPlateLabel.Name = "LblPlateLabel";
            this.LblPlateLabel.Size = new System.Drawing.Size(105, 20);
            this.LblPlateLabel.TabIndex = 21;
            this.LblPlateLabel.Text = "Kennzeichen:";
            // 
            // CbCustomers
            // 
            this.CbCustomers.FormattingEnabled = true;
            this.CbCustomers.Items.AddRange(new object[] {
            "",
            "Kalle Schuber",
            "Max Mustermann",
            "Cliff Berger",
            "Manfred Fernandes",
            "..."});
            this.CbCustomers.Location = new System.Drawing.Point(77, 27);
            this.CbCustomers.Name = "CbCustomers";
            this.CbCustomers.Size = new System.Drawing.Size(151, 21);
            this.CbCustomers.TabIndex = 22;
            // 
            // CbCustomersPlate
            // 
            this.CbCustomersPlate.FormattingEnabled = true;
            this.CbCustomersPlate.Items.AddRange(new object[] {
            "",
            "DERKALLE",
            "BIGDON1",
            "BIGDON2",
            "..."});
            this.CbCustomersPlate.Location = new System.Drawing.Point(123, 54);
            this.CbCustomersPlate.Name = "CbCustomersPlate";
            this.CbCustomersPlate.Size = new System.Drawing.Size(105, 21);
            this.CbCustomersPlate.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.einstellungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitarbeiterToolStripMenuItem,
            this.designEinstellungToolStripMenuItem,
            this.kundenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem1.Text = "Unternehmen";
            // 
            // mitarbeiterToolStripMenuItem
            // 
            this.mitarbeiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuAnlegenToolStripMenuItem1,
            this.entfernenToolStripMenuItem});
            this.mitarbeiterToolStripMenuItem.Name = "mitarbeiterToolStripMenuItem";
            this.mitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mitarbeiterToolStripMenuItem.Text = "Mitarbeiter";
            // 
            // neuAnlegenToolStripMenuItem1
            // 
            this.neuAnlegenToolStripMenuItem1.Name = "neuAnlegenToolStripMenuItem1";
            this.neuAnlegenToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.neuAnlegenToolStripMenuItem1.Text = "Neu Anlegen";
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.entfernenToolStripMenuItem.Text = "Alle Anzeigen";
            // 
            // designEinstellungToolStripMenuItem
            // 
            this.designEinstellungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxMustermannToolStripMenuItem,
            this.manfredFernandesToolStripMenuItem});
            this.designEinstellungToolStripMenuItem.Name = "designEinstellungToolStripMenuItem";
            this.designEinstellungToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.designEinstellungToolStripMenuItem.Text = "Benutzer Auswahl";
            // 
            // maxMustermannToolStripMenuItem
            // 
            this.maxMustermannToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entfernenToolStripMenuItem1});
            this.maxMustermannToolStripMenuItem.Name = "maxMustermannToolStripMenuItem";
            this.maxMustermannToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.maxMustermannToolStripMenuItem.Text = "Max Mustermann";
            this.maxMustermannToolStripMenuItem.Click += new System.EventHandler(this.maxMustermannToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem1
            // 
            this.entfernenToolStripMenuItem1.Name = "entfernenToolStripMenuItem1";
            this.entfernenToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.entfernenToolStripMenuItem1.Text = "Entfernen";
            // 
            // manfredFernandesToolStripMenuItem
            // 
            this.manfredFernandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entfernenToolStripMenuItem2});
            this.manfredFernandesToolStripMenuItem.Name = "manfredFernandesToolStripMenuItem";
            this.manfredFernandesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manfredFernandesToolStripMenuItem.Text = "Manfred Fernandes";
            this.manfredFernandesToolStripMenuItem.Click += new System.EventHandler(this.manfredFernandesToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem2
            // 
            this.entfernenToolStripMenuItem2.Name = "entfernenToolStripMenuItem2";
            this.entfernenToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.entfernenToolStripMenuItem2.Text = "Entfernen";
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuAnlegenToolStripMenuItem,
            this.kundenAnzeigenToolStripMenuItem,
            this.kundenLöschenToolStripMenuItem});
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kundenToolStripMenuItem.Text = "Kunden";
            // 
            // neuAnlegenToolStripMenuItem
            // 
            this.neuAnlegenToolStripMenuItem.Name = "neuAnlegenToolStripMenuItem";
            this.neuAnlegenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.neuAnlegenToolStripMenuItem.Text = "Neu Anlegen";
            // 
            // kundenAnzeigenToolStripMenuItem
            // 
            this.kundenAnzeigenToolStripMenuItem.Name = "kundenAnzeigenToolStripMenuItem";
            this.kundenAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kundenAnzeigenToolStripMenuItem.Text = "Kunden Anzeigen";
            // 
            // kundenLöschenToolStripMenuItem
            // 
            this.kundenLöschenToolStripMenuItem.Name = "kundenLöschenToolStripMenuItem";
            this.kundenLöschenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kundenLöschenToolStripMenuItem.Text = "Kunden löschen";
            // 
            // einstellungToolStripMenuItem
            // 
            this.einstellungToolStripMenuItem.Name = "einstellungToolStripMenuItem";
            this.einstellungToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.einstellungToolStripMenuItem.Text = "Einstellung";
            // 
            // CmdNewResult
            // 
            this.CmdNewResult.Location = new System.Drawing.Point(12, 305);
            this.CmdNewResult.Name = "CmdNewResult";
            this.CmdNewResult.Size = new System.Drawing.Size(156, 23);
            this.CmdNewResult.TabIndex = 25;
            this.CmdNewResult.Text = "Neu - Berechnen";
            this.CmdNewResult.UseVisualStyleBackColor = true;
            this.CmdNewResult.Click += new System.EventHandler(this.CmdNewResult_Click);
            // 
            // LblWorkerLabel
            // 
            this.LblWorkerLabel.AutoSize = true;
            this.LblWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWorkerLabel.Location = new System.Drawing.Point(248, 28);
            this.LblWorkerLabel.Name = "LblWorkerLabel";
            this.LblWorkerLabel.Size = new System.Drawing.Size(122, 20);
            this.LblWorkerLabel.TabIndex = 26;
            this.LblWorkerLabel.Text = "Sachbearbeiter:";
            // 
            // LblWorkerName
            // 
            this.LblWorkerName.AutoSize = true;
            this.LblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWorkerName.Location = new System.Drawing.Point(248, 55);
            this.LblWorkerName.Name = "LblWorkerName";
            this.LblWorkerName.Size = new System.Drawing.Size(0, 20);
            this.LblWorkerName.TabIndex = 27;
            // 
            // Bennys_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 336);
            this.Controls.Add(this.LblWorkerName);
            this.Controls.Add(this.LblWorkerLabel);
            this.Controls.Add(this.CmdNewResult);
            this.Controls.Add(this.CbCustomersPlate);
            this.Controls.Add(this.CbCustomers);
            this.Controls.Add(this.LblPlateLabel);
            this.Controls.Add(this.LblCustomerLabel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LblPriceScineLabel);
            this.Controls.Add(this.LblPriceResult);
            this.Controls.Add(this.CmdAddPart);
            this.Controls.Add(this.LblPercentLabel);
            this.Controls.Add(this.DudSalePercent);
            this.Controls.Add(this.CbSelectExtras);
            this.Controls.Add(this.TxtListPrice);
            this.Controls.Add(this.CbSelectDesign);
            this.Controls.Add(this.CbSelectPerformance);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bennys_App";
            this.Text = "Benny´s Rechensystem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CbSelectExtras;
        internal System.Windows.Forms.TextBox TxtListPrice;
        internal System.Windows.Forms.ComboBox CbSelectDesign;
        internal System.Windows.Forms.ComboBox CbSelectPerformance;
        private System.Windows.Forms.DomainUpDown DudSalePercent;
        private System.Windows.Forms.Label LblPercentLabel;
        private System.Windows.Forms.Button CmdAddPart;
        private System.Windows.Forms.Label LblPriceResult;
        private System.Windows.Forms.Label LblPriceScineLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label LblCustomerLabel;
        private System.Windows.Forms.Label LblPlateLabel;
        internal System.Windows.Forms.ComboBox CbCustomers;
        internal System.Windows.Forms.ComboBox CbCustomersPlate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem designEinstellungToolStripMenuItem;
        private System.Windows.Forms.Button CmdNewResult;
        private System.Windows.Forms.Label LblWorkerLabel;
        private System.Windows.Forms.Label LblWorkerName;
        private System.Windows.Forms.ToolStripMenuItem maxMustermannToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manfredFernandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuAnlegenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenLöschenToolStripMenuItem;
    }
}

