using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	// Start is called before the first frame update
	public Image slider;
	//public Image fill;

	
	public void SetMaxHealth(float health)
	{
        slider.fillAmount = health;


     //   fill.color = gradient.Evaluate(1f);
	}

	public void SetHealth(float health)
	{
		slider.fillAmount = health;
	}

}
