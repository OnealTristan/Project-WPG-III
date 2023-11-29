using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class MenuButton : MonoBehaviour, IPointerClickHandler
{

    public MenuGroup menuGroup;
    public Image background;

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
	{
		menuGroup.OnMenuSelected(this);
	}

	// Start is called before the first frame update
	void Start()
    {
        background = GetComponent<Image>();
        menuGroup.Subscribe(this);
    }

}
