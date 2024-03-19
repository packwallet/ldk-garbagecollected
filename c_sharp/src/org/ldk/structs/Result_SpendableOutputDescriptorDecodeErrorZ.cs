using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_SpendableOutputDescriptorDecodeErrorZ : CommonBase {
	Result_SpendableOutputDescriptorDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_SpendableOutputDescriptorDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultSpendableOutputDescriptorDecodeErrorZFree(ptr); }
	}

	internal static Result_SpendableOutputDescriptorDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultSpendableOutputDescriptorDecodeErrorZIsOk(ptr)) {
			return new Result_SpendableOutputDescriptorDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_SpendableOutputDescriptorDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_SpendableOutputDescriptorDecodeErrorZ_OK : Result_SpendableOutputDescriptorDecodeErrorZ {
		public readonly SpendableOutputDescriptor res;
		internal Result_SpendableOutputDescriptorDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultSpendableOutputDescriptorDecodeErrorZGetOk(ptr);
			org.ldk.structs.SpendableOutputDescriptor res_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_SpendableOutputDescriptorDecodeErrorZ_Err : Result_SpendableOutputDescriptorDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_SpendableOutputDescriptorDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultSpendableOutputDescriptorDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_SpendableOutputDescriptorDecodeErrorZ in the success state.
	 */
	public static Result_SpendableOutputDescriptorDecodeErrorZ ok(org.ldk.structs.SpendableOutputDescriptor o) {
		long ret = Bindings.CResultSpendableOutputDescriptorDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpendableOutputDescriptorDecodeErrorZ ret_hu_conv = Result_SpendableOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_SpendableOutputDescriptorDecodeErrorZ in the error state.
	 */
	public static Result_SpendableOutputDescriptorDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultSpendableOutputDescriptorDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpendableOutputDescriptorDecodeErrorZ ret_hu_conv = Result_SpendableOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultSpendableOutputDescriptorDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultSpendableOutputDescriptorDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_SpendableOutputDescriptorDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_SpendableOutputDescriptorDecodeErrorZ clone() {
		long ret = Bindings.CResultSpendableOutputDescriptorDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpendableOutputDescriptorDecodeErrorZ ret_hu_conv = Result_SpendableOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
