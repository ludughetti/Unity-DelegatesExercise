using System;
using UnityEngine;

public class DelegateConsumer : MonoBehaviour
{
    [SerializeField] private string secretData = "this is a secret that I'll only share through delegates >:)";
    
    public void ConsumeDelegate(DelegateGiveSecret giveSecret)
    {
        if(giveSecret != null)
        {
            giveSecret(secretData);
        } else
        {
            Console.WriteLine("GiveSecret is null!");
        }
    }
}
