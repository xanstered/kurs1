using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{

    private int Coin = 0;

    public TextMeshProUGUI CoinText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
            Coin++;
        CoinText.text = "Coin: " + Coin.ToString();
        Debug.Log(Coin);
        Destroy(other.gameObject);
    }
}
