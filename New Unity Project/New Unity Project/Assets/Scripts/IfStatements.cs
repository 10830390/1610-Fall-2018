﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public bool LightOn;
	public string Password;
	public int A, B, C;

	public FloatData WizardPower, PawnPower;
	public NameID Lock, Key;
	
	// Update is called once per frame
	void Update () {

		if (Lock == Key)
		{
			print("Open Door");
		}

		if (WizardPower.Value > PawnPower.Value)
		{
			print("Wizard wins");
		}
		
		if (LightOn)
		{
		print("The light is on.");	
			
		}
		else
		{
			print("the light is off.");
		}
		
		if (Password == "OU812")
			print("You are correct!");

		if (C == A + B)
		{
			print(C);
		}
	}
}
