using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei : MonoBehaviour
{
    // 当たった時に呼ばれる関数
    void OnTriggerEnter(Collider t)
    {
        Debug.Log("Hit"); // ログを表示する
        if (gameObject.CompareTag("Sozai"))
        {
            Destroy(gameObject);
        }
    }
}
