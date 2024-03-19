using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_COption_TypeZDecodeErrorZ : CommonBase {
	Result_COption_TypeZDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_COption_TypeZDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultCOptionTypeZDecodeErrorZFree(ptr); }
	}

	internal static Result_COption_TypeZDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCOptionTypeZDecodeErrorZIsOk(ptr)) {
			return new Result_COption_TypeZDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_COption_TypeZDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_COption_TypeZDecodeErrorZ_OK : Result_COption_TypeZDecodeErrorZ {
		public readonly Option_TypeZ res;
		internal Result_COption_TypeZDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCOptionTypeZDecodeErrorZGetOk(ptr);
			org.ldk.structs.Option_TypeZ res_hu_conv = org.ldk.structs.Option_TypeZ.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_COption_TypeZDecodeErrorZ_Err : Result_COption_TypeZDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_COption_TypeZDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultCOptionTypeZDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_COption_TypeZDecodeErrorZ in the success state.
	 */
	public static Result_COption_TypeZDecodeErrorZ ok(org.ldk.structs.Option_TypeZ o) {
		long ret = Bindings.CResultCOptionTypeZDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_TypeZDecodeErrorZ ret_hu_conv = Result_COption_TypeZDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_COption_TypeZDecodeErrorZ in the error state.
	 */
	public static Result_COption_TypeZDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultCOptionTypeZDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_TypeZDecodeErrorZ ret_hu_conv = Result_COption_TypeZDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCOptionTypeZDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCOptionTypeZDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_COption_TypeZDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_COption_TypeZDecodeErrorZ clone() {
		long ret = Bindings.CResultCOptionTypeZDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_TypeZDecodeErrorZ ret_hu_conv = Result_COption_TypeZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
