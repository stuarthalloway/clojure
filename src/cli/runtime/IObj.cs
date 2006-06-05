﻿/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
 *   which can be found in the file CPL.TXT at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

using System;
namespace org.clojure.runtime
    {
    interface IObj
        {
        object put(ThreadLocalData tld, IComparable key, object val);
        object get(ThreadLocalData tld, IComparable key);
        bool has(ThreadLocalData tld, IComparable key);
        }
    }