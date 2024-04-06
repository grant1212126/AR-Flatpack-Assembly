using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    public GameObject fillBar;
    public GameObject percentageText;
    public int currentInstruction;

    public void ChangeProgressBar(float amount)
    {
        if(amount > 1.00f | amount < 0.00f)
        {
            Debug.Log("Error, invalid value for progress bar percentage");
            return;
        }
        Vector3 scaleChange = new Vector3(amount, 1.00f, 1.00f);
        fillBar.transform.localScale = scaleChange;
        
        TextMeshProUGUI text = percentageText.GetComponent<TextMeshProUGUI>(); 
        
        
        
        text.text = Convert.ToInt32(amount * 100).ToString();
        text.text += " %";
    }

    public void ResetControlPanel()
    {
        ChangeProgressBar(0.00f);
    }
    
}
