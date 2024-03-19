using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ : CommonBase {
	Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ() {
		if (ptr != 0) { Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZFree(ptr); }
	}

	internal static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZIsOk(ptr)) {
			return new Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ_OK : Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ {
		public readonly TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res;
		internal Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZGetOk(ptr);
			TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ res_hu_conv = new TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ_Err : Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ {
		internal Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ in the success state.
	 */
	public static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ ok(org.ldk.structs.TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ o) {
		long ret = Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZOk(o != null ? o.ptr : 0);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ in the error state.
	 */
	public static Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ err() {
		long ret = Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ clone() {
		long ret = Bindings.CResultC2TupleThirtyTwoBytesThirtyTwoBytesZNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ ret_hu_conv = Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
