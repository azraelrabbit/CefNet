﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/internal/cef_types.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet
{
	/// <summary>
	/// Supported context menu edit state bit flags. These constants match their
	/// equivalents in Chromium&apos;s ContextMenuDataEditFlags and should not be
	/// renumbered.
	/// </summary>
	[Flags]
	public enum CefContextMenuEditStateFlags
	{
		None = 0,

		CanUndo = 1 << 0,

		CanRedo = 1 << 1,

		CanCut = 1 << 2,

		CanCopy = 1 << 3,

		CanPaste = 1 << 4,

		CanDelete = 1 << 5,

		CanSelectAll = 1 << 6,

		CanTranslate = 1 << 7,

		CanEditRichly = 1 << 8,
	}
}

