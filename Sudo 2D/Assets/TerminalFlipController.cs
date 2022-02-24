using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalFlipController : MonoBehaviour
{
    // Start is called before the first frame update
    bool toggleUp = true;
    public Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)){
            if (toggleUp)
            {
                anim.Play("TerminalUp");
                toggleUp = false;
            }
            else
            {
                anim.Play("TerminalDown");   
                toggleUp = true;
            }
        }

    }
}

