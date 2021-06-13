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
        Highlighting.intensity = 0;//set light intensity to 0
        UIMS = FindObjectOfType<UIManagerScript>();// get UiManagerScript from scene
    }

    
    void Update()
    {
        if (Selected == true)
        {
            Highlighting.intensity = 1;//if agent was selected, set light intensity to 1
        }
        
        if (Selected == true && UIMS.NewWasSelected == true)
        {
            Selected = false;
            Highlighting.intensity = 0;
            //if agent was unselected, set light intensity to 0
        }
    }
}
