using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_CVec_u8Zu64ZNoneZ : CommonBase {
	Result_C2Tuple_CVec_u8Zu64ZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_CVec_u8Zu64ZNoneZ() {
		if (ptr != 0) { Bindings.CResultC2TupleCVecU8Zu64ZnonezFree(ptr); }
	}

	internal static Result_C2Tuple_CVec_u8Zu64ZNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultC2TupleCVecU8Zu64ZnonezIsOk(ptr)) {
			return new Result_C2Tuple_CVec_u8Zu64ZNoneZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_CVec_u8Zu64ZNoneZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_CVec_u8Zu64ZNoneZ_OK : Result_C2Tuple_CVec_u8Zu64ZNoneZ {
		public readonly TwoTuple_CVec_u8Zu64Z res;
		internal Result_C2Tuple_CVec_u8Zu64ZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultC2TupleCVecU8Zu64ZnonezGetOk(ptr);
			TwoTuple_CVec_u8Zu64Z res_hu_conv = new TwoTuple_CVec_u8Zu64Z(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_CVec_u8Zu64ZNoneZ_Err : Result_C2Tuple_CVec_u8Zu64ZNoneZ {
		internal Result_C2Tuple_CVec_u8Zu64ZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_CVec_u8Zu64ZNoneZ in the success state.
	 */
	public static Result_C2Tuple_CVec_u8Zu64ZNoneZ ok(org.ldk.structs.TwoTuple_CVec_u8Zu64Z o) {
		long ret = Bindings.CResultC2TupleCVecU8Zu64ZnonezOk(o != null ? o.ptr : 0);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_CVec_u8Zu64ZNoneZ ret_hu_conv = Result_C2Tuple_CVec_u8Zu64ZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_CVec_u8Zu64ZNoneZ in the error state.
	 */
	public static Result_C2Tuple_CVec_u8Zu64ZNoneZ err() {
		long ret = Bindings.CResultC2TupleCVecU8Zu64ZnonezErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_CVec_u8Zu64ZNoneZ ret_hu_conv = Result_C2Tuple_CVec_u8Zu64ZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultC2TupleCVecU8Zu64ZnonezIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultC2TupleCVecU8Zu64ZnonezClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_CVec_u8Zu64ZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_CVec_u8Zu64ZNoneZ clone() {
		long ret = Bindings.CResultC2TupleCVecU8Zu64ZnonezClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_CVec_u8Zu64ZNoneZ ret_hu_conv = Result_C2Tuple_CVec_u8Zu64ZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
