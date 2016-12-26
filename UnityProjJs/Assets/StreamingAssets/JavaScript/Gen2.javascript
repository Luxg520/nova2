Bridge.assembly("BridgeProj", function ($asm, globals) {
    "use strict";

    Bridge.define("jsbExtension", {
        statics: {
            UpdateCoroutines: function (mb) {
                var elapsed = UnityEngine.Time.getdeltaTime();
            mb.$UpdateAllCoroutines(elapsed);
            mb.$UpdateAllInvokes(elapsed);
            }
        }
    });
});

Bridge.assembly("BridgeProj", function ($asm, globals) {
    "use strict";

    Bridge.define("jsb.Test.Logic.EntityTriggerScript", {
        OnScirptInit: function (uSelfId) {
        },
        OnScirptTriggerEnter: function (uSelfId, uOtherEntityId) {
        },
        OnScirptTriggerExit: function (uSelfId, uOtherEntityId) {
        },
        OnScirptTriggerStay: function (uSelfId, uOtherEntityId) {
        },
        OnBeaten: function (uSelfId, uOtherEntityId) {
        },
        OnListenerEntityDead: function (uSelfId, uOtherEntityDeadId) {
        }
    });

    Bridge.define("jsb.Test.Logic.JSBInfo", {
        Version: "1.0",
        QQGroup: 189738580,
        getDocumentUrl: function () {
            return "http://www.cnblogs.com/answerwinner/p/6037911.html";
        }
    });

    Bridge.define("jsb.Test.Logic.Request10019", {
        itemID: 0,
        num: 0,
        optParams: null
    });

    Bridge.define("jsb.Test.Logic.Request10019.Opt", {
        selects: null
    });

    Bridge.define("jsb.Test.Logic.TestCallFromCs", {
        statics: {
            CreateJSBindingInfo: function () {
                return new jsb.Test.Logic.JSBInfo();
            }
        }
    });

    Bridge.define("jsb.Test.Logic.Y7777", {
        inherits: [jsb.Test.Logic.EntityTriggerScript]
    });

    Bridge.define("jsb.Test.Logic.TestCoroutine", {
        inherits: [UnityEngine.MonoBehaviour],
        Start: function () {
            this.StartCoroutine(this.Co());
        },
        Update: function () {
            jsbExtension.UpdateCoroutines(this);
        },
        Co: function* () {
            
            var c = 0;
            while (true) {
                yield (new UnityEngine.WaitForSeconds(1.0));
                UnityEngine.MonoBehaviour.print("我 " + (((c = (c + 1) | 0))));

                if (c >= 4) {
                    break;
                }
            }

            // JS 会打印这句，这是因为 yield break 不支持
            UnityEngine.MonoBehaviour.print("end of Co");
            
        }
    });

    Bridge.define("jsb.Test.Logic.TestDictionary", {
        inherits: [UnityEngine.MonoBehaviour],
        Start: function () {
            var $t;
            var dict = new (System.Collections.Generic.Dictionary$2(String,System.Int32))();
            dict.add("liudh", 50);
            dict.add("wuyz", 27);

            var age = { };
            if (dict.tryGetValue("liudh", age)) {
                UnityEngine.Debug.Log(System.String.concat("age: ", age.v.toString()));
            } else {
                UnityEngine.Debug.Log("not found");
            }
            $t = Bridge.getEnumerator(dict);
            while ($t.moveNext()) {
                var v = $t.getCurrent();
                UnityEngine.Debug.Log(System.String.concat(v.key.toString(), "->", v.value.toString()));
            }
        }
    });

    Bridge.define("jsb.Test.Logic.TestEntry", {
        inherits: [UnityEngine.MonoBehaviour],
        dict: null,
        Start: function () {
            var $t;
            this.dict = new (System.Collections.Generic.Dictionary$2(String,Function))();
            this.dict.set("TestCoroutine", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f1));
            this.dict.set("TestPerformance", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f2));
            this.dict.set("TestVector3", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f3));
            this.dict.set("TestDictionary", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f4));

            // 注意，如果是 JS ，AddComponent(string) 要传全名（包括命名空间和定义类）
            // 但是 CS 只要类名就可以了
            // 所以最好是用 AddComponent<T>
            var scriptName = "jsb.Test.Logic.TestInt64";

            this.dict.set("TestInt64", Bridge.fn.bind(this, function () {
                this.getgameObject().AddComponent$1(scriptName);
            }));
            this.dict.set("TestJSON", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f5));
            // 注意 TestCallJs 是 C# 脚本
            this.dict.set("TestCallJs", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f6));
            this.dict.set("TestInherit", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f7));

            var btnPrefab = this.gettransform().Find("ButtonPrefab").getgameObject();
            $t = Bridge.getEnumerator(this.dict);
            while ($t.moveNext()) {
                (function () {
                    var KV = $t.getCurrent();
                    var n = KV.key;
                    var go = Bridge.cast(UnityEngine.Object.Instantiate(btnPrefab), UnityEngine.GameObject);
                    var trans = go.gettransform();
                    go.setname(n);
                    trans.FindChild("Text").GetComponent(UnityEngine.UI.Text).settext(n);
                    go.SetActive(true);
                    go.GetComponent(UnityEngine.UI.Button).getonClick().AddListener(Bridge.fn.bind(this, function () {
                        this.OnClick(n);
                    }));
                    trans.SetParent$1(this.gettransform(), false);
                }).call(this);
            }
        },
        OnClick: function (n) {
            // 删除除了 TestEntry 之外的 JSComponent
            var mbs = this.GetComponents(UnityEngine.MonoBehaviour);
            for (var i = 0; i < mbs.length; i = (i + 1) | 0) {
                if (!(Bridge.is(mbs[i], jsb.Test.Logic.TestEntry))) {
                    UnityEngine.Object.DestroyImmediate(mbs[i]);
                }
            }

            this.dict.get(n)();
        }
    });

    var $_ = {};

    Bridge.ns("jsb.Test.Logic.TestEntry", $_);

    Bridge.apply($_.jsb.Test.Logic.TestEntry, {
        f1: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestCoroutine);
        },
        f2: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestPerformance);
        },
        f3: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestVector3);
        },
        f4: function () {
            this.getgameObject().AddComponent$2(jsb.Test.Logic.TestDictionary);
        },
        f5: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestJSON);
        },
        f6: function () {
            this.getgameObject().AddComponent(TestCallJs);
        },
        f7: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestInherit1);
            this.getgameObject().AddComponent(jsb.Test.Logic.TestInherit2);
        }
    });

    Bridge.define("jsb.Test.Logic.TestInherit1", {
        inherits: [UnityEngine.MonoBehaviour]
    });

    Bridge.define("jsb.Test.Logic.TestInt64", {
        inherits: [UnityEngine.MonoBehaviour],
        Start: function () {
            var ul = System.UInt64([-1,-1]); // 2^64-1
            UnityEngine.Debug.Log("Js(Logic) 传出 ulong：" + ul);
            jsb.Test.Framwork.TestMisc.SetUL(ul);

            var l = System.Int64([0,-2147483648]); // -2^63
            UnityEngine.Debug.Log("Js(Logic) 传出 long：" + l);
            jsb.Test.Framwork.TestMisc.SetL(l);

            jsb.Test.Framwork.TestMisc.GetL($_.jsb.Test.Logic.TestInt64.f1);

            jsb.Test.Framwork.TestMisc.GetUL($_.jsb.Test.Logic.TestInt64.f2);
        }
    });

    Bridge.ns("jsb.Test.Logic.TestInt64", $_);

    Bridge.apply($_.jsb.Test.Logic.TestInt64, {
        f1: function (_l) {
            UnityEngine.Debug.Log("Js(Logic) 收到 long：" + _l);
        },
        f2: function (_ul) {
            UnityEngine.Debug.Log("Js(Logic) 收到 ulong：" + _ul);
        }
    });

    Bridge.define("jsb.Test.Logic.TestJSON", {
        inherits: [UnityEngine.MonoBehaviour],
        Start: function () {
            var r = Bridge.merge(new jsb.Test.Logic.Request10019(), {
                itemID: 112,
                num: 2,
                optParams: Bridge.merge(new jsb.Test.Logic.Request10019.Opt(), {
                    selects: [5, 4, 8]
                } )
            } );
            var str = JSON.stringify(r);
            UnityEngine.MonoBehaviour.print(str);
        }
    });

    Bridge.define("jsb.Test.Logic.TestPerformance", {
        inherits: [UnityEngine.MonoBehaviour],
        statics: {
            Run: function (refObject) {
                jsb.Test.Framwork.TestPerformance.StaticObject.x = (jsb.Test.Framwork.TestPerformance.StaticObject.x + refObject.x) | 0;
                jsb.Test.Framwork.TestPerformance.StaticObject.y = (jsb.Test.Framwork.TestPerformance.StaticObject.y + refObject.y) | 0;
                return jsb.Test.Framwork.TestPerformance.StaticObject;
            }
        },
        mTransform: null,
        Start: function () {
            this.mTransform = this.gettransform();

            this.Test0();
            this.Test1();
            this.Test2();
            this.Test3();
            this.Test4();
            this.Test5();
            this.Test6();
        },
        Test0: function () {
            var N = 10000000;

            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            var g = 0;
            var f = 0;
            for (var i = 0; i < N; i = (i + 1) | 0) {
                g = (g + 1) | 0;
                f = (f + 1) | 0;
            }
            sw.stop();
            //         Debug.Log("loop count: " + N.ToString());
            //         Debug.Log("calc result: " + (f + g).ToString());
            UnityEngine.Debug.Log("test0 time: " + sw.milliseconds() + " ms");
        },
        Test1: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            var m = new UnityEngine.Vector3();
            for (var i = 0; i < 2000; i = (i + 1) | 0) {
                m = this.mTransform.getposition().$clone();

                this.mTransform.setposition(m.$clone());
            }
            UnityEngine.Debug.Log("test1 time: " + sw.milliseconds() + " ms");
        },
        Test2: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            var m = this.mTransform.getposition().$clone();
            for (var i = 0; i < 2000; i = (i + 1) | 0) {
                m = UnityEngine.Vector3.Normalize(m.$clone()).$clone();
            }
            UnityEngine.Debug.Log("test2 time: " + sw.milliseconds() + " ms");
        },
        Test3: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            var m = this.mTransform.getposition().$clone();
            for (var i = 0; i < 2000; i = (i + 1) | 0) {
                m.Normalize();
            }
            UnityEngine.Debug.Log("test3 time: " + sw.milliseconds() + " ms");
        },
        Test4: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            var m = this.mTransform.getposition().$clone();
            for (var i = 0; i < 2000; i = (i + 1) | 0) {
                this.mTransform.setposition(m.$clone());
            }
            UnityEngine.Debug.Log("test4 time: " + sw.milliseconds() + " ms");
        },
        Test5: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            for (var i = 0; i < 2000; i = (i + 1) | 0) {
                new UnityEngine.Vector3.$ctor2(i, i, i);
            }
            UnityEngine.Debug.Log("test5 time: " + sw.milliseconds() + " ms");
        },
        Test6: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            for (var i = 0; i < 50000; i = (i + 1) | 0) {
                var go = new UnityEngine.GameObject.$ctor1("init");
                UnityEngine.Object.DestroyImmediate(go);
            }

            UnityEngine.Debug.Log("test6 time: " + sw.milliseconds() + " ms");
        },
        Test7: function () {
            var sw = new System.Diagnostics.Stopwatch();
            sw.start();
            var obj = jsb.Test.Framwork.TestPerformance.StaticObject;
            for (var i = 0; i < 50000; i = (i + 1) | 0) {
                obj = jsb.Test.Logic.TestPerformance.Run(obj);
            }
            sw.stop();

            UnityEngine.Debug.Log("test7 time: " + sw.milliseconds() + " ms");
        },
        OnChangeEvent: function () {

        }
    });

    Bridge.define("jsb.Test.Logic.TestVector3", {
        inherits: [UnityEngine.MonoBehaviour],
        Start: function () {
            var sb = new System.Text.StringBuilder();
            var v = new UnityEngine.Vector3.$ctor2(2, 3, 6);
            var w = new UnityEngine.Vector3.$ctor2(7, 23, 1);

            var n = v.getnormalized().$clone();
            var arr = [n.x, n.y, n.z];
            UnityEngine.Debug.Log(sb.appendFormat.apply(sb, ["v.normalized = ({0}, {1}, {2})"].concat(arr)).toString());

            sb.remove(0, sb.getLength());
            var cross = UnityEngine.Vector3.Cross(v.$clone(), w.$clone()).$clone();
            arr = [cross.x, cross.y, cross.z];
            UnityEngine.Debug.Log(sb.appendFormat.apply(sb, ["Cross(v, w) = ({0}, {1}, {2})"].concat(arr)).toString());

            UnityEngine.Debug.Log("v.magnitude = " + System.Single.format(v.getmagnitude(), 'G'));
            UnityEngine.Debug.Log("w.magnitude = " + System.Single.format(w.getmagnitude(), 'G'));
            UnityEngine.Debug.Log("Dot(v, w) = " + System.Single.format(UnityEngine.Vector3.Dot(v.$clone(), w.$clone()), 'G'));
            UnityEngine.Debug.Log("Angle(v, w) = " + System.Single.format(UnityEngine.Vector3.Angle(v.$clone(), w.$clone()), 'G'));

            var proj = UnityEngine.Vector3.Project(v.$clone(), w.$clone()).$clone();
            UnityEngine.Debug.Log(System.String.concat("Project(v,w) = ", proj.ToString()));

            v.Normalize();
            w.Normalize();
            UnityEngine.Debug.Log(System.String.concat("normalized v = ", v.ToString()));
            UnityEngine.Debug.Log(System.String.concat("normalized w = ", w.ToString()));
        }
    });

    Bridge.define("jsb.Test.Logic.TestInherit2", {
        inherits: [jsb.Test.Logic.TestInherit1],
        Start: function () {
            var arr = this.GetComponents(jsb.Test.Logic.TestInherit1);
            UnityEngine.MonoBehaviour.print("arr.Length = " + arr.length);
        },
        OnGUI: function () {
            //print("ongui");
        }
    });
});

