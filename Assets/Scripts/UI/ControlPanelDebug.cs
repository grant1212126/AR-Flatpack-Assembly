using UnityEngine;

public class ControlPanelDebug : ControlPanel
{
    
    public GameObject instructionPanel3D;
    public GameObject instructionBase3D;
    public GameObject instructionPanel2D;
    public GameObject examplePanel;

    public void EnableOrDisable2DInstructionPanel()
    {
        if (instructionPanel2D.activeSelf)
        {
            instructionPanel2D.SetActive(false);
        }
        else
        {   
            instructionPanel2D.SetActive(true);
        }
    }
    
    public void EnableOrDisable3DInstructionPanel()
    {
        if (instructionPanel3D.activeSelf)
        {
            instructionPanel3D.SetActive(false);
            instructionBase3D.SetActive(false);
        }
        else
        {   
            instructionPanel3D.SetActive(true);
            instructionBase3D.SetActive(true);
        }
    }
    
    public void EnableOrDisableExamplePanel()
    {
        if (examplePanel.activeSelf)
        {
            examplePanel.SetActive(false);
        }
        else
        {   
            examplePanel.SetActive(true);
        }
    }

    void Start()
    {
        instructionPanel3D.SetActive(false);
        instructionBase3D.SetActive(false);
        
        instructionPanel2D.SetActive(false);
        
        examplePanel.SetActive(false);
    }
}
