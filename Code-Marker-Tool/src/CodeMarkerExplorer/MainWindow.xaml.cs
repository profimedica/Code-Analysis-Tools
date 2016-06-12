using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace CodeMarkerExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string InputFile = MarkersCollection.MarkersFilePath;
        public MainWindow()
        {
            InitializeComponent();
            LoadMarkers();
            DataContext = this;
        }
        MarkersCollection markersCollection = new MarkersCollection();
        public ObservableCollection<MarkedFile> markedFiles;

        /// <summary>
        /// Load all markers from file
        /// </summary>
        private void LoadMarkers()
        {
            string[] lines = File.ReadAllLines(InputFile);
            markedFiles = new ObservableCollection<MarkedFile>();
            foreach (string line in lines)
            {
                MarkedFile markedFile = new MarkedFile(line);
                markedFiles.Add(markedFile);
            }
        }

        private static string SelectedFileContent = "";
        private void MarkedFilesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedFileContent = File.ReadAllText(((MarkedFile)MarkedFilesList.SelectedItem).Path);
            DocTextBlock.Text = SelectedFileContent;
            Marker marker = ((MarkedFile)MarkedFilesList.SelectedItem).RootMarker;
            MarkersTreeView.Items.Clear();
            TreeViewItem rootItem = new TreeViewItem();
            rootItem.Header = marker.ToString();
            MarkersTreeView.Items.Add(rootItem);
            FillTree(marker.Markers, rootItem);
        }

        private void FillTree(List<Marker> markerList, TreeViewItem rootItem)
        {
            if (markerList != null)
            {
                //rootItem.Items = new ItemCollection();
                foreach (Marker child in markerList)
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Header = child.ToString();
                    item.Tag = child;
                    rootItem.Items.Add(item);
                    if (child.Markers != null)
                    {
                        FillTree(child.Markers, item);
                    }
                    item.ExpandSubtree();
                }
            }
        }

        private static bool loc = false;

        private void MarkedFilesList_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                FocusManager.SetFocusedElement(this, DocTextBlock);
                Keyboard.Focus(DocTextBlock);
                loc = true;
            }
            if (e.Key == Key.Up)
            {
                if (loc)
                {
                    e.Handled = true;
                    return;
                }
                FocusManager.SetFocusedElement(this, DocTextBlock);
                Keyboard.Focus(DocTextBlock);
            }
            if (e.Key == Key.Down)
            {
                if (loc)
                {
                    e.Handled = true;
                    return;
                }
                FocusManager.SetFocusedElement(this, DocTextBlock);
                Keyboard.Focus(DocTextBlock);
            }
            if (e.Key == Key.Right)
            {
                loc = false;
            }
        }

        private void MarkersTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            //if(MarkersTreeView.SelectedItem)
            if (MarkersTreeView.SelectedItem != null)
            {
                Marker marker = (Marker)(((TreeViewItem)MarkersTreeView.SelectedItem).Tag);
                if (marker != null && marker.To > marker.From)
                {
                    DocTextBlock.Inlines.Clear();
                    DocTextBlock.Inlines.Add(SelectedFileContent.Substring(0, marker.From));
                    if (marker.BlockAt > 0)
                    {
                        Run fragment1 = new Run(SelectedFileContent.Substring(marker.From, marker.BlockAt - marker.From));
                        fragment1.Background = new SolidColorBrush(Colors.Yellow);
                        DocTextBlock.Inlines.Add(fragment1);
                        Run fragment2 = new Run(SelectedFileContent.Substring(marker.BlockAt, marker.To - 1 - marker.BlockAt));
                        fragment2.Background = new SolidColorBrush(Colors.Aquamarine);
                        DocTextBlock.Inlines.Add(fragment2);
                        Run fragment3 = new Run(SelectedFileContent.Substring(marker.To - 1, 1));
                        fragment3.Background = new SolidColorBrush(Colors.Yellow);
                        DocTextBlock.Inlines.Add(fragment3);
                    }
                    else
                    {
                        Run fragment = new Run(SelectedFileContent.Substring(marker.From, marker.To - marker.From));
                        fragment.Background = new SolidColorBrush(Colors.Yellow);
                        DocTextBlock.Inlines.Add(fragment);
                    }
                    DocTextBlock.Inlines.Add(SelectedFileContent.Substring(marker.To));
                }
            }
        }

        private void SourceFoldersComboBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            //
        }

        private void ComboBox_TextChanged(object sender, RoutedEventArgs e)
        {
            string path = SourceFoldersComboBox.Text;
            if (File.Exists(path))
            {
                InputFile = path;
                LoadMarkers();
            }
        }
    }
}