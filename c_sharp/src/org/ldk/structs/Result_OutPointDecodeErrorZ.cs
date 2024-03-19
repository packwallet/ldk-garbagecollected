using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_OutPointDecodeErrorZ : CommonBase {
	Result_OutPointDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_OutPointDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultOutPointDecodeErrorZFree(ptr); }
	}

	internal static Result_OutPointDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultOutPointDecodeErrorZIsOk(ptr)) {
			return new Result_OutPointDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OutPointDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_OutPointDecodeErrorZ_OK : Result_OutPointDecodeErrorZ {
		public readonly OutPoint res;
		internal Result_OutPointDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultOutPointDecodeErrorZGetOk(ptr);
			org.ldk.structs.OutPoint res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.OutPoint(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_OutPointDecodeErrorZ_Err : Result_OutPointDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_OutPointDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultOutPointDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OutPointDecodeErrorZ in the success state.
	 */
	public static Result_OutPointDecodeErrorZ ok(org.ldk.structs.OutPoint o) {
		long ret = Bindings.CResultOutPointDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutPointDecodeErrorZ ret_hu_conv = Result_OutPointDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OutPointDecodeErrorZ in the error state.
	 */
	public static Result_OutPointDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultOutPointDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutPointDecodeErrorZ ret_hu_conv = Result_OutPointDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultOutPointDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultOutPointDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_OutPointDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_OutPointDecodeErrorZ clone() {
		long ret = Bindings.CResultOutPointDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OutPointDecodeErrorZ ret_hu_conv = Result_OutPointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
