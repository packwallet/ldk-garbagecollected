using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ChannelReadyDecodeErrorZ : CommonBase {
	Result_ChannelReadyDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ChannelReadyDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultChannelReadyDecodeErrorZFree(ptr); }
	}

	internal static Result_ChannelReadyDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultChannelReadyDecodeErrorZIsOk(ptr)) {
			return new Result_ChannelReadyDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ChannelReadyDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ChannelReadyDecodeErrorZ_OK : Result_ChannelReadyDecodeErrorZ {
		public readonly ChannelReady res;
		internal Result_ChannelReadyDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultChannelReadyDecodeErrorZGetOk(ptr);
			org.ldk.structs.ChannelReady res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ChannelReady(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ChannelReadyDecodeErrorZ_Err : Result_ChannelReadyDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ChannelReadyDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultChannelReadyDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ChannelReadyDecodeErrorZ in the success state.
	 */
	public static Result_ChannelReadyDecodeErrorZ ok(org.ldk.structs.ChannelReady o) {
		long ret = Bindings.CResultChannelReadyDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelReadyDecodeErrorZ ret_hu_conv = Result_ChannelReadyDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ChannelReadyDecodeErrorZ in the error state.
	 */
	public static Result_ChannelReadyDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultChannelReadyDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelReadyDecodeErrorZ ret_hu_conv = Result_ChannelReadyDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultChannelReadyDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultChannelReadyDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ChannelReadyDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ChannelReadyDecodeErrorZ clone() {
		long ret = Bindings.CResultChannelReadyDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelReadyDecodeErrorZ ret_hu_conv = Result_ChannelReadyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
