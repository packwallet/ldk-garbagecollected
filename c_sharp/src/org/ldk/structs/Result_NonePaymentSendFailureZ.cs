using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NonePaymentSendFailureZ : CommonBase {
	Result_NonePaymentSendFailureZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NonePaymentSendFailureZ() {
		if (ptr != 0) { Bindings.CResultNonePaymentSendFailureZFree(ptr); }
	}

	internal static Result_NonePaymentSendFailureZ constr_from_ptr(long ptr) {
		if (Bindings.CResultNonePaymentSendFailureZIsOk(ptr)) {
			return new Result_NonePaymentSendFailureZ_OK(null, ptr);
		} else {
			return new Result_NonePaymentSendFailureZ_Err(null, ptr);
		}
	}
	public class Result_NonePaymentSendFailureZ_OK : Result_NonePaymentSendFailureZ {
		internal Result_NonePaymentSendFailureZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NonePaymentSendFailureZ_Err : Result_NonePaymentSendFailureZ {
		public readonly PaymentSendFailure err;
		internal Result_NonePaymentSendFailureZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultNonePaymentSendFailureZGetErr(ptr);
			org.ldk.structs.PaymentSendFailure err_hu_conv = org.ldk.structs.PaymentSendFailure.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NonePaymentSendFailureZ in the success state.
	 */
	public static Result_NonePaymentSendFailureZ ok() {
		long ret = Bindings.CResultNonePaymentSendFailureZOk();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePaymentSendFailureZ ret_hu_conv = Result_NonePaymentSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NonePaymentSendFailureZ in the error state.
	 */
	public static Result_NonePaymentSendFailureZ err(org.ldk.structs.PaymentSendFailure e) {
		long ret = Bindings.CResultNonePaymentSendFailureZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePaymentSendFailureZ ret_hu_conv = Result_NonePaymentSendFailureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultNonePaymentSendFailureZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultNonePaymentSendFailureZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NonePaymentSendFailureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NonePaymentSendFailureZ clone() {
		long ret = Bindings.CResultNonePaymentSendFailureZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePaymentSendFailureZ ret_hu_conv = Result_NonePaymentSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
