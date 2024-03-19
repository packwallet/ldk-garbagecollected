using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Indicates an error on the client's part (usually some variant of attempting to use too-low or
 * too-high values)
 */
public class APIError : CommonBase {
	protected APIError(object _dummy, long ptr) : base(ptr) { }
	~APIError() {
		if (ptr != 0) { Bindings.APIErrorFree(ptr); }
	}

	internal static APIError constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKAPIErrorTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new APIError_APIMisuseError(ptr);
			case 1: return new APIError_FeeRateTooHigh(ptr);
			case 2: return new APIError_InvalidRoute(ptr);
			case 3: return new APIError_ChannelUnavailable(ptr);
			case 4: return new APIError_MonitorUpdateInProgress(ptr);
			case 5: return new APIError_IncompatibleShutdownScript(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A APIError of type APIMisuseError */
	public class APIError_APIMisuseError : APIError {
		/**
		 * A human-readable error message
		 */
		public string err;
		internal APIError_APIMisuseError(long ptr) : base(null, ptr) {
			long err = Bindings.LDKAPIErrorAPIMisuseErrorGetErr(ptr);
			string err_conv = InternalUtils.DecodeString(err);
			this.err = err_conv;
		}
	}
	/** A APIError of type FeeRateTooHigh */
	public class APIError_FeeRateTooHigh : APIError {
		/**
		 * A human-readable error message
		 */
		public string err;
		/**
		 * The feerate which was too high.
		 */
		public int feerate;
		internal APIError_FeeRateTooHigh(long ptr) : base(null, ptr) {
			long err = Bindings.LDKAPIErrorFeeRateTooHighGetErr(ptr);
			string err_conv = InternalUtils.DecodeString(err);
			this.err = err_conv;
			this.feerate = Bindings.LDKAPIErrorFeeRateTooHighGetFeerate(ptr);
		}
	}
	/** A APIError of type InvalidRoute */
	public class APIError_InvalidRoute : APIError {
		/**
		 * A human-readable error message
		 */
		public string err;
		internal APIError_InvalidRoute(long ptr) : base(null, ptr) {
			long err = Bindings.LDKAPIErrorInvalidRouteGetErr(ptr);
			string err_conv = InternalUtils.DecodeString(err);
			this.err = err_conv;
		}
	}
	/** A APIError of type ChannelUnavailable */
	public class APIError_ChannelUnavailable : APIError {
		/**
		 * A human-readable error message
		 */
		public string err;
		internal APIError_ChannelUnavailable(long ptr) : base(null, ptr) {
			long err = Bindings.LDKAPIErrorChannelUnavailableGetErr(ptr);
			string err_conv = InternalUtils.DecodeString(err);
			this.err = err_conv;
		}
	}
	/** A APIError of type MonitorUpdateInProgress */
	public class APIError_MonitorUpdateInProgress : APIError {
		internal APIError_MonitorUpdateInProgress(long ptr) : base(null, ptr) {
		}
	}
	/** A APIError of type IncompatibleShutdownScript */
	public class APIError_IncompatibleShutdownScript : APIError {
		/**
		 * The incompatible shutdown script.
		 */
		public ShutdownScript script;
		internal APIError_IncompatibleShutdownScript(long ptr) : base(null, ptr) {
			long script = Bindings.LDKAPIErrorIncompatibleShutdownScriptGetScript(ptr);
			org.ldk.structs.ShutdownScript script_hu_conv = null; if (script < 0 || script > 4096) { script_hu_conv = new org.ldk.structs.ShutdownScript(null, script); }
			if (script_hu_conv != null) { script_hu_conv.ptrs_to.AddLast(this); };
			this.script = script_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.APIErrorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the APIError
	 */
	public APIError clone() {
		long ret = Bindings.APIErrorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new APIMisuseError-variant APIError
	 */
	public static APIError apimisuse_error(string err) {
		long ret = Bindings.APIErrorApimisuseError(InternalUtils.EncodeString(err));
		GC.KeepAlive(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FeeRateTooHigh-variant APIError
	 */
	public static APIError fee_rate_too_high(string err, int feerate) {
		long ret = Bindings.APIErrorFeeRateTooHigh(InternalUtils.EncodeString(err), feerate);
		GC.KeepAlive(err);
		GC.KeepAlive(feerate);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidRoute-variant APIError
	 */
	public static APIError invalid_route(string err) {
		long ret = Bindings.APIErrorInvalidRoute(InternalUtils.EncodeString(err));
		GC.KeepAlive(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelUnavailable-variant APIError
	 */
	public static APIError channel_unavailable(string err) {
		long ret = Bindings.APIErrorChannelUnavailable(InternalUtils.EncodeString(err));
		GC.KeepAlive(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new MonitorUpdateInProgress-variant APIError
	 */
	public static APIError monitor_update_in_progress() {
		long ret = Bindings.APIErrorMonitorUpdateInProgress();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new IncompatibleShutdownScript-variant APIError
	 */
	public static APIError incompatible_shutdown_script(org.ldk.structs.ShutdownScript script) {
		long ret = Bindings.APIErrorIncompatibleShutdownScript(script == null ? 0 : script.ptr);
		GC.KeepAlive(script);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.APIError ret_hu_conv = org.ldk.structs.APIError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(script); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two APIErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.APIError b) {
		bool ret = Bindings.APIErrorEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is APIError)) return false;
		return this.eq((APIError)o);
	}
	/**
	 * Serialize the APIError object into a byte array which can be read by APIError_read
	 */
	public byte[] write() {
		long ret = Bindings.APIErrorWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
