using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileType", menuName = "DungeonCrawler/ProjectileType", order = 3)]

public class Projectile : ScriptableObject
{
    public float projectileSpeed;
    public float timeOfExplosion;
    public GameObject projectileForm;
}
