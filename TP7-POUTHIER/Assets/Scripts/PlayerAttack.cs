using System.Collections;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private Projectile _projectile;
    GameObject projectile;

    public void CreateProjectile()
    {
        Vector2 playerPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - playerPos;

        float time = _projectile.timeOfExplosion;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            projectile = Instantiate(_projectile.projectileForm);
            projectile.transform.position = playerPos;
            Rigidbody2D rbProjectile = projectile.GetComponent<Rigidbody2D>();
            rbProjectile.AddForce(direction * _projectile.projectileSpeed, ForceMode2D.Impulse);
            Destroy(projectile, _projectile.timeOfExplosion);
        }
    }

    private void Update()
    {
        CreateProjectile();
    }
}