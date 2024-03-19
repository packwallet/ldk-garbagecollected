using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_TransactionNoneZ : CommonBase {
	Result_TransactionNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_TransactionNoneZ() {
		if (ptr != 0) { Bindings.CResultTransactionNoneZFree(ptr); }
	}

	internal static Result_TransactionNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultTransactionNoneZIsOk(ptr)) {
			return new Result_TransactionNoneZ_OK(null, ptr);
		} else {
			return new Result_TransactionNoneZ_Err(null, ptr);
		}
	}
	public class Result_TransactionNoneZ_OK : Result_TransactionNoneZ {
		public readonly byte[] res;
		internal Result_TransactionNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultTransactionNoneZGetOk(ptr);
			byte[] res_conv = InternalUtils.DecodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result_TransactionNoneZ_Err : Result_TransactionNoneZ {
		internal Result_TransactionNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_TransactionNoneZ in the success state.
	 */
	public static Result_TransactionNoneZ ok(byte[] o) {
		long ret = Bindings.CResultTransactionNoneZOk(InternalUtils.EncodeUint8Array(o));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TransactionNoneZ ret_hu_conv = Result_TransactionNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_TransactionNoneZ in the error state.
	 */
	public static Result_TransactionNoneZ err() {
		long ret = Bindings.CResultTransactionNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TransactionNoneZ ret_hu_conv = Result_TransactionNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultTransactionNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultTransactionNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_TransactionNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_TransactionNoneZ clone() {
		long ret = Bindings.CResultTransactionNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TransactionNoneZ ret_hu_conv = Result_TransactionNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
