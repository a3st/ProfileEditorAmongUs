// Copyright © 2019-2020 Dmitriy Lukovenko. All rights reserved.
// Contacts: <mludima23@gmail.com>
// License: https://opensource.org/licenses/GPL-3.0

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ProfileEditor
{
    public partial class SkinWindow : Window
    {
        public ProfileConfig m_config;

        public Dictionary<int, ItemInfo> m_headDB = new Dictionary<int, ItemInfo>();
        public Dictionary<int, ItemInfo> m_bodyDB = new Dictionary<int, ItemInfo>();
        public Dictionary<int, ItemInfo> m_petDB = new Dictionary<int, ItemInfo>();
        public Dictionary<int, string> m_colorDB = new Dictionary<int, string>();

        public SkinWindow()
        {
            InitializeComponent();
        }

        private void SkinWindow_Loaded(object sender, RoutedEventArgs e)
        {
            HeadsDB.Load(ref m_headDB);

            foreach(KeyValuePair<int, ItemInfo> item in m_headDB)
            {
                headComboBox.Items.Add(item.Value.m_itemName as Object);
            }

            BodyDB.Load(ref m_bodyDB);

            foreach (KeyValuePair<int, ItemInfo> item in m_bodyDB)
            {
                bodyComboBox.Items.Add(item.Value.m_itemName as Object);
            }

            PetDB.Load(ref m_petDB);

            foreach (KeyValuePair<int, ItemInfo> item in m_petDB)
            {
                petComboBox.Items.Add(item.Value.m_itemName as Object);
            }

            ColorDB.Load(ref m_colorDB);

            foreach (KeyValuePair<int, string> item in m_colorDB)
            {
                skinColorComboBox.Items.Add(item.Value as Object);
            }

            m_config = ProfileConfig.Load();

            if(m_config.Nickname == String.Empty && m_config.Body == 0 && m_config.Head == 0)
            {
                MessageBox.Show("Profile was not found.\n" +
                    "A profile with standard settings has been created", "Warning", 
                    MessageBoxButton.OK, MessageBoxImage.Warning
                );
            }

            nicknameTextBox.Text = m_config.Nickname;
            bodyComboBox.SelectedIndex = m_config.Body;
            headComboBox.SelectedIndex = m_config.Head;
            petComboBox.SelectedIndex = m_config.Pet;
            skinColorComboBox.SelectedIndex = m_config.Color;
        }

        private void BodyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m_config.Body = (sender as ComboBox).SelectedIndex;

            bodyImage.Source = new BitmapImage(
                new Uri("Resources/" + m_bodyDB[m_config.Body].m_imagePath, UriKind.Relative)
            );
        }

        private void HeadComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m_config.Head = (sender as ComboBox).SelectedIndex;

            headImage.Source = new BitmapImage(
                new Uri("Resources/" + m_headDB[m_config.Head].m_imagePath, UriKind.Relative)
            );
        }

        private void PetComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m_config.Pet = (sender as ComboBox).SelectedIndex;

            petImage.Source = new BitmapImage(
                new Uri("Resources/" + m_petDB[m_config.Pet].m_imagePath, UriKind.Relative)
            );
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            m_config.Save();
        }

        private void skinColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m_config.Color = (sender as ComboBox).SelectedIndex;
        }

        private void buttonCredits_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The author of this software is Dmitry Lukovenko.\n" +
                "This software does not allow players to gain any advantage in the game lobby.\n\n" +
                "Program source code: https://github.com/a3st76/peditoramongus", "Credits", 
                MessageBoxButton.OK, MessageBoxImage.Information
            );
        }
    }
}
