using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Base key used in conjunction with a `per_commitment_point` to generate an [`HtlcKey`].
 * 
 * HTLC keys are used to ensure only the recipient of an HTLC can claim it on-chain with the HTLC
 * preimage and that only the sender of an HTLC can claim it on-chain after it has timed out.
 * Thus, both channel counterparties' HTLC keys will appears in each HTLC output's script.
 */
public class HtlcBasepoint : CommonBase {
	internal HtlcBasepoint(object _dummy, long ptr) : base(ptr) { }
	~HtlcBasepoint() {
		if (ptr != 0) { Bindings.HtlcBasepointFree(ptr); }
	}

	public byte[] get_a() {
		long ret = Bindings.HtlcBasepointGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	public void set_a(byte[] val) {
		Bindings.HtlcBasepointSetA(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new HtlcBasepoint given each field
	 */
	public static HtlcBasepoint of(byte[] a_arg) {
		long ret = Bindings.HtlcBasepointNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a_arg, 33)));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcBasepoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcBasepoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two HtlcBasepoints contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.HtlcBasepoint b) {
		bool ret = Bindings.HtlcBasepointEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is HtlcBasepoint)) return false;
		return this.eq((HtlcBasepoint)o);
	}
	internal long clone_ptr() {
		long ret = Bindings.HtlcBasepointClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the HtlcBasepoint
	 */
	public HtlcBasepoint clone() {
		long ret = Bindings.HtlcBasepointClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcBasepoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcBasepoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the HtlcBasepoint.
	 */
	public long hash() {
		long ret = Bindings.HtlcBasepointHash(this.ptr);
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
		long ret = Bindings.HtlcBasepointToPublicKey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Serialize the HtlcBasepoint object into a byte array which can be read by HtlcBasepoint_read
	 */
	public byte[] write() {
		long ret = Bindings.HtlcBasepointWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a HtlcBasepoint from a byte array, created by HtlcBasepoint_write
	 */
	public static Result_HtlcBasepointDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.HtlcBasepointRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcBasepointDecodeErrorZ ret_hu_conv = Result_HtlcBasepointDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
