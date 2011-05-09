﻿using System;
using JSIL.Meta;

namespace JSIL.Proxies {
    [JSProxy(
        new [] { typeof(Delegate), typeof (MulticastDelegate) },
        JSProxyMemberPolicy.ReplaceNone
    )]
    public abstract class DelegateProxy {
        [JSRuntimeDispatch]
        public static void Combine () {
            throw new InvalidOperationException();
        }
    }
}