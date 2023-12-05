using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontCam2 : MonoBehaviour
{
    public GameObject player;
    private float cameraDistance = 0.005F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - player.transform.forward * cameraDistance;
        transform.LookAt(player.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + 5F, transform.position.z);
    }
}
