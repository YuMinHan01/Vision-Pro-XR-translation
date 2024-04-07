using UnityEngine;
using UnityEngine.UI;

public class ActivateObjectOnClick : MonoBehaviour
{
    public void OnclickExit ()
    {
        //GameObject.Find("UI").transform.Find("Lasagna_img").gameObject.SetActive(true);
        GameObject.Find("UI").transform.Find("Lasagna_impo").gameObject.SetActive(true);
        GameObject.Find("UI").transform.Find("Canvas2").gameObject.SetActive(true);
    }
}
