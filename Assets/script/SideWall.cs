using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball") 
        {
            string wallName = transform.name;
            hitInfo.gameObject.SendMessage("RestartGame");
            GameManager.Instance.Score(wallName);
        }
    }
}
