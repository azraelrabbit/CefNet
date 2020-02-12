﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_request_callback_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Callback structure used for asynchronous continuation of url requests.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_request_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_request_callback_t* self, int allow)*
		/// </summary>
		public void* cont;

		/// <summary>
		/// Continue the url request. If |allow| is true (1) the request will be
		/// continued. Otherwise, the request will be canceled.
		/// </summary>
		[NativeName("cont")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Continue(int allow);

		/// <summary>
		/// void (*)(_cef_request_callback_t* self)*
		/// </summary>
		public void* cancel;

		/// <summary>
		/// Cancel the url request.
		/// </summary>
		[NativeName("cancel")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Cancel();
	}
}

