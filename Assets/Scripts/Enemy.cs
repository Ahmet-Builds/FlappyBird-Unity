using UnityEngine;

public class Enemy : MonoBehaviour
{
 public Rigidbody2D Enemyrigidbody2D;
    public float moveSpeed = 2f;
    private void Update()
    {
        Enemyrigidbody2D.linearVelocityX = -moveSpeed;
    }
}
