using System;

namespace main
{

    /// <summary>
    /// A class which models a Tileset.
    /// </summary>
    public class Tileset
    {
        /// <summary>
        /// A constructor for Tileset.
        /// </summary>
        /// <param name="fileName">the name of the file containing the tileset</param>
        /// <param name="tilesCount">the number of tiles in the tileset</param>
        /// <param name="columns">the number of columns in the tileset</param>
        /// <param name="firstTileId">the ID of the first tile</param>
        public Tileset(string fileName, int tilesCount, int columns, int firstTileId)
        {
            FileName = fileName;
            TilesCount = tilesCount;
            Columns = columns;
            Rows = tilesCount / columns;
            FirstTileId = firstTileId;
        }

        /// <summary>
        /// Returns the name of the file containing the tileset.
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Returns the number of tiles in the tileset.
        /// </summary>
        public int TilesCount { get; }

        /// <summary>
        /// Returns the number of columns in the tileset.
        /// </summary>
        public int Columns { get; }

        /// <summary>
        /// Returns the number of rows in the tileset.
        /// </summary>
        public int Rows { get; }

        /// <summary>
        /// Returns the ID of the first tileset.
        /// </summary>
        public int FirstTileId { get; }
    }
}