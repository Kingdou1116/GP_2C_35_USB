using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collect : MonoBehaviour
{
    public GameObject Collect_object = null; // Textオブジェクト
    public int CollectNum = 0;
    public int Sozai = 0;
    // 初期化
    void Start()
    {
    }
    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text Collect_text = Collect_object.GetComponent<Text>();
        if (true)
        {
            CollectNum++;
            if (CollectNum > 3)
            {
                CollectNum = 0;
            }
        }
        // テキストの表示を入れ替える
        Collect_text.text = "Wood:" + CollectNum;
    }
}
