using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    
    // Start is called before the first frame update
    

    public class CoinCounter : MonoBehaviour
{
    public int coins = 0;
    public Text coinText;
    
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coins;
    }
    public void AddCoins(int amount)
    {
        coins += amount;
    }
    //CoinCounter coinCounter = GameObject.Find("CoinManager").GetComponent<CoinCounter>();
    //coinCounter.AddCoins(10);
}
