using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
	public GameObject fillBar;

	  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    
    }

    public void ChangeProgressBar(float amount)
    {
	    if(amount > 1.00f | amount < 0.00f)
	    {
		    Debug.Log("Error, invalid value for progress bar percentage");
		    return;
	    }
	    Vector3 scaleChange = new Vector3(amount, 1.00f, 1.00f);
	    fillBar.transform.localScale = scaleChange;
    }
}
