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
        //collision�� ��� ���⼱ bulletCaseź�ǿ� �ش���.
        if ((!isMelee && !isRock) && collision.gameObject.tag == "Floor")
        {
            Debug.Log("Rock�� �����ݸ����� �ƴѰ�츸 floor collision�� ����!" + isRock);
            Destroy(gameObject,3);
        }
        else if(!isMelee && collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Trigger�� ��� ���⼱ bullet�߻�ü���� ��ü�� �ǹ���.
        if((!isMelee && !isRock) && other.gameObject.tag == "Floor")
        {
            Debug.Log("Rock�� �����ݸ����� �ƴѰ�츸 floor trigger�� ����!" + isRock);
            Destroy(gameObject,3);
        }
        else if(!isMelee && other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
