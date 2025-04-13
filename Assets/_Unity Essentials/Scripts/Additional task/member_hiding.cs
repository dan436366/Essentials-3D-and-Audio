using UnityEngine;
using System.Collections;

namespace member_hiding
{
    public class member_hiding : MonoBehaviour
    {

    }

    public class Humanoid
    {
        public void Yell()
        {
            Debug.Log("Humanoid version of the Yell() method");
        }
    }

    public class Enemy : Humanoid
    {
        new public void Yell()
        {
            Debug.Log("Enemy version of the Yell() method");
        }
    }

    public class Orc : Enemy
    {
        new public void Yell()
        {
            Debug.Log("Orc version of the Yell() method");
        }
    }

    public class WarBand : MonoBehaviour
    {
        void Start()
        {
            Humanoid human = new Humanoid();
            Humanoid enemy = new Enemy();
            Humanoid orc = new Orc();


            human.Yell();
            enemy.Yell();
            orc.Yell();
        }
    }
}

