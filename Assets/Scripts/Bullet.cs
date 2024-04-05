using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public bool isMelee;
    public bool isRock;

    private void OnCollisionEnter(Collision collision)
    {
        //collision의 경우 여기선 bulletCase탄피에 해당함.
        if ((!isMelee && !isRock) && collision.gameObject.tag == "Floor")
        {
            Debug.Log("Rock도 근접콜리젼도 아닌경우만 floor collision시 삭제!" + isRock);
            Destroy(gameObject,3);
        }
        else if(!isMelee && collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Trigger의 경우 여기선 bullet발사체형상 자체를 의미함.
        if((!isMelee && !isRock) && other.gameObject.tag == "Floor")
        {
            Debug.Log("Rock도 근접콜리젼도 아닌경우만 floor trigger시 삭제!" + isRock);
            Destroy(gameObject,3);
        }
        else if(!isMelee && other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
