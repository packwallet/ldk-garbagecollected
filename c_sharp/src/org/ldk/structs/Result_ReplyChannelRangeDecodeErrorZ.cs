using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ReplyChannelRangeDecodeErrorZ : CommonBase {
	Result_ReplyChannelRangeDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ReplyChannelRangeDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultReplyChannelRangeDecodeErrorZFree(ptr); }
	}

	internal static Result_ReplyChannelRangeDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultReplyChannelRangeDecodeErrorZIsOk(ptr)) {
			return new Result_ReplyChannelRangeDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ReplyChannelRangeDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ReplyChannelRangeDecodeErrorZ_OK : Result_ReplyChannelRangeDecodeErrorZ {
		public readonly ReplyChannelRange res;
		internal Result_ReplyChannelRangeDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultReplyChannelRangeDecodeErrorZGetOk(ptr);
			org.ldk.structs.ReplyChannelRange res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ReplyChannelRange(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ReplyChannelRangeDecodeErrorZ_Err : Result_ReplyChannelRangeDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ReplyChannelRangeDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultReplyChannelRangeDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ReplyChannelRangeDecodeErrorZ in the success state.
	 */
	public static Result_ReplyChannelRangeDecodeErrorZ ok(org.ldk.structs.ReplyChannelRange o) {
		long ret = Bindings.CResultReplyChannelRangeDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReplyChannelRangeDecodeErrorZ ret_hu_conv = Result_ReplyChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ReplyChannelRangeDecodeErrorZ in the error state.
	 */
	public static Result_ReplyChannelRangeDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultReplyChannelRangeDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReplyChannelRangeDecodeErrorZ ret_hu_conv = Result_ReplyChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultReplyChannelRangeDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultReplyChannelRangeDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ReplyChannelRangeDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ReplyChannelRangeDecodeErrorZ clone() {
		long ret = Bindings.CResultReplyChannelRangeDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReplyChannelRangeDecodeErrorZ ret_hu_conv = Result_ReplyChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
