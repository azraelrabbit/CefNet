﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_extension_handler_t.cs
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
	sealed partial class CefExtensionHandlerGlue: CefExtensionHandler, ICefExtensionHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefExtensionHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefExtensionHandlerPrivate.AvoidOnExtensionLoadFailed()
		{
			return _implementation.AvoidOnExtensionLoadFailed();
		}

		public override void OnExtensionLoadFailed(CefErrorCode result)
		{
			_implementation.OnExtensionLoadFailed(result);
		}

		bool ICefExtensionHandlerPrivate.AvoidOnExtensionLoaded()
		{
			return _implementation.AvoidOnExtensionLoaded();
		}

		public override void OnExtensionLoaded(CefExtension extension)
		{
			_implementation.OnExtensionLoaded(extension);
		}

		bool ICefExtensionHandlerPrivate.AvoidOnExtensionUnloaded()
		{
			return _implementation.AvoidOnExtensionUnloaded();
		}

		public override void OnExtensionUnloaded(CefExtension extension)
		{
			_implementation.OnExtensionUnloaded(extension);
		}

		bool ICefExtensionHandlerPrivate.AvoidOnBeforeBackgroundBrowser()
		{
			return _implementation.AvoidOnBeforeBackgroundBrowser();
		}

		public override bool OnBeforeBackgroundBrowser(CefExtension extension, string url, ref CefClient client, CefBrowserSettings settings)
		{
			return _implementation.OnBeforeBackgroundBrowser(extension, url, ref client, settings);
		}

		bool ICefExtensionHandlerPrivate.AvoidOnBeforeBrowser()
		{
			return _implementation.AvoidOnBeforeBrowser();
		}

		public override bool OnBeforeBrowser(CefExtension extension, CefBrowser browser, CefBrowser activeBrowser, int index, string url, bool active, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings)
		{
			return _implementation.OnBeforeBrowser(extension, browser, activeBrowser, index, url, active, windowInfo, ref client, settings);
		}

		bool ICefExtensionHandlerPrivate.AvoidGetActiveBrowser()
		{
			return _implementation.AvoidGetActiveBrowser();
		}

		public override CefBrowser GetActiveBrowser(CefExtension extension, CefBrowser browser, bool includeIncognito)
		{
			return _implementation.GetActiveBrowser(extension, browser, includeIncognito);
		}

		bool ICefExtensionHandlerPrivate.AvoidCanAccessBrowser()
		{
			return _implementation.AvoidCanAccessBrowser();
		}

		public override bool CanAccessBrowser(CefExtension extension, CefBrowser browser, bool includeIncognito, CefBrowser targetBrowser)
		{
			return _implementation.CanAccessBrowser(extension, browser, includeIncognito, targetBrowser);
		}

		bool ICefExtensionHandlerPrivate.AvoidGetExtensionResource()
		{
			return _implementation.AvoidGetExtensionResource();
		}

		public override bool GetExtensionResource(CefExtension extension, CefBrowser browser, string file, CefGetExtensionResourceCallback callback)
		{
			return _implementation.GetExtensionResource(extension, browser, file, callback);
		}

	}
}
