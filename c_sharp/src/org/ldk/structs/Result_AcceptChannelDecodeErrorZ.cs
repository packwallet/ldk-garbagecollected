using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_AcceptChannelDecodeErrorZ : CommonBase {
	Result_AcceptChannelDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_AcceptChannelDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultAcceptChannelDecodeErrorZFree(ptr); }
	}

	internal static Result_AcceptChannelDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultAcceptChannelDecodeErrorZIsOk(ptr)) {
			return new Result_AcceptChannelDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_AcceptChannelDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_AcceptChannelDecodeErrorZ_OK : Result_AcceptChannelDecodeErrorZ {
		public readonly AcceptChannel res;
		internal Result_AcceptChannelDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultAcceptChannelDecodeErrorZGetOk(ptr);
			org.ldk.structs.AcceptChannel res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.AcceptChannel(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_AcceptChannelDecodeErrorZ_Err : Result_AcceptChannelDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_AcceptChannelDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultAcceptChannelDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_AcceptChannelDecodeErrorZ in the success state.
	 */
	public static Result_AcceptChannelDecodeErrorZ ok(org.ldk.structs.AcceptChannel o) {
		long ret = Bindings.CResultAcceptChannelDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelDecodeErrorZ ret_hu_conv = Result_AcceptChannelDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_AcceptChannelDecodeErrorZ in the error state.
	 */
	public static Result_AcceptChannelDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultAcceptChannelDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelDecodeErrorZ ret_hu_conv = Result_AcceptChannelDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultAcceptChannelDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultAcceptChannelDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_AcceptChannelDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_AcceptChannelDecodeErrorZ clone() {
		long ret = Bindings.CResultAcceptChannelDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelDecodeErrorZ ret_hu_conv = Result_AcceptChannelDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
