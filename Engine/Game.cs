using System;
using System.Xml;
using Engine.Collections;

namespace Engine
{
    public class Game
    {
        private readonly int _copyrightYear;
        private readonly SortedListWithFloorAndCeilingIntegerKey<int> _levels = new SortedListWithFloorAndCeilingIntegerKey<int>();

        public string Name { get; private set; }
        public Version CurrentVersion { get; private set; }
        public string WebsiteURL { get; private set; }
        public string WebsiteName { get; private set; }
        public string CopyrightHolder { get; private set; }

        public string CopyrightYears
        {
            get
            {
                return (DateTime.Now.Year > _copyrightYear)
                    ? string.Format("{0} - {1}", _copyrightYear, DateTime.Now.Year)
                    : string.Format("{0}", _copyrightYear);
            }
        }

        public Game(string xmlGameInformation)
        {
            ClearPrivateVariables();

            XmlDocument info = new XmlDocument();
            info.LoadXml(xmlGameInformation);

            Name = info.SelectSingleNode("/Game/Name").InnerText;
            WebsiteName = info.SelectSingleNode("/Game/Website/Name").InnerText;
            WebsiteURL = info.SelectSingleNode("/Game/Website/URL").InnerText;
            CurrentVersion = new Version(
                Convert.ToInt32(info.SelectSingleNode("/Game/Version/@Major").InnerText),
                Convert.ToInt32(info.SelectSingleNode("/Game/Version/@Minor").InnerText));

            CopyrightHolder = info.SelectSingleNode("/Game/Copyright/Holder").InnerText;
            _copyrightYear = Convert.ToInt32(info.SelectSingleNode("/Game/Copyright/Year").InnerText);

            XmlNodeList levels = info.SelectNodes("/Game/Levels/Level");

            if(levels == null)
            {
                //TODO: Raise exception
            }
            else
            {
                foreach(XmlNode level in levels)
                {
                    _levels.Add(Convert.ToInt32(level.InnerText), Convert.ToInt32(level.Attributes["MaxXP"].InnerText));
                }
            }
        }

        private void ClearPrivateVariables()
        {
            _levels.Clear();
        }
    }
}