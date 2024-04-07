using UnityEngine;
using UnityEngine.UI;

public class ActivateObjectOnClick2 : MonoBehaviour
{
    public void OnclickExit()
    {
        GameObject.Find("UI").transform.Find("Lasagna_img").gameObject.SetActive(true);

    }
}
