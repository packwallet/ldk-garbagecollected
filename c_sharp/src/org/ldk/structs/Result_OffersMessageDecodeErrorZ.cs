using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_OffersMessageDecodeErrorZ : CommonBase {
	Result_OffersMessageDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_OffersMessageDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultOffersMessageDecodeErrorZFree(ptr); }
	}

	internal static Result_OffersMessageDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultOffersMessageDecodeErrorZIsOk(ptr)) {
			return new Result_OffersMessageDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_OffersMessageDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_OffersMessageDecodeErrorZ_OK : Result_OffersMessageDecodeErrorZ {
		public readonly OffersMessage res;
		internal Result_OffersMessageDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultOffersMessageDecodeErrorZGetOk(ptr);
			org.ldk.structs.OffersMessage res_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_OffersMessageDecodeErrorZ_Err : Result_OffersMessageDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_OffersMessageDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultOffersMessageDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_OffersMessageDecodeErrorZ in the success state.
	 */
	public static Result_OffersMessageDecodeErrorZ ok(org.ldk.structs.OffersMessage o) {
		long ret = Bindings.CResultOffersMessageDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersMessageDecodeErrorZ ret_hu_conv = Result_OffersMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_OffersMessageDecodeErrorZ in the error state.
	 */
	public static Result_OffersMessageDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultOffersMessageDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersMessageDecodeErrorZ ret_hu_conv = Result_OffersMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultOffersMessageDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultOffersMessageDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_OffersMessageDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_OffersMessageDecodeErrorZ clone() {
		long ret = Bindings.CResultOffersMessageDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_OffersMessageDecodeErrorZ ret_hu_conv = Result_OffersMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
