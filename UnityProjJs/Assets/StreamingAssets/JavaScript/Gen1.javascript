
(function ($hc) {
    "use strict";
    if ($hc < 1) { return; }
     
    Bridge.define("System.Runtime.Serialization.ISerializable", {
        $kind: "interface",
        statics: {
        },
        GetObjectData: function (a0/* SerializationInfo */, a1/* StreamingContext */) { return CS.Call(4, 0, 0, false, this, a0, a1); },
    });
    if ($hc < 2) { return; }
     
    Bridge.define("UnityEngine.RaycastHit2D", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.RaycastHit2D(); },
            op_Implicit: function (a0/* RaycastHit2D */) { return CS.Call(4, 1, 1, true, a0); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.RaycastHit2D)) {
                return false;
            }
            return true;
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.RaycastHit2D();
            return s;
        },
        ctor: function () {
            CS.Call(5, 1, 0, true, this);
        },
        getcentroid: function () { return CS.Call(2, 1, 0, false, this); },
        setcentroid: function (v) { return CS.Call(3, 1, 0, false, this, v); },
        getcollider: function () { return CS.Call(2, 1, 1, false, this); },
        setcollider: function (v) { return CS.Call(3, 1, 1, false, this, v); },
        getdistance: function () { return CS.Call(2, 1, 2, false, this); },
        setdistance: function (v) { return CS.Call(3, 1, 2, false, this, v); },
        getfraction: function () { return CS.Call(2, 1, 3, false, this); },
        setfraction: function (v) { return CS.Call(3, 1, 3, false, this, v); },
        getnormal: function () { return CS.Call(2, 1, 4, false, this); },
        setnormal: function (v) { return CS.Call(3, 1, 4, false, this, v); },
        getpoint: function () { return CS.Call(2, 1, 5, false, this); },
        setpoint: function (v) { return CS.Call(3, 1, 5, false, this, v); },
        getrigidbody: function () { return CS.Call(2, 1, 6, false, this); },
        setrigidbody: function (v) { return CS.Call(3, 1, 6, false, this, v); },
        gettransform: function () { return CS.Call(2, 1, 7, false, this); },
        settransform: function (v) { return CS.Call(3, 1, 7, false, this, v); },
        CompareTo: function (a0/* RaycastHit2D */) { return CS.Call(4, 1, 0, false, this, a0); },
    });
    if ($hc < 3) { return; }
     
    Bridge.define("UnityEngine.UI.ICanvasElement", {
        $kind: "interface",
        statics: {
        },
        gettransform: function () { return CS.Call(2, 2, 0, false, this); },
        settransform: function (v) { return CS.Call(3, 2, 0, false, this, v); },
        IsDestroyed: function () { return CS.Call(4, 2, 0, false, this); },
        Rebuild: function (a0/* CanvasUpdate */) { return CS.Call(4, 2, 1, false, this, a0); },
    });
    if ($hc < 4) { return; }
     
    Bridge.define("UnityEngine.UI.ILayoutController", {
        $kind: "interface",
        statics: {
        },
        SetLayoutHorizontal: function () { return CS.Call(4, 3, 0, false, this); },
        SetLayoutVertical: function () { return CS.Call(4, 3, 1, false, this); },
    });
    if ($hc < 5) { return; }
     
    Bridge.define("UnityEngine.UI.IMaskable", {
        $kind: "interface",
        statics: {
        },
        ParentMaskStateChanged: function () { return CS.Call(4, 4, 0, false, this); },
    });
    if ($hc < 6) { return; }
     
    Bridge.define("UnityEngine.Collision2D", {
        statics: {
        },
        ctor: function () {
            CS.Call(5, 5, 0, true, this);
        },
        getcollider: function () { return CS.Call(2, 5, 0, false, this); },
        setcollider: function (v) { return CS.Call(3, 5, 0, false, this, v); },
        getcontacts: function () { return CS.Call(2, 5, 1, false, this); },
        setcontacts: function (v) { return CS.Call(3, 5, 1, false, this, v); },
        getgameObject: function () { return CS.Call(2, 5, 2, false, this); },
        setgameObject: function (v) { return CS.Call(3, 5, 2, false, this, v); },
        getrelativeVelocity: function () { return CS.Call(2, 5, 3, false, this); },
        setrelativeVelocity: function (v) { return CS.Call(3, 5, 3, false, this, v); },
        getrigidbody: function () { return CS.Call(2, 5, 4, false, this); },
        setrigidbody: function (v) { return CS.Call(3, 5, 4, false, this, v); },
        gettransform: function () { return CS.Call(2, 5, 5, false, this); },
        settransform: function (v) { return CS.Call(3, 5, 5, false, this, v); },
    });
    if ($hc < 7) { return; }
     
    Bridge.define("System.Runtime.Serialization.IDeserializationCallback", {
        $kind: "interface",
        statics: {
        },
        OnDeserialization: function (a0/* Object */) { return CS.Call(4, 6, 0, false, this, a0); },
    });
    if ($hc < 8) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IEventSystemHandler", {
        $kind: "interface",
        statics: {
        },
    });
    if ($hc < 9) { return; }
     
    Bridge.define("UnityEngine.LayerMask", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.LayerMask(); },
            GetMask: function (a0/* String[] */) { return CS.Call(4, 8, 0, true, a0); },
            LayerToName: function (a0/* Int32 */) { return CS.Call(4, 8, 1, true, a0); },
            NameToLayer: function (a0/* String */) { return CS.Call(4, 8, 2, true, a0); },
            op_Implicit: function (a0/* LayerMask */) { return CS.Call(4, 8, 3, true, a0); },
            op_Implicit$1: function (a0/* Int32 */) { return CS.Call(4, 8, 4, true, a0); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.LayerMask)) {
                return false;
            }
            return true;
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.LayerMask();
            return s;
        },
        ctor: function () {
            CS.Call(5, 8, 0, true, this);
        },
        getvalue: function () { return CS.Call(2, 8, 0, false, this); },
        setvalue: function (v) { return CS.Call(3, 8, 0, false, this, v); },
    });
    if ($hc < 10) { return; }
     
    Bridge.define("System.Collections.IDictionary", {
        inherits: [System.Collections.IEnumerable, System.Collections.ICollection],
        $kind: "interface",
        statics: {
        },
        getIsFixedSize: function () { return CS.Call(2, 9, 0, false, this); },
        setIsFixedSize: function (v) { return CS.Call(3, 9, 0, false, this, v); },
        getIsReadOnly: function () { return CS.Call(2, 9, 1, false, this); },
        setIsReadOnly: function (v) { return CS.Call(3, 9, 1, false, this, v); },
        getItem: function (ind0) { return CS.Call(2, 9, 2, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 9, 2, false, this, ind0, v); },
        getKeys: function () { return CS.Call(2, 9, 3, false, this); },
        setKeys: function (v) { return CS.Call(3, 9, 3, false, this, v); },
        getValues: function () { return CS.Call(2, 9, 4, false, this); },
        setValues: function (v) { return CS.Call(3, 9, 4, false, this, v); },
        Add: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 9, 0, false, this, a0, a1); },
        Clear: function () { return CS.Call(4, 9, 1, false, this); },
        Contains: function (a0/* Object */) { return CS.Call(4, 9, 2, false, this, a0); },
        GetEnumerator: function () { return CS.Call(4, 9, 3, false, this); },
        Remove: function (a0/* Object */) { return CS.Call(4, 9, 4, false, this, a0); },
    });
    if ($hc < 11) { return; }
     
    Bridge.define("UnityEngine.Physics2D", {
        statics: {
            $fields: {
                IgnoreRaycastLayer: {
                    get: function () { return CS.Call(0, 10, 0, true); },
                    set: function (v) { return CS.Call(1, 10, 0, true, v); }
                },
                DefaultRaycastLayers: {
                    get: function () { return CS.Call(0, 10, 1, true); },
                    set: function (v) { return CS.Call(1, 10, 1, true, v); }
                },
                AllLayers: {
                    get: function () { return CS.Call(0, 10, 2, true); },
                    set: function (v) { return CS.Call(1, 10, 2, true, v); }
                },
            },
            getangularSleepTolerance: function () { return CS.Call(2, 10, 0, true); },
            setangularSleepTolerance: function (v) { return CS.Call(3, 10, 0, true, v); },
            getbaumgarteScale: function () { return CS.Call(2, 10, 1, true); },
            setbaumgarteScale: function (v) { return CS.Call(3, 10, 1, true, v); },
            getbaumgarteTOIScale: function () { return CS.Call(2, 10, 2, true); },
            setbaumgarteTOIScale: function (v) { return CS.Call(3, 10, 2, true, v); },
            getchangeStopsCallbacks: function () { return CS.Call(2, 10, 3, true); },
            setchangeStopsCallbacks: function (v) { return CS.Call(3, 10, 3, true, v); },
            getgravity: function () { return CS.Call(2, 10, 4, true); },
            setgravity: function (v) { return CS.Call(3, 10, 4, true, v); },
            getlinearSleepTolerance: function () { return CS.Call(2, 10, 5, true); },
            setlinearSleepTolerance: function (v) { return CS.Call(3, 10, 5, true, v); },
            getmaxAngularCorrection: function () { return CS.Call(2, 10, 6, true); },
            setmaxAngularCorrection: function (v) { return CS.Call(3, 10, 6, true, v); },
            getmaxLinearCorrection: function () { return CS.Call(2, 10, 7, true); },
            setmaxLinearCorrection: function (v) { return CS.Call(3, 10, 7, true, v); },
            getmaxRotationSpeed: function () { return CS.Call(2, 10, 8, true); },
            setmaxRotationSpeed: function (v) { return CS.Call(3, 10, 8, true, v); },
            getmaxTranslationSpeed: function () { return CS.Call(2, 10, 9, true); },
            setmaxTranslationSpeed: function (v) { return CS.Call(3, 10, 9, true, v); },
            getminPenetrationForPenalty: function () { return CS.Call(2, 10, 10, true); },
            setminPenetrationForPenalty: function (v) { return CS.Call(3, 10, 10, true, v); },
            getpositionIterations: function () { return CS.Call(2, 10, 11, true); },
            setpositionIterations: function (v) { return CS.Call(3, 10, 11, true, v); },
            getraycastsHitTriggers: function () { return CS.Call(2, 10, 12, true); },
            setraycastsHitTriggers: function (v) { return CS.Call(3, 10, 12, true, v); },
            getraycastsStartInColliders: function () { return CS.Call(2, 10, 13, true); },
            setraycastsStartInColliders: function (v) { return CS.Call(3, 10, 13, true, v); },
            gettimeToSleep: function () { return CS.Call(2, 10, 14, true); },
            settimeToSleep: function (v) { return CS.Call(3, 10, 14, true, v); },
            getvelocityIterations: function () { return CS.Call(2, 10, 15, true); },
            setvelocityIterations: function (v) { return CS.Call(3, 10, 15, true, v); },
            getvelocityThreshold: function () { return CS.Call(2, 10, 16, true); },
            setvelocityThreshold: function (v) { return CS.Call(3, 10, 16, true, v); },
            BoxCast: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */) { return CS.Call(4, 10, 0, true, a0, a1, a2, a3); },
            BoxCast$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */) { return CS.Call(4, 10, 1, true, a0, a1, a2, a3, a4); },
            BoxCast$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */, a5/* Int32 */) { return CS.Call(4, 10, 2, true, a0, a1, a2, a3, a4, a5); },
            BoxCast$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */, a5/* Int32 */, a6/* Single */) { return CS.Call(4, 10, 3, true, a0, a1, a2, a3, a4, a5, a6); },
            BoxCast$4: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */, a5/* Int32 */, a6/* Single */, a7/* Single */) { return CS.Call(4, 10, 4, true, a0, a1, a2, a3, a4, a5, a6, a7); },
            BoxCastAll: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */) { return CS.Call(4, 10, 5, true, a0, a1, a2, a3); },
            BoxCastAll$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */) { return CS.Call(4, 10, 6, true, a0, a1, a2, a3, a4); },
            BoxCastAll$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */, a5/* Int32 */) { return CS.Call(4, 10, 7, true, a0, a1, a2, a3, a4, a5); },
            BoxCastAll$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */, a5/* Int32 */, a6/* Single */) { return CS.Call(4, 10, 8, true, a0, a1, a2, a3, a4, a5, a6); },
            BoxCastAll$4: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* Single */, a5/* Int32 */, a6/* Single */, a7/* Single */) { return CS.Call(4, 10, 9, true, a0, a1, a2, a3, a4, a5, a6, a7); },
            BoxCastNonAlloc: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* RaycastHit2D[] */) { return CS.Call(4, 10, 10, true, a0, a1, a2, a3, a4); },
            BoxCastNonAlloc$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* RaycastHit2D[] */, a5/* Single */) { return CS.Call(4, 10, 11, true, a0, a1, a2, a3, a4, a5); },
            BoxCastNonAlloc$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* RaycastHit2D[] */, a5/* Single */, a6/* Int32 */) { return CS.Call(4, 10, 12, true, a0, a1, a2, a3, a4, a5, a6); },
            BoxCastNonAlloc$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* RaycastHit2D[] */, a5/* Single */, a6/* Int32 */, a7/* Single */) { return CS.Call(4, 10, 13, true, a0, a1, a2, a3, a4, a5, a6, a7); },
            BoxCastNonAlloc$4: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Vector2 */, a4/* RaycastHit2D[] */, a5/* Single */, a6/* Int32 */, a7/* Single */, a8/* Single */) { return CS.Call(4, 10, 14, true, a0, a1, a2, a3, a4, a5, a6, a7, a8); },
            CircleCast: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */) { return CS.Call(4, 10, 15, true, a0, a1, a2); },
            CircleCast$1: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */) { return CS.Call(4, 10, 16, true, a0, a1, a2, a3); },
            CircleCast$2: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */, a4/* Int32 */) { return CS.Call(4, 10, 17, true, a0, a1, a2, a3, a4); },
            CircleCast$3: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */, a4/* Int32 */, a5/* Single */) { return CS.Call(4, 10, 18, true, a0, a1, a2, a3, a4, a5); },
            CircleCast$4: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */, a4/* Int32 */, a5/* Single */, a6/* Single */) { return CS.Call(4, 10, 19, true, a0, a1, a2, a3, a4, a5, a6); },
            CircleCastAll: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */) { return CS.Call(4, 10, 20, true, a0, a1, a2); },
            CircleCastAll$1: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */) { return CS.Call(4, 10, 21, true, a0, a1, a2, a3); },
            CircleCastAll$2: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */, a4/* Int32 */) { return CS.Call(4, 10, 22, true, a0, a1, a2, a3, a4); },
            CircleCastAll$3: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */, a4/* Int32 */, a5/* Single */) { return CS.Call(4, 10, 23, true, a0, a1, a2, a3, a4, a5); },
            CircleCastAll$4: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* Single */, a4/* Int32 */, a5/* Single */, a6/* Single */) { return CS.Call(4, 10, 24, true, a0, a1, a2, a3, a4, a5, a6); },
            CircleCastNonAlloc: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* RaycastHit2D[] */) { return CS.Call(4, 10, 25, true, a0, a1, a2, a3); },
            CircleCastNonAlloc$1: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* RaycastHit2D[] */, a4/* Single */) { return CS.Call(4, 10, 26, true, a0, a1, a2, a3, a4); },
            CircleCastNonAlloc$2: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* RaycastHit2D[] */, a4/* Single */, a5/* Int32 */) { return CS.Call(4, 10, 27, true, a0, a1, a2, a3, a4, a5); },
            CircleCastNonAlloc$3: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* RaycastHit2D[] */, a4/* Single */, a5/* Int32 */, a6/* Single */) { return CS.Call(4, 10, 28, true, a0, a1, a2, a3, a4, a5, a6); },
            CircleCastNonAlloc$4: function (a0/* Vector2 */, a1/* Single */, a2/* Vector2 */, a3/* RaycastHit2D[] */, a4/* Single */, a5/* Int32 */, a6/* Single */, a7/* Single */) { return CS.Call(4, 10, 29, true, a0, a1, a2, a3, a4, a5, a6, a7); },
            GetIgnoreCollision: function (a0/* Collider2D */, a1/* Collider2D */) { return CS.Call(4, 10, 30, true, a0, a1); },
            GetIgnoreLayerCollision: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 10, 31, true, a0, a1); },
            GetRayIntersection: function (a0/* Ray */) { return CS.Call(4, 10, 32, true, a0); },
            GetRayIntersection$1: function (a0/* Ray */, a1/* Single */) { return CS.Call(4, 10, 33, true, a0, a1); },
            GetRayIntersection$2: function (a0/* Ray */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 10, 34, true, a0, a1, a2); },
            GetRayIntersectionAll: function (a0/* Ray */) { return CS.Call(4, 10, 35, true, a0); },
            GetRayIntersectionAll$1: function (a0/* Ray */, a1/* Single */) { return CS.Call(4, 10, 36, true, a0, a1); },
            GetRayIntersectionAll$2: function (a0/* Ray */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 10, 37, true, a0, a1, a2); },
            GetRayIntersectionNonAlloc: function (a0/* Ray */, a1/* RaycastHit2D[] */) { return CS.Call(4, 10, 38, true, a0, a1); },
            GetRayIntersectionNonAlloc$1: function (a0/* Ray */, a1/* RaycastHit2D[] */, a2/* Single */) { return CS.Call(4, 10, 39, true, a0, a1, a2); },
            GetRayIntersectionNonAlloc$2: function (a0/* Ray */, a1/* RaycastHit2D[] */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 10, 40, true, a0, a1, a2, a3); },
            IgnoreCollision: function (a0/* Collider2D */, a1/* Collider2D */) { return CS.Call(4, 10, 41, true, a0, a1); },
            IgnoreCollision$1: function (a0/* Collider2D */, a1/* Collider2D */, a2/* Boolean */) { return CS.Call(4, 10, 42, true, a0, a1, a2); },
            IgnoreLayerCollision: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 10, 43, true, a0, a1); },
            IgnoreLayerCollision$1: function (a0/* Int32 */, a1/* Int32 */, a2/* Boolean */) { return CS.Call(4, 10, 44, true, a0, a1, a2); },
            Linecast: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 10, 45, true, a0, a1); },
            Linecast$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */) { return CS.Call(4, 10, 46, true, a0, a1, a2); },
            Linecast$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 47, true, a0, a1, a2, a3); },
            Linecast$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 48, true, a0, a1, a2, a3, a4); },
            LinecastAll: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 10, 49, true, a0, a1); },
            LinecastAll$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */) { return CS.Call(4, 10, 50, true, a0, a1, a2); },
            LinecastAll$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 51, true, a0, a1, a2, a3); },
            LinecastAll$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 52, true, a0, a1, a2, a3, a4); },
            LinecastNonAlloc: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */) { return CS.Call(4, 10, 53, true, a0, a1, a2); },
            LinecastNonAlloc$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Int32 */) { return CS.Call(4, 10, 54, true, a0, a1, a2, a3); },
            LinecastNonAlloc$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Int32 */, a4/* Single */) { return CS.Call(4, 10, 55, true, a0, a1, a2, a3, a4); },
            LinecastNonAlloc$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Int32 */, a4/* Single */, a5/* Single */) { return CS.Call(4, 10, 56, true, a0, a1, a2, a3, a4, a5); },
            OverlapArea: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 10, 57, true, a0, a1); },
            OverlapArea$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */) { return CS.Call(4, 10, 58, true, a0, a1, a2); },
            OverlapArea$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 59, true, a0, a1, a2, a3); },
            OverlapArea$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 60, true, a0, a1, a2, a3, a4); },
            OverlapAreaAll: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 10, 61, true, a0, a1); },
            OverlapAreaAll$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */) { return CS.Call(4, 10, 62, true, a0, a1, a2); },
            OverlapAreaAll$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 63, true, a0, a1, a2, a3); },
            OverlapAreaAll$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 64, true, a0, a1, a2, a3, a4); },
            OverlapAreaNonAlloc: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Collider2D[] */) { return CS.Call(4, 10, 65, true, a0, a1, a2); },
            OverlapAreaNonAlloc$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Collider2D[] */, a3/* Int32 */) { return CS.Call(4, 10, 66, true, a0, a1, a2, a3); },
            OverlapAreaNonAlloc$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Collider2D[] */, a3/* Int32 */, a4/* Single */) { return CS.Call(4, 10, 67, true, a0, a1, a2, a3, a4); },
            OverlapAreaNonAlloc$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Collider2D[] */, a3/* Int32 */, a4/* Single */, a5/* Single */) { return CS.Call(4, 10, 68, true, a0, a1, a2, a3, a4, a5); },
            OverlapCircle: function (a0/* Vector2 */, a1/* Single */) { return CS.Call(4, 10, 69, true, a0, a1); },
            OverlapCircle$1: function (a0/* Vector2 */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 10, 70, true, a0, a1, a2); },
            OverlapCircle$2: function (a0/* Vector2 */, a1/* Single */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 71, true, a0, a1, a2, a3); },
            OverlapCircle$3: function (a0/* Vector2 */, a1/* Single */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 72, true, a0, a1, a2, a3, a4); },
            OverlapCircleAll: function (a0/* Vector2 */, a1/* Single */) { return CS.Call(4, 10, 73, true, a0, a1); },
            OverlapCircleAll$1: function (a0/* Vector2 */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 10, 74, true, a0, a1, a2); },
            OverlapCircleAll$2: function (a0/* Vector2 */, a1/* Single */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 75, true, a0, a1, a2, a3); },
            OverlapCircleAll$3: function (a0/* Vector2 */, a1/* Single */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 76, true, a0, a1, a2, a3, a4); },
            OverlapCircleNonAlloc: function (a0/* Vector2 */, a1/* Single */, a2/* Collider2D[] */) { return CS.Call(4, 10, 77, true, a0, a1, a2); },
            OverlapCircleNonAlloc$1: function (a0/* Vector2 */, a1/* Single */, a2/* Collider2D[] */, a3/* Int32 */) { return CS.Call(4, 10, 78, true, a0, a1, a2, a3); },
            OverlapCircleNonAlloc$2: function (a0/* Vector2 */, a1/* Single */, a2/* Collider2D[] */, a3/* Int32 */, a4/* Single */) { return CS.Call(4, 10, 79, true, a0, a1, a2, a3, a4); },
            OverlapCircleNonAlloc$3: function (a0/* Vector2 */, a1/* Single */, a2/* Collider2D[] */, a3/* Int32 */, a4/* Single */, a5/* Single */) { return CS.Call(4, 10, 80, true, a0, a1, a2, a3, a4, a5); },
            OverlapPoint: function (a0/* Vector2 */) { return CS.Call(4, 10, 81, true, a0); },
            OverlapPoint$1: function (a0/* Vector2 */, a1/* Int32 */) { return CS.Call(4, 10, 82, true, a0, a1); },
            OverlapPoint$2: function (a0/* Vector2 */, a1/* Int32 */, a2/* Single */) { return CS.Call(4, 10, 83, true, a0, a1, a2); },
            OverlapPoint$3: function (a0/* Vector2 */, a1/* Int32 */, a2/* Single */, a3/* Single */) { return CS.Call(4, 10, 84, true, a0, a1, a2, a3); },
            OverlapPointAll: function (a0/* Vector2 */) { return CS.Call(4, 10, 85, true, a0); },
            OverlapPointAll$1: function (a0/* Vector2 */, a1/* Int32 */) { return CS.Call(4, 10, 86, true, a0, a1); },
            OverlapPointAll$2: function (a0/* Vector2 */, a1/* Int32 */, a2/* Single */) { return CS.Call(4, 10, 87, true, a0, a1, a2); },
            OverlapPointAll$3: function (a0/* Vector2 */, a1/* Int32 */, a2/* Single */, a3/* Single */) { return CS.Call(4, 10, 88, true, a0, a1, a2, a3); },
            OverlapPointNonAlloc: function (a0/* Vector2 */, a1/* Collider2D[] */) { return CS.Call(4, 10, 89, true, a0, a1); },
            OverlapPointNonAlloc$1: function (a0/* Vector2 */, a1/* Collider2D[] */, a2/* Int32 */) { return CS.Call(4, 10, 90, true, a0, a1, a2); },
            OverlapPointNonAlloc$2: function (a0/* Vector2 */, a1/* Collider2D[] */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 10, 91, true, a0, a1, a2, a3); },
            OverlapPointNonAlloc$3: function (a0/* Vector2 */, a1/* Collider2D[] */, a2/* Int32 */, a3/* Single */, a4/* Single */) { return CS.Call(4, 10, 92, true, a0, a1, a2, a3, a4); },
            Raycast: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 10, 93, true, a0, a1); },
            Raycast$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */) { return CS.Call(4, 10, 94, true, a0, a1, a2); },
            Raycast$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 10, 95, true, a0, a1, a2, a3); },
            Raycast$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Int32 */, a4/* Single */) { return CS.Call(4, 10, 96, true, a0, a1, a2, a3, a4); },
            Raycast$4: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Int32 */, a4/* Single */, a5/* Single */) { return CS.Call(4, 10, 97, true, a0, a1, a2, a3, a4, a5); },
            RaycastAll: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 10, 98, true, a0, a1); },
            RaycastAll$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */) { return CS.Call(4, 10, 99, true, a0, a1, a2); },
            RaycastAll$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 10, 100, true, a0, a1, a2, a3); },
            RaycastAll$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Int32 */, a4/* Single */) { return CS.Call(4, 10, 101, true, a0, a1, a2, a3, a4); },
            RaycastAll$4: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */, a3/* Int32 */, a4/* Single */, a5/* Single */) { return CS.Call(4, 10, 102, true, a0, a1, a2, a3, a4, a5); },
            RaycastNonAlloc: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */) { return CS.Call(4, 10, 103, true, a0, a1, a2); },
            RaycastNonAlloc$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Single */) { return CS.Call(4, 10, 104, true, a0, a1, a2, a3); },
            RaycastNonAlloc$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Single */, a4/* Int32 */) { return CS.Call(4, 10, 105, true, a0, a1, a2, a3, a4); },
            RaycastNonAlloc$3: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Single */, a4/* Int32 */, a5/* Single */) { return CS.Call(4, 10, 106, true, a0, a1, a2, a3, a4, a5); },
            RaycastNonAlloc$4: function (a0/* Vector2 */, a1/* Vector2 */, a2/* RaycastHit2D[] */, a3/* Single */, a4/* Int32 */, a5/* Single */, a6/* Single */) { return CS.Call(4, 10, 107, true, a0, a1, a2, a3, a4, a5, a6); },
        },
        ctor: function () {
            CS.Call(5, 10, 0, true, this);
        },
    });
    if ($hc < 12) { return; }
     
    Bridge.define("UnityEngine.Screen", {
        statics: {
            getautorotateToLandscapeLeft: function () { return CS.Call(2, 11, 0, true); },
            setautorotateToLandscapeLeft: function (v) { return CS.Call(3, 11, 0, true, v); },
            getautorotateToLandscapeRight: function () { return CS.Call(2, 11, 1, true); },
            setautorotateToLandscapeRight: function (v) { return CS.Call(3, 11, 1, true, v); },
            getautorotateToPortrait: function () { return CS.Call(2, 11, 2, true); },
            setautorotateToPortrait: function (v) { return CS.Call(3, 11, 2, true, v); },
            getautorotateToPortraitUpsideDown: function () { return CS.Call(2, 11, 3, true); },
            setautorotateToPortraitUpsideDown: function (v) { return CS.Call(3, 11, 3, true, v); },
            getcurrentResolution: function () { return CS.Call(2, 11, 4, true); },
            setcurrentResolution: function (v) { return CS.Call(3, 11, 4, true, v); },
            getdpi: function () { return CS.Call(2, 11, 5, true); },
            setdpi: function (v) { return CS.Call(3, 11, 5, true, v); },
            getfullScreen: function () { return CS.Call(2, 11, 6, true); },
            setfullScreen: function (v) { return CS.Call(3, 11, 6, true, v); },
            getGetResolution: function () { return CS.Call(2, 11, 7, true); },
            setGetResolution: function (v) { return CS.Call(3, 11, 7, true, v); },
            getheight: function () { return CS.Call(2, 11, 8, true); },
            setheight: function (v) { return CS.Call(3, 11, 8, true, v); },
            getlockCursor: function () { return CS.Call(2, 11, 9, true); },
            setlockCursor: function (v) { return CS.Call(3, 11, 9, true, v); },
            getorientation: function () { return CS.Call(2, 11, 10, true); },
            setorientation: function (v) { return CS.Call(3, 11, 10, true, v); },
            getresolutions: function () { return CS.Call(2, 11, 11, true); },
            setresolutions: function (v) { return CS.Call(3, 11, 11, true, v); },
            getshowCursor: function () { return CS.Call(2, 11, 12, true); },
            setshowCursor: function (v) { return CS.Call(3, 11, 12, true, v); },
            getsleepTimeout: function () { return CS.Call(2, 11, 13, true); },
            setsleepTimeout: function (v) { return CS.Call(3, 11, 13, true, v); },
            getwidth: function () { return CS.Call(2, 11, 14, true); },
            setwidth: function (v) { return CS.Call(3, 11, 14, true, v); },
            SetResolution: function (a0/* Int32 */, a1/* Int32 */, a2/* Boolean */) { return CS.Call(4, 11, 0, true, a0, a1, a2); },
            SetResolution$1: function (a0/* Int32 */, a1/* Int32 */, a2/* Boolean */, a3/* Int32 */) { return CS.Call(4, 11, 1, true, a0, a1, a2, a3); },
        },
        ctor: function () {
            CS.Call(5, 11, 0, true, this);
        },
    });
    if ($hc < 13) { return; }
     
    Bridge.define("UnityEngine.Quaternion", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.Quaternion(); },
            $fields: {
                kEpsilon: {
                    get: function () { return CS.Call(0, 12, 0, true); },
                    set: function (v) { return CS.Call(1, 12, 0, true, v); }
                },
            },
            getidentity: function () { return CS.Call(2, 12, 2, true); },
            setidentity: function (v) { return CS.Call(3, 12, 2, true, v); },
            Angle: function (a0/* Quaternion */, a1/* Quaternion */) { return CS.Call(4, 12, 9, true, a0, a1); },
            AngleAxis: function (a0/* Single */, a1/* Vector3 */) { return CS.Call(4, 12, 10, true, a0, a1); },
            Dot: function (a0/* Quaternion */, a1/* Quaternion */) { return CS.Call(4, 12, 11, true, a0, a1); },
            Euler: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 12, 12, true, a0, a1, a2); },
            Euler$1: function (a0/* Vector3 */) { return CS.Call(4, 12, 13, true, a0); },
            FromToRotation: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 12, 14, true, a0, a1); },
            Inverse: function (a0/* Quaternion */) { return CS.Call(4, 12, 15, true, a0); },
            Lerp: function (a0/* Quaternion */, a1/* Quaternion */, a2/* Single */) { return CS.Call(4, 12, 16, true, a0, a1, a2); },
            LookRotation: function (a0/* Vector3 */) { return CS.Call(4, 12, 17, true, a0); },
            LookRotation$1: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 12, 18, true, a0, a1); },
            op_Equality: function (a0/* Quaternion */, a1/* Quaternion */) { return CS.Call(4, 12, 19, true, a0, a1); },
            op_Inequality: function (a0/* Quaternion */, a1/* Quaternion */) { return CS.Call(4, 12, 20, true, a0, a1); },
            op_Multiply: function (a0/* Quaternion */, a1/* Quaternion */) { return CS.Call(4, 12, 21, true, a0, a1); },
            op_Multiply$1: function (a0/* Quaternion */, a1/* Vector3 */) { return CS.Call(4, 12, 22, true, a0, a1); },
            RotateTowards: function (a0/* Quaternion */, a1/* Quaternion */, a2/* Single */) { return CS.Call(4, 12, 23, true, a0, a1, a2); },
            Slerp: function (a0/* Quaternion */, a1/* Quaternion */, a2/* Single */) { return CS.Call(4, 12, 24, true, a0, a1, a2); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.Quaternion)) {
                return false;
            }
            Bridge.equals(this.kEpsilon, o.kEpsilon) && Bridge.equals(this.x, o.x) && Bridge.equals(this.y, o.y) && Bridge.equals(this.z, o.z) && Bridge.equals(this.w, o.w);
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.Quaternion();
            s.kEpsilon = this.kEpsilon;
            s.x = this.x;
            s.y = this.y;
            s.z = this.z;
            s.w = this.w;
            return s;
        },
        ctor: function () {
            CS.Call(5, 12, 0, true, this);
        },
        $ctor1: function (a0, a1, a2, a3) {
            CS.Call(5, 12, 1, true, this, a0, a1, a2, a3);
        },
        $fields: {
            x: {
                get: function () { return CS.Call(0, 12, 1, false, this); },
                set: function (v) { return CS.Call(1, 12, 1, false, this, v); }
            },
            y: {
                get: function () { return CS.Call(0, 12, 2, false, this); },
                set: function (v) { return CS.Call(1, 12, 2, false, this, v); }
            },
            z: {
                get: function () { return CS.Call(0, 12, 3, false, this); },
                set: function (v) { return CS.Call(1, 12, 3, false, this, v); }
            },
            w: {
                get: function () { return CS.Call(0, 12, 4, false, this); },
                set: function (v) { return CS.Call(1, 12, 4, false, this, v); }
            },
        },
        geteulerAngles: function () { return CS.Call(2, 12, 0, false, this); },
        seteulerAngles: function (v) { return CS.Call(3, 12, 0, false, this, v); },
        getItem: function (ind0) { return CS.Call(2, 12, 1, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 12, 1, false, this, ind0, v); },
        Equals: function (a0/* Object */) { return CS.Call(4, 12, 0, false, this, a0); },
        GetHashCode: function () { return CS.Call(4, 12, 1, false, this); },
        Set: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Single */) { return CS.Call(4, 12, 2, false, this, a0, a1, a2, a3); },
        SetFromToRotation: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 12, 3, false, this, a0, a1); },
        SetLookRotation: function (a0/* Vector3 */) { return CS.Call(4, 12, 4, false, this, a0); },
        SetLookRotation$1: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 12, 5, false, this, a0, a1); },
        ToAngleAxis: function (a0/* Single& */, a1/* Vector3& */) { return CS.Call(4, 12, 6, false, this, a0, a1); },
        ToString: function () { return CS.Call(4, 12, 7, false, this); },
        ToString$1: function (a0/* String */) { return CS.Call(4, 12, 8, false, this, a0); },
    });
    if ($hc < 14) { return; }
     
    Bridge.define("UnityEngine.Physics", {
        statics: {
            $fields: {
                kIgnoreRaycastLayer: {
                    get: function () { return CS.Call(0, 13, 0, true); },
                    set: function (v) { return CS.Call(1, 13, 0, true, v); }
                },
                kDefaultRaycastLayers: {
                    get: function () { return CS.Call(0, 13, 1, true); },
                    set: function (v) { return CS.Call(1, 13, 1, true, v); }
                },
                kAllLayers: {
                    get: function () { return CS.Call(0, 13, 2, true); },
                    set: function (v) { return CS.Call(1, 13, 2, true, v); }
                },
                IgnoreRaycastLayer: {
                    get: function () { return CS.Call(0, 13, 3, true); },
                    set: function (v) { return CS.Call(1, 13, 3, true, v); }
                },
                DefaultRaycastLayers: {
                    get: function () { return CS.Call(0, 13, 4, true); },
                    set: function (v) { return CS.Call(1, 13, 4, true, v); }
                },
                AllLayers: {
                    get: function () { return CS.Call(0, 13, 5, true); },
                    set: function (v) { return CS.Call(1, 13, 5, true, v); }
                },
            },
            getbounceThreshold: function () { return CS.Call(2, 13, 0, true); },
            setbounceThreshold: function (v) { return CS.Call(3, 13, 0, true, v); },
            getgravity: function () { return CS.Call(2, 13, 1, true); },
            setgravity: function (v) { return CS.Call(3, 13, 1, true, v); },
            getmaxAngularVelocity: function () { return CS.Call(2, 13, 2, true); },
            setmaxAngularVelocity: function (v) { return CS.Call(3, 13, 2, true, v); },
            getminPenetrationForPenalty: function () { return CS.Call(2, 13, 3, true); },
            setminPenetrationForPenalty: function (v) { return CS.Call(3, 13, 3, true, v); },
            getsleepAngularVelocity: function () { return CS.Call(2, 13, 4, true); },
            setsleepAngularVelocity: function (v) { return CS.Call(3, 13, 4, true, v); },
            getsleepVelocity: function () { return CS.Call(2, 13, 5, true); },
            setsleepVelocity: function (v) { return CS.Call(3, 13, 5, true, v); },
            getsolverIterationCount: function () { return CS.Call(2, 13, 6, true); },
            setsolverIterationCount: function (v) { return CS.Call(3, 13, 6, true, v); },
            CapsuleCast: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */) { return CS.Call(4, 13, 0, true, a0, a1, a2, a3); },
            CapsuleCast$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* Single */) { return CS.Call(4, 13, 1, true, a0, a1, a2, a3, a4); },
            CapsuleCast$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* Single */, a5/* Int32 */) { return CS.Call(4, 13, 2, true, a0, a1, a2, a3, a4, a5); },
            CapsuleCast$3: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* RaycastHit& */) { return CS.Call(4, 13, 3, true, a0, a1, a2, a3, a4); },
            CapsuleCast$4: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* RaycastHit& */, a5/* Single */) { return CS.Call(4, 13, 4, true, a0, a1, a2, a3, a4, a5); },
            CapsuleCast$5: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* RaycastHit& */, a5/* Single */, a6/* Int32 */) { return CS.Call(4, 13, 5, true, a0, a1, a2, a3, a4, a5, a6); },
            CapsuleCastAll: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */) { return CS.Call(4, 13, 6, true, a0, a1, a2, a3); },
            CapsuleCastAll$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* Single */) { return CS.Call(4, 13, 7, true, a0, a1, a2, a3, a4); },
            CapsuleCastAll$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Vector3 */, a4/* Single */, a5/* Int32 */) { return CS.Call(4, 13, 8, true, a0, a1, a2, a3, a4, a5); },
            CheckCapsule: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 13, 9, true, a0, a1, a2); },
            CheckCapsule$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 13, 10, true, a0, a1, a2, a3); },
            CheckSphere: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 13, 11, true, a0, a1); },
            CheckSphere$1: function (a0/* Vector3 */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 13, 12, true, a0, a1, a2); },
            GetIgnoreLayerCollision: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 13, 13, true, a0, a1); },
            IgnoreCollision: function (a0/* Collider */, a1/* Collider */) { return CS.Call(4, 13, 14, true, a0, a1); },
            IgnoreCollision$1: function (a0/* Collider */, a1/* Collider */, a2/* Boolean */) { return CS.Call(4, 13, 15, true, a0, a1, a2); },
            IgnoreLayerCollision: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 13, 16, true, a0, a1); },
            IgnoreLayerCollision$1: function (a0/* Int32 */, a1/* Int32 */, a2/* Boolean */) { return CS.Call(4, 13, 17, true, a0, a1, a2); },
            Linecast: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 13, 18, true, a0, a1); },
            Linecast$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Int32 */) { return CS.Call(4, 13, 19, true, a0, a1, a2); },
            Linecast$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* RaycastHit& */) { return CS.Call(4, 13, 20, true, a0, a1, a2); },
            Linecast$3: function (a0/* Vector3 */, a1/* Vector3 */, a2/* RaycastHit& */, a3/* Int32 */) { return CS.Call(4, 13, 21, true, a0, a1, a2, a3); },
            OverlapSphere: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 13, 22, true, a0, a1); },
            OverlapSphere$1: function (a0/* Vector3 */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 13, 23, true, a0, a1, a2); },
            Raycast: function (a0/* Ray */) { return CS.Call(4, 13, 24, true, a0); },
            Raycast$1: function (a0/* Ray */, a1/* Single */) { return CS.Call(4, 13, 25, true, a0, a1); },
            Raycast$2: function (a0/* Ray */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 13, 26, true, a0, a1, a2); },
            Raycast$3: function (a0/* Ray */, a1/* RaycastHit& */) { return CS.Call(4, 13, 27, true, a0, a1); },
            Raycast$4: function (a0/* Ray */, a1/* RaycastHit& */, a2/* Single */) { return CS.Call(4, 13, 28, true, a0, a1, a2); },
            Raycast$5: function (a0/* Ray */, a1/* RaycastHit& */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 13, 29, true, a0, a1, a2, a3); },
            Raycast$6: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 13, 30, true, a0, a1); },
            Raycast$7: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 13, 31, true, a0, a1, a2); },
            Raycast$8: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 13, 32, true, a0, a1, a2, a3); },
            Raycast$9: function (a0/* Vector3 */, a1/* Vector3 */, a2/* RaycastHit& */) { return CS.Call(4, 13, 33, true, a0, a1, a2); },
            Raycast$10: function (a0/* Vector3 */, a1/* Vector3 */, a2/* RaycastHit& */, a3/* Single */) { return CS.Call(4, 13, 34, true, a0, a1, a2, a3); },
            Raycast$11: function (a0/* Vector3 */, a1/* Vector3 */, a2/* RaycastHit& */, a3/* Single */, a4/* Int32 */) { return CS.Call(4, 13, 35, true, a0, a1, a2, a3, a4); },
            RaycastAll: function (a0/* Ray */) { return CS.Call(4, 13, 36, true, a0); },
            RaycastAll$1: function (a0/* Ray */, a1/* Single */) { return CS.Call(4, 13, 37, true, a0, a1); },
            RaycastAll$2: function (a0/* Ray */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 13, 38, true, a0, a1, a2); },
            RaycastAll$3: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 13, 39, true, a0, a1); },
            RaycastAll$4: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 13, 40, true, a0, a1, a2); },
            RaycastAll$5: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 13, 41, true, a0, a1, a2, a3); },
            SphereCast: function (a0/* Ray */, a1/* Single */) { return CS.Call(4, 13, 42, true, a0, a1); },
            SphereCast$1: function (a0/* Ray */, a1/* Single */, a2/* Single */) { return CS.Call(4, 13, 43, true, a0, a1, a2); },
            SphereCast$2: function (a0/* Ray */, a1/* Single */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 13, 44, true, a0, a1, a2, a3); },
            SphereCast$3: function (a0/* Ray */, a1/* Single */, a2/* RaycastHit& */) { return CS.Call(4, 13, 45, true, a0, a1, a2); },
            SphereCast$4: function (a0/* Ray */, a1/* Single */, a2/* RaycastHit& */, a3/* Single */) { return CS.Call(4, 13, 46, true, a0, a1, a2, a3); },
            SphereCast$5: function (a0/* Ray */, a1/* Single */, a2/* RaycastHit& */, a3/* Single */, a4/* Int32 */) { return CS.Call(4, 13, 47, true, a0, a1, a2, a3, a4); },
            SphereCast$6: function (a0/* Vector3 */, a1/* Single */, a2/* Vector3 */, a3/* RaycastHit& */) { return CS.Call(4, 13, 48, true, a0, a1, a2, a3); },
            SphereCast$7: function (a0/* Vector3 */, a1/* Single */, a2/* Vector3 */, a3/* RaycastHit& */, a4/* Single */) { return CS.Call(4, 13, 49, true, a0, a1, a2, a3, a4); },
            SphereCast$8: function (a0/* Vector3 */, a1/* Single */, a2/* Vector3 */, a3/* RaycastHit& */, a4/* Single */, a5/* Int32 */) { return CS.Call(4, 13, 50, true, a0, a1, a2, a3, a4, a5); },
            SphereCastAll: function (a0/* Ray */, a1/* Single */) { return CS.Call(4, 13, 51, true, a0, a1); },
            SphereCastAll$1: function (a0/* Ray */, a1/* Single */, a2/* Single */) { return CS.Call(4, 13, 52, true, a0, a1, a2); },
            SphereCastAll$2: function (a0/* Ray */, a1/* Single */, a2/* Single */, a3/* Int32 */) { return CS.Call(4, 13, 53, true, a0, a1, a2, a3); },
            SphereCastAll$3: function (a0/* Vector3 */, a1/* Single */, a2/* Vector3 */) { return CS.Call(4, 13, 54, true, a0, a1, a2); },
            SphereCastAll$4: function (a0/* Vector3 */, a1/* Single */, a2/* Vector3 */, a3/* Single */) { return CS.Call(4, 13, 55, true, a0, a1, a2, a3); },
            SphereCastAll$5: function (a0/* Vector3 */, a1/* Single */, a2/* Vector3 */, a3/* Single */, a4/* Int32 */) { return CS.Call(4, 13, 56, true, a0, a1, a2, a3, a4); },
        },
        ctor: function () {
            CS.Call(5, 13, 0, true, this);
        },
    });
    if ($hc < 15) { return; }
     
    Bridge.define("UnityEngine.Color", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.Color(); },
            getblack: function () { return CS.Call(2, 14, 4, true); },
            setblack: function (v) { return CS.Call(3, 14, 4, true, v); },
            getblue: function () { return CS.Call(2, 14, 5, true); },
            setblue: function (v) { return CS.Call(3, 14, 5, true, v); },
            getclear: function () { return CS.Call(2, 14, 6, true); },
            setclear: function (v) { return CS.Call(3, 14, 6, true, v); },
            getcyan: function () { return CS.Call(2, 14, 7, true); },
            setcyan: function (v) { return CS.Call(3, 14, 7, true, v); },
            getgray: function () { return CS.Call(2, 14, 8, true); },
            setgray: function (v) { return CS.Call(3, 14, 8, true, v); },
            getgreen: function () { return CS.Call(2, 14, 9, true); },
            setgreen: function (v) { return CS.Call(3, 14, 9, true, v); },
            getgrey: function () { return CS.Call(2, 14, 10, true); },
            setgrey: function (v) { return CS.Call(3, 14, 10, true, v); },
            getmagenta: function () { return CS.Call(2, 14, 11, true); },
            setmagenta: function (v) { return CS.Call(3, 14, 11, true, v); },
            getred: function () { return CS.Call(2, 14, 12, true); },
            setred: function (v) { return CS.Call(3, 14, 12, true, v); },
            getwhite: function () { return CS.Call(2, 14, 13, true); },
            setwhite: function (v) { return CS.Call(3, 14, 13, true, v); },
            getyellow: function () { return CS.Call(2, 14, 14, true); },
            setyellow: function (v) { return CS.Call(3, 14, 14, true, v); },
            Lerp: function (a0/* Color */, a1/* Color */, a2/* Single */) { return CS.Call(4, 14, 4, true, a0, a1, a2); },
            op_Addition: function (a0/* Color */, a1/* Color */) { return CS.Call(4, 14, 5, true, a0, a1); },
            op_Division: function (a0/* Color */, a1/* Single */) { return CS.Call(4, 14, 6, true, a0, a1); },
            op_Equality: function (a0/* Color */, a1/* Color */) { return CS.Call(4, 14, 7, true, a0, a1); },
            op_Implicit: function (a0/* Vector4 */) { return CS.Call(4, 14, 8, true, a0); },
            op_Implicit$1: function (a0/* Color */) { return CS.Call(4, 14, 9, true, a0); },
            op_Inequality: function (a0/* Color */, a1/* Color */) { return CS.Call(4, 14, 10, true, a0, a1); },
            op_Multiply: function (a0/* Single */, a1/* Color */) { return CS.Call(4, 14, 11, true, a0, a1); },
            op_Multiply$1: function (a0/* Color */, a1/* Single */) { return CS.Call(4, 14, 12, true, a0, a1); },
            op_Multiply$2: function (a0/* Color */, a1/* Color */) { return CS.Call(4, 14, 13, true, a0, a1); },
            op_Subtraction: function (a0/* Color */, a1/* Color */) { return CS.Call(4, 14, 14, true, a0, a1); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.Color)) {
                return false;
            }
            Bridge.equals(this.r, o.r) && Bridge.equals(this.g, o.g) && Bridge.equals(this.b, o.b) && Bridge.equals(this.a, o.a);
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.Color();
            s.r = this.r;
            s.g = this.g;
            s.b = this.b;
            s.a = this.a;
            return s;
        },
        ctor: function () {
            CS.Call(5, 14, 0, true, this);
        },
        $ctor1: function (a0, a1, a2) {
            CS.Call(5, 14, 1, true, this, a0, a1, a2);
        },
        $ctor2: function (a0, a1, a2, a3) {
            CS.Call(5, 14, 2, true, this, a0, a1, a2, a3);
        },
        $fields: {
            r: {
                get: function () { return CS.Call(0, 14, 0, false, this); },
                set: function (v) { return CS.Call(1, 14, 0, false, this, v); }
            },
            g: {
                get: function () { return CS.Call(0, 14, 1, false, this); },
                set: function (v) { return CS.Call(1, 14, 1, false, this, v); }
            },
            b: {
                get: function () { return CS.Call(0, 14, 2, false, this); },
                set: function (v) { return CS.Call(1, 14, 2, false, this, v); }
            },
            a: {
                get: function () { return CS.Call(0, 14, 3, false, this); },
                set: function (v) { return CS.Call(1, 14, 3, false, this, v); }
            },
        },
        getgamma: function () { return CS.Call(2, 14, 0, false, this); },
        setgamma: function (v) { return CS.Call(3, 14, 0, false, this, v); },
        getgrayscale: function () { return CS.Call(2, 14, 1, false, this); },
        setgrayscale: function (v) { return CS.Call(3, 14, 1, false, this, v); },
        getItem: function (ind0) { return CS.Call(2, 14, 2, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 14, 2, false, this, ind0, v); },
        getlinear: function () { return CS.Call(2, 14, 3, false, this); },
        setlinear: function (v) { return CS.Call(3, 14, 3, false, this, v); },
        Equals: function (a0/* Object */) { return CS.Call(4, 14, 0, false, this, a0); },
        GetHashCode: function () { return CS.Call(4, 14, 1, false, this); },
        ToString: function () { return CS.Call(4, 14, 2, false, this); },
        ToString$1: function (a0/* String */) { return CS.Call(4, 14, 3, false, this, a0); },
    });
    if ($hc < 16) { return; }
     
    Bridge.define("UnityEngine.Rect", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.Rect(); },
            MinMaxRect: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Single */) { return CS.Call(4, 15, 10, true, a0, a1, a2, a3); },
            NormalizedToPoint: function (a0/* Rect */, a1/* Vector2 */) { return CS.Call(4, 15, 11, true, a0, a1); },
            op_Equality: function (a0/* Rect */, a1/* Rect */) { return CS.Call(4, 15, 12, true, a0, a1); },
            op_Inequality: function (a0/* Rect */, a1/* Rect */) { return CS.Call(4, 15, 13, true, a0, a1); },
            PointToNormalized: function (a0/* Rect */, a1/* Vector2 */) { return CS.Call(4, 15, 14, true, a0, a1); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.Rect)) {
                return false;
            }
            return true;
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.Rect();
            return s;
        },
        ctor: function () {
            CS.Call(5, 15, 0, true, this);
        },
        $ctor1: function (a0, a1, a2, a3) {
            CS.Call(5, 15, 1, true, this, a0, a1, a2, a3);
        },
        $ctor2: function (a0) {
            CS.Call(5, 15, 2, true, this, a0);
        },
        getcenter: function () { return CS.Call(2, 15, 0, false, this); },
        setcenter: function (v) { return CS.Call(3, 15, 0, false, this, v); },
        getheight: function () { return CS.Call(2, 15, 1, false, this); },
        setheight: function (v) { return CS.Call(3, 15, 1, false, this, v); },
        getmax: function () { return CS.Call(2, 15, 2, false, this); },
        setmax: function (v) { return CS.Call(3, 15, 2, false, this, v); },
        getmin: function () { return CS.Call(2, 15, 3, false, this); },
        setmin: function (v) { return CS.Call(3, 15, 3, false, this, v); },
        getposition: function () { return CS.Call(2, 15, 4, false, this); },
        setposition: function (v) { return CS.Call(3, 15, 4, false, this, v); },
        getsize: function () { return CS.Call(2, 15, 5, false, this); },
        setsize: function (v) { return CS.Call(3, 15, 5, false, this, v); },
        getwidth: function () { return CS.Call(2, 15, 6, false, this); },
        setwidth: function (v) { return CS.Call(3, 15, 6, false, this, v); },
        getx: function () { return CS.Call(2, 15, 7, false, this); },
        setx: function (v) { return CS.Call(3, 15, 7, false, this, v); },
        getxMax: function () { return CS.Call(2, 15, 8, false, this); },
        setxMax: function (v) { return CS.Call(3, 15, 8, false, this, v); },
        getxMin: function () { return CS.Call(2, 15, 9, false, this); },
        setxMin: function (v) { return CS.Call(3, 15, 9, false, this, v); },
        gety: function () { return CS.Call(2, 15, 10, false, this); },
        sety: function (v) { return CS.Call(3, 15, 10, false, this, v); },
        getyMax: function () { return CS.Call(2, 15, 11, false, this); },
        setyMax: function (v) { return CS.Call(3, 15, 11, false, this, v); },
        getyMin: function () { return CS.Call(2, 15, 12, false, this); },
        setyMin: function (v) { return CS.Call(3, 15, 12, false, this, v); },
        Contains: function (a0/* Vector2 */) { return CS.Call(4, 15, 0, false, this, a0); },
        Contains$1: function (a0/* Vector3 */) { return CS.Call(4, 15, 1, false, this, a0); },
        Contains$2: function (a0/* Vector3 */, a1/* Boolean */) { return CS.Call(4, 15, 2, false, this, a0, a1); },
        Equals: function (a0/* Object */) { return CS.Call(4, 15, 3, false, this, a0); },
        GetHashCode: function () { return CS.Call(4, 15, 4, false, this); },
        Overlaps: function (a0/* Rect */) { return CS.Call(4, 15, 5, false, this, a0); },
        Overlaps$1: function (a0/* Rect */, a1/* Boolean */) { return CS.Call(4, 15, 6, false, this, a0, a1); },
        Set: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Single */) { return CS.Call(4, 15, 7, false, this, a0, a1, a2, a3); },
        ToString: function () { return CS.Call(4, 15, 8, false, this); },
        ToString$1: function (a0/* String */) { return CS.Call(4, 15, 9, false, this, a0); },
    });
    if ($hc < 17) { return; }
     
    Bridge.define("UnityEngine.Mathf", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.Mathf(); },
            $fields: {
                PI: {
                    get: function () { return CS.Call(0, 16, 0, true); },
                    set: function (v) { return CS.Call(1, 16, 0, true, v); }
                },
                Infinity: {
                    get: function () { return CS.Call(0, 16, 1, true); },
                    set: function (v) { return CS.Call(1, 16, 1, true, v); }
                },
                NegativeInfinity: {
                    get: function () { return CS.Call(0, 16, 2, true); },
                    set: function (v) { return CS.Call(1, 16, 2, true, v); }
                },
                Deg2Rad: {
                    get: function () { return CS.Call(0, 16, 3, true); },
                    set: function (v) { return CS.Call(1, 16, 3, true, v); }
                },
                Rad2Deg: {
                    get: function () { return CS.Call(0, 16, 4, true); },
                    set: function (v) { return CS.Call(1, 16, 4, true, v); }
                },
                Epsilon: {
                    get: function () { return CS.Call(0, 16, 5, true); },
                    set: function (v) { return CS.Call(1, 16, 5, true, v); }
                },
            },
            Abs: function (a0/* Int32 */) { return CS.Call(4, 16, 0, true, a0); },
            Abs$1: function (a0/* Single */) { return CS.Call(4, 16, 1, true, a0); },
            Acos: function (a0/* Single */) { return CS.Call(4, 16, 2, true, a0); },
            Approximately: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 3, true, a0, a1); },
            Asin: function (a0/* Single */) { return CS.Call(4, 16, 4, true, a0); },
            Atan: function (a0/* Single */) { return CS.Call(4, 16, 5, true, a0); },
            Atan2: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 6, true, a0, a1); },
            Ceil: function (a0/* Single */) { return CS.Call(4, 16, 7, true, a0); },
            CeilToInt: function (a0/* Single */) { return CS.Call(4, 16, 8, true, a0); },
            Clamp: function (a0/* Int32 */, a1/* Int32 */, a2/* Int32 */) { return CS.Call(4, 16, 9, true, a0, a1, a2); },
            Clamp$1: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 10, true, a0, a1, a2); },
            Clamp01: function (a0/* Single */) { return CS.Call(4, 16, 11, true, a0); },
            ClosestPowerOfTwo: function (a0/* Int32 */) { return CS.Call(4, 16, 12, true, a0); },
            Cos: function (a0/* Single */) { return CS.Call(4, 16, 13, true, a0); },
            DeltaAngle: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 14, true, a0, a1); },
            Exp: function (a0/* Single */) { return CS.Call(4, 16, 15, true, a0); },
            Floor: function (a0/* Single */) { return CS.Call(4, 16, 16, true, a0); },
            FloorToInt: function (a0/* Single */) { return CS.Call(4, 16, 17, true, a0); },
            Gamma: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 18, true, a0, a1, a2); },
            GammaToLinearSpace: function (a0/* Single */) { return CS.Call(4, 16, 19, true, a0); },
            InverseLerp: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 20, true, a0, a1, a2); },
            IsPowerOfTwo: function (a0/* Int32 */) { return CS.Call(4, 16, 21, true, a0); },
            Lerp: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 22, true, a0, a1, a2); },
            LerpAngle: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 23, true, a0, a1, a2); },
            LinearToGammaSpace: function (a0/* Single */) { return CS.Call(4, 16, 24, true, a0); },
            Log: function (a0/* Single */) { return CS.Call(4, 16, 25, true, a0); },
            Log$1: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 26, true, a0, a1); },
            Log10: function (a0/* Single */) { return CS.Call(4, 16, 27, true, a0); },
            Max: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 16, 28, true, a0, a1); },
            Max$1: function (a0/* Int32[] */) { return CS.Call(4, 16, 29, true, a0); },
            Max$2: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 30, true, a0, a1); },
            Max$3: function (a0/* Single[] */) { return CS.Call(4, 16, 31, true, a0); },
            Min: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 16, 32, true, a0, a1); },
            Min$1: function (a0/* Int32[] */) { return CS.Call(4, 16, 33, true, a0); },
            Min$2: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 34, true, a0, a1); },
            Min$3: function (a0/* Single[] */) { return CS.Call(4, 16, 35, true, a0); },
            MoveTowards: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 36, true, a0, a1, a2); },
            MoveTowardsAngle: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 37, true, a0, a1, a2); },
            NextPowerOfTwo: function (a0/* Int32 */) { return CS.Call(4, 16, 38, true, a0); },
            PerlinNoise: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 39, true, a0, a1); },
            PingPong: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 40, true, a0, a1); },
            Pow: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 41, true, a0, a1); },
            Repeat: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 16, 42, true, a0, a1); },
            Round: function (a0/* Single */) { return CS.Call(4, 16, 43, true, a0); },
            RoundToInt: function (a0/* Single */) { return CS.Call(4, 16, 44, true, a0); },
            Sign: function (a0/* Single */) { return CS.Call(4, 16, 45, true, a0); },
            Sin: function (a0/* Single */) { return CS.Call(4, 16, 46, true, a0); },
            SmoothDamp: function (a0/* Single */, a1/* Single */, a2/* Single& */, a3/* Single */) { return CS.Call(4, 16, 47, true, a0, a1, a2, a3); },
            SmoothDamp$1: function (a0/* Single */, a1/* Single */, a2/* Single& */, a3/* Single */, a4/* Single */) { return CS.Call(4, 16, 48, true, a0, a1, a2, a3, a4); },
            SmoothDamp$2: function (a0/* Single */, a1/* Single */, a2/* Single& */, a3/* Single */, a4/* Single */, a5/* Single */) { return CS.Call(4, 16, 49, true, a0, a1, a2, a3, a4, a5); },
            SmoothDampAngle: function (a0/* Single */, a1/* Single */, a2/* Single& */, a3/* Single */) { return CS.Call(4, 16, 50, true, a0, a1, a2, a3); },
            SmoothDampAngle$1: function (a0/* Single */, a1/* Single */, a2/* Single& */, a3/* Single */, a4/* Single */) { return CS.Call(4, 16, 51, true, a0, a1, a2, a3, a4); },
            SmoothDampAngle$2: function (a0/* Single */, a1/* Single */, a2/* Single& */, a3/* Single */, a4/* Single */, a5/* Single */) { return CS.Call(4, 16, 52, true, a0, a1, a2, a3, a4, a5); },
            SmoothStep: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 16, 53, true, a0, a1, a2); },
            Sqrt: function (a0/* Single */) { return CS.Call(4, 16, 54, true, a0); },
            Tan: function (a0/* Single */) { return CS.Call(4, 16, 55, true, a0); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.Mathf)) {
                return false;
            }
            Bridge.equals(this.PI, o.PI) && Bridge.equals(this.Infinity, o.Infinity) && Bridge.equals(this.NegativeInfinity, o.NegativeInfinity) && Bridge.equals(this.Deg2Rad, o.Deg2Rad) && Bridge.equals(this.Rad2Deg, o.Rad2Deg) && Bridge.equals(this.Epsilon, o.Epsilon);
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.Mathf();
            s.PI = this.PI;
            s.Infinity = this.Infinity;
            s.NegativeInfinity = this.NegativeInfinity;
            s.Deg2Rad = this.Deg2Rad;
            s.Rad2Deg = this.Rad2Deg;
            s.Epsilon = this.Epsilon;
            return s;
        },
        ctor: function () {
            CS.Call(5, 16, 0, true, this);
        },
    });
    if ($hc < 18) { return; }
     
    Bridge.define("UnityEngine.YieldInstruction", {
        statics: {
        },
        ctor: function () {
            CS.Call(5, 17, 0, true, this);
        },
    });
    if ($hc < 19) { return; }
     
    Bridge.define("UnityEngine.UI.ILayoutElement", {
        $kind: "interface",
        statics: {
        },
        getflexibleHeight: function () { return CS.Call(2, 18, 0, false, this); },
        setflexibleHeight: function (v) { return CS.Call(3, 18, 0, false, this, v); },
        getflexibleWidth: function () { return CS.Call(2, 18, 1, false, this); },
        setflexibleWidth: function (v) { return CS.Call(3, 18, 1, false, this, v); },
        getlayoutPriority: function () { return CS.Call(2, 18, 2, false, this); },
        setlayoutPriority: function (v) { return CS.Call(3, 18, 2, false, this, v); },
        getminHeight: function () { return CS.Call(2, 18, 3, false, this); },
        setminHeight: function (v) { return CS.Call(3, 18, 3, false, this, v); },
        getminWidth: function () { return CS.Call(2, 18, 4, false, this); },
        setminWidth: function (v) { return CS.Call(3, 18, 4, false, this, v); },
        getpreferredHeight: function () { return CS.Call(2, 18, 5, false, this); },
        setpreferredHeight: function (v) { return CS.Call(3, 18, 5, false, this, v); },
        getpreferredWidth: function () { return CS.Call(2, 18, 6, false, this); },
        setpreferredWidth: function (v) { return CS.Call(3, 18, 6, false, this, v); },
        CalculateLayoutInputHorizontal: function () { return CS.Call(4, 18, 0, false, this); },
        CalculateLayoutInputVertical: function () { return CS.Call(4, 18, 1, false, this); },
    });
    if ($hc < 20) { return; }
     
    Bridge.define("UnityEngine.NavMeshPath", {
        statics: {
        },
        ctor: function () {
            CS.Call(5, 19, 0, true, this);
        },
        getcorners: function () { return CS.Call(2, 19, 0, false, this); },
        setcorners: function (v) { return CS.Call(3, 19, 0, false, this, v); },
        getstatus: function () { return CS.Call(2, 19, 1, false, this); },
        setstatus: function (v) { return CS.Call(3, 19, 1, false, this, v); },
        ClearCorners: function () { return CS.Call(4, 19, 0, false, this); },
    });
    if ($hc < 21) { return; }
     
    Bridge.define("UnityEngine.RaycastHit", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.RaycastHit(); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.RaycastHit)) {
                return false;
            }
            return true;
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.RaycastHit();
            return s;
        },
        ctor: function () {
            CS.Call(5, 20, 0, true, this);
        },
        getbarycentricCoordinate: function () { return CS.Call(2, 20, 0, false, this); },
        setbarycentricCoordinate: function (v) { return CS.Call(3, 20, 0, false, this, v); },
        getcollider: function () { return CS.Call(2, 20, 1, false, this); },
        setcollider: function (v) { return CS.Call(3, 20, 1, false, this, v); },
        getdistance: function () { return CS.Call(2, 20, 2, false, this); },
        setdistance: function (v) { return CS.Call(3, 20, 2, false, this, v); },
        getlightmapCoord: function () { return CS.Call(2, 20, 3, false, this); },
        setlightmapCoord: function (v) { return CS.Call(3, 20, 3, false, this, v); },
        getnormal: function () { return CS.Call(2, 20, 4, false, this); },
        setnormal: function (v) { return CS.Call(3, 20, 4, false, this, v); },
        getpoint: function () { return CS.Call(2, 20, 5, false, this); },
        setpoint: function (v) { return CS.Call(3, 20, 5, false, this, v); },
        getrigidbody: function () { return CS.Call(2, 20, 6, false, this); },
        setrigidbody: function (v) { return CS.Call(3, 20, 6, false, this, v); },
        gettextureCoord: function () { return CS.Call(2, 20, 7, false, this); },
        settextureCoord: function (v) { return CS.Call(3, 20, 7, false, this, v); },
        gettextureCoord2: function () { return CS.Call(2, 20, 8, false, this); },
        settextureCoord2: function (v) { return CS.Call(3, 20, 8, false, this, v); },
        gettransform: function () { return CS.Call(2, 20, 9, false, this); },
        settransform: function (v) { return CS.Call(3, 20, 9, false, this, v); },
        gettriangleIndex: function () { return CS.Call(2, 20, 10, false, this); },
        settriangleIndex: function (v) { return CS.Call(3, 20, 10, false, this, v); },
    });
    if ($hc < 22) { return; }
     
    Bridge.define("UnityEngine.AnimatorStateInfo", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.AnimatorStateInfo(); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.AnimatorStateInfo)) {
                return false;
            }
            return true;
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.AnimatorStateInfo();
            return s;
        },
        ctor: function () {
            CS.Call(5, 21, 0, true, this);
        },
        getlength: function () { return CS.Call(2, 21, 0, false, this); },
        setlength: function (v) { return CS.Call(3, 21, 0, false, this, v); },
        getloop: function () { return CS.Call(2, 21, 1, false, this); },
        setloop: function (v) { return CS.Call(3, 21, 1, false, this, v); },
        getnameHash: function () { return CS.Call(2, 21, 2, false, this); },
        setnameHash: function (v) { return CS.Call(3, 21, 2, false, this, v); },
        getnormalizedTime: function () { return CS.Call(2, 21, 3, false, this); },
        setnormalizedTime: function (v) { return CS.Call(3, 21, 3, false, this, v); },
        gettagHash: function () { return CS.Call(2, 21, 4, false, this); },
        settagHash: function (v) { return CS.Call(3, 21, 4, false, this, v); },
        IsName: function (a0/* String */) { return CS.Call(4, 21, 0, false, this, a0); },
        IsTag: function (a0/* String */) { return CS.Call(4, 21, 1, false, this, a0); },
    });
    if ($hc < 23) { return; }
     
    Bridge.define("UnityEngine.Resources", {
        statics: {
            FindObjectsOfTypeAll: function (T) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 22, 0, true, $T);
            },
            FindObjectsOfTypeAll$1: function (a0/* Type */) { return CS.Call(4, 22, 1, true, a0); },
            GetBuiltinResource: function (T, a0/* String */) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 22, 2, true, $T, a0);
            },
            GetBuiltinResource$1: function (a0/* Type */, a1/* String */) { return CS.Call(4, 22, 3, true, a0, a1); },
            Load: function (T, a0/* String */) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 22, 4, true, $T, a0);
            },
            Load$1: function (a0/* String */) { return CS.Call(4, 22, 5, true, a0); },
            Load$2: function (a0/* String */, a1/* Type */) { return CS.Call(4, 22, 6, true, a0, a1); },
            LoadAll: function (T, a0/* String */) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 22, 7, true, $T, a0);
            },
            LoadAll$1: function (a0/* String */) { return CS.Call(4, 22, 8, true, a0); },
            LoadAll$2: function (a0/* String */, a1/* Type */) { return CS.Call(4, 22, 9, true, a0, a1); },
            LoadAssetAtPath: function (T, a0/* String */) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 22, 10, true, $T, a0);
            },
            LoadAssetAtPath$1: function (a0/* String */, a1/* Type */) { return CS.Call(4, 22, 11, true, a0, a1); },
            LoadAsync: function (a0/* String */) { return CS.Call(4, 22, 12, true, a0); },
            LoadAsync$1: function (a0/* String */, a1/* Type */) { return CS.Call(4, 22, 13, true, a0, a1); },
            LoadAsync$2: function (T, a0/* String */) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 22, 14, true, $T, a0);
            },
            UnloadAsset: function (a0/* Object */) { return CS.Call(4, 22, 15, true, a0); },
            UnloadUnusedAssets: function () { return CS.Call(4, 22, 16, true); },
        },
        ctor: function () {
            CS.Call(5, 22, 0, true, this);
        },
    });
    if ($hc < 24) { return; }
     
    Bridge.define("jsb.Test.Framwork.TestGeneric$3", function (T, J, K) { return {
        statics: {
        },
        ctor: function (a0) {
            var $GAs = Bridge.Reflection.getGenericArguments(Bridge.getType(this));
            var $T = Bridge.Reflection.getTypeFullName($GAs[0]);
            var $J = Bridge.Reflection.getTypeFullName($GAs[1]);
            var $K = Bridge.Reflection.getTypeFullName($GAs[2]);
            CS.Call(5, 23, 0, true, this, $T, $J, $K, a0);
        },
        Compare: function (a0/* CompareFunc */) { return CS.Call(4, 23, 0, false, this, a0); },
        Hello: function (X, Y) {
            var $X = Bridge.Reflection.getTypeFullName(X);
            var $Y = Bridge.Reflection.getTypeFullName(Y);
            return CS.Call(4, 23, 1, false, this, $X, $Y);
        },
        PrintName: function () { return CS.Call(4, 23, 2, false, this); },
    }});
    if ($hc < 25) { return; }
     
    Bridge.define("UnityEngine.Vector2", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.Vector2(); },
            $fields: {
                kEpsilon: {
                    get: function () { return CS.Call(0, 24, 0, true); },
                    set: function (v) { return CS.Call(1, 24, 0, true, v); }
                },
            },
            getone: function () { return CS.Call(2, 24, 4, true); },
            setone: function (v) { return CS.Call(3, 24, 4, true, v); },
            getright: function () { return CS.Call(2, 24, 5, true); },
            setright: function (v) { return CS.Call(3, 24, 5, true, v); },
            getup: function () { return CS.Call(2, 24, 6, true); },
            setup: function (v) { return CS.Call(3, 24, 6, true, v); },
            getzero: function () { return CS.Call(2, 24, 7, true); },
            setzero: function (v) { return CS.Call(3, 24, 7, true, v); },
            Angle: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 8, true, a0, a1); },
            ClampMagnitude: function (a0/* Vector2 */, a1/* Single */) { return CS.Call(4, 24, 9, true, a0, a1); },
            Distance: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 10, true, a0, a1); },
            Dot: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 11, true, a0, a1); },
            Lerp: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */) { return CS.Call(4, 24, 12, true, a0, a1, a2); },
            Max: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 13, true, a0, a1); },
            Min: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 14, true, a0, a1); },
            MoveTowards: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Single */) { return CS.Call(4, 24, 15, true, a0, a1, a2); },
            op_Addition: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 16, true, a0, a1); },
            op_Division: function (a0/* Vector2 */, a1/* Single */) { return CS.Call(4, 24, 17, true, a0, a1); },
            op_Equality: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 18, true, a0, a1); },
            op_Implicit: function (a0/* Vector3 */) { return CS.Call(4, 24, 19, true, a0); },
            op_Implicit$1: function (a0/* Vector2 */) { return CS.Call(4, 24, 20, true, a0); },
            op_Inequality: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 21, true, a0, a1); },
            op_Multiply: function (a0/* Single */, a1/* Vector2 */) { return CS.Call(4, 24, 22, true, a0, a1); },
            op_Multiply$1: function (a0/* Vector2 */, a1/* Single */) { return CS.Call(4, 24, 23, true, a0, a1); },
            op_Subtraction: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 24, true, a0, a1); },
            op_UnaryNegation: function (a0/* Vector2 */) { return CS.Call(4, 24, 25, true, a0); },
            Scale: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 24, 26, true, a0, a1); },
            SmoothDamp: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Vector2& */, a3/* Single */) { return CS.Call(4, 24, 27, true, a0, a1, a2, a3); },
            SmoothDamp$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Vector2& */, a3/* Single */, a4/* Single */) { return CS.Call(4, 24, 28, true, a0, a1, a2, a3, a4); },
            SmoothDamp$2: function (a0/* Vector2 */, a1/* Vector2 */, a2/* Vector2& */, a3/* Single */, a4/* Single */, a5/* Single */) { return CS.Call(4, 24, 29, true, a0, a1, a2, a3, a4, a5); },
            SqrMagnitude: function (a0/* Vector2 */) { return CS.Call(4, 24, 30, true, a0); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.Vector2)) {
                return false;
            }
            Bridge.equals(this.kEpsilon, o.kEpsilon) && Bridge.equals(this.x, o.x) && Bridge.equals(this.y, o.y);
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.Vector2();
            s.kEpsilon = this.kEpsilon;
            s.x = this.x;
            s.y = this.y;
            return s;
        },
        ctor: function () {
            CS.Call(5, 24, 0, true, this);
        },
        $ctor1: function (a0, a1) {
            CS.Call(5, 24, 1, true, this, a0, a1);
        },
        $fields: {
            x: {
                get: function () { return CS.Call(0, 24, 1, false, this); },
                set: function (v) { return CS.Call(1, 24, 1, false, this, v); }
            },
            y: {
                get: function () { return CS.Call(0, 24, 2, false, this); },
                set: function (v) { return CS.Call(1, 24, 2, false, this, v); }
            },
        },
        getItem: function (ind0) { return CS.Call(2, 24, 0, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 24, 0, false, this, ind0, v); },
        getmagnitude: function () { return CS.Call(2, 24, 1, false, this); },
        setmagnitude: function (v) { return CS.Call(3, 24, 1, false, this, v); },
        getnormalized: function () { return CS.Call(2, 24, 2, false, this); },
        setnormalized: function (v) { return CS.Call(3, 24, 2, false, this, v); },
        getsqrMagnitude: function () { return CS.Call(2, 24, 3, false, this); },
        setsqrMagnitude: function (v) { return CS.Call(3, 24, 3, false, this, v); },
        Equals: function (a0/* Object */) { return CS.Call(4, 24, 0, false, this, a0); },
        GetHashCode: function () { return CS.Call(4, 24, 1, false, this); },
        Normalize: function () { return CS.Call(4, 24, 2, false, this); },
        Scale: function (a0/* Vector2 */) { return CS.Call(4, 24, 3, false, this, a0); },
        Set: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 24, 4, false, this, a0, a1); },
        SqrMagnitude: function () { return CS.Call(4, 24, 5, false, this); },
        ToString: function () { return CS.Call(4, 24, 6, false, this); },
        ToString$1: function (a0/* String */) { return CS.Call(4, 24, 7, false, this, a0); },
    });
    if ($hc < 26) { return; }
     
    Bridge.define("UnityEngine.Vector3", {
        $kind: "struct",
        statics: {
            getDefaultValue: function () { return new UnityEngine.Vector3(); },
            $fields: {
                kEpsilon: {
                    get: function () { return CS.Call(0, 25, 0, true); },
                    set: function (v) { return CS.Call(1, 25, 0, true, v); }
                },
            },
            getback: function () { return CS.Call(2, 25, 4, true); },
            setback: function (v) { return CS.Call(3, 25, 4, true, v); },
            getdown: function () { return CS.Call(2, 25, 5, true); },
            setdown: function (v) { return CS.Call(3, 25, 5, true, v); },
            getforward: function () { return CS.Call(2, 25, 6, true); },
            setforward: function (v) { return CS.Call(3, 25, 6, true, v); },
            getleft: function () { return CS.Call(2, 25, 7, true); },
            setleft: function (v) { return CS.Call(3, 25, 7, true, v); },
            getone: function () { return CS.Call(2, 25, 8, true); },
            setone: function (v) { return CS.Call(3, 25, 8, true, v); },
            getright: function () { return CS.Call(2, 25, 9, true); },
            setright: function (v) { return CS.Call(3, 25, 9, true, v); },
            getup: function () { return CS.Call(2, 25, 10, true); },
            setup: function (v) { return CS.Call(3, 25, 10, true, v); },
            getzero: function () { return CS.Call(2, 25, 11, true); },
            setzero: function (v) { return CS.Call(3, 25, 11, true, v); },
            Angle: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 7, true, a0, a1); },
            ClampMagnitude: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 25, 8, true, a0, a1); },
            Cross: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 9, true, a0, a1); },
            Distance: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 10, true, a0, a1); },
            Dot: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 11, true, a0, a1); },
            Lerp: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 25, 12, true, a0, a1, a2); },
            Magnitude: function (a0/* Vector3 */) { return CS.Call(4, 25, 13, true, a0); },
            Max: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 14, true, a0, a1); },
            Min: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 15, true, a0, a1); },
            MoveTowards: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 25, 16, true, a0, a1, a2); },
            Normalize: function (a0/* Vector3 */) { return CS.Call(4, 25, 17, true, a0); },
            op_Addition: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 18, true, a0, a1); },
            op_Division: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 25, 19, true, a0, a1); },
            op_Equality: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 20, true, a0, a1); },
            op_Inequality: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 21, true, a0, a1); },
            op_Multiply: function (a0/* Single */, a1/* Vector3 */) { return CS.Call(4, 25, 22, true, a0, a1); },
            op_Multiply$1: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 25, 23, true, a0, a1); },
            op_Subtraction: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 24, true, a0, a1); },
            op_UnaryNegation: function (a0/* Vector3 */) { return CS.Call(4, 25, 25, true, a0); },
            OrthoNormalize: function (a0/* Vector3& */, a1/* Vector3& */) { return CS.Call(4, 25, 26, true, a0, a1); },
            OrthoNormalize$1: function (a0/* Vector3& */, a1/* Vector3& */, a2/* Vector3& */) { return CS.Call(4, 25, 27, true, a0, a1, a2); },
            Project: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 28, true, a0, a1); },
            ProjectOnPlane: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 29, true, a0, a1); },
            Reflect: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 30, true, a0, a1); },
            RotateTowards: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Single */) { return CS.Call(4, 25, 31, true, a0, a1, a2, a3); },
            Scale: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 25, 32, true, a0, a1); },
            Slerp: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 25, 33, true, a0, a1, a2); },
            SmoothDamp: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Vector3& */, a3/* Single */) { return CS.Call(4, 25, 34, true, a0, a1, a2, a3); },
            SmoothDamp$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Vector3& */, a3/* Single */, a4/* Single */) { return CS.Call(4, 25, 35, true, a0, a1, a2, a3, a4); },
            SmoothDamp$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Vector3& */, a3/* Single */, a4/* Single */, a5/* Single */) { return CS.Call(4, 25, 36, true, a0, a1, a2, a3, a4, a5); },
            SqrMagnitude: function (a0/* Vector3 */) { return CS.Call(4, 25, 37, true, a0); },
        },
        equals: function (o) {
            if (!Bridge.is(o, UnityEngine.Vector3)) {
                return false;
            }
            Bridge.equals(this.kEpsilon, o.kEpsilon) && Bridge.equals(this.x, o.x) && Bridge.equals(this.y, o.y) && Bridge.equals(this.z, o.z);
        },
        $clone: function (to) {
            return this; // don't clone
             
            var s = to || new UnityEngine.Vector3();
            s.kEpsilon = this.kEpsilon;
            s.x = this.x;
            s.y = this.y;
            s.z = this.z;
            return s;
        },
        ctor: function () {
            CS.Call(5, 25, 0, true, this);
        },
        $ctor1: function (a0, a1) {
            CS.Call(5, 25, 1, true, this, a0, a1);
        },
        $ctor2: function (a0, a1, a2) {
            CS.Call(5, 25, 2, true, this, a0, a1, a2);
        },
        $fields: {
            x: {
                get: function () { return CS.Call(0, 25, 1, false, this); },
                set: function (v) { return CS.Call(1, 25, 1, false, this, v); }
            },
            y: {
                get: function () { return CS.Call(0, 25, 2, false, this); },
                set: function (v) { return CS.Call(1, 25, 2, false, this, v); }
            },
            z: {
                get: function () { return CS.Call(0, 25, 3, false, this); },
                set: function (v) { return CS.Call(1, 25, 3, false, this, v); }
            },
        },
        getItem: function (ind0) { return CS.Call(2, 25, 0, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 25, 0, false, this, ind0, v); },
        getmagnitude: function () { return CS.Call(2, 25, 1, false, this); },
        setmagnitude: function (v) { return CS.Call(3, 25, 1, false, this, v); },
        getnormalized: function () { return CS.Call(2, 25, 2, false, this); },
        setnormalized: function (v) { return CS.Call(3, 25, 2, false, this, v); },
        getsqrMagnitude: function () { return CS.Call(2, 25, 3, false, this); },
        setsqrMagnitude: function (v) { return CS.Call(3, 25, 3, false, this, v); },
        Equals: function (a0/* Object */) { return CS.Call(4, 25, 0, false, this, a0); },
        GetHashCode: function () { return CS.Call(4, 25, 1, false, this); },
        Normalize: function () { return CS.Call(4, 25, 2, false, this); },
        Scale: function (a0/* Vector3 */) { return CS.Call(4, 25, 3, false, this, a0); },
        Set: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 25, 4, false, this, a0, a1, a2); },
        ToString: function () { return CS.Call(4, 25, 5, false, this); },
        ToString$1: function (a0/* String */) { return CS.Call(4, 25, 6, false, this, a0); },
    });
    if ($hc < 27) { return; }
     
    Bridge.define("UnityEngine.Debug", {
        statics: {
            getdeveloperConsoleVisible: function () { return CS.Call(2, 26, 0, true); },
            setdeveloperConsoleVisible: function (v) { return CS.Call(3, 26, 0, true, v); },
            getisDebugBuild: function () { return CS.Call(2, 26, 1, true); },
            setisDebugBuild: function (v) { return CS.Call(3, 26, 1, true, v); },
            Break: function () { return CS.Call(4, 26, 0, true); },
            ClearDeveloperConsole: function () { return CS.Call(4, 26, 1, true); },
            DebugBreak: function () { return CS.Call(4, 26, 2, true); },
            DrawLine: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 26, 3, true, a0, a1); },
            DrawLine$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Color */) { return CS.Call(4, 26, 4, true, a0, a1, a2); },
            DrawLine$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Color */, a3/* Single */) { return CS.Call(4, 26, 5, true, a0, a1, a2, a3); },
            DrawLine$3: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Color */, a3/* Single */, a4/* Boolean */) { return CS.Call(4, 26, 6, true, a0, a1, a2, a3, a4); },
            DrawRay: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 26, 7, true, a0, a1); },
            DrawRay$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Color */) { return CS.Call(4, 26, 8, true, a0, a1, a2); },
            DrawRay$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Color */, a3/* Single */) { return CS.Call(4, 26, 9, true, a0, a1, a2, a3); },
            DrawRay$3: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Color */, a3/* Single */, a4/* Boolean */) { return CS.Call(4, 26, 10, true, a0, a1, a2, a3, a4); },
            Log: function (a0/* Object */) { return CS.Call(4, 26, 11, true, a0); },
            Log$1: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 26, 12, true, a0, a1); },
            LogError: function (a0/* Object */) { return CS.Call(4, 26, 13, true, a0); },
            LogError$1: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 26, 14, true, a0, a1); },
            LogException: function (a0/* Exception */) { return CS.Call(4, 26, 15, true, a0); },
            LogException$1: function (a0/* Exception */, a1/* Object */) { return CS.Call(4, 26, 16, true, a0, a1); },
            LogWarning: function (a0/* Object */) { return CS.Call(4, 26, 17, true, a0); },
            LogWarning$1: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 26, 18, true, a0, a1); },
        },
        ctor: function () {
            CS.Call(5, 26, 0, true, this);
        },
    });
    if ($hc < 28) { return; }
     
    Bridge.define("UnityEngine.Input", {
        statics: {
            getacceleration: function () { return CS.Call(2, 27, 0, true); },
            setacceleration: function (v) { return CS.Call(3, 27, 0, true, v); },
            getaccelerationEventCount: function () { return CS.Call(2, 27, 1, true); },
            setaccelerationEventCount: function (v) { return CS.Call(3, 27, 1, true, v); },
            getaccelerationEvents: function () { return CS.Call(2, 27, 2, true); },
            setaccelerationEvents: function (v) { return CS.Call(3, 27, 2, true, v); },
            getanyKey: function () { return CS.Call(2, 27, 3, true); },
            setanyKey: function (v) { return CS.Call(3, 27, 3, true, v); },
            getanyKeyDown: function () { return CS.Call(2, 27, 4, true); },
            setanyKeyDown: function (v) { return CS.Call(3, 27, 4, true, v); },
            getcompass: function () { return CS.Call(2, 27, 5, true); },
            setcompass: function (v) { return CS.Call(3, 27, 5, true, v); },
            getcompensateSensors: function () { return CS.Call(2, 27, 6, true); },
            setcompensateSensors: function (v) { return CS.Call(3, 27, 6, true, v); },
            getcompositionCursorPos: function () { return CS.Call(2, 27, 7, true); },
            setcompositionCursorPos: function (v) { return CS.Call(3, 27, 7, true, v); },
            getcompositionString: function () { return CS.Call(2, 27, 8, true); },
            setcompositionString: function (v) { return CS.Call(3, 27, 8, true, v); },
            getdeviceOrientation: function () { return CS.Call(2, 27, 9, true); },
            setdeviceOrientation: function (v) { return CS.Call(3, 27, 9, true, v); },
            getgyro: function () { return CS.Call(2, 27, 10, true); },
            setgyro: function (v) { return CS.Call(3, 27, 10, true, v); },
            getimeCompositionMode: function () { return CS.Call(2, 27, 11, true); },
            setimeCompositionMode: function (v) { return CS.Call(3, 27, 11, true, v); },
            getimeIsSelected: function () { return CS.Call(2, 27, 12, true); },
            setimeIsSelected: function (v) { return CS.Call(3, 27, 12, true, v); },
            getinputString: function () { return CS.Call(2, 27, 13, true); },
            setinputString: function (v) { return CS.Call(3, 27, 13, true, v); },
            getlocation: function () { return CS.Call(2, 27, 14, true); },
            setlocation: function (v) { return CS.Call(3, 27, 14, true, v); },
            getmousePosition: function () { return CS.Call(2, 27, 15, true); },
            setmousePosition: function (v) { return CS.Call(3, 27, 15, true, v); },
            getmousePresent: function () { return CS.Call(2, 27, 16, true); },
            setmousePresent: function (v) { return CS.Call(3, 27, 16, true, v); },
            getmouseScrollDelta: function () { return CS.Call(2, 27, 17, true); },
            setmouseScrollDelta: function (v) { return CS.Call(3, 27, 17, true, v); },
            getmultiTouchEnabled: function () { return CS.Call(2, 27, 18, true); },
            setmultiTouchEnabled: function (v) { return CS.Call(3, 27, 18, true, v); },
            getsimulateMouseWithTouches: function () { return CS.Call(2, 27, 19, true); },
            setsimulateMouseWithTouches: function (v) { return CS.Call(3, 27, 19, true, v); },
            gettouchCount: function () { return CS.Call(2, 27, 20, true); },
            settouchCount: function (v) { return CS.Call(3, 27, 20, true, v); },
            gettouches: function () { return CS.Call(2, 27, 21, true); },
            settouches: function (v) { return CS.Call(3, 27, 21, true, v); },
            gettouchSupported: function () { return CS.Call(2, 27, 22, true); },
            settouchSupported: function (v) { return CS.Call(3, 27, 22, true, v); },
            GetAccelerationEvent: function (a0/* Int32 */) { return CS.Call(4, 27, 0, true, a0); },
            GetAxis: function (a0/* String */) { return CS.Call(4, 27, 1, true, a0); },
            GetAxisRaw: function (a0/* String */) { return CS.Call(4, 27, 2, true, a0); },
            GetButton: function (a0/* String */) { return CS.Call(4, 27, 3, true, a0); },
            GetButtonDown: function (a0/* String */) { return CS.Call(4, 27, 4, true, a0); },
            GetButtonUp: function (a0/* String */) { return CS.Call(4, 27, 5, true, a0); },
            GetJoystickNames: function () { return CS.Call(4, 27, 6, true); },
            GetKey: function (a0/* String */) { return CS.Call(4, 27, 7, true, a0); },
            GetKey$1: function (a0/* KeyCode */) { return CS.Call(4, 27, 8, true, a0); },
            GetKeyDown: function (a0/* String */) { return CS.Call(4, 27, 9, true, a0); },
            GetKeyDown$1: function (a0/* KeyCode */) { return CS.Call(4, 27, 10, true, a0); },
            GetKeyUp: function (a0/* String */) { return CS.Call(4, 27, 11, true, a0); },
            GetKeyUp$1: function (a0/* KeyCode */) { return CS.Call(4, 27, 12, true, a0); },
            GetMouseButton: function (a0/* Int32 */) { return CS.Call(4, 27, 13, true, a0); },
            GetMouseButtonDown: function (a0/* Int32 */) { return CS.Call(4, 27, 14, true, a0); },
            GetMouseButtonUp: function (a0/* Int32 */) { return CS.Call(4, 27, 15, true, a0); },
            GetTouch: function (a0/* Int32 */) { return CS.Call(4, 27, 16, true, a0); },
            ResetInputAxes: function () { return CS.Call(4, 27, 17, true); },
        },
        ctor: function () {
            CS.Call(5, 27, 0, true, this);
        },
    });
    if ($hc < 29) { return; }
     
    Bridge.define("UnityEngine.ISerializationCallbackReceiver", {
        $kind: "interface",
        statics: {
        },
        OnAfterDeserialize: function () { return CS.Call(4, 28, 0, false, this); },
        OnBeforeSerialize: function () { return CS.Call(4, 28, 1, false, this); },
    });
    if ($hc < 30) { return; }
     
    Bridge.define("UnityEngine.Object", {
        statics: {
            Destroy: function (a0/* Object */) { return CS.Call(4, 29, 4, true, a0); },
            Destroy$1: function (a0/* Object */, a1/* Single */) { return CS.Call(4, 29, 5, true, a0, a1); },
            DestroyImmediate: function (a0/* Object */) { return CS.Call(4, 29, 6, true, a0); },
            DestroyImmediate$1: function (a0/* Object */, a1/* Boolean */) { return CS.Call(4, 29, 7, true, a0, a1); },
            DestroyObject: function (a0/* Object */) { return CS.Call(4, 29, 8, true, a0); },
            DestroyObject$1: function (a0/* Object */, a1/* Single */) { return CS.Call(4, 29, 9, true, a0, a1); },
            DontDestroyOnLoad: function (a0/* Object */) { return CS.Call(4, 29, 10, true, a0); },
            FindObjectOfType: function (T) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 29, 11, true, $T);
            },
            FindObjectOfType$1: function (a0/* Type */) { return CS.Call(4, 29, 12, true, a0); },
            FindObjectsOfType: function (T) {
                var $T = Bridge.Reflection.getTypeFullName(T);
                return CS.Call(4, 29, 13, true, $T);
            },
            FindObjectsOfType$1: function (a0/* Type */) { return CS.Call(4, 29, 14, true, a0); },
            Instantiate: function (a0/* Object */) { return CS.Call(4, 29, 15, true, a0); },
            Instantiate$1: function (a0/* Object */, a1/* Vector3 */, a2/* Quaternion */) { return CS.Call(4, 29, 16, true, a0, a1, a2); },
            op_Equality: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 29, 17, true, a0, a1); },
            op_Implicit: function (a0/* Object */) { return CS.Call(4, 29, 18, true, a0); },
            op_Inequality: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 29, 19, true, a0, a1); },
        },
        ctor: function () {
            CS.Call(5, 29, 0, true, this);
        },
        gethideFlags: function () { return CS.Call(2, 29, 0, false, this); },
        sethideFlags: function (v) { return CS.Call(3, 29, 0, false, this, v); },
        getname: function () { return CS.Call(2, 29, 1, false, this); },
        setname: function (v) { return CS.Call(3, 29, 1, false, this, v); },
        Equals: function (a0/* Object */) { return CS.Call(4, 29, 0, false, this, a0); },
        GetHashCode: function () { return CS.Call(4, 29, 1, false, this); },
        GetInstanceID: function () { return CS.Call(4, 29, 2, false, this); },
        ToString: function () { return CS.Call(4, 29, 3, false, this); },
    });
    if ($hc < 31) { return; }
     
    Bridge.define("UnityEngine.WWW", {
        inherits: [System.IDisposable],
        statics: {
            EscapeURL: function (a0/* String */) { return CS.Call(4, 30, 10, true, a0); },
            EscapeURL$1: function (a0/* String */, a1/* Encoding */) { return CS.Call(4, 30, 11, true, a0, a1); },
            LoadFromCacheOrDownload: function (a0/* String */, a1/* Int32 */) { return CS.Call(4, 30, 12, true, a0, a1); },
            LoadFromCacheOrDownload$1: function (a0/* String */, a1/* Int32 */, a2/* UInt32 */) { return CS.Call(4, 30, 13, true, a0, a1, a2); },
            UnEscapeURL: function (a0/* String */) { return CS.Call(4, 30, 14, true, a0); },
            UnEscapeURL$1: function (a0/* String */, a1/* Encoding */) { return CS.Call(4, 30, 15, true, a0, a1); },
        },
        ctor: function (a0) {
            CS.Call(5, 30, 0, true, this, a0);
        },
        $ctor1: function (a0, a1) {
            CS.Call(5, 30, 1, true, this, a0, a1);
        },
        $ctor2: function (a0, a1, a2) {
            CS.Call(5, 30, 2, true, this, a0, a1, a2);
        },
        $ctor3: function (a0, a1) {
            CS.Call(5, 30, 3, true, this, a0, a1);
        },
        getassetBundle: function () { return CS.Call(2, 30, 0, false, this); },
        setassetBundle: function (v) { return CS.Call(3, 30, 0, false, this, v); },
        getaudioClip: function () { return CS.Call(2, 30, 1, false, this); },
        setaudioClip: function (v) { return CS.Call(3, 30, 1, false, this, v); },
        getbytes: function () { return CS.Call(2, 30, 2, false, this); },
        setbytes: function (v) { return CS.Call(3, 30, 2, false, this, v); },
        getbytesDownloaded: function () { return CS.Call(2, 30, 3, false, this); },
        setbytesDownloaded: function (v) { return CS.Call(3, 30, 3, false, this, v); },
        geterror: function () { return CS.Call(2, 30, 4, false, this); },
        seterror: function (v) { return CS.Call(3, 30, 4, false, this, v); },
        getisDone: function () { return CS.Call(2, 30, 5, false, this); },
        setisDone: function (v) { return CS.Call(3, 30, 5, false, this, v); },
        getmovie: function () { return CS.Call(2, 30, 6, false, this); },
        setmovie: function (v) { return CS.Call(3, 30, 6, false, this, v); },
        getprogress: function () { return CS.Call(2, 30, 7, false, this); },
        setprogress: function (v) { return CS.Call(3, 30, 7, false, this, v); },
        getresponseHeaders: function () { return CS.Call(2, 30, 8, false, this); },
        setresponseHeaders: function (v) { return CS.Call(3, 30, 8, false, this, v); },
        getsize: function () { return CS.Call(2, 30, 9, false, this); },
        setsize: function (v) { return CS.Call(3, 30, 9, false, this, v); },
        gettext: function () { return CS.Call(2, 30, 10, false, this); },
        settext: function (v) { return CS.Call(3, 30, 10, false, this, v); },
        gettexture: function () { return CS.Call(2, 30, 11, false, this); },
        settexture: function (v) { return CS.Call(3, 30, 11, false, this, v); },
        gettextureNonReadable: function () { return CS.Call(2, 30, 12, false, this); },
        settextureNonReadable: function (v) { return CS.Call(3, 30, 12, false, this, v); },
        getthreadPriority: function () { return CS.Call(2, 30, 13, false, this); },
        setthreadPriority: function (v) { return CS.Call(3, 30, 13, false, this, v); },
        getuploadProgress: function () { return CS.Call(2, 30, 14, false, this); },
        setuploadProgress: function (v) { return CS.Call(3, 30, 14, false, this, v); },
        geturl: function () { return CS.Call(2, 30, 15, false, this); },
        seturl: function (v) { return CS.Call(3, 30, 15, false, this, v); },
        Dispose: function () { return CS.Call(4, 30, 0, false, this); },
        GetAudioClip: function (a0/* Boolean */) { return CS.Call(4, 30, 1, false, this, a0); },
        GetAudioClip$1: function (a0/* Boolean */, a1/* Boolean */) { return CS.Call(4, 30, 2, false, this, a0, a1); },
        GetAudioClip$2: function (a0/* Boolean */, a1/* Boolean */, a2/* AudioType */) { return CS.Call(4, 30, 3, false, this, a0, a1, a2); },
        GetAudioClipCompressed: function () { return CS.Call(4, 30, 4, false, this); },
        GetAudioClipCompressed$1: function (a0/* Boolean */) { return CS.Call(4, 30, 5, false, this, a0); },
        GetAudioClipCompressed$2: function (a0/* Boolean */, a1/* AudioType */) { return CS.Call(4, 30, 6, false, this, a0, a1); },
        InitWWW: function (a0/* String */, a1/* Byte[] */, a2/* String[] */) { return CS.Call(4, 30, 7, false, this, a0, a1, a2); },
        LoadImageIntoTexture: function (a0/* Texture2D */) { return CS.Call(4, 30, 8, false, this, a0); },
        LoadUnityWeb: function () { return CS.Call(4, 30, 9, false, this); },
    });
    if ($hc < 32) { return; }
     
    Bridge.define("UnityEngine.Time", {
        statics: {
            getcaptureFramerate: function () { return CS.Call(2, 31, 0, true); },
            setcaptureFramerate: function (v) { return CS.Call(3, 31, 0, true, v); },
            getdeltaTime: function () { return CS.Call(2, 31, 1, true); },
            setdeltaTime: function (v) { return CS.Call(3, 31, 1, true, v); },
            getfixedDeltaTime: function () { return CS.Call(2, 31, 2, true); },
            setfixedDeltaTime: function (v) { return CS.Call(3, 31, 2, true, v); },
            getfixedTime: function () { return CS.Call(2, 31, 3, true); },
            setfixedTime: function (v) { return CS.Call(3, 31, 3, true, v); },
            getframeCount: function () { return CS.Call(2, 31, 4, true); },
            setframeCount: function (v) { return CS.Call(3, 31, 4, true, v); },
            getmaximumDeltaTime: function () { return CS.Call(2, 31, 5, true); },
            setmaximumDeltaTime: function (v) { return CS.Call(3, 31, 5, true, v); },
            getrealtimeSinceStartup: function () { return CS.Call(2, 31, 6, true); },
            setrealtimeSinceStartup: function (v) { return CS.Call(3, 31, 6, true, v); },
            getrenderedFrameCount: function () { return CS.Call(2, 31, 7, true); },
            setrenderedFrameCount: function (v) { return CS.Call(3, 31, 7, true, v); },
            getsmoothDeltaTime: function () { return CS.Call(2, 31, 8, true); },
            setsmoothDeltaTime: function (v) { return CS.Call(3, 31, 8, true, v); },
            gettime: function () { return CS.Call(2, 31, 9, true); },
            settime: function (v) { return CS.Call(3, 31, 9, true, v); },
            gettimeScale: function () { return CS.Call(2, 31, 10, true); },
            settimeScale: function (v) { return CS.Call(3, 31, 10, true, v); },
            gettimeSinceLevelLoad: function () { return CS.Call(2, 31, 11, true); },
            settimeSinceLevelLoad: function (v) { return CS.Call(3, 31, 11, true, v); },
            getunscaledDeltaTime: function () { return CS.Call(2, 31, 12, true); },
            setunscaledDeltaTime: function (v) { return CS.Call(3, 31, 12, true, v); },
            getunscaledTime: function () { return CS.Call(2, 31, 13, true); },
            setunscaledTime: function (v) { return CS.Call(3, 31, 13, true, v); },
        },
        ctor: function () {
            CS.Call(5, 31, 0, true, this);
        },
    });
    if ($hc < 33) { return; }
     
    Bridge.define("UnityEngine.Application", {
        statics: {
            getabsoluteURL: function () { return CS.Call(2, 32, 0, true); },
            setabsoluteURL: function (v) { return CS.Call(3, 32, 0, true, v); },
            getbackgroundLoadingPriority: function () { return CS.Call(2, 32, 1, true); },
            setbackgroundLoadingPriority: function (v) { return CS.Call(3, 32, 1, true, v); },
            getdataPath: function () { return CS.Call(2, 32, 2, true); },
            setdataPath: function (v) { return CS.Call(3, 32, 2, true, v); },
            getgenuine: function () { return CS.Call(2, 32, 3, true); },
            setgenuine: function (v) { return CS.Call(3, 32, 3, true, v); },
            getgenuineCheckAvailable: function () { return CS.Call(2, 32, 4, true); },
            setgenuineCheckAvailable: function (v) { return CS.Call(3, 32, 4, true, v); },
            getinternetReachability: function () { return CS.Call(2, 32, 5, true); },
            setinternetReachability: function (v) { return CS.Call(3, 32, 5, true, v); },
            getisConsolePlatform: function () { return CS.Call(2, 32, 6, true); },
            setisConsolePlatform: function (v) { return CS.Call(3, 32, 6, true, v); },
            getisEditor: function () { return CS.Call(2, 32, 7, true); },
            setisEditor: function (v) { return CS.Call(3, 32, 7, true, v); },
            getisLoadingLevel: function () { return CS.Call(2, 32, 8, true); },
            setisLoadingLevel: function (v) { return CS.Call(3, 32, 8, true, v); },
            getisMobilePlatform: function () { return CS.Call(2, 32, 9, true); },
            setisMobilePlatform: function (v) { return CS.Call(3, 32, 9, true, v); },
            getisPlaying: function () { return CS.Call(2, 32, 10, true); },
            setisPlaying: function (v) { return CS.Call(3, 32, 10, true, v); },
            getisWebPlayer: function () { return CS.Call(2, 32, 11, true); },
            setisWebPlayer: function (v) { return CS.Call(3, 32, 11, true, v); },
            getlevelCount: function () { return CS.Call(2, 32, 12, true); },
            setlevelCount: function (v) { return CS.Call(3, 32, 12, true, v); },
            getloadedLevel: function () { return CS.Call(2, 32, 13, true); },
            setloadedLevel: function (v) { return CS.Call(3, 32, 13, true, v); },
            getloadedLevelName: function () { return CS.Call(2, 32, 14, true); },
            setloadedLevelName: function (v) { return CS.Call(3, 32, 14, true, v); },
            getpersistentDataPath: function () { return CS.Call(2, 32, 15, true); },
            setpersistentDataPath: function (v) { return CS.Call(3, 32, 15, true, v); },
            getplatform: function () { return CS.Call(2, 32, 16, true); },
            setplatform: function (v) { return CS.Call(3, 32, 16, true, v); },
            getrunInBackground: function () { return CS.Call(2, 32, 17, true); },
            setrunInBackground: function (v) { return CS.Call(3, 32, 17, true, v); },
            getsrcValue: function () { return CS.Call(2, 32, 18, true); },
            setsrcValue: function (v) { return CS.Call(3, 32, 18, true, v); },
            getstreamedBytes: function () { return CS.Call(2, 32, 19, true); },
            setstreamedBytes: function (v) { return CS.Call(3, 32, 19, true, v); },
            getstreamingAssetsPath: function () { return CS.Call(2, 32, 20, true); },
            setstreamingAssetsPath: function (v) { return CS.Call(3, 32, 20, true, v); },
            getsystemLanguage: function () { return CS.Call(2, 32, 21, true); },
            setsystemLanguage: function (v) { return CS.Call(3, 32, 21, true, v); },
            gettargetFrameRate: function () { return CS.Call(2, 32, 22, true); },
            settargetFrameRate: function (v) { return CS.Call(3, 32, 22, true, v); },
            gettemporaryCachePath: function () { return CS.Call(2, 32, 23, true); },
            settemporaryCachePath: function (v) { return CS.Call(3, 32, 23, true, v); },
            getunityVersion: function () { return CS.Call(2, 32, 24, true); },
            setunityVersion: function (v) { return CS.Call(3, 32, 24, true, v); },
            getwebSecurityEnabled: function () { return CS.Call(2, 32, 25, true); },
            setwebSecurityEnabled: function (v) { return CS.Call(3, 32, 25, true, v); },
            getwebSecurityHostUrl: function () { return CS.Call(2, 32, 26, true); },
            setwebSecurityHostUrl: function (v) { return CS.Call(3, 32, 26, true, v); },
            CancelQuit: function () { return CS.Call(4, 32, 0, true); },
            CanStreamedLevelBeLoaded: function (a0/* Int32 */) { return CS.Call(4, 32, 1, true, a0); },
            CanStreamedLevelBeLoaded$1: function (a0/* String */) { return CS.Call(4, 32, 2, true, a0); },
            CaptureScreenshot: function (a0/* String */) { return CS.Call(4, 32, 3, true, a0); },
            CaptureScreenshot$1: function (a0/* String */, a1/* Int32 */) { return CS.Call(4, 32, 4, true, a0, a1); },
            ExternalCall: function (a0/* String */, a1/* Object[] */) { return CS.Call(4, 32, 5, true, a0, a1); },
            GetStreamProgressForLevel: function (a0/* Int32 */) { return CS.Call(4, 32, 6, true, a0); },
            GetStreamProgressForLevel$1: function (a0/* String */) { return CS.Call(4, 32, 7, true, a0); },
            HasProLicense: function () { return CS.Call(4, 32, 8, true); },
            HasUserAuthorization: function (a0/* UserAuthorization */) { return CS.Call(4, 32, 9, true, a0); },
            LoadLevel: function (a0/* Int32 */) { return CS.Call(4, 32, 10, true, a0); },
            LoadLevel$1: function (a0/* String */) { return CS.Call(4, 32, 11, true, a0); },
            LoadLevelAdditive: function (a0/* Int32 */) { return CS.Call(4, 32, 12, true, a0); },
            LoadLevelAdditive$1: function (a0/* String */) { return CS.Call(4, 32, 13, true, a0); },
            LoadLevelAdditiveAsync: function (a0/* Int32 */) { return CS.Call(4, 32, 14, true, a0); },
            LoadLevelAdditiveAsync$1: function (a0/* String */) { return CS.Call(4, 32, 15, true, a0); },
            LoadLevelAsync: function (a0/* Int32 */) { return CS.Call(4, 32, 16, true, a0); },
            LoadLevelAsync$1: function (a0/* String */) { return CS.Call(4, 32, 17, true, a0); },
            OpenURL: function (a0/* String */) { return CS.Call(4, 32, 18, true, a0); },
            Quit: function () { return CS.Call(4, 32, 19, true); },
            RegisterLogCallback: function (a0/* LogCallback */) { return CS.Call(4, 32, 20, true, a0); },
            RegisterLogCallbackThreaded: function (a0/* LogCallback */) { return CS.Call(4, 32, 21, true, a0); },
            RequestUserAuthorization: function (a0/* UserAuthorization */) { return CS.Call(4, 32, 22, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 32, 0, true, this);
        },
    });
    if ($hc < 34) { return; }
     
    Bridge.define("jsb.Test.Framwork.TestRF", {
        statics: {
            Get_Out: function (a0/* Int32& */) { return CS.Call(4, 33, 0, true, a0); },
            Increase_ByRef: function (a0/* Boolean */, a1/* Int32& */) { return CS.Call(4, 33, 1, true, a0, a1); },
        },
        ctor: function () {
            CS.Call(5, 33, 0, true, this);
        },
    });
    if ($hc < 35) { return; }
     
    Bridge.define("jsb.Test.Framwork.TestMisc", {
        statics: {
            GetL: function (a0/* Action`1 */) { return CS.Call(4, 34, 1, true, a0); },
            GetUL: function (a0/* Action`1 */) { return CS.Call(4, 34, 2, true, a0); },
            SetL: function (a0/* Int64 */) { return CS.Call(4, 34, 3, true, a0); },
            SetUL: function (a0/* UInt64 */) { return CS.Call(4, 34, 4, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 34, 0, true, this);
        },
        TestParams: function (a0/* String[] */) { return CS.Call(4, 34, 0, false, this, a0); },
    });
    if ($hc < 36) { return; }
     
    Bridge.define("jsb.Test.Framwork.TestPerformance", {
        statics: {
            $fields: {
                StaticObject: {
                    get: function () { return CS.Call(0, 35, 0, true); },
                    set: function (v) { return CS.Call(1, 35, 0, true, v); }
                },
            },
            test123: function (a0/* Object[] */) { return CS.Call(4, 35, 0, true, a0); },
            testString: function (a0/* String[] */) { return CS.Call(4, 35, 1, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 35, 0, true, this);
        },
    });
    if ($hc < 37) { return; }
     
    Bridge.define("UnityEngine.EventSystems.ISelectHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnSelect: function (a0/* BaseEventData */) { return CS.Call(4, 36, 0, false, this, a0); },
    });
    if ($hc < 38) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IMoveHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnMove: function (a0/* AxisEventData */) { return CS.Call(4, 37, 0, false, this, a0); },
    });
    if ($hc < 39) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IDeselectHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnDeselect: function (a0/* BaseEventData */) { return CS.Call(4, 38, 0, false, this, a0); },
    });
    if ($hc < 40) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IPointerEnterHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnPointerEnter: function (a0/* PointerEventData */) { return CS.Call(4, 39, 0, false, this, a0); },
    });
    if ($hc < 41) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IPointerExitHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnPointerExit: function (a0/* PointerEventData */) { return CS.Call(4, 40, 0, false, this, a0); },
    });
    if ($hc < 42) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IPointerClickHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnPointerClick: function (a0/* PointerEventData */) { return CS.Call(4, 41, 0, false, this, a0); },
    });
    if ($hc < 43) { return; }
     
    Bridge.define("UnityEngine.EventSystems.ISubmitHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnSubmit: function (a0/* BaseEventData */) { return CS.Call(4, 42, 0, false, this, a0); },
    });
    if ($hc < 44) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IPointerUpHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnPointerUp: function (a0/* PointerEventData */) { return CS.Call(4, 43, 0, false, this, a0); },
    });
    if ($hc < 45) { return; }
     
    Bridge.define("UnityEngine.Events.UnityEventBase", {
        inherits: [UnityEngine.ISerializationCallbackReceiver],
        statics: {
            GetValidMethodInfo: function (a0/* Object */, a1/* String */, a2/* Type[] */) { return CS.Call(4, 44, 6, true, a0, a1, a2); },
        },
        GetPersistentEventCount: function () { return CS.Call(4, 44, 0, false, this); },
        GetPersistentMethodName: function (a0/* Int32 */) { return CS.Call(4, 44, 1, false, this, a0); },
        GetPersistentTarget: function (a0/* Int32 */) { return CS.Call(4, 44, 2, false, this, a0); },
        RemoveAllListeners: function () { return CS.Call(4, 44, 3, false, this); },
        SetPersistentListenerState: function (a0/* Int32 */, a1/* UnityEventCallState */) { return CS.Call(4, 44, 4, false, this, a0, a1); },
        ToString: function () { return CS.Call(4, 44, 5, false, this); },
    });
    if ($hc < 46) { return; }
     
    Bridge.define("UnityEngine.UI.ILayoutGroup", {
        inherits: [UnityEngine.UI.ILayoutController],
        $kind: "interface",
        statics: {
        },
    });
    if ($hc < 47) { return; }
     
    Bridge.define("UnityEngine.EventSystems.IPointerDownHandler", {
        inherits: [UnityEngine.EventSystems.IEventSystemHandler],
        $kind: "interface",
        statics: {
        },
        OnPointerDown: function (a0/* PointerEventData */) { return CS.Call(4, 46, 0, false, this, a0); },
    });
    if ($hc < 48) { return; }
     
    Bridge.define("UnityEngine.Material", {
        inherits: [UnityEngine.Object],
        statics: {
        },
        ctor: function (a0) {
            CS.Call(5, 47, 0, true, this, a0);
        },
        $ctor1: function (a0) {
            CS.Call(5, 47, 1, true, this, a0);
        },
        $ctor2: function (a0) {
            CS.Call(5, 47, 2, true, this, a0);
        },
        getcolor: function () { return CS.Call(2, 47, 0, false, this); },
        setcolor: function (v) { return CS.Call(3, 47, 0, false, this, v); },
        getmainTexture: function () { return CS.Call(2, 47, 1, false, this); },
        setmainTexture: function (v) { return CS.Call(3, 47, 1, false, this, v); },
        getmainTextureOffset: function () { return CS.Call(2, 47, 2, false, this); },
        setmainTextureOffset: function (v) { return CS.Call(3, 47, 2, false, this, v); },
        getmainTextureScale: function () { return CS.Call(2, 47, 3, false, this); },
        setmainTextureScale: function (v) { return CS.Call(3, 47, 3, false, this, v); },
        getpassCount: function () { return CS.Call(2, 47, 4, false, this); },
        setpassCount: function (v) { return CS.Call(3, 47, 4, false, this, v); },
        getrenderQueue: function () { return CS.Call(2, 47, 5, false, this); },
        setrenderQueue: function (v) { return CS.Call(3, 47, 5, false, this, v); },
        getshader: function () { return CS.Call(2, 47, 6, false, this); },
        setshader: function (v) { return CS.Call(3, 47, 6, false, this, v); },
        getshaderKeywords: function () { return CS.Call(2, 47, 7, false, this); },
        setshaderKeywords: function (v) { return CS.Call(3, 47, 7, false, this, v); },
        CopyPropertiesFromMaterial: function (a0/* Material */) { return CS.Call(4, 47, 0, false, this, a0); },
        DisableKeyword: function (a0/* String */) { return CS.Call(4, 47, 1, false, this, a0); },
        EnableKeyword: function (a0/* String */) { return CS.Call(4, 47, 2, false, this, a0); },
        GetColor: function (a0/* Int32 */) { return CS.Call(4, 47, 3, false, this, a0); },
        GetColor$1: function (a0/* String */) { return CS.Call(4, 47, 4, false, this, a0); },
        GetFloat: function (a0/* Int32 */) { return CS.Call(4, 47, 5, false, this, a0); },
        GetFloat$1: function (a0/* String */) { return CS.Call(4, 47, 6, false, this, a0); },
        GetInt: function (a0/* Int32 */) { return CS.Call(4, 47, 7, false, this, a0); },
        GetInt$1: function (a0/* String */) { return CS.Call(4, 47, 8, false, this, a0); },
        GetMatrix: function (a0/* Int32 */) { return CS.Call(4, 47, 9, false, this, a0); },
        GetMatrix$1: function (a0/* String */) { return CS.Call(4, 47, 10, false, this, a0); },
        GetTag: function (a0/* String */, a1/* Boolean */) { return CS.Call(4, 47, 11, false, this, a0, a1); },
        GetTag$1: function (a0/* String */, a1/* Boolean */, a2/* String */) { return CS.Call(4, 47, 12, false, this, a0, a1, a2); },
        GetTexture: function (a0/* Int32 */) { return CS.Call(4, 47, 13, false, this, a0); },
        GetTexture$1: function (a0/* String */) { return CS.Call(4, 47, 14, false, this, a0); },
        GetTextureOffset: function (a0/* String */) { return CS.Call(4, 47, 15, false, this, a0); },
        GetTextureScale: function (a0/* String */) { return CS.Call(4, 47, 16, false, this, a0); },
        GetVector: function (a0/* Int32 */) { return CS.Call(4, 47, 17, false, this, a0); },
        GetVector$1: function (a0/* String */) { return CS.Call(4, 47, 18, false, this, a0); },
        HasProperty: function (a0/* Int32 */) { return CS.Call(4, 47, 19, false, this, a0); },
        HasProperty$1: function (a0/* String */) { return CS.Call(4, 47, 20, false, this, a0); },
        Lerp: function (a0/* Material */, a1/* Material */, a2/* Single */) { return CS.Call(4, 47, 21, false, this, a0, a1, a2); },
        SetBuffer: function (a0/* String */, a1/* ComputeBuffer */) { return CS.Call(4, 47, 22, false, this, a0, a1); },
        SetColor: function (a0/* Int32 */, a1/* Color */) { return CS.Call(4, 47, 23, false, this, a0, a1); },
        SetColor$1: function (a0/* String */, a1/* Color */) { return CS.Call(4, 47, 24, false, this, a0, a1); },
        SetFloat: function (a0/* Int32 */, a1/* Single */) { return CS.Call(4, 47, 25, false, this, a0, a1); },
        SetFloat$1: function (a0/* String */, a1/* Single */) { return CS.Call(4, 47, 26, false, this, a0, a1); },
        SetInt: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 47, 27, false, this, a0, a1); },
        SetInt$1: function (a0/* String */, a1/* Int32 */) { return CS.Call(4, 47, 28, false, this, a0, a1); },
        SetMatrix: function (a0/* Int32 */, a1/* Matrix4x4 */) { return CS.Call(4, 47, 29, false, this, a0, a1); },
        SetMatrix$1: function (a0/* String */, a1/* Matrix4x4 */) { return CS.Call(4, 47, 30, false, this, a0, a1); },
        SetPass: function (a0/* Int32 */) { return CS.Call(4, 47, 31, false, this, a0); },
        SetTexture: function (a0/* Int32 */, a1/* Texture */) { return CS.Call(4, 47, 32, false, this, a0, a1); },
        SetTexture$1: function (a0/* String */, a1/* Texture */) { return CS.Call(4, 47, 33, false, this, a0, a1); },
        SetTextureOffset: function (a0/* String */, a1/* Vector2 */) { return CS.Call(4, 47, 34, false, this, a0, a1); },
        SetTextureScale: function (a0/* String */, a1/* Vector2 */) { return CS.Call(4, 47, 35, false, this, a0, a1); },
        SetVector: function (a0/* Int32 */, a1/* Vector4 */) { return CS.Call(4, 47, 36, false, this, a0, a1); },
        SetVector$1: function (a0/* String */, a1/* Vector4 */) { return CS.Call(4, 47, 37, false, this, a0, a1); },
    });
    if ($hc < 49) { return; }
     
    Bridge.define("UnityEngine.Component", {
        inherits: [UnityEngine.Object],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 48, 0, true, this);
        },
        getanimation: function () { return CS.Call(2, 48, 0, false, this); },
        setanimation: function (v) { return CS.Call(3, 48, 0, false, this, v); },
        getaudio: function () { return CS.Call(2, 48, 1, false, this); },
        setaudio: function (v) { return CS.Call(3, 48, 1, false, this, v); },
        getcamera: function () { return CS.Call(2, 48, 2, false, this); },
        setcamera: function (v) { return CS.Call(3, 48, 2, false, this, v); },
        getcollider: function () { return CS.Call(2, 48, 3, false, this); },
        setcollider: function (v) { return CS.Call(3, 48, 3, false, this, v); },
        getcollider2D: function () { return CS.Call(2, 48, 4, false, this); },
        setcollider2D: function (v) { return CS.Call(3, 48, 4, false, this, v); },
        getconstantForce: function () { return CS.Call(2, 48, 5, false, this); },
        setconstantForce: function (v) { return CS.Call(3, 48, 5, false, this, v); },
        getgameObject: function () { return CS.Call(2, 48, 6, false, this); },
        setgameObject: function (v) { return CS.Call(3, 48, 6, false, this, v); },
        getguiText: function () { return CS.Call(2, 48, 7, false, this); },
        setguiText: function (v) { return CS.Call(3, 48, 7, false, this, v); },
        getguiTexture: function () { return CS.Call(2, 48, 8, false, this); },
        setguiTexture: function (v) { return CS.Call(3, 48, 8, false, this, v); },
        gethingeJoint: function () { return CS.Call(2, 48, 9, false, this); },
        sethingeJoint: function (v) { return CS.Call(3, 48, 9, false, this, v); },
        getlight: function () { return CS.Call(2, 48, 10, false, this); },
        setlight: function (v) { return CS.Call(3, 48, 10, false, this, v); },
        getparticleEmitter: function () { return CS.Call(2, 48, 11, false, this); },
        setparticleEmitter: function (v) { return CS.Call(3, 48, 11, false, this, v); },
        getparticleSystem: function () { return CS.Call(2, 48, 12, false, this); },
        setparticleSystem: function (v) { return CS.Call(3, 48, 12, false, this, v); },
        getrenderer: function () { return CS.Call(2, 48, 13, false, this); },
        setrenderer: function (v) { return CS.Call(3, 48, 13, false, this, v); },
        getrigidbody: function () { return CS.Call(2, 48, 14, false, this); },
        setrigidbody: function (v) { return CS.Call(3, 48, 14, false, this, v); },
        getrigidbody2D: function () { return CS.Call(2, 48, 15, false, this); },
        setrigidbody2D: function (v) { return CS.Call(3, 48, 15, false, this, v); },
        gettag: function () { return CS.Call(2, 48, 16, false, this); },
        settag: function (v) { return CS.Call(3, 48, 16, false, this, v); },
        gettransform: function () { return CS.Call(2, 48, 17, false, this); },
        settransform: function (v) { return CS.Call(3, 48, 17, false, this, v); },
        BroadcastMessage: function (a0/* String */) { return CS.Call(4, 48, 0, false, this, a0); },
        BroadcastMessage$1: function (a0/* String */, a1/* Object */) { return CS.Call(4, 48, 1, false, this, a0, a1); },
        BroadcastMessage$2: function (a0/* String */, a1/* Object */, a2/* SendMessageOptions */) { return CS.Call(4, 48, 2, false, this, a0, a1, a2); },
        BroadcastMessage$3: function (a0/* String */, a1/* SendMessageOptions */) { return CS.Call(4, 48, 3, false, this, a0, a1); },
        CompareTag: function (a0/* String */) { return CS.Call(4, 48, 4, false, this, a0); },
        GetComponent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 5, false, this, $T);
        },
        GetComponent$1: function (a0/* String */) { return CS.Call(4, 48, 6, false, this, a0); },
        GetComponent$2: function (a0/* Type */) { return CS.Call(4, 48, 7, false, this, a0); },
        GetComponentInChildren: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 8, false, this, $T);
        },
        GetComponentInChildren$1: function (a0/* Type */) { return CS.Call(4, 48, 9, false, this, a0); },
        GetComponentInParent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 10, false, this, $T);
        },
        GetComponentInParent$1: function (a0/* Type */) { return CS.Call(4, 48, 11, false, this, a0); },
        GetComponents: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 12, false, this, $T);
        },
        GetComponents$1: function (a0/* Type */, a1/* List`1 */) { return CS.Call(4, 48, 13, false, this, a0, a1); },
        GetComponents$2: function (T, a0/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 14, false, this, $T, a0);
        },
        GetComponents$3: function (a0/* Type */) { return CS.Call(4, 48, 15, false, this, a0); },
        GetComponentsInChildren: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 16, false, this, $T);
        },
        GetComponentsInChildren$1: function (T, a0/* Boolean */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 17, false, this, $T, a0);
        },
        GetComponentsInChildren$2: function (T, a0/* Boolean */, a1/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 18, false, this, $T, a0, a1);
        },
        GetComponentsInChildren$3: function (T, a0/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 19, false, this, $T, a0);
        },
        GetComponentsInChildren$4: function (a0/* Type */) { return CS.Call(4, 48, 20, false, this, a0); },
        GetComponentsInChildren$5: function (a0/* Type */, a1/* Boolean */) { return CS.Call(4, 48, 21, false, this, a0, a1); },
        GetComponentsInParent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 22, false, this, $T);
        },
        GetComponentsInParent$1: function (T, a0/* Boolean */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 48, 23, false, this, $T, a0);
        },
        GetComponentsInParent$2: function (a0/* Type */) { return CS.Call(4, 48, 24, false, this, a0); },
        GetComponentsInParent$3: function (a0/* Type */, a1/* Boolean */) { return CS.Call(4, 48, 25, false, this, a0, a1); },
        SendMessage: function (a0/* String */) { return CS.Call(4, 48, 26, false, this, a0); },
        SendMessage$1: function (a0/* String */, a1/* Object */) { return CS.Call(4, 48, 27, false, this, a0, a1); },
        SendMessage$2: function (a0/* String */, a1/* Object */, a2/* SendMessageOptions */) { return CS.Call(4, 48, 28, false, this, a0, a1, a2); },
        SendMessage$3: function (a0/* String */, a1/* SendMessageOptions */) { return CS.Call(4, 48, 29, false, this, a0, a1); },
        SendMessageUpwards: function (a0/* String */) { return CS.Call(4, 48, 30, false, this, a0); },
        SendMessageUpwards$1: function (a0/* String */, a1/* Object */) { return CS.Call(4, 48, 31, false, this, a0, a1); },
        SendMessageUpwards$2: function (a0/* String */, a1/* Object */, a2/* SendMessageOptions */) { return CS.Call(4, 48, 32, false, this, a0, a1, a2); },
        SendMessageUpwards$3: function (a0/* String */, a1/* SendMessageOptions */) { return CS.Call(4, 48, 33, false, this, a0, a1); },
    });
    if ($hc < 50) { return; }
     
    Bridge.define("UnityEngine.AudioClip", {
        inherits: [UnityEngine.Object],
        statics: {
            Create: function (a0/* String */, a1/* Int32 */, a2/* Int32 */, a3/* Int32 */, a4/* Boolean */, a5/* Boolean */) { return CS.Call(4, 49, 2, true, a0, a1, a2, a3, a4, a5); },
            Create$1: function (a0/* String */, a1/* Int32 */, a2/* Int32 */, a3/* Int32 */, a4/* Boolean */, a5/* Boolean */, a6/* PCMReaderCallback */) { return CS.Call(4, 49, 3, true, a0, a1, a2, a3, a4, a5, a6); },
            Create$2: function (a0/* String */, a1/* Int32 */, a2/* Int32 */, a3/* Int32 */, a4/* Boolean */, a5/* Boolean */, a6/* PCMReaderCallback */, a7/* PCMSetPositionCallback */) { return CS.Call(4, 49, 4, true, a0, a1, a2, a3, a4, a5, a6, a7); },
        },
        ctor: function () {
            CS.Call(5, 49, 0, true, this);
        },
        getchannels: function () { return CS.Call(2, 49, 0, false, this); },
        setchannels: function (v) { return CS.Call(3, 49, 0, false, this, v); },
        getfrequency: function () { return CS.Call(2, 49, 1, false, this); },
        setfrequency: function (v) { return CS.Call(3, 49, 1, false, this, v); },
        getisReadyToPlay: function () { return CS.Call(2, 49, 2, false, this); },
        setisReadyToPlay: function (v) { return CS.Call(3, 49, 2, false, this, v); },
        getlength: function () { return CS.Call(2, 49, 3, false, this); },
        setlength: function (v) { return CS.Call(3, 49, 3, false, this, v); },
        getsamples: function () { return CS.Call(2, 49, 4, false, this); },
        setsamples: function (v) { return CS.Call(3, 49, 4, false, this, v); },
        GetData: function (a0/* Single[] */, a1/* Int32 */) { return CS.Call(4, 49, 0, false, this, a0, a1); },
        SetData: function (a0/* Single[] */, a1/* Int32 */) { return CS.Call(4, 49, 1, false, this, a0, a1); },
    });
    if ($hc < 51) { return; }
     
    Bridge.define("UnityEngine.TextAsset", {
        inherits: [UnityEngine.Object],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 50, 0, true, this);
        },
        getbytes: function () { return CS.Call(2, 50, 0, false, this); },
        setbytes: function (v) { return CS.Call(3, 50, 0, false, this, v); },
        gettext: function () { return CS.Call(2, 50, 1, false, this); },
        settext: function (v) { return CS.Call(3, 50, 1, false, this, v); },
        ToString: function () { return CS.Call(4, 50, 0, false, this); },
    });
    if ($hc < 52) { return; }
     
    Bridge.define("UnityEngine.WaitForSeconds", {
        inherits: [UnityEngine.YieldInstruction],
        statics: {
        },
        ctor: function (a0) {
            this.$totalTime = a0;
            this.$elapsedTime = 0;
            this.$finished = false;
        },
    });
    if ($hc < 53) { return; }
     
    Bridge.define("UnityEngine.GameObject", {
        inherits: [UnityEngine.Object],
        statics: {
            CreatePrimitive: function (a0/* PrimitiveType */) { return CS.Call(4, 52, 40, true, a0); },
            Find: function (a0/* String */) { return CS.Call(4, 52, 41, true, a0); },
            FindGameObjectsWithTag: function (a0/* String */) { return CS.Call(4, 52, 42, true, a0); },
            FindGameObjectWithTag: function (a0/* String */) { return CS.Call(4, 52, 43, true, a0); },
            FindWithTag: function (a0/* String */) { return CS.Call(4, 52, 44, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 52, 0, true, this);
        },
        $ctor1: function (a0) {
            CS.Call(5, 52, 1, true, this, a0);
        },
        $ctor2: function (a0, a1) {
            CS.Call(5, 52, 2, true, this, a0, a1);
        },
        getactiveInHierarchy: function () { return CS.Call(2, 52, 0, false, this); },
        setactiveInHierarchy: function (v) { return CS.Call(3, 52, 0, false, this, v); },
        getactiveSelf: function () { return CS.Call(2, 52, 1, false, this); },
        setactiveSelf: function (v) { return CS.Call(3, 52, 1, false, this, v); },
        getanimation: function () { return CS.Call(2, 52, 2, false, this); },
        setanimation: function (v) { return CS.Call(3, 52, 2, false, this, v); },
        getaudio: function () { return CS.Call(2, 52, 3, false, this); },
        setaudio: function (v) { return CS.Call(3, 52, 3, false, this, v); },
        getcamera: function () { return CS.Call(2, 52, 4, false, this); },
        setcamera: function (v) { return CS.Call(3, 52, 4, false, this, v); },
        getcollider: function () { return CS.Call(2, 52, 5, false, this); },
        setcollider: function (v) { return CS.Call(3, 52, 5, false, this, v); },
        getcollider2D: function () { return CS.Call(2, 52, 6, false, this); },
        setcollider2D: function (v) { return CS.Call(3, 52, 6, false, this, v); },
        getconstantForce: function () { return CS.Call(2, 52, 7, false, this); },
        setconstantForce: function (v) { return CS.Call(3, 52, 7, false, this, v); },
        getgameObject: function () { return CS.Call(2, 52, 8, false, this); },
        setgameObject: function (v) { return CS.Call(3, 52, 8, false, this, v); },
        getguiText: function () { return CS.Call(2, 52, 9, false, this); },
        setguiText: function (v) { return CS.Call(3, 52, 9, false, this, v); },
        getguiTexture: function () { return CS.Call(2, 52, 10, false, this); },
        setguiTexture: function (v) { return CS.Call(3, 52, 10, false, this, v); },
        gethingeJoint: function () { return CS.Call(2, 52, 11, false, this); },
        sethingeJoint: function (v) { return CS.Call(3, 52, 11, false, this, v); },
        getisStatic: function () { return CS.Call(2, 52, 12, false, this); },
        setisStatic: function (v) { return CS.Call(3, 52, 12, false, this, v); },
        getlayer: function () { return CS.Call(2, 52, 13, false, this); },
        setlayer: function (v) { return CS.Call(3, 52, 13, false, this, v); },
        getlight: function () { return CS.Call(2, 52, 14, false, this); },
        setlight: function (v) { return CS.Call(3, 52, 14, false, this, v); },
        getparticleEmitter: function () { return CS.Call(2, 52, 15, false, this); },
        setparticleEmitter: function (v) { return CS.Call(3, 52, 15, false, this, v); },
        getparticleSystem: function () { return CS.Call(2, 52, 16, false, this); },
        setparticleSystem: function (v) { return CS.Call(3, 52, 16, false, this, v); },
        getrenderer: function () { return CS.Call(2, 52, 17, false, this); },
        setrenderer: function (v) { return CS.Call(3, 52, 17, false, this, v); },
        getrigidbody: function () { return CS.Call(2, 52, 18, false, this); },
        setrigidbody: function (v) { return CS.Call(3, 52, 18, false, this, v); },
        getrigidbody2D: function () { return CS.Call(2, 52, 19, false, this); },
        setrigidbody2D: function (v) { return CS.Call(3, 52, 19, false, this, v); },
        gettag: function () { return CS.Call(2, 52, 20, false, this); },
        settag: function (v) { return CS.Call(3, 52, 20, false, this, v); },
        gettransform: function () { return CS.Call(2, 52, 21, false, this); },
        settransform: function (v) { return CS.Call(3, 52, 21, false, this, v); },
        AddComponent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 0, false, this, $T);
        },
        AddComponent$1: function (a0/* String */) { return CS.Call(4, 52, 1, false, this, a0); },
        AddComponent$2: function (a0/* Type */) { return CS.Call(4, 52, 2, false, this, Bridge.Reflection.getTypeFullName(a0)); },
        BroadcastMessage: function (a0/* String */) { return CS.Call(4, 52, 3, false, this, a0); },
        BroadcastMessage$1: function (a0/* String */, a1/* Object */) { return CS.Call(4, 52, 4, false, this, a0, a1); },
        BroadcastMessage$2: function (a0/* String */, a1/* Object */, a2/* SendMessageOptions */) { return CS.Call(4, 52, 5, false, this, a0, a1, a2); },
        BroadcastMessage$3: function (a0/* String */, a1/* SendMessageOptions */) { return CS.Call(4, 52, 6, false, this, a0, a1); },
        CompareTag: function (a0/* String */) { return CS.Call(4, 52, 7, false, this, a0); },
        GetComponent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 8, false, this, $T);
        },
        GetComponent$1: function (a0/* String */) { return CS.Call(4, 52, 9, false, this, a0); },
        GetComponent$2: function (a0/* Type */) { return CS.Call(4, 52, 10, false, this, a0); },
        GetComponentInChildren: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 11, false, this, $T);
        },
        GetComponentInChildren$1: function (a0/* Type */) { return CS.Call(4, 52, 12, false, this, a0); },
        GetComponentInParent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 13, false, this, $T);
        },
        GetComponentInParent$1: function (a0/* Type */) { return CS.Call(4, 52, 14, false, this, a0); },
        GetComponents: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 15, false, this, $T);
        },
        GetComponents$1: function (a0/* Type */, a1/* List`1 */) { return CS.Call(4, 52, 16, false, this, a0, a1); },
        GetComponents$2: function (T, a0/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 17, false, this, $T, a0);
        },
        GetComponents$3: function (a0/* Type */) { return CS.Call(4, 52, 18, false, this, a0); },
        GetComponentsInChildren: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 19, false, this, $T);
        },
        GetComponentsInChildren$1: function (T, a0/* Boolean */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 20, false, this, $T, a0);
        },
        GetComponentsInChildren$2: function (T, a0/* Boolean */, a1/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 21, false, this, $T, a0, a1);
        },
        GetComponentsInChildren$3: function (T, a0/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 22, false, this, $T, a0);
        },
        GetComponentsInChildren$4: function (a0/* Type */) { return CS.Call(4, 52, 23, false, this, a0); },
        GetComponentsInChildren$5: function (a0/* Type */, a1/* Boolean */) { return CS.Call(4, 52, 24, false, this, a0, a1); },
        GetComponentsInParent: function (T) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 25, false, this, $T);
        },
        GetComponentsInParent$1: function (T, a0/* Boolean */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 26, false, this, $T, a0);
        },
        GetComponentsInParent$2: function (T, a0/* Boolean */, a1/* List`1 */) {
            var $T = Bridge.Reflection.getTypeFullName(T);
            return CS.Call(4, 52, 27, false, this, $T, a0, a1);
        },
        GetComponentsInParent$3: function (a0/* Type */) { return CS.Call(4, 52, 28, false, this, a0); },
        GetComponentsInParent$4: function (a0/* Type */, a1/* Boolean */) { return CS.Call(4, 52, 29, false, this, a0, a1); },
        SampleAnimation: function (a0/* AnimationClip */, a1/* Single */) { return CS.Call(4, 52, 30, false, this, a0, a1); },
        SendMessage: function (a0/* String */) { return CS.Call(4, 52, 31, false, this, a0); },
        SendMessage$1: function (a0/* String */, a1/* Object */) { return CS.Call(4, 52, 32, false, this, a0, a1); },
        SendMessage$2: function (a0/* String */, a1/* Object */, a2/* SendMessageOptions */) { return CS.Call(4, 52, 33, false, this, a0, a1, a2); },
        SendMessage$3: function (a0/* String */, a1/* SendMessageOptions */) { return CS.Call(4, 52, 34, false, this, a0, a1); },
        SendMessageUpwards: function (a0/* String */) { return CS.Call(4, 52, 35, false, this, a0); },
        SendMessageUpwards$1: function (a0/* String */, a1/* Object */) { return CS.Call(4, 52, 36, false, this, a0, a1); },
        SendMessageUpwards$2: function (a0/* String */, a1/* Object */, a2/* SendMessageOptions */) { return CS.Call(4, 52, 37, false, this, a0, a1, a2); },
        SendMessageUpwards$3: function (a0/* String */, a1/* SendMessageOptions */) { return CS.Call(4, 52, 38, false, this, a0, a1); },
        SetActive: function (a0/* Boolean */) { return CS.Call(4, 52, 39, false, this, a0); },
    });
    if ($hc < 54) { return; }
     
    Bridge.define("System.Collections.Hashtable", {
        inherits: [System.Collections.IEnumerable, System.ICloneable, System.Runtime.Serialization.ISerializable, System.Collections.ICollection, System.Collections.IDictionary, System.Runtime.Serialization.IDeserializationCallback],
        statics: {
            Synchronized: function (a0/* Hashtable */) { return CS.Call(4, 53, 11, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 53, 0, true, this);
        },
        $ctor1: function (a0) {
            CS.Call(5, 53, 1, true, this, a0);
        },
        $ctor2: function (a0, a1) {
            CS.Call(5, 53, 2, true, this, a0, a1);
        },
        $ctor3: function (a0, a1) {
            CS.Call(5, 53, 3, true, this, a0, a1);
        },
        $ctor4: function (a0, a1, a2) {
            CS.Call(5, 53, 4, true, this, a0, a1, a2);
        },
        $ctor5: function (a0) {
            CS.Call(5, 53, 5, true, this, a0);
        },
        $ctor6: function (a0) {
            CS.Call(5, 53, 6, true, this, a0);
        },
        $ctor7: function (a0, a1) {
            CS.Call(5, 53, 7, true, this, a0, a1);
        },
        $ctor8: function (a0, a1) {
            CS.Call(5, 53, 8, true, this, a0, a1);
        },
        $ctor9: function (a0, a1, a2) {
            CS.Call(5, 53, 9, true, this, a0, a1, a2);
        },
        getCount: function () { return CS.Call(2, 53, 0, false, this); },
        setCount: function (v) { return CS.Call(3, 53, 0, false, this, v); },
        getIsFixedSize: function () { return CS.Call(2, 53, 1, false, this); },
        setIsFixedSize: function (v) { return CS.Call(3, 53, 1, false, this, v); },
        getIsReadOnly: function () { return CS.Call(2, 53, 2, false, this); },
        setIsReadOnly: function (v) { return CS.Call(3, 53, 2, false, this, v); },
        getIsSynchronized: function () { return CS.Call(2, 53, 3, false, this); },
        setIsSynchronized: function (v) { return CS.Call(3, 53, 3, false, this, v); },
        getItem: function (ind0) { return CS.Call(2, 53, 4, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 53, 4, false, this, ind0, v); },
        getKeys: function () { return CS.Call(2, 53, 5, false, this); },
        setKeys: function (v) { return CS.Call(3, 53, 5, false, this, v); },
        getSyncRoot: function () { return CS.Call(2, 53, 6, false, this); },
        setSyncRoot: function (v) { return CS.Call(3, 53, 6, false, this, v); },
        getValues: function () { return CS.Call(2, 53, 7, false, this); },
        setValues: function (v) { return CS.Call(3, 53, 7, false, this, v); },
        Add: function (a0/* Object */, a1/* Object */) { return CS.Call(4, 53, 0, false, this, a0, a1); },
        Clear: function () { return CS.Call(4, 53, 1, false, this); },
        Clone: function () { return CS.Call(4, 53, 2, false, this); },
        Contains: function (a0/* Object */) { return CS.Call(4, 53, 3, false, this, a0); },
        ContainsKey: function (a0/* Object */) { return CS.Call(4, 53, 4, false, this, a0); },
        ContainsValue: function (a0/* Object */) { return CS.Call(4, 53, 5, false, this, a0); },
        CopyTo: function (a0/* Array */, a1/* Int32 */) { return CS.Call(4, 53, 6, false, this, a0, a1); },
        GetEnumerator: function () { return CS.Call(4, 53, 7, false, this); },
        GetObjectData: function (a0/* SerializationInfo */, a1/* StreamingContext */) { return CS.Call(4, 53, 8, false, this, a0, a1); },
        OnDeserialization: function (a0/* Object */) { return CS.Call(4, 53, 9, false, this, a0); },
        Remove: function (a0/* Object */) { return CS.Call(4, 53, 10, false, this, a0); },
    });
    if ($hc < 55) { return; }
     
    Bridge.define("UnityEngine.Sprite", {
        inherits: [UnityEngine.Object],
        statics: {
            Create: function (a0/* Texture2D */, a1/* Rect */, a2/* Vector2 */) { return CS.Call(4, 54, 0, true, a0, a1, a2); },
            Create$1: function (a0/* Texture2D */, a1/* Rect */, a2/* Vector2 */, a3/* Single */) { return CS.Call(4, 54, 1, true, a0, a1, a2, a3); },
            Create$2: function (a0/* Texture2D */, a1/* Rect */, a2/* Vector2 */, a3/* Single */, a4/* UInt32 */) { return CS.Call(4, 54, 2, true, a0, a1, a2, a3, a4); },
            Create$3: function (a0/* Texture2D */, a1/* Rect */, a2/* Vector2 */, a3/* Single */, a4/* UInt32 */, a5/* SpriteMeshType */) { return CS.Call(4, 54, 3, true, a0, a1, a2, a3, a4, a5); },
            Create$4: function (a0/* Texture2D */, a1/* Rect */, a2/* Vector2 */, a3/* Single */, a4/* UInt32 */, a5/* SpriteMeshType */, a6/* Vector4 */) { return CS.Call(4, 54, 4, true, a0, a1, a2, a3, a4, a5, a6); },
        },
        ctor: function () {
            CS.Call(5, 54, 0, true, this);
        },
        getborder: function () { return CS.Call(2, 54, 0, false, this); },
        setborder: function (v) { return CS.Call(3, 54, 0, false, this, v); },
        getbounds: function () { return CS.Call(2, 54, 1, false, this); },
        setbounds: function (v) { return CS.Call(3, 54, 1, false, this, v); },
        getpacked: function () { return CS.Call(2, 54, 2, false, this); },
        setpacked: function (v) { return CS.Call(3, 54, 2, false, this, v); },
        getpackingMode: function () { return CS.Call(2, 54, 3, false, this); },
        setpackingMode: function (v) { return CS.Call(3, 54, 3, false, this, v); },
        getpackingRotation: function () { return CS.Call(2, 54, 4, false, this); },
        setpackingRotation: function (v) { return CS.Call(3, 54, 4, false, this, v); },
        getpixelsPerUnit: function () { return CS.Call(2, 54, 5, false, this); },
        setpixelsPerUnit: function (v) { return CS.Call(3, 54, 5, false, this, v); },
        getrect: function () { return CS.Call(2, 54, 6, false, this); },
        setrect: function (v) { return CS.Call(3, 54, 6, false, this, v); },
        gettexture: function () { return CS.Call(2, 54, 7, false, this); },
        settexture: function (v) { return CS.Call(3, 54, 7, false, this, v); },
        gettextureRect: function () { return CS.Call(2, 54, 8, false, this); },
        settextureRect: function (v) { return CS.Call(3, 54, 8, false, this, v); },
        gettextureRectOffset: function () { return CS.Call(2, 54, 9, false, this); },
        settextureRectOffset: function (v) { return CS.Call(3, 54, 9, false, this, v); },
    });
    if ($hc < 56) { return; }
     
    Bridge.define("UnityEngine.Behaviour", {
        inherits: [UnityEngine.Component],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 55, 0, true, this);
        },
        getenabled: function () { return CS.Call(2, 55, 0, false, this); },
        setenabled: function (v) { return CS.Call(3, 55, 0, false, this, v); },
        getisActiveAndEnabled: function () { return CS.Call(2, 55, 1, false, this); },
        setisActiveAndEnabled: function (v) { return CS.Call(3, 55, 1, false, this, v); },
    });
    if ($hc < 57) { return; }
     
    Bridge.define("UnityEngine.Rigidbody", {
        inherits: [UnityEngine.Component],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 56, 0, true, this);
        },
        getangularDrag: function () { return CS.Call(2, 56, 0, false, this); },
        setangularDrag: function (v) { return CS.Call(3, 56, 0, false, this, v); },
        getangularVelocity: function () { return CS.Call(2, 56, 1, false, this); },
        setangularVelocity: function (v) { return CS.Call(3, 56, 1, false, this, v); },
        getcenterOfMass: function () { return CS.Call(2, 56, 2, false, this); },
        setcenterOfMass: function (v) { return CS.Call(3, 56, 2, false, this, v); },
        getcollisionDetectionMode: function () { return CS.Call(2, 56, 3, false, this); },
        setcollisionDetectionMode: function (v) { return CS.Call(3, 56, 3, false, this, v); },
        getconstraints: function () { return CS.Call(2, 56, 4, false, this); },
        setconstraints: function (v) { return CS.Call(3, 56, 4, false, this, v); },
        getdetectCollisions: function () { return CS.Call(2, 56, 5, false, this); },
        setdetectCollisions: function (v) { return CS.Call(3, 56, 5, false, this, v); },
        getdrag: function () { return CS.Call(2, 56, 6, false, this); },
        setdrag: function (v) { return CS.Call(3, 56, 6, false, this, v); },
        getfreezeRotation: function () { return CS.Call(2, 56, 7, false, this); },
        setfreezeRotation: function (v) { return CS.Call(3, 56, 7, false, this, v); },
        getinertiaTensor: function () { return CS.Call(2, 56, 8, false, this); },
        setinertiaTensor: function (v) { return CS.Call(3, 56, 8, false, this, v); },
        getinertiaTensorRotation: function () { return CS.Call(2, 56, 9, false, this); },
        setinertiaTensorRotation: function (v) { return CS.Call(3, 56, 9, false, this, v); },
        getinterpolation: function () { return CS.Call(2, 56, 10, false, this); },
        setinterpolation: function (v) { return CS.Call(3, 56, 10, false, this, v); },
        getisKinematic: function () { return CS.Call(2, 56, 11, false, this); },
        setisKinematic: function (v) { return CS.Call(3, 56, 11, false, this, v); },
        getmass: function () { return CS.Call(2, 56, 12, false, this); },
        setmass: function (v) { return CS.Call(3, 56, 12, false, this, v); },
        getmaxAngularVelocity: function () { return CS.Call(2, 56, 13, false, this); },
        setmaxAngularVelocity: function (v) { return CS.Call(3, 56, 13, false, this, v); },
        getposition: function () { return CS.Call(2, 56, 14, false, this); },
        setposition: function (v) { return CS.Call(3, 56, 14, false, this, v); },
        getrotation: function () { return CS.Call(2, 56, 15, false, this); },
        setrotation: function (v) { return CS.Call(3, 56, 15, false, this, v); },
        getsleepAngularVelocity: function () { return CS.Call(2, 56, 16, false, this); },
        setsleepAngularVelocity: function (v) { return CS.Call(3, 56, 16, false, this, v); },
        getsleepVelocity: function () { return CS.Call(2, 56, 17, false, this); },
        setsleepVelocity: function (v) { return CS.Call(3, 56, 17, false, this, v); },
        getsolverIterationCount: function () { return CS.Call(2, 56, 18, false, this); },
        setsolverIterationCount: function (v) { return CS.Call(3, 56, 18, false, this, v); },
        getuseConeFriction: function () { return CS.Call(2, 56, 19, false, this); },
        setuseConeFriction: function (v) { return CS.Call(3, 56, 19, false, this, v); },
        getuseGravity: function () { return CS.Call(2, 56, 20, false, this); },
        setuseGravity: function (v) { return CS.Call(3, 56, 20, false, this, v); },
        getvelocity: function () { return CS.Call(2, 56, 21, false, this); },
        setvelocity: function (v) { return CS.Call(3, 56, 21, false, this, v); },
        getworldCenterOfMass: function () { return CS.Call(2, 56, 22, false, this); },
        setworldCenterOfMass: function (v) { return CS.Call(3, 56, 22, false, this, v); },
        AddExplosionForce: function (a0/* Single */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 56, 0, false, this, a0, a1, a2); },
        AddExplosionForce$1: function (a0/* Single */, a1/* Vector3 */, a2/* Single */, a3/* Single */) { return CS.Call(4, 56, 1, false, this, a0, a1, a2, a3); },
        AddExplosionForce$2: function (a0/* Single */, a1/* Vector3 */, a2/* Single */, a3/* Single */, a4/* ForceMode */) { return CS.Call(4, 56, 2, false, this, a0, a1, a2, a3, a4); },
        AddForce: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 56, 3, false, this, a0, a1, a2); },
        AddForce$1: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* ForceMode */) { return CS.Call(4, 56, 4, false, this, a0, a1, a2, a3); },
        AddForce$2: function (a0/* Vector3 */) { return CS.Call(4, 56, 5, false, this, a0); },
        AddForce$3: function (a0/* Vector3 */, a1/* ForceMode */) { return CS.Call(4, 56, 6, false, this, a0, a1); },
        AddForceAtPosition: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 56, 7, false, this, a0, a1); },
        AddForceAtPosition$1: function (a0/* Vector3 */, a1/* Vector3 */, a2/* ForceMode */) { return CS.Call(4, 56, 8, false, this, a0, a1, a2); },
        AddRelativeForce: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 56, 9, false, this, a0, a1, a2); },
        AddRelativeForce$1: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* ForceMode */) { return CS.Call(4, 56, 10, false, this, a0, a1, a2, a3); },
        AddRelativeForce$2: function (a0/* Vector3 */) { return CS.Call(4, 56, 11, false, this, a0); },
        AddRelativeForce$3: function (a0/* Vector3 */, a1/* ForceMode */) { return CS.Call(4, 56, 12, false, this, a0, a1); },
        AddRelativeTorque: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 56, 13, false, this, a0, a1, a2); },
        AddRelativeTorque$1: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* ForceMode */) { return CS.Call(4, 56, 14, false, this, a0, a1, a2, a3); },
        AddRelativeTorque$2: function (a0/* Vector3 */) { return CS.Call(4, 56, 15, false, this, a0); },
        AddRelativeTorque$3: function (a0/* Vector3 */, a1/* ForceMode */) { return CS.Call(4, 56, 16, false, this, a0, a1); },
        AddTorque: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 56, 17, false, this, a0, a1, a2); },
        AddTorque$1: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* ForceMode */) { return CS.Call(4, 56, 18, false, this, a0, a1, a2, a3); },
        AddTorque$2: function (a0/* Vector3 */) { return CS.Call(4, 56, 19, false, this, a0); },
        AddTorque$3: function (a0/* Vector3 */, a1/* ForceMode */) { return CS.Call(4, 56, 20, false, this, a0, a1); },
        ClosestPointOnBounds: function (a0/* Vector3 */) { return CS.Call(4, 56, 21, false, this, a0); },
        GetPointVelocity: function (a0/* Vector3 */) { return CS.Call(4, 56, 22, false, this, a0); },
        GetRelativePointVelocity: function (a0/* Vector3 */) { return CS.Call(4, 56, 23, false, this, a0); },
        IsSleeping: function () { return CS.Call(4, 56, 24, false, this); },
        MovePosition: function (a0/* Vector3 */) { return CS.Call(4, 56, 25, false, this, a0); },
        MoveRotation: function (a0/* Quaternion */) { return CS.Call(4, 56, 26, false, this, a0); },
        SetDensity: function (a0/* Single */) { return CS.Call(4, 56, 27, false, this, a0); },
        Sleep: function () { return CS.Call(4, 56, 28, false, this); },
        SweepTest: function (a0/* Vector3 */, a1/* RaycastHit& */) { return CS.Call(4, 56, 29, false, this, a0, a1); },
        SweepTest$1: function (a0/* Vector3 */, a1/* RaycastHit& */, a2/* Single */) { return CS.Call(4, 56, 30, false, this, a0, a1, a2); },
        SweepTestAll: function (a0/* Vector3 */) { return CS.Call(4, 56, 31, false, this, a0); },
        SweepTestAll$1: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 56, 32, false, this, a0, a1); },
        WakeUp: function () { return CS.Call(4, 56, 33, false, this); },
    });
    if ($hc < 58) { return; }
     
    Bridge.define("UnityEngine.Renderer", {
        inherits: [UnityEngine.Component],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 57, 0, true, this);
        },
        getbounds: function () { return CS.Call(2, 57, 0, false, this); },
        setbounds: function (v) { return CS.Call(3, 57, 0, false, this, v); },
        getcastShadows: function () { return CS.Call(2, 57, 1, false, this); },
        setcastShadows: function (v) { return CS.Call(3, 57, 1, false, this, v); },
        getenabled: function () { return CS.Call(2, 57, 2, false, this); },
        setenabled: function (v) { return CS.Call(3, 57, 2, false, this, v); },
        getisPartOfStaticBatch: function () { return CS.Call(2, 57, 3, false, this); },
        setisPartOfStaticBatch: function (v) { return CS.Call(3, 57, 3, false, this, v); },
        getisVisible: function () { return CS.Call(2, 57, 4, false, this); },
        setisVisible: function (v) { return CS.Call(3, 57, 4, false, this, v); },
        getlightmapIndex: function () { return CS.Call(2, 57, 5, false, this); },
        setlightmapIndex: function (v) { return CS.Call(3, 57, 5, false, this, v); },
        getlightmapTilingOffset: function () { return CS.Call(2, 57, 6, false, this); },
        setlightmapTilingOffset: function (v) { return CS.Call(3, 57, 6, false, this, v); },
        getlightProbeAnchor: function () { return CS.Call(2, 57, 7, false, this); },
        setlightProbeAnchor: function (v) { return CS.Call(3, 57, 7, false, this, v); },
        getlocalToWorldMatrix: function () { return CS.Call(2, 57, 8, false, this); },
        setlocalToWorldMatrix: function (v) { return CS.Call(3, 57, 8, false, this, v); },
        getmaterial: function () { return CS.Call(2, 57, 9, false, this); },
        setmaterial: function (v) { return CS.Call(3, 57, 9, false, this, v); },
        getmaterials: function () { return CS.Call(2, 57, 10, false, this); },
        setmaterials: function (v) { return CS.Call(3, 57, 10, false, this, v); },
        getreceiveShadows: function () { return CS.Call(2, 57, 11, false, this); },
        setreceiveShadows: function (v) { return CS.Call(3, 57, 11, false, this, v); },
        getsharedMaterial: function () { return CS.Call(2, 57, 12, false, this); },
        setsharedMaterial: function (v) { return CS.Call(3, 57, 12, false, this, v); },
        getsharedMaterials: function () { return CS.Call(2, 57, 13, false, this); },
        setsharedMaterials: function (v) { return CS.Call(3, 57, 13, false, this, v); },
        getsortingLayerID: function () { return CS.Call(2, 57, 14, false, this); },
        setsortingLayerID: function (v) { return CS.Call(3, 57, 14, false, this, v); },
        getsortingLayerName: function () { return CS.Call(2, 57, 15, false, this); },
        setsortingLayerName: function (v) { return CS.Call(3, 57, 15, false, this, v); },
        getsortingOrder: function () { return CS.Call(2, 57, 16, false, this); },
        setsortingOrder: function (v) { return CS.Call(3, 57, 16, false, this, v); },
        getuseLightProbes: function () { return CS.Call(2, 57, 17, false, this); },
        setuseLightProbes: function (v) { return CS.Call(3, 57, 17, false, this, v); },
        getworldToLocalMatrix: function () { return CS.Call(2, 57, 18, false, this); },
        setworldToLocalMatrix: function (v) { return CS.Call(3, 57, 18, false, this, v); },
        GetPropertyBlock: function (a0/* MaterialPropertyBlock */) { return CS.Call(4, 57, 0, false, this, a0); },
        Render: function (a0/* Int32 */) { return CS.Call(4, 57, 1, false, this, a0); },
        SetPropertyBlock: function (a0/* MaterialPropertyBlock */) { return CS.Call(4, 57, 2, false, this, a0); },
    });
    if ($hc < 59) { return; }
     
    Bridge.define("UnityEngine.ParticleSystem", {
        inherits: [UnityEngine.Component],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 58, 0, true, this);
        },
        getduration: function () { return CS.Call(2, 58, 0, false, this); },
        setduration: function (v) { return CS.Call(3, 58, 0, false, this, v); },
        getemissionRate: function () { return CS.Call(2, 58, 1, false, this); },
        setemissionRate: function (v) { return CS.Call(3, 58, 1, false, this, v); },
        getenableEmission: function () { return CS.Call(2, 58, 2, false, this); },
        setenableEmission: function (v) { return CS.Call(3, 58, 2, false, this, v); },
        getgravityModifier: function () { return CS.Call(2, 58, 3, false, this); },
        setgravityModifier: function (v) { return CS.Call(3, 58, 3, false, this, v); },
        getisPaused: function () { return CS.Call(2, 58, 4, false, this); },
        setisPaused: function (v) { return CS.Call(3, 58, 4, false, this, v); },
        getisPlaying: function () { return CS.Call(2, 58, 5, false, this); },
        setisPlaying: function (v) { return CS.Call(3, 58, 5, false, this, v); },
        getisStopped: function () { return CS.Call(2, 58, 6, false, this); },
        setisStopped: function (v) { return CS.Call(3, 58, 6, false, this, v); },
        getloop: function () { return CS.Call(2, 58, 7, false, this); },
        setloop: function (v) { return CS.Call(3, 58, 7, false, this, v); },
        getmaxParticles: function () { return CS.Call(2, 58, 8, false, this); },
        setmaxParticles: function (v) { return CS.Call(3, 58, 8, false, this, v); },
        getparticleCount: function () { return CS.Call(2, 58, 9, false, this); },
        setparticleCount: function (v) { return CS.Call(3, 58, 9, false, this, v); },
        getplaybackSpeed: function () { return CS.Call(2, 58, 10, false, this); },
        setplaybackSpeed: function (v) { return CS.Call(3, 58, 10, false, this, v); },
        getplayOnAwake: function () { return CS.Call(2, 58, 11, false, this); },
        setplayOnAwake: function (v) { return CS.Call(3, 58, 11, false, this, v); },
        getrandomSeed: function () { return CS.Call(2, 58, 12, false, this); },
        setrandomSeed: function (v) { return CS.Call(3, 58, 12, false, this, v); },
        getsafeCollisionEventSize: function () { return CS.Call(2, 58, 13, false, this); },
        setsafeCollisionEventSize: function (v) { return CS.Call(3, 58, 13, false, this, v); },
        getsimulationSpace: function () { return CS.Call(2, 58, 14, false, this); },
        setsimulationSpace: function (v) { return CS.Call(3, 58, 14, false, this, v); },
        getstartColor: function () { return CS.Call(2, 58, 15, false, this); },
        setstartColor: function (v) { return CS.Call(3, 58, 15, false, this, v); },
        getstartDelay: function () { return CS.Call(2, 58, 16, false, this); },
        setstartDelay: function (v) { return CS.Call(3, 58, 16, false, this, v); },
        getstartLifetime: function () { return CS.Call(2, 58, 17, false, this); },
        setstartLifetime: function (v) { return CS.Call(3, 58, 17, false, this, v); },
        getstartRotation: function () { return CS.Call(2, 58, 18, false, this); },
        setstartRotation: function (v) { return CS.Call(3, 58, 18, false, this, v); },
        getstartSize: function () { return CS.Call(2, 58, 19, false, this); },
        setstartSize: function (v) { return CS.Call(3, 58, 19, false, this, v); },
        getstartSpeed: function () { return CS.Call(2, 58, 20, false, this); },
        setstartSpeed: function (v) { return CS.Call(3, 58, 20, false, this, v); },
        gettime: function () { return CS.Call(2, 58, 21, false, this); },
        settime: function (v) { return CS.Call(3, 58, 21, false, this, v); },
        Clear: function () { return CS.Call(4, 58, 0, false, this); },
        Clear$1: function (a0/* Boolean */) { return CS.Call(4, 58, 1, false, this, a0); },
        Emit: function (a0/* Int32 */) { return CS.Call(4, 58, 2, false, this, a0); },
        Emit$1: function (a0/* Particle */) { return CS.Call(4, 58, 3, false, this, a0); },
        Emit$2: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */, a3/* Single */, a4/* Color32 */) { return CS.Call(4, 58, 4, false, this, a0, a1, a2, a3, a4); },
        GetCollisionEvents: function (a0/* GameObject */, a1/* CollisionEvent[] */) { return CS.Call(4, 58, 5, false, this, a0, a1); },
        GetParticles: function (a0/* Particle[] */) { return CS.Call(4, 58, 6, false, this, a0); },
        IsAlive: function () { return CS.Call(4, 58, 7, false, this); },
        IsAlive$1: function (a0/* Boolean */) { return CS.Call(4, 58, 8, false, this, a0); },
        Pause: function () { return CS.Call(4, 58, 9, false, this); },
        Pause$1: function (a0/* Boolean */) { return CS.Call(4, 58, 10, false, this, a0); },
        Play: function () { return CS.Call(4, 58, 11, false, this); },
        Play$1: function (a0/* Boolean */) { return CS.Call(4, 58, 12, false, this, a0); },
        SetParticles: function (a0/* Particle[] */, a1/* Int32 */) { return CS.Call(4, 58, 13, false, this, a0, a1); },
        Simulate: function (a0/* Single */) { return CS.Call(4, 58, 14, false, this, a0); },
        Simulate$1: function (a0/* Single */, a1/* Boolean */) { return CS.Call(4, 58, 15, false, this, a0, a1); },
        Simulate$2: function (a0/* Single */, a1/* Boolean */, a2/* Boolean */) { return CS.Call(4, 58, 16, false, this, a0, a1, a2); },
        Stop: function () { return CS.Call(4, 58, 17, false, this); },
        Stop$1: function (a0/* Boolean */) { return CS.Call(4, 58, 18, false, this, a0); },
    });
    if ($hc < 60) { return; }
     
    Bridge.define("UnityEngine.Rigidbody2D", {
        inherits: [UnityEngine.Component],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 59, 0, true, this);
        },
        getangularDrag: function () { return CS.Call(2, 59, 0, false, this); },
        setangularDrag: function (v) { return CS.Call(3, 59, 0, false, this, v); },
        getangularVelocity: function () { return CS.Call(2, 59, 1, false, this); },
        setangularVelocity: function (v) { return CS.Call(3, 59, 1, false, this, v); },
        getcenterOfMass: function () { return CS.Call(2, 59, 2, false, this); },
        setcenterOfMass: function (v) { return CS.Call(3, 59, 2, false, this, v); },
        getcollisionDetectionMode: function () { return CS.Call(2, 59, 3, false, this); },
        setcollisionDetectionMode: function (v) { return CS.Call(3, 59, 3, false, this, v); },
        getdrag: function () { return CS.Call(2, 59, 4, false, this); },
        setdrag: function (v) { return CS.Call(3, 59, 4, false, this, v); },
        getfixedAngle: function () { return CS.Call(2, 59, 5, false, this); },
        setfixedAngle: function (v) { return CS.Call(3, 59, 5, false, this, v); },
        getgravityScale: function () { return CS.Call(2, 59, 6, false, this); },
        setgravityScale: function (v) { return CS.Call(3, 59, 6, false, this, v); },
        getinertia: function () { return CS.Call(2, 59, 7, false, this); },
        setinertia: function (v) { return CS.Call(3, 59, 7, false, this, v); },
        getinterpolation: function () { return CS.Call(2, 59, 8, false, this); },
        setinterpolation: function (v) { return CS.Call(3, 59, 8, false, this, v); },
        getisKinematic: function () { return CS.Call(2, 59, 9, false, this); },
        setisKinematic: function (v) { return CS.Call(3, 59, 9, false, this, v); },
        getmass: function () { return CS.Call(2, 59, 10, false, this); },
        setmass: function (v) { return CS.Call(3, 59, 10, false, this, v); },
        getposition: function () { return CS.Call(2, 59, 11, false, this); },
        setposition: function (v) { return CS.Call(3, 59, 11, false, this, v); },
        getrotation: function () { return CS.Call(2, 59, 12, false, this); },
        setrotation: function (v) { return CS.Call(3, 59, 12, false, this, v); },
        getsimulated: function () { return CS.Call(2, 59, 13, false, this); },
        setsimulated: function (v) { return CS.Call(3, 59, 13, false, this, v); },
        getsleepMode: function () { return CS.Call(2, 59, 14, false, this); },
        setsleepMode: function (v) { return CS.Call(3, 59, 14, false, this, v); },
        getvelocity: function () { return CS.Call(2, 59, 15, false, this); },
        setvelocity: function (v) { return CS.Call(3, 59, 15, false, this, v); },
        getworldCenterOfMass: function () { return CS.Call(2, 59, 16, false, this); },
        setworldCenterOfMass: function (v) { return CS.Call(3, 59, 16, false, this, v); },
        AddForce: function (a0/* Vector2 */) { return CS.Call(4, 59, 0, false, this, a0); },
        AddForce$1: function (a0/* Vector2 */, a1/* ForceMode2D */) { return CS.Call(4, 59, 1, false, this, a0, a1); },
        AddForceAtPosition: function (a0/* Vector2 */, a1/* Vector2 */) { return CS.Call(4, 59, 2, false, this, a0, a1); },
        AddForceAtPosition$1: function (a0/* Vector2 */, a1/* Vector2 */, a2/* ForceMode2D */) { return CS.Call(4, 59, 3, false, this, a0, a1, a2); },
        AddRelativeForce: function (a0/* Vector2 */) { return CS.Call(4, 59, 4, false, this, a0); },
        AddRelativeForce$1: function (a0/* Vector2 */, a1/* ForceMode2D */) { return CS.Call(4, 59, 5, false, this, a0, a1); },
        AddTorque: function (a0/* Single */) { return CS.Call(4, 59, 6, false, this, a0); },
        AddTorque$1: function (a0/* Single */, a1/* ForceMode2D */) { return CS.Call(4, 59, 7, false, this, a0, a1); },
        GetPoint: function (a0/* Vector2 */) { return CS.Call(4, 59, 8, false, this, a0); },
        GetPointVelocity: function (a0/* Vector2 */) { return CS.Call(4, 59, 9, false, this, a0); },
        GetRelativePoint: function (a0/* Vector2 */) { return CS.Call(4, 59, 10, false, this, a0); },
        GetRelativePointVelocity: function (a0/* Vector2 */) { return CS.Call(4, 59, 11, false, this, a0); },
        GetRelativeVector: function (a0/* Vector2 */) { return CS.Call(4, 59, 12, false, this, a0); },
        GetVector: function (a0/* Vector2 */) { return CS.Call(4, 59, 13, false, this, a0); },
        IsAwake: function () { return CS.Call(4, 59, 14, false, this); },
        IsSleeping: function () { return CS.Call(4, 59, 15, false, this); },
        MovePosition: function (a0/* Vector2 */) { return CS.Call(4, 59, 16, false, this, a0); },
        MoveRotation: function (a0/* Single */) { return CS.Call(4, 59, 17, false, this, a0); },
        Sleep: function () { return CS.Call(4, 59, 18, false, this); },
        WakeUp: function () { return CS.Call(4, 59, 19, false, this); },
    });
    if ($hc < 61) { return; }
     
    Bridge.define("UnityEngine.Events.UnityEvent", {
        inherits: [UnityEngine.Events.UnityEventBase, UnityEngine.ISerializationCallbackReceiver],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 60, 0, true, this);
        },
        AddListener: function (a0/* UnityAction */) { return CS.Call(4, 60, 0, false, this, a0); },
        Invoke: function () { return CS.Call(4, 60, 1, false, this); },
        RemoveListener: function (a0/* UnityAction */) { return CS.Call(4, 60, 2, false, this, a0); },
    });
    if ($hc < 62) { return; }
     
    Bridge.define("UnityEngine.Collider", {
        inherits: [UnityEngine.Component],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 61, 0, true, this);
        },
        getattachedRigidbody: function () { return CS.Call(2, 61, 0, false, this); },
        setattachedRigidbody: function (v) { return CS.Call(3, 61, 0, false, this, v); },
        getbounds: function () { return CS.Call(2, 61, 1, false, this); },
        setbounds: function (v) { return CS.Call(3, 61, 1, false, this, v); },
        getenabled: function () { return CS.Call(2, 61, 2, false, this); },
        setenabled: function (v) { return CS.Call(3, 61, 2, false, this, v); },
        getisTrigger: function () { return CS.Call(2, 61, 3, false, this); },
        setisTrigger: function (v) { return CS.Call(3, 61, 3, false, this, v); },
        getmaterial: function () { return CS.Call(2, 61, 4, false, this); },
        setmaterial: function (v) { return CS.Call(3, 61, 4, false, this, v); },
        getsharedMaterial: function () { return CS.Call(2, 61, 5, false, this); },
        setsharedMaterial: function (v) { return CS.Call(3, 61, 5, false, this, v); },
        ClosestPointOnBounds: function (a0/* Vector3 */) { return CS.Call(4, 61, 0, false, this, a0); },
        Raycast: function (a0/* Ray */, a1/* RaycastHit& */, a2/* Single */) { return CS.Call(4, 61, 1, false, this, a0, a1, a2); },
    });
    if ($hc < 63) { return; }
     
    Bridge.define("UnityEngine.Transform", {
        inherits: [UnityEngine.Component, System.Collections.IEnumerable],
        statics: {
        },
        getchildCount: function () { return CS.Call(2, 62, 0, false, this); },
        setchildCount: function (v) { return CS.Call(3, 62, 0, false, this, v); },
        geteulerAngles: function () { return CS.Call(2, 62, 1, false, this); },
        seteulerAngles: function (v) { return CS.Call(3, 62, 1, false, this, v); },
        getforward: function () { return CS.Call(2, 62, 2, false, this); },
        setforward: function (v) { return CS.Call(3, 62, 2, false, this, v); },
        gethasChanged: function () { return CS.Call(2, 62, 3, false, this); },
        sethasChanged: function (v) { return CS.Call(3, 62, 3, false, this, v); },
        getlocalEulerAngles: function () { return CS.Call(2, 62, 4, false, this); },
        setlocalEulerAngles: function (v) { return CS.Call(3, 62, 4, false, this, v); },
        getlocalPosition: function () { return CS.Call(2, 62, 5, false, this); },
        setlocalPosition: function (v) { return CS.Call(3, 62, 5, false, this, v); },
        getlocalRotation: function () { return CS.Call(2, 62, 6, false, this); },
        setlocalRotation: function (v) { return CS.Call(3, 62, 6, false, this, v); },
        getlocalScale: function () { return CS.Call(2, 62, 7, false, this); },
        setlocalScale: function (v) { return CS.Call(3, 62, 7, false, this, v); },
        getlocalToWorldMatrix: function () { return CS.Call(2, 62, 8, false, this); },
        setlocalToWorldMatrix: function (v) { return CS.Call(3, 62, 8, false, this, v); },
        getlossyScale: function () { return CS.Call(2, 62, 9, false, this); },
        setlossyScale: function (v) { return CS.Call(3, 62, 9, false, this, v); },
        getparent: function () { return CS.Call(2, 62, 10, false, this); },
        setparent: function (v) { return CS.Call(3, 62, 10, false, this, v); },
        getposition: function () { return CS.Call(2, 62, 11, false, this); },
        setposition: function (v) { return CS.Call(3, 62, 11, false, this, v); },
        getright: function () { return CS.Call(2, 62, 12, false, this); },
        setright: function (v) { return CS.Call(3, 62, 12, false, this, v); },
        getroot: function () { return CS.Call(2, 62, 13, false, this); },
        setroot: function (v) { return CS.Call(3, 62, 13, false, this, v); },
        getrotation: function () { return CS.Call(2, 62, 14, false, this); },
        setrotation: function (v) { return CS.Call(3, 62, 14, false, this, v); },
        getup: function () { return CS.Call(2, 62, 15, false, this); },
        setup: function (v) { return CS.Call(3, 62, 15, false, this, v); },
        getworldToLocalMatrix: function () { return CS.Call(2, 62, 16, false, this); },
        setworldToLocalMatrix: function (v) { return CS.Call(3, 62, 16, false, this, v); },
        DetachChildren: function () { return CS.Call(4, 62, 0, false, this); },
        Find: function (a0/* String */) { return CS.Call(4, 62, 1, false, this, a0); },
        FindChild: function (a0/* String */) { return CS.Call(4, 62, 2, false, this, a0); },
        GetChild: function (a0/* Int32 */) { return CS.Call(4, 62, 3, false, this, a0); },
        GetEnumerator: function () { return CS.Call(4, 62, 4, false, this); },
        GetSiblingIndex: function () { return CS.Call(4, 62, 5, false, this); },
        InverseTransformDirection: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 6, false, this, a0, a1, a2); },
        InverseTransformDirection$1: function (a0/* Vector3 */) { return CS.Call(4, 62, 7, false, this, a0); },
        InverseTransformPoint: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 8, false, this, a0, a1, a2); },
        InverseTransformPoint$1: function (a0/* Vector3 */) { return CS.Call(4, 62, 9, false, this, a0); },
        InverseTransformVector: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 10, false, this, a0, a1, a2); },
        InverseTransformVector$1: function (a0/* Vector3 */) { return CS.Call(4, 62, 11, false, this, a0); },
        IsChildOf: function (a0/* Transform */) { return CS.Call(4, 62, 12, false, this, a0); },
        LookAt: function (a0/* Transform */) { return CS.Call(4, 62, 13, false, this, a0); },
        LookAt$1: function (a0/* Transform */, a1/* Vector3 */) { return CS.Call(4, 62, 14, false, this, a0, a1); },
        LookAt$2: function (a0/* Vector3 */) { return CS.Call(4, 62, 15, false, this, a0); },
        LookAt$3: function (a0/* Vector3 */, a1/* Vector3 */) { return CS.Call(4, 62, 16, false, this, a0, a1); },
        Rotate: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 17, false, this, a0, a1, a2); },
        Rotate$1: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Space */) { return CS.Call(4, 62, 18, false, this, a0, a1, a2, a3); },
        Rotate$2: function (a0/* Vector3 */) { return CS.Call(4, 62, 19, false, this, a0); },
        Rotate$3: function (a0/* Vector3 */, a1/* Single */) { return CS.Call(4, 62, 20, false, this, a0, a1); },
        Rotate$4: function (a0/* Vector3 */, a1/* Single */, a2/* Space */) { return CS.Call(4, 62, 21, false, this, a0, a1, a2); },
        Rotate$5: function (a0/* Vector3 */, a1/* Space */) { return CS.Call(4, 62, 22, false, this, a0, a1); },
        RotateAround: function (a0/* Vector3 */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 62, 23, false, this, a0, a1, a2); },
        SetAsFirstSibling: function () { return CS.Call(4, 62, 24, false, this); },
        SetAsLastSibling: function () { return CS.Call(4, 62, 25, false, this); },
        SetParent: function (a0/* Transform */) { return CS.Call(4, 62, 26, false, this, a0); },
        SetParent$1: function (a0/* Transform */, a1/* Boolean */) { return CS.Call(4, 62, 27, false, this, a0, a1); },
        SetSiblingIndex: function (a0/* Int32 */) { return CS.Call(4, 62, 28, false, this, a0); },
        TransformDirection: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 29, false, this, a0, a1, a2); },
        TransformDirection$1: function (a0/* Vector3 */) { return CS.Call(4, 62, 30, false, this, a0); },
        TransformPoint: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 31, false, this, a0, a1, a2); },
        TransformPoint$1: function (a0/* Vector3 */) { return CS.Call(4, 62, 32, false, this, a0); },
        TransformVector: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 33, false, this, a0, a1, a2); },
        TransformVector$1: function (a0/* Vector3 */) { return CS.Call(4, 62, 34, false, this, a0); },
        Translate: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 62, 35, false, this, a0, a1, a2); },
        Translate$1: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Space */) { return CS.Call(4, 62, 36, false, this, a0, a1, a2, a3); },
        Translate$2: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Transform */) { return CS.Call(4, 62, 37, false, this, a0, a1, a2, a3); },
        Translate$3: function (a0/* Vector3 */) { return CS.Call(4, 62, 38, false, this, a0); },
        Translate$4: function (a0/* Vector3 */, a1/* Space */) { return CS.Call(4, 62, 39, false, this, a0, a1); },
        Translate$5: function (a0/* Vector3 */, a1/* Transform */) { return CS.Call(4, 62, 40, false, this, a0, a1); },
    });
    if ($hc < 64) { return; }
     
    Bridge.define("UnityEngine.LineRenderer", {
        inherits: [UnityEngine.Renderer],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 63, 0, true, this);
        },
        getuseWorldSpace: function () { return CS.Call(2, 63, 0, false, this); },
        setuseWorldSpace: function (v) { return CS.Call(3, 63, 0, false, this, v); },
        SetColors: function (a0/* Color */, a1/* Color */) { return CS.Call(4, 63, 0, false, this, a0, a1); },
        SetPosition: function (a0/* Int32 */, a1/* Vector3 */) { return CS.Call(4, 63, 1, false, this, a0, a1); },
        SetVertexCount: function (a0/* Int32 */) { return CS.Call(4, 63, 2, false, this, a0); },
        SetWidth: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 63, 3, false, this, a0, a1); },
    });
    if ($hc < 65) { return; }
     
    Bridge.define("UnityEngine.Collider2D", {
        inherits: [UnityEngine.Behaviour],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 64, 0, true, this);
        },
        getattachedRigidbody: function () { return CS.Call(2, 64, 0, false, this); },
        setattachedRigidbody: function (v) { return CS.Call(3, 64, 0, false, this, v); },
        getbounds: function () { return CS.Call(2, 64, 1, false, this); },
        setbounds: function (v) { return CS.Call(3, 64, 1, false, this, v); },
        getisTrigger: function () { return CS.Call(2, 64, 2, false, this); },
        setisTrigger: function (v) { return CS.Call(3, 64, 2, false, this, v); },
        getshapeCount: function () { return CS.Call(2, 64, 3, false, this); },
        setshapeCount: function (v) { return CS.Call(3, 64, 3, false, this, v); },
        getsharedMaterial: function () { return CS.Call(2, 64, 4, false, this); },
        setsharedMaterial: function (v) { return CS.Call(3, 64, 4, false, this, v); },
        OverlapPoint: function (a0/* Vector2 */) { return CS.Call(4, 64, 0, false, this, a0); },
    });
    if ($hc < 66) { return; }
     
    Bridge.define("UnityEngine.SphereCollider", {
        inherits: [UnityEngine.Collider],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 65, 0, true, this);
        },
        getcenter: function () { return CS.Call(2, 65, 0, false, this); },
        setcenter: function (v) { return CS.Call(3, 65, 0, false, this, v); },
        getradius: function () { return CS.Call(2, 65, 1, false, this); },
        setradius: function (v) { return CS.Call(3, 65, 1, false, this, v); },
    });
    if ($hc < 67) { return; }
     
    Bridge.define("UnityEngine.Light", {
        inherits: [UnityEngine.Behaviour],
        statics: {
            GetLights: function (a0/* LightType */, a1/* Int32 */) { return CS.Call(4, 66, 0, true, a0, a1); },
        },
        ctor: function () {
            CS.Call(5, 66, 0, true, this);
        },
        getalreadyLightmapped: function () { return CS.Call(2, 66, 0, false, this); },
        setalreadyLightmapped: function (v) { return CS.Call(3, 66, 0, false, this, v); },
        getcolor: function () { return CS.Call(2, 66, 1, false, this); },
        setcolor: function (v) { return CS.Call(3, 66, 1, false, this, v); },
        getcookie: function () { return CS.Call(2, 66, 2, false, this); },
        setcookie: function (v) { return CS.Call(3, 66, 2, false, this, v); },
        getcookieSize: function () { return CS.Call(2, 66, 3, false, this); },
        setcookieSize: function (v) { return CS.Call(3, 66, 3, false, this, v); },
        getcullingMask: function () { return CS.Call(2, 66, 4, false, this); },
        setcullingMask: function (v) { return CS.Call(3, 66, 4, false, this, v); },
        getflare: function () { return CS.Call(2, 66, 5, false, this); },
        setflare: function (v) { return CS.Call(3, 66, 5, false, this, v); },
        getintensity: function () { return CS.Call(2, 66, 6, false, this); },
        setintensity: function (v) { return CS.Call(3, 66, 6, false, this, v); },
        getrange: function () { return CS.Call(2, 66, 7, false, this); },
        setrange: function (v) { return CS.Call(3, 66, 7, false, this, v); },
        getrenderMode: function () { return CS.Call(2, 66, 8, false, this); },
        setrenderMode: function (v) { return CS.Call(3, 66, 8, false, this, v); },
        getshadowBias: function () { return CS.Call(2, 66, 9, false, this); },
        setshadowBias: function (v) { return CS.Call(3, 66, 9, false, this, v); },
        getshadows: function () { return CS.Call(2, 66, 10, false, this); },
        setshadows: function (v) { return CS.Call(3, 66, 10, false, this, v); },
        getshadowSoftness: function () { return CS.Call(2, 66, 11, false, this); },
        setshadowSoftness: function (v) { return CS.Call(3, 66, 11, false, this, v); },
        getshadowSoftnessFade: function () { return CS.Call(2, 66, 12, false, this); },
        setshadowSoftnessFade: function (v) { return CS.Call(3, 66, 12, false, this, v); },
        getshadowStrength: function () { return CS.Call(2, 66, 13, false, this); },
        setshadowStrength: function (v) { return CS.Call(3, 66, 13, false, this, v); },
        getspotAngle: function () { return CS.Call(2, 66, 14, false, this); },
        setspotAngle: function (v) { return CS.Call(3, 66, 14, false, this, v); },
        gettype: function () { return CS.Call(2, 66, 15, false, this); },
        settype: function (v) { return CS.Call(3, 66, 15, false, this, v); },
    });
    if ($hc < 68) { return; }
     
    Bridge.define("UnityEngine.AudioSource", {
        inherits: [UnityEngine.Behaviour],
        statics: {
            PlayClipAtPoint: function (a0/* AudioClip */, a1/* Vector3 */) { return CS.Call(4, 67, 12, true, a0, a1); },
            PlayClipAtPoint$1: function (a0/* AudioClip */, a1/* Vector3 */, a2/* Single */) { return CS.Call(4, 67, 13, true, a0, a1, a2); },
        },
        ctor: function () {
            CS.Call(5, 67, 0, true, this);
        },
        getbypassEffects: function () { return CS.Call(2, 67, 0, false, this); },
        setbypassEffects: function (v) { return CS.Call(3, 67, 0, false, this, v); },
        getbypassListenerEffects: function () { return CS.Call(2, 67, 1, false, this); },
        setbypassListenerEffects: function (v) { return CS.Call(3, 67, 1, false, this, v); },
        getbypassReverbZones: function () { return CS.Call(2, 67, 2, false, this); },
        setbypassReverbZones: function (v) { return CS.Call(3, 67, 2, false, this, v); },
        getclip: function () { return CS.Call(2, 67, 3, false, this); },
        setclip: function (v) { return CS.Call(3, 67, 3, false, this, v); },
        getdopplerLevel: function () { return CS.Call(2, 67, 4, false, this); },
        setdopplerLevel: function (v) { return CS.Call(3, 67, 4, false, this, v); },
        getignoreListenerPause: function () { return CS.Call(2, 67, 5, false, this); },
        setignoreListenerPause: function (v) { return CS.Call(3, 67, 5, false, this, v); },
        getignoreListenerVolume: function () { return CS.Call(2, 67, 6, false, this); },
        setignoreListenerVolume: function (v) { return CS.Call(3, 67, 6, false, this, v); },
        getisPlaying: function () { return CS.Call(2, 67, 7, false, this); },
        setisPlaying: function (v) { return CS.Call(3, 67, 7, false, this, v); },
        getloop: function () { return CS.Call(2, 67, 8, false, this); },
        setloop: function (v) { return CS.Call(3, 67, 8, false, this, v); },
        getmaxDistance: function () { return CS.Call(2, 67, 9, false, this); },
        setmaxDistance: function (v) { return CS.Call(3, 67, 9, false, this, v); },
        getminDistance: function () { return CS.Call(2, 67, 10, false, this); },
        setminDistance: function (v) { return CS.Call(3, 67, 10, false, this, v); },
        getmute: function () { return CS.Call(2, 67, 11, false, this); },
        setmute: function (v) { return CS.Call(3, 67, 11, false, this, v); },
        getpan: function () { return CS.Call(2, 67, 12, false, this); },
        setpan: function (v) { return CS.Call(3, 67, 12, false, this, v); },
        getpanLevel: function () { return CS.Call(2, 67, 13, false, this); },
        setpanLevel: function (v) { return CS.Call(3, 67, 13, false, this, v); },
        getpitch: function () { return CS.Call(2, 67, 14, false, this); },
        setpitch: function (v) { return CS.Call(3, 67, 14, false, this, v); },
        getplayOnAwake: function () { return CS.Call(2, 67, 15, false, this); },
        setplayOnAwake: function (v) { return CS.Call(3, 67, 15, false, this, v); },
        getpriority: function () { return CS.Call(2, 67, 16, false, this); },
        setpriority: function (v) { return CS.Call(3, 67, 16, false, this, v); },
        getrolloffMode: function () { return CS.Call(2, 67, 17, false, this); },
        setrolloffMode: function (v) { return CS.Call(3, 67, 17, false, this, v); },
        getspread: function () { return CS.Call(2, 67, 18, false, this); },
        setspread: function (v) { return CS.Call(3, 67, 18, false, this, v); },
        gettime: function () { return CS.Call(2, 67, 19, false, this); },
        settime: function (v) { return CS.Call(3, 67, 19, false, this, v); },
        gettimeSamples: function () { return CS.Call(2, 67, 20, false, this); },
        settimeSamples: function (v) { return CS.Call(3, 67, 20, false, this, v); },
        getvelocityUpdateMode: function () { return CS.Call(2, 67, 21, false, this); },
        setvelocityUpdateMode: function (v) { return CS.Call(3, 67, 21, false, this, v); },
        getvolume: function () { return CS.Call(2, 67, 22, false, this); },
        setvolume: function (v) { return CS.Call(3, 67, 22, false, this, v); },
        GetOutputData: function (a0/* Single[] */, a1/* Int32 */) { return CS.Call(4, 67, 0, false, this, a0, a1); },
        GetSpectrumData: function (a0/* Single[] */, a1/* Int32 */, a2/* FFTWindow */) { return CS.Call(4, 67, 1, false, this, a0, a1, a2); },
        Pause: function () { return CS.Call(4, 67, 2, false, this); },
        Play: function () { return CS.Call(4, 67, 3, false, this); },
        Play$1: function (a0/* UInt64 */) { return CS.Call(4, 67, 4, false, this, a0); },
        PlayDelayed: function (a0/* Single */) { return CS.Call(4, 67, 5, false, this, a0); },
        PlayOneShot: function (a0/* AudioClip */) { return CS.Call(4, 67, 6, false, this, a0); },
        PlayOneShot$1: function (a0/* AudioClip */, a1/* Single */) { return CS.Call(4, 67, 7, false, this, a0, a1); },
        PlayScheduled: function (a0/* Double */) { return CS.Call(4, 67, 8, false, this, a0); },
        SetScheduledEndTime: function (a0/* Double */) { return CS.Call(4, 67, 9, false, this, a0); },
        SetScheduledStartTime: function (a0/* Double */) { return CS.Call(4, 67, 10, false, this, a0); },
        Stop: function () { return CS.Call(4, 67, 11, false, this); },
    });
    if ($hc < 69) { return; }
     
    Bridge.define("UnityEngine.NavMeshAgent", {
        inherits: [UnityEngine.Behaviour],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 68, 0, true, this);
        },
        getacceleration: function () { return CS.Call(2, 68, 0, false, this); },
        setacceleration: function (v) { return CS.Call(3, 68, 0, false, this, v); },
        getangularSpeed: function () { return CS.Call(2, 68, 1, false, this); },
        setangularSpeed: function (v) { return CS.Call(3, 68, 1, false, this, v); },
        getautoBraking: function () { return CS.Call(2, 68, 2, false, this); },
        setautoBraking: function (v) { return CS.Call(3, 68, 2, false, this, v); },
        getautoRepath: function () { return CS.Call(2, 68, 3, false, this); },
        setautoRepath: function (v) { return CS.Call(3, 68, 3, false, this, v); },
        getautoTraverseOffMeshLink: function () { return CS.Call(2, 68, 4, false, this); },
        setautoTraverseOffMeshLink: function (v) { return CS.Call(3, 68, 4, false, this, v); },
        getavoidancePriority: function () { return CS.Call(2, 68, 5, false, this); },
        setavoidancePriority: function (v) { return CS.Call(3, 68, 5, false, this, v); },
        getbaseOffset: function () { return CS.Call(2, 68, 6, false, this); },
        setbaseOffset: function (v) { return CS.Call(3, 68, 6, false, this, v); },
        getcurrentOffMeshLinkData: function () { return CS.Call(2, 68, 7, false, this); },
        setcurrentOffMeshLinkData: function (v) { return CS.Call(3, 68, 7, false, this, v); },
        getdesiredVelocity: function () { return CS.Call(2, 68, 8, false, this); },
        setdesiredVelocity: function (v) { return CS.Call(3, 68, 8, false, this, v); },
        getdestination: function () { return CS.Call(2, 68, 9, false, this); },
        setdestination: function (v) { return CS.Call(3, 68, 9, false, this, v); },
        gethasPath: function () { return CS.Call(2, 68, 10, false, this); },
        sethasPath: function (v) { return CS.Call(3, 68, 10, false, this, v); },
        getheight: function () { return CS.Call(2, 68, 11, false, this); },
        setheight: function (v) { return CS.Call(3, 68, 11, false, this, v); },
        getisOnOffMeshLink: function () { return CS.Call(2, 68, 12, false, this); },
        setisOnOffMeshLink: function (v) { return CS.Call(3, 68, 12, false, this, v); },
        getisPathStale: function () { return CS.Call(2, 68, 13, false, this); },
        setisPathStale: function (v) { return CS.Call(3, 68, 13, false, this, v); },
        getnextOffMeshLinkData: function () { return CS.Call(2, 68, 14, false, this); },
        setnextOffMeshLinkData: function (v) { return CS.Call(3, 68, 14, false, this, v); },
        getnextPosition: function () { return CS.Call(2, 68, 15, false, this); },
        setnextPosition: function (v) { return CS.Call(3, 68, 15, false, this, v); },
        getobstacleAvoidanceType: function () { return CS.Call(2, 68, 16, false, this); },
        setobstacleAvoidanceType: function (v) { return CS.Call(3, 68, 16, false, this, v); },
        getpath: function () { return CS.Call(2, 68, 17, false, this); },
        setpath: function (v) { return CS.Call(3, 68, 17, false, this, v); },
        getpathEndPosition: function () { return CS.Call(2, 68, 18, false, this); },
        setpathEndPosition: function (v) { return CS.Call(3, 68, 18, false, this, v); },
        getpathPending: function () { return CS.Call(2, 68, 19, false, this); },
        setpathPending: function (v) { return CS.Call(3, 68, 19, false, this, v); },
        getpathStatus: function () { return CS.Call(2, 68, 20, false, this); },
        setpathStatus: function (v) { return CS.Call(3, 68, 20, false, this, v); },
        getradius: function () { return CS.Call(2, 68, 21, false, this); },
        setradius: function (v) { return CS.Call(3, 68, 21, false, this, v); },
        getremainingDistance: function () { return CS.Call(2, 68, 22, false, this); },
        setremainingDistance: function (v) { return CS.Call(3, 68, 22, false, this, v); },
        getspeed: function () { return CS.Call(2, 68, 23, false, this); },
        setspeed: function (v) { return CS.Call(3, 68, 23, false, this, v); },
        getsteeringTarget: function () { return CS.Call(2, 68, 24, false, this); },
        setsteeringTarget: function (v) { return CS.Call(3, 68, 24, false, this, v); },
        getstoppingDistance: function () { return CS.Call(2, 68, 25, false, this); },
        setstoppingDistance: function (v) { return CS.Call(3, 68, 25, false, this, v); },
        getupdatePosition: function () { return CS.Call(2, 68, 26, false, this); },
        setupdatePosition: function (v) { return CS.Call(3, 68, 26, false, this, v); },
        getupdateRotation: function () { return CS.Call(2, 68, 27, false, this); },
        setupdateRotation: function (v) { return CS.Call(3, 68, 27, false, this, v); },
        getvelocity: function () { return CS.Call(2, 68, 28, false, this); },
        setvelocity: function (v) { return CS.Call(3, 68, 28, false, this, v); },
        getwalkableMask: function () { return CS.Call(2, 68, 29, false, this); },
        setwalkableMask: function (v) { return CS.Call(3, 68, 29, false, this, v); },
        ActivateCurrentOffMeshLink: function (a0/* Boolean */) { return CS.Call(4, 68, 0, false, this, a0); },
        CalculatePath: function (a0/* Vector3 */, a1/* NavMeshPath */) { return CS.Call(4, 68, 1, false, this, a0, a1); },
        CompleteOffMeshLink: function () { return CS.Call(4, 68, 2, false, this); },
        FindClosestEdge: function (a0/* NavMeshHit& */) { return CS.Call(4, 68, 3, false, this, a0); },
        GetLayerCost: function (a0/* Int32 */) { return CS.Call(4, 68, 4, false, this, a0); },
        Move: function (a0/* Vector3 */) { return CS.Call(4, 68, 5, false, this, a0); },
        Raycast: function (a0/* Vector3 */, a1/* NavMeshHit& */) { return CS.Call(4, 68, 6, false, this, a0, a1); },
        ResetPath: function () { return CS.Call(4, 68, 7, false, this); },
        Resume: function () { return CS.Call(4, 68, 8, false, this); },
        SamplePathPosition: function (a0/* Int32 */, a1/* Single */, a2/* NavMeshHit& */) { return CS.Call(4, 68, 9, false, this, a0, a1, a2); },
        SetDestination: function (a0/* Vector3 */) { return CS.Call(4, 68, 10, false, this, a0); },
        SetLayerCost: function (a0/* Int32 */, a1/* Single */) { return CS.Call(4, 68, 11, false, this, a0, a1); },
        SetPath: function (a0/* NavMeshPath */) { return CS.Call(4, 68, 12, false, this, a0); },
        Stop: function () { return CS.Call(4, 68, 13, false, this); },
        Stop$1: function (a0/* Boolean */) { return CS.Call(4, 68, 14, false, this, a0); },
        Warp: function (a0/* Vector3 */) { return CS.Call(4, 68, 15, false, this, a0); },
    });
    if ($hc < 70) { return; }
     
    Bridge.define("UnityEngine.GUIElement", {
        inherits: [UnityEngine.Behaviour],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 69, 0, true, this);
        },
        GetScreenRect: function () { return CS.Call(4, 69, 0, false, this); },
        GetScreenRect$1: function (a0/* Camera */) { return CS.Call(4, 69, 1, false, this, a0); },
        HitTest: function (a0/* Vector3 */) { return CS.Call(4, 69, 2, false, this, a0); },
        HitTest$1: function (a0/* Vector3 */, a1/* Camera */) { return CS.Call(4, 69, 3, false, this, a0, a1); },
    });
    if ($hc < 71) { return; }
     
    Bridge.define("UnityEngine.ParticleSystemRenderer", {
        inherits: [UnityEngine.Renderer],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 70, 0, true, this);
        },
        getcameraVelocityScale: function () { return CS.Call(2, 70, 0, false, this); },
        setcameraVelocityScale: function (v) { return CS.Call(3, 70, 0, false, this, v); },
        getlengthScale: function () { return CS.Call(2, 70, 1, false, this); },
        setlengthScale: function (v) { return CS.Call(3, 70, 1, false, this, v); },
        getmaxParticleSize: function () { return CS.Call(2, 70, 2, false, this); },
        setmaxParticleSize: function (v) { return CS.Call(3, 70, 2, false, this, v); },
        getmesh: function () { return CS.Call(2, 70, 3, false, this); },
        setmesh: function (v) { return CS.Call(3, 70, 3, false, this, v); },
        getrenderMode: function () { return CS.Call(2, 70, 4, false, this); },
        setrenderMode: function (v) { return CS.Call(3, 70, 4, false, this, v); },
        getvelocityScale: function () { return CS.Call(2, 70, 5, false, this); },
        setvelocityScale: function (v) { return CS.Call(3, 70, 5, false, this, v); },
    });
    if ($hc < 72) { return; }
     
    Bridge.define("UnityEngine.MeshCollider", {
        inherits: [UnityEngine.Collider],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 71, 0, true, this);
        },
        getconvex: function () { return CS.Call(2, 71, 0, false, this); },
        setconvex: function (v) { return CS.Call(3, 71, 0, false, this, v); },
        getsharedMesh: function () { return CS.Call(2, 71, 1, false, this); },
        setsharedMesh: function (v) { return CS.Call(3, 71, 1, false, this, v); },
        getsmoothSphereCollisions: function () { return CS.Call(2, 71, 2, false, this); },
        setsmoothSphereCollisions: function (v) { return CS.Call(3, 71, 2, false, this, v); },
    });
    if ($hc < 73) { return; }
     
    Bridge.define("UnityEngine.Camera", {
        inherits: [UnityEngine.Behaviour],
        statics: {
            getallCameras: function () { return CS.Call(2, 72, 33, true); },
            setallCameras: function (v) { return CS.Call(3, 72, 33, true, v); },
            getallCamerasCount: function () { return CS.Call(2, 72, 34, true); },
            setallCamerasCount: function (v) { return CS.Call(3, 72, 34, true, v); },
            getcurrent: function () { return CS.Call(2, 72, 35, true); },
            setcurrent: function (v) { return CS.Call(3, 72, 35, true, v); },
            getmain: function () { return CS.Call(2, 72, 36, true); },
            setmain: function (v) { return CS.Call(3, 72, 36, true, v); },
            GetAllCameras: function (a0/* Camera[] */) { return CS.Call(4, 72, 24, true, a0); },
            SetupCurrent: function (a0/* Camera */) { return CS.Call(4, 72, 25, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 72, 0, true, this);
        },
        getactualRenderingPath: function () { return CS.Call(2, 72, 0, false, this); },
        setactualRenderingPath: function (v) { return CS.Call(3, 72, 0, false, this, v); },
        getaspect: function () { return CS.Call(2, 72, 1, false, this); },
        setaspect: function (v) { return CS.Call(3, 72, 1, false, this, v); },
        getbackgroundColor: function () { return CS.Call(2, 72, 2, false, this); },
        setbackgroundColor: function (v) { return CS.Call(3, 72, 2, false, this, v); },
        getcameraToWorldMatrix: function () { return CS.Call(2, 72, 3, false, this); },
        setcameraToWorldMatrix: function (v) { return CS.Call(3, 72, 3, false, this, v); },
        getclearFlags: function () { return CS.Call(2, 72, 4, false, this); },
        setclearFlags: function (v) { return CS.Call(3, 72, 4, false, this, v); },
        getclearStencilAfterLightingPass: function () { return CS.Call(2, 72, 5, false, this); },
        setclearStencilAfterLightingPass: function (v) { return CS.Call(3, 72, 5, false, this, v); },
        getcullingMask: function () { return CS.Call(2, 72, 6, false, this); },
        setcullingMask: function (v) { return CS.Call(3, 72, 6, false, this, v); },
        getdepth: function () { return CS.Call(2, 72, 7, false, this); },
        setdepth: function (v) { return CS.Call(3, 72, 7, false, this, v); },
        getdepthTextureMode: function () { return CS.Call(2, 72, 8, false, this); },
        setdepthTextureMode: function (v) { return CS.Call(3, 72, 8, false, this, v); },
        geteventMask: function () { return CS.Call(2, 72, 9, false, this); },
        seteventMask: function (v) { return CS.Call(3, 72, 9, false, this, v); },
        getfarClipPlane: function () { return CS.Call(2, 72, 10, false, this); },
        setfarClipPlane: function (v) { return CS.Call(3, 72, 10, false, this, v); },
        getfieldOfView: function () { return CS.Call(2, 72, 11, false, this); },
        setfieldOfView: function (v) { return CS.Call(3, 72, 11, false, this, v); },
        gethdr: function () { return CS.Call(2, 72, 12, false, this); },
        sethdr: function (v) { return CS.Call(3, 72, 12, false, this, v); },
        getisOrthoGraphic: function () { return CS.Call(2, 72, 13, false, this); },
        setisOrthoGraphic: function (v) { return CS.Call(3, 72, 13, false, this, v); },
        getlayerCullDistances: function () { return CS.Call(2, 72, 14, false, this); },
        setlayerCullDistances: function (v) { return CS.Call(3, 72, 14, false, this, v); },
        getlayerCullSpherical: function () { return CS.Call(2, 72, 15, false, this); },
        setlayerCullSpherical: function (v) { return CS.Call(3, 72, 15, false, this, v); },
        getnearClipPlane: function () { return CS.Call(2, 72, 16, false, this); },
        setnearClipPlane: function (v) { return CS.Call(3, 72, 16, false, this, v); },
        getorthographic: function () { return CS.Call(2, 72, 17, false, this); },
        setorthographic: function (v) { return CS.Call(3, 72, 17, false, this, v); },
        getorthographicSize: function () { return CS.Call(2, 72, 18, false, this); },
        setorthographicSize: function (v) { return CS.Call(3, 72, 18, false, this, v); },
        getpixelHeight: function () { return CS.Call(2, 72, 19, false, this); },
        setpixelHeight: function (v) { return CS.Call(3, 72, 19, false, this, v); },
        getpixelRect: function () { return CS.Call(2, 72, 20, false, this); },
        setpixelRect: function (v) { return CS.Call(3, 72, 20, false, this, v); },
        getpixelWidth: function () { return CS.Call(2, 72, 21, false, this); },
        setpixelWidth: function (v) { return CS.Call(3, 72, 21, false, this, v); },
        getprojectionMatrix: function () { return CS.Call(2, 72, 22, false, this); },
        setprojectionMatrix: function (v) { return CS.Call(3, 72, 22, false, this, v); },
        getrect: function () { return CS.Call(2, 72, 23, false, this); },
        setrect: function (v) { return CS.Call(3, 72, 23, false, this, v); },
        getrenderingPath: function () { return CS.Call(2, 72, 24, false, this); },
        setrenderingPath: function (v) { return CS.Call(3, 72, 24, false, this, v); },
        getstereoConvergence: function () { return CS.Call(2, 72, 25, false, this); },
        setstereoConvergence: function (v) { return CS.Call(3, 72, 25, false, this, v); },
        getstereoEnabled: function () { return CS.Call(2, 72, 26, false, this); },
        setstereoEnabled: function (v) { return CS.Call(3, 72, 26, false, this, v); },
        getstereoSeparation: function () { return CS.Call(2, 72, 27, false, this); },
        setstereoSeparation: function (v) { return CS.Call(3, 72, 27, false, this, v); },
        gettargetTexture: function () { return CS.Call(2, 72, 28, false, this); },
        settargetTexture: function (v) { return CS.Call(3, 72, 28, false, this, v); },
        gettransparencySortMode: function () { return CS.Call(2, 72, 29, false, this); },
        settransparencySortMode: function (v) { return CS.Call(3, 72, 29, false, this, v); },
        getuseOcclusionCulling: function () { return CS.Call(2, 72, 30, false, this); },
        setuseOcclusionCulling: function (v) { return CS.Call(3, 72, 30, false, this, v); },
        getvelocity: function () { return CS.Call(2, 72, 31, false, this); },
        setvelocity: function (v) { return CS.Call(3, 72, 31, false, this, v); },
        getworldToCameraMatrix: function () { return CS.Call(2, 72, 32, false, this); },
        setworldToCameraMatrix: function (v) { return CS.Call(3, 72, 32, false, this, v); },
        CalculateObliqueMatrix: function (a0/* Vector4 */) { return CS.Call(4, 72, 0, false, this, a0); },
        CopyFrom: function (a0/* Camera */) { return CS.Call(4, 72, 1, false, this, a0); },
        Render: function () { return CS.Call(4, 72, 2, false, this); },
        RenderDontRestore: function () { return CS.Call(4, 72, 3, false, this); },
        RenderToCubemap: function (a0/* Cubemap */) { return CS.Call(4, 72, 4, false, this, a0); },
        RenderToCubemap$1: function (a0/* Cubemap */, a1/* Int32 */) { return CS.Call(4, 72, 5, false, this, a0, a1); },
        RenderToCubemap$2: function (a0/* RenderTexture */) { return CS.Call(4, 72, 6, false, this, a0); },
        RenderToCubemap$3: function (a0/* RenderTexture */, a1/* Int32 */) { return CS.Call(4, 72, 7, false, this, a0, a1); },
        RenderWithShader: function (a0/* Shader */, a1/* String */) { return CS.Call(4, 72, 8, false, this, a0, a1); },
        ResetAspect: function () { return CS.Call(4, 72, 9, false, this); },
        ResetProjectionMatrix: function () { return CS.Call(4, 72, 10, false, this); },
        ResetReplacementShader: function () { return CS.Call(4, 72, 11, false, this); },
        ResetWorldToCameraMatrix: function () { return CS.Call(4, 72, 12, false, this); },
        ScreenPointToRay: function (a0/* Vector3 */) { return CS.Call(4, 72, 13, false, this, a0); },
        ScreenToViewportPoint: function (a0/* Vector3 */) { return CS.Call(4, 72, 14, false, this, a0); },
        ScreenToWorldPoint: function (a0/* Vector3 */) { return CS.Call(4, 72, 15, false, this, a0); },
        SetReplacementShader: function (a0/* Shader */, a1/* String */) { return CS.Call(4, 72, 16, false, this, a0, a1); },
        SetTargetBuffers: function (a0/* RenderBuffer */, a1/* RenderBuffer */) { return CS.Call(4, 72, 17, false, this, a0, a1); },
        SetTargetBuffers$1: function (a0/* RenderBuffer[] */, a1/* RenderBuffer */) { return CS.Call(4, 72, 18, false, this, a0, a1); },
        ViewportPointToRay: function (a0/* Vector3 */) { return CS.Call(4, 72, 19, false, this, a0); },
        ViewportToScreenPoint: function (a0/* Vector3 */) { return CS.Call(4, 72, 20, false, this, a0); },
        ViewportToWorldPoint: function (a0/* Vector3 */) { return CS.Call(4, 72, 21, false, this, a0); },
        WorldToScreenPoint: function (a0/* Vector3 */) { return CS.Call(4, 72, 22, false, this, a0); },
        WorldToViewportPoint: function (a0/* Vector3 */) { return CS.Call(4, 72, 23, false, this, a0); },
    });
    if ($hc < 74) { return; }
     
    Bridge.define("UnityEngine.SpriteRenderer", {
        inherits: [UnityEngine.Renderer],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 73, 0, true, this);
        },
        getcolor: function () { return CS.Call(2, 73, 0, false, this); },
        setcolor: function (v) { return CS.Call(3, 73, 0, false, this, v); },
        getsprite: function () { return CS.Call(2, 73, 1, false, this); },
        setsprite: function (v) { return CS.Call(3, 73, 1, false, this, v); },
    });
    if ($hc < 75) { return; }
     
    Bridge.define("UnityEngine.Animator", {
        inherits: [UnityEngine.Behaviour],
        statics: {
            StringToHash: function (a0/* String */) { return CS.Call(4, 74, 67, true, a0); },
        },
        ctor: function () {
            CS.Call(5, 74, 0, true, this);
        },
        getapplyRootMotion: function () { return CS.Call(2, 74, 0, false, this); },
        setapplyRootMotion: function (v) { return CS.Call(3, 74, 0, false, this, v); },
        getavatar: function () { return CS.Call(2, 74, 1, false, this); },
        setavatar: function (v) { return CS.Call(3, 74, 1, false, this, v); },
        getbodyPosition: function () { return CS.Call(2, 74, 2, false, this); },
        setbodyPosition: function (v) { return CS.Call(3, 74, 2, false, this, v); },
        getbodyRotation: function () { return CS.Call(2, 74, 3, false, this); },
        setbodyRotation: function (v) { return CS.Call(3, 74, 3, false, this, v); },
        getcullingMode: function () { return CS.Call(2, 74, 4, false, this); },
        setcullingMode: function (v) { return CS.Call(3, 74, 4, false, this, v); },
        getdeltaPosition: function () { return CS.Call(2, 74, 5, false, this); },
        setdeltaPosition: function (v) { return CS.Call(3, 74, 5, false, this, v); },
        getdeltaRotation: function () { return CS.Call(2, 74, 6, false, this); },
        setdeltaRotation: function (v) { return CS.Call(3, 74, 6, false, this, v); },
        getfeetPivotActive: function () { return CS.Call(2, 74, 7, false, this); },
        setfeetPivotActive: function (v) { return CS.Call(3, 74, 7, false, this, v); },
        getfireEvents: function () { return CS.Call(2, 74, 8, false, this); },
        setfireEvents: function (v) { return CS.Call(3, 74, 8, false, this, v); },
        getgravityWeight: function () { return CS.Call(2, 74, 9, false, this); },
        setgravityWeight: function (v) { return CS.Call(3, 74, 9, false, this, v); },
        gethasRootMotion: function () { return CS.Call(2, 74, 10, false, this); },
        sethasRootMotion: function (v) { return CS.Call(3, 74, 10, false, this, v); },
        gethasTransformHierarchy: function () { return CS.Call(2, 74, 11, false, this); },
        sethasTransformHierarchy: function (v) { return CS.Call(3, 74, 11, false, this, v); },
        gethumanScale: function () { return CS.Call(2, 74, 12, false, this); },
        sethumanScale: function (v) { return CS.Call(3, 74, 12, false, this, v); },
        getisHuman: function () { return CS.Call(2, 74, 13, false, this); },
        setisHuman: function (v) { return CS.Call(3, 74, 13, false, this, v); },
        getisMatchingTarget: function () { return CS.Call(2, 74, 14, false, this); },
        setisMatchingTarget: function (v) { return CS.Call(3, 74, 14, false, this, v); },
        getisOptimizable: function () { return CS.Call(2, 74, 15, false, this); },
        setisOptimizable: function (v) { return CS.Call(3, 74, 15, false, this, v); },
        getlayerCount: function () { return CS.Call(2, 74, 16, false, this); },
        setlayerCount: function (v) { return CS.Call(3, 74, 16, false, this, v); },
        getlayersAffectMassCenter: function () { return CS.Call(2, 74, 17, false, this); },
        setlayersAffectMassCenter: function (v) { return CS.Call(3, 74, 17, false, this, v); },
        getleftFeetBottomHeight: function () { return CS.Call(2, 74, 18, false, this); },
        setleftFeetBottomHeight: function (v) { return CS.Call(3, 74, 18, false, this, v); },
        getlogWarnings: function () { return CS.Call(2, 74, 19, false, this); },
        setlogWarnings: function (v) { return CS.Call(3, 74, 19, false, this, v); },
        getpivotPosition: function () { return CS.Call(2, 74, 20, false, this); },
        setpivotPosition: function (v) { return CS.Call(3, 74, 20, false, this, v); },
        getpivotWeight: function () { return CS.Call(2, 74, 21, false, this); },
        setpivotWeight: function (v) { return CS.Call(3, 74, 21, false, this, v); },
        getplaybackTime: function () { return CS.Call(2, 74, 22, false, this); },
        setplaybackTime: function (v) { return CS.Call(3, 74, 22, false, this, v); },
        getrecorderStartTime: function () { return CS.Call(2, 74, 23, false, this); },
        setrecorderStartTime: function (v) { return CS.Call(3, 74, 23, false, this, v); },
        getrecorderStopTime: function () { return CS.Call(2, 74, 24, false, this); },
        setrecorderStopTime: function (v) { return CS.Call(3, 74, 24, false, this, v); },
        getrightFeetBottomHeight: function () { return CS.Call(2, 74, 25, false, this); },
        setrightFeetBottomHeight: function (v) { return CS.Call(3, 74, 25, false, this, v); },
        getrootPosition: function () { return CS.Call(2, 74, 26, false, this); },
        setrootPosition: function (v) { return CS.Call(3, 74, 26, false, this, v); },
        getrootRotation: function () { return CS.Call(2, 74, 27, false, this); },
        setrootRotation: function (v) { return CS.Call(3, 74, 27, false, this, v); },
        getruntimeAnimatorController: function () { return CS.Call(2, 74, 28, false, this); },
        setruntimeAnimatorController: function (v) { return CS.Call(3, 74, 28, false, this, v); },
        getspeed: function () { return CS.Call(2, 74, 29, false, this); },
        setspeed: function (v) { return CS.Call(3, 74, 29, false, this, v); },
        getstabilizeFeet: function () { return CS.Call(2, 74, 30, false, this); },
        setstabilizeFeet: function (v) { return CS.Call(3, 74, 30, false, this, v); },
        gettargetPosition: function () { return CS.Call(2, 74, 31, false, this); },
        settargetPosition: function (v) { return CS.Call(3, 74, 31, false, this, v); },
        gettargetRotation: function () { return CS.Call(2, 74, 32, false, this); },
        settargetRotation: function (v) { return CS.Call(3, 74, 32, false, this, v); },
        getupdateMode: function () { return CS.Call(2, 74, 33, false, this); },
        setupdateMode: function (v) { return CS.Call(3, 74, 33, false, this, v); },
        CrossFade: function (a0/* Int32 */, a1/* Single */) { return CS.Call(4, 74, 0, false, this, a0, a1); },
        CrossFade$1: function (a0/* Int32 */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 74, 1, false, this, a0, a1, a2); },
        CrossFade$2: function (a0/* Int32 */, a1/* Single */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 74, 2, false, this, a0, a1, a2, a3); },
        CrossFade$3: function (a0/* String */, a1/* Single */) { return CS.Call(4, 74, 3, false, this, a0, a1); },
        CrossFade$4: function (a0/* String */, a1/* Single */, a2/* Int32 */) { return CS.Call(4, 74, 4, false, this, a0, a1, a2); },
        CrossFade$5: function (a0/* String */, a1/* Single */, a2/* Int32 */, a3/* Single */) { return CS.Call(4, 74, 5, false, this, a0, a1, a2, a3); },
        GetAnimatorTransitionInfo: function (a0/* Int32 */) { return CS.Call(4, 74, 6, false, this, a0); },
        GetBoneTransform: function (a0/* HumanBodyBones */) { return CS.Call(4, 74, 7, false, this, a0); },
        GetBool: function (a0/* Int32 */) { return CS.Call(4, 74, 8, false, this, a0); },
        GetBool$1: function (a0/* String */) { return CS.Call(4, 74, 9, false, this, a0); },
        GetCurrentAnimationClipState: function (a0/* Int32 */) { return CS.Call(4, 74, 10, false, this, a0); },
        GetCurrentAnimatorStateInfo: function (a0/* Int32 */) { return CS.Call(4, 74, 11, false, this, a0); },
        GetFloat: function (a0/* Int32 */) { return CS.Call(4, 74, 12, false, this, a0); },
        GetFloat$1: function (a0/* String */) { return CS.Call(4, 74, 13, false, this, a0); },
        GetIKPosition: function (a0/* AvatarIKGoal */) { return CS.Call(4, 74, 14, false, this, a0); },
        GetIKPositionWeight: function (a0/* AvatarIKGoal */) { return CS.Call(4, 74, 15, false, this, a0); },
        GetIKRotation: function (a0/* AvatarIKGoal */) { return CS.Call(4, 74, 16, false, this, a0); },
        GetIKRotationWeight: function (a0/* AvatarIKGoal */) { return CS.Call(4, 74, 17, false, this, a0); },
        GetInteger: function (a0/* Int32 */) { return CS.Call(4, 74, 18, false, this, a0); },
        GetInteger$1: function (a0/* String */) { return CS.Call(4, 74, 19, false, this, a0); },
        GetLayerName: function (a0/* Int32 */) { return CS.Call(4, 74, 20, false, this, a0); },
        GetLayerWeight: function (a0/* Int32 */) { return CS.Call(4, 74, 21, false, this, a0); },
        GetNextAnimationClipState: function (a0/* Int32 */) { return CS.Call(4, 74, 22, false, this, a0); },
        GetNextAnimatorStateInfo: function (a0/* Int32 */) { return CS.Call(4, 74, 23, false, this, a0); },
        InterruptMatchTarget: function () { return CS.Call(4, 74, 24, false, this); },
        InterruptMatchTarget$1: function (a0/* Boolean */) { return CS.Call(4, 74, 25, false, this, a0); },
        IsInTransition: function (a0/* Int32 */) { return CS.Call(4, 74, 26, false, this, a0); },
        IsParameterControlledByCurve: function (a0/* Int32 */) { return CS.Call(4, 74, 27, false, this, a0); },
        IsParameterControlledByCurve$1: function (a0/* String */) { return CS.Call(4, 74, 28, false, this, a0); },
        MatchTarget: function (a0/* Vector3 */, a1/* Quaternion */, a2/* AvatarTarget */, a3/* MatchTargetWeightMask */, a4/* Single */) { return CS.Call(4, 74, 29, false, this, a0, a1, a2, a3, a4); },
        MatchTarget$1: function (a0/* Vector3 */, a1/* Quaternion */, a2/* AvatarTarget */, a3/* MatchTargetWeightMask */, a4/* Single */, a5/* Single */) { return CS.Call(4, 74, 30, false, this, a0, a1, a2, a3, a4, a5); },
        Play: function (a0/* Int32 */) { return CS.Call(4, 74, 31, false, this, a0); },
        Play$1: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 74, 32, false, this, a0, a1); },
        Play$2: function (a0/* Int32 */, a1/* Int32 */, a2/* Single */) { return CS.Call(4, 74, 33, false, this, a0, a1, a2); },
        Play$3: function (a0/* String */) { return CS.Call(4, 74, 34, false, this, a0); },
        Play$4: function (a0/* String */, a1/* Int32 */) { return CS.Call(4, 74, 35, false, this, a0, a1); },
        Play$5: function (a0/* String */, a1/* Int32 */, a2/* Single */) { return CS.Call(4, 74, 36, false, this, a0, a1, a2); },
        Rebind: function () { return CS.Call(4, 74, 37, false, this); },
        ResetTrigger: function (a0/* Int32 */) { return CS.Call(4, 74, 38, false, this, a0); },
        ResetTrigger$1: function (a0/* String */) { return CS.Call(4, 74, 39, false, this, a0); },
        SetBool: function (a0/* Int32 */, a1/* Boolean */) { return CS.Call(4, 74, 40, false, this, a0, a1); },
        SetBool$1: function (a0/* String */, a1/* Boolean */) { return CS.Call(4, 74, 41, false, this, a0, a1); },
        SetFloat: function (a0/* Int32 */, a1/* Single */) { return CS.Call(4, 74, 42, false, this, a0, a1); },
        SetFloat$1: function (a0/* Int32 */, a1/* Single */, a2/* Single */, a3/* Single */) { return CS.Call(4, 74, 43, false, this, a0, a1, a2, a3); },
        SetFloat$2: function (a0/* String */, a1/* Single */) { return CS.Call(4, 74, 44, false, this, a0, a1); },
        SetFloat$3: function (a0/* String */, a1/* Single */, a2/* Single */, a3/* Single */) { return CS.Call(4, 74, 45, false, this, a0, a1, a2, a3); },
        SetIKPosition: function (a0/* AvatarIKGoal */, a1/* Vector3 */) { return CS.Call(4, 74, 46, false, this, a0, a1); },
        SetIKPositionWeight: function (a0/* AvatarIKGoal */, a1/* Single */) { return CS.Call(4, 74, 47, false, this, a0, a1); },
        SetIKRotation: function (a0/* AvatarIKGoal */, a1/* Quaternion */) { return CS.Call(4, 74, 48, false, this, a0, a1); },
        SetIKRotationWeight: function (a0/* AvatarIKGoal */, a1/* Single */) { return CS.Call(4, 74, 49, false, this, a0, a1); },
        SetInteger: function (a0/* Int32 */, a1/* Int32 */) { return CS.Call(4, 74, 50, false, this, a0, a1); },
        SetInteger$1: function (a0/* String */, a1/* Int32 */) { return CS.Call(4, 74, 51, false, this, a0, a1); },
        SetLayerWeight: function (a0/* Int32 */, a1/* Single */) { return CS.Call(4, 74, 52, false, this, a0, a1); },
        SetLookAtPosition: function (a0/* Vector3 */) { return CS.Call(4, 74, 53, false, this, a0); },
        SetLookAtWeight: function (a0/* Single */) { return CS.Call(4, 74, 54, false, this, a0); },
        SetLookAtWeight$1: function (a0/* Single */, a1/* Single */) { return CS.Call(4, 74, 55, false, this, a0, a1); },
        SetLookAtWeight$2: function (a0/* Single */, a1/* Single */, a2/* Single */) { return CS.Call(4, 74, 56, false, this, a0, a1, a2); },
        SetLookAtWeight$3: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Single */) { return CS.Call(4, 74, 57, false, this, a0, a1, a2, a3); },
        SetLookAtWeight$4: function (a0/* Single */, a1/* Single */, a2/* Single */, a3/* Single */, a4/* Single */) { return CS.Call(4, 74, 58, false, this, a0, a1, a2, a3, a4); },
        SetTarget: function (a0/* AvatarTarget */, a1/* Single */) { return CS.Call(4, 74, 59, false, this, a0, a1); },
        SetTrigger: function (a0/* Int32 */) { return CS.Call(4, 74, 60, false, this, a0); },
        SetTrigger$1: function (a0/* String */) { return CS.Call(4, 74, 61, false, this, a0); },
        StartPlayback: function () { return CS.Call(4, 74, 62, false, this); },
        StartRecording: function (a0/* Int32 */) { return CS.Call(4, 74, 63, false, this, a0); },
        StopPlayback: function () { return CS.Call(4, 74, 64, false, this); },
        StopRecording: function () { return CS.Call(4, 74, 65, false, this); },
        Update: function (a0/* Single */) { return CS.Call(4, 74, 66, false, this, a0); },
    });
    if ($hc < 76) { return; }
     
    Bridge.define("UnityEngine.BoxCollider", {
        inherits: [UnityEngine.Collider],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 75, 0, true, this);
        },
        getcenter: function () { return CS.Call(2, 75, 0, false, this); },
        setcenter: function (v) { return CS.Call(3, 75, 0, false, this, v); },
        getsize: function () { return CS.Call(2, 75, 1, false, this); },
        setsize: function (v) { return CS.Call(3, 75, 1, false, this, v); },
    });
    if ($hc < 77) { return; }
     
    Bridge.define("UnityEngine.CapsuleCollider", {
        inherits: [UnityEngine.Collider],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 76, 0, true, this);
        },
        getcenter: function () { return CS.Call(2, 76, 0, false, this); },
        setcenter: function (v) { return CS.Call(3, 76, 0, false, this, v); },
        getdirection: function () { return CS.Call(2, 76, 1, false, this); },
        setdirection: function (v) { return CS.Call(3, 76, 1, false, this, v); },
        getheight: function () { return CS.Call(2, 76, 2, false, this); },
        setheight: function (v) { return CS.Call(3, 76, 2, false, this, v); },
        getradius: function () { return CS.Call(2, 76, 3, false, this); },
        setradius: function (v) { return CS.Call(3, 76, 3, false, this, v); },
    });
    if ($hc < 78) { return; }
     
    Bridge.define("UnityEngine.MonoBehaviour", {
        inherits: [UnityEngine.Behaviour],
        statics: {
            print: function (a0/* Object */) { return CS.Call(4, 77, 14, true, a0); },
        },
        ctor: function () {},
        getuseGUILayout: function () { return CS.Call(2, 77, 0, false, this); },
        setuseGUILayout: function (v) { return CS.Call(3, 77, 0, false, this, v); },
        CancelInvoke: function () { return CS.Call(4, 77, 0, false, this); },
        CancelInvoke$1: function (a0/* String */) { return CS.Call(4, 77, 1, false, this, a0); },
        Invoke: function (a0/* String */, a1/* Single */) { return CS.Call(4, 77, 2, false, this, a0, a1); },
        InvokeRepeating: function (a0/* String */, a1/* Single */, a2/* Single */) { return CS.Call(4, 77, 3, false, this, a0, a1, a2); },
        IsInvoking: function () { return CS.Call(4, 77, 4, false, this); },
        IsInvoking$1: function (a0/* String */) { return CS.Call(4, 77, 5, false, this, a0); },
        StartCoroutine: function (a0/* IEnumerator */) { return CS.Call(4, 77, 6, false, this, a0); },
        StartCoroutine$1: function (a0/* String */) { return CS.Call(4, 77, 7, false, this, a0); },
        StartCoroutine$2: function (a0/* String */, a1/* Object */) { return CS.Call(4, 77, 8, false, this, a0, a1); },
        StartCoroutine_Auto: function (a0/* IEnumerator */) { return CS.Call(4, 77, 9, false, this, a0); },
        StopAllCoroutines: function () { return CS.Call(4, 77, 10, false, this); },
        StopCoroutine: function (a0/* IEnumerator */) { return CS.Call(4, 77, 11, false, this, a0); },
        StopCoroutine$1: function (a0/* String */) { return CS.Call(4, 77, 12, false, this, a0); },
        StopCoroutine$2: function (a0/* Coroutine */) { return CS.Call(4, 77, 13, false, this, a0); },
    });
    if ($hc < 79) { return; }
     
    Bridge.define("UnityEngine.MeshRenderer", {
        inherits: [UnityEngine.Renderer],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 78, 0, true, this);
        },
    });
    if ($hc < 80) { return; }
     
    Bridge.define("UnityEngine.UI.Button.ButtonClickedEvent", {
        inherits: [UnityEngine.Events.UnityEvent, UnityEngine.ISerializationCallbackReceiver],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 79, 0, true, this);
        },
    });
    if ($hc < 81) { return; }
     
    Bridge.define("UnityEngine.Animation", {
        inherits: [UnityEngine.Behaviour, System.Collections.IEnumerable],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 80, 0, true, this);
        },
        getanimatePhysics: function () { return CS.Call(2, 80, 0, false, this); },
        setanimatePhysics: function (v) { return CS.Call(3, 80, 0, false, this, v); },
        getclip: function () { return CS.Call(2, 80, 1, false, this); },
        setclip: function (v) { return CS.Call(3, 80, 1, false, this, v); },
        getcullingType: function () { return CS.Call(2, 80, 2, false, this); },
        setcullingType: function (v) { return CS.Call(3, 80, 2, false, this, v); },
        getisPlaying: function () { return CS.Call(2, 80, 3, false, this); },
        setisPlaying: function (v) { return CS.Call(3, 80, 3, false, this, v); },
        getItem: function (ind0) { return CS.Call(2, 80, 4, false, this, ind0); },
        setItem: function (ind0, v) { return CS.Call(3, 80, 4, false, this, ind0, v); },
        getlocalBounds: function () { return CS.Call(2, 80, 5, false, this); },
        setlocalBounds: function (v) { return CS.Call(3, 80, 5, false, this, v); },
        getplayAutomatically: function () { return CS.Call(2, 80, 6, false, this); },
        setplayAutomatically: function (v) { return CS.Call(3, 80, 6, false, this, v); },
        getwrapMode: function () { return CS.Call(2, 80, 7, false, this); },
        setwrapMode: function (v) { return CS.Call(3, 80, 7, false, this, v); },
        AddClip: function (a0/* AnimationClip */, a1/* String */) { return CS.Call(4, 80, 0, false, this, a0, a1); },
        AddClip$1: function (a0/* AnimationClip */, a1/* String */, a2/* Int32 */, a3/* Int32 */) { return CS.Call(4, 80, 1, false, this, a0, a1, a2, a3); },
        AddClip$2: function (a0/* AnimationClip */, a1/* String */, a2/* Int32 */, a3/* Int32 */, a4/* Boolean */) { return CS.Call(4, 80, 2, false, this, a0, a1, a2, a3, a4); },
        Blend: function (a0/* String */) { return CS.Call(4, 80, 3, false, this, a0); },
        Blend$1: function (a0/* String */, a1/* Single */) { return CS.Call(4, 80, 4, false, this, a0, a1); },
        Blend$2: function (a0/* String */, a1/* Single */, a2/* Single */) { return CS.Call(4, 80, 5, false, this, a0, a1, a2); },
        CrossFade: function (a0/* String */) { return CS.Call(4, 80, 6, false, this, a0); },
        CrossFade$1: function (a0/* String */, a1/* Single */) { return CS.Call(4, 80, 7, false, this, a0, a1); },
        CrossFade$2: function (a0/* String */, a1/* Single */, a2/* PlayMode */) { return CS.Call(4, 80, 8, false, this, a0, a1, a2); },
        CrossFadeQueued: function (a0/* String */) { return CS.Call(4, 80, 9, false, this, a0); },
        CrossFadeQueued$1: function (a0/* String */, a1/* Single */) { return CS.Call(4, 80, 10, false, this, a0, a1); },
        CrossFadeQueued$2: function (a0/* String */, a1/* Single */, a2/* QueueMode */) { return CS.Call(4, 80, 11, false, this, a0, a1, a2); },
        CrossFadeQueued$3: function (a0/* String */, a1/* Single */, a2/* QueueMode */, a3/* PlayMode */) { return CS.Call(4, 80, 12, false, this, a0, a1, a2, a3); },
        GetClip: function (a0/* String */) { return CS.Call(4, 80, 13, false, this, a0); },
        GetClipCount: function () { return CS.Call(4, 80, 14, false, this); },
        GetEnumerator: function () { return CS.Call(4, 80, 15, false, this); },
        IsPlaying: function (a0/* String */) { return CS.Call(4, 80, 16, false, this, a0); },
        Play: function () { return CS.Call(4, 80, 17, false, this); },
        Play$1: function (a0/* String */) { return CS.Call(4, 80, 18, false, this, a0); },
        Play$2: function (a0/* String */, a1/* PlayMode */) { return CS.Call(4, 80, 19, false, this, a0, a1); },
        Play$3: function (a0/* PlayMode */) { return CS.Call(4, 80, 20, false, this, a0); },
        PlayQueued: function (a0/* String */) { return CS.Call(4, 80, 21, false, this, a0); },
        PlayQueued$1: function (a0/* String */, a1/* QueueMode */) { return CS.Call(4, 80, 22, false, this, a0, a1); },
        PlayQueued$2: function (a0/* String */, a1/* QueueMode */, a2/* PlayMode */) { return CS.Call(4, 80, 23, false, this, a0, a1, a2); },
        RemoveClip: function (a0/* String */) { return CS.Call(4, 80, 24, false, this, a0); },
        RemoveClip$1: function (a0/* AnimationClip */) { return CS.Call(4, 80, 25, false, this, a0); },
        Rewind: function () { return CS.Call(4, 80, 26, false, this); },
        Rewind$1: function (a0/* String */) { return CS.Call(4, 80, 27, false, this, a0); },
        Sample: function () { return CS.Call(4, 80, 28, false, this); },
        Stop: function () { return CS.Call(4, 80, 29, false, this); },
        Stop$1: function (a0/* String */) { return CS.Call(4, 80, 30, false, this, a0); },
        SyncLayer: function (a0/* Int32 */) { return CS.Call(4, 80, 31, false, this, a0); },
    });
    if ($hc < 82) { return; }
     
    Bridge.define("UnityEngine.RectTransform", {
        inherits: [UnityEngine.Transform, System.Collections.IEnumerable],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 81, 0, true, this);
        },
        getanchoredPosition: function () { return CS.Call(2, 81, 0, false, this); },
        setanchoredPosition: function (v) { return CS.Call(3, 81, 0, false, this, v); },
        getanchoredPosition3D: function () { return CS.Call(2, 81, 1, false, this); },
        setanchoredPosition3D: function (v) { return CS.Call(3, 81, 1, false, this, v); },
        getanchorMax: function () { return CS.Call(2, 81, 2, false, this); },
        setanchorMax: function (v) { return CS.Call(3, 81, 2, false, this, v); },
        getanchorMin: function () { return CS.Call(2, 81, 3, false, this); },
        setanchorMin: function (v) { return CS.Call(3, 81, 3, false, this, v); },
        getoffsetMax: function () { return CS.Call(2, 81, 4, false, this); },
        setoffsetMax: function (v) { return CS.Call(3, 81, 4, false, this, v); },
        getoffsetMin: function () { return CS.Call(2, 81, 5, false, this); },
        setoffsetMin: function (v) { return CS.Call(3, 81, 5, false, this, v); },
        getpivot: function () { return CS.Call(2, 81, 6, false, this); },
        setpivot: function (v) { return CS.Call(3, 81, 6, false, this, v); },
        getrect: function () { return CS.Call(2, 81, 7, false, this); },
        setrect: function (v) { return CS.Call(3, 81, 7, false, this, v); },
        getsizeDelta: function () { return CS.Call(2, 81, 8, false, this); },
        setsizeDelta: function (v) { return CS.Call(3, 81, 8, false, this, v); },
        GetLocalCorners: function (a0/* Vector3[] */) { return CS.Call(4, 81, 0, false, this, a0); },
        GetWorldCorners: function (a0/* Vector3[] */) { return CS.Call(4, 81, 1, false, this, a0); },
        SetInsetAndSizeFromParentEdge: function (a0/* Edge */, a1/* Single */, a2/* Single */) { return CS.Call(4, 81, 2, false, this, a0, a1, a2); },
        SetSizeWithCurrentAnchors: function (a0/* Axis */, a1/* Single */) { return CS.Call(4, 81, 3, false, this, a0, a1); },
    });
    if ($hc < 83) { return; }
     
    Bridge.define("TestCallJs", {
        inherits: [UnityEngine.MonoBehaviour],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 82, 0, true, this);
        },
    });
    if ($hc < 84) { return; }
     
    Bridge.define("UnityEngine.EventSystems.UIBehaviour", {
        inherits: [UnityEngine.MonoBehaviour],
        statics: {
        },
        IsActive: function () { return CS.Call(4, 83, 0, false, this); },
        IsDestroyed: function () { return CS.Call(4, 83, 1, false, this); },
    });
    if ($hc < 85) { return; }
     
    Bridge.define("UnityEngine.BoxCollider2D", {
        inherits: [UnityEngine.Collider2D],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 84, 0, true, this);
        },
        getcenter: function () { return CS.Call(2, 84, 0, false, this); },
        setcenter: function (v) { return CS.Call(3, 84, 0, false, this, v); },
        getsize: function () { return CS.Call(2, 84, 1, false, this); },
        setsize: function (v) { return CS.Call(3, 84, 1, false, this, v); },
    });
    if ($hc < 86) { return; }
     
    Bridge.define("UnityEngine.CircleCollider2D", {
        inherits: [UnityEngine.Collider2D],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 85, 0, true, this);
        },
        getcenter: function () { return CS.Call(2, 85, 0, false, this); },
        setcenter: function (v) { return CS.Call(3, 85, 0, false, this, v); },
        getradius: function () { return CS.Call(2, 85, 1, false, this); },
        setradius: function (v) { return CS.Call(3, 85, 1, false, this, v); },
    });
    if ($hc < 87) { return; }
     
    Bridge.define("UnityEngine.PolygonCollider2D", {
        inherits: [UnityEngine.Collider2D],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 86, 0, true, this);
        },
        getpathCount: function () { return CS.Call(2, 86, 0, false, this); },
        setpathCount: function (v) { return CS.Call(3, 86, 0, false, this, v); },
        getpoints: function () { return CS.Call(2, 86, 1, false, this); },
        setpoints: function (v) { return CS.Call(3, 86, 1, false, this, v); },
        CreatePrimitive: function (a0/* Int32 */) { return CS.Call(4, 86, 0, false, this, a0); },
        CreatePrimitive$1: function (a0/* Int32 */, a1/* Vector2 */) { return CS.Call(4, 86, 1, false, this, a0, a1); },
        CreatePrimitive$2: function (a0/* Int32 */, a1/* Vector2 */, a2/* Vector2 */) { return CS.Call(4, 86, 2, false, this, a0, a1, a2); },
        GetPath: function (a0/* Int32 */) { return CS.Call(4, 86, 3, false, this, a0); },
        GetTotalPointCount: function () { return CS.Call(4, 86, 4, false, this); },
        SetPath: function (a0/* Int32 */, a1/* Vector2[] */) { return CS.Call(4, 86, 5, false, this, a0, a1); },
    });
    if ($hc < 88) { return; }
     
    Bridge.define("UnityEngine.GUITexture", {
        inherits: [UnityEngine.GUIElement],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 87, 0, true, this);
        },
        getborder: function () { return CS.Call(2, 87, 0, false, this); },
        setborder: function (v) { return CS.Call(3, 87, 0, false, this, v); },
        getcolor: function () { return CS.Call(2, 87, 1, false, this); },
        setcolor: function (v) { return CS.Call(3, 87, 1, false, this, v); },
        getpixelInset: function () { return CS.Call(2, 87, 2, false, this); },
        setpixelInset: function (v) { return CS.Call(3, 87, 2, false, this, v); },
        gettexture: function () { return CS.Call(2, 87, 3, false, this); },
        settexture: function (v) { return CS.Call(3, 87, 3, false, this, v); },
    });
    if ($hc < 89) { return; }
     
    Bridge.define("UnityEngine.GUIText", {
        inherits: [UnityEngine.GUIElement],
        statics: {
        },
        ctor: function () {
            CS.Call(5, 88, 0, true, this);
        },
        getalignment: function () { return CS.Call(2, 88, 0, false, this); },
        setalignment: function (v) { return CS.Call(3, 88, 0, false, this, v); },
        getanchor: function () { return CS.Call(2, 88, 1, false, this); },
        setanchor: function (v) { return CS.Call(3, 88, 1, false, this, v); },
        getcolor: function () { return CS.Call(2, 88, 2, false, this); },
        setcolor: function (v) { return CS.Call(3, 88, 2, false, this, v); },
        getfont: function () { return CS.Call(2, 88, 3, false, this); },
        setfont: function (v) { return CS.Call(3, 88, 3, false, this, v); },
        getfontSize: function () { return CS.Call(2, 88, 4, false, this); },
        setfontSize: function (v) { return CS.Call(3, 88, 4, false, this, v); },
        getfontStyle: function () { return CS.Call(2, 88, 5, false, this); },
        setfontStyle: function (v) { return CS.Call(3, 88, 5, false, this, v); },
        getlineSpacing: function () { return CS.Call(2, 88, 6, false, this); },
        setlineSpacing: function (v) { return CS.Call(3, 88, 6, false, this, v); },
        getmaterial: function () { return CS.Call(2, 88, 7, false, this); },
        setmaterial: function (v) { return CS.Call(3, 88, 7, false, this, v); },
        getpixelOffset: function () { return CS.Call(2, 88, 8, false, this); },
        setpixelOffset: function (v) { return CS.Call(3, 88, 8, false, this, v); },
        getrichText: function () { return CS.Call(2, 88, 9, false, this); },
        setrichText: function (v) { return CS.Call(3, 88, 9, false, this, v); },
        gettabSize: function () { return CS.Call(2, 88, 10, false, this); },
        settabSize: function (v) { return CS.Call(3, 88, 10, false, this, v); },
        gettext: function () { return CS.Call(2, 88, 11, false, this); },
        settext: function (v) { return CS.Call(3, 88, 11, false, this, v); },
    });
    if ($hc < 90) { return; }
     
    Bridge.define("UnityEngine.UI.Selectable", {
        inherits: [UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler],
        statics: {
            getallSelectables: function () { return CS.Call(2, 89, 9, true); },
            setallSelectables: function (v) { return CS.Call(3, 89, 9, true, v); },
        },
        getanimationTriggers: function () { return CS.Call(2, 89, 0, false, this); },
        setanimationTriggers: function (v) { return CS.Call(3, 89, 0, false, this, v); },
        getanimator: function () { return CS.Call(2, 89, 1, false, this); },
        setanimator: function (v) { return CS.Call(3, 89, 1, false, this, v); },
        getcolors: function () { return CS.Call(2, 89, 2, false, this); },
        setcolors: function (v) { return CS.Call(3, 89, 2, false, this, v); },
        getimage: function () { return CS.Call(2, 89, 3, false, this); },
        setimage: function (v) { return CS.Call(3, 89, 3, false, this, v); },
        getinteractable: function () { return CS.Call(2, 89, 4, false, this); },
        setinteractable: function (v) { return CS.Call(3, 89, 4, false, this, v); },
        getnavigation: function () { return CS.Call(2, 89, 5, false, this); },
        setnavigation: function (v) { return CS.Call(3, 89, 5, false, this, v); },
        getspriteState: function () { return CS.Call(2, 89, 6, false, this); },
        setspriteState: function (v) { return CS.Call(3, 89, 6, false, this, v); },
        gettargetGraphic: function () { return CS.Call(2, 89, 7, false, this); },
        settargetGraphic: function (v) { return CS.Call(3, 89, 7, false, this, v); },
        gettransition: function () { return CS.Call(2, 89, 8, false, this); },
        settransition: function (v) { return CS.Call(3, 89, 8, false, this, v); },
        FindSelectable: function (a0/* Vector3 */) { return CS.Call(4, 89, 0, false, this, a0); },
        FindSelectableOnDown: function () { return CS.Call(4, 89, 1, false, this); },
        FindSelectableOnLeft: function () { return CS.Call(4, 89, 2, false, this); },
        FindSelectableOnRight: function () { return CS.Call(4, 89, 3, false, this); },
        FindSelectableOnUp: function () { return CS.Call(4, 89, 4, false, this); },
        IsInteractable: function () { return CS.Call(4, 89, 5, false, this); },
        OnDeselect: function (a0/* BaseEventData */) { return CS.Call(4, 89, 6, false, this, a0); },
        OnMove: function (a0/* AxisEventData */) { return CS.Call(4, 89, 7, false, this, a0); },
        OnPointerDown: function (a0/* PointerEventData */) { return CS.Call(4, 89, 8, false, this, a0); },
        OnPointerEnter: function (a0/* PointerEventData */) { return CS.Call(4, 89, 9, false, this, a0); },
        OnPointerExit: function (a0/* PointerEventData */) { return CS.Call(4, 89, 10, false, this, a0); },
        OnPointerUp: function (a0/* PointerEventData */) { return CS.Call(4, 89, 11, false, this, a0); },
        OnSelect: function (a0/* BaseEventData */) { return CS.Call(4, 89, 12, false, this, a0); },
        Select: function () { return CS.Call(4, 89, 13, false, this); },
    });
    if ($hc < 91) { return; }
     
    Bridge.define("UnityEngine.UI.LayoutGroup", {
        inherits: [UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutController, UnityEngine.UI.ILayoutGroup],
        statics: {
        },
        getchildAlignment: function () { return CS.Call(2, 90, 0, false, this); },
        setchildAlignment: function (v) { return CS.Call(3, 90, 0, false, this, v); },
        getflexibleHeight: function () { return CS.Call(2, 90, 1, false, this); },
        setflexibleHeight: function (v) { return CS.Call(3, 90, 1, false, this, v); },
        getflexibleWidth: function () { return CS.Call(2, 90, 2, false, this); },
        setflexibleWidth: function (v) { return CS.Call(3, 90, 2, false, this, v); },
        getlayoutPriority: function () { return CS.Call(2, 90, 3, false, this); },
        setlayoutPriority: function (v) { return CS.Call(3, 90, 3, false, this, v); },
        getminHeight: function () { return CS.Call(2, 90, 4, false, this); },
        setminHeight: function (v) { return CS.Call(3, 90, 4, false, this, v); },
        getminWidth: function () { return CS.Call(2, 90, 5, false, this); },
        setminWidth: function (v) { return CS.Call(3, 90, 5, false, this, v); },
        getpadding: function () { return CS.Call(2, 90, 6, false, this); },
        setpadding: function (v) { return CS.Call(3, 90, 6, false, this, v); },
        getpreferredHeight: function () { return CS.Call(2, 90, 7, false, this); },
        setpreferredHeight: function (v) { return CS.Call(3, 90, 7, false, this, v); },
        getpreferredWidth: function () { return CS.Call(2, 90, 8, false, this); },
        setpreferredWidth: function (v) { return CS.Call(3, 90, 8, false, this, v); },
        CalculateLayoutInputHorizontal: function () { return CS.Call(4, 90, 0, false, this); },
        CalculateLayoutInputVertical: function () { return CS.Call(4, 90, 1, false, this); },
        SetLayoutHorizontal: function () { return CS.Call(4, 90, 2, false, this); },
        SetLayoutVertical: function () { return CS.Call(4, 90, 3, false, this); },
    });
    if ($hc < 92) { return; }
     
    Bridge.define("UnityEngine.UI.Graphic", {
        inherits: [UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ICanvasElement],
        statics: {
            getdefaultGraphicMaterial: function () { return CS.Call(2, 91, 9, true); },
            setdefaultGraphicMaterial: function (v) { return CS.Call(3, 91, 9, true, v); },
        },
        getcanvas: function () { return CS.Call(2, 91, 0, false, this); },
        setcanvas: function (v) { return CS.Call(3, 91, 0, false, this, v); },
        getcanvasRenderer: function () { return CS.Call(2, 91, 1, false, this); },
        setcanvasRenderer: function (v) { return CS.Call(3, 91, 1, false, this, v); },
        getcolor: function () { return CS.Call(2, 91, 2, false, this); },
        setcolor: function (v) { return CS.Call(3, 91, 2, false, this, v); },
        getdefaultMaterial: function () { return CS.Call(2, 91, 3, false, this); },
        setdefaultMaterial: function (v) { return CS.Call(3, 91, 3, false, this, v); },
        getdepth: function () { return CS.Call(2, 91, 4, false, this); },
        setdepth: function (v) { return CS.Call(3, 91, 4, false, this, v); },
        getmainTexture: function () { return CS.Call(2, 91, 5, false, this); },
        setmainTexture: function (v) { return CS.Call(3, 91, 5, false, this, v); },
        getmaterial: function () { return CS.Call(2, 91, 6, false, this); },
        setmaterial: function (v) { return CS.Call(3, 91, 6, false, this, v); },
        getmaterialForRendering: function () { return CS.Call(2, 91, 7, false, this); },
        setmaterialForRendering: function (v) { return CS.Call(3, 91, 7, false, this, v); },
        getrectTransform: function () { return CS.Call(2, 91, 8, false, this); },
        setrectTransform: function (v) { return CS.Call(3, 91, 8, false, this, v); },
        CrossFadeAlpha: function (a0/* Single */, a1/* Single */, a2/* Boolean */) { return CS.Call(4, 91, 0, false, this, a0, a1, a2); },
        CrossFadeColor: function (a0/* Color */, a1/* Single */, a2/* Boolean */, a3/* Boolean */) { return CS.Call(4, 91, 1, false, this, a0, a1, a2, a3); },
        GetPixelAdjustedRect: function () { return CS.Call(4, 91, 2, false, this); },
        PixelAdjustPoint: function (a0/* Vector2 */) { return CS.Call(4, 91, 3, false, this, a0); },
        Raycast: function (a0/* Vector2 */, a1/* Camera */) { return CS.Call(4, 91, 4, false, this, a0, a1); },
        Rebuild: function (a0/* CanvasUpdate */) { return CS.Call(4, 91, 5, false, this, a0); },
        RegisterDirtyLayoutCallback: function (a0/* UnityAction */) { return CS.Call(4, 91, 6, false, this, a0); },
        RegisterDirtyMaterialCallback: function (a0/* UnityAction */) { return CS.Call(4, 91, 7, false, this, a0); },
        RegisterDirtyVerticesCallback: function (a0/* UnityAction */) { return CS.Call(4, 91, 8, false, this, a0); },
        SetAllDirty: function () { return CS.Call(4, 91, 9, false, this); },
        SetLayoutDirty: function () { return CS.Call(4, 91, 10, false, this); },
        SetMaterialDirty: function () { return CS.Call(4, 91, 11, false, this); },
        SetNativeSize: function () { return CS.Call(4, 91, 12, false, this); },
        SetVerticesDirty: function () { return CS.Call(4, 91, 13, false, this); },
        UnregisterDirtyLayoutCallback: function (a0/* UnityAction */) { return CS.Call(4, 91, 14, false, this, a0); },
        UnregisterDirtyMaterialCallback: function (a0/* UnityAction */) { return CS.Call(4, 91, 15, false, this, a0); },
        UnregisterDirtyVerticesCallback: function (a0/* UnityAction */) { return CS.Call(4, 91, 16, false, this, a0); },
    });
    if ($hc < 93) { return; }
     
    Bridge.define("UnityEngine.UI.GridLayoutGroup", {
        inherits: [UnityEngine.UI.LayoutGroup, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutController, UnityEngine.UI.ILayoutGroup],
        statics: {
        },
        getcellSize: function () { return CS.Call(2, 92, 0, false, this); },
        setcellSize: function (v) { return CS.Call(3, 92, 0, false, this, v); },
        getconstraint: function () { return CS.Call(2, 92, 1, false, this); },
        setconstraint: function (v) { return CS.Call(3, 92, 1, false, this, v); },
        getconstraintCount: function () { return CS.Call(2, 92, 2, false, this); },
        setconstraintCount: function (v) { return CS.Call(3, 92, 2, false, this, v); },
        getspacing: function () { return CS.Call(2, 92, 3, false, this); },
        setspacing: function (v) { return CS.Call(3, 92, 3, false, this, v); },
        getstartAxis: function () { return CS.Call(2, 92, 4, false, this); },
        setstartAxis: function (v) { return CS.Call(3, 92, 4, false, this, v); },
        getstartCorner: function () { return CS.Call(2, 92, 5, false, this); },
        setstartCorner: function (v) { return CS.Call(3, 92, 5, false, this, v); },
        CalculateLayoutInputHorizontal: function () { return CS.Call(4, 92, 0, false, this); },
        CalculateLayoutInputVertical: function () { return CS.Call(4, 92, 1, false, this); },
        SetLayoutHorizontal: function () { return CS.Call(4, 92, 2, false, this); },
        SetLayoutVertical: function () { return CS.Call(4, 92, 3, false, this); },
    });
    if ($hc < 94) { return; }
     
    Bridge.define("UnityEngine.UI.Button", {
        inherits: [UnityEngine.UI.Selectable, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler],
        statics: {
        },
        getonClick: function () { return CS.Call(2, 93, 0, false, this); },
        setonClick: function (v) { return CS.Call(3, 93, 0, false, this, v); },
        OnPointerClick: function (a0/* PointerEventData */) { return CS.Call(4, 93, 0, false, this, a0); },
        OnSubmit: function (a0/* BaseEventData */) { return CS.Call(4, 93, 1, false, this, a0); },
    });
    if ($hc < 95) { return; }
     
    Bridge.define("UnityEngine.UI.MaskableGraphic", {
        inherits: [UnityEngine.UI.Graphic, UnityEngine.UI.IMaskable, UnityEngine.UI.ICanvasElement],
        statics: {
        },
        getmaskable: function () { return CS.Call(2, 94, 0, false, this); },
        setmaskable: function (v) { return CS.Call(3, 94, 0, false, this, v); },
        getmaterial: function () { return CS.Call(2, 94, 1, false, this); },
        setmaterial: function (v) { return CS.Call(3, 94, 1, false, this, v); },
        ParentMaskStateChanged: function () { return CS.Call(4, 94, 0, false, this); },
        SetMaterialDirty: function () { return CS.Call(4, 94, 1, false, this); },
    });
    if ($hc < 96) { return; }
     
    Bridge.define("UnityEngine.UI.Text", {
        inherits: [UnityEngine.UI.MaskableGraphic, UnityEngine.UI.ILayoutElement, UnityEngine.UI.IMaskable, UnityEngine.UI.ICanvasElement],
        statics: {
            GetTextAnchorPivot: function (a0/* TextAnchor */) { return CS.Call(4, 95, 4, true, a0); },
        },
        getalignment: function () { return CS.Call(2, 95, 0, false, this); },
        setalignment: function (v) { return CS.Call(3, 95, 0, false, this, v); },
        getcachedTextGenerator: function () { return CS.Call(2, 95, 1, false, this); },
        setcachedTextGenerator: function (v) { return CS.Call(3, 95, 1, false, this, v); },
        getcachedTextGeneratorForLayout: function () { return CS.Call(2, 95, 2, false, this); },
        setcachedTextGeneratorForLayout: function (v) { return CS.Call(3, 95, 2, false, this, v); },
        getdefaultMaterial: function () { return CS.Call(2, 95, 3, false, this); },
        setdefaultMaterial: function (v) { return CS.Call(3, 95, 3, false, this, v); },
        getflexibleHeight: function () { return CS.Call(2, 95, 4, false, this); },
        setflexibleHeight: function (v) { return CS.Call(3, 95, 4, false, this, v); },
        getflexibleWidth: function () { return CS.Call(2, 95, 5, false, this); },
        setflexibleWidth: function (v) { return CS.Call(3, 95, 5, false, this, v); },
        getfont: function () { return CS.Call(2, 95, 6, false, this); },
        setfont: function (v) { return CS.Call(3, 95, 6, false, this, v); },
        getfontSize: function () { return CS.Call(2, 95, 7, false, this); },
        setfontSize: function (v) { return CS.Call(3, 95, 7, false, this, v); },
        getfontStyle: function () { return CS.Call(2, 95, 8, false, this); },
        setfontStyle: function (v) { return CS.Call(3, 95, 8, false, this, v); },
        gethorizontalOverflow: function () { return CS.Call(2, 95, 9, false, this); },
        sethorizontalOverflow: function (v) { return CS.Call(3, 95, 9, false, this, v); },
        getlayoutPriority: function () { return CS.Call(2, 95, 10, false, this); },
        setlayoutPriority: function (v) { return CS.Call(3, 95, 10, false, this, v); },
        getlineSpacing: function () { return CS.Call(2, 95, 11, false, this); },
        setlineSpacing: function (v) { return CS.Call(3, 95, 11, false, this, v); },
        getmainTexture: function () { return CS.Call(2, 95, 12, false, this); },
        setmainTexture: function (v) { return CS.Call(3, 95, 12, false, this, v); },
        getminHeight: function () { return CS.Call(2, 95, 13, false, this); },
        setminHeight: function (v) { return CS.Call(3, 95, 13, false, this, v); },
        getminWidth: function () { return CS.Call(2, 95, 14, false, this); },
        setminWidth: function (v) { return CS.Call(3, 95, 14, false, this, v); },
        getpixelsPerUnit: function () { return CS.Call(2, 95, 15, false, this); },
        setpixelsPerUnit: function (v) { return CS.Call(3, 95, 15, false, this, v); },
        getpreferredHeight: function () { return CS.Call(2, 95, 16, false, this); },
        setpreferredHeight: function (v) { return CS.Call(3, 95, 16, false, this, v); },
        getpreferredWidth: function () { return CS.Call(2, 95, 17, false, this); },
        setpreferredWidth: function (v) { return CS.Call(3, 95, 17, false, this, v); },
        getresizeTextForBestFit: function () { return CS.Call(2, 95, 18, false, this); },
        setresizeTextForBestFit: function (v) { return CS.Call(3, 95, 18, false, this, v); },
        getresizeTextMaxSize: function () { return CS.Call(2, 95, 19, false, this); },
        setresizeTextMaxSize: function (v) { return CS.Call(3, 95, 19, false, this, v); },
        getresizeTextMinSize: function () { return CS.Call(2, 95, 20, false, this); },
        setresizeTextMinSize: function (v) { return CS.Call(3, 95, 20, false, this, v); },
        getsupportRichText: function () { return CS.Call(2, 95, 21, false, this); },
        setsupportRichText: function (v) { return CS.Call(3, 95, 21, false, this, v); },
        gettext: function () { return CS.Call(2, 95, 22, false, this); },
        settext: function (v) { return CS.Call(3, 95, 22, false, this, v); },
        getverticalOverflow: function () { return CS.Call(2, 95, 23, false, this); },
        setverticalOverflow: function (v) { return CS.Call(3, 95, 23, false, this, v); },
        CalculateLayoutInputHorizontal: function () { return CS.Call(4, 95, 0, false, this); },
        CalculateLayoutInputVertical: function () { return CS.Call(4, 95, 1, false, this); },
        FontTextureChanged: function () { return CS.Call(4, 95, 2, false, this); },
        GetGenerationSettings: function (a0/* Vector2 */) { return CS.Call(4, 95, 3, false, this, a0); },
    });
})(1000000);