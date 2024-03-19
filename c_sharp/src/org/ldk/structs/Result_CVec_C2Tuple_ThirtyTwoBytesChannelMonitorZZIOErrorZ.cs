using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ : CommonBase {
	Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ() {
		if (ptr != 0) { Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZFree(ptr); }
	}

	internal static Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZIsOk(ptr)) {
			return new Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ_OK(null, ptr);
		} else {
			return new Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ_Err(null, ptr);
		}
	}
	public class Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ_OK : Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ {
		public readonly TwoTuple_ThirtyTwoBytesChannelMonitorZ[] res;
		internal Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZGetOk(ptr);
			int res_conv_40_len = InternalUtils.GetArrayLength(res);
			TwoTuple_ThirtyTwoBytesChannelMonitorZ[] res_conv_40_arr = new TwoTuple_ThirtyTwoBytesChannelMonitorZ[res_conv_40_len];
			for (int o = 0; o < res_conv_40_len; o++) {
				long res_conv_40 = InternalUtils.GetU64ArrayElem(res, o);
				TwoTuple_ThirtyTwoBytesChannelMonitorZ res_conv_40_hu_conv = new TwoTuple_ThirtyTwoBytesChannelMonitorZ(null, res_conv_40);
				if (res_conv_40_hu_conv != null) { res_conv_40_hu_conv.ptrs_to.AddLast(this); };
				res_conv_40_arr[o] = res_conv_40_hu_conv;
			}
			Bindings.FreeBuffer(res);
			this.res = res_conv_40_arr;
		}
	}

	public class Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ_Err : Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ {
		public readonly IOError err;
		internal Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ in the success state.
	 */
	public static Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ ok(TwoTuple_ThirtyTwoBytesChannelMonitorZ[] o) {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZOk(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(o, o_conv_40 => o_conv_40 != null ? o_conv_40.ptr : 0)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ ret_hu_conv = Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ in the error state.
	 */
	public static Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ err(IOError e) {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ ret_hu_conv = Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ clone() {
		long ret = Bindings.CResultCVecC2TupleThirtyTwoBytesChannelMonitorZZIOErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ ret_hu_conv = Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
