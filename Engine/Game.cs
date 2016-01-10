using System;

namespace Engine
{
    public class Game
    {
        private readonly int _copyrightYear;

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

        public Game(string name, string websiteName, string websiteURL, int majorVersion, int minorVersion,
            string copyrightHolder, int copyrightYear)
        {
            Name = name;
            CurrentVersion = new Version(majorVersion, minorVersion);
            WebsiteURL = websiteURL;
            WebsiteName = websiteName;
            CopyrightHolder = copyrightHolder;

            _copyrightYear = copyrightYear;
        }
    }
}