using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UntrustedStringDecodeErrorZ : CommonBase {
	Result_UntrustedStringDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UntrustedStringDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultUntrustedStringDecodeErrorZFree(ptr); }
	}

	internal static Result_UntrustedStringDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultUntrustedStringDecodeErrorZIsOk(ptr)) {
			return new Result_UntrustedStringDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_UntrustedStringDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_UntrustedStringDecodeErrorZ_OK : Result_UntrustedStringDecodeErrorZ {
		public readonly UntrustedString res;
		internal Result_UntrustedStringDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultUntrustedStringDecodeErrorZGetOk(ptr);
			org.ldk.structs.UntrustedString res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UntrustedString(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UntrustedStringDecodeErrorZ_Err : Result_UntrustedStringDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_UntrustedStringDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultUntrustedStringDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_UntrustedStringDecodeErrorZ in the success state.
	 */
	public static Result_UntrustedStringDecodeErrorZ ok(org.ldk.structs.UntrustedString o) {
		long ret = Bindings.CResultUntrustedStringDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UntrustedStringDecodeErrorZ ret_hu_conv = Result_UntrustedStringDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UntrustedStringDecodeErrorZ in the error state.
	 */
	public static Result_UntrustedStringDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultUntrustedStringDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UntrustedStringDecodeErrorZ ret_hu_conv = Result_UntrustedStringDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultUntrustedStringDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultUntrustedStringDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UntrustedStringDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UntrustedStringDecodeErrorZ clone() {
		long ret = Bindings.CResultUntrustedStringDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UntrustedStringDecodeErrorZ ret_hu_conv = Result_UntrustedStringDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
