using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UpdateAddHTLCDecodeErrorZ : CommonBase {
	Result_UpdateAddHTLCDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UpdateAddHTLCDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultUpdateAddHTLCDecodeErrorZFree(ptr); }
	}

	internal static Result_UpdateAddHTLCDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultUpdateAddHTLCDecodeErrorZIsOk(ptr)) {
			return new Result_UpdateAddHTLCDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_UpdateAddHTLCDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_UpdateAddHTLCDecodeErrorZ_OK : Result_UpdateAddHTLCDecodeErrorZ {
		public readonly UpdateAddHTLC res;
		internal Result_UpdateAddHTLCDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultUpdateAddHTLCDecodeErrorZGetOk(ptr);
			org.ldk.structs.UpdateAddHTLC res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UpdateAddHTLC(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UpdateAddHTLCDecodeErrorZ_Err : Result_UpdateAddHTLCDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_UpdateAddHTLCDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultUpdateAddHTLCDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_UpdateAddHTLCDecodeErrorZ in the success state.
	 */
	public static Result_UpdateAddHTLCDecodeErrorZ ok(org.ldk.structs.UpdateAddHTLC o) {
		long ret = Bindings.CResultUpdateAddHTLCDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateAddHTLCDecodeErrorZ ret_hu_conv = Result_UpdateAddHTLCDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UpdateAddHTLCDecodeErrorZ in the error state.
	 */
	public static Result_UpdateAddHTLCDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultUpdateAddHTLCDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateAddHTLCDecodeErrorZ ret_hu_conv = Result_UpdateAddHTLCDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultUpdateAddHTLCDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultUpdateAddHTLCDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UpdateAddHTLCDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UpdateAddHTLCDecodeErrorZ clone() {
		long ret = Bindings.CResultUpdateAddHTLCDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateAddHTLCDecodeErrorZ ret_hu_conv = Result_UpdateAddHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
