using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RoutingFeesDecodeErrorZ : CommonBase {
	Result_RoutingFeesDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RoutingFeesDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultRoutingFeesDecodeErrorZFree(ptr); }
	}

	internal static Result_RoutingFeesDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRoutingFeesDecodeErrorZIsOk(ptr)) {
			return new Result_RoutingFeesDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_RoutingFeesDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_RoutingFeesDecodeErrorZ_OK : Result_RoutingFeesDecodeErrorZ {
		public readonly RoutingFees res;
		internal Result_RoutingFeesDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRoutingFeesDecodeErrorZGetOk(ptr);
			org.ldk.structs.RoutingFees res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RoutingFees(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RoutingFeesDecodeErrorZ_Err : Result_RoutingFeesDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_RoutingFeesDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultRoutingFeesDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RoutingFeesDecodeErrorZ in the success state.
	 */
	public static Result_RoutingFeesDecodeErrorZ ok(org.ldk.structs.RoutingFees o) {
		long ret = Bindings.CResultRoutingFeesDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RoutingFeesDecodeErrorZ ret_hu_conv = Result_RoutingFeesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RoutingFeesDecodeErrorZ in the error state.
	 */
	public static Result_RoutingFeesDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultRoutingFeesDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RoutingFeesDecodeErrorZ ret_hu_conv = Result_RoutingFeesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRoutingFeesDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRoutingFeesDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RoutingFeesDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RoutingFeesDecodeErrorZ clone() {
		long ret = Bindings.CResultRoutingFeesDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RoutingFeesDecodeErrorZ ret_hu_conv = Result_RoutingFeesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
