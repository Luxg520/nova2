using System;
using UnityEngine;
using System.Collections;

public class Msg
{
    public Msg Set(string k, string v)
    {
        return this;
    }

    public Msg Set(string k, int v)
    {
        return this;
    }

    public Msg Set(string k, bool v)
    {
        return this;
    }

    public Msg Set(string k, long v)
    {
        return this;
    }

    public Msg Set(string k, ulong v)
    {
        return this;
    }

    public void Send()
    {
        
    }

    public void Request(Action<Msg> cb)
    {

    }

    public void Request(Action<Msg> cb, Action cbExpire)
    {

    }

    string type;

    static Msg msg = new Msg();
    public static Msg Create(string type)
    {
        msg.type = type;
        return msg;
    }
}
