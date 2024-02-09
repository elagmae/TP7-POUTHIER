using UnityEngine;

[CreateAssetMenu(fileName = "MonsterType", menuName = "DungeonCrawler/MonsterType", order = 2)]

public class MonstersType : ScriptableObject
{
    public float speed;
    public GameObject monsterForm;
    public float health;
}