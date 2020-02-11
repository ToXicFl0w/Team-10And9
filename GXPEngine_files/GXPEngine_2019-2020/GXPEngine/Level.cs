using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiledMapParser;
using GXPEngine;
public class Level : GameObject
{
    Player player;

    public Level()
    {
        player = new Player();
        AddChild(player);
        player.SetXY(400, 300);
        //rotation = 90;
    }

    void Update()
    {
        //SetXY(-player.x, -player.y);
        if(Input.GetKeyDown(Key.SPACE))
        {
            Turn(90);
        }
    }
}


/* private void BlockSetupFromFile()                                         // Loads in level trough TileMapParser.
 {
     Map level;                                                            // create object under name level.
     short[,] layer;                                                       // creates an array of layers
     int wid, hei;                                                         // Takes the width and height of the map and stores in wid and hei

     level = MapParser.ReadMap("_Assets/Arkanoid_map.tmx");                // Reads data from Tiled map
     layer = level.Layers[0].GetTileArray();                               // Stores information about layers in the array

     wid = level.Layers[0].Width;                                          // Stores width information in wid
     hei = level.Layers[0].Height;                                         // Stores height information in hei
     for (int x = 0; x < wid; x++)
     {
         for (int y = 0; y < hei; y++)
         {
             int value = Convert.ToInt16(layer.GetValue(x, y));            // Changes layer information to integers to use in a switch-case
             switch (value)
             {
                 case 1:

                     break;
                 case 2:

                     break;
                 case 3:

                     break;
                 case 4:

                     break;
             }
         }
     }
 }
}*/
