using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDetection : MonoBehaviour
{
    public EnemyMovement enemyMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //   Debug.Log("Hit PLayer");
            enemyMovement.m_Follow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemyMovement.m_Follow = false;
        }
    }
}
