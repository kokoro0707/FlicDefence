using UnityEngine;

public class Missle : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("DestroyZone"))
        {

            Destroy(gameObject);

        }

    }


}
