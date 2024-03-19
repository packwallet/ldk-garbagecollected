using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A derived key built from a [`HtlcBasepoint`] and `per_commitment_point`.
 * 
 * HTLC keys are used to ensure only the recipient of an HTLC can claim it on-chain with the HTLC
 * preimage and that only the sender of an HTLC can claim it on-chain after it has timed out.
 * Thus, both channel counterparties' HTLC keys will appears in each HTLC output's script.
 * 
 * [See the BOLT specs]
 * (https://github.com/lightning/bolts/blob/master/03-transactions.md#localpubkey-local_htlcpubkey-remote_htlcpubkey-local_delayedpubkey-and-remote_delayedpubkey-derivation)
 * for more information on key derivation details.
 */
public class HtlcKey : CommonBase {
	internal HtlcKey(object _dummy, long ptr) : base(ptr) { }
	~HtlcKey() {
		if (ptr != 0) { Bindings.HtlcKeyFree(ptr); }
	}

	public byte[] get_a() {
		long ret = Bindings.HtlcKeyGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	public void set_a(byte[] val) {
		Bindings.HtlcKeySetA(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new HtlcKey given each field
	 */
	public static HtlcKey of(byte[] a_arg) {
		long ret = Bindings.HtlcKeyNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a_arg, 33)));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two HtlcKeys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.HtlcKey b) {
		bool ret = Bindings.HtlcKeyEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is HtlcKey)) return false;
		return this.eq((HtlcKey)o);
	}
	internal long clone_ptr() {
		long ret = Bindings.HtlcKeyClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the HtlcKey
	 */
	public HtlcKey clone() {
		long ret = Bindings.HtlcKeyClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Derive a public htlcpubkey using one node\'s `per_commitment_point` and its countersignatory\'s `basepoint`
	 */
	public static HtlcKey from_basepoint(org.ldk.structs.HtlcBasepoint countersignatory_basepoint, byte[] per_commitment_point) {
		long ret = Bindings.HtlcKeyFromBasepoint(countersignatory_basepoint == null ? 0 : countersignatory_basepoint.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(per_commitment_point, 33)));
		GC.KeepAlive(countersignatory_basepoint);
		GC.KeepAlive(per_commitment_point);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(countersignatory_basepoint); };
		return ret_hu_conv;
	}

	/**
	 * Build a htlcpubkey directly from an already-derived private key
	 */
	public static HtlcKey from_secret_key(byte[] sk) {
		long ret = Bindings.HtlcKeyFromSecretKey(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(sk, 32)));
		GC.KeepAlive(sk);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Get inner Public Key
	 */
	public byte[] to_public_key() {
		long ret = Bindings.HtlcKeyToPublicKey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Serialize the HtlcKey object into a byte array which can be read by HtlcKey_read
	 */
	public byte[] write() {
		long ret = Bindings.HtlcKeyWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a HtlcKey from a byte array, created by HtlcKey_write
	 */
	public static Result_HtlcKeyDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.HtlcKeyRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcKeyDecodeErrorZ ret_hu_conv = Result_HtlcKeyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
