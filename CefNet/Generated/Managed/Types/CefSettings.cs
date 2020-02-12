﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_settings_t.cs
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
	/// Initialization settings. Specify NULL or 0 to get the recommended default
	/// values. Many of these and other settings can also configured using command-
	/// line switches.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefSettings : IDisposable
	{
		private cef_settings_t* _instance;

		private readonly bool _disposable;

		public CefSettings()
		{
			_disposable = true;
			_instance = (cef_settings_t*)CefStructure.Allocate(sizeof(cef_settings_t));
			_instance->size = new UIntPtr((uint)sizeof(cef_settings_t));
		}

		internal static unsafe CefSettings Create(IntPtr instance)
		{
			return new CefSettings((cef_settings_t*)instance);
		}

		public CefSettings(cef_settings_t* instance)
		{
			_instance = instance;
		}

		public cef_settings_t* NativeInstance
		{
			get
			{
				return _instance;
			}
		}

		public cef_settings_t* GetNativeInstance()
		{
			return _instance;
		}

		/// <summary>
		/// Size of this structure.
		/// </summary>
		public long Size
		{
			get
			{
				return (long)(_instance->size);
			}
			set
			{
				_instance->size = new UIntPtr((ulong)value);
			}
		}

		/// <summary>
		/// Set to true (1) to disable the sandbox for sub-processes. See
		/// cef_sandbox_win.h for requirements to enable the sandbox on Windows. Also
		/// configurable using the &quot;no-sandbox&quot; command-line switch.
		/// </summary>
		public bool NoSandbox
		{
			get
			{
				return _instance->no_sandbox != 0;
			}
			set
			{
				_instance->no_sandbox = value ? 1 : 0;
			}
		}

		/// <summary>
		/// The path to a separate executable that will be launched for sub-processes.
		/// If this value is empty on Windows or Linux then the main process executable
		/// will be used. If this value is empty on macOS then a helper executable must
		/// exist at &quot;Contents/Frameworks/
		/// &lt;app
		/// &gt; Helper.app/Contents/MacOS/
		/// &lt;app
		/// &gt; Helper&quot;
		/// in the top-level app bundle. See the comments on CefExecuteProcess() for
		/// details. Also configurable using the &quot;browser-subprocess-path&quot; command-line
		/// switch.
		/// </summary>
		public string BrowserSubprocessPath
		{
			get
			{
				return CefString.Read(&_instance->browser_subprocess_path);
			}
			set
			{
				CefString.Replace(&_instance->browser_subprocess_path, value);
			}
		}

		/// <summary>
		/// The path to the CEF framework directory on macOS. If this value is empty
		/// then the framework must exist at &quot;Contents/Frameworks/Chromium Embedded
		/// Framework.framework&quot; in the top-level app bundle. Also configurable using
		/// the &quot;framework-dir-path&quot; command-line switch.
		/// </summary>
		public string FrameworkDirPath
		{
			get
			{
				return CefString.Read(&_instance->framework_dir_path);
			}
			set
			{
				CefString.Replace(&_instance->framework_dir_path, value);
			}
		}

		/// <summary>
		/// The path to the main bundle on macOS. If this value is empty then it
		/// defaults to the top-level app bundle. Also configurable using
		/// the &quot;main-bundle-path&quot; command-line switch.
		/// </summary>
		public string MainBundlePath
		{
			get
			{
				return CefString.Read(&_instance->main_bundle_path);
			}
			set
			{
				CefString.Replace(&_instance->main_bundle_path, value);
			}
		}

		/// <summary>
		/// Set to true (1) to have the browser process message loop run in a separate
		/// thread. If false (0) than the CefDoMessageLoopWork() function must be
		/// called from your application message loop. This option is only supported on
		/// Windows and Linux.
		/// </summary>
		public bool MultiThreadedMessageLoop
		{
			get
			{
				return _instance->multi_threaded_message_loop != 0;
			}
			set
			{
				_instance->multi_threaded_message_loop = value ? 1 : 0;
			}
		}

		/// <summary>
		/// Set to true (1) to control browser process main (UI) thread message pump
		/// scheduling via the CefBrowserProcessHandler::OnScheduleMessagePumpWork()
		/// callback. This option is recommended for use in combination with the
		/// CefDoMessageLoopWork() function in cases where the CEF message loop must be
		/// integrated into an existing application message loop (see additional
		/// comments and warnings on CefDoMessageLoopWork). Enabling this option is not
		/// recommended for most users; leave this option disabled and use either the
		/// CefRunMessageLoop() function or multi_threaded_message_loop if possible.
		/// </summary>
		public bool ExternalMessagePump
		{
			get
			{
				return _instance->external_message_pump != 0;
			}
			set
			{
				_instance->external_message_pump = value ? 1 : 0;
			}
		}

		/// <summary>
		/// Set to true (1) to enable windowless (off-screen) rendering support. Do not
		/// enable this value if the application does not use windowless rendering as
		/// it may reduce rendering performance on some systems.
		/// </summary>
		public bool WindowlessRenderingEnabled
		{
			get
			{
				return _instance->windowless_rendering_enabled != 0;
			}
			set
			{
				_instance->windowless_rendering_enabled = value ? 1 : 0;
			}
		}

		/// <summary>
		/// Set to true (1) to disable configuration of browser process features using
		/// standard CEF and Chromium command-line arguments. Configuration can still
		/// be specified using CEF data structures or via the
		/// CefApp::OnBeforeCommandLineProcessing() method.
		/// </summary>
		public bool CommandLineArgsDisabled
		{
			get
			{
				return _instance->command_line_args_disabled != 0;
			}
			set
			{
				_instance->command_line_args_disabled = value ? 1 : 0;
			}
		}

		/// <summary>
		/// The location where data for the global browser cache will be stored on
		/// disk. If non-empty this must be either equal to or a child directory of
		/// CefSettings.root_cache_path. If empty then browsers will be created in
		/// &quot;incognito mode&quot; where in-memory caches are used for storage and no data is
		/// persisted to disk. HTML5 databases such as localStorage will only persist
		/// across sessions if a cache path is specified. Can be overridden for
		/// individual CefRequestContext instances via the
		/// CefRequestContextSettings.cache_path value.
		/// </summary>
		public string CachePath
		{
			get
			{
				return CefString.Read(&_instance->cache_path);
			}
			set
			{
				CefString.Replace(&_instance->cache_path, value);
			}
		}

		/// <summary>
		/// The root directory that all CefSettings.cache_path and
		/// CefRequestContextSettings.cache_path values must have in common. If this
		/// value is empty and CefSettings.cache_path is non-empty then this value will
		/// default to the CefSettings.cache_path value. Failure to set this value
		/// correctly may result in the sandbox blocking read/write access to the
		/// cache_path directory.
		/// </summary>
		public string RootCachePath
		{
			get
			{
				return CefString.Read(&_instance->root_cache_path);
			}
			set
			{
				CefString.Replace(&_instance->root_cache_path, value);
			}
		}

		/// <summary>
		/// The location where user data such as spell checking dictionary files will
		/// be stored on disk. If empty then the default platform-specific user data
		/// directory will be used (&quot;~/.cef_user_data&quot; directory on Linux,
		/// &quot;~/Library/Application Support/CEF/User Data&quot; directory on Mac OS X,
		/// &quot;Local Settings@Application Data@CEF @User Data&quot; directory under the user
		/// profile directory on Windows).
		/// </summary>
		public string UserDataPath
		{
			get
			{
				return CefString.Read(&_instance->user_data_path);
			}
			set
			{
				CefString.Replace(&_instance->user_data_path, value);
			}
		}

		/// <summary>
		/// To persist session cookies (cookies without an expiry date or validity
		/// interval) by default when using the global cookie manager set this value to
		/// true (1). Session cookies are generally intended to be transient and most
		/// Web browsers do not persist them. A |cache_path| value must also be
		/// specified to enable this feature. Also configurable using the
		/// &quot;persist-session-cookies&quot; command-line switch. Can be overridden for
		/// individual CefRequestContext instances via the
		/// CefRequestContextSettings.persist_session_cookies value.
		/// </summary>
		public bool PersistSessionCookies
		{
			get
			{
				return _instance->persist_session_cookies != 0;
			}
			set
			{
				_instance->persist_session_cookies = value ? 1 : 0;
			}
		}

		/// <summary>
		/// To persist user preferences as a JSON file in the cache path directory set
		/// this value to true (1). A |cache_path| value must also be specified
		/// to enable this feature. Also configurable using the
		/// &quot;persist-user-preferences&quot; command-line switch. Can be overridden for
		/// individual CefRequestContext instances via the
		/// CefRequestContextSettings.persist_user_preferences value.
		/// </summary>
		public bool PersistUserPreferences
		{
			get
			{
				return _instance->persist_user_preferences != 0;
			}
			set
			{
				_instance->persist_user_preferences = value ? 1 : 0;
			}
		}

		/// <summary>
		/// Value that will be returned as the User-Agent HTTP header. If empty the
		/// default User-Agent string will be used. Also configurable using the
		/// &quot;user-agent&quot; command-line switch.
		/// </summary>
		public string UserAgent
		{
			get
			{
				return CefString.Read(&_instance->user_agent);
			}
			set
			{
				CefString.Replace(&_instance->user_agent, value);
			}
		}

		/// <summary>
		/// Value that will be inserted as the product portion of the default
		/// User-Agent string. If empty the Chromium product version will be used. If
		/// |userAgent| is specified this value will be ignored. Also configurable
		/// using the &quot;product-version&quot; command-line switch.
		/// </summary>
		public string ProductVersion
		{
			get
			{
				return CefString.Read(&_instance->product_version);
			}
			set
			{
				CefString.Replace(&_instance->product_version, value);
			}
		}

		/// <summary>
		/// The locale string that will be passed to WebKit. If empty the default
		/// locale of &quot;en-US&quot; will be used. This value is ignored on Linux where locale
		/// is determined using environment variable parsing with the precedence order:
		/// LANGUAGE, LC_ALL, LC_MESSAGES and LANG. Also configurable using the &quot;lang&quot;
		/// command-line switch.
		/// </summary>
		public string Locale
		{
			get
			{
				return CefString.Read(&_instance->locale);
			}
			set
			{
				CefString.Replace(&_instance->locale, value);
			}
		}

		/// <summary>
		/// The directory and file name to use for the debug log. If empty a default
		/// log file name and location will be used. On Windows and Linux a &quot;debug.log&quot;
		/// file will be written in the main executable directory. On Mac OS X a
		/// &quot;~/Library/Logs/
		/// &lt;app
		/// name&gt;_debug.log&quot; file will be written where
		/// &lt;app
		/// name&gt;
		/// is the name of the main app executable. Also configurable using the
		/// &quot;log-file&quot; command-line switch.
		/// </summary>
		public string LogFile
		{
			get
			{
				return CefString.Read(&_instance->log_file);
			}
			set
			{
				CefString.Replace(&_instance->log_file, value);
			}
		}

		/// <summary>
		/// The log severity. Only messages of this severity level or higher will be
		/// logged. When set to DISABLE no messages will be written to the log file,
		/// but FATAL messages will still be output to stderr. Also configurable using
		/// the &quot;log-severity&quot; command-line switch with a value of &quot;verbose&quot;, &quot;info&quot;,
		/// &quot;warning&quot;, &quot;error&quot;, &quot;fatal&quot; or &quot;disable&quot;.
		/// </summary>
		public CefLogSeverity LogSeverity
		{
			get
			{
				return _instance->log_severity;
			}
			set
			{
				_instance->log_severity = value;
			}
		}

		/// <summary>
		/// Custom flags that will be used when initializing the V8 JavaScript engine.
		/// The consequences of using custom flags may not be well tested. Also
		/// configurable using the &quot;js-flags&quot; command-line switch.
		/// </summary>
		public string JavascriptFlags
		{
			get
			{
				return CefString.Read(&_instance->javascript_flags);
			}
			set
			{
				CefString.Replace(&_instance->javascript_flags, value);
			}
		}

		/// <summary>
		/// The fully qualified path for the resources directory. If this value is
		/// empty the cef.pak and/or devtools_resources.pak files must be located in
		/// the module directory on Windows/Linux or the app bundle Resources directory
		/// on Mac OS X. Also configurable using the &quot;resources-dir-path&quot; command-line
		/// switch.
		/// </summary>
		public string ResourcesDirPath
		{
			get
			{
				return CefString.Read(&_instance->resources_dir_path);
			}
			set
			{
				CefString.Replace(&_instance->resources_dir_path, value);
			}
		}

		/// <summary>
		/// The fully qualified path for the locales directory. If this value is empty
		/// the locales directory must be located in the module directory. This value
		/// is ignored on Mac OS X where pack files are always loaded from the app
		/// bundle Resources directory. Also configurable using the &quot;locales-dir-path&quot;
		/// command-line switch.
		/// </summary>
		public string LocalesDirPath
		{
			get
			{
				return CefString.Read(&_instance->locales_dir_path);
			}
			set
			{
				CefString.Replace(&_instance->locales_dir_path, value);
			}
		}

		/// <summary>
		/// Set to true (1) to disable loading of pack files for resources and locales.
		/// A resource bundle handler must be provided for the browser and render
		/// processes via CefApp::GetResourceBundleHandler() if loading of pack files
		/// is disabled. Also configurable using the &quot;disable-pack-loading&quot; command-
		/// line switch.
		/// </summary>
		public bool PackLoadingDisabled
		{
			get
			{
				return _instance->pack_loading_disabled != 0;
			}
			set
			{
				_instance->pack_loading_disabled = value ? 1 : 0;
			}
		}

		/// <summary>
		/// Set to a value between 1024 and 65535 to enable remote debugging on the
		/// specified port. For example, if 8080 is specified the remote debugging URL
		/// will be http://localhost:8080. CEF can be remotely debugged from any CEF or
		/// Chrome browser window. Also configurable using the &quot;remote-debugging-port&quot;
		/// command-line switch.
		/// </summary>
		public int RemoteDebuggingPort
		{
			get
			{
				return _instance->remote_debugging_port;
			}
			set
			{
				_instance->remote_debugging_port = value;
			}
		}

		/// <summary>
		/// The number of stack trace frames to capture for uncaught exceptions.
		/// Specify a positive value to enable the CefRenderProcessHandler::
		/// OnUncaughtException() callback. Specify 0 (default value) and
		/// OnUncaughtException() will not be called. Also configurable using the
		/// &quot;uncaught-exception-stack-size&quot; command-line switch.
		/// </summary>
		public int UncaughtExceptionStackSize
		{
			get
			{
				return _instance->uncaught_exception_stack_size;
			}
			set
			{
				_instance->uncaught_exception_stack_size = value;
			}
		}

		/// <summary>
		/// Set to true (1) to ignore errors related to invalid SSL certificates.
		/// Enabling this setting can lead to potential security vulnerabilities like
		/// &quot;man in the middle&quot; attacks. Applications that load content from the
		/// internet should not enable this setting. Also configurable using the
		/// &quot;ignore-certificate-errors&quot; command-line switch. Can be overridden for
		/// individual CefRequestContext instances via the
		/// CefRequestContextSettings.ignore_certificate_errors value.
		/// </summary>
		public bool IgnoreCertificateErrors
		{
			get
			{
				return _instance->ignore_certificate_errors != 0;
			}
			set
			{
				_instance->ignore_certificate_errors = value ? 1 : 0;
			}
		}

		/// <summary>
		/// Background color used for the browser before a document is loaded and when
		/// no document color is specified. The alpha component must be either fully
		/// opaque (0xFF) or fully transparent (0x00). If the alpha component is fully
		/// opaque then the RGB components will be used as the background color. If the
		/// alpha component is fully transparent for a windowed browser then the
		/// default value of opaque white be used. If the alpha component is fully
		/// transparent for a windowless (off-screen) browser then transparent painting
		/// will be enabled.
		/// </summary>
		public CefColor BackgroundColor
		{
			get
			{
				return _instance->background_color;
			}
			set
			{
				_instance->background_color = value;
			}
		}

		/// <summary>
		/// Comma delimited ordered list of language codes without any whitespace that
		/// will be used in the &quot;Accept-Language&quot; HTTP header. May be overridden on a
		/// per-browser basis using the CefBrowserSettings.accept_language_list value.
		/// If both values are empty then &quot;en-US,en&quot; will be used. Can be overridden
		/// for individual CefRequestContext instances via the
		/// CefRequestContextSettings.accept_language_list value.
		/// </summary>
		public string AcceptLanguageList
		{
			get
			{
				return CefString.Read(&_instance->accept_language_list);
			}
			set
			{
				CefString.Replace(&_instance->accept_language_list, value);
			}
		}

		/// <summary>
		/// GUID string used for identifying the application. This is passed to the
		/// system AV function for scanning downloaded files. By default, the GUID
		/// will be an empty string and the file will be treated as an untrusted
		/// file when the GUID is empty.
		/// </summary>
		public string ApplicationClientIdForFileScanning
		{
			get
			{
				return CefString.Read(&_instance->application_client_id_for_file_scanning);
			}
			set
			{
				CefString.Replace(&_instance->application_client_id_for_file_scanning, value);
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_disposable && _instance != null)
			{
				BrowserSubprocessPath = null;
				FrameworkDirPath = null;
				MainBundlePath = null;
				CachePath = null;
				RootCachePath = null;
				UserDataPath = null;
				UserAgent = null;
				ProductVersion = null;
				Locale = null;
				LogFile = null;
				JavascriptFlags = null;
				ResourcesDirPath = null;
				LocalesDirPath = null;
				AcceptLanguageList = null;
				ApplicationClientIdForFileScanning = null;
				Marshal.FreeHGlobal((IntPtr)_instance);
				_instance = null;}
		}

		~CefSettings()
		{
			Dispose(false);
		}
	}
}
