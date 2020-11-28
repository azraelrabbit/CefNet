﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_values_capi.h
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
	/// Structure representing a binary value. Can be used on any process and thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_binary_value_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_binary_value_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// Returns true (1) if this object is valid. This object may become invalid if
		/// the underlying data is owned by another object (e.g. list or dictionary)
		/// and that other object is then modified or destroyed. Do not call any other
		/// functions if this function returns false (0).
		/// </summary>
		[NativeName("is_valid")]
		public unsafe int IsValid()
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, int>)is_valid)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_binary_value_t* self)*
		/// </summary>
		public void* is_owned;

		/// <summary>
		/// Returns true (1) if this object is currently owned by another object.
		/// </summary>
		[NativeName("is_owned")]
		public unsafe int IsOwned()
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, int>)is_owned)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_binary_value_t* self, _cef_binary_value_t* that)*
		/// </summary>
		public void* is_same;

		/// <summary>
		/// Returns true (1) if this object and |that| object have the same underlying
		/// data.
		/// </summary>
		[NativeName("is_same")]
		public unsafe int IsSame(cef_binary_value_t* that)
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, cef_binary_value_t*, int>)is_same)(self, that);
			}
		}

		/// <summary>
		/// int (*)(_cef_binary_value_t* self, _cef_binary_value_t* that)*
		/// </summary>
		public void* is_equal;

		/// <summary>
		/// Returns true (1) if this object and |that| object have an equivalent
		/// underlying value but are not necessarily the same object.
		/// </summary>
		[NativeName("is_equal")]
		public unsafe int IsEqual(cef_binary_value_t* that)
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, cef_binary_value_t*, int>)is_equal)(self, that);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_binary_value_t* self)*
		/// </summary>
		public void* copy;

		/// <summary>
		/// Returns a copy of this object. The data in this object will also be copied.
		/// </summary>
		[NativeName("copy")]
		public unsafe cef_binary_value_t* Copy()
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, cef_binary_value_t*>)copy)(self);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_binary_value_t* self)*
		/// </summary>
		public void* get_size;

		/// <summary>
		/// Returns the data size.
		/// </summary>
		[NativeName("get_size")]
		public unsafe UIntPtr GetSize()
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, UIntPtr>)get_size)(self);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_binary_value_t* self, void* buffer, size_t buffer_size, size_t data_offset)*
		/// </summary>
		public void* get_data;

		/// <summary>
		/// Read up to |buffer_size| number of bytes into |buffer|. Reading begins at
		/// the specified byte |data_offset|. Returns the number of bytes read.
		/// </summary>
		[NativeName("get_data")]
		public unsafe UIntPtr GetData(void* buffer, UIntPtr buffer_size, UIntPtr data_offset)
		{
			fixed (cef_binary_value_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_binary_value_t*, void*, UIntPtr, UIntPtr, UIntPtr>)get_data)(self, buffer, buffer_size, data_offset);
			}
		}
	}
}

