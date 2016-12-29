using UnityEngine;
using System.Collections;
using Swift;

public class LoginAgent : Agent_Logic
{
    void LoginCb(IReadableBuffer r)
    {

    }

    void ExpireCb(bool connected)
    {

    }

    public void Login(string uid, string pwd)
    {
        A.Request("Login", (IWriteableBuffer w) =>
        {
            w.Write(uid);
            w.Write(pwd);
        },
        LoginCb,
        ExpireCb
        );
    }
}
