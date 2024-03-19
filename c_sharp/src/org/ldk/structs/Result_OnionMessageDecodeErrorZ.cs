using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_OnionMessageDecodeErrorZ : CommonBase {
	Result_OnionMessageDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_OnionMessageDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultOnionMessageDecodeErrorZFree(ptr); }
	}

	internal static Result_OnionMessageDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultOnionMessageDecodeErrorZIsOk(ptr)) {
			return new Result_OnionMessageDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OnionMessageDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_OnionMessageDecodeErrorZ_OK : Result_OnionMessageDecodeErrorZ {
		public readonly OnionMessage res;
		internal Result_OnionMessageDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultOnionMessageDecodeErrorZGetOk(ptr);
			org.ldk.structs.OnionMessage res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.OnionMessage(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_OnionMessageDecodeErrorZ_Err : Result_OnionMessageDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_OnionMessageDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultOnionMessageDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OnionMessageDecodeErrorZ in the success state.
	 */
	public static Result_OnionMessageDecodeErrorZ ok(org.ldk.structs.OnionMessage o) {
		long ret = Bindings.CResultOnionMessageDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OnionMessageDecodeErrorZ ret_hu_conv = Result_OnionMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OnionMessageDecodeErrorZ in the error state.
	 */
	public static Result_OnionMessageDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultOnionMessageDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OnionMessageDecodeErrorZ ret_hu_conv = Result_OnionMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultOnionMessageDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultOnionMessageDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_OnionMessageDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_OnionMessageDecodeErrorZ clone() {
		long ret = Bindings.CResultOnionMessageDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OnionMessageDecodeErrorZ ret_hu_conv = Result_OnionMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
