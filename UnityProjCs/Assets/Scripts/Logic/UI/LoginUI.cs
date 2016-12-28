using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoginUI : MonoBehaviour
{
    void Awake()
    {
        Button btn = transform.FindChild("EnterGameBtn").GetComponent<Button>();
        btn.onClick.AddListener(this.OnLoginClick);
    }
    void OnLoginClick()
    {
        print("Login!");
    }
}
