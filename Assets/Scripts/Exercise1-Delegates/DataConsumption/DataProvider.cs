using UnityEngine;

public delegate int DelegateGetAge(int personId);
public delegate string DelegateGetName(int personId);
public delegate short DelegateGetPostalCode(int personId);

public class DataProvider : MonoBehaviour
{
    [SerializeField] private DataConsumer dataConsumer;
    
    [SerializeField] private int genericAge = 18;
    [SerializeField] private string genericName = "name";
    [SerializeField] private short genericPostalCode = 1408;

    public DelegateGetAge delegateGetAge;
    public DelegateGetName delegateGetName;
    public DelegateGetPostalCode delegateGetPostalCode;

    private void Start()
    {
        delegateGetAge = GetAge;
        delegateGetName = GetName;
        delegateGetPostalCode = GetPostalCode;
    }

    private int GetAge(int personId)
    {
        return genericAge;
    }
    
    private string GetName(int personId)
    {
        return genericName;
    }
    
    private short GetPostalCode(int personId)
    {
        return genericPostalCode;
    }

    [ContextMenu("Test report")]
    private void TestReport()
    {
        dataConsumer.ReportPersonData(0, delegateGetAge, delegateGetName, delegateGetPostalCode);
    }
}