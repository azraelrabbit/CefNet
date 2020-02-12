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
	/// DOM event category flags.
	/// </summary>
	public enum CefDOMEventCategory
	{
		Unknown = 0x0,

		UI = 0x1,

		Mouse = 0x2,

		Mutation = 0x4,

		Keyboard = 0x8,

		Text = 0x10,

		Composition = 0x20,

		Drag = 0x40,

		Clipboard = 0x80,

		Message = 0x100,

		Wheel = 0x200,

		BeforeTextInserted = 0x400,

		Overflow = 0x800,

		PageTransition = 0x1000,

		Popstate = 0x2000,

		Progress = 0x4000,

		XmlhttprequestProgress = 0x8000,
	}
}

