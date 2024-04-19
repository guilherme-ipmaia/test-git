using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float acceleration = 2;
    public Vector3 speed;


    public float secondsToKill = 4;
    IEnumerator Start()
    {
        speed = Vector3.zero;

        yield return new WaitForSeconds(secondsToKill);
        Destroy(gameObject);
    }

    void Update()
    {
        speed += transform.right * acceleration;

        transform.position += speed;
    }


    private void OnTriggerEnter(Collider other)
    {
        //if(gameObject)
    }
}
