using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConsumer : MonoBehaviour
{
    public void ReportPersonData(int personId, DelegateGetAge getAge, DelegateGetName getName, DelegateGetPostalCode getPostalCode)
    {
        string name = string.Empty;
        int age = -1;
        short postalCode = -1;

        var dataReport = string.Format("name: {0}, age: {1}, postal code: {2}", name, age, postalCode);
        Debug.Log($"{name}: Giving report on Data before update. {dataReport}");

        name = getName(personId);
        age = getAge(personId);
        postalCode = getPostalCode(personId);

        Debug.Log($"{name}: Giving report on Data after delegate update. {dataReport}");
    }
}
