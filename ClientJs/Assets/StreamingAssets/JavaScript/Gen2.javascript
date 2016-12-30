Bridge.assembly("BridgeProj", function ($asm, globals) {
    "use strict";

    /** @namespace System */

    /**
     * @memberof System
     * @callback System.Action
     * @return  {void}
     */

    /**
     * 客户端游戏核心对象，引用所有逻辑模块并负责主要驱动
     *
     * @public
     * @class GameCore
     */
    Bridge.define("GameCore", {
        statics: {
            inst: null,
            config: {
                init: function () {
                    this.inst = new GameCore();
                }
            },
            getInstance: function () {
                return GameCore.inst;
            }
        },
        srvConn: null,
        core: null,
        core_Logic: null,
        config: {
            init: function () {
                this.core = new Swift.Core();
                this.core_Logic = new Swift.Core_Logic();
            }
        },
        getCurrentServerConnection: function () {
            return this.srvConn;
        },
        AddAgent: function (agent, comName, serverComName) {
            agent.getA().setServerComponentName(serverComName);
            this.core_Logic.Add$1(comName, agent);
        },
        Init: function () {
            this.AddAgent(new LoginAgent(), "LoginAgent", "LoginPort");

            // 显示登录界面
            var prefab = Bridge.cast(EditorEnv.LoadMainAssetAtPath("Assets/AssetBundles/Prefabs/LoginUI.prefab"), UnityEngine.GameObject);
            var go = UnityEngine.Object.Instantiate(UnityEngine.GameObject, prefab);
            var uiCanvas = UnityEngine.GameObject.Find("Root/UICanvas").gettransform();
            go.gettransform().SetParent$1(uiCanvas, false);
            go.AddComponent(LoginUI);
        },
        ConnectServer: function (ip, port, callback) {
            var nc = this.core.Get(Swift.NetCore);
            nc.Close();

            UnityEngine.Debug.Log(System.String.concat("ConnectServer ", ip, ":", port));

            nc.Connect2Peer$1(ip, port, Bridge.fn.bind(this, function (conn, reason) {
                this.ResetAllConnection(conn);
                callback(conn, reason);
            }));
        },
        CloseNetConnections: function () {
            var nc = this.core.Get(Swift.NetCore);
            nc.Close();
        },
        OnTimeElapsed: function (te) {
            this.core.RunOneFrame(te);
            this.core_Logic.RunOneFrame(te);
        },
        ResetAllConnection: function (conn) {
            this.srvConn = conn;
            var arr = this.core.getAll();
            for (var i = 0; i < arr.length; i = (i + 1) | 0) {
                var c = arr[i];
                if (Bridge.is(c, Swift.PortAgent)) {
                    var pa = Bridge.as(c, Swift.PortAgent);
                    pa.Setup(conn);
                }
            }
        }
    });

    /**
     * 缓动动画工具类
     *
     * @static
     * @abstract
     * @public
     * @class ItweenUtils
     */
    Bridge.define("ItweenUtils", {
        statics: {
            scale: 0,
            PopupLittleFrame: function (frame, alphaCallBack, endCallBack) {
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                frame.gettransform().setlocalScale(new UnityEngine.Vector3.$ctor2(0.6, 0.6, 0.6)); //clipped panel  缩放比必须一致
                ItweenUtils.Extend(frame, iTween.EaseType.easeOutBack, 0.15).Delay(0.05).OnComplete(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                alphaCallBack(0);
                ItweenUtils.Value0To1(frame, 0.1, alphaCallBack).Delay(0.05).Start();
            },
            PopupLittleFrameEnd: function (frame, alphaCallBack, endCallBack) {
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                ItweenUtils.StopTween(frame);
                ItweenUtils.ScaleTo(frame, new UnityEngine.Vector3.$ctor2(0.6, 0.6, 0.6), iTween.EaseType.easeInBack, 0.15).OnComplete(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                ItweenUtils.Value1To0(frame, 0.15, alphaCallBack).EaseType(iTween.EaseType.easeInSine).Start();
            },
            PopupFrame: function (frame, alphaCallBack, endCallBack) {
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                frame.gettransform().setlocalScale(new UnityEngine.Vector3.$ctor2(0.4, 0.4, 0.4)); //clipped panel  缩放比必须一致
                ItweenUtils.Extend(frame, iTween.EaseType.easeOutBack, 0.25).Delay(0.05).OnComplete(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                alphaCallBack(0);
                ItweenUtils.Value0To1(frame, 0.15, alphaCallBack).Delay(0.05).Start();
            },
            PopupFrameEnd: function (frame, alphaCallBack, endCallBack) {
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                ItweenUtils.StopTween(frame);
                ItweenUtils.ScaleTo(frame, new UnityEngine.Vector3.$ctor2(0.4, 0.4, 0.4), iTween.EaseType.easeInBack, 0.25).OnComplete(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                ItweenUtils.Value1To0(frame, 0.25, alphaCallBack).EaseType(iTween.EaseType.easeInSine).Start();
            },
            PopupBigFrame: function (frame, alphaCallBack, endCallBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                var scalePath = [new UnityEngine.Vector3.$ctor2(1.005, 1.005, 1.005), new UnityEngine.Vector3.$ctor2(1.015, 1.015, 1.015), new UnityEngine.Vector3.$ctor2(1.012, 1.012, 1.012), new UnityEngine.Vector3.$ctor2(1.003, 1.003, 1.003), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0)];
                frame.gettransform().setlocalScale(new UnityEngine.Vector3.$ctor2(0.0001, 0.0001, 0.0001));
                ItweenUtils.ScaleToPath(frame, scalePath, iTween.EaseType.easeOutSine, 0.25).Delay(0.05).OnComplete(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                if (!Bridge.staticEquals(alphaCallBack, null)) {
                    alphaCallBack(1);
                }
            },
            PopupBigFrameEnd: function (frame, endCallBack) {
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                var scalePath = [new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(1.01, 1.01, 1.01), new UnityEngine.Vector3.$ctor2(0.995, 0.995, 0.995), new UnityEngine.Vector3.$ctor2(0.96, 0.96, 0.96)];
                ItweenUtils.StopTween(frame);
                ItweenUtils.ScaleToPath(frame, scalePath, iTween.EaseType.easeOutSine, 0.2).OnComplete(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();
            },
            PopupNum: function (frame, delay, endCallBack) {
                if (delay === void 0) { delay = 0.0; }
                if (endCallBack === void 0) { endCallBack = null; }
                ItweenUtils.StopTween(frame);
                var scalePath = [new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(1.35, 1.35, 1.35), new UnityEngine.Vector3.$ctor2(1.5, 1.5, 1.5), new UnityEngine.Vector3.$ctor2(1.35, 1.35, 1.35), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(0.85, 0.85, 0.85), new UnityEngine.Vector3.$ctor2(0.95, 0.95, 0.95), new UnityEngine.Vector3.$ctor2(1.05, 1.05, 1.05), new UnityEngine.Vector3.$ctor2(1.15, 1.15, 1.15), new UnityEngine.Vector3.$ctor2(1.1, 1.1, 1.1), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0)];
                ItweenUtils.ScaleToPath(frame, scalePath, iTween.EaseType.linear, 0.35).Delay(delay).Start();

                if (!Bridge.staticEquals(endCallBack, null)) {
                    ItweenUtils.CallBackLater(frame, 0.35 + delay, endCallBack);
                }
            },
            PopupNum2: function (frame, delay, endCallBack) {
                if (delay === void 0) { delay = 0.0; }
                if (endCallBack === void 0) { endCallBack = null; }
                ItweenUtils.StopTween(frame);
                var scalePath = [new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(1.25, 1.25, 1.25), new UnityEngine.Vector3.$ctor2(1.35, 1.35, 1.35), new UnityEngine.Vector3.$ctor2(1.25, 1.25, 1.25), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(0.85, 0.85, 0.85), new UnityEngine.Vector3.$ctor2(0.95, 0.95, 0.95), new UnityEngine.Vector3.$ctor2(1.05, 1.05, 1.05), new UnityEngine.Vector3.$ctor2(1.1, 1.1, 1.1), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0)];
                ItweenUtils.ScaleToPath(frame, scalePath, iTween.EaseType.linear, 0.4).Delay(delay).Start();

                if (!Bridge.staticEquals(endCallBack, null)) {
                    ItweenUtils.CallBackLater(frame, 0.4 + delay, endCallBack);
                }
            },
            PopupNum3: function (frame, delay, endCallBack) {
                if (delay === void 0) { delay = 0.0; }
                if (endCallBack === void 0) { endCallBack = null; }
                ItweenUtils.StopTween(frame);
                var scalePath = [new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(1.15, 1.15, 1.15), new UnityEngine.Vector3.$ctor2(1.2, 1.2, 1.2), new UnityEngine.Vector3.$ctor2(1.15, 1.15, 1.15), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(0.9, 0.9, 0.9), new UnityEngine.Vector3.$ctor2(0.93, 0.93, 0.93), new UnityEngine.Vector3.$ctor2(1.03, 1.03, 1.03), new UnityEngine.Vector3.$ctor2(1.08, 1.08, 1.08), new UnityEngine.Vector3.$ctor2(1.04, 1.04, 1.04), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0)];
                ItweenUtils.ScaleToPath(frame, scalePath, iTween.EaseType.linear, 0.35).Delay(delay).Start();

                if (!Bridge.staticEquals(endCallBack, null)) {
                    ItweenUtils.CallBackLater(frame, 0.35 + delay, endCallBack);
                }
            },
            PopupNumFromZero: function (frame, delay, endCallBack) {
                if (delay === void 0) { delay = 0.0; }
                if (endCallBack === void 0) { endCallBack = null; }
                ItweenUtils.StopTween(frame);
                var scalePath = [new UnityEngine.Vector3.$ctor2(0.0, 0.0, 0.0), new UnityEngine.Vector3.$ctor2(0.8, 0.8, 0.8), new UnityEngine.Vector3.$ctor2(1.3, 1.3, 1.3), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(0.85, 0.85, 0.85), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), new UnityEngine.Vector3.$ctor2(1.1, 1.1, 1.1), new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0)];

                frame.gettransform().setlocalScale(UnityEngine.Vector3.getzero().$clone());
                ItweenUtils.ScaleToPath(frame, scalePath, iTween.EaseType.linear, 0.35).Delay(delay).Start();

                if (!Bridge.staticEquals(endCallBack, null)) {
                    ItweenUtils.CallBackLater(frame, 0.35 + delay, endCallBack);
                }
            },
            ShakeItem: function (frame, delay, endCallBack) {
                if (delay === void 0) { delay = 0.0; }
                if (endCallBack === void 0) { endCallBack = null; }
                ItweenUtils.StopTween(frame);
                var rotatePath = [new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, 15), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, -13.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, 11.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, -9.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, 7.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, -6), new UnityEngine.Vector3.$ctor2(0, 0, -4), new UnityEngine.Vector3.$ctor2(0, 0, 0)];
                ItweenUtils.RotateToPath(frame, rotatePath, 0.5).EaseType(iTween.EaseType.linear).Delay(delay).Start();

                if (!Bridge.staticEquals(endCallBack, null)) {
                    ItweenUtils.CallBackLater(frame, 0.5 + delay, endCallBack);
                }
            },
            ShakeDanmakuItem: function (frame, delay, endCallBack) {
                if (delay === void 0) { delay = 0.0; }
                if (endCallBack === void 0) { endCallBack = null; }
                var rotatePath = [new UnityEngine.Vector3.$ctor2(0, 0, -17), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, 15), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, -13.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, 11.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, -9.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, 7.0), new UnityEngine.Vector3.$ctor2(0, 0, 0), new UnityEngine.Vector3.$ctor2(0, 0, -6), new UnityEngine.Vector3.$ctor2(0, 0, -4), new UnityEngine.Vector3.$ctor2(0, 0, 0)];
                ItweenUtils.RotateToPath(frame, rotatePath, 0.5).EaseType(iTween.EaseType.linear).Delay(delay).Start();

                if (!Bridge.staticEquals(endCallBack, null)) {
                    ItweenUtils.CallBackLater(frame, 0.5 + delay, endCallBack);
                }
            },
            PullDownFrame: function (frame, alphaCallBack, endCallBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                frame.gettransform().setlocalPosition(new UnityEngine.Vector3.$ctor1(0, UnityEngine.Screen.getheight()));
                ItweenUtils.MoveTo(frame, UnityEngine.Vector3.op_Subtraction(frame.gettransform().getlocalPosition(), new UnityEngine.Vector3.$ctor2(0, UnityEngine.Screen.getheight(), 0)), iTween.EaseType.easeOutBack, 0.4).Delay(0.05).OnComplete$2(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                if (!Bridge.staticEquals(alphaCallBack, null)) {
                    alphaCallBack(0);
                    ItweenUtils.Value0To1(frame, 0.2, alphaCallBack).Delay(0.05).Start();
                }
            },
            PullDownFrameEnd: function (frame, alphaCallBack, endCallBack, isBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                if (isBack === void 0) { isBack = false; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                ItweenUtils.StopTween(frame);
                var easeTYpe = isBack ? iTween.EaseType.easeInExpo : iTween.EaseType.easeInSine;
                var time = isBack ? 0.4 : 0.3;

                ItweenUtils.MoveTo(frame, UnityEngine.Vector3.op_Addition(frame.gettransform().getlocalPosition(), new UnityEngine.Vector3.$ctor2(0, UnityEngine.Screen.getheight(), 0)), easeTYpe, time).OnComplete$2(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                if (!Bridge.staticEquals(alphaCallBack, null)) {
                    ItweenUtils.Value1To0(frame, 0.2, alphaCallBack).Start();
                }
            },
            PullDownFadeFrame: function (frame, alphaCallBack, endCallBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                frame.gettransform().setlocalPosition(new UnityEngine.Vector3.$ctor1(0, ((Bridge.Int.div(UnityEngine.Screen.getheight(), 2)) | 0)));
                ItweenUtils.MoveTo(frame, UnityEngine.Vector3.op_Subtraction(frame.gettransform().getlocalPosition(), new UnityEngine.Vector3.$ctor2(0, ((Bridge.Int.div(UnityEngine.Screen.getheight(), 2)) | 0), 0)), iTween.EaseType.easeOutBack, 0.3).Delay(0.05).OnComplete$2(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                if (!Bridge.staticEquals(alphaCallBack, null)) {
                    ItweenUtils.Value0To1(frame, 0.15, alphaCallBack).Delay(0.05).Start();
                }
            },
            PullDownFadeFrameEnd: function (frame, alphaCallBack, endCallBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                ItweenUtils.StopTween(frame);
                ItweenUtils.MoveTo(frame, UnityEngine.Vector3.op_Addition(frame.gettransform().getlocalPosition(), new UnityEngine.Vector3.$ctor2(0, ((Bridge.Int.div(UnityEngine.Screen.getheight(), 2)) | 0), 0)), iTween.EaseType.easeInSine, 0.3).OnComplete$2(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();

                if (!Bridge.staticEquals(alphaCallBack, null)) {
                    ItweenUtils.Value1To0(frame, 0.3, alphaCallBack).Start();
                }
            },
            PullRightFrame: function (frame, alphaCallBack, endCallBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                frame.gettransform().setlocalPosition(new UnityEngine.Vector3.$ctor1(((-UnityEngine.Screen.getwidth()) | 0) / 1.5, 0));
                ItweenUtils.MoveTo(frame, UnityEngine.Vector3.op_Addition(frame.gettransform().getlocalPosition(), new UnityEngine.Vector3.$ctor2(UnityEngine.Screen.getwidth() / 1.5, 0, 0)), iTween.EaseType.easeOutQuart, 0.3).Delay(0.05).OnComplete$2(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();
            },
            PullRightFrameEnd: function (frame, alphaCallBack, endCallBack) {
                if (alphaCallBack === void 0) { alphaCallBack = null; }
                if (endCallBack === void 0) { endCallBack = null; }
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
                ItweenUtils.StopTween(frame);
                ItweenUtils.MoveTo(frame, UnityEngine.Vector3.op_Addition(frame.gettransform().getlocalPosition(), new UnityEngine.Vector3.$ctor2(((-UnityEngine.Screen.getwidth()) | 0) / 1.5, 0, 0)), iTween.EaseType.easeInQuart, 0.3).OnComplete$2(function () {
                    ItweenUtils.EndCallBack(endCallBack);
                }).Start();
            },
            EndCallBack: function (call) {
                // TODO UnityEngine.Application.targetFrameRate = GameDriver.MinFrameRate;
                if (!Bridge.staticEquals(call, null)) {
                    call();
                }
            },
            MoveTo: function (go, point, easeType, time) {
                var t = new ItweenUtils.iTweenMoveTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("position", point.$clone());
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("time", time);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            MoveToSpeed: function (go, point, easeType, speed) {
                var t = new ItweenUtils.iTweenMoveTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("position", point.$clone());
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("speed", speed);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            MoveToPath: function (go, path, easeType, time) {
                var t = new ItweenUtils.iTweenMoveTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("path", path);
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("time", time);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            MoveToPath$1: function (go, path, easeType, time) {
                var t = new ItweenUtils.iTweenMoveTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.SetVector3Array("path", path);
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("time", time);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            MoveToPathSpeed: function (go, path, easeType, speed) {
                var t = new ItweenUtils.iTweenMoveTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.SetVector3Array("path", path);
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("speed", speed);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.GameObject}      go        
             * @param   {UnityEngine.GameObject}      target    
             * @param   {number}                      time
             * @return  {ItweenUtils.iTweenLookTo}
             */
            Look: function (go, target, time) {
                if (time === void 0) { time = 0.0; }
                var t = new ItweenUtils.iTweenLookTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("looktarget", target.gettransform());
                    t.dict.Set("time", time);
                }
                return t;
            },
            RotateBy: function (go, amount, time) {
                var t = new ItweenUtils.iTweenRotate(true, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("amount", amount.$clone());
                    t.dict.Set("time", time);
                    t.dict.SetEaseType(iTween.EaseType.linear);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            RotateTo: function (go, rotation, time) {
                var t = new ItweenUtils.iTweenRotate(false, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("rotation", rotation.$clone());
                    t.dict.Set("time", time);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            RotateToPath: function (go, path, time) {
                var t = new ItweenUtils.iTweenRotate(false, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("path", path);
                    t.dict.Set("time", time);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            RotateToPathSpeed: function (go, path, speed) {
                var t = new ItweenUtils.iTweenRotate(false, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("path", path);
                    t.dict.Set("time", 0);
                    t.dict.Set("speed", speed);
                    t.dict.Set("islocal", true);
                }
                return t;
            },
            RotateByX: function (go, x, time) {
                return ItweenUtils.RotateBy(go, new UnityEngine.Vector3.$ctor2(x, 0.0, 0.0), time);
            },
            RotateByY: function (go, y, time) {
                return ItweenUtils.RotateBy(go, new UnityEngine.Vector3.$ctor2(0.0, y, 0.0), time);
            },
            RotateByZ: function (go, z, time) {
                return ItweenUtils.RotateBy(go, new UnityEngine.Vector3.$ctor2(0.0, 0.0, z), time);
            },
            ScaleToPath: function (go, scalePath, easeType, time) {
                var t = new ItweenUtils.iTweenScaleTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.SetVector3Array("path", scalePath);
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("time", time);
                }
                return t;
            },
            ScaleTo: function (go, scale, easeType, time) {
                var t = new ItweenUtils.iTweenScaleTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("scale", scale.$clone());
                    t.dict.SetEaseType(easeType);
                    t.dict.Set("time", time);
                }
                return t;
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.GameObject}       go          
             * @param   {number}                       easeType    
             * @param   {number}                       time
             * @return  {ItweenUtils.iTweenScaleTo}
             */
            Extend: function (go, easeType, time) {
                return ItweenUtils.ScaleTo(go, new UnityEngine.Vector3.$ctor2(1.0, 1.0, 1.0), easeType, time);
            },
            HorizontalExtend: function (go, easeType, time) {
                return ItweenUtils.ScaleTo(go, new UnityEngine.Vector3.$ctor2(1.0, go.gettransform().getlocalScale().y, 1.0), easeType, time);
            },
            VerticalExtend: function (go, easeType, time) {
                return ItweenUtils.ScaleTo(go, new UnityEngine.Vector3.$ctor2(go.gettransform().getlocalScale().x, 1.0, 1.0), easeType, time);
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.GameObject}       go          
             * @param   {number}                       easeType    
             * @param   {number}                       time
             * @return  {ItweenUtils.iTweenScaleTo}
             */
            Shrink: function (go, easeType, time) {
                return ItweenUtils.ScaleTo(go, new UnityEngine.Vector3.$ctor2(0.0, 0.0, 0.0), easeType, time);
            },
            ValueTo: function (go, oldValue, newValue, time, callback) {
                var t = new ItweenUtils.iTweenValueTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("from", oldValue);
                    t.dict.Set("to", newValue);
                    t.dict.SetEaseType(iTween.EaseType.linear);
                    t.dict.Set("time", time);
                    t.dict.SetCb$2("onupdate", callback);
                }
                return t;
            },
            ValueToSpeed: function (go, oldValue, newValue, speed, callback) {
                var t = new ItweenUtils.iTweenValueTo(go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("from", oldValue);
                    t.dict.Set("to", newValue);
                    t.dict.SetEaseType(iTween.EaseType.linear);
                    t.dict.Set("time", Math.abs(newValue - oldValue) / speed);
                    t.dict.SetCb$2("onupdate", callback);
                }
                return t;
            },
            Value0To1: function (go, time, callback) {
                return ItweenUtils.ValueTo(go, 0.0, 1.0, time, callback);
            },
            Value1To0: function (go, time, callback) {
                return ItweenUtils.ValueTo(go, 1.0, 0.0, time, callback);
            },
            ShakePosition: function (go, x, y, z, time) {
                var t = new ItweenUtils.iTweenShake(true, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("x", x);
                    t.dict.Set("y", y);
                    t.dict.SetEaseType(iTween.EaseType.linear);
                    t.dict.Set("z", z);
                    t.dict.Set("islocal", true);
                    t.dict.Set("originalPos", UnityEngine.Vector3.getzero().$clone());
                    t.dict.Set("time", time);
                }
                return t;
            },
            ShakePosition$1: function (go, amount, time) {
                var t = new ItweenUtils.iTweenShake(true, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("amount", amount.$clone());
                    t.dict.SetEaseType(iTween.EaseType.linear);
                    t.dict.Set("islocal", true);
                    t.dict.Set("originalPos", UnityEngine.Vector3.getzero().$clone());
                    t.dict.Set("time", time);
                }
                return t;
            },
            ShakeRotationZ: function (go, z, time) {
                var t = new ItweenUtils.iTweenShake(false, go);
                {
                    t.dict = new iTween.iTweenDictionary.ctor();
                    t.dict.Set("z", z);
                    t.dict.Set("time", time);
                    t.dict.SetEaseType(iTween.EaseType.linear);
                }
                return t;
            },
            PauseTween: function (go) {
                iTween.Pause$2(go);
            },
            ResumeTween: function (go) {
                iTween.Resume$2(go);
            },
            StopTween: function (go) {
                iTween.Stop$2(go);
            },
            StopTween$1: function (go, type) {
                iTween.Stop$4(go, type);
            },
            StopByName: function (name) {
                iTween.StopByName(name);
            },
            HasTween: function (go) {
                return iTweenRoot.HasiTweens(go);
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.GameObject}    go          
             * @param   {number}                    time        
             * @param   {System.Action}             callback
             * @return  {void}
             */
            CallBackLater: function (go, time, callback) {
                var dict = new iTween.iTweenDictionary.ctor();
                dict.Set("time", time);
                dict.SetCb("onComplete", callback);
                iTween.CallBackLater(go, dict);
            },
            CallBackLater$1: function (go, time, callback, param) {
                var dict = new iTween.iTweenDictionary.ctor();
                dict.Set("time", time);
                dict.SetCb$1("onComplete", callback);
                dict.Set("onCompleteParams", param);
                iTween.CallBackLater(go, dict);
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point
             * @return  {UnityEngine.Vector3}
             */
            TopToTopRight: function (point) {
                return new UnityEngine.Vector3.$ctor1(point.x - (((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0)) / ItweenUtils.GetScale(), point.y);
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point
             * @return  {UnityEngine.Vector3}
             */
            TopToBottomLeft: function (point) {
                return new UnityEngine.Vector3.$ctor1(point.x + (((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0)) / ItweenUtils.GetScale(), point.y + UnityEngine.Screen.getheight() / ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point
             * @return  {UnityEngine.Vector3}
             */
            TopLeftToBottom: function (point) {
                return new UnityEngine.Vector3.$ctor1(point.x - (((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0)) / ItweenUtils.GetScale(), point.y + UnityEngine.Screen.getheight() / ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    position    
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            WorldToLeftBottom: function (position, camera) {
                var point = camera.WorldToScreenPoint(position.$clone()).$clone();
                return UnityEngine.Vector3.op_Division(new UnityEngine.Vector3.$ctor1(point.x, point.y), ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    position    
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            WorldToCenter: function (position, camera) {
                var point = camera.WorldToScreenPoint(position.$clone()).$clone();
                return UnityEngine.Vector3.op_Division(new UnityEngine.Vector3.$ctor1(point.x - ((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0), point.y - ((Bridge.Int.div(UnityEngine.Screen.getheight(), 2)) | 0)), ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    position    
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            WorldToTop: function (position, camera) {
                var point = camera.WorldToScreenPoint(position.$clone()).$clone();
                return UnityEngine.Vector3.op_Division(new UnityEngine.Vector3.$ctor1(point.x - ((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0), point.y - UnityEngine.Screen.getheight()), ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    position    
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            WorldToRightTop: function (position, camera) {
                var point = camera.WorldToScreenPoint(position.$clone()).$clone();
                return UnityEngine.Vector3.op_Division(new UnityEngine.Vector3.$ctor1(point.x - UnityEngine.Screen.getwidth(), point.y - UnityEngine.Screen.getheight()), ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    position    
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            WorldToRightBottom: function (position, camera) {
                var point = camera.WorldToScreenPoint(position.$clone()).$clone();
                return UnityEngine.Vector3.op_Division(new UnityEngine.Vector3.$ctor1(point.x - UnityEngine.Screen.getwidth(), point.y), ItweenUtils.GetScale());
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            BottomToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                point = UnityEngine.Vector3.op_Addition(point.$clone(), new UnityEngine.Vector3.$ctor1(((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0), 0));
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            LeftTopToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                point = UnityEngine.Vector3.op_Addition(point.$clone(), new UnityEngine.Vector3.$ctor1(0, UnityEngine.Screen.getheight()));
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            LeftToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                point = UnityEngine.Vector3.op_Addition(point.$clone(), new UnityEngine.Vector3.$ctor1(0, 0));
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            CenterToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                point = UnityEngine.Vector3.op_Addition(point.$clone(), new UnityEngine.Vector3.$ctor1(((Bridge.Int.div(UnityEngine.Screen.getwidth(), 2)) | 0), ((Bridge.Int.div(UnityEngine.Screen.getheight(), 2)) | 0)));
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            LeftBottomToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            RightTopToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                point = UnityEngine.Vector3.op_Addition(point.$clone(), new UnityEngine.Vector3.$ctor1(UnityEngine.Screen.getwidth(), UnityEngine.Screen.getheight()));
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {UnityEngine.Vector3}    point     
             * @param   {UnityEngine.Camera}     camera
             * @return  {UnityEngine.Vector3}
             */
            RightToWorld: function (point, camera) {
                point.x *= ItweenUtils.GetScale();
                point.y *= ItweenUtils.GetScale();
                point = UnityEngine.Vector3.op_Addition(point.$clone(), new UnityEngine.Vector3.$ctor1(UnityEngine.Screen.getwidth(), 0));
                var position = camera.ScreenToWorldPoint(point.$clone()).$clone();
                return position.$clone();
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {number}                           length    
             * @param   {UnityEngine.Transform}            parent
             * @return  {Array.<UnityEngine.Transform>}
             */
            CreatePath: function (length, parent) {
                var path = System.Array.init(length, null);
                var child = ItweenUtils.CreateEmpty("path", parent);
                for (var index = 0; index < length; index = (index + 1) | 0) {
                    var point = ItweenUtils.CreateEmpty("point" + index, child.gettransform());
                    path[index] = point.gettransform();
                }
                return path;
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {Array.<UnityEngine.Transform>}    path
             * @return  {void}
             */
            DestroyPath: function (path) {
                UnityEngine.Object.Destroy(path[0].gettransform().getparent().getgameObject());
                path = null;
            },
            /**
             * @static
             * @private
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @param   {string}                    name      
             * @param   {UnityEngine.Transform}     parent
             * @return  {UnityEngine.GameObject}
             */
            CreateEmpty: function (name, parent) {
                var go = new UnityEngine.GameObject.$ctor1(name);
                go.gettransform().setparent(parent);
                go.gettransform().setlocalPosition(UnityEngine.Vector3.getzero().$clone());
                go.gettransform().setlocalScale(UnityEngine.Vector3.getone().$clone());
                return go;
            },
            /**
             * @static
             * @public
             * @this ItweenUtils
             * @memberof ItweenUtils
             * @return  {number}
             */
            GetScale: function () {
                if (ItweenUtils.scale === 0) {
                    ItweenUtils.scale = 1;
                }
                return ItweenUtils.scale;
            }
        }
    });

    Bridge.define("ItweenUtils.iTweenAct", {
        dict: null,
        go: null,
        ctor: function (go) {
            this.$initialize();
            this.go = go;
        },
        Start: function () {
            UnityEngine.Debug.LogError("iTweenAct.Start should be override");
        },
        Stop: function () {
            iTween.Stop$2(this.go);
        },
        OnComplete: function (cb) {
            if (!Bridge.staticEquals(cb, null)) {
                this.dict.SetCb("onComplete", cb);
            }
            return this;
        },
        OnComplete$1: function (cb, param) {
            if (!Bridge.staticEquals(cb, null)) {
                this.dict.SetCb$1("onComplete", cb);
                this.dict.Set("onCompleteParams", param);
            }
            return this;
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

    Bridge.define("jsbExtension", {
        statics: {
            UpdateCoroutines: function (mb) {
                var elapsed = UnityEngine.Time.getdeltaTime();
            mb.$UpdateAllCoroutines(elapsed);
            mb.$UpdateAllInvokes(elapsed);
            }
        }
    });

    /** @namespace Swift */

    /**
     * 组件接口
     *
     * @public
     * @class Swift.Component_Logic
     */
    Bridge.define("Swift.Component_Logic", {
        FuncGetComponent: null,
        FuncRemoveComponent: null,
        FuncAddComponent: null,
        name: null,
        getName: function () {
            return this.name;
        },
        setName: function (value) {
            this.name = value;
        },
        GetComponent: function (str) {
            return this.FuncGetComponent(str);
        },
        RemoveComponent: function (str) {
            return this.FuncRemoveComponent(str);
        },
        AddComponent: function (str, com) {
            this.FuncAddComponent(str, com);
        },
        OnAdded: function () {
        },
        OnRemoved: function () {
        },
        Close: function () {
        },
        Clear: function () {

        }
    });

    Bridge.define("Msg", {
        statics: {
            msg: null,
            config: {
                init: function () {
                    this.msg = new Msg();
                }
            },
            Create: function (type) {
                Msg.msg.type = type;
                return Msg.msg;
            }
        },
        type: null,
        Set$3: function (k, v) {
            return this;
        },
        Set$1: function (k, v) {
            return this;
        },
        Set: function (k, v) {
            return this;
        },
        Set$2: function (k, v) {
            return this;
        },
        Set$4: function (k, v) {
            return this;
        },
        Send: function () {

        },
        Request: function (cb) {

        },
        Request$1: function (cb, cbExpire) {

        }
    });

    /** @namespace Nova */

    /**
     * 时间管理器接口
     *
     * @abstract
     * @public
     * @class Nova.ITimeMgr
     */
    Bridge.define("Nova.ITimeMgr", {
        $kind: "interface"
    });

    /**
     * 各种原因代码
     *
     * @public
     * @class Nova.ReasonEnums
     */
    Bridge.define("Nova.ReasonEnums", {
        $kind: "enum",
        statics: {
            Ok: 0,
            Failed: 1,
            TimeExpired: 2,
            Disconnected: 3,
            Login_NoName: 4,
            Login_NameTooShort: 5,
            Login_NameTooLong: 6,
            Login_NameHaveSp: 7,
            Login_NameInvalid: 8,
            Login_NameExists: 9,
            InvalidIDOrPWD: 10,
            Unknown: 11
        }
    });

    Bridge.define("Nova.SortUtils", {
        statics: {
            /**
             * 货币最大位数
             *
             * @static
             * @public
             * @memberof Nova.SortUtils
             * @constant
             * @default 5
             * @type number
             */
            MaxCount: 5,
            OrderBy: function (T, data, lessOrEqual) {
                for (var i = 0; i < data.length; i = (i + 1) | 0) {
                    var a = data[i];
                    for (var j = (i + 1) | 0; j < data.length; j = (j + 1) | 0) {
                        var b = data[j];
                        if (!lessOrEqual(a, b)) {
                            data[i] = b;
                            data[j] = a;
                        }
                    }
                }
            },
            DownConvertList: function (T1, T2, lst1, lst2) {
                var $t;
                lst2.clear();
                $t = Bridge.getEnumerator(lst1, null, T1);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    lst2.add(Bridge.cast(d, T2));
                }
            },
            DownConvertDict: function (T1, T2, T3, dict1, dict2) {
                var $t;
                dict2.clear();
                $t = Bridge.getEnumerator(dict1);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    dict2.set(d.key, Bridge.cast(d.value, T3));
                }
            },
            UpConvertList: function (T1, T2, lst1, lst2) {
                var $t;
                lst2.clear();
                $t = Bridge.getEnumerator(lst1, null, T1);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    lst2.add(d);
                }
            },
            UpConvertDict: function (T1, T2, T3, dict1, dict2) {
                var $t;
                dict2.clear();
                $t = Bridge.getEnumerator(dict1);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    dict2.set(d.key, d.value);
                }
            },
            MakeSureListMinSize: function (T, lst, minSize, dv) {
                while (lst.getCount() < minSize) {
                    lst.add(dv);
                }
            },
            /**
             * 将钱的数量转换成XXXX万格式 （如果数量大于最大显示长度maxCount,那么将以XXX万赖显示）
             *
             * @static
             * @public
             * @this Nova.SortUtils
             * @memberof Nova.SortUtils
             * @param   {number}    money       钱的数量
             * @param   {number}    maxCount    最大显示长度位数
             * @return  {string}
             */
            FormatMoney: function (money, maxCount) {
                if (maxCount === void 0) { maxCount = 5; }
                if (money.toString().length > maxCount) {
                    return System.String.format("{0}万", ((Bridge.Int.div(money, 10000)) | 0));
                } else {
                    return money.toString();
                }
            },
            SelectAll: function (T, list, f) {
                var $t;
                var allSel = new (System.Collections.Generic.List$1(T))();
                $t = Bridge.getEnumerator(list, null, T);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    if (f(d)) {
                        allSel.add(d);
                    }
                }

                return allSel.toArray();
            },
            Reserve2Decimal: function (f) {
                return System.String.format("{0}.{1}", Bridge.Int.clip32(f), System.String.alignString((Bridge.Int.clip32(f * 100) % 100).toString(), -2, 48));
            },
            SelectFirst: function (T, list, f) {
                var $t;
                $t = Bridge.getEnumerator(list, null, T);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    if (f(d)) {
                        return d;
                    }
                }

                return Bridge.getDefaultValue(T);
            },
            FindFirstPos: function (T, list, f) {
                var $t;
                var i = 0;
                $t = Bridge.getEnumerator(list, null, T);
                while ($t.moveNext()) {
                    var v = $t.getCurrent();
                    if (f(v)) {
                        return i;
                    } else {
                        i = (i + 1) | 0;
                    }
                }

                return -1;
            },
            FindFirstNullPos: function (T, list) {
                return Nova.SortUtils.FindFirstPos(T, list, $_.Nova.SortUtils.f1);
            },
            CountNoNull: function (T, list) {
                return Nova.SortUtils.Count(T, list, $_.Nova.SortUtils.f2);
            },
            Count: function (T, list, f) {
                var $t;
                var n = 0;
                $t = Bridge.getEnumerator(list, null, T);
                while ($t.moveNext()) {
                    var d = $t.getCurrent();
                    if (f(d)) {
                        n = (n + 1) | 0;
                    }
                }

                return n;
            }
        }
    });

    var $_ = {};

    Bridge.ns("Nova.SortUtils", $_);

    Bridge.apply($_.Nova.SortUtils, {
        f1: function (v) {
            return v == null;
        },
        f2: function (v) {
            return v != null;
        }
    });

    /**
     * 用户信息
     *
     * @public
     * @class Nova.UserInfo
     */
    Bridge.define("Nova.UserInfo", {
        statics: {
            ctor: function () {

            }
        },
        ID: null,
        Name: null,
        Password: null,
        Level: 0,
        Exp: 0,
        VipLevel: 0,
        VipExp: 0,
        Diamond: 0,
        BindDiamond: 0,
        ctor: function () {
            Nova.UserInfo.$ctor1.call(this, null);
        },
        $ctor1: function (userID) {
            this.$initialize();
            this.ID = userID;
        }
    });

    Bridge.define("Nova.Utils", {
        statics: {
            skipDrama: false,
            SkipGuide: false,
            getSystemMemSize: function () {
                return UnityEngine.SystemInfo.getsystemMemorySize();
            },
            getSystemVMemSize: function () {
                return UnityEngine.SystemInfo.getgraphicsMemorySize();
            },
            getDeviceID: function () {
                return UnityEngine.SystemInfo.getdeviceUniqueIdentifier();
            },
            getDeviceInfo: function () {
                return System.String.concat(UnityEngine.SystemInfo.getdeviceModel(), ",", UnityEngine.SystemInfo.getgraphicsDeviceName(), ",", UnityEngine.SystemInfo.getoperatingSystem(), ",", UnityEngine.SystemInfo.getsystemMemorySize(), ",", UnityEngine.SystemInfo.getgraphicsMemorySize(), ",", UnityEngine.SystemInfo.getdeviceUniqueIdentifier());
            },
            getSkipDrama: function () {
                return Nova.Utils.skipDrama;
            },
            setSkipDrama: function (value) {
                Nova.Utils.skipDrama = value;
            },
            AddChild$1: function (parent, child) {
                Nova.Utils.AddChild$2(parent, child.gettransform());
            },
            AddChild: function (parent, child) {
                Nova.Utils.AddChild$1(parent.gettransform(), child);
            },
            AddChild$2: function (parent, child) {
                child.SetParent(parent);
                child.setlocalPosition(UnityEngine.Vector3.getzero().$clone());
                child.setlocalScale(UnityEngine.Vector3.getone().$clone());
                child.setlocalRotation(UnityEngine.Quaternion.getidentity().$clone());
            },
            AddChild_Prefab: function (parent, prefab) {
                if (UnityEngine.Object.op_Inequality(parent, null) && UnityEngine.Object.op_Inequality(prefab, null)) {
                    var go = UnityEngine.Object.Instantiate(UnityEngine.GameObject, prefab);
                    go.gettransform().SetParent$1(parent, false);
                    Nova.Utils.AddChild$1(parent, go);
                    return go;
                }
                return null;
            },
            AddUIChild: function (parent, child) {
                // http://docs.unity3d.com/Manual/HOWTO-UICreateFromScripting.html
                child.gettransform().SetParent$1(parent, false);
            },
            ProcessAllChildren: function (p, d) {
                for (var i = 0; i < p.getchildCount(); i = (i + 1) | 0) {
                    d(p.GetChild(i).getgameObject());
                }
            },
            IndexOf: function (T, set, obj) {
                var $t;
                var i = 0;
                $t = Bridge.getEnumerator(set, null, T);
                while ($t.moveNext()) {
                    var e = $t.getCurrent();
                    if (Bridge.referenceEquals(e, obj)) {
                        return i;
                    } else {
                        i = (i + 1) | 0;
                    }
                }

                return -1;
            },
            GetUIRect: function (uiObj) {
                if (UnityEngine.Object.op_Inequality(uiObj.GetComponent(UnityEngine.UI.Image), null)) {
                    return uiObj.GetComponent(UnityEngine.UI.Image).GetPixelAdjustedRect();
                } else {
                    if (UnityEngine.Object.op_Inequality(uiObj.GetComponent(UnityEngine.UI.RawImage), null)) {
                        return uiObj.GetComponent(UnityEngine.UI.RawImage).GetPixelAdjustedRect();
                    } else {
                        return new UnityEngine.Rect.$ctor1(0, 0, 0, 0);
                    }
                }
            },
            TravelChildren: function (go, fun) {
                var $t;
                if (UnityEngine.Object.op_Equality(go, null) || Bridge.staticEquals(fun, null)) {
                    return;
                }

                var lst = new (System.Collections.Generic.List$1(UnityEngine.GameObject))();
                lst.add(go);
                while (lst.getCount() > 0) {
                    var arr = lst.toArray();
                    lst.clear();
                    $t = Bridge.getEnumerator(arr);
                    while ($t.moveNext()) {
                        var obj = $t.getCurrent();
                        fun(obj);
                        for (var i = 0; i < obj.gettransform().getchildCount(); i = (i + 1) | 0) {
                            lst.add(obj.gettransform().GetChild(i).getgameObject());
                        }
                    }
                }
            },
            CopyCameraParameters: function (src, dst) {
                var p = dst.gettransform().getparent();
                Nova.Utils.AddChild$2(src.gettransform(), dst.gettransform());
                dst.gettransform().setparent(p);

                dst.setfieldOfView(src.getfieldOfView());
                dst.setorthographic(src.getorthographic());
                dst.setnearClipPlane(src.getnearClipPlane());
                dst.setfarClipPlane(src.getfarClipPlane());
                dst.setaspect(src.getaspect());
                dst.setdepth(src.getdepth());
            },
            Travel: function (T, lst, fun) {
                var $t;
                $t = Bridge.getEnumerator(lst, null, T);
                while ($t.moveNext()) {
                    var e = $t.getCurrent();
                    fun(e);
                }
            }
        }
    });

    /**
     * 组件容器
     *
     * @public
     * @class Swift.ComponentContainer_Logic
     */
    Bridge.define("Swift.ComponentContainer_Logic", {
        components: null,
        lstComponents: null,
        modified: false,
        config: {
            events: {
                ComponentAdded: null,
                ComponentRemoved: null
            },
            init: function () {
                this.components = new (System.Collections.Generic.Dictionary$2(String,Swift.Component_Logic))();
                this.lstComponents = new (System.Collections.Generic.List$1(Swift.Component_Logic))();
            }
        },
        getAll: function () {
            var $t;
            if (this.modified) {
                this.lstComponents.clear();
                $t = Bridge.getEnumerator(this.components);
                while ($t.moveNext()) {
                    var KV = $t.getCurrent();
                    this.lstComponents.add(KV.value);
                }
                this.modified = false;
            }
            return this.lstComponents;
        },
        Get: function (T) {
            var lst = this.getAll();
            for (var i = 0; i < lst.getCount(); i = (i + 1) | 0) {
                var c = lst.getItem(i);
                if (Bridge.is(c, T)) {
                    return Bridge.as(c, T);
                }
            }

            return null;
        },
        GetByName: function (name) {
            if (this.components.containsKey(name)) {
                return this.components.get(name);
            } else {
                return null;
            }
        },
        Add: function (c) {
            if (c.getName() == null) {
                throw new System.Exception("Component_Logic has no name");
            } else {
                if (this.components.containsKey(c.getName())) {
                    throw new System.Exception(System.String.concat("Component_Logic name conflicted: ", c.getName()));
                }
            }

            this.components.set(c.getName(), c);
            this.modified = true;
            //c.Container = this;
            c.FuncGetComponent = Bridge.fn.bind(this, this.GetByName);
            c.FuncAddComponent = Bridge.fn.bind(this, this.Add$1);
            c.FuncRemoveComponent = Bridge.fn.bind(this, this.Remove);

            if (!Bridge.staticEquals(this.ComponentAdded, null)) {
                this.ComponentAdded(c);
            }
        },
        Add$1: function (name, c) {
            if (name != null && this.components.containsKey(name)) {
                throw new System.Exception(System.String.concat("Component_Logic has already got name: ", c.getName()));
            } else {
                if (this.components.containsKey(name)) {
                    throw new System.Exception(System.String.concat("Component_Logic name conflicted: ", c.getName()));
                }
            }

            c.setName(name);
            this.components.set(name, c);
            this.modified = true;
            //c.Container = this;
            c.FuncGetComponent = Bridge.fn.bind(this, this.GetByName);
            c.FuncAddComponent = Bridge.fn.bind(this, this.Add$1);
            c.FuncRemoveComponent = Bridge.fn.bind(this, this.Remove);
            c.OnAdded();

            if (!Bridge.staticEquals(this.ComponentAdded, null)) {
                this.ComponentAdded(c);
            }
        },
        Remove: function (name) {
            var c = null;

            if (this.components.containsKey(name)) {
                c = this.components.get(name);
                this.components.remove(name);
                this.modified = true;
                c.OnRemoved();

                if (!Bridge.staticEquals(this.ComponentRemoved, null)) {
                    this.ComponentRemoved(c);
                }
            }

            return c;
        }
    });

    Bridge.define("Swift.ConditionWaiter", {
        cch: null,
        ctor: function (handler) {
            this.$initialize();
            this.cch = handler;
        },
        getFinished: function () {
            return this.cch();
        }
    });

    /**
     * 核心类
     *
     * @public
     * @class Swift.Core_Logic
     */
    Bridge.define("Swift.Core_Logic", {
        cc: null,
        config: {
            init: function () {
                this.cc = new Swift.ComponentContainer_Logic();
            }
        },
        ctor: function () {
            this.$initialize();
        },
        Add$1: function (name, c) {
            this.cc.Add$1(name, c);
        },
        Add: function (c) {
            this.cc.Add(c);
        },
        Get: function (T) {
            return this.cc.Get(T);
        },
        Gets: function (T) {
            var lst = this.cc.getAll();
            var lst2 = new (System.Collections.Generic.List$1(T))();
            for (var i = 0; i < lst.getCount(); i = (i + 1) | 0) {
                var c = lst.getItem(i);
                if (Bridge.is(c, T)) {
                    lst2.add(Bridge.as(c, T));
                }
            }
            return lst2.toArray();
        },
        GetByName: function (T, name) {
            var c = this.cc.GetByName(name);
            if (Bridge.is(c, T)) {
                return Bridge.as(c, T);
            }

            return null;
        },
        GetByName$1: function (name) {
            return this.cc.GetByName(name);
        },
        Remove: function (name) {
            var lst = this.cc.getAll();
            for (var i = 0; i < lst.getCount(); i = (i + 1) | 0) {
                var c = lst.getItem(i);
                if (Bridge.referenceEquals(c.getName(), name)) {
                    this.cc.Remove(name);
                    return;
                }
            }
        },
        RunOneFrame: function (timeElapsed) {
            //PerformanceCounter counter = Get<PerformanceCounter>();
            //bool counterEnabled = counter != null;

            //if (counterEnabled)
            //{
            //    counter.Clear();
            //    counter.StartTag("FrameTotal");
            //}

            var lst = this.cc.getAll();
            for (var i = 0; i < lst.getCount(); i = (i + 1) | 0) {
                var c = lst.getItem(i);
                //                 if (counterEnabled)
                //                     counter.StartTag(c.Name);

                if (Bridge.is(c, Swift.IFrameDrived)) {
                    (Bridge.as(c, Swift.IFrameDrived)).Swift$IFrameDrived$OnTimeElapsed(timeElapsed);
                }

                //                 if (counterEnabled)
                //                     counter.EndTag(c.Name);
            }

            //             if (counterEnabled)
            //                 counter.EndTag("FrameTotal");
        },
        Close: function () {
            var lst = this.cc.getAll();
            for (var i = 0; i < lst.getCount(); i = (i + 1) | 0) {
                lst.getItem(i).Close();
            }
        }
    });

    /**
     * 协程接口
     *
     * @abstract
     * @public
     * @class Swift.ICoroutine
     */
    Bridge.define("Swift.ICoroutine", {
        $kind: "interface"
    });

    Bridge.define("Swift.EventWaiter", {
        set: false,
        arst: false,
        expired: false,
        interval: 0,
        t: 0,
        ctor: function () {
            Swift.EventWaiter.$ctor2.call(this, false, 0);
        },
        $ctor1: function (autoReset) {
            Swift.EventWaiter.$ctor2.call(this, autoReset, 0);
        },
        $ctor2: function (autoReset, timeout) {
            this.$initialize();
            this.arst = autoReset;
            this.interval = timeout;
            this.t = this.interval;
        },
        getExpired: function () {
            return this.expired;
        },
        getIsAutoReset: function () {
            return this.arst;
        },
        getIsSet: function () {
            return this.set;
        },
        TimeElapsed: function (te) {
            if (this.interval <= 0 || this.expired) {
                return;
            }

            this.t = (this.t - te) | 0;
            this.expired = (this.t <= 0);
        },
        Set: function () {
            this.set = true;
        },
        Reset: function () {
            this.set = false;
            this.t = this.interval;
        }
    });

    Bridge.define("Swift.FrameWaiter", {
        f: 0,
        ctor: function (frame) {
            this.$initialize();
            this.f = frame;
        }
    });

    Bridge.define("Swift.TimeWaiter", {
        t: 0,
        ctor: function (time) {
            this.$initialize();
            this.t = time;
        }
    });

    Bridge.define("Swift.YieldOp", {
        e: null,
        firstTime: false,
        ctor: function (e) {
            this.$initialize();
            this.e = e;
            this.firstTime = true;
        },
        Current: function () {
            if (this.firstTime) {
                this.firstTime = false;
                this.v = this.e.next();
            }
            return this.v.value;
        },
        MoveNext: function () {
            this.v = this.e.next();
            return !this.v.done;
        }
    });

    Bridge.define("UIAni", {
        $kind: "enum",
        statics: {
            None: 0
        }
    });

    /**
     * UI信息
     *
     * @public
     * @class UIInfo
     */
    Bridge.define("UIInfo", {
        type: 0,
        style: 0,
        layer: 0,
        resName: null,
        ui: null
    });

    /**
     * UI层级
     *
     * @public
     * @class UILayer
     */
    Bridge.define("UILayer", {
        $kind: "enum",
        statics: {
            Game: 0,
            Prepose: 1,
            Guide: 2,
            Test: 3
        }
    });

    Bridge.define("UIState", {
        $kind: "enum",
        statics: {
            None: 0,
            Initial: 1,
            Loading: 2,
            Ready: 3,
            Disabled: 4,
            Closing: 5
        }
    });

    /**
     * UI样式
     普通、全屏、模态等
     *
     * @public
     * @class UIStyle
     */
    Bridge.define("UIStyle", {
        $kind: "enum",
        statics: {
            Simple: 0,
            Full: 1,
            Modal: 2
        }
    });

    /**
     * UI类型，UI的唯一标识
     *
     * @public
     * @class UIType
     */
    Bridge.define("UIType", {
        $kind: "enum",
        statics: {
            LoginUI: 0,
            ServerList: 1,
            Loading: 2,
            AccountUI: 3,
            Dialog: 4
        }
    });

    Bridge.define("ItweenUtils.iTweenLookTo", {
        inherits: [ItweenUtils.iTweenAct],
        ctor: function (go) {
            this.$initialize();
            ItweenUtils.iTweenAct.ctor.call(this, go);

        },
        Start: function () {
            iTween.LookTo(this.go, this.dict);
        }
    });

    Bridge.define("ItweenUtils.iTweenMoveTo", {
        inherits: [ItweenUtils.iTweenAct],
        ctor: function (go) {
            this.$initialize();
            ItweenUtils.iTweenAct.ctor.call(this, go);

        },
        Delay: function (delay) {
            this.dict.Set("delay", delay);
            return this;
        },
        IsWorld: function () {
            this.dict.Set("islocal", false);
            return this;
        },
        Speed: function (speed) {
            this.dict.Set("speed", speed);
            return this;
        },
        Loop: function () {
            this.dict.SetLoopType(iTween.LoopType.loop);
            return this;
        },
        PingPong: function () {
            this.dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
        },
        Start: function () {
            iTween.MoveTo(this.go, this.dict);
        },
        LookTime: function (looktime) {
            this.dict.Set("looktime", looktime);
            return this;
        },
        LookTarget: function (target) {
            this.dict.Set("looktarget", target);
            return this;
        },
        OrientToPath: function () {
            this.dict.Set("orienttopath", true);
            return this;
        },
        Immediate: function () {
            this.dict.Set("moveToPath", false);
            return this;
        },
        OnComplete$2: function (cb) {
            return Bridge.cast(this.OnComplete(cb), ItweenUtils.iTweenMoveTo);
        }
    });

    Bridge.define("ItweenUtils.iTweenRotate", {
        inherits: [ItweenUtils.iTweenAct],
        isBy: true,
        ctor: function (isBy, go) {
            this.$initialize();
            ItweenUtils.iTweenAct.ctor.call(this, go);
            this.isBy = isBy;
        },
        Delay: function (delay) {
            this.dict.Set("delay", delay);
            return this;
        },
        EaseType: function (easeType) {
            this.dict.SetEaseType(easeType);
            return this;
        },
        Loop: function () {
            this.dict.SetLoopType(iTween.LoopType.loop);
            return this;
        },
        Start: function () {
            if (this.isBy) {
                iTween.RotateBy(this.go, this.dict);
            } else {
                iTween.RotateTo(this.go, this.dict);
            }
        }
    });

    Bridge.define("ItweenUtils.iTweenScaleTo", {
        inherits: [ItweenUtils.iTweenAct],
        ctor: function (go) {
            this.$initialize();
            ItweenUtils.iTweenAct.ctor.call(this, go);

        },
        Delay: function (delay) {
            this.dict.Set("delay", delay);
            return this;
        },
        PingPong: function () {
            this.dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
        },
        Loop: function () {
            this.dict.SetLoopType(iTween.LoopType.loop);
            return this;
        },
        Start: function () {
            iTween.ScaleTo(this.go, this.dict);
        }
    });

    Bridge.define("ItweenUtils.iTweenShake", {
        inherits: [ItweenUtils.iTweenAct],
        byPosition: true,
        ctor: function (byPosition, go) {
            this.$initialize();
            ItweenUtils.iTweenAct.ctor.call(this, go);
            this.byPosition = byPosition;
        },
        Loop: function () {
            this.dict.SetLoopType(iTween.LoopType.loop);
            return this;
        },
        PingPong: function () {
            this.dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
        },
        OriginalPos: function (originalPos) {
            this.dict.Set("originalPos", originalPos.$clone());
            return this;
        },
        Delay: function (delay) {
            this.dict.Set("delay", delay);
            return this;
        },
        Start: function () {
            if (UnityEngine.Time.gettimeScale() === 100) {
                return;
            }

            if (this.byPosition) {
                iTween.ShakePosition(this.go, this.dict);
            } else {
                iTween.ShakeRotation(this.go, this.dict);
            }
        }
    });

    Bridge.define("ItweenUtils.iTweenValueTo", {
        inherits: [ItweenUtils.iTweenAct],
        ctor: function (go) {
            this.$initialize();
            ItweenUtils.iTweenAct.ctor.call(this, go);

        },
        Delay: function (delay) {
            this.dict.Set("delay", delay);
            return this;
        },
        EaseType: function (easeType) {
            this.dict.SetEaseType(easeType);
            return this;
        },
        PingPong: function () {
            this.dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
        },
        Loop: function () {
            this.dict.SetLoopType(iTween.LoopType.loop);
            return this;
        },
        Start: function () {
            // shoule be override
            iTween.ValueTo(this.go, this.dict);
        }
    });

    Bridge.define("Swift.Agent_Logic", {
        inherits: [Swift.Component_Logic],
        agent: null,
        config: {
            init: function () {
                this.agent = new Swift.PortAgent();
            }
        },
        getA: function () {
            return this.agent;
        }
    });

    /**
     * 协程管理器
     *
     * @public
     * @class Swift.CoroutineManager
     * @augments Swift.Component
     * @implements  Swift.IFrameDrived
     */
    Bridge.define("Swift.CoroutineManager", {
        inherits: [Swift.Component,Swift.IFrameDrived],
        coroutineList: null,
        removed: null,
        config: {
            alias: [
            "OnTimeElapsed", "Swift$IFrameDrived$OnTimeElapsed"
            ],
            init: function () {
                this.coroutineList = new (System.Collections.Generic.List$1(Swift.CoroutineManager.Coroutine))();
                this.removed = new (System.Collections.Generic.List$1(Swift.CoroutineManager.Coroutine))();
            }
        },
        Stop: function (c) {
            this.coroutineList.remove(Bridge.cast(c, Swift.CoroutineManager.Coroutine));
        },
        Start: function (e) {
            return this.StartCoroutineInternal(e, false);
        },
        StartCoroutineInternal: function (e, runImmediately) {
            var c = new Swift.CoroutineManager.Coroutine(e);
            this.coroutineList.add(c);

            if (runImmediately) {
                c.Next(0);
            }

            return c;
        },
        OnTimeElapsed: function (te) {
            var $t, $t1;
            this.removed.clear();

            // 推动每个协程
            var list = this.coroutineList.toArray();
            $t = Bridge.getEnumerator(list);
            while ($t.moveNext()) {
                var c = $t.getCurrent();
                if (this.removed.contains(c)) {
                    continue;
                }

                if (!c.getFinished()) {
                    c.Next(te);
                }

                if (c.getFinished()) {
                    this.removed.add(c);
                }
            }

            // 把该移除的移除
            $t1 = Bridge.getEnumerator(this.removed);
            while ($t1.moveNext()) {
                var c1 = $t1.getCurrent();
                this.coroutineList.remove(c1);
            }
        }
    });

    /**
     * 协程
     *
     * @private
     * @class Swift.CoroutineManager.Coroutine
     * @implements  Swift.ICoroutine
     */
    Bridge.define("Swift.CoroutineManager.Coroutine", {
        inherits: [Swift.ICoroutine],
        op: null,
        finished: false,
        C: null,
        firstTime: true,
        config: {
            alias: [
            "getFinished", "Swift$ICoroutine$getFinished",
            "setFinished", "Swift$ICoroutine$setFinished"
            ]
        },
        ctor: function (enumerator) {
            this.$initialize();
            //e = enumerator;
            this.op = new Swift.YieldOp(enumerator);
        },
        getFinished: function () {
            return this.finished;
        },
        setFinished: function (value) {
            this.finished = value;
        },
        Next: function (te) {
            this.C = this.op.Current();

            if ((Bridge.is(this.C, Swift.TimeWaiter)) && Bridge.cast(this.C, Swift.TimeWaiter).t > 0) {
                Bridge.cast(this.C, Swift.TimeWaiter).t = (Bridge.cast(this.C, Swift.TimeWaiter).t - te) | 0;
            } else {
                if ((Bridge.is(this.C, Swift.FrameWaiter)) && Bridge.cast(this.C, Swift.FrameWaiter).f > 0) {
                    Bridge.cast(this.C, Swift.FrameWaiter).f = (Bridge.cast(this.C, Swift.FrameWaiter).f - 1) | 0;
                } else {
                    if ((Bridge.is(this.C, Swift.ConditionWaiter)) && !Bridge.cast(this.C, Swift.ConditionWaiter).getFinished()) {
                        return;
                    } else {
                        if (Bridge.is(this.C, Swift.EventWaiter)) {
                            var ew = Bridge.cast(this.C, Swift.EventWaiter);
                            if (!ew.getIsSet() && !ew.getExpired()) {
                                ew.TimeElapsed(te);
                                return;
                            } else {
                                this.finished = !this.op.MoveNext();
                                if (ew.getIsAutoReset()) {
                                    ew.Reset();
                                }
                            }
                        } else if ((Bridge.is(this.C, Swift.CoroutineManager.Coroutine)) && !Bridge.cast(this.C, Swift.CoroutineManager.Coroutine).getFinished()) {
                            return;
                        } else {
                            this.finished = !this.op.MoveNext();
                        }
                    }
                }
            }
        }
    });

    Bridge.define("Swift.CoroutineWaiter", {
        inherits: [Swift.ConditionWaiter],
        ctor: function (coroutine) {
            this.$initialize();
            Swift.ConditionWaiter.ctor.call(this, function () {
                return coroutine.Swift$ICoroutine$getFinished();
            });
        }
    });

    Bridge.define("LoginAgent", {
        inherits: [Swift.Agent_Logic],
        LoginCb: function (r) {

        },
        ExpireCb: function (connected) {

        },
        Login: function (uid, pwd) {
            this.getA().Request$1("Login", function (w) {
                w.Swift$IWriteableBuffer$Write$17(uid);
                w.Swift$IWriteableBuffer$Write$17(pwd);
            }, Bridge.fn.bind(this, this.LoginCb), Bridge.fn.bind(this, this.ExpireCb));
        }
    });

    Bridge.define("GameDriver", {
        inherits: [UnityEngine.MonoBehaviour],
        statics: {
            MaxFrameRate: 40,
            MinFrameRate: 30
        },
        Awake: function () {
            //设置目标帧率
            UnityEngine.Application.settargetFrameRate(GameDriver.MinFrameRate);

            // NOVA-1740
            // Disable screen dimming
            //Screen.sleepTimeout = SleepTimeout.NeverSleep;
        },
        Start: function () {
            GameCore.getInstance().Init();
        },
        FixedUpdate: function () {
            var te = Bridge.Int.clip32(UnityEngine.Time.getfixedDeltaTime() * 1000);
            GameCore.getInstance().OnTimeElapsed(te);
        }
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
            this.dict.set("TestVector3", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f2));
            this.dict.set("TestDictionary", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f3));
            this.dict.set("TestJSON", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f4));
            // 注意 TestCallJs 是 C# 脚本
            this.dict.set("TestInherit", Bridge.fn.bind(this, $_.jsb.Test.Logic.TestEntry.f5));

            var btnPrefab = this.gettransform().Find("ButtonPrefab").getgameObject();
            $t = Bridge.getEnumerator(this.dict);
            while ($t.moveNext()) {
                (function () {
                    var KV = $t.getCurrent();
                    var n = KV.key;
                    var go = UnityEngine.Object.Instantiate(UnityEngine.GameObject, btnPrefab);
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

    Bridge.ns("jsb.Test.Logic.TestEntry", $_);

    Bridge.apply($_.jsb.Test.Logic.TestEntry, {
        f1: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestCoroutine);
        },
        f2: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestVector3);
        },
        f3: function () {
            this.getgameObject().AddComponent$1(jsb.Test.Logic.TestDictionary);
        },
        f4: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestJSON);
        },
        f5: function () {
            this.getgameObject().AddComponent(jsb.Test.Logic.TestInherit1);
            this.getgameObject().AddComponent(jsb.Test.Logic.TestInherit2);
        }
    });

    Bridge.define("jsb.Test.Logic.TestInherit1", {
        inherits: [UnityEngine.MonoBehaviour]
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

    Bridge.define("LoginUI", {
        inherits: [UnityEngine.MonoBehaviour],
        Awake: function () {
            var btn = this.gettransform().FindChild("EnterGameBtn").GetComponent(UnityEngine.UI.Button);
            btn.getonClick().AddListener(Bridge.fn.bind(this, this.OnLoginClick));

            var clrs = btn.getcolors();
            ItweenUtils.Value0To1(btn.getgameObject(), 500.0, function (v) {
                var r = v * 500.0;
                r = r - Bridge.Int.clip32(r);

                var g = v * 200.0;
                g = g - Bridge.Int.clip32(g);

                var b = v * 100.0;
                b = b - Bridge.Int.clip32(b);

                clrs.setnormalColor(new UnityEngine.Color.$ctor2(r, g, b, 1.0));
                btn.setcolors(clrs);
            }).Start();
        },
        OnLoginClick: function () {
            //Nova.Utils.Md5
            UnityEngine.MonoBehaviour.print("Login!");
        }
    });

    Bridge.define("UIBase", {
        inherits: [UnityEngine.MonoBehaviour],
        UIInfo: null,
        Hide: function () {
            this.OnHide();
            this.getgameObject().SetActive(false);
        },
        /**
         * 仅首次显示前调用
         优先级高于Init
         *
         * @instance
         * @protected
         * @this UIBase
         * @memberof UIBase
         * @return  {void}
         */
        Awake: function () {

        },
        Start: function () {

        },
        /**
         * 界面初始化阶段（主要用于界面数据处理）
         每次开启界面都会调用一次
         不要在这里面播放UI动画相关操作
         *
         * @instance
         * @public
         * @this UIBase
         * @memberof UIBase
         * @param   {Array.<Object>}    _params
         * @return  {void}
         */
        OnInit: function (_params) {
            if (_params === void 0) { _params = []; }

        },
        /**
         * 界面显示阶段（相当于Start）
         可用于播放动画
         *
         * @instance
         * @protected
         * @this UIBase
         * @memberof UIBase
         * @return  {void}
         */
        OnShow: function () {

        },
        /**
         * 界面隐藏前调用
         *
         * @instance
         * @protected
         * @this UIBase
         * @memberof UIBase
         * @return  {void}
         */
        OnHide: function () {

        },
        /**
         * 每帧执行函数
         尽量不用，非必要时才用
         *
         * @instance
         * @protected
         * @this UIBase
         * @memberof UIBase
         * @param   {number}    _deltaTime
         * @return  {void}
         */
        OnUpdate: function (_deltaTime) {

        },
        /**
         * 当界面被卸载时
         *
         * @instance
         * @protected
         * @this UIBase
         * @memberof UIBase
         * @return  {void}
         */
        OnDestroy: function () {

        },
        /**
         * 每帧运行（内部函数）
         *
         * @instance
         * @private
         * @this UIBase
         * @memberof UIBase
         * @return  {void}
         */
        Update: function () {
            this.OnUpdate(UnityEngine.Time.getdeltaTime());
        }
    });

    Bridge.define("UIManager", {
        inherits: [UnityEngine.MonoBehaviour]
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
