using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_PublicKeyCVec_SocketAddressZZ : CommonBase {
	internal TwoTuple_PublicKeyCVec_SocketAddressZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_PublicKeyCVec_SocketAddressZZ() {
		if (ptr != 0) { Bindings.C2TuplePublicKeyCVecSocketAddressZZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TuplePublicKeyCVecSocketAddressZZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public SocketAddress[] get_b() {
		long ret = Bindings.C2TuplePublicKeyCVecSocketAddressZZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_15_len = InternalUtils.GetArrayLength(ret);
		SocketAddress[] ret_conv_15_arr = new SocketAddress[ret_conv_15_len];
		for (int p = 0; p < ret_conv_15_len; p++) {
			long ret_conv_15 = InternalUtils.GetU64ArrayElem(ret, p);
			org.ldk.structs.SocketAddress ret_conv_15_hu_conv = org.ldk.structs.SocketAddress.constr_from_ptr(ret_conv_15);
			if (ret_conv_15_hu_conv != null) { ret_conv_15_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_15_arr[p] = ret_conv_15_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_15_arr;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TuplePublicKeyCVecSocketAddressZZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_PublicKeyCVec_SocketAddressZZ clone() {
		long ret = Bindings.C2TuplePublicKeyCVecSocketAddressZZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_PublicKeyCVec_SocketAddressZZ ret_hu_conv = new TwoTuple_PublicKeyCVec_SocketAddressZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_PublicKeyCVec_SocketAddressZZ from the contained elements.
	 */
	public static TwoTuple_PublicKeyCVec_SocketAddressZZ of(byte[] a, SocketAddress[] b) {
		long ret = Bindings.C2TuplePublicKeyCVecSocketAddressZZNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a, 33)), InternalUtils.EncodeUint64Array(InternalUtils.MapArray(b, b_conv_15 => b_conv_15.ptr)));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_PublicKeyCVec_SocketAddressZZ ret_hu_conv = new TwoTuple_PublicKeyCVec_SocketAddressZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (SocketAddress b_conv_15 in b) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b_conv_15); }; };
		return ret_hu_conv;
	}

}
} } }
