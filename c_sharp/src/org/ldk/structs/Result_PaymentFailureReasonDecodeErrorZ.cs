using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PaymentFailureReasonDecodeErrorZ : CommonBase {
	Result_PaymentFailureReasonDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PaymentFailureReasonDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultPaymentFailureReasonDecodeErrorZFree(ptr); }
	}

	internal static Result_PaymentFailureReasonDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultPaymentFailureReasonDecodeErrorZIsOk(ptr)) {
			return new Result_PaymentFailureReasonDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_PaymentFailureReasonDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_PaymentFailureReasonDecodeErrorZ_OK : Result_PaymentFailureReasonDecodeErrorZ {
		public readonly PaymentFailureReason res;
		internal Result_PaymentFailureReasonDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = Bindings.CResultPaymentFailureReasonDecodeErrorZGetOk(ptr);
		}
	}

	public class Result_PaymentFailureReasonDecodeErrorZ_Err : Result_PaymentFailureReasonDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_PaymentFailureReasonDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultPaymentFailureReasonDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_PaymentFailureReasonDecodeErrorZ in the success state.
	 */
	public static Result_PaymentFailureReasonDecodeErrorZ ok(PaymentFailureReason o) {
		long ret = Bindings.CResultPaymentFailureReasonDecodeErrorZOk(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentFailureReasonDecodeErrorZ ret_hu_conv = Result_PaymentFailureReasonDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PaymentFailureReasonDecodeErrorZ in the error state.
	 */
	public static Result_PaymentFailureReasonDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultPaymentFailureReasonDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentFailureReasonDecodeErrorZ ret_hu_conv = Result_PaymentFailureReasonDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultPaymentFailureReasonDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultPaymentFailureReasonDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PaymentFailureReasonDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_PaymentFailureReasonDecodeErrorZ clone() {
		long ret = Bindings.CResultPaymentFailureReasonDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentFailureReasonDecodeErrorZ ret_hu_conv = Result_PaymentFailureReasonDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
