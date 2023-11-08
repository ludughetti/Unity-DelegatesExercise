using System;
using UnityEngine;

public delegate void DelegateGiveSecret(string secret);

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer consumer;

    public DelegateGiveSecret giveSecret;

    private void Start()
    {
        giveSecret = LogSecret;
    }

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        consumer.ConsumeDelegate(giveSecret);
    }

    private void LogSecret(string secret)
    {
        Console.WriteLine(secret);
    }
}
