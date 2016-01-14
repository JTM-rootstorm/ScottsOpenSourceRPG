using System.Collections.Generic;
using System.Linq;
using Engine.Collections;

namespace Engine.Entities
{
    public class World
    {
        private readonly SortedListWithFloorAndCeilingIntegerKey<int> _levels = new SortedListWithFloorAndCeilingIntegerKey<int>();

        private const int WORLD_SIZE = 29;
        private const int MIDPOINT = (WORLD_SIZE / 2);

        private readonly List<Location> _locations = new List<Location>();

        public string GameName { get; set; }
        public string GameAuthor { get; set; }
        public string GameCopyrightNotice { get; set; }
        public string GameWebsiteURL { get; set; }

        public World()
        {
            PopulateLevelsList();
            PopulateLocationList();
        }

        public int LevelForExperiencePoints(int experiencePoints)
        {
            return _levels.FloorValueFor(experiencePoints);
        }

        public Location LocationAtCoordinates(Coordinate coordinates)
        {
            return _locations.SingleOrDefault(loc => loc.Coordinates.Match(coordinates));
        }

        public Location StartingLocation()
        {
            return _locations.Single(loc => loc.Coordinates.Match(new Coordinate(MIDPOINT, MIDPOINT)));
        }

        private void PopulateLevelsList()
        {
            _levels.Add(0, 1);
            _levels.Add(100, 2);
            _levels.Add(200, 3);
            _levels.Add(300, 4);
            _levels.Add(400, 5);
            _levels.Add(500, 6);
            _levels.Add(600, 7);
            _levels.Add(700, 8);
            _levels.Add(800, 9);
            _levels.Add(900, 10);
        }

        private void PopulateLocationList()
        {
        }
    }
}
