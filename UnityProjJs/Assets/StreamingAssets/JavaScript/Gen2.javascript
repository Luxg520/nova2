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
        inited: false,
        Init: function () {
            if (this.inited) {
                return;
            }

            this.inited = true;

            // 显示登录界面
            var prefab = Bridge.cast(EditorEnv.LoadMainAssetAtPath("Assets/AssetBundles/Prefabs/LoginUI.prefab"), UnityEngine.GameObject);
            var go = UnityEngine.Object.Instantiate(UnityEngine.GameObject, prefab);
            var uiCanvas = UnityEngine.GameObject.Find("Root/UICanvas").gettransform();
            go.gettransform().SetParent$1(uiCanvas, false);
            go.AddComponent(LoginUI);
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

    Bridge.define("jsbExtension", {
        statics: {
            UpdateCoroutines: function (mb) {
                var elapsed = UnityEngine.Time.getdeltaTime();
            mb.$UpdateAllCoroutines(elapsed);
            mb.$UpdateAllInvokes(elapsed);
            }
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
            //int te = (int)(Time.fixedDeltaTime * 1000);
            //GameCore.Instance.OnTimeElapsed(te);
        }
    });

    Bridge.define("LoginUI", {
        inherits: [UnityEngine.MonoBehaviour],
        Awake: function () {
            var btn = this.gettransform().FindChild("EnterGameBtn").GetComponent(UnityEngine.UI.Button);
            btn.getonClick().AddListener(Bridge.fn.bind(this, this.OnLoginClick));
        },
        OnLoginClick: function () {
            UnityEngine.MonoBehaviour.print("Login!");
        }
    });
});

Bridge.assembly("BridgeProj", function ($asm, globals) {
    "use strict";

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

    var $_ = {};

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

