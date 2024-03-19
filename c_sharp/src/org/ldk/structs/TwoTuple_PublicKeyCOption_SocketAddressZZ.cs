using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_PublicKeyCOption_SocketAddressZZ : CommonBase {
	internal TwoTuple_PublicKeyCOption_SocketAddressZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_PublicKeyCOption_SocketAddressZZ() {
		if (ptr != 0) { Bindings.C2TuplePublicKeyCOptionSocketAddressZZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TuplePublicKeyCOptionSocketAddressZZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public Option_SocketAddressZ get_b() {
		long ret = Bindings.C2TuplePublicKeyCOptionSocketAddressZZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_SocketAddressZ ret_hu_conv = org.ldk.structs.Option_SocketAddressZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TuplePublicKeyCOptionSocketAddressZZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_PublicKeyCOption_SocketAddressZZ clone() {
		long ret = Bindings.C2TuplePublicKeyCOptionSocketAddressZZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_PublicKeyCOption_SocketAddressZZ ret_hu_conv = new TwoTuple_PublicKeyCOption_SocketAddressZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_PublicKeyCOption_SocketAddressZZ from the contained elements.
	 */
	public static TwoTuple_PublicKeyCOption_SocketAddressZZ of(byte[] a, org.ldk.structs.Option_SocketAddressZ b) {
		long ret = Bindings.C2TuplePublicKeyCOptionSocketAddressZZNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a, 33)), b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_PublicKeyCOption_SocketAddressZZ ret_hu_conv = new TwoTuple_PublicKeyCOption_SocketAddressZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b); };
		return ret_hu_conv;
	}

}
} } }
