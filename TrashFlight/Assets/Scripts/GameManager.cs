using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// 게임의 전체적은 부분을 관리하기 때문에 Singleton 패턴 사용
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    private int coin = 0;

    public static GameManager instance = null;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void IncreaseCoin()
    {
        coin += 1;
        text.SetText(coin.ToString());
    }
}
