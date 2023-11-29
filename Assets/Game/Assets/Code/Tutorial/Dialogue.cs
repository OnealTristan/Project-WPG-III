using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Image[] dialog;
    public Image[] sampah;

    public GameObject sampahPnl;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseBtnLvl.GameIsPaused == false)
		{
            if (Input.GetMouseButtonDown(0))
            {
                NextImage();
            }
        }
    }

    void NextImage ()
	{
        if (index < dialog.Length - 1)
		{
            if (index == 2)
			{
                sampah[0].gameObject.SetActive(true);
                sampah[1].gameObject.SetActive(true);
                dialog[index].gameObject.SetActive(false);
                dialog[index + 1].gameObject.SetActive(true);
                index++;
            }
            else if (index == 3)
			{
                sampah[0].gameObject.SetActive(false);
                sampah[1].gameObject.SetActive(false);
                sampah[2].gameObject.SetActive(true);
                sampah[3].gameObject.SetActive(true);
                dialog[index].gameObject.SetActive(false);
                dialog[index + 1].gameObject.SetActive(true);
                index++;
            } else
			{
                sampah[2].gameObject.SetActive(false);
                sampah[3].gameObject.SetActive(false);
                dialog[index].gameObject.SetActive(false);
                dialog[index + 1].gameObject.SetActive(true);
                index++;
            }
		} else
		{
            sampahPnl.SetActive(true);
            dialog[index].gameObject.SetActive(false);
        }
	}
}
