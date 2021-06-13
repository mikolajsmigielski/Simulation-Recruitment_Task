using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public Text NameText;
    public Text NameDisplay;
    public Text HealthText;
    public Text HealthDisplay;
    public Camera PlayerCamera;
    public bool NewWasSelected = false;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//when main mouse key down, use function to select object
        {
            SelectionBeam();
            
        }
    }

    void DiselectionBeam()//disselecting function, similar to SelectionBeam
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) == true)
        {
            
            Transform hitObject = hit.transform;
            AgentHighlighting AgentLight = hitObject.GetComponent<AgentHighlighting>();
            AgentHealthAndName SelectAgent = hitObject.GetComponent<AgentHealthAndName>();
            if (SelectAgent != null && SelectAgent.Selected == true)
            {
                
                if (hitObject.CompareTag("Agent") == true)
                {
                    NameDisplay.text = " ";
                    HealthDisplay.text = " ";
                    SelectAgent.Selected = false;
                }
            }
            if (AgentLight != null && AgentLight.Selected == true)
            {
                AgentLight.Selected = false;
            }
        }
    }

    void SelectionBeam()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//create ray from mouse position
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit) == true)// if something was hit by ray, then
        {
            Transform hitObject = hit.transform;//get object transform
            AgentHighlighting AgentLight = hitObject.GetComponent<AgentHighlighting>();// get acess to component AgentHighlighting
            AgentHealthAndName SelectAgent = hitObject.GetComponent<AgentHealthAndName>();// get acess to component AgentHealthAndName
            if (SelectAgent != null && SelectAgent.Selected == false)// if selected agent was not selected, then
            {
                NewWasSelected = true;// set that new object wast selected
                NameDisplay.text = SelectAgent.Name;//display agent name on screen
                HealthDisplay.text = SelectAgent.Health.ToString();//Display agent health on screen
                SelectAgent.Selected = true;// set that this agent was selected
                
            }
            if(AgentLight!=null && AgentLight.Selected == false) // if selected agent was not selected, then 
            {
                AgentLight.Selected = true;// set that this agent was selected
            }
        }
    }
}
