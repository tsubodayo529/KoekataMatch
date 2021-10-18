using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shotPower;
    public Transform shotPos;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H)){
            Shot();
        }
    }

    public void Shot(){
        GameObject bullet =  Instantiate(bulletPrefab);
        bullet.transform.position = shotPos.position;
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        Vector3 front = shotPos.transform.forward;
        rigid.AddForce(front * shotPower, ForceMode.Impulse);
    }
}
