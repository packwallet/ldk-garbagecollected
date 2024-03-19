using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NoneBolt11SemanticErrorZ : CommonBase {
	Result_NoneBolt11SemanticErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NoneBolt11SemanticErrorZ() {
		if (ptr != 0) { Bindings.CResultNoneBolt11SemanticErrorZFree(ptr); }
	}

	internal static Result_NoneBolt11SemanticErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultNoneBolt11SemanticErrorZIsOk(ptr)) {
			return new Result_NoneBolt11SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_NoneBolt11SemanticErrorZ_Err(null, ptr);
		}
	}
	public class Result_NoneBolt11SemanticErrorZ_OK : Result_NoneBolt11SemanticErrorZ {
		internal Result_NoneBolt11SemanticErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NoneBolt11SemanticErrorZ_Err : Result_NoneBolt11SemanticErrorZ {
		public readonly Bolt11SemanticError err;
		internal Result_NoneBolt11SemanticErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultNoneBolt11SemanticErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_NoneBolt11SemanticErrorZ in the success state.
	 */
	public static Result_NoneBolt11SemanticErrorZ ok() {
		long ret = Bindings.CResultNoneBolt11SemanticErrorZOk();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt11SemanticErrorZ ret_hu_conv = Result_NoneBolt11SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneBolt11SemanticErrorZ in the error state.
	 */
	public static Result_NoneBolt11SemanticErrorZ err(Bolt11SemanticError e) {
		long ret = Bindings.CResultNoneBolt11SemanticErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt11SemanticErrorZ ret_hu_conv = Result_NoneBolt11SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultNoneBolt11SemanticErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultNoneBolt11SemanticErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneBolt11SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NoneBolt11SemanticErrorZ clone() {
		long ret = Bindings.CResultNoneBolt11SemanticErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt11SemanticErrorZ ret_hu_conv = Result_NoneBolt11SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
