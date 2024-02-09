using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _hero;
    public void MonsterMovement()
    {
        Vector3 playerPos = _hero.transform.position;
        this.transform.Translate((playerPos-this.transform.position) * Time.deltaTime * 0.5f);
    }

    private void Update()
    {
        MonsterMovement();
    }
}
