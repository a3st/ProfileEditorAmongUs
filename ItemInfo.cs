// Copyright © 2019-2020 Dmitriy Lukovenko. All rights reserved.
// Contacts: <mludima23@gmail.com>
// License: https://opensource.org/licenses/GPL-3.0

namespace ProfileEditor
{
    public struct ItemInfo
    {
        public string m_imagePath;
        public string m_itemName;

        public ItemInfo(string itemName, string imagePath)
        {
            m_itemName = itemName;
            m_imagePath = imagePath;
        }
    }
}
