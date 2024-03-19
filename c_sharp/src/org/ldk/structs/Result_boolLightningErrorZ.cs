using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_boolLightningErrorZ : CommonBase {
	Result_boolLightningErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_boolLightningErrorZ() {
		if (ptr != 0) { Bindings.CResultBoollightningerrorzFree(ptr); }
	}

	internal static Result_boolLightningErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBoollightningerrorzIsOk(ptr)) {
			return new Result_boolLightningErrorZ_OK(null, ptr);
		} else {
			return new Result_boolLightningErrorZ_Err(null, ptr);
		}
	}
	public class Result_boolLightningErrorZ_OK : Result_boolLightningErrorZ {
		public readonly bool res;
		internal Result_boolLightningErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = Bindings.CResultBoollightningerrorzGetOk(ptr);
		}
	}

	public class Result_boolLightningErrorZ_Err : Result_boolLightningErrorZ {
		public readonly LightningError err;
		internal Result_boolLightningErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBoollightningerrorzGetErr(ptr);
			org.ldk.structs.LightningError err_hu_conv = null; if (err < 0 || err > 4096) { err_hu_conv = new org.ldk.structs.LightningError(null, err); }
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_boolLightningErrorZ in the success state.
	 */
	public static Result_boolLightningErrorZ ok(bool o) {
		long ret = Bindings.CResultBoollightningerrorzOk(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolLightningErrorZ ret_hu_conv = Result_boolLightningErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_boolLightningErrorZ in the error state.
	 */
	public static Result_boolLightningErrorZ err(org.ldk.structs.LightningError e) {
		long ret = Bindings.CResultBoollightningerrorzErr(e == null ? 0 : e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolLightningErrorZ ret_hu_conv = Result_boolLightningErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBoollightningerrorzIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBoollightningerrorzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_boolLightningErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_boolLightningErrorZ clone() {
		long ret = Bindings.CResultBoollightningerrorzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolLightningErrorZ ret_hu_conv = Result_boolLightningErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
