using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlay : MonoBehaviour
{
    Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("Move_0");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            anim.Play("Move_1");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.CrossFade("Move_0");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.CrossFade("Move_1");
        }
    }
}
