using System;									// System contains a lot of default C# libraries 
using System.Drawing;                           // System.Drawing contains a library used for canvas drawing below
using GXPEngine;								// GXPEngine contains the engine

public class MyGame : Game
{
	public MyGame() : base(1920, 1080, true)		// Create a window that's 1920x1080 and fullscreen
	{
        Level level = new Level();
        AddChild(level);
        level.SetXY(0, 0);
    }

    void Update()
	{
        if(Player.gameRotation == 1)
        {
            
        }
        if (Player.gameRotation == 2)
        {
            
        }
        if (Player.gameRotation == 3)
        {
            
        }
        if (Player.gameRotation == 4)
        {
            
        }
    }

	static void Main()							// Main() is the first method that's called when the program is run
	{
		new MyGame().Start();					// Create a "MyGame" and start it
	}
}