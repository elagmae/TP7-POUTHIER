using UnityEngine;

[CreateAssetMenu(fileName = "CharacterClass", menuName = "DungeonCrawler/CharacterClass", order = 1)]

// Exercice 1 : on créer le scriptable object pour y instancier les classes de personnages (et donc leur vitesse)
public class Character : ScriptableObject
{
    public float speed;
    public ScriptableObject projectile;
}
