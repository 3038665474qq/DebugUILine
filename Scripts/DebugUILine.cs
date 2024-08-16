using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugUILine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	//边框
	static Vector3[] fourCorners = new Vector3[4];
	/// <summary>
	/// Scene面板 查看周围有蓝色边框 
	/// </summary>
	void OnDrawGizmos()
	{
		foreach (MaskableGraphic g in GameObject.FindObjectsOfType<MaskableGraphic>())
		{
			if (g.raycastTarget)
			{
				RectTransform rectTransform = g.transform as RectTransform;
				rectTransform.GetWorldCorners(fourCorners);
				Gizmos.color = Color.blue;
				for (int i = 0; i < 4; i++)
					Gizmos.DrawLine(fourCorners[i], fourCorners[(i + 1) % 4]);

			}
		}
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
