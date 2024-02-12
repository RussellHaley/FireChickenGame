using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GunLoader : MonoBehaviour
{
    public GameObject _myPrefab;
    public bool _weaponEnabled;
    private GameObject _gun;
    private Rigidbody2D _rb; // Reference to the Rigidbody2D component

    private void Start()
    {
		_weaponEnabled = true;
        _gun = GetChildGameObject(gameObject, "PlayerGun");
    }

	public void EnableWeapon(bool enable)
	{
		_weaponEnabled = enable;
	}

    private void Update()
    {
		if(!_weaponEnabled)return;

        if (Input.GetMouseButton(0))
        {
            // gameObject.GetComponent<SpriteRenderer>();
            var renderer = _gun.GetComponentInChildren<SpriteRenderer>();
            renderer.color = new Color(1, 0, 0, 1); // Red color
            var b = GameObject.Instantiate(_myPrefab);
            b.SetActive(true);
            b.transform.position = new Vector2(_gun.transform.position.x + 2,_gun.transform.position.y);
            var rb = b.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(1000, 0));	
        }
        else
        {
            var renderer = _gun.GetComponentInChildren<SpriteRenderer>();
            renderer.color = new Color(1, 1, 1, 1); // White color
        }
        // _rb.MovePosition(_rb.position + transform.right * _spd * Time.deltaTime);
    }
    
    public GameObject GetChildGameObject(GameObject fromGameObject, string withName)
    {
        var allKids = fromGameObject.GetComponentsInChildren<Transform>();
        var kid = allKids.FirstOrDefault(k => k.gameObject.name == withName);
        if (kid == null) return null;
        return kid.gameObject;
    }
}
