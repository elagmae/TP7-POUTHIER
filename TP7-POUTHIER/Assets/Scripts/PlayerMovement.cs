using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Character _characterClass;

    private void FixedUpdate()
    {
        // Pour les mouvements du joueur
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        this.transform.Translate(movement * _characterClass.speed * Time.deltaTime);
    }
}
