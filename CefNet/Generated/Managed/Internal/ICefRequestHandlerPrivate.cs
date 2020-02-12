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

namespace CefNet.Internal
{
	public interface ICefRequestHandlerPrivate
	{
		bool AvoidOnBeforeBrowse();
		bool AvoidOnOpenUrlFromTab();
		bool AvoidGetResourceRequestHandler();
		bool AvoidGetAuthCredentials();
		bool AvoidOnQuotaRequest();
		bool AvoidOnCertificateError();
		bool AvoidOnSelectClientCertificate();
		bool AvoidOnPluginCrashed();
		bool AvoidOnRenderViewReady();
		bool AvoidOnRenderProcessTerminated();
	}
}
