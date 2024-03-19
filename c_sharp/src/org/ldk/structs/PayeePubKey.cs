using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Payee public key
 */
public class PayeePubKey : CommonBase {
	internal PayeePubKey(object _dummy, long ptr) : base(ptr) { }
	~PayeePubKey() {
		if (ptr != 0) { Bindings.PayeePubKeyFree(ptr); }
	}

	public byte[] get_a() {
		long ret = Bindings.PayeePubKeyGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	public void set_a(byte[] val) {
		Bindings.PayeePubKeySetA(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PayeePubKey given each field
	 */
	public static PayeePubKey of(byte[] a_arg) {
		long ret = Bindings.PayeePubKeyNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a_arg, 33)));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PayeePubKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PayeePubKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.PayeePubKeyClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PayeePubKey
	 */
	public PayeePubKey clone() {
		long ret = Bindings.PayeePubKeyClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PayeePubKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PayeePubKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the PayeePubKey.
	 */
	public long hash() {
		long ret = Bindings.PayeePubKeyHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two PayeePubKeys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.PayeePubKey b) {
		bool ret = Bindings.PayeePubKeyEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is PayeePubKey)) return false;
		return this.eq((PayeePubKey)o);
	}
}
} } }
