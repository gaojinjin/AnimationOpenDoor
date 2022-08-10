using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpeed : MonoBehaviour
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
            anim.Play("Move_2");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            anim["Move_2"].speed = -1f;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim["Move_2"].speed = 2f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim["Move_2"].speed = 1f;
        }
    }
}
