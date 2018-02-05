using System.Collections.Generic;
using JetBrains.Annotations;
using World.Objects;

namespace World
{
    [UsedImplicitly]
    public class Tile
    {
        [UsedImplicitly] public List<MovableObject> ListMovableObjects;
        [UsedImplicitly] public List<StaticObject> ListStaticObjects;

        [UsedImplicitly] public WorldController WorldController;

        public Tile(WorldController world, int x, int y)
        {
            WorldController = world;
            ListMovableObjects = new List<MovableObject>();
            ListStaticObjects = new List<StaticObject>();
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }
}