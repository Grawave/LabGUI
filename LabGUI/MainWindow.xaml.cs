using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LabGUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private FlowRateSettingsList pump1FlowRateList;
        private FlowRateSettingsList pump2FlowRateList;
        public MainWindow()
        {
            this.InitializeComponent();
            this.pump1FlowRateList = new FlowRateSettingsList();
            this.pump2FlowRateList = new FlowRateSettingsList();

            initializePump1SettingsListView();
        }

        private void pump1ClickAddSetting(object sender, RoutedEventArgs e)
        {
            //String flowRate = pump1FlowRateInputBox.GetValue(String);
            String flowRate = pump1FlowRateInputBox.SelectedText;
            double flowRateDbl = double.Parse(flowRate);
            double duration = double.Parse(pump1DurationInputBox.SelectedText);
            this.pump1FlowRateList.add(new FlowRateSetting(flowRateDbl, duration, this.pump1FlowRateList.getMaxID() + 1));
            

            
            // Add to gridview. Add also 'remove button'. The remove button needs to be associated with a FlowRateSetting, which must be deleted from the view and from the collection
            // Maybe it should be in the form of 'RowItem' etc., which includes the button and reference to the FlowRateSetting.
        }

        private void pump2ClickAddSetting(object sender, RoutedEventArgs e)
        {
            pump2AddSettingButton.Content = "modify2";
        }

        private void initializePump1SettingsListView()
        {
            ListView view = new ListView();
            ListView view2 = new ListView
            {
                Header = "Test"
            };

            pump1SettingsListView.Header = "Asd";
            //view.Header{ "test1"; "test2"};
            //view.Header{ }

            //pump1SettingsListView.View = View.Details;
            //pump1SettingsListView.Header();

        }
    }
}
