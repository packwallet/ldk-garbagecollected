using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_TxRemoveInputDecodeErrorZ : CommonBase {
	Result_TxRemoveInputDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_TxRemoveInputDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultTxRemoveInputDecodeErrorZFree(ptr); }
	}

	internal static Result_TxRemoveInputDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultTxRemoveInputDecodeErrorZIsOk(ptr)) {
			return new Result_TxRemoveInputDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_TxRemoveInputDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_TxRemoveInputDecodeErrorZ_OK : Result_TxRemoveInputDecodeErrorZ {
		public readonly TxRemoveInput res;
		internal Result_TxRemoveInputDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultTxRemoveInputDecodeErrorZGetOk(ptr);
			org.ldk.structs.TxRemoveInput res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.TxRemoveInput(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_TxRemoveInputDecodeErrorZ_Err : Result_TxRemoveInputDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_TxRemoveInputDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultTxRemoveInputDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_TxRemoveInputDecodeErrorZ in the success state.
	 */
	public static Result_TxRemoveInputDecodeErrorZ ok(org.ldk.structs.TxRemoveInput o) {
		long ret = Bindings.CResultTxRemoveInputDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxRemoveInputDecodeErrorZ ret_hu_conv = Result_TxRemoveInputDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_TxRemoveInputDecodeErrorZ in the error state.
	 */
	public static Result_TxRemoveInputDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultTxRemoveInputDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxRemoveInputDecodeErrorZ ret_hu_conv = Result_TxRemoveInputDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultTxRemoveInputDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultTxRemoveInputDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_TxRemoveInputDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_TxRemoveInputDecodeErrorZ clone() {
		long ret = Bindings.CResultTxRemoveInputDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxRemoveInputDecodeErrorZ ret_hu_conv = Result_TxRemoveInputDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
