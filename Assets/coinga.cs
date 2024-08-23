using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinga : MonoBehaviour
{
    public gamemanager gameMg;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameMg.coinAdd();
            Destroy(gameObject);
        }
    }
}
