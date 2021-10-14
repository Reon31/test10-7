using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floarmove : MonoBehaviour
{
    Transform a;
    float px, pz;


    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        px = a.localEulerAngles.x;
        pz = a.localEulerAngles.z;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if ((px <= 30 && px <= 360) || (px >= 330 && px >= 360))
        {

            if (x == -1)
            {
                transform.Rotate(new Vector3(0, 0, 1));
            }
            if (x == 1)
            {
                transform.Rotate(new Vector3(0, 0, -1));
            }
        }
        //if ((px <= 30 && px < 0) || (px >= 330 && px > 0))
        //{
        //    if (x == 1)
        //    {
        //        transform.Rotate(new Vector3(0, 0, -1));

        //    }
        //}
        if ((pz <= 30 && pz <= 360) || (pz >= 330 && pz >= 360))
        {
            if (y == -1)
            {
                transform.Rotate(new Vector3(-1, 0, 0));

            }
            if (y == 1)
            {
                transform.Rotate(new Vector3(1, 0, 0));
            }
        }
    }
}