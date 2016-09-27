﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

namespace Playground
{
	public class TestItem : MonoBehaviour 
	{
		public RectTransform inventory;

		private int offsetX = 390;
		private int offsetY = 268;
		private int itemPositionX = 0;
		private int itemPositionY = 0;
		private int itemHeight = 109;
		private int expandWidth = 250;

		void Start()
		{
			Debug.LogWarning("Playground::TestItem script is in use by " + gameObject.name);
		}

		void OnEnable()
		{
			Debug.Log("OnEnable");
		}

		void OnDisable()
		{
			Debug.Log("OnDisable");
		}

		void Update()
		{
			UpdatePosition();
		}

		public void ShowPanel(int item)
		{
			if (item > 4)
			{
				itemPositionX = (offsetX * 2) + expandWidth;
				itemPositionY = (item - 5) * itemHeight;
			}
			else
			{
				itemPositionX = 0;
				itemPositionY = item * itemHeight;
			}	

			UpdatePosition();
			gameObject.SetActive(true);
		}

		public void HidePanel()
		{
			gameObject.SetActive(false);
		}

		private void UpdatePosition()
		{
			Vector2 position = new Vector2(inventory.localPosition.x - offsetX + itemPositionX, inventory.localPosition.y + offsetY - itemPositionY);
			GetComponent<RectTransform>().localPosition = position;
		}
	}
}