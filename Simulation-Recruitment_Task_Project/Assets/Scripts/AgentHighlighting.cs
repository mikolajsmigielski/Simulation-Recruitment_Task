using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHighlighting : MonoBehaviour
{
    public Light Highlighting;
    public bool Selected = false;
    public UIManagerScript UIMS;
    
    void Start()
    {
        Highlighting.intensity = 0;
        UIMS = FindObjectOfType<UIManagerScript>();
    }

    
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
        if (Selected == true && UIMS.NewWasSelected == true)
        {
            Selected = false;
        }
    }
}
