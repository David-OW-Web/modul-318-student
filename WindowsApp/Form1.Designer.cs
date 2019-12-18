namespace WindowsApp
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.verbindungenResultate = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mehrOptionen = new System.Windows.Forms.CheckBox();
            this.verbindungSuchen = new System.Windows.Forms.Button();
            this.mehrOptionenGroupBox = new System.Windows.Forms.GroupBox();
            this.datumLabel = new System.Windows.Forms.Label();
            this.uhrzeitLabel = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.TextBox();
            this.uhrZeit = new System.Windows.Forms.TextBox();
            this.informationsGroupBox = new System.Windows.Forms.GroupBox();
            this.startStation = new System.Windows.Forms.TextBox();
            this.endStationListBox = new System.Windows.Forms.ListBox();
            this.startStationListBox = new System.Windows.Forms.ListBox();
            this.endStationLabel = new System.Windows.Forms.Label();
            this.startStationLabel = new System.Windows.Forms.Label();
            this.endStation = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stationListBox = new System.Windows.Forms.ListBox();
            this.showAbfahrtTafel = new System.Windows.Forms.Button();
            this.stationResultate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.station = new System.Windows.Forms.TextBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowserStations = new System.Windows.Forms.WebBrowser();
            this.stationMapSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchStationMap = new System.Windows.Forms.Button();
            this.stationMapListBox = new System.Windows.Forms.ListBox();
            this.stationMapSearch = new System.Windows.Forms.TextBox();
            this.stationMapSearchLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mehrOptionenGroupBox.SuspendLayout();
            this.informationsGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.stationMapSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1726, 714);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.verbindungenResultate);
            this.tabPage1.Controls.Add(this.mehrOptionen);
            this.tabPage1.Controls.Add(this.verbindungSuchen);
            this.tabPage1.Controls.Add(this.mehrOptionenGroupBox);
            this.tabPage1.Controls.Add(this.informationsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1718, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // verbindungenResultate
            // 
            this.verbindungenResultate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.verbindungenResultate.HideSelection = false;
            this.verbindungenResultate.Location = new System.Drawing.Point(310, 30);
            this.verbindungenResultate.Name = "verbindungenResultate";
            this.verbindungenResultate.Size = new System.Drawing.Size(1379, 483);
            this.verbindungenResultate.TabIndex = 4;
            this.verbindungenResultate.UseCompatibleStateImageBehavior = false;
            this.verbindungenResultate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Von bis";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nummer";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dauer";
            this.columnHeader6.Width = 150;
            // 
            // mehrOptionen
            // 
            this.mehrOptionen.AutoSize = true;
            this.mehrOptionen.Location = new System.Drawing.Point(20, 305);
            this.mehrOptionen.Name = "mehrOptionen";
            this.mehrOptionen.Size = new System.Drawing.Size(186, 21);
            this.mehrOptionen.TabIndex = 2;
            this.mehrOptionen.Text = "Mehr Optionen anzeigen";
            this.mehrOptionen.UseVisualStyleBackColor = true;
            this.mehrOptionen.CheckedChanged += new System.EventHandler(this.mehrOptionen_CheckedChanged_1);
            // 
            // verbindungSuchen
            // 
            this.verbindungSuchen.Location = new System.Drawing.Point(20, 528);
            this.verbindungSuchen.Name = "verbindungSuchen";
            this.verbindungSuchen.Size = new System.Drawing.Size(273, 34);
            this.verbindungSuchen.TabIndex = 0;
            this.verbindungSuchen.Text = "Verbindungen Suchen";
            this.verbindungSuchen.UseVisualStyleBackColor = true;
            this.verbindungSuchen.Click += new System.EventHandler(this.verbindungenSuchen_Click);
            // 
            // mehrOptionenGroupBox
            // 
            this.mehrOptionenGroupBox.Controls.Add(this.datumLabel);
            this.mehrOptionenGroupBox.Controls.Add(this.uhrzeitLabel);
            this.mehrOptionenGroupBox.Controls.Add(this.datum);
            this.mehrOptionenGroupBox.Controls.Add(this.uhrZeit);
            this.mehrOptionenGroupBox.Location = new System.Drawing.Point(20, 332);
            this.mehrOptionenGroupBox.Name = "mehrOptionenGroupBox";
            this.mehrOptionenGroupBox.Size = new System.Drawing.Size(273, 181);
            this.mehrOptionenGroupBox.TabIndex = 0;
            this.mehrOptionenGroupBox.TabStop = false;
            this.mehrOptionenGroupBox.Text = "Mehr Optionen";
            this.mehrOptionenGroupBox.Visible = false;
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(6, 93);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(49, 17);
            this.datumLabel.TabIndex = 9;
            this.datumLabel.Text = "Datum";
            // 
            // uhrzeitLabel
            // 
            this.uhrzeitLabel.AutoSize = true;
            this.uhrzeitLabel.Location = new System.Drawing.Point(6, 29);
            this.uhrzeitLabel.Name = "uhrzeitLabel";
            this.uhrzeitLabel.Size = new System.Drawing.Size(53, 17);
            this.uhrzeitLabel.TabIndex = 8;
            this.uhrzeitLabel.Text = "Uhrzeit";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(6, 113);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(100, 22);
            this.datum.TabIndex = 5;
            this.datum.Visible = false;
            // 
            // uhrZeit
            // 
            this.uhrZeit.Location = new System.Drawing.Point(6, 49);
            this.uhrZeit.Name = "uhrZeit";
            this.uhrZeit.Size = new System.Drawing.Size(100, 22);
            this.uhrZeit.TabIndex = 4;
            this.uhrZeit.Visible = false;
            // 
            // informationsGroupBox
            // 
            this.informationsGroupBox.Controls.Add(this.startStation);
            this.informationsGroupBox.Controls.Add(this.endStationListBox);
            this.informationsGroupBox.Controls.Add(this.startStationListBox);
            this.informationsGroupBox.Controls.Add(this.endStationLabel);
            this.informationsGroupBox.Controls.Add(this.startStationLabel);
            this.informationsGroupBox.Controls.Add(this.endStation);
            this.informationsGroupBox.Location = new System.Drawing.Point(20, 25);
            this.informationsGroupBox.Name = "informationsGroupBox";
            this.informationsGroupBox.Size = new System.Drawing.Size(273, 274);
            this.informationsGroupBox.TabIndex = 1;
            this.informationsGroupBox.TabStop = false;
            this.informationsGroupBox.Text = "Informationen";
            // 
            // startStation
            // 
            this.startStation.Location = new System.Drawing.Point(6, 38);
            this.startStation.Name = "startStation";
            this.startStation.Size = new System.Drawing.Size(100, 22);
            this.startStation.TabIndex = 10;
            this.startStation.TextChanged += new System.EventHandler(this.startStation_TextChanged);
            // 
            // endStationListBox
            // 
            this.endStationListBox.FormattingEnabled = true;
            this.endStationListBox.ItemHeight = 16;
            this.endStationListBox.Location = new System.Drawing.Point(6, 193);
            this.endStationListBox.Name = "endStationListBox";
            this.endStationListBox.Size = new System.Drawing.Size(200, 68);
            this.endStationListBox.TabIndex = 9;
            this.endStationListBox.Visible = false;
            this.endStationListBox.DoubleClick += new System.EventHandler(this.endStationListBox_DoubleClick);
            // 
            // startStationListBox
            // 
            this.startStationListBox.FormattingEnabled = true;
            this.startStationListBox.ItemHeight = 16;
            this.startStationListBox.Location = new System.Drawing.Point(6, 74);
            this.startStationListBox.Name = "startStationListBox";
            this.startStationListBox.Size = new System.Drawing.Size(200, 68);
            this.startStationListBox.TabIndex = 8;
            this.startStationListBox.Visible = false;
            this.startStationListBox.DoubleClick += new System.EventHandler(this.startStationListBox_DoubleClick);
            // 
            // endStationLabel
            // 
            this.endStationLabel.AutoSize = true;
            this.endStationLabel.Location = new System.Drawing.Point(3, 145);
            this.endStationLabel.Name = "endStationLabel";
            this.endStationLabel.Size = new System.Drawing.Size(41, 17);
            this.endStationLabel.TabIndex = 7;
            this.endStationLabel.Text = "Nach";
            // 
            // startStationLabel
            // 
            this.startStationLabel.AutoSize = true;
            this.startStationLabel.Location = new System.Drawing.Point(3, 18);
            this.startStationLabel.Name = "startStationLabel";
            this.startStationLabel.Size = new System.Drawing.Size(33, 17);
            this.startStationLabel.TabIndex = 6;
            this.startStationLabel.Text = "Von";
            // 
            // endStation
            // 
            this.endStation.Location = new System.Drawing.Point(6, 165);
            this.endStation.Name = "endStation";
            this.endStation.Size = new System.Drawing.Size(100, 22);
            this.endStation.TabIndex = 3;
            this.endStation.TextChanged += new System.EventHandler(this.endStation_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stationListBox);
            this.tabPage2.Controls.Add(this.showAbfahrtTafel);
            this.tabPage2.Controls.Add(this.stationResultate);
            this.tabPage2.Controls.Add(this.station);
            this.tabPage2.Controls.Add(this.stationLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1718, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stationListBox
            // 
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.ItemHeight = 16;
            this.stationListBox.Location = new System.Drawing.Point(37, 88);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(246, 84);
            this.stationListBox.TabIndex = 6;
            this.stationListBox.Visible = false;
            this.stationListBox.DoubleClick += new System.EventHandler(this.stationListBox_DoubleClick);
            // 
            // showAbfahrtTafel
            // 
            this.showAbfahrtTafel.Location = new System.Drawing.Point(46, 191);
            this.showAbfahrtTafel.Name = "showAbfahrtTafel";
            this.showAbfahrtTafel.Size = new System.Drawing.Size(123, 29);
            this.showAbfahrtTafel.TabIndex = 5;
            this.showAbfahrtTafel.Text = "Anzeigen";
            this.showAbfahrtTafel.UseVisualStyleBackColor = true;
            this.showAbfahrtTafel.Click += new System.EventHandler(this.showAbfahrtTafel_Click);
            // 
            // stationResultate
            // 
            this.stationResultate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.stationResultate.HideSelection = false;
            this.stationResultate.Location = new System.Drawing.Point(325, 45);
            this.stationResultate.Name = "stationResultate";
            this.stationResultate.Size = new System.Drawing.Size(1364, 373);
            this.stationResultate.TabIndex = 3;
            this.stationResultate.UseCompatibleStateImageBehavior = false;
            this.stationResultate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mit";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ab";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Richtung";
            this.columnHeader3.Width = 150;
            // 
            // station
            // 
            this.station.Location = new System.Drawing.Point(37, 45);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(100, 22);
            this.station.TabIndex = 1;
            this.station.TextChanged += new System.EventHandler(this.station_TextChanged);
            this.station.KeyUp += new System.Windows.Forms.KeyEventHandler(this.station_KeyUp);
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(34, 25);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(52, 17);
            this.stationLabel.TabIndex = 0;
            this.stationLabel.Text = "Station";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowserStations);
            this.tabPage3.Controls.Add(this.stationMapSearchGroupBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1718, 685);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stationen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowserStations
            // 
            this.webBrowserStations.Location = new System.Drawing.Point(341, 31);
            this.webBrowserStations.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserStations.Name = "webBrowserStations";
            this.webBrowserStations.ScriptErrorsSuppressed = true;
            this.webBrowserStations.Size = new System.Drawing.Size(1317, 557);
            this.webBrowserStations.TabIndex = 3;
            // 
            // stationMapSearchGroupBox
            // 
            this.stationMapSearchGroupBox.Controls.Add(this.searchStationMap);
            this.stationMapSearchGroupBox.Controls.Add(this.stationMapListBox);
            this.stationMapSearchGroupBox.Controls.Add(this.stationMapSearch);
            this.stationMapSearchGroupBox.Controls.Add(this.stationMapSearchLabel);
            this.stationMapSearchGroupBox.Location = new System.Drawing.Point(15, 21);
            this.stationMapSearchGroupBox.Name = "stationMapSearchGroupBox";
            this.stationMapSearchGroupBox.Size = new System.Drawing.Size(302, 547);
            this.stationMapSearchGroupBox.TabIndex = 0;
            this.stationMapSearchGroupBox.TabStop = false;
            this.stationMapSearchGroupBox.Text = "Name";
            // 
            // searchStationMap
            // 
            this.searchStationMap.Location = new System.Drawing.Point(149, 51);
            this.searchStationMap.Name = "searchStationMap";
            this.searchStationMap.Size = new System.Drawing.Size(75, 23);
            this.searchStationMap.TabIndex = 3;
            this.searchStationMap.Text = "Suchen";
            this.searchStationMap.UseVisualStyleBackColor = true;
            this.searchStationMap.Click += new System.EventHandler(this.searchStationMap_Click);
            // 
            // stationMapListBox
            // 
            this.stationMapListBox.FormattingEnabled = true;
            this.stationMapListBox.ItemHeight = 16;
            this.stationMapListBox.Location = new System.Drawing.Point(22, 92);
            this.stationMapListBox.Name = "stationMapListBox";
            this.stationMapListBox.Size = new System.Drawing.Size(252, 292);
            this.stationMapListBox.TabIndex = 2;
            this.stationMapListBox.DoubleClick += new System.EventHandler(this.stationMapListBox_DoubleClick);
            // 
            // stationMapSearch
            // 
            this.stationMapSearch.Location = new System.Drawing.Point(22, 51);
            this.stationMapSearch.Name = "stationMapSearch";
            this.stationMapSearch.Size = new System.Drawing.Size(100, 22);
            this.stationMapSearch.TabIndex = 1;
            this.stationMapSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stationMapSearch_KeyUp);
            // 
            // stationMapSearchLabel
            // 
            this.stationMapSearchLabel.AutoSize = true;
            this.stationMapSearchLabel.Location = new System.Drawing.Point(19, 31);
            this.stationMapSearchLabel.Name = "stationMapSearchLabel";
            this.stationMapSearchLabel.Size = new System.Drawing.Size(52, 17);
            this.stationMapSearchLabel.TabIndex = 0;
            this.stationMapSearchLabel.Text = "Station";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 770);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FahrplanApp - by David Peric";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.mehrOptionenGroupBox.ResumeLayout(false);
            this.mehrOptionenGroupBox.PerformLayout();
            this.informationsGroupBox.ResumeLayout(false);
            this.informationsGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.stationMapSearchGroupBox.ResumeLayout(false);
            this.stationMapSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button verbindungSuchen;
        private System.Windows.Forms.GroupBox mehrOptionenGroupBox;
        private System.Windows.Forms.GroupBox informationsGroupBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox mehrOptionen;
        private System.Windows.Forms.TextBox datum;
        private System.Windows.Forms.TextBox uhrZeit;
        private System.Windows.Forms.TextBox endStation;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label uhrzeitLabel;
        private System.Windows.Forms.Label endStationLabel;
        private System.Windows.Forms.Label startStationLabel;
        private System.Windows.Forms.TextBox station;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.ListView stationResultate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button showAbfahrtTafel;
        private System.Windows.Forms.ListBox stationListBox;
        private System.Windows.Forms.ListBox endStationListBox;
        private System.Windows.Forms.ListBox startStationListBox;
        private System.Windows.Forms.ListView verbindungenResultate;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowserStations;
        private System.Windows.Forms.GroupBox stationMapSearchGroupBox;
        private System.Windows.Forms.Button searchStationMap;
        private System.Windows.Forms.ListBox stationMapListBox;
        private System.Windows.Forms.TextBox stationMapSearch;
        private System.Windows.Forms.Label stationMapSearchLabel;
        private System.Windows.Forms.TextBox startStation;
    }
}

