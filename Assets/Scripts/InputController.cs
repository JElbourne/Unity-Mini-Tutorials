using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public GameObject target;

    MoveTrait m_MoveTrait;

    private void Start()
    {
        m_MoveTrait = target.GetComponent<MoveTrait>();
    }

    void Update () {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if(m_MoveTrait && (hor != 0 || ver != 0))
        {
            m_MoveTrait.Move(hor, ver, 10);
        }
    }
}
