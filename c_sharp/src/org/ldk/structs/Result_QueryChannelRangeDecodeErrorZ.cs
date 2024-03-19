using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_QueryChannelRangeDecodeErrorZ : CommonBase {
	Result_QueryChannelRangeDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_QueryChannelRangeDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultQueryChannelRangeDecodeErrorZFree(ptr); }
	}

	internal static Result_QueryChannelRangeDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultQueryChannelRangeDecodeErrorZIsOk(ptr)) {
			return new Result_QueryChannelRangeDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_QueryChannelRangeDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_QueryChannelRangeDecodeErrorZ_OK : Result_QueryChannelRangeDecodeErrorZ {
		public readonly QueryChannelRange res;
		internal Result_QueryChannelRangeDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultQueryChannelRangeDecodeErrorZGetOk(ptr);
			org.ldk.structs.QueryChannelRange res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.QueryChannelRange(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_QueryChannelRangeDecodeErrorZ_Err : Result_QueryChannelRangeDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_QueryChannelRangeDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultQueryChannelRangeDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_QueryChannelRangeDecodeErrorZ in the success state.
	 */
	public static Result_QueryChannelRangeDecodeErrorZ ok(org.ldk.structs.QueryChannelRange o) {
		long ret = Bindings.CResultQueryChannelRangeDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_QueryChannelRangeDecodeErrorZ ret_hu_conv = Result_QueryChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_QueryChannelRangeDecodeErrorZ in the error state.
	 */
	public static Result_QueryChannelRangeDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultQueryChannelRangeDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_QueryChannelRangeDecodeErrorZ ret_hu_conv = Result_QueryChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultQueryChannelRangeDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultQueryChannelRangeDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_QueryChannelRangeDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_QueryChannelRangeDecodeErrorZ clone() {
		long ret = Bindings.CResultQueryChannelRangeDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_QueryChannelRangeDecodeErrorZ ret_hu_conv = Result_QueryChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
