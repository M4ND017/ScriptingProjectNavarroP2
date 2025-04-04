using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletspeed;

    private Inventory inventory;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot ()
    {
        if(Input.GetButtonDown("Fire1")&& inventory.myStuff.bullet > 0)
        {
           Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletspeed);
            inventory.myStuff.bullet--;
        }
    }
}
