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

namespace CefNet.CApi
{
	/// <summary>
	/// URL component parts.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_urlparts_t
	{
		/// <summary>
		/// The complete URL specification.
		/// </summary>
		public cef_string_t spec;

		/// <summary>
		/// Scheme component not including the colon (e.g., &quot;http&quot;).
		/// </summary>
		public cef_string_t scheme;

		/// <summary>
		/// User name component.
		/// </summary>
		public cef_string_t username;

		/// <summary>
		/// Password component.
		/// </summary>
		public cef_string_t password;

		/// <summary>
		/// Host component. This may be a hostname, an IPv4 address or an IPv6 literal
		/// surrounded by square brackets (e.g., &quot;[2001:db8::1]&quot;).
		/// </summary>
		public cef_string_t host;

		/// <summary>
		/// Port number component.
		/// </summary>
		public cef_string_t port;

		/// <summary>
		/// Origin contains just the scheme, host, and port from a URL. Equivalent to
		/// clearing any username and password, replacing the path with a slash, and
		/// clearing everything after that. This value will be empty for non-standard
		/// URLs.
		/// </summary>
		public cef_string_t origin;

		/// <summary>
		/// Path component including the first slash following the host.
		/// </summary>
		public cef_string_t path;

		/// <summary>
		/// Query string component (i.e., everything following the &apos;?&apos;).
		/// </summary>
		public cef_string_t query;
	}
}

