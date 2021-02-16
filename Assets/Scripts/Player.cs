using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum OutHand //가위바위보 열거체
    {
        Rock,
        Scissors,
        Paper
    }
    private bool attackRight;    //공격권
    private OutHand outHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAttackRight(bool attackRight)
    {
        this.attackRight = attackRight;
    }

    public void SelectOutHand(OutHand outHand)
    {
        this.outHand = outHand;
    }
}
