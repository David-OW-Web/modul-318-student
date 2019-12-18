using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        private Transport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        // Saubere Methoden mit richtigen Namen

        private void startStation_TextChanged(object sender, EventArgs e)
        {
            startStationListBox.Items.Clear();
            var stations = transport.GetStations(startStation.Text).StationList;

            for (int i = 0; i < stations.Count - 1; i++)
            {
                startStationListBox.Items.Add(stations[i].Name);
                startStationListBox.Visible = true;
            }
        }

        private void startStationListBox_DoubleClick(object sender, EventArgs e)
        {
            startStation.Text = Convert.ToString(startStationListBox.SelectedItem);
            startStationListBox.Items.Clear();
            startStationListBox.Visible = false;
        }

        private void endStationListBox_DoubleClick(object sender, EventArgs e)
        {
            endStation.Text = Convert.ToString(endStationListBox.SelectedItem);
            endStationListBox.Items.Clear();
            endStationListBox.Visible = false;
        }

        private void stationListBox_DoubleClick(object sender, EventArgs e)
        {
            station.Text = Convert.ToString(stationListBox.SelectedItem);
            stationListBox.Items.Clear();
            stationListBox.Visible = false;
            showAbfahrtTafel.PerformClick();
        }

        private void stationMapListBox_DoubleClick(object sender, EventArgs e)
        {
            var ort = Convert.ToString(stationMapListBox.SelectedItem);
            // Setzt den Titel der Gruppenbox, bzw. den Text der Gruppenbox auf den ausgewählten Ort
            stationMapSearchGroupBox.Text = ort;
            // var url = $"https://www.google.ch/maps/place/{ort}";
            var url = $"https://map.search.ch/{ort}";
            var stations = transport.GetStations(stationMapSearch.Text).StationList;
            for (int i = 0; i < stations.Count; i++)
            {

                // Ist der Wert von Variable Ort gleich, wie der beim durchlaufen der Schleife?
                if (stations[i].Name == ort)
                {
                    // Wenn es der gleiche Ort ist die X und Y Koordinaten holen
                    var xCoordinate = stations[i].Coordinate.XCoordinate;
                    var yCoordinate = stations[i].Coordinate.YCoordinate;
                    // Wenn die Koordinaten 0 sind die Schleife beenden, weil man auf der Karte dann nichts zu finden hat. Die Koordinaten sind meistens auf 0 bei genauen Adressen
                    if (xCoordinate == 0 || yCoordinate == 0)
                    {
                        MessageBox.Show("Bitte wählen sie einen anderen Ort aus");
                        break;
                    }
                    else
                    {
                        // listBox1.Items.Add(xCoordinate); listBox1.Items.Add(yCoordinate); dies war zum Testen ob die Koordinaten abgerufen werden
                    }
                    // Dynamische URL zum Abrufen der Karte im Steuerelement WebBrowser
                    var bingMapsUrl = $"http://bing.com/maps/default.aspx?cp={xCoordinate}~{yCoordinate}&lvl=20";
                    webBrowserStations.Navigate(bingMapsUrl);
                }
            }
        }

        // Zeigt weitere Optionen (Datum und Uhrzeit) an, wenn mehrOptionen-CheckBox angeklickt wird, bzw. ist
        private void mehrOptionen_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mehrOptionen.Checked)
            {
                mehrOptionenGroupBox.Visible = true;
                uhrZeit.Visible = true; datum.Visible = true;
            }
            else
            {
                uhrZeit.Visible = false; datum.Visible = false;
                mehrOptionenGroupBox.Visible = false;
            }
        }

        private void verbindungenSuchen_Click(object sender, EventArgs e)
        {
            verbindungenResultate.Items.Clear();
            // StartStation und EndStation sind Pflichtfelder
            string StartStation = startStation.Text.ToString();
            string EndStation = endStation.Text.ToString();
            // DD.MM.YYYY Format
            string datum = this.datum.Text.ToString();
            string uhrzeit = uhrZeit.Text.ToString();
            // Wenn Datum leer ist, wird ihm der Wert des heutigen Datums zugewiesen
            if (datum == String.Empty) { datum = DateTime.Now.Date.ToString(); }
            // Wenn die Uhrzeit leer ist, wird ihm die jetzige Uhrzeit zugewiesen
            if (uhrzeit == String.Empty) { uhrzeit = DateTime.Now.ToString().Substring(11, 5); }

            // Wenn StartStation und EndStation leer sind, API gar nicht abrufen!
            if (StartStation != String.Empty && EndStation != String.Empty)
            {
                Connections connections;
                StationBoardRoot verbindungen;
                connections = transport.GetConnections(StartStation, EndStation, datum, uhrzeit);
                verbindungen = transport.GetStationBoard(StartStation, "");

                try
                {
                    for (int i = 0; i < connections.ConnectionList.Count; i++)
                    {
                        string zeitspanne = connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) + " -> " + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8);

                        string nummerVerbindung = verbindungen.Entries[1].Category + " " + verbindungen.Entries[i].Number;

                        string connection = connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3) + " min";
                        string[] content = { zeitspanne, nummerVerbindung, connection };
                        ListViewItem lvi = new ListViewItem(content);
                        verbindungenResultate.Items.Add(lvi);
                    }
                }
                catch
                {
                    MessageBox.Show("Ihre Eingaben sind ungültig");
                }
            } else
            {
                MessageBox.Show("Start- und Endstation sind Pflichtfelder");
            }
        }

        private void showAbfahrtTafel_Click(object sender, EventArgs e)
        {
            stationResultate.Items.Clear();

            // API nur abrufen, wenn eine Station eingegeben wird
            if (station.Text.ToString() != String.Empty)
            {
                StationBoardRoot sbr = transport.GetStationBoard(station.Text.ToString(), "");
                int i = 0;
                foreach (var station in sbr.Entries)
                {
                    i++;
                    string[] content = { station.Operator + " " + station.Number, station.Stop.Departure.TimeOfDay.ToString(), station.To };
                    ListViewItem lvi = new ListViewItem(content);
                    stationResultate.Items.Add(lvi);
                }
            } else
            {
                MessageBox.Show("Station ist Pflichtfeld");
            }
        }

        private void searchStationMap_Click(object sender, EventArgs e)
        {
            stationMapListBox.Items.Clear();
            string Station = stationMapSearch.Text.ToString();
            // API wird nur abgerufen, wenn Station eingegeben wird, bzw. ist
            if (Station != String.Empty)
            {
                var stations = transport.GetStations(Station).StationList;

                for (int i = 0; i < stations.Count - 1; i++)
                {
                    stationMapListBox.Items.Add(stations[i].Name);
                }
            } else
            {
                MessageBox.Show("Bitte Feld ausfüllen");
            }
        }

        private void endStation_TextChanged(object sender, EventArgs e)
        {
            endStationListBox.Items.Clear();
            var stations = transport.GetStations(endStation.Text).StationList;

            for (int i = 0; i < stations.Count - 1; i++)
            {
                endStationListBox.Items.Add(stations[i].Name);
                endStationListBox.Visible = true;
            }
        }

        private void station_TextChanged(object sender, EventArgs e)
        {
            stationListBox.Items.Clear();
            var stations = transport.GetStations(station.Text).StationList;

            for (int i = 0; i < stations.Count - 1; i++)
            {
                stationListBox.Items.Add(stations[i].Name);
                stationListBox.Visible = true;
            }
        }

        private void stationMapSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && stationMapSearch.Text != String.Empty)
            {
                searchStationMap.PerformClick();
            }
        }

        private void station_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && station.Text != String.Empty)
            {
                showAbfahrtTafel.PerformClick(); // Eventuell noch für double click machen, dass es sucht, bzw. Resultate anzeigt
                stationListBox.Items.Clear();
                stationListBox.Visible = false;
            }
        }
    }
}
