using UnityEngine;

public class MonsterDestruction : MonoBehaviour
{
    [SerializeField]
    private MonstersType _monster;
    public GameObject monster;
    static float health = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (health == 0)
        {
            Debug.Log(health);
            Destroy(monster);
        }

        else
        {
            health--;
            Debug.Log(health);
        }
    }

    private void Start()
    {
        health += _monster.health;
    }
}
