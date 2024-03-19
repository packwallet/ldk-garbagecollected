using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_DelayedPaymentOutputDescriptorDecodeErrorZ : CommonBase {
	Result_DelayedPaymentOutputDescriptorDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_DelayedPaymentOutputDescriptorDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZFree(ptr); }
	}

	internal static Result_DelayedPaymentOutputDescriptorDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZIsOk(ptr)) {
			return new Result_DelayedPaymentOutputDescriptorDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_DelayedPaymentOutputDescriptorDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_DelayedPaymentOutputDescriptorDecodeErrorZ_OK : Result_DelayedPaymentOutputDescriptorDecodeErrorZ {
		public readonly DelayedPaymentOutputDescriptor res;
		internal Result_DelayedPaymentOutputDescriptorDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZGetOk(ptr);
			org.ldk.structs.DelayedPaymentOutputDescriptor res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.DelayedPaymentOutputDescriptor(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_DelayedPaymentOutputDescriptorDecodeErrorZ_Err : Result_DelayedPaymentOutputDescriptorDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_DelayedPaymentOutputDescriptorDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_DelayedPaymentOutputDescriptorDecodeErrorZ in the success state.
	 */
	public static Result_DelayedPaymentOutputDescriptorDecodeErrorZ ok(org.ldk.structs.DelayedPaymentOutputDescriptor o) {
		long ret = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentOutputDescriptorDecodeErrorZ ret_hu_conv = Result_DelayedPaymentOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_DelayedPaymentOutputDescriptorDecodeErrorZ in the error state.
	 */
	public static Result_DelayedPaymentOutputDescriptorDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentOutputDescriptorDecodeErrorZ ret_hu_conv = Result_DelayedPaymentOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_DelayedPaymentOutputDescriptorDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_DelayedPaymentOutputDescriptorDecodeErrorZ clone() {
		long ret = Bindings.CResultDelayedPaymentOutputDescriptorDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentOutputDescriptorDecodeErrorZ ret_hu_conv = Result_DelayedPaymentOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
