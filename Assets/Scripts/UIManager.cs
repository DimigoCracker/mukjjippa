using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image player1, player2, player1Hand, player2Hand;
    public Sprite muk, jji, ppa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LightOn()
        
    }
    public enum PlayerType
    {
        Player1, Player2
    }
    public void LightOn()
    {
        /*if (type == PlayerType.Player1)
        {
            player1.tintColor = Color.yellow;
        }
        else
        {
            player2.tintColor = Color.yellow;
        }*/
        player1.color = Color.yellow;
    }
    public void Hand(int type)
    {
        if((type & 4) == 0)
        {
            switch (type)
            {
                case 0: player1Hand.sprite = muk;
                    break;
                case 1: player1Hand.sprite = jji;
                    break;
                case 2: player1Hand.sprite = ppa;
                    break;
            }
        }
        else
        {
            switch (type & 3)
            {
                case 0:
                    player2Hand.sprite = muk;
                    break;
                case 1:
                    player2Hand.sprite = jji;
                    break;
                case 2:
                    player2Hand.sprite = ppa;
                    break;
            }
        }
        
    }
}
