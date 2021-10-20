using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject bulletPrefabCube;
    public GameObject bulletPrefabSphere;
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
            ShotCube();
        }
        else if(Input.GetKeyDown(KeyCode.J))
        {
            ShotSphere();
        }
    }

//Hを押すと珠を打ち出す処理１
    public void ShotCube(){
        GameObject bullet =  Instantiate(bulletPrefabCube);
        bullet.transform.position = shotPos.position;
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        Vector3 front = shotPos.transform.forward;
        rigid.AddForce(front * shotPower, ForceMode.Impulse);
    }

//Jを押すと珠を打ち出す処理２
    public void ShotSphere(){
        GameObject bullet =  Instantiate(bulletPrefabSphere);
        bullet.transform.position = shotPos.position;
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        Vector3 front = shotPos.transform.forward;
        rigid.AddForce(front * shotPower, ForceMode.Impulse);
    }
}
