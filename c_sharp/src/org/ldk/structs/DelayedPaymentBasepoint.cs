using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Base key used in conjunction with a `per_commitment_point` to generate a [`DelayedPaymentKey`].
 * 
 * The delayed payment key is used to pay the commitment state broadcaster their
 * non-HTLC-encumbered funds after a delay to give their counterparty a chance to punish if the
 * state broadcasted was previously revoked.
 */
public class DelayedPaymentBasepoint : CommonBase {
	internal DelayedPaymentBasepoint(object _dummy, long ptr) : base(ptr) { }
	~DelayedPaymentBasepoint() {
		if (ptr != 0) { Bindings.DelayedPaymentBasepointFree(ptr); }
	}

	public byte[] get_a() {
		long ret = Bindings.DelayedPaymentBasepointGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	public void set_a(byte[] val) {
		Bindings.DelayedPaymentBasepointSetA(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new DelayedPaymentBasepoint given each field
	 */
	public static DelayedPaymentBasepoint of(byte[] a_arg) {
		long ret = Bindings.DelayedPaymentBasepointNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a_arg, 33)));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentBasepoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentBasepoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two DelayedPaymentBasepoints contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.DelayedPaymentBasepoint b) {
		bool ret = Bindings.DelayedPaymentBasepointEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is DelayedPaymentBasepoint)) return false;
		return this.eq((DelayedPaymentBasepoint)o);
	}
	internal long clone_ptr() {
		long ret = Bindings.DelayedPaymentBasepointClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the DelayedPaymentBasepoint
	 */
	public DelayedPaymentBasepoint clone() {
		long ret = Bindings.DelayedPaymentBasepointClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentBasepoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentBasepoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the DelayedPaymentBasepoint.
	 */
	public long hash() {
		long ret = Bindings.DelayedPaymentBasepointHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Get inner Public Key
	 */
	public byte[] to_public_key() {
		long ret = Bindings.DelayedPaymentBasepointToPublicKey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Serialize the DelayedPaymentBasepoint object into a byte array which can be read by DelayedPaymentBasepoint_read
	 */
	public byte[] write() {
		long ret = Bindings.DelayedPaymentBasepointWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a DelayedPaymentBasepoint from a byte array, created by DelayedPaymentBasepoint_write
	 */
	public static Result_DelayedPaymentBasepointDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.DelayedPaymentBasepointRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentBasepointDecodeErrorZ ret_hu_conv = Result_DelayedPaymentBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
