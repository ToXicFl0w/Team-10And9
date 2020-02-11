using System;
using GXPEngine;
public class Player : Sprite
{
    private float _speed = 0.4f;
    private float _gravity = 1.0f;
    public static int gameRotation= 1;


    //------------------------------------------------------------
    //                      Player()
    //------------------------------------------------------------
    public Player() : base("Assets/Chonky.png")
    {
        SetOrigin(width / 2, height);                                           // Set center of the sprite.
    }

    //------------------------------------------------------------
    //                      movementInput()
    //------------------------------------------------------------
    void MovementInput()
    {
        if(Input.GetKey(Key.A))
        {
            Move(-(Time.deltaTime * _speed), 0f);
        }
        if (Input.GetKey(Key.D))
        {
            Move((Time.deltaTime * _speed), 0f);
        }
        if (Input.GetKey(Key.Q))
        {
            gameRotation -= 1;
        }
        if(Input.GetKey(Key.E))
        {
            gameRotation += 1;
        }
    }

    void GravityEffect()
    {
        Console.WriteLine(parent.rotation);
        MoveUntilCollision(0, _gravity);
    }

    void OutOfScreen()
    {
        if(this.y >= 700)
        {
            this.y = 600;
        }
    }

    void Update()
    {
        GravityEffect();
        MovementInput();
        OutOfScreen();
    }
}
