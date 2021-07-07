﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_media_observer_t.cs
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

namespace CefNet
{
	/// <summary>
	/// Implemented by the client to observe MediaRouter events and registered via
	/// cef_media_router_t::AddObserver. The functions of this structure will be
	/// called on the browser process UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefMediaObserver : CefBaseRefCounted<cef_media_observer_t>, ICefMediaObserverPrivate
	{
#if NET_LESS_5_0
		private static readonly OnSinksDelegate fnOnSinks = OnSinksImpl;

		private static readonly OnRoutesDelegate fnOnRoutes = OnRoutesImpl;

		private static readonly OnRouteStateChangedDelegate fnOnRouteStateChanged = OnRouteStateChangedImpl;

		private static readonly OnRouteMessageReceivedDelegate fnOnRouteMessageReceived = OnRouteMessageReceivedImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefMediaObserver Create(IntPtr instance)
		{
			return new CefMediaObserver((cef_media_observer_t*)instance);
		}

		public CefMediaObserver()
		{
			cef_media_observer_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_sinks = (void*)Marshal.GetFunctionPointerForDelegate(fnOnSinks);
			self->on_routes = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRoutes);
			self->on_route_state_changed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRouteStateChanged);
			self->on_route_message_received = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRouteMessageReceived);
			#else
			self->on_sinks = (delegate* unmanaged[Stdcall]<cef_media_observer_t*, UIntPtr, cef_media_sink_t**, void>)&OnSinksImpl;
			self->on_routes = (delegate* unmanaged[Stdcall]<cef_media_observer_t*, UIntPtr, cef_media_route_t**, void>)&OnRoutesImpl;
			self->on_route_state_changed = (delegate* unmanaged[Stdcall]<cef_media_observer_t*, cef_media_route_t*, CefMediaRouteConnectionState, void>)&OnRouteStateChangedImpl;
			self->on_route_message_received = (delegate* unmanaged[Stdcall]<cef_media_observer_t*, cef_media_route_t*, void*, UIntPtr, void>)&OnRouteMessageReceivedImpl;
			#endif
		}

		public CefMediaObserver(cef_media_observer_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMediaObserverPrivate.AvoidOnSinks();

		/// <summary>
		/// The list of available media sinks has changed or
		/// cef_media_router_t::NotifyCurrentSinks was called.
		/// </summary>
		protected internal unsafe virtual void OnSinks(CefMediaSink[] sinks)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnSinksDelegate(cef_media_observer_t* self, UIntPtr sinksCount, cef_media_sink_t** sinks);

#endif // NET_LESS_5_0
		// void (*)(_cef_media_observer_t* self, size_t sinksCount, const _cef_media_sink_t** sinks)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnSinksImpl(cef_media_observer_t* self, UIntPtr sinksCount, cef_media_sink_t** sinks)
		{
			var instance = GetInstance((IntPtr)self) as CefMediaObserver;
			if (instance == null || ((ICefMediaObserverPrivate)instance).AvoidOnSinks())
			{
				return;
			}
			CefMediaSink[] obj_sinks = new CefMediaSink[(int)sinksCount];
			for (int i = 0; i < obj_sinks.Length; i++)
			{
				var item = *(sinks + i);
				item->@base.AddRef();
				obj_sinks[i] = CefMediaSink.Wrap(CefMediaSink.Create, item);
			}
			instance.OnSinks(obj_sinks);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMediaObserverPrivate.AvoidOnRoutes();

		/// <summary>
		/// The list of available media routes has changed or
		/// cef_media_router_t::NotifyCurrentRoutes was called.
		/// </summary>
		protected internal unsafe virtual void OnRoutes(CefMediaRoute[] routes)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRoutesDelegate(cef_media_observer_t* self, UIntPtr routesCount, cef_media_route_t** routes);

#endif // NET_LESS_5_0
		// void (*)(_cef_media_observer_t* self, size_t routesCount, const _cef_media_route_t** routes)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRoutesImpl(cef_media_observer_t* self, UIntPtr routesCount, cef_media_route_t** routes)
		{
			var instance = GetInstance((IntPtr)self) as CefMediaObserver;
			if (instance == null || ((ICefMediaObserverPrivate)instance).AvoidOnRoutes())
			{
				return;
			}
			CefMediaRoute[] obj_routes = new CefMediaRoute[(int)routesCount];
			for (int i = 0; i < obj_routes.Length; i++)
			{
				var item = *(routes + i);
				item->@base.AddRef();
				obj_routes[i] = CefMediaRoute.Wrap(CefMediaRoute.Create, item);
			}
			instance.OnRoutes(obj_routes);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMediaObserverPrivate.AvoidOnRouteStateChanged();

		/// <summary>
		/// The connection state of |route| has changed.
		/// </summary>
		protected internal unsafe virtual void OnRouteStateChanged(CefMediaRoute route, CefMediaRouteConnectionState state)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRouteStateChangedDelegate(cef_media_observer_t* self, cef_media_route_t* route, CefMediaRouteConnectionState state);

#endif // NET_LESS_5_0
		// void (*)(_cef_media_observer_t* self, _cef_media_route_t* route, cef_media_route_connection_state_t state)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRouteStateChangedImpl(cef_media_observer_t* self, cef_media_route_t* route, CefMediaRouteConnectionState state)
		{
			var instance = GetInstance((IntPtr)self) as CefMediaObserver;
			if (instance == null || ((ICefMediaObserverPrivate)instance).AvoidOnRouteStateChanged())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)route);
				return;
			}
			instance.OnRouteStateChanged(CefMediaRoute.Wrap(CefMediaRoute.Create, route), state);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMediaObserverPrivate.AvoidOnRouteMessageReceived();

		/// <summary>
		/// A message was recieved over |route|. |message| is only valid for the scope
		/// of this callback and should be copied if necessary.
		/// </summary>
		protected internal unsafe virtual void OnRouteMessageReceived(CefMediaRoute route, IntPtr message, long messageSize)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRouteMessageReceivedDelegate(cef_media_observer_t* self, cef_media_route_t* route, void* message, UIntPtr message_size);

#endif // NET_LESS_5_0
		// void (*)(_cef_media_observer_t* self, _cef_media_route_t* route, const void* message, size_t message_size)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRouteMessageReceivedImpl(cef_media_observer_t* self, cef_media_route_t* route, void* message, UIntPtr message_size)
		{
			var instance = GetInstance((IntPtr)self) as CefMediaObserver;
			if (instance == null || ((ICefMediaObserverPrivate)instance).AvoidOnRouteMessageReceived())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)route);
				return;
			}
			instance.OnRouteMessageReceived(CefMediaRoute.Wrap(CefMediaRoute.Create, route), unchecked((IntPtr)message), (long)message_size);
		}
	}
}
