using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_HTLCDescriptorDecodeErrorZ : CommonBase {
	Result_HTLCDescriptorDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_HTLCDescriptorDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultHTLCDescriptorDecodeErrorZFree(ptr); }
	}

	internal static Result_HTLCDescriptorDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultHTLCDescriptorDecodeErrorZIsOk(ptr)) {
			return new Result_HTLCDescriptorDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_HTLCDescriptorDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_HTLCDescriptorDecodeErrorZ_OK : Result_HTLCDescriptorDecodeErrorZ {
		public readonly HTLCDescriptor res;
		internal Result_HTLCDescriptorDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultHTLCDescriptorDecodeErrorZGetOk(ptr);
			org.ldk.structs.HTLCDescriptor res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.HTLCDescriptor(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_HTLCDescriptorDecodeErrorZ_Err : Result_HTLCDescriptorDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_HTLCDescriptorDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultHTLCDescriptorDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_HTLCDescriptorDecodeErrorZ in the success state.
	 */
	public static Result_HTLCDescriptorDecodeErrorZ ok(org.ldk.structs.HTLCDescriptor o) {
		long ret = Bindings.CResultHTLCDescriptorDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HTLCDescriptorDecodeErrorZ ret_hu_conv = Result_HTLCDescriptorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HTLCDescriptorDecodeErrorZ in the error state.
	 */
	public static Result_HTLCDescriptorDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultHTLCDescriptorDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HTLCDescriptorDecodeErrorZ ret_hu_conv = Result_HTLCDescriptorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultHTLCDescriptorDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultHTLCDescriptorDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HTLCDescriptorDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_HTLCDescriptorDecodeErrorZ clone() {
		long ret = Bindings.CResultHTLCDescriptorDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HTLCDescriptorDecodeErrorZ ret_hu_conv = Result_HTLCDescriptorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
