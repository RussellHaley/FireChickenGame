using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerMovement : MonoBehaviour
{
	

	public bool _movementEnabled;
	public float _walkSpeed = 0.02f;
	
	private Vector2 _mouseLast;
	private Rigidbody2D _rb;
	
	public void EnablePlayerMovement(bool enable)
	{
		_movementEnabled = enable;
	}
	
	// Start is called before the first frame update
	void Start()
	{
		_movementEnabled = true;
		_rb = gameObject.GetComponent<Rigidbody2D>(); 
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		// Debug.Log("Got here first");
	}


	public GameObject GetChildGameObject(GameObject fromGameObject, string withName)
	{
		var allKids = fromGameObject.GetComponentsInChildren<Transform>();
		var kid = allKids.FirstOrDefault(k => k.gameObject.name == withName);
		if (kid == null) return null;
		return kid.gameObject;
	}
	
	void Update()
	{
		if (!_movementEnabled) return;

		Vector2 mousePosition = Input.mousePosition;
		Vector2 diff = _mouseLast - mousePosition;
		float inputHorizontal = Input.GetAxisRaw("Horizontal");
		float inputVertical = Input.GetAxisRaw("Vertical");
		_rb.AddForce(new Vector2(inputHorizontal * _walkSpeed, inputVertical * _walkSpeed));
		Debug.Log($"Force {inputHorizontal} - {inputVertical} - {_walkSpeed}");
	}

}
