using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorial
{
    public class InputController : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            float hor = Input.GetAxis("Horizontal");
            float ver = Input.GetAxis("Vertical");
            if (hor != 0 || ver != 0)
                Debug.Log(hor + " " + ver);

            if (Input.GetButtonDown("Jump"))
                Debug.Log("Jumping");

        }
    }
}

