using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ThirtyTwoBytesAPIErrorZ : CommonBase {
	Result_ThirtyTwoBytesAPIErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ThirtyTwoBytesAPIErrorZ() {
		if (ptr != 0) { Bindings.CResultThirtyTwoBytesAPIErrorZFree(ptr); }
	}

	internal static Result_ThirtyTwoBytesAPIErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultThirtyTwoBytesAPIErrorZIsOk(ptr)) {
			return new Result_ThirtyTwoBytesAPIErrorZ_OK(null, ptr);
		} else {
			return new Result_ThirtyTwoBytesAPIErrorZ_Err(null, ptr);
		}
	}
	public class Result_ThirtyTwoBytesAPIErrorZ_OK : Result_ThirtyTwoBytesAPIErrorZ {
		public readonly byte[] res;
		internal Result_ThirtyTwoBytesAPIErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultThirtyTwoBytesAPIErrorZGetOk(ptr);
			byte[] res_conv = InternalUtils.DecodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result_ThirtyTwoBytesAPIErrorZ_Err : Result_ThirtyTwoBytesAPIErrorZ {
		public readonly APIError err;
		internal Result_ThirtyTwoBytesAPIErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultThirtyTwoBytesAPIErrorZGetErr(ptr);
			org.ldk.structs.APIError err_hu_conv = org.ldk.structs.APIError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ThirtyTwoBytesAPIErrorZ in the success state.
	 */
	public static Result_ThirtyTwoBytesAPIErrorZ ok(byte[] o) {
		long ret = Bindings.CResultThirtyTwoBytesAPIErrorZOk(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(o, 32)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ThirtyTwoBytesAPIErrorZ ret_hu_conv = Result_ThirtyTwoBytesAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ThirtyTwoBytesAPIErrorZ in the error state.
	 */
	public static Result_ThirtyTwoBytesAPIErrorZ err(org.ldk.structs.APIError e) {
		long ret = Bindings.CResultThirtyTwoBytesAPIErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ThirtyTwoBytesAPIErrorZ ret_hu_conv = Result_ThirtyTwoBytesAPIErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultThirtyTwoBytesAPIErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultThirtyTwoBytesAPIErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ThirtyTwoBytesAPIErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ThirtyTwoBytesAPIErrorZ clone() {
		long ret = Bindings.CResultThirtyTwoBytesAPIErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ThirtyTwoBytesAPIErrorZ ret_hu_conv = Result_ThirtyTwoBytesAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
