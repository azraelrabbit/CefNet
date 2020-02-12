﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_v8_capi.h
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
	/// Structure representing a V8 stack trace handle. V8 handles can only be
	/// accessed from the thread on which they are created. Valid threads for
	/// creating a V8 handle include the render process main thread (TID_RENDERER)
	/// and WebWorker threads. A task runner for posting tasks on the associated
	/// thread can be retrieved via the cef_v8context_t::get_task_runner() function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_v8stack_trace_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_v8stack_trace_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// Returns true (1) if the underlying handle is valid and it can be accessed
		/// on the current thread. Do not call any other functions if this function
		/// returns false (0).
		/// </summary>
		[NativeName("is_valid")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsValid();

		/// <summary>
		/// int (*)(_cef_v8stack_trace_t* self)*
		/// </summary>
		public void* get_frame_count;

		/// <summary>
		/// Returns the number of stack frames.
		/// </summary>
		[NativeName("get_frame_count")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetFrameCount();

		/// <summary>
		/// _cef_v8stack_frame_t* (*)(_cef_v8stack_trace_t* self, int index)*
		/// </summary>
		public void* get_frame;

		/// <summary>
		/// Returns the stack frame at the specified 0-based index.
		/// </summary>
		[NativeName("get_frame")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8stack_frame_t* GetFrame(int index);
	}
}

