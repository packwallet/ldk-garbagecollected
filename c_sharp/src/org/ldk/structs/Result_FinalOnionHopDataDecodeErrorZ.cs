using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_FinalOnionHopDataDecodeErrorZ : CommonBase {
	Result_FinalOnionHopDataDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_FinalOnionHopDataDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultFinalOnionHopDataDecodeErrorZFree(ptr); }
	}

	internal static Result_FinalOnionHopDataDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultFinalOnionHopDataDecodeErrorZIsOk(ptr)) {
			return new Result_FinalOnionHopDataDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_FinalOnionHopDataDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_FinalOnionHopDataDecodeErrorZ_OK : Result_FinalOnionHopDataDecodeErrorZ {
		public readonly FinalOnionHopData res;
		internal Result_FinalOnionHopDataDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultFinalOnionHopDataDecodeErrorZGetOk(ptr);
			org.ldk.structs.FinalOnionHopData res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.FinalOnionHopData(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_FinalOnionHopDataDecodeErrorZ_Err : Result_FinalOnionHopDataDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_FinalOnionHopDataDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultFinalOnionHopDataDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_FinalOnionHopDataDecodeErrorZ in the success state.
	 */
	public static Result_FinalOnionHopDataDecodeErrorZ ok(org.ldk.structs.FinalOnionHopData o) {
		long ret = Bindings.CResultFinalOnionHopDataDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FinalOnionHopDataDecodeErrorZ ret_hu_conv = Result_FinalOnionHopDataDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_FinalOnionHopDataDecodeErrorZ in the error state.
	 */
	public static Result_FinalOnionHopDataDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultFinalOnionHopDataDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FinalOnionHopDataDecodeErrorZ ret_hu_conv = Result_FinalOnionHopDataDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultFinalOnionHopDataDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultFinalOnionHopDataDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_FinalOnionHopDataDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_FinalOnionHopDataDecodeErrorZ clone() {
		long ret = Bindings.CResultFinalOnionHopDataDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FinalOnionHopDataDecodeErrorZ ret_hu_conv = Result_FinalOnionHopDataDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
