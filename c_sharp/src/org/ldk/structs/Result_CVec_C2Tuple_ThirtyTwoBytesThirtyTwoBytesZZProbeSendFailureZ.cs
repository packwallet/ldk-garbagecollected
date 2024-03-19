using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ : CommonBase {
	Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ() {
		if (ptr != 0) { Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZFree(ptr); }
	}

	internal static Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZIsOk(ptr)) {
			return new Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ_OK(null, ptr);
		} else {
			return new Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ_Err(null, ptr);
		}
	}
	public class Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ_OK : Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ {
		public readonly TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ[] res;
		internal Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZGetOk(ptr);
			int res_conv_40_len = InternalUtils.GetArrayLength(res);
			TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ[] res_conv_40_arr = new TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ[res_conv_40_len];
			for (int o = 0; o < res_conv_40_len; o++) {
				long res_conv_40 = InternalUtils.GetU64ArrayElem(res, o);
				TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res_conv_40_hu_conv = new TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ(null, res_conv_40);
				if (res_conv_40_hu_conv != null) { res_conv_40_hu_conv.ptrs_to.AddLast(this); };
				res_conv_40_arr[o] = res_conv_40_hu_conv;
			}
			Bindings.FreeBuffer(res);
			this.res = res_conv_40_arr;
		}
	}

	public class Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ_Err : Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ {
		public readonly ProbeSendFailure err;
		internal Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZGetErr(ptr);
			org.ldk.structs.ProbeSendFailure err_hu_conv = org.ldk.structs.ProbeSendFailure.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ in the success state.
	 */
	public static Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ ok(TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ[] o) {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZOk(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(o, o_conv_40 => o_conv_40 != null ? o_conv_40.ptr : 0)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ ret_hu_conv = Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ in the error state.
	 */
	public static Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ err(org.ldk.structs.ProbeSendFailure e) {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ ret_hu_conv = Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ clone() {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ ret_hu_conv = Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
