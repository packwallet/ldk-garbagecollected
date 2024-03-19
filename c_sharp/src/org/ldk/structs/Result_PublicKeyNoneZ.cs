using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PublicKeyNoneZ : CommonBase {
	Result_PublicKeyNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PublicKeyNoneZ() {
		if (ptr != 0) { Bindings.CResultPublicKeyNoneZFree(ptr); }
	}

	internal static Result_PublicKeyNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultPublicKeyNoneZIsOk(ptr)) {
			return new Result_PublicKeyNoneZ_OK(null, ptr);
		} else {
			return new Result_PublicKeyNoneZ_Err(null, ptr);
		}
	}
	public class Result_PublicKeyNoneZ_OK : Result_PublicKeyNoneZ {
		public readonly byte[] res;
		internal Result_PublicKeyNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultPublicKeyNoneZGetOk(ptr);
			byte[] res_conv = InternalUtils.DecodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result_PublicKeyNoneZ_Err : Result_PublicKeyNoneZ {
		internal Result_PublicKeyNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_PublicKeyNoneZ in the success state.
	 */
	public static Result_PublicKeyNoneZ ok(byte[] o) {
		long ret = Bindings.CResultPublicKeyNoneZOk(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(o, 33)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeyNoneZ ret_hu_conv = Result_PublicKeyNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PublicKeyNoneZ in the error state.
	 */
	public static Result_PublicKeyNoneZ err() {
		long ret = Bindings.CResultPublicKeyNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeyNoneZ ret_hu_conv = Result_PublicKeyNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultPublicKeyNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultPublicKeyNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PublicKeyNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_PublicKeyNoneZ clone() {
		long ret = Bindings.CResultPublicKeyNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeyNoneZ ret_hu_conv = Result_PublicKeyNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
