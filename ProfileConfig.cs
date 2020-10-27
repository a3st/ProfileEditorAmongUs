// Copyright © 2019-2020 Dmitriy Lukovenko. All rights reserved.
// Contacts: <mludima23@gmail.com>
// License: https://opensource.org/licenses/GPL-3.0

using System;
using System.IO;

namespace ProfileEditor
{
    public class ProfileConfig
    {
        public string Nickname 
        {
            get { return m_nickname; }
            set { m_nickname = value; }
        }
        public int Head
        {
            get { return m_head; }
            set { m_head = value; }
        }
        public int Body
        {
            get { return m_body; }
            set { m_body = value; }
        }
        public int Pet
        {
            get { return m_pet; }
            set { m_pet = value; }
        }
        public int Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        private string m_nickname;
        private int m_body;
        private int m_pet;
        private int m_head;
        private int m_color;

        private string[] m_raw;

        public ProfileConfig()
        {
            m_nickname = String.Empty;
            m_body = 0;
            m_head = 0;
            m_pet = 0;
            m_color = 0;

            m_raw = new string[] {
                "",
                "1","0","1",
                "False","False","False",
                "0","True","False",
                "0",
                "13",
                "12", "1", "0",
                "0","0",
                "True","0","True"
            };
        }

        public ProfileConfig(string[] raw)
        {
            m_nickname = raw[0];
            m_color = Convert.ToInt32(raw[2]);
            m_head = Convert.ToInt32(raw[10]);
            m_body = Convert.ToInt32(raw[15]);
            m_pet = Convert.ToInt32(raw[16]);
            m_raw = raw;
        }

        public static ProfileConfig Load()
        {
            if (!File.Exists(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\..\LocalLow\Innersloth\Among Us\playerPrefs")
            )
            {
                return new ProfileConfig();
            }
            else
            {
                string[] raw;

                using (StreamReader sr = new StreamReader(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\..\LocalLow\Innersloth\Among Us\playerPrefs")
                )
                {
                    var tmp = sr.ReadLine();
                    raw = tmp.Split(',');
                }

                return new ProfileConfig(raw);
            }
        }

        public void Save()
        {
            using (StreamWriter sr = new StreamWriter(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\..\LocalLow\Innersloth\Among Us\playerPrefs", false)
            )
            {
                sr.WriteLine(
                    m_nickname + "," +
                    m_raw[1] + "," +
                    m_color + "," +
                    m_raw[3] + "," +
                    m_raw[4] + "," +
                    m_raw[5] + "," +
                    m_raw[6] + "," +
                    m_raw[7] + "," +
                    m_raw[8] + "," +
                    m_raw[9] + "," +
                    m_head + "," +
                    m_raw[11] + "," +
                    m_raw[12] + "," +
                    m_raw[13] + "," +
                    m_raw[14] + "," +
                    m_body + "," +
                    m_pet + "," +
                    m_raw[17] + "," +
                    m_raw[18] + "," +
                    m_raw[19]
                );
            }
        }
    }
}
