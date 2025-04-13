using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class interfaces : MonoBehaviour
{

}

public interface IDamageable
{
    Vector3 Position { get; }
    void Damage(float damage);
}

public class ProtonShield : IDamageable
{
    public float hitPoints = 10f;
    public Vector3 Position { get; }
    public void Damage(float damage)
    {
        hitPoints -= damage;
    }
}

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeReference]
    public IDamageable shield = new ProtonShield();

    public float startingHealth = 100f;
    float m_CurrentHealth;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }
    void Start()
    {
        m_CurrentHealth = startingHealth;
    }
    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
    }
}

public class Explosion : MonoBehaviour
{
    public float range = 10f;
    public float damage = 35f;
    List<IDamageable> m_AllDamageables = new List<IDamageable>();
    void Start()
    {
        MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
        for (int i = 0; i < allScripts.Length; i++)
        {
            if (allScripts[i] is IDamageable)
                m_AllDamageables.Add(allScripts[i] as IDamageable);
        }
    }
    public void Explode()
    {
        for (int i = 0; i < m_AllDamageables.Count; i++)
        {
            if (Vector3.Distance(m_AllDamageables[i].Position, transform.position) < range)
                m_AllDamageables[i].Damage(damage);
        }
    }

}