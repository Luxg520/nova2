using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoginUI : MonoBehaviour
{
    void Awake()
    {
        Button btn = transform.FindChild("EnterGameBtn").GetComponent<Button>();
        btn.onClick.AddListener(this.OnLoginClick);

        var clrs = btn.colors;
        btn.gameObject.Value0To1(500f, (v) =>
        {
            float r = v * 500f;
            r = r - (int)r;

            float g = v * 200f;
            g = g - (int)g;

            float b = v * 100f;
            b = b - (int)b;

            clrs.normalColor = new Color(r, g, b, 1f);
            btn.colors = clrs;
        }).Start();
    }
    void OnLoginClick()
    {
        //Nova.Utils.Md5
        print("Login!");
    }
}
