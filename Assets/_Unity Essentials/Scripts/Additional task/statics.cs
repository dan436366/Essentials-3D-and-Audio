using UnityEngine;
using System.Collections;

public class statics : MonoBehaviour
{

}

public class Enemy
{
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
}

public class Game1
{
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        int x = Enemy.enemyCount;
    }
}

public class Player1 : MonoBehaviour
{

    public static int playerCount = 0;

    void Start()
    {
        playerCount++;
    }
}

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        int x = Player1.playerCount;
    }
}

public static class Utilities
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

public class UtilitiesExample : MonoBehaviour
{
    void Start()
    {
        int x = Utilities.Add(5, 6);
    }
}