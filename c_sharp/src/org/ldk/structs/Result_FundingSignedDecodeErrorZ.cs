using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_FundingSignedDecodeErrorZ : CommonBase {
	Result_FundingSignedDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_FundingSignedDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultFundingSignedDecodeErrorZFree(ptr); }
	}

	internal static Result_FundingSignedDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultFundingSignedDecodeErrorZIsOk(ptr)) {
			return new Result_FundingSignedDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_FundingSignedDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_FundingSignedDecodeErrorZ_OK : Result_FundingSignedDecodeErrorZ {
		public readonly FundingSigned res;
		internal Result_FundingSignedDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultFundingSignedDecodeErrorZGetOk(ptr);
			org.ldk.structs.FundingSigned res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.FundingSigned(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_FundingSignedDecodeErrorZ_Err : Result_FundingSignedDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_FundingSignedDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultFundingSignedDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_FundingSignedDecodeErrorZ in the success state.
	 */
	public static Result_FundingSignedDecodeErrorZ ok(org.ldk.structs.FundingSigned o) {
		long ret = Bindings.CResultFundingSignedDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingSignedDecodeErrorZ ret_hu_conv = Result_FundingSignedDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_FundingSignedDecodeErrorZ in the error state.
	 */
	public static Result_FundingSignedDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultFundingSignedDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingSignedDecodeErrorZ ret_hu_conv = Result_FundingSignedDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultFundingSignedDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultFundingSignedDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_FundingSignedDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_FundingSignedDecodeErrorZ clone() {
		long ret = Bindings.CResultFundingSignedDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingSignedDecodeErrorZ ret_hu_conv = Result_FundingSignedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
