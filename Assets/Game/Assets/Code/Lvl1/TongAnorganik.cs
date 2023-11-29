using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TongAnorganik : MonoBehaviour, IDropHandler
{

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if (eventData.pointerDrag != null)
		{
			eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
			if (eventData.pointerDrag.layer == 9)
			{
				ScoreScript.scoreValue += 10;
				Destroy(eventData.pointerDrag, .1f);
			} else
			{
				ScoreScript.scoreValue -= 10;
				Destroy(eventData.pointerDrag, .1f);
				Debug.Log("Salah !!");
			}
		}
	}
}