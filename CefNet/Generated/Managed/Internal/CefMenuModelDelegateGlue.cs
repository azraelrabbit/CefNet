﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_menu_model_delegate_t.cs
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
	sealed partial class CefMenuModelDelegateGlue: CefMenuModelDelegate, ICefMenuModelDelegatePrivate
	{
		private WebViewGlue _implementation;

		public CefMenuModelDelegateGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefMenuModelDelegatePrivate.AvoidExecuteCommand()
		{
			return _implementation.AvoidExecuteCommand();
		}

		public override void ExecuteCommand(CefMenuModel menuModel, int commandId, CefEventFlags eventFlags)
		{
			_implementation.ExecuteCommand(menuModel, commandId, eventFlags);
		}

		bool ICefMenuModelDelegatePrivate.AvoidMouseOutsideMenu()
		{
			return _implementation.AvoidMouseOutsideMenu();
		}

		public override void MouseOutsideMenu(CefMenuModel menuModel, CefPoint screenPoint)
		{
			_implementation.MouseOutsideMenu(menuModel, screenPoint);
		}

		bool ICefMenuModelDelegatePrivate.AvoidUnhandledOpenSubmenu()
		{
			return _implementation.AvoidUnhandledOpenSubmenu();
		}

		public override void UnhandledOpenSubmenu(CefMenuModel menuModel, bool isRtl)
		{
			_implementation.UnhandledOpenSubmenu(menuModel, isRtl);
		}

		bool ICefMenuModelDelegatePrivate.AvoidUnhandledCloseSubmenu()
		{
			return _implementation.AvoidUnhandledCloseSubmenu();
		}

		public override void UnhandledCloseSubmenu(CefMenuModel menuModel, bool isRtl)
		{
			_implementation.UnhandledCloseSubmenu(menuModel, isRtl);
		}

		bool ICefMenuModelDelegatePrivate.AvoidMenuWillShow()
		{
			return _implementation.AvoidMenuWillShow();
		}

		public override void MenuWillShow(CefMenuModel menuModel)
		{
			_implementation.MenuWillShow(menuModel);
		}

		bool ICefMenuModelDelegatePrivate.AvoidMenuClosed()
		{
			return _implementation.AvoidMenuClosed();
		}

		public override void MenuClosed(CefMenuModel menuModel)
		{
			_implementation.MenuClosed(menuModel);
		}

		bool ICefMenuModelDelegatePrivate.AvoidFormatLabel()
		{
			return _implementation.AvoidFormatLabel();
		}

		public override bool FormatLabel(CefMenuModel menuModel, ref string label)
		{
			return _implementation.FormatLabel(menuModel, ref label);
		}

	}
}
