using UnityEngine;

public class ShowFlagsOnEnding : MonoBehaviour
{
    public GameObject RedFlags;
    public GameObject BlueFlags;
    public GameObject MixFlags;



    public void ShowRedFlags()
    {
        RedFlags.SetActive(true);
    }
    public void ShowBlueFlags()
    {
        BlueFlags.SetActive(true);
    }
    public void ShowMixFlags()
    {
        MixFlags.SetActive(true);
    }
}
