using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ControlPanelUIManager2D : ControlPanel
{
	public Sprite[] instructions;
	public Image instructionImage;
	
	public void ChangeInstruction(int instructionStep)
	{
		if (instructionStep < 0 | instructionStep > 8)
		{
			Debug.Log("Error, you have entered an incorrect instruction step, please enter a number between 1 and 8 (inclusive)");
			return;
		}

		instructionImage.sprite = instructions[instructionStep];
		
		
		ChangeProgressBar((float)instructionStep / 8f);
		
	}

	public void NextInstruction()
	{
		currentInstruction += 1;
		ChangeInstruction(currentInstruction);
	}
	
	public void PreviousInstruction()
	{
		currentInstruction -= 1;
		ChangeInstruction(currentInstruction);
	}
	

	  // Start is called before the first frame update
    void Start()
    {
        this.ResetControlPanel();
        ChangeInstruction(0);
    }
    
    
}
