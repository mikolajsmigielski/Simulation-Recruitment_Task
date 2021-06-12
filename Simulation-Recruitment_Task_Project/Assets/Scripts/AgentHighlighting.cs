using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHighlighting : MonoBehaviour
{
    public Light Highlighting;
    public bool Selected = false;
    // Start is called before the first frame update
    void Start()
    {
        Highlighting.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Selected == true)
        {
            Highlighting.intensity = 1;
        }
        if (Selected == false)
        {
            Highlighting.intensity = 0;
        }
    }
}
