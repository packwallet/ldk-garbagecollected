using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_UtxoZNoneZ : CommonBase {
	Result_CVec_UtxoZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_UtxoZNoneZ() {
		if (ptr != 0) { Bindings.CResultCVecUtxoZNoneZFree(ptr); }
	}

	internal static Result_CVec_UtxoZNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCVecUtxoZNoneZIsOk(ptr)) {
			return new Result_CVec_UtxoZNoneZ_OK(null, ptr);
		} else {
			return new Result_CVec_UtxoZNoneZ_Err(null, ptr);
		}
	}
	public class Result_CVec_UtxoZNoneZ_OK : Result_CVec_UtxoZNoneZ {
		public readonly Utxo[] res;
		internal Result_CVec_UtxoZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCVecUtxoZNoneZGetOk(ptr);
			int res_conv_6_len = InternalUtils.GetArrayLength(res);
			Utxo[] res_conv_6_arr = new Utxo[res_conv_6_len];
			for (int g = 0; g < res_conv_6_len; g++) {
				long res_conv_6 = InternalUtils.GetU64ArrayElem(res, g);
				org.ldk.structs.Utxo res_conv_6_hu_conv = null; if (res_conv_6 < 0 || res_conv_6 > 4096) { res_conv_6_hu_conv = new org.ldk.structs.Utxo(null, res_conv_6); }
				if (res_conv_6_hu_conv != null) { res_conv_6_hu_conv.ptrs_to.AddLast(this); };
				res_conv_6_arr[g] = res_conv_6_hu_conv;
			}
			Bindings.FreeBuffer(res);
			this.res = res_conv_6_arr;
		}
	}

	public class Result_CVec_UtxoZNoneZ_Err : Result_CVec_UtxoZNoneZ {
		internal Result_CVec_UtxoZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_CVec_UtxoZNoneZ in the success state.
	 */
	public static Result_CVec_UtxoZNoneZ ok(Utxo[] o) {
		long ret = Bindings.CResultCVecUtxoZNoneZOk(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(o, o_conv_6 => o_conv_6 == null ? 0 : o_conv_6.ptr)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_UtxoZNoneZ ret_hu_conv = Result_CVec_UtxoZNoneZ.constr_from_ptr(ret);
		foreach (Utxo o_conv_6 in o) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_conv_6); }; };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_UtxoZNoneZ in the error state.
	 */
	public static Result_CVec_UtxoZNoneZ err() {
		long ret = Bindings.CResultCVecUtxoZNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_UtxoZNoneZ ret_hu_conv = Result_CVec_UtxoZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCVecUtxoZNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCVecUtxoZNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_UtxoZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_UtxoZNoneZ clone() {
		long ret = Bindings.CResultCVecUtxoZNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_UtxoZNoneZ ret_hu_conv = Result_CVec_UtxoZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
