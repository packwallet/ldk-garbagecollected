using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RouteHintDecodeErrorZ : CommonBase {
	Result_RouteHintDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RouteHintDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultRouteHintDecodeErrorZFree(ptr); }
	}

	internal static Result_RouteHintDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRouteHintDecodeErrorZIsOk(ptr)) {
			return new Result_RouteHintDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_RouteHintDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_RouteHintDecodeErrorZ_OK : Result_RouteHintDecodeErrorZ {
		public readonly RouteHint res;
		internal Result_RouteHintDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRouteHintDecodeErrorZGetOk(ptr);
			org.ldk.structs.RouteHint res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RouteHint(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RouteHintDecodeErrorZ_Err : Result_RouteHintDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_RouteHintDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultRouteHintDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RouteHintDecodeErrorZ in the success state.
	 */
	public static Result_RouteHintDecodeErrorZ ok(org.ldk.structs.RouteHint o) {
		long ret = Bindings.CResultRouteHintDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RouteHintDecodeErrorZ ret_hu_conv = Result_RouteHintDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RouteHintDecodeErrorZ in the error state.
	 */
	public static Result_RouteHintDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultRouteHintDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RouteHintDecodeErrorZ ret_hu_conv = Result_RouteHintDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRouteHintDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRouteHintDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RouteHintDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RouteHintDecodeErrorZ clone() {
		long ret = Bindings.CResultRouteHintDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RouteHintDecodeErrorZ ret_hu_conv = Result_RouteHintDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
