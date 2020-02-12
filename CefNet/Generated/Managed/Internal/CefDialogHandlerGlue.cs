﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_dialog_handler_t.cs
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
	sealed partial class CefDialogHandlerGlue: CefDialogHandler, ICefDialogHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefDialogHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefDialogHandlerPrivate.AvoidOnFileDialog()
		{
			return _implementation.AvoidOnFileDialog();
		}

		public override bool OnFileDialog(CefBrowser browser, CefFileDialogMode mode, string title, string defaultFilePath, CefStringList acceptFilters, bool selectedAcceptFilter, CefFileDialogCallback callback)
		{
			return _implementation.OnFileDialog(browser, mode, title, defaultFilePath, acceptFilters, selectedAcceptFilter, callback);
		}

	}
}
