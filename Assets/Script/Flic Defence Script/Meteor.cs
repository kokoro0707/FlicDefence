using UnityEngine;
public class Meteor : MonoBehaviour
{

    public int scorePoint = 10;



    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Missile"))
        {

            GameManager2.instance.AddScore(scorePoint);



            Destroy(other.gameObject); // ミサイル

            Destroy(gameObject);       // 隕石

        }



        if (other.CompareTag("Ground"))
        {

            GameManager2.instance.GameOver();

            Destroy(gameObject);

        }

    }

}


