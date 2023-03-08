using UnityEngine;
using System.Collections;

public class OpenAndCloseDoor : MonoBehaviour
{
    [SerializeField] Animator openAndClose;
    [SerializeField] Transform Player;
    [SerializeField] bool open;

	void Start()
	{
		open = false;
	}

	void OnMouseOver()
	{
		{
			if (Player)
			{
				float dist1 = Vector3.Distance(Player.position, transform.position);
				if (dist1 < 15)
				{
					if (open == false)
					{
						if (Input.GetKeyDown(KeyCode.F))
						{
							StartCoroutine(opening());
						}
					}
                }
			}
		}

	}

    void Update()
    {
		float dist2 = Vector3.Distance(Player.position, transform.position);
		if (dist2 > 15) 
		{
			if (open == true) 
			{
				StartCoroutine(closing());
			}
		}
    }

    IEnumerator opening()
	{
		openAndClose.Play("DoorOpen");
		open = true;
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		openAndClose.Play("DoorClose");
		open = false;
		yield return new WaitForSeconds(.5f);
	}
}