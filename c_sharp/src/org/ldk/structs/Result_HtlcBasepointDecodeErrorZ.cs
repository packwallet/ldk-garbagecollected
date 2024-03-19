using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_HtlcBasepointDecodeErrorZ : CommonBase {
	Result_HtlcBasepointDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_HtlcBasepointDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultHtlcBasepointDecodeErrorZFree(ptr); }
	}

	internal static Result_HtlcBasepointDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultHtlcBasepointDecodeErrorZIsOk(ptr)) {
			return new Result_HtlcBasepointDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_HtlcBasepointDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_HtlcBasepointDecodeErrorZ_OK : Result_HtlcBasepointDecodeErrorZ {
		public readonly HtlcBasepoint res;
		internal Result_HtlcBasepointDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultHtlcBasepointDecodeErrorZGetOk(ptr);
			org.ldk.structs.HtlcBasepoint res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.HtlcBasepoint(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_HtlcBasepointDecodeErrorZ_Err : Result_HtlcBasepointDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_HtlcBasepointDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultHtlcBasepointDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_HtlcBasepointDecodeErrorZ in the success state.
	 */
	public static Result_HtlcBasepointDecodeErrorZ ok(org.ldk.structs.HtlcBasepoint o) {
		long ret = Bindings.CResultHtlcBasepointDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcBasepointDecodeErrorZ ret_hu_conv = Result_HtlcBasepointDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HtlcBasepointDecodeErrorZ in the error state.
	 */
	public static Result_HtlcBasepointDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultHtlcBasepointDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcBasepointDecodeErrorZ ret_hu_conv = Result_HtlcBasepointDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultHtlcBasepointDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultHtlcBasepointDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HtlcBasepointDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_HtlcBasepointDecodeErrorZ clone() {
		long ret = Bindings.CResultHtlcBasepointDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcBasepointDecodeErrorZ ret_hu_conv = Result_HtlcBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
