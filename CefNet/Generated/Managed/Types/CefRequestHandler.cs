﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_request_handler_t.cs
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
	/// Implement this structure to handle events related to browser requests. The
	/// functions of this structure will be called on the thread indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefRequestHandler : CefBaseRefCounted<cef_request_handler_t>, ICefRequestHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnBeforeBrowseDelegate fnOnBeforeBrowse = OnBeforeBrowseImpl;

		private static readonly OnOpenUrlFromTabDelegate fnOnOpenUrlFromTab = OnOpenUrlFromTabImpl;

		private static readonly GetResourceRequestHandlerDelegate fnGetResourceRequestHandler = GetResourceRequestHandlerImpl;

		private static readonly GetAuthCredentialsDelegate fnGetAuthCredentials = GetAuthCredentialsImpl;

		private static readonly OnQuotaRequestDelegate fnOnQuotaRequest = OnQuotaRequestImpl;

		private static readonly OnCertificateErrorDelegate fnOnCertificateError = OnCertificateErrorImpl;

		private static readonly OnSelectClientCertificateDelegate fnOnSelectClientCertificate = OnSelectClientCertificateImpl;

		private static readonly OnPluginCrashedDelegate fnOnPluginCrashed = OnPluginCrashedImpl;

		private static readonly OnRenderViewReadyDelegate fnOnRenderViewReady = OnRenderViewReadyImpl;

		private static readonly OnRenderProcessTerminatedDelegate fnOnRenderProcessTerminated = OnRenderProcessTerminatedImpl;

		private static readonly OnDocumentAvailableInMainFrameDelegate fnOnDocumentAvailableInMainFrame = OnDocumentAvailableInMainFrameImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefRequestHandler Create(IntPtr instance)
		{
			return new CefRequestHandler((cef_request_handler_t*)instance);
		}

		public CefRequestHandler()
		{
			cef_request_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_before_browse = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforeBrowse);
			self->on_open_urlfrom_tab = (void*)Marshal.GetFunctionPointerForDelegate(fnOnOpenUrlFromTab);
			self->get_resource_request_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetResourceRequestHandler);
			self->get_auth_credentials = (void*)Marshal.GetFunctionPointerForDelegate(fnGetAuthCredentials);
			self->on_quota_request = (void*)Marshal.GetFunctionPointerForDelegate(fnOnQuotaRequest);
			self->on_certificate_error = (void*)Marshal.GetFunctionPointerForDelegate(fnOnCertificateError);
			self->on_select_client_certificate = (void*)Marshal.GetFunctionPointerForDelegate(fnOnSelectClientCertificate);
			self->on_plugin_crashed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnPluginCrashed);
			self->on_render_view_ready = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRenderViewReady);
			self->on_render_process_terminated = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRenderProcessTerminated);
			self->on_document_available_in_main_frame = (void*)Marshal.GetFunctionPointerForDelegate(fnOnDocumentAvailableInMainFrame);
			#else
			self->on_before_browse = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, cef_frame_t*, cef_request_t*, int, int, int>)&OnBeforeBrowseImpl;
			self->on_open_urlfrom_tab = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, cef_frame_t*, cef_string_t*, CefWindowOpenDisposition, int, int>)&OnOpenUrlFromTabImpl;
			self->get_resource_request_handler = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, cef_frame_t*, cef_request_t*, int, int, cef_string_t*, int*, cef_resource_request_handler_t*>)&GetResourceRequestHandlerImpl;
			self->get_auth_credentials = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, cef_string_t*, int, cef_string_t*, int, cef_string_t*, cef_string_t*, cef_auth_callback_t*, int>)&GetAuthCredentialsImpl;
			self->on_quota_request = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, cef_string_t*, long, cef_request_callback_t*, int>)&OnQuotaRequestImpl;
			self->on_certificate_error = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, CefErrorCode, cef_string_t*, cef_sslinfo_t*, cef_request_callback_t*, int>)&OnCertificateErrorImpl;
			self->on_select_client_certificate = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, int, cef_string_t*, int, UIntPtr, cef_x509certificate_t**, cef_select_client_certificate_callback_t*, int>)&OnSelectClientCertificateImpl;
			self->on_plugin_crashed = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, cef_string_t*, void>)&OnPluginCrashedImpl;
			self->on_render_view_ready = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, void>)&OnRenderViewReadyImpl;
			self->on_render_process_terminated = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, CefTerminationStatus, void>)&OnRenderProcessTerminatedImpl;
			self->on_document_available_in_main_frame = (delegate* unmanaged[Stdcall]<cef_request_handler_t*, cef_browser_t*, void>)&OnDocumentAvailableInMainFrameImpl;
			#endif
		}

		public CefRequestHandler(cef_request_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnBeforeBrowse();

		/// <summary>
		/// Called on the UI thread before browser navigation. Return true (1) to
		/// cancel the navigation or false (0) to allow the navigation to proceed. The
		/// |request| object cannot be modified in this callback.
		/// cef_load_handler_t::OnLoadingStateChange will be called twice in all cases.
		/// If the navigation is allowed cef_load_handler_t::OnLoadStart and
		/// cef_load_handler_t::OnLoadEnd will be called. If the navigation is canceled
		/// cef_load_handler_t::OnLoadError will be called with an |errorCode| value of
		/// ERR_ABORTED. The |user_gesture| value will be true (1) if the browser
		/// navigated via explicit user gesture (e.g. clicking a link) or false (0) if
		/// it navigated automatically (e.g. via the DomContentLoaded event).
		/// </summary>
		protected internal unsafe virtual bool OnBeforeBrowse(CefBrowser browser, CefFrame frame, CefRequest request, bool userGesture, bool isRedirect)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnBeforeBrowseDelegate(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int user_gesture, int is_redirect);

#endif // NET_LESS_5_0
		// int (*)(_cef_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, int user_gesture, int is_redirect)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnBeforeBrowseImpl(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int user_gesture, int is_redirect)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnBeforeBrowse())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return default;
			}
			return instance.OnBeforeBrowse(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), user_gesture != 0, is_redirect != 0) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnOpenUrlFromTab();

		/// <summary>
		/// Called on the UI thread before OnBeforeBrowse in certain limited cases
		/// where navigating a new or different browser might be desirable. This
		/// includes user-initiated navigation that might open in a special way (e.g.
		/// links clicked via middle-click or ctrl + left-click) and certain types of
		/// cross-origin navigation initiated from the renderer process (e.g.
		/// navigating the top-level frame to/from a file URL). The |browser| and
		/// |frame| values represent the source of the navigation. The
		/// |target_disposition| value indicates where the user intended to navigate
		/// the browser based on standard Chromium behaviors (e.g. current tab, new
		/// tab, etc). The |user_gesture| value will be true (1) if the browser
		/// navigated via explicit user gesture (e.g. clicking a link) or false (0) if
		/// it navigated automatically (e.g. via the DomContentLoaded event). Return
		/// true (1) to cancel the navigation or false (0) to allow the navigation to
		/// proceed in the source browser&apos;s top-level frame.
		/// </summary>
		protected internal unsafe virtual bool OnOpenUrlFromTab(CefBrowser browser, CefFrame frame, string targetUrl, CefWindowOpenDisposition targetDisposition, bool userGesture)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnOpenUrlFromTabDelegate(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, CefWindowOpenDisposition target_disposition, int user_gesture);

#endif // NET_LESS_5_0
		// int (*)(_cef_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, const cef_string_t* target_url, cef_window_open_disposition_t target_disposition, int user_gesture)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnOpenUrlFromTabImpl(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, CefWindowOpenDisposition target_disposition, int user_gesture)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnOpenUrlFromTab())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return default;
			}
			return instance.OnOpenUrlFromTab(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefString.Read(target_url), target_disposition, user_gesture != 0) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidGetResourceRequestHandler();

		/// <summary>
		/// Called on the browser process IO thread before a resource request is
		/// initiated. The |browser| and |frame| values represent the source of the
		/// request. |request| represents the request contents and cannot be modified
		/// in this callback. |is_navigation| will be true (1) if the resource request
		/// is a navigation. |is_download| will be true (1) if the resource request is
		/// a download. |request_initiator| is the origin (scheme + domain) of the page
		/// that initiated the request. Set |disable_default_handling| to true (1) to
		/// disable default handling of the request, in which case it will need to be
		/// handled via cef_resource_request_handler_t::GetResourceHandler or it will
		/// be canceled. To allow the resource load to proceed with default handling
		/// return NULL. To specify a handler for the resource return a
		/// cef_resource_request_handler_t object. If this callback returns NULL the
		/// same function will be called on the associated
		/// cef_request_context_handler_t, if any.
		/// </summary>
		protected internal unsafe virtual CefResourceRequestHandler GetResourceRequestHandler(CefBrowser browser, CefFrame frame, CefRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref int disableDefaultHandling)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_resource_request_handler_t* GetResourceRequestHandlerDelegate(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling);

#endif // NET_LESS_5_0
		// _cef_resource_request_handler_t* (*)(_cef_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, int is_navigation, int is_download, const cef_string_t* request_initiator, int* disable_default_handling)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe cef_resource_request_handler_t* GetResourceRequestHandlerImpl(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidGetResourceRequestHandler())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return default;
			}
			CefResourceRequestHandler rv = instance.GetResourceRequestHandler(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), is_navigation != 0, is_download != 0, CefString.Read(request_initiator), ref *disable_default_handling);
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidGetAuthCredentials();

		/// <summary>
		/// Called on the IO thread when the browser needs credentials from the user.
		/// |origin_url| is the origin making this authentication request. |isProxy|
		/// indicates whether the host is a proxy server. |host| contains the hostname
		/// and |port| contains the port number. |realm| is the realm of the challenge
		/// and may be NULL. |scheme| is the authentication scheme used, such as
		/// &quot;basic&quot; or &quot;digest&quot;, and will be NULL if the source of the request is an
		/// FTP server. Return true (1) to continue the request and call
		/// cef_auth_callback_t::cont() either in this function or at a later time when
		/// the authentication information is available. Return false (0) to cancel the
		/// request immediately.
		/// </summary>
		protected internal unsafe virtual bool GetAuthCredentials(CefBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, CefAuthCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int GetAuthCredentialsDelegate(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_request_handler_t* self, _cef_browser_t* browser, const cef_string_t* origin_url, int isProxy, const cef_string_t* host, int port, const cef_string_t* realm, const cef_string_t* scheme, _cef_auth_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int GetAuthCredentialsImpl(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidGetAuthCredentials())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.GetAuthCredentials(CefBrowser.Wrap(CefBrowser.Create, browser), CefString.Read(origin_url), isProxy != 0, CefString.Read(host), port, CefString.Read(realm), CefString.Read(scheme), CefAuthCallback.Wrap(CefAuthCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnQuotaRequest();

		/// <summary>
		/// Called on the IO thread when JavaScript requests a specific storage quota
		/// size via the webkitStorageInfo.requestQuota function. |origin_url| is the
		/// origin of the page making the request. |new_size| is the requested quota
		/// size in bytes. Return true (1) to continue the request and call
		/// cef_request_callback_t::cont() either in this function or at a later time
		/// to grant or deny the request. Return false (0) to cancel the request
		/// immediately.
		/// </summary>
		protected internal unsafe virtual bool OnQuotaRequest(CefBrowser browser, string originUrl, long newSize, CefRequestCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnQuotaRequestDelegate(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, long new_size, cef_request_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_request_handler_t* self, _cef_browser_t* browser, const cef_string_t* origin_url, int64 new_size, _cef_request_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnQuotaRequestImpl(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, long new_size, cef_request_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnQuotaRequest())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.OnQuotaRequest(CefBrowser.Wrap(CefBrowser.Create, browser), CefString.Read(origin_url), new_size, CefRequestCallback.Wrap(CefRequestCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnCertificateError();

		/// <summary>
		/// Called on the UI thread to handle requests for URLs with an invalid SSL
		/// certificate. Return true (1) and call cef_request_callback_t::cont() either
		/// in this function or at a later time to continue or cancel the request.
		/// Return false (0) to cancel the request immediately. If
		/// CefSettings.ignore_certificate_errors is set all invalid certificates will
		/// be accepted without calling this function.
		/// </summary>
		protected internal unsafe virtual bool OnCertificateError(CefBrowser browser, CefErrorCode certError, string requestUrl, CefSSLInfo sSLInfo, CefRequestCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnCertificateErrorDelegate(cef_request_handler_t* self, cef_browser_t* browser, CefErrorCode cert_error, cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_request_handler_t* self, _cef_browser_t* browser, cef_errorcode_t cert_error, const cef_string_t* request_url, _cef_sslinfo_t* ssl_info, _cef_request_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnCertificateErrorImpl(cef_request_handler_t* self, cef_browser_t* browser, CefErrorCode cert_error, cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnCertificateError())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)ssl_info);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.OnCertificateError(CefBrowser.Wrap(CefBrowser.Create, browser), cert_error, CefString.Read(request_url), CefSSLInfo.Wrap(CefSSLInfo.Create, ssl_info), CefRequestCallback.Wrap(CefRequestCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnSelectClientCertificate();

		/// <summary>
		/// Called on the UI thread when a client certificate is being requested for
		/// authentication. Return false (0) to use the default behavior and
		/// automatically select the first certificate available. Return true (1) and
		/// call cef_select_client_certificate_callback_t::Select either in this
		/// function or at a later time to select a certificate. Do not call Select or
		/// call it with NULL to continue without using any certificate. |isProxy|
		/// indicates whether the host is an HTTPS proxy or the origin server. |host|
		/// and |port| contains the hostname and port of the SSL server. |certificates|
		/// is the list of certificates to choose from; this list has already been
		/// pruned by Chromium so that it only contains certificates from issuers that
		/// the server trusts.
		/// </summary>
		protected internal unsafe virtual bool OnSelectClientCertificate(CefBrowser browser, bool isProxy, string host, int port, CefX509Certificate[] certificates, CefSelectClientCertificateCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnSelectClientCertificateDelegate(cef_request_handler_t* self, cef_browser_t* browser, int isProxy, cef_string_t* host, int port, UIntPtr certificatesCount, cef_x509certificate_t** certificates, cef_select_client_certificate_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_request_handler_t* self, _cef_browser_t* browser, int isProxy, const cef_string_t* host, int port, size_t certificatesCount, const _cef_x509certificate_t** certificates, _cef_select_client_certificate_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnSelectClientCertificateImpl(cef_request_handler_t* self, cef_browser_t* browser, int isProxy, cef_string_t* host, int port, UIntPtr certificatesCount, cef_x509certificate_t** certificates, cef_select_client_certificate_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnSelectClientCertificate())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			CefX509Certificate[] obj_certificates = new CefX509Certificate[(int)certificatesCount];
			for (int i = 0; i < obj_certificates.Length; i++)
			{
				var item = *(certificates + i);
				item->@base.AddRef();
				obj_certificates[i] = CefX509Certificate.Wrap(CefX509Certificate.Create, item);
			}
			return instance.OnSelectClientCertificate(CefBrowser.Wrap(CefBrowser.Create, browser), isProxy != 0, CefString.Read(host), port, obj_certificates, CefSelectClientCertificateCallback.Wrap(CefSelectClientCertificateCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnPluginCrashed();

		/// <summary>
		/// Called on the browser process UI thread when a plugin has crashed.
		/// |plugin_path| is the path of the plugin that crashed.
		/// </summary>
		protected internal unsafe virtual void OnPluginCrashed(CefBrowser browser, string pluginPath)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnPluginCrashedDelegate(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* plugin_path);

#endif // NET_LESS_5_0
		// void (*)(_cef_request_handler_t* self, _cef_browser_t* browser, const cef_string_t* plugin_path)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnPluginCrashedImpl(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* plugin_path)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnPluginCrashed())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnPluginCrashed(CefBrowser.Wrap(CefBrowser.Create, browser), CefString.Read(plugin_path));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnRenderViewReady();

		/// <summary>
		/// Called on the browser process UI thread when the render view associated
		/// with |browser| is ready to receive/handle IPC messages in the render
		/// process.
		/// </summary>
		protected internal unsafe virtual void OnRenderViewReady(CefBrowser browser)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRenderViewReadyDelegate(cef_request_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// void (*)(_cef_request_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRenderViewReadyImpl(cef_request_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnRenderViewReady())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnRenderViewReady(CefBrowser.Wrap(CefBrowser.Create, browser));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnRenderProcessTerminated();

		/// <summary>
		/// Called on the browser process UI thread when the render process terminates
		/// unexpectedly. |status| indicates how the process terminated.
		/// </summary>
		protected internal unsafe virtual void OnRenderProcessTerminated(CefBrowser browser, CefTerminationStatus status)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRenderProcessTerminatedDelegate(cef_request_handler_t* self, cef_browser_t* browser, CefTerminationStatus status);

#endif // NET_LESS_5_0
		// void (*)(_cef_request_handler_t* self, _cef_browser_t* browser, cef_termination_status_t status)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRenderProcessTerminatedImpl(cef_request_handler_t* self, cef_browser_t* browser, CefTerminationStatus status)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnRenderProcessTerminated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnRenderProcessTerminated(CefBrowser.Wrap(CefBrowser.Create, browser), status);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestHandlerPrivate.AvoidOnDocumentAvailableInMainFrame();

		/// <summary>
		/// Called on the browser process UI thread when the window.document object of
		/// the main frame has been created.
		/// </summary>
		protected internal unsafe virtual void OnDocumentAvailableInMainFrame(CefBrowser browser)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnDocumentAvailableInMainFrameDelegate(cef_request_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// void (*)(_cef_request_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnDocumentAvailableInMainFrameImpl(cef_request_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestHandler;
			if (instance == null || ((ICefRequestHandlerPrivate)instance).AvoidOnDocumentAvailableInMainFrame())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnDocumentAvailableInMainFrame(CefBrowser.Wrap(CefBrowser.Create, browser));
		}
	}
}
