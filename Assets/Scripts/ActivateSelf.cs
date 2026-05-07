using UnityEngine;

public class ActivateSelf : MonoBehaviour
{
    public int showself = 0;

    public GameObject SelfRefrence;

    // Update is called once per frame
    void Update()
    {
        if (showself >= 2)
        {
            
            SelfRefrence.SetActive(true);
        }
    }

    public void InvestigationUP()
    {
        Debug.Log("invest up");
        showself = showself + 1;
    }
}
