using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinCountText;

    // Start is called before the first frame update
    void Start()
    {
        coinCountText.text = "Coins: " + Coin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Coin++;
        coinCountText.text = "Coins: " + Coins.ToSring;
    }
}
