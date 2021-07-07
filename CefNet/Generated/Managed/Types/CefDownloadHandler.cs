﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_download_handler_t.cs
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
	/// Structure used to handle file downloads. The functions of this structure will
	/// called on the browser process UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefDownloadHandler : CefBaseRefCounted<cef_download_handler_t>, ICefDownloadHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnBeforeDownloadDelegate fnOnBeforeDownload = OnBeforeDownloadImpl;

		private static readonly OnDownloadUpdatedDelegate fnOnDownloadUpdated = OnDownloadUpdatedImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefDownloadHandler Create(IntPtr instance)
		{
			return new CefDownloadHandler((cef_download_handler_t*)instance);
		}

		public CefDownloadHandler()
		{
			cef_download_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_before_download = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforeDownload);
			self->on_download_updated = (void*)Marshal.GetFunctionPointerForDelegate(fnOnDownloadUpdated);
			#else
			self->on_before_download = (delegate* unmanaged[Stdcall]<cef_download_handler_t*, cef_browser_t*, cef_download_item_t*, cef_string_t*, cef_before_download_callback_t*, void>)&OnBeforeDownloadImpl;
			self->on_download_updated = (delegate* unmanaged[Stdcall]<cef_download_handler_t*, cef_browser_t*, cef_download_item_t*, cef_download_item_callback_t*, void>)&OnDownloadUpdatedImpl;
			#endif
		}

		public CefDownloadHandler(cef_download_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDownloadHandlerPrivate.AvoidOnBeforeDownload();

		/// <summary>
		/// Called before a download begins. |suggested_name| is the suggested name for
		/// the download file. By default the download will be canceled. Execute
		/// |callback| either asynchronously or in this function to continue the
		/// download if desired. Do not keep a reference to |download_item| outside of
		/// this function.
		/// </summary>
		protected internal unsafe virtual void OnBeforeDownload(CefBrowser browser, CefDownloadItem downloadItem, string suggestedName, CefBeforeDownloadCallback callback)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnBeforeDownloadDelegate(cef_download_handler_t* self, cef_browser_t* browser, cef_download_item_t* download_item, cef_string_t* suggested_name, cef_before_download_callback_t* callback);

#endif // NET_LESS_5_0
		// void (*)(_cef_download_handler_t* self, _cef_browser_t* browser, _cef_download_item_t* download_item, const cef_string_t* suggested_name, _cef_before_download_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnBeforeDownloadImpl(cef_download_handler_t* self, cef_browser_t* browser, cef_download_item_t* download_item, cef_string_t* suggested_name, cef_before_download_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefDownloadHandler;
			if (instance == null || ((ICefDownloadHandlerPrivate)instance).AvoidOnBeforeDownload())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)download_item);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return;
			}
			instance.OnBeforeDownload(CefBrowser.Wrap(CefBrowser.Create, browser), CefDownloadItem.Wrap(CefDownloadItem.Create, download_item), CefString.Read(suggested_name), CefBeforeDownloadCallback.Wrap(CefBeforeDownloadCallback.Create, callback));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDownloadHandlerPrivate.AvoidOnDownloadUpdated();

		/// <summary>
		/// Called when a download&apos;s status or progress information has been updated.
		/// This may be called multiple times before and after on_before_download().
		/// Execute |callback| either asynchronously or in this function to cancel the
		/// download if desired. Do not keep a reference to |download_item| outside of
		/// this function.
		/// </summary>
		protected internal unsafe virtual void OnDownloadUpdated(CefBrowser browser, CefDownloadItem downloadItem, CefDownloadItemCallback callback)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnDownloadUpdatedDelegate(cef_download_handler_t* self, cef_browser_t* browser, cef_download_item_t* download_item, cef_download_item_callback_t* callback);

#endif // NET_LESS_5_0
		// void (*)(_cef_download_handler_t* self, _cef_browser_t* browser, _cef_download_item_t* download_item, _cef_download_item_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnDownloadUpdatedImpl(cef_download_handler_t* self, cef_browser_t* browser, cef_download_item_t* download_item, cef_download_item_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefDownloadHandler;
			if (instance == null || ((ICefDownloadHandlerPrivate)instance).AvoidOnDownloadUpdated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)download_item);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return;
			}
			instance.OnDownloadUpdated(CefBrowser.Wrap(CefBrowser.Create, browser), CefDownloadItem.Wrap(CefDownloadItem.Create, download_item), CefDownloadItemCallback.Wrap(CefDownloadItemCallback.Create, callback));
		}
	}
}
