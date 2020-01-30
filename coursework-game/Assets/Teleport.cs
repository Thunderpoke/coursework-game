using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{

    public GameObject Portal;
    public GameObject Player;

    void onTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Warp());
            Debug.Log("Test");
        }
    }
    IEnumerator Warp()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = new Vector2 (Portal.transform.position.x, Portal.transform.position.y);
    }


}