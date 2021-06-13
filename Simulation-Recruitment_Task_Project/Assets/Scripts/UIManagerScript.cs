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
        if (Input.GetButtonDown("Fire1"))
        {
            SelectionBeam();
            //DiselectionBeam();
        }
    }

    void DiselectionBeam()
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit) == true)
        {
            Transform hitObject = hit.transform;
            AgentHighlighting AgentLight = hitObject.GetComponent<AgentHighlighting>();
            AgentHealthAndName SelectAgent = hitObject.GetComponent<AgentHealthAndName>();
            if (SelectAgent != null && SelectAgent.Selected == false)
            {
                NewWasSelected = true;
                
                if (hitObject.CompareTag("Agent") == true)
                {
                    NameDisplay.text = SelectAgent.Name;
                    HealthDisplay.text = SelectAgent.Health.ToString();
                    SelectAgent.Selected = true;
                }
            }
            if(AgentLight!=null && AgentLight.Selected == false)
            {
                AgentLight.Selected = true;
            }
        }
    }
}
