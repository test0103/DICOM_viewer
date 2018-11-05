﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseSystemToggleLabels : MonoBehaviour, IPointerClickHandler
{

	public void OnPointerClick(PointerEventData eventData)
	{
		bool isOn = gameObject.GetComponent<Toggle>().isOn;
		
		gameObject.GetComponentInParent<Genomics>().ToggleLabels(isOn);
	}
}