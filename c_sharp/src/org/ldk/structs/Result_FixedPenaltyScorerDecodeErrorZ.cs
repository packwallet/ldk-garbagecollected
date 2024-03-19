using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_FixedPenaltyScorerDecodeErrorZ : CommonBase {
	Result_FixedPenaltyScorerDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_FixedPenaltyScorerDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultFixedPenaltyScorerDecodeErrorZFree(ptr); }
	}

	internal static Result_FixedPenaltyScorerDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultFixedPenaltyScorerDecodeErrorZIsOk(ptr)) {
			return new Result_FixedPenaltyScorerDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_FixedPenaltyScorerDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_FixedPenaltyScorerDecodeErrorZ_OK : Result_FixedPenaltyScorerDecodeErrorZ {
		public readonly FixedPenaltyScorer res;
		internal Result_FixedPenaltyScorerDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultFixedPenaltyScorerDecodeErrorZGetOk(ptr);
			org.ldk.structs.FixedPenaltyScorer res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.FixedPenaltyScorer(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_FixedPenaltyScorerDecodeErrorZ_Err : Result_FixedPenaltyScorerDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_FixedPenaltyScorerDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultFixedPenaltyScorerDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_FixedPenaltyScorerDecodeErrorZ in the success state.
	 */
	public static Result_FixedPenaltyScorerDecodeErrorZ ok(org.ldk.structs.FixedPenaltyScorer o) {
		long ret = Bindings.CResultFixedPenaltyScorerDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FixedPenaltyScorerDecodeErrorZ ret_hu_conv = Result_FixedPenaltyScorerDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_FixedPenaltyScorerDecodeErrorZ in the error state.
	 */
	public static Result_FixedPenaltyScorerDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultFixedPenaltyScorerDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FixedPenaltyScorerDecodeErrorZ ret_hu_conv = Result_FixedPenaltyScorerDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultFixedPenaltyScorerDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultFixedPenaltyScorerDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_FixedPenaltyScorerDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_FixedPenaltyScorerDecodeErrorZ clone() {
		long ret = Bindings.CResultFixedPenaltyScorerDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FixedPenaltyScorerDecodeErrorZ ret_hu_conv = Result_FixedPenaltyScorerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
