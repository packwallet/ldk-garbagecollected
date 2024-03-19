using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A derived key built from a [`DelayedPaymentBasepoint`] and `per_commitment_point`.
 * 
 * The delayed payment key is used to pay the commitment state broadcaster their
 * non-HTLC-encumbered funds after a delay. This delay gives their counterparty a chance to
 * punish and claim all the channel funds if the state broadcasted was previously revoked.
 * 
 * [See the BOLT specs]
 * (https://github.com/lightning/bolts/blob/master/03-transactions.md#localpubkey-local_htlcpubkey-remote_htlcpubkey-local_delayedpubkey-and-remote_delayedpubkey-derivation)
 * for more information on key derivation details.
 */
public class DelayedPaymentKey : CommonBase {
	internal DelayedPaymentKey(object _dummy, long ptr) : base(ptr) { }
	~DelayedPaymentKey() {
		if (ptr != 0) { Bindings.DelayedPaymentKeyFree(ptr); }
	}

	public byte[] get_a() {
		long ret = Bindings.DelayedPaymentKeyGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	public void set_a(byte[] val) {
		Bindings.DelayedPaymentKeySetA(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new DelayedPaymentKey given each field
	 */
	public static DelayedPaymentKey of(byte[] a_arg) {
		long ret = Bindings.DelayedPaymentKeyNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a_arg, 33)));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two DelayedPaymentKeys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.DelayedPaymentKey b) {
		bool ret = Bindings.DelayedPaymentKeyEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is DelayedPaymentKey)) return false;
		return this.eq((DelayedPaymentKey)o);
	}
	internal long clone_ptr() {
		long ret = Bindings.DelayedPaymentKeyClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the DelayedPaymentKey
	 */
	public DelayedPaymentKey clone() {
		long ret = Bindings.DelayedPaymentKeyClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Derive a public delayedpubkey using one node\'s `per_commitment_point` and its countersignatory\'s `basepoint`
	 */
	public static DelayedPaymentKey from_basepoint(org.ldk.structs.DelayedPaymentBasepoint countersignatory_basepoint, byte[] per_commitment_point) {
		long ret = Bindings.DelayedPaymentKeyFromBasepoint(countersignatory_basepoint == null ? 0 : countersignatory_basepoint.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(per_commitment_point, 33)));
		GC.KeepAlive(countersignatory_basepoint);
		GC.KeepAlive(per_commitment_point);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(countersignatory_basepoint); };
		return ret_hu_conv;
	}

	/**
	 * Build a delayedpubkey directly from an already-derived private key
	 */
	public static DelayedPaymentKey from_secret_key(byte[] sk) {
		long ret = Bindings.DelayedPaymentKeyFromSecretKey(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(sk, 32)));
		GC.KeepAlive(sk);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Get inner Public Key
	 */
	public byte[] to_public_key() {
		long ret = Bindings.DelayedPaymentKeyToPublicKey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Serialize the DelayedPaymentKey object into a byte array which can be read by DelayedPaymentKey_read
	 */
	public byte[] write() {
		long ret = Bindings.DelayedPaymentKeyWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a DelayedPaymentKey from a byte array, created by DelayedPaymentKey_write
	 */
	public static Result_DelayedPaymentKeyDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.DelayedPaymentKeyRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentKeyDecodeErrorZ ret_hu_conv = Result_DelayedPaymentKeyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
