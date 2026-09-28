using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float jumpForce = 5f;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

}
