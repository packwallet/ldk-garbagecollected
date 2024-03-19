using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_BigSizeDecodeErrorZ : CommonBase {
	Result_BigSizeDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_BigSizeDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultBigSizeDecodeErrorZFree(ptr); }
	}

	internal static Result_BigSizeDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBigSizeDecodeErrorZIsOk(ptr)) {
			return new Result_BigSizeDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_BigSizeDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_BigSizeDecodeErrorZ_OK : Result_BigSizeDecodeErrorZ {
		public readonly BigSize res;
		internal Result_BigSizeDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultBigSizeDecodeErrorZGetOk(ptr);
			org.ldk.structs.BigSize res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.BigSize(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_BigSizeDecodeErrorZ_Err : Result_BigSizeDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_BigSizeDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBigSizeDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_BigSizeDecodeErrorZ in the success state.
	 */
	public static Result_BigSizeDecodeErrorZ ok(org.ldk.structs.BigSize o) {
		long ret = Bindings.CResultBigSizeDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BigSizeDecodeErrorZ ret_hu_conv = Result_BigSizeDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_BigSizeDecodeErrorZ in the error state.
	 */
	public static Result_BigSizeDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultBigSizeDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BigSizeDecodeErrorZ ret_hu_conv = Result_BigSizeDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBigSizeDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBigSizeDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BigSizeDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_BigSizeDecodeErrorZ clone() {
		long ret = Bindings.CResultBigSizeDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BigSizeDecodeErrorZ ret_hu_conv = Result_BigSizeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
