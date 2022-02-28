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
	/// Supported error code values.
	/// </summary>
	public enum CefErrorCode
	{
		/// <summary>
		/// No error.
		/// </summary>
		None = 0,

		IOPending = -1,

		Failed = -2,

		Aborted = -3,

		InvalidArgument = -4,

		InvalidHandle = -5,

		FileNotFound = -6,

		TimedOut = -7,

		FileTooBig = -8,

		Unexpected = -9,

		AccessDenied = -10,

		NotImplemented = -11,

		InsufficientResources = -12,

		OutOfMemory = -13,

		UploadFileChanged = -14,

		SocketNotConnected = -15,

		FileExists = -16,

		FilePathTooLong = -17,

		FileNoSpace = -18,

		FileVirusInfected = -19,

		BlockedByClient = -20,

		NetworkChanged = -21,

		BlockedByAdministrator = -22,

		SocketIsConnected = -23,

		BlockedEnrollmentCheckPending = -24,

		UploadStreamRewindNotSupported = -25,

		ContextShutDown = -26,

		BlockedByResponse = -27,

		CleartextNotPermitted = -29,

		BlockedByCsp = -30,

		H2OrQuicRequired = -31,

		ConnectionClosed = -100,

		ConnectionReset = -101,

		ConnectionRefused = -102,

		ConnectionAborted = -103,

		ConnectionFailed = -104,

		NameNotResolved = -105,

		InternetDisconnected = -106,

		SSLProtocolError = -107,

		AddressInvalid = -108,

		AddressUnreachable = -109,

		SSLClientAuthCertNeeded = -110,

		TunnelConnectionFailed = -111,

		NoSSLVersionsEnabled = -112,

		SSLVersionOrCipherMismatch = -113,

		SSLRenegotiationRequested = -114,

		ProxyAuthUnsupported = -115,

		CertErrorInSSLRenegotiation = -116,

		BadSSLClientAuthCert = -117,

		ConnectionTimedOut = -118,

		HostResolverQueueTooLarge = -119,

		SocksConnectionFailed = -120,

		SocksConnectionHostUnreachable = -121,

		AlpnNegotiationFailed = -122,

		SSLNoRenegotiation = -123,

		WinsockUnexpectedWrittenBytes = -124,

		SSLDecompressionFailureAlert = -125,

		SSLBadRecordMacAlert = -126,

		ProxyAuthRequested = -127,

		ProxyConnectionFailed = -130,

		MandatoryProxyConfigurationFailed = -131,

		PreconnectMaxSocketLimit = -133,

		SSLClientAuthPrivateKeyAccessDenied = -134,

		SSLClientAuthCertNoPrivateKey = -135,

		ProxyCertificateInvalid = -136,

		NameResolutionFailed = -137,

		NetworkAccessDenied = -138,

		TemporarilyThrottled = -139,

		HttpsProxyTunnelResponseRedirect = -140,

		SSLClientAuthSignatureFailed = -141,

		MsgTooBig = -142,

		WsProtocolError = -145,

		AddressInUse = -147,

		SSLHandshakeNotCompleted = -148,

		SSLBadPeerPublicKey = -149,

		SSLPinnedKeyNotInCertChain = -150,

		ClientAuthCertTypeUnsupported = -151,

		SSLDecryptErrorAlert = -153,

		WsThrottleQueueTooLarge = -154,

		SSLServerCertChanged = -156,

		SSLUnrecognizedNameAlert = -159,

		SocketSetReceiveBufferSizeError = -160,

		SocketSetSendBufferSizeError = -161,

		SocketReceiveBufferSizeUnchangeable = -162,

		SocketSendBufferSizeUnchangeable = -163,

		SSLClientAuthCertBadFormat = -164,

		IcannNameCollision = -166,

		SSLServerCertBadFormat = -167,

		CtSthParsingFailed = -168,

		CtSthIncomplete = -169,

		UnableToReuseConnectionForProxyAuth = -170,

		CtConsistencyProofParsingFailed = -171,

		SSLObsoleteCipher = -172,

		WsUpgrade = -173,

		ReadIfReadyNotImplemented = -174,

		NoBufferSpace = -176,

		SSLClientAuthNoCommonAlgorithms = -177,

		EarlyDataRejected = -178,

		WrongVersionOnEarlyData = -179,

		TLS13DowngradeDetected = -180,

		SSLKeyUsageIncompatible = -181,

		InvalidEchConfigList = -182,

		EchNotNegotiated = -183,

		EchFallbackCertificateInvalid = -184,

		CertCommonNameInvalid = -200,

		CertDateInvalid = -201,

		CertAuthorityInvalid = -202,

		CertContainsErrors = -203,

		CertNoRevocationMechanism = -204,

		CertUnableToCheckRevocation = -205,

		CertRevoked = -206,

		CertInvalid = -207,

		CertWeakSignatureAlgorithm = -208,

		CertNonUniqueName = -210,

		CertWeakKey = -211,

		CertNameConstraintViolation = -212,

		CertValidityTooLong = -213,

		CertificateTransparencyRequired = -214,

		CertSymantecLegacy = -215,

		CertKnownInterceptionBlocked = -217,

		CertEnd = -219,

		InvalidUrl = -300,

		DisallowedUrlScheme = -301,

		UnknownUrlScheme = -302,

		InvalidRedirect = -303,

		TooManyRedirects = -310,

		UnsafeRedirect = -311,

		UnsafePort = -312,

		InvalidResponse = -320,

		InvalidChunkedEncoding = -321,

		MethodNotSupported = -322,

		UnexpectedProxyAuth = -323,

		EmptyResponse = -324,

		ResponseHeadersTooBig = -325,

		PacScriptFailed = -327,

		RequestRangeNotSatisfiable = -328,

		MalformedIdentity = -329,

		ContentDecodingFailed = -330,

		NetworkIOSuspended = -331,

		SynReplyNotReceived = -332,

		EncodingConversionFailed = -333,

		UnrecognizedFtpDirectoryListingFormat = -334,

		NoSupportedProxies = -336,

		Http2ProtocolError = -337,

		InvalidAuthCredentials = -338,

		UnsupportedAuthScheme = -339,

		EncodingDetectionFailed = -340,

		MissingAuthCredentials = -341,

		UnexpectedSecurityLibraryStatus = -342,

		MisconfiguredAuthEnvironment = -343,

		UndocumentedSecurityLibraryStatus = -344,

		ResponseBodyTooBigToDrain = -345,

		ResponseHeadersMultipleContentLength = -346,

		IncompleteHttp2Headers = -347,

		PacNotInDhcp = -348,

		ResponseHeadersMultipleContentDisposition = -349,

		ResponseHeadersMultipleLocation = -350,

		Http2ServerRefusedStream = -351,

		Http2PingFailed = -352,

		ContentLengthMismatch = -354,

		IncompleteChunkedEncoding = -355,

		QuicProtocolError = -356,

		ResponseHeadersTruncated = -357,

		QuicHandshakeFailed = -358,

		Http2InadequateTransportSecurity = -360,

		Http2FlowControlError = -361,

		Http2FrameSizeError = -362,

		Http2CompressionError = -363,

		ProxyAuthRequestedWithNoConnection = -364,

		Http11Required = -365,

		ProxyHttp11Required = -366,

		PacScriptTerminated = -367,

		InvalidHttpResponse = -370,

		ContentDecodingInitFailed = -371,

		Http2RstStreamNoErrorReceived = -372,

		Http2PushedStreamNotAvailable = -373,

		Http2ClaimedPushedStreamResetByServer = -374,

		TooManyRetries = -375,

		Http2StreamClosed = -376,

		Http2ClientRefusedStream = -377,

		Http2PushedResponseDoesNotMatch = -378,

		HttpResponseCodeFailure = -379,

		QuicCertRootNotKnown = -380,

		QuicGoawayRequestCanBeRetried = -381,

		CacheMiss = -400,

		CacheReadFailure = -401,

		CacheWriteFailure = -402,

		CacheOperationNotSupported = -403,

		CacheOpenFailure = -404,

		CacheCreateFailure = -405,

		CacheRace = -406,

		CacheChecksumReadFailure = -407,

		CacheChecksumMismatch = -408,

		CacheLockTimeout = -409,

		CacheAuthFailureAfterRead = -410,

		CacheEntryNotSuitable = -411,

		CacheDoomFailure = -412,

		CacheOpenOrCreateFailure = -413,

		InsecureResponse = -501,

		NoPrivateKeyForCert = -502,

		AddUserCertFailed = -503,

		InvalidSignedExchange = -504,

		InvalidWebBundle = -505,

		TrustTokenOperationFailed = -506,

		TrustTokenOperationSuccessWithoutSendingRequest = -507,

		FtpFailed = -601,

		FtpServiceUnavailable = -602,

		FtpTransferAborted = -603,

		FtpFileBusy = -604,

		FtpSyntaxError = -605,

		FtpCommandNotSupported = -606,

		FtpBadCommandSequence = -607,

		Pkcs12ImportBadPassword = -701,

		Pkcs12ImportFailed = -702,

		ImportCaCertNotCa = -703,

		ImportCertAlreadyExists = -704,

		ImportCaCertFailed = -705,

		ImportServerCertFailed = -706,

		Pkcs12ImportInvalidMac = -707,

		Pkcs12ImportInvalidFile = -708,

		Pkcs12ImportUnsupported = -709,

		KeyGenerationFailed = -710,

		PrivateKeyExportFailed = -712,

		SelfSignedCertGenerationFailed = -713,

		CertDatabaseChanged = -714,

		DnsMalformedResponse = -800,

		DnsServerRequiresTcp = -801,

		DnsServerFailed = -802,

		DnsTimedOut = -803,

		DnsCacheMiss = -804,

		DnsSearchEmpty = -805,

		DnsSortError = -806,

		DnsSecureResolverHostnameResolutionFailed = -808,

		DnsNameHttpsOnly = -809,
	}
}

