using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_ThirtyTwoBytesPublicKeyZ : CommonBase {
	internal TwoTuple_ThirtyTwoBytesPublicKeyZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_ThirtyTwoBytesPublicKeyZ() {
		if (ptr != 0) { Bindings.C2TupleThirtyTwoBytesPublicKeyZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TupleThirtyTwoBytesPublicKeyZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public byte[] get_b() {
		long ret = Bindings.C2TupleThirtyTwoBytesPublicKeyZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleThirtyTwoBytesPublicKeyZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_ThirtyTwoBytesPublicKeyZ clone() {
		long ret = Bindings.C2TupleThirtyTwoBytesPublicKeyZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ThirtyTwoBytesPublicKeyZ ret_hu_conv = new TwoTuple_ThirtyTwoBytesPublicKeyZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_ThirtyTwoBytesPublicKeyZ from the contained elements.
	 */
	public static TwoTuple_ThirtyTwoBytesPublicKeyZ of(byte[] a, byte[] b) {
		long ret = Bindings.C2TupleThirtyTwoBytesPublicKeyZNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(b, 33)));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ThirtyTwoBytesPublicKeyZ ret_hu_conv = new TwoTuple_ThirtyTwoBytesPublicKeyZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
