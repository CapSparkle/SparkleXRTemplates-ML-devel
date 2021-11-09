using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrippingDevice : MonoBehaviour
{
	[SerializeField]
	int HP = 10;

	public Action OnDamageTaken;

    public void TakeDamage(int damage)
	{
		OnDamageTaken();
	}
}
