using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRock : Bullet
{
    Rigidbody rigid;
    float angularPower = 2;
   // float scaleValue = 2f;
    bool isShoot;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(GainPowerTimer());
        StartCoroutine(GainPower());
    }

    IEnumerator GainPowerTimer() {
        yield return new WaitForSecondsRealtime(3.6f);
        isShoot = true;
    }

    IEnumerator GainPower()
    {
        while (!isShoot)
        {
            angularPower += 4f;
            //scaleValue += 0.6f;
           // transform.localScale = Vector3.one * scaleValue;
            //Debug.Log("BossRock gainPower rock localScale:" + Vector3.one * scaleValue+"/"+ scaleValue);
            Debug.Log("BossRock transform.right * angularPower:" + transform.right * angularPower + "/" + angularPower);
            rigid.AddTorque(transform.right * angularPower, ForceMode.Acceleration);
            yield return null;
        }
    }
}
