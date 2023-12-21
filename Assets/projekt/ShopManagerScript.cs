using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[2,3];
    public float Coins;
    public Text CoinsTXT;
    public TMPro.TextMeshProUGUI CoinText;

    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "Coins:" + Coins.ToString();

        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;

        //Price

        shopItems[2, 1] = 2;
        shopItems[2, 2] = 2;

        //Quantity

        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;

    }

    // Update is called once per frame
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectObject;

        if (Coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            Coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTXT.text = "Coins:" + Coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
    }
}
