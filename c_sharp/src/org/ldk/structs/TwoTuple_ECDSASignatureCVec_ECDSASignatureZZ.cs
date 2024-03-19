using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ : CommonBase {
	internal TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ() {
		if (ptr != 0) { Bindings.C2TupleECDSASignatureCVecECDSASignatureZZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TupleECDSASignatureCVecECDSASignatureZZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public byte[][] get_b() {
		long ret = Bindings.C2TupleECDSASignatureCVecECDSASignatureZZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_8_len = InternalUtils.GetArrayLength(ret);
		byte[][] ret_conv_8_arr = new byte[ret_conv_8_len][];
		for (int i = 0; i < ret_conv_8_len; i++) {
			long ret_conv_8 = InternalUtils.GetU64ArrayElem(ret, i);
			byte[] ret_conv_8_conv = InternalUtils.DecodeUint8Array(ret_conv_8);
			ret_conv_8_arr[i] = ret_conv_8_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_8_arr;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleECDSASignatureCVecECDSASignatureZZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ clone() {
		long ret = Bindings.C2TupleECDSASignatureCVecECDSASignatureZZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ ret_hu_conv = new TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_ECDSASignatureCVec_ECDSASignatureZZ from the contained elements.
	 */
	public static TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ of(byte[] a, byte[][] b) {
		long ret = Bindings.C2TupleECDSASignatureCVecECDSASignatureZZNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a, 64)), InternalUtils.EncodeUint64Array(InternalUtils.MapArray(b, b_conv_8 => InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(b_conv_8, 64)))));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ ret_hu_conv = new TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
