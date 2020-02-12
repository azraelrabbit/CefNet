﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_dom_capi.h
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
	/// Structure to implement for visiting the DOM. The functions of this structure
	/// will be called on the render process main thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_domvisitor_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_domvisitor_t* self, _cef_domdocument_t* document)*
		/// </summary>
		public void* visit;

		/// <summary>
		/// Method executed for visiting the DOM. The document object passed to this
		/// function represents a snapshot of the DOM at the time this function is
		/// executed. DOM objects are only valid for the scope of this function. Do not
		/// keep references to or attempt to access any DOM objects outside the scope
		/// of this function.
		/// </summary>
		[NativeName("visit")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Visit(cef_domdocument_t* document);
	}
}

