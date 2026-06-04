using UnityEngine;
public class MeteorFall : MonoBehaviour
{

    public float fallSpeed = 2.5f;

    void Update()
    {

        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

    }

}


