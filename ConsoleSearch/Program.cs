using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileManagerNS;

namespace ConsoleSearch
{


    class Program
    {
        static int tileWidth = 64;
        static int tileHeight = 64;
        #region tileMap
        static int[,] tileMap = new int[,]
    {
        {1,2,2,2,2,2,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {1,2,3,2,2,2,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {1,1,1,1,1,1,1,1,1,1,1,3,2,2,2,2,2,2,3,2,2,2,2,2,2,2,3,2,2,2,2,2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,2,0,0,0,0,0,2,0,0,0,0,2,0,0,0,2,0,0,0,2,2,2,2,3,2,2,2,2},
        {2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        {2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,2,1,1,2,2,2,1,1,2,2,2,2,1,1,2,2,2,2,2,2,2,2,2,2,2,2,3,2,2,2,2,2,2},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,2,2,2,1,1,2,2,2,2,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,2,1,1,2,2,2,4,1,2,2,2,2,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,2,2,2,1,1,2,2,2,2,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {2,2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,2,2,2,2,2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
        {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
    };
        #endregion
        private static List<TileRef> _tileRefs = new List<TileRef>();
        private static List<Tile> _path = new List<Tile>();
        private static TileManager _tileManager;
        static void Main(string[] args)
        {
             _tileManager = new TileManager();
            _tileRefs.Add(new TileRef(4, 2, 0));
            _tileRefs.Add(new TileRef(3, 3, 1));
            _tileRefs.Add(new TileRef(6, 3, 2));
            _tileRefs.Add(new TileRef(6, 2, 3));
            _tileRefs.Add(new TileRef(0, 2, 4));
            string[] backTileNames = { "free", "pavement", "ground", "blue", "home" };
            string[] impassibleTiles = { "free", "ground", "blue" };

            _tileManager.addLayer("background",
                backTileNames, tileMap, _tileRefs, tileWidth, tileHeight);
            _tileManager.ActiveLayer = _tileManager.getLayer("background");
            _tileManager.ActiveLayer.makeImpassable(impassibleTiles);
            _tileManager.ActiveLayer.makeTileList();
            _tileManager.CurrentTile = _tileManager.ActiveLayer.Tiles[0, 0];

            Tile Start = _tileManager.CurrentTile;
            Tile Finish = _tileManager.ActiveLayer.TileList.Where(t => t.TileName == "home").Single();
            Stack<Tile> frontier = new Stack<Tile>();
            frontier.Push(Start);
            TileEqComparer compare = new TileEqComparer();
            List<Tile> Solution = dfs(compare, frontier, new List<Tile>(), Start, Finish);

            //writeTileList();
            // The 2D Tile map is turned into a collection Tiles in Lists
            // write a method that will write out all the tiles and their contents 
            // to the screen in order 00 to tileWidth, tileHeight
            // Write a Method that will list all the impassable Tiles
            // Write a Method that will list all the passable
            // Write a Method that will list all tiles of a name tile type
        }

        private static void writeTileList()
        {
            List<Tile> orderedTiles = _tileManager.ActiveLayer.TileList
                .Take(20)
                .ToList();

            foreach (Tile t in orderedTiles)
            {
                Console.WriteLine("Tile is {0}", t.ToString());

            }
            Console.ReadKey();
        }
        
        private static List<Tile> dfs(TileEqComparer comparer, 
                            Stack<Tile> frontier, List<Tile> Visited, Tile Current, Tile Goal)
        {
            if (!Visited.Contains(Current, comparer))
                Visited.Add(Current);

            if (frontier.Count == 0)
                return null; // run out of options no solution
            // explore the frontier
            Tile next = frontier.Pop();
            if (next == Goal) { Visited.Add(Goal); return Visited; }
            else {
               
                List<Tile> neighbours = 
                    _tileManager.ActiveLayer.adjacentTo(Current)
                    .Where(n => !Visited.Contains(n, comparer))
                    .Reverse() // as first one to be explored is 
                    .ToList();
                // add to the frontier
                foreach (Tile t in neighbours)
                    frontier.Push(t);

                    dfs(comparer, frontier, Visited, next, Goal);
                }
            return null;
        }
    }
}
