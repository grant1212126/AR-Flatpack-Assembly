using System;
using UnityEngine;

[ExecuteInEditMode]
public class ControlPanelUIManager3D : ControlPanel
{
	public GameObject[] animationGroup;
	public GameObject instructionBase;
	
	public void ChangeInstruction(int instructionStep, int previousInstruction = -1)
	{
		
		if (instructionStep < 0 | instructionStep > 8)
		{
			Debug.Log("Error, you have entered an incorrect instruction step, please enter a number between 1 and 8 (inclusive)");
			return;
		}
		
		if (previousInstruction != -1)
		{
			animationGroup[previousInstruction].SetActive(false);
		}
		
		ChangeProgressBar((float)instructionStep / 8f);
		animationGroup[instructionStep].SetActive(true);
		
		}

	public void NextInstruction()
	{
		currentInstruction += 1;
		ChangeInstruction(currentInstruction, currentInstruction-1);
	}
	
	public void PreviousInstruction()
	{
		currentInstruction -= 1;
		ChangeInstruction(currentInstruction, currentInstruction+1);
	}
	

	// Start is called before the first frame update
	void Start()
	{
		this.ResetControlPanel();
		ChangeInstruction(0);
	}

	private void Update()
	{
		
	}
}
