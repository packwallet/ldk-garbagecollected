using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_DelayedPaymentBasepointDecodeErrorZ : CommonBase {
	Result_DelayedPaymentBasepointDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_DelayedPaymentBasepointDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultDelayedPaymentBasepointDecodeErrorZFree(ptr); }
	}

	internal static Result_DelayedPaymentBasepointDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultDelayedPaymentBasepointDecodeErrorZIsOk(ptr)) {
			return new Result_DelayedPaymentBasepointDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_DelayedPaymentBasepointDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_DelayedPaymentBasepointDecodeErrorZ_OK : Result_DelayedPaymentBasepointDecodeErrorZ {
		public readonly DelayedPaymentBasepoint res;
		internal Result_DelayedPaymentBasepointDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultDelayedPaymentBasepointDecodeErrorZGetOk(ptr);
			org.ldk.structs.DelayedPaymentBasepoint res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.DelayedPaymentBasepoint(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_DelayedPaymentBasepointDecodeErrorZ_Err : Result_DelayedPaymentBasepointDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_DelayedPaymentBasepointDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultDelayedPaymentBasepointDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_DelayedPaymentBasepointDecodeErrorZ in the success state.
	 */
	public static Result_DelayedPaymentBasepointDecodeErrorZ ok(org.ldk.structs.DelayedPaymentBasepoint o) {
		long ret = Bindings.CResultDelayedPaymentBasepointDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_DelayedPaymentBasepointDecodeErrorZ in the error state.
	 */
	public static Result_DelayedPaymentBasepointDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultDelayedPaymentBasepointDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultDelayedPaymentBasepointDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultDelayedPaymentBasepointDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_DelayedPaymentBasepointDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_DelayedPaymentBasepointDecodeErrorZ clone() {
		long ret = Bindings.CResultDelayedPaymentBasepointDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
