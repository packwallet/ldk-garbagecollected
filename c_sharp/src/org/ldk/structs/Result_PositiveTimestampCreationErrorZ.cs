using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PositiveTimestampCreationErrorZ : CommonBase {
	Result_PositiveTimestampCreationErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PositiveTimestampCreationErrorZ() {
		if (ptr != 0) { Bindings.CResultPositiveTimestampCreationErrorZFree(ptr); }
	}

	internal static Result_PositiveTimestampCreationErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultPositiveTimestampCreationErrorZIsOk(ptr)) {
			return new Result_PositiveTimestampCreationErrorZ_OK(null, ptr);
		} else {
			return new Result_PositiveTimestampCreationErrorZ_Err(null, ptr);
		}
	}
	public class Result_PositiveTimestampCreationErrorZ_OK : Result_PositiveTimestampCreationErrorZ {
		public readonly PositiveTimestamp res;
		internal Result_PositiveTimestampCreationErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultPositiveTimestampCreationErrorZGetOk(ptr);
			org.ldk.structs.PositiveTimestamp res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.PositiveTimestamp(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_PositiveTimestampCreationErrorZ_Err : Result_PositiveTimestampCreationErrorZ {
		public readonly CreationError err;
		internal Result_PositiveTimestampCreationErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultPositiveTimestampCreationErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_PositiveTimestampCreationErrorZ in the success state.
	 */
	public static Result_PositiveTimestampCreationErrorZ ok(org.ldk.structs.PositiveTimestamp o) {
		long ret = Bindings.CResultPositiveTimestampCreationErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PositiveTimestampCreationErrorZ ret_hu_conv = Result_PositiveTimestampCreationErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PositiveTimestampCreationErrorZ in the error state.
	 */
	public static Result_PositiveTimestampCreationErrorZ err(CreationError e) {
		long ret = Bindings.CResultPositiveTimestampCreationErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PositiveTimestampCreationErrorZ ret_hu_conv = Result_PositiveTimestampCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultPositiveTimestampCreationErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultPositiveTimestampCreationErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PositiveTimestampCreationErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_PositiveTimestampCreationErrorZ clone() {
		long ret = Bindings.CResultPositiveTimestampCreationErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PositiveTimestampCreationErrorZ ret_hu_conv = Result_PositiveTimestampCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
