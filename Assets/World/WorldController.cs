using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using World.Objects;

namespace World
{
    [UsedImplicitly]
    public class WorldController : MonoBehaviour
    {
        public int Height;
        public int Width;

        private Tile[,] _tiles;

        public WorldController(int height, int width, Tile[,] tiles)
        {
            Height = height;
            Width = width;

            for (var xIndex = 0; xIndex < width; xIndex++)
            {
                for (var yIndex = 0; yIndex < height; yIndex++)
                {
                    tiles[xIndex, yIndex] = new Tile(this, xIndex, yIndex);
                }
            }

            _tiles = tiles;
        }

        [UsedImplicitly]
        internal void GenerateWorld(int height, int width)
        {
            
        }

        [UsedImplicitly]
        internal Tile FindTileAt(int x, int y)
        {
            return _tiles[x, y];
        }

// TODO: Refactor 'FindTileAtRange' to use the new '_tiles' container.        
//        [UsedImplicitly]
//        internal List<Tile> FindTileAtRange(int x1, int x2, int y1, int y2)
//        {
//            return _tiles.FindAll(t => t.X >= x1 && t.X <= x2 && t.Y >= y1 && t.Y <= y2);
//        }
    }
}
