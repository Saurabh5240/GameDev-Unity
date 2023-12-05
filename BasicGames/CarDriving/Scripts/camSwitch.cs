using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            cam1.gameObject.active = !cam1.gameObject.active;
            cam2.gameObject.active = !cam1.gameObject.active;
        
        }

        
    }
}
