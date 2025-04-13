using UnityEngine;
using System.Collections;

public class creating_properties : MonoBehaviour
{

}

public class Player
{

    private int experience;

    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}

public class Game : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}