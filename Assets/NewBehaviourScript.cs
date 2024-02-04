using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{
	Rigidbody2D _rb;

	public Transform target;
	public float _walkSpeed = 0.02f;
	float _inputHorizontal;
	float _inputVertical;
	
	private Vector2 mouseLast;
	private GameObject _player = null;
	private GameObject _gun = null;
	private GameObject _bullet = null;
	public Vector3 targetPosition;
	// Start is called before the first frame update
	void Start()
	{
		_rb = gameObject.GetComponent<Rigidbody2D>(); 
		_player = GetChildGameObject(gameObject, "Player");
		if(_player == null)	Debug.Log("ERROR! DID NOT GET _PLAYER OBJECT");
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
		
		// Vector2 mousePosition = Mouse.current.position.ReadValue();
		Vector2 mousePosition = Input.mousePosition;
		Vector2 diff = mouseLast - mousePosition;
		// Debug.Log($"{diff.x} {diff.y}");
		_inputHorizontal = Input.GetAxisRaw("Horizontal");
		_inputVertical = Input.GetAxisRaw("Vertical");
		_rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, _inputVertical * _walkSpeed));
        // transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		

	}

}
