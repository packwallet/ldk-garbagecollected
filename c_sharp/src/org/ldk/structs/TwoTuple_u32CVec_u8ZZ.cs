using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_u32CVec_u8ZZ : CommonBase {
	internal TwoTuple_u32CVec_u8ZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_u32CVec_u8ZZ() {
		if (ptr != 0) { Bindings.C2TupleU32CvecU8ZzFree(ptr); }
	}

	/**
	 * 
	 */
	public int get_a() {
		int ret = Bindings.C2TupleU32CvecU8ZzGetA(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * 
	 */
	public byte[] get_b() {
		long ret = Bindings.C2TupleU32CvecU8ZzGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleU32CvecU8ZzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_u32CVec_u8ZZ clone() {
		long ret = Bindings.C2TupleU32CvecU8ZzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_u32CVec_u8ZZ ret_hu_conv = new TwoTuple_u32CVec_u8ZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_u32CVec_u8ZZ from the contained elements.
	 */
	public static TwoTuple_u32CVec_u8ZZ of(int a, byte[] b) {
		long ret = Bindings.C2TupleU32CvecU8ZzNew(a, InternalUtils.EncodeUint8Array(b));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_u32CVec_u8ZZ ret_hu_conv = new TwoTuple_u32CVec_u8ZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
