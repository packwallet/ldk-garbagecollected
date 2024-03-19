using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ChannelInfoDecodeErrorZ : CommonBase {
	Result_ChannelInfoDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ChannelInfoDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultChannelInfoDecodeErrorZFree(ptr); }
	}

	internal static Result_ChannelInfoDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultChannelInfoDecodeErrorZIsOk(ptr)) {
			return new Result_ChannelInfoDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ChannelInfoDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ChannelInfoDecodeErrorZ_OK : Result_ChannelInfoDecodeErrorZ {
		public readonly ChannelInfo res;
		internal Result_ChannelInfoDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultChannelInfoDecodeErrorZGetOk(ptr);
			org.ldk.structs.ChannelInfo res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ChannelInfo(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ChannelInfoDecodeErrorZ_Err : Result_ChannelInfoDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ChannelInfoDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultChannelInfoDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ChannelInfoDecodeErrorZ in the success state.
	 */
	public static Result_ChannelInfoDecodeErrorZ ok(org.ldk.structs.ChannelInfo o) {
		long ret = Bindings.CResultChannelInfoDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelInfoDecodeErrorZ ret_hu_conv = Result_ChannelInfoDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ChannelInfoDecodeErrorZ in the error state.
	 */
	public static Result_ChannelInfoDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultChannelInfoDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelInfoDecodeErrorZ ret_hu_conv = Result_ChannelInfoDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultChannelInfoDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultChannelInfoDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ChannelInfoDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ChannelInfoDecodeErrorZ clone() {
		long ret = Bindings.CResultChannelInfoDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelInfoDecodeErrorZ ret_hu_conv = Result_ChannelInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
