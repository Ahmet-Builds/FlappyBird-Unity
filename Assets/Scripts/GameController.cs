using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent<Enemy>(out Enemy component))
        {
            Debug.Log("Çarpışma tespit edildi");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
