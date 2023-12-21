using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{

    private int Coin = 0;

    public TMPro.TextMeshProUGUI CoinText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
            Coin++;
        coinText.text = "Coins: " + Coin.ToString();
        Debug.Log(Coin);
        Destroy(other.gameObject);
    }
}
