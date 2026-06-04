using UnityEngine;

public class MissileLauncher : MonoBehaviour
{

    [Header("ミサイル")]

    public GameObject missilePrefab;

    public Transform firePoint;

    public float missileSpeed = 12f;



    [Header("フリック")]

    public float minFlickDistance = 50f;



    Vector2 startPos;



    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            startPos = Input.mousePosition;

        }



        if (Input.GetMouseButtonUp(0))
        {

            Vector2 endPos = Input.mousePosition;

            Vector2 flick = endPos - startPos;



            if (flick.magnitude < minFlickDistance) return;



            Vector2 direction = flick.normalized;

            Shoot(direction);

        }

    }



    void Shoot(Vector2 direction)
    {

        GameObject missile = Instantiate(

        missilePrefab,

        firePoint.position,

        Quaternion.identity

        );



        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();

        rb.linearVelocity = direction * missileSpeed;



        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        missile.transform.rotation = Quaternion.Euler(0, 0, angle - 90f);

    }

}

