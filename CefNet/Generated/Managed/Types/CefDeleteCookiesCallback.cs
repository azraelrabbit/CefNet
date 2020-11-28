﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_delete_cookies_callback_t.cs
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
	/// Structure to implement to be notified of asynchronous completion via
	/// cef_cookie_manager_t::delete_cookies().
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefDeleteCookiesCallback : CefBaseRefCounted<cef_delete_cookies_callback_t>, ICefDeleteCookiesCallbackPrivate
	{
#if NET_LESS_5_0
		private static readonly OnCompleteDelegate fnOnComplete = OnCompleteImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefDeleteCookiesCallback Create(IntPtr instance)
		{
			return new CefDeleteCookiesCallback((cef_delete_cookies_callback_t*)instance);
		}

		public CefDeleteCookiesCallback()
		{
			cef_delete_cookies_callback_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_complete = (void*)Marshal.GetFunctionPointerForDelegate(fnOnComplete);
			#else
			self->on_complete = (delegate* unmanaged[Stdcall]<cef_delete_cookies_callback_t*, int, void>)&OnCompleteImpl;
			#endif
		}

		public CefDeleteCookiesCallback(cef_delete_cookies_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDeleteCookiesCallbackPrivate.AvoidOnComplete();

		/// <summary>
		/// Method that will be called upon completion. |num_deleted| will be the
		/// number of cookies that were deleted.
		/// </summary>
		protected internal unsafe virtual void OnComplete(int numDeleted)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnCompleteDelegate(cef_delete_cookies_callback_t* self, int num_deleted);

#endif // NET_LESS_5_0
		// void (*)(_cef_delete_cookies_callback_t* self, int num_deleted)*
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
		private static unsafe void OnCompleteImpl(cef_delete_cookies_callback_t* self, int num_deleted)
		{
			var instance = GetInstance((IntPtr)self) as CefDeleteCookiesCallback;
			if (instance == null || ((ICefDeleteCookiesCallbackPrivate)instance).AvoidOnComplete())
			{
				return;
			}
			instance.OnComplete(num_deleted);
		}
	}
}
