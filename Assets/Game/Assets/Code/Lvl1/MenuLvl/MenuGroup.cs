using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGroup : MonoBehaviour
{

    public List<MenuButton> menuButtons;
	public List<GameObject> objectsToSwap;
	

    public void Subscribe(MenuButton button)
	{
		if (menuButtons == null)
		{
			menuButtons = new List<MenuButton>();
		}

		menuButtons.Add(button);
	}

	public void OnMenuSelected (MenuButton button)
	{
		int index = button.transform.GetSiblingIndex();
		for (int i = 0; i < objectsToSwap.Count; i++)
		{
			if (i == index)
			{
				objectsToSwap[i].SetActive(true);
				Time.timeScale = 1f;
			} else
			{
				objectsToSwap[i].SetActive(false);
				Time.timeScale = 1f;
			}
		}
	}

}
