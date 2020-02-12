﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_scheme_handler_factory_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Structure that creates cef_resource_handler_t instances for handling scheme
	/// requests. The functions of this structure will always be called on the IO
	/// thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefSchemeHandlerFactory : CefBaseRefCounted<cef_scheme_handler_factory_t>
	{
		internal static unsafe CefSchemeHandlerFactory Create(IntPtr instance)
		{
			return new CefSchemeHandlerFactory((cef_scheme_handler_factory_t*)instance);
		}

		public CefSchemeHandlerFactory(cef_scheme_handler_factory_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Return a new resource handler instance to handle the request or an NULL
		/// reference to allow default handling of the request. |browser| and |frame|
		/// will be the browser window and frame respectively that originated the
		/// request or NULL if the request did not originate from a browser window (for
		/// example, if the request came from cef_urlrequest_t). The |request| object
		/// passed to this function cannot be modified.
		/// </summary>
		public unsafe virtual CefResourceHandler Create(CefBrowser browser, CefFrame frame, string schemeName, CefRequest request)
		{
			fixed (char* s2 = schemeName)
			{
				var cstr2 = new cef_string_t { Str = s2, Length = schemeName != null ? schemeName.Length : 0 };
				return SafeCall(CefResourceHandler.Wrap(CefResourceHandler.Create, NativeInstance->Create((browser != null) ? browser.GetNativeInstance() : null, (frame != null) ? frame.GetNativeInstance() : null, &cstr2, (request != null) ? request.GetNativeInstance() : null)));
			}
		}
	}
}
