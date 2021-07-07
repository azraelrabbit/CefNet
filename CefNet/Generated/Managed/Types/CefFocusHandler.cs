﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_focus_handler_t.cs
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
	/// Implement this structure to handle events related to focus. The functions of
	/// this structure will be called on the UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefFocusHandler : CefBaseRefCounted<cef_focus_handler_t>, ICefFocusHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnTakeFocusDelegate fnOnTakeFocus = OnTakeFocusImpl;

		private static readonly OnSetFocusDelegate fnOnSetFocus = OnSetFocusImpl;

		private static readonly OnGotFocusDelegate fnOnGotFocus = OnGotFocusImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefFocusHandler Create(IntPtr instance)
		{
			return new CefFocusHandler((cef_focus_handler_t*)instance);
		}

		public CefFocusHandler()
		{
			cef_focus_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_take_focus = (void*)Marshal.GetFunctionPointerForDelegate(fnOnTakeFocus);
			self->on_set_focus = (void*)Marshal.GetFunctionPointerForDelegate(fnOnSetFocus);
			self->on_got_focus = (void*)Marshal.GetFunctionPointerForDelegate(fnOnGotFocus);
			#else
			self->on_take_focus = (delegate* unmanaged[Stdcall]<cef_focus_handler_t*, cef_browser_t*, int, void>)&OnTakeFocusImpl;
			self->on_set_focus = (delegate* unmanaged[Stdcall]<cef_focus_handler_t*, cef_browser_t*, CefFocusSource, int>)&OnSetFocusImpl;
			self->on_got_focus = (delegate* unmanaged[Stdcall]<cef_focus_handler_t*, cef_browser_t*, void>)&OnGotFocusImpl;
			#endif
		}

		public CefFocusHandler(cef_focus_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefFocusHandlerPrivate.AvoidOnTakeFocus();

		/// <summary>
		/// Called when the browser component is about to loose focus. For instance, if
		/// focus was on the last HTML element and the user pressed the TAB key. |next|
		/// will be true (1) if the browser is giving focus to the next component and
		/// false (0) if the browser is giving focus to the previous component.
		/// </summary>
		protected internal unsafe virtual void OnTakeFocus(CefBrowser browser, bool next)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnTakeFocusDelegate(cef_focus_handler_t* self, cef_browser_t* browser, int next);

#endif // NET_LESS_5_0
		// void (*)(_cef_focus_handler_t* self, _cef_browser_t* browser, int next)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnTakeFocusImpl(cef_focus_handler_t* self, cef_browser_t* browser, int next)
		{
			var instance = GetInstance((IntPtr)self) as CefFocusHandler;
			if (instance == null || ((ICefFocusHandlerPrivate)instance).AvoidOnTakeFocus())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnTakeFocus(CefBrowser.Wrap(CefBrowser.Create, browser), next != 0);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefFocusHandlerPrivate.AvoidOnSetFocus();

		/// <summary>
		/// Called when the browser component is requesting focus. |source| indicates
		/// where the focus request is originating from. Return false (0) to allow the
		/// focus to be set or true (1) to cancel setting the focus.
		/// </summary>
		protected internal unsafe virtual bool OnSetFocus(CefBrowser browser, CefFocusSource source)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnSetFocusDelegate(cef_focus_handler_t* self, cef_browser_t* browser, CefFocusSource source);

#endif // NET_LESS_5_0
		// int (*)(_cef_focus_handler_t* self, _cef_browser_t* browser, cef_focus_source_t source)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnSetFocusImpl(cef_focus_handler_t* self, cef_browser_t* browser, CefFocusSource source)
		{
			var instance = GetInstance((IntPtr)self) as CefFocusHandler;
			if (instance == null || ((ICefFocusHandlerPrivate)instance).AvoidOnSetFocus())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			return instance.OnSetFocus(CefBrowser.Wrap(CefBrowser.Create, browser), source) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefFocusHandlerPrivate.AvoidOnGotFocus();

		/// <summary>
		/// Called when the browser component has received focus.
		/// </summary>
		protected internal unsafe virtual void OnGotFocus(CefBrowser browser)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnGotFocusDelegate(cef_focus_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// void (*)(_cef_focus_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnGotFocusImpl(cef_focus_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefFocusHandler;
			if (instance == null || ((ICefFocusHandlerPrivate)instance).AvoidOnGotFocus())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnGotFocus(CefBrowser.Wrap(CefBrowser.Create, browser));
		}
	}
}
