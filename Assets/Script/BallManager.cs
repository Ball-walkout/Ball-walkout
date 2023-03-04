using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            GameManager.Instance.SetCoin(1);
            Destroy(other.gameObject);
        }
        else if(other.tag == "Obstacle")
        {
            // 장애물 종류별 스코어 변경 필요 **
            GameManager.Instance.SetScore(10);
            Destroy(other.gameObject, 1f);
        }
    }
}
