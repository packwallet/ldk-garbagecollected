using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UnsignedChannelUpdateDecodeErrorZ : CommonBase {
	Result_UnsignedChannelUpdateDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UnsignedChannelUpdateDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultUnsignedChannelUpdateDecodeErrorZFree(ptr); }
	}

	internal static Result_UnsignedChannelUpdateDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultUnsignedChannelUpdateDecodeErrorZIsOk(ptr)) {
			return new Result_UnsignedChannelUpdateDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_UnsignedChannelUpdateDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_UnsignedChannelUpdateDecodeErrorZ_OK : Result_UnsignedChannelUpdateDecodeErrorZ {
		public readonly UnsignedChannelUpdate res;
		internal Result_UnsignedChannelUpdateDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultUnsignedChannelUpdateDecodeErrorZGetOk(ptr);
			org.ldk.structs.UnsignedChannelUpdate res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UnsignedChannelUpdate(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UnsignedChannelUpdateDecodeErrorZ_Err : Result_UnsignedChannelUpdateDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_UnsignedChannelUpdateDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultUnsignedChannelUpdateDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_UnsignedChannelUpdateDecodeErrorZ in the success state.
	 */
	public static Result_UnsignedChannelUpdateDecodeErrorZ ok(org.ldk.structs.UnsignedChannelUpdate o) {
		long ret = Bindings.CResultUnsignedChannelUpdateDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelUpdateDecodeErrorZ ret_hu_conv = Result_UnsignedChannelUpdateDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UnsignedChannelUpdateDecodeErrorZ in the error state.
	 */
	public static Result_UnsignedChannelUpdateDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultUnsignedChannelUpdateDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelUpdateDecodeErrorZ ret_hu_conv = Result_UnsignedChannelUpdateDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultUnsignedChannelUpdateDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultUnsignedChannelUpdateDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UnsignedChannelUpdateDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UnsignedChannelUpdateDecodeErrorZ clone() {
		long ret = Bindings.CResultUnsignedChannelUpdateDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelUpdateDecodeErrorZ ret_hu_conv = Result_UnsignedChannelUpdateDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
