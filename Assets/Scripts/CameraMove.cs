using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform player;
    public float speedFollow = 5;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset= player.position- transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination= player.position - offset;
        transform.position = Vector3.Lerp(transform.position,destination,Time.deltaTime*speedFollow);   
    }
}
