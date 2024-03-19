using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_usizeTransactionZ : CommonBase {
	internal TwoTuple_usizeTransactionZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_usizeTransactionZ() {
		if (ptr != 0) { Bindings.C2TupleUsizetransactionzFree(ptr); }
	}

	/**
	 * 
	 */
	public long get_a() {
		long ret = Bindings.C2TupleUsizetransactionzGetA(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * 
	 */
	public byte[] get_b() {
		long ret = Bindings.C2TupleUsizetransactionzGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleUsizetransactionzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_usizeTransactionZ clone() {
		long ret = Bindings.C2TupleUsizetransactionzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_usizeTransactionZ ret_hu_conv = new TwoTuple_usizeTransactionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_usizeTransactionZ from the contained elements.
	 */
	public static TwoTuple_usizeTransactionZ of(long a, byte[] b) {
		long ret = Bindings.C2TupleUsizetransactionzNew(a, InternalUtils.EncodeUint8Array(b));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_usizeTransactionZ ret_hu_conv = new TwoTuple_usizeTransactionZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
