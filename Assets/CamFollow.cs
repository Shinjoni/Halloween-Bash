using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

	public float dampTime = .15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;

	public bool bounds;

	public Vector3 mincameraPos;
	public Vector3 maxcameraPos;

	// Update is called once per frame
	void Update()
	{
		if (target)
		{
			Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);

			Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(.50f, .50f, point.z));

			Vector3 destination = transform.position + delta;

			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);


			if (bounds)
			{

				transform.position = new Vector3(Mathf.Clamp(transform.position.x, mincameraPos.x, maxcameraPos.x), Mathf.Clamp(transform.position.y, mincameraPos.y, maxcameraPos.y), Mathf.Clamp(transform.position.z, mincameraPos.z, maxcameraPos.z));

			}

		}

	}
}
