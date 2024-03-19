using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NoneAPIErrorZ : CommonBase {
	Result_NoneAPIErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NoneAPIErrorZ() {
		if (ptr != 0) { Bindings.CResultNoneAPIErrorZFree(ptr); }
	}

	internal static Result_NoneAPIErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultNoneAPIErrorZIsOk(ptr)) {
			return new Result_NoneAPIErrorZ_OK(null, ptr);
		} else {
			return new Result_NoneAPIErrorZ_Err(null, ptr);
		}
	}
	public class Result_NoneAPIErrorZ_OK : Result_NoneAPIErrorZ {
		internal Result_NoneAPIErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NoneAPIErrorZ_Err : Result_NoneAPIErrorZ {
		public readonly APIError err;
		internal Result_NoneAPIErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultNoneAPIErrorZGetErr(ptr);
			org.ldk.structs.APIError err_hu_conv = org.ldk.structs.APIError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NoneAPIErrorZ in the success state.
	 */
	public static Result_NoneAPIErrorZ ok() {
		long ret = Bindings.CResultNoneAPIErrorZOk();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneAPIErrorZ in the error state.
	 */
	public static Result_NoneAPIErrorZ err(org.ldk.structs.APIError e) {
		long ret = Bindings.CResultNoneAPIErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultNoneAPIErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultNoneAPIErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneAPIErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NoneAPIErrorZ clone() {
		long ret = Bindings.CResultNoneAPIErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneAPIErrorZ ret_hu_conv = Result_NoneAPIErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
