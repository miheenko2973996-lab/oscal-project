using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;

namespace oscal_project
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ControlItem> _allControls = new List<ControlItem>();
        private string _currentFilePath;
        private string _currentJsonContent;

        public MainWindow()
        {
            InitializeComponent();

            string startFilePath = System.IO.Path.Combine(
       AppDomain.CurrentDomain.BaseDirectory,
       "data",
       "BSI-Methodik-Grundschutz++-catalog.json");

            LoadOscalData(startFilePath);
            _currentFilePath = startFilePath;
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*";

            if (dialog.ShowDialog() == true)
            {
                string filePath = dialog.FileName;

                try
                {
                  LoadOscalData(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Öffnen:\n" + ex.Message);
                }
            }
        }
        private void LoadOscalData(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("JSON-Datei nicht gefunden:\n" + filePath);
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                _currentJsonContent = jsonContent;  
                JObject root = JObject.Parse(jsonContent);

                JToken groups = root["catalog"]?["groups"];

                if (groups != null)
                {
                    ReadGroups(groups);
                }
                else
                {
                    JToken controls = root["catalog"]?["controls"];

                    if (controls != null)
                    {
                        ReadControls(controls);
                    }
                    else
                    {
                        MessageBox.Show("Diese OSCAL-Datei wird nicht unterstützt (keine groups oder controls gefunden).");
                        return;
                    }
                }

                _allControls.Clear();
                ReadGroups(groups);
                ControlsListBox.ItemsSource = _allControls;

                if (_allControls.Count > 0)
                {
                    ControlsListBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der JSON-Datei:\n" + ex.Message);
            }
        }
        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dateien (*.json)|*.json";

            if (dialog.ShowDialog() == true)
            {
                string filePath = dialog.FileName;

                try
                {
                    // Beispiel: aktuelles JSON speichern
                    File.WriteAllText(filePath, _currentJsonContent);
                    _currentFilePath = filePath;
                    MessageBox.Show("Datei gespeichert:\n" + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Speichern:\n" + ex.Message);
                }
            }
        }
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentFilePath))
            {
                MessageBox.Show("Es ist keine Datei geöffnet.");
                return;
            }

            try
            {
                File.WriteAllText(_currentFilePath, _currentJsonContent);
                MessageBox.Show("Datei gespeichert:\n" + _currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern:\n" + ex.Message);
            }
        }
        private void ExportJson_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentJsonContent))
            {
                MessageBox.Show("Es ist kein JSON-Inhalt zum Exportieren vorhanden.");
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dateien (*.json)|*.json";
            dialog.FileName = "export.json";

            if (dialog.ShowDialog() == true)
            {
                string filePath = dialog.FileName;

                try
                {
                    File.WriteAllText(filePath, _currentJsonContent);
                    MessageBox.Show("JSON exportiert:\n" + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim JSON-Export:\n" + ex.Message);
                }
            }
        }
        private void ExportXml_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentJsonContent))
            {
                MessageBox.Show("Es ist kein JSON-Inhalt zum Exportieren vorhanden.");
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML Dateien (*.xml)|*.xml";
            dialog.FileName = "export.xml";

            if (dialog.ShowDialog() == true)
            {
                string filePath = dialog.FileName;

                try
                {
                    XmlDocument doc = JsonConvert.DeserializeXmlNode(_currentJsonContent, "catalog");
                    doc.Save(filePath);

                    MessageBox.Show("XML exportiert:\n" + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim XML-Export:\n" + ex.Message);
                }
            }
        }
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BeschreibungTextBlock.Text))
            {
                MessageBox.Show("Kein Text zum Kopieren vorhanden.");
                return;
            }

            Clipboard.SetText(BeschreibungTextBlock.Text);
            MessageBox.Show("Text wurde kopiert.");
        }

        private void ReadGroups(JToken groups)
        {
            foreach (JToken group in groups)
            {
                JToken controls = group["controls"];
                if (controls != null)
                {
                    ReadControls(controls);
                }

                JToken childGroups = group["groups"];
                if (childGroups != null)
                {
                    ReadGroups(childGroups);
                }
            }
        }

        private void ReadControls(JToken controls)
        {
            foreach (JToken control in controls)
            {
                ControlItem item = new ControlItem
                {
                    Id = control["id"]?.ToString(),
                    Title = control["title"]?.ToString(),
                    Beschreibung = GetDescription(control),
                    Parameter = GetParameters(control)
                };

                _allControls.Add(item);

                JToken childControls = control["controls"];
                if (childControls != null)
                {
                    ReadControls(childControls);
                }
            }
        }

        private string GetDescription(JToken control)
        {
            JToken parts = control["parts"];
            if (parts == null)
            {
                return "Keine Beschreibung gefunden.";
            }

            foreach (JToken part in parts)
            {
                string partName = part["name"]?.ToString();

                if (partName == "statement" || partName == "guidance" || partName == "overview")
                {
                    string prose = part["prose"]?.ToString();

                    if (!string.IsNullOrWhiteSpace(prose))
                    {
                        return prose;
                    }
                }
            }

            return "Keine Beschreibung gefunden.";
        }

        private List<ParameterItem> GetParameters(JToken control)
        {
            List<ParameterItem> parameterList = new List<ParameterItem>();

            JToken paramsToken = control["params"];
            if (paramsToken == null)
            {
                return parameterList;
            }

            foreach (JToken param in paramsToken)
            {
                string label =
                    param["label"]?.ToString() ??
                    param["id"]?.ToString() ??
                    "Unbekannt";

                string wert = "-";

                JToken values = param["values"];
                if (values != null && values.HasValues)
                {
                    List<string> valueList = new List<string>();

                    foreach (JToken value in values)
                    {
                        valueList.Add(value.ToString());
                    }

                    wert = string.Join(", ", valueList);
                }
                else
                {
                    wert = param["select"]?["how-many"]?.ToString() ?? "-";
                }

                parameterList.Add(new ParameterItem
                {
                    Name = label,
                    Wert = wert
                });
            }

            return parameterList;
        }

        private void ControlsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ControlItem selectedControl = ControlsListBox.SelectedItem as ControlItem;

            if (selectedControl == null)
            {
                return;
            }

            TitleTextBlock.Text = "Titel: " + selectedControl.Title;
            BeschreibungTextBlock.Text = selectedControl.Beschreibung;
            ParameterGrid.ItemsSource = selectedControl.Parameter;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SearchPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                SearchPlaceholder.Visibility = Visibility.Collapsed;
            }

            if (SearchBox == null)
            {
                return;
            }

            string suchtext = SearchBox.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(suchtext))
            {
                SearchPlaceholder.Visibility = Visibility.Visible;
                ControlsListBox.ItemsSource = _allControls;
                return;
            }

            List<ControlItem> gefiltert = _allControls.FindAll(c =>
                (!string.IsNullOrWhiteSpace(c.Title) && c.Title.ToLower().Contains(suchtext)) ||
                (!string.IsNullOrWhiteSpace(c.Id) && c.Id.ToLower().Contains(suchtext)) ||
                (!string.IsNullOrWhiteSpace(c.Beschreibung) && c.Beschreibung.ToLower().Contains(suchtext)));

            ControlsListBox.ItemsSource = gefiltert;
            if (gefiltert.Count > 0)
            {
                ControlsListBox.SelectedIndex = 0;
            }
        }
        private void SearchMenu_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Focus();
            SearchBox.SelectAll();
        }

        private void ClearSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Clear();
            ControlsListBox.ItemsSource = _allControls;

            if (_allControls.Count > 0)
            {
                ControlsListBox.SelectedIndex = 0;
            }
            SearchBox.Focus();
        }
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ControlsListBox.Items.Count > 0)
                {
                    ControlsListBox.SelectedIndex = 0;
                    ControlsListBox.Focus();
                }
            }
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "OSCAL Viewer\n\n" +
                "Version 1.0\n\n" +
                "Diese Anwendung dient zur Anzeige und Analyse von\n" +
                "Sicherheitsmaßnahmen aus dem BSI Grundschutz-Katalog.\n\n" +
                "Funktionen:\n" +
                "- Suchen\n- Export JSON/XML\n\n" +
                "Entwickelt von: Olha",
                "Über das Programm",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }

    public class ControlItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Beschreibung { get; set; }
        public List<ParameterItem> Parameter { get; set; } = new List<ParameterItem>();
    }

    public class ParameterItem
    {
        public string Name { get; set; }
        public string Wert { get; set; }
    }
}