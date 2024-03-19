using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Information used to forward or fail this HTLC that is being forwarded within a blinded path.
 */
public class BlindedForward : CommonBase {
	internal BlindedForward(object _dummy, long ptr) : base(ptr) { }
	~BlindedForward() {
		if (ptr != 0) { Bindings.BlindedForwardFree(ptr); }
	}

	/**
	 * The `blinding_point` that was set in the inbound [`msgs::UpdateAddHTLC`], or in the inbound
	 * onion payload if we're the introduction node. Useful for calculating the next hop's
	 * [`msgs::UpdateAddHTLC::blinding_point`].
	 */
	public byte[] get_inbound_blinding_point() {
		long ret = Bindings.BlindedForwardGetInboundBlindingPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The `blinding_point` that was set in the inbound [`msgs::UpdateAddHTLC`], or in the inbound
	 * onion payload if we're the introduction node. Useful for calculating the next hop's
	 * [`msgs::UpdateAddHTLC::blinding_point`].
	 */
	public void set_inbound_blinding_point(byte[] val) {
		Bindings.BlindedForwardSetInboundBlindingPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If needed, this determines how this HTLC should be failed backwards, based on whether we are
	 * the introduction node.
	 */
	public BlindedFailure get_failure() {
		BlindedFailure ret = Bindings.BlindedForwardGetFailure(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * If needed, this determines how this HTLC should be failed backwards, based on whether we are
	 * the introduction node.
	 */
	public void set_failure(BlindedFailure val) {
		Bindings.BlindedForwardSetFailure(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new BlindedForward given each field
	 */
	public static BlindedForward of(byte[] inbound_blinding_point_arg, BlindedFailure failure_arg) {
		long ret = Bindings.BlindedForwardNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(inbound_blinding_point_arg, 33)), failure_arg);
		GC.KeepAlive(inbound_blinding_point_arg);
		GC.KeepAlive(failure_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedForward ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedForward(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.BlindedForwardClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BlindedForward
	 */
	public BlindedForward clone() {
		long ret = Bindings.BlindedForwardClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedForward ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedForward(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the BlindedForward.
	 */
	public long hash() {
		long ret = Bindings.BlindedForwardHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two BlindedForwards contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.BlindedForward b) {
		bool ret = Bindings.BlindedForwardEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BlindedForward)) return false;
		return this.eq((BlindedForward)o);
	}
	/**
	 * Serialize the BlindedForward object into a byte array which can be read by BlindedForward_read
	 */
	public byte[] write() {
		long ret = Bindings.BlindedForwardWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a BlindedForward from a byte array, created by BlindedForward_write
	 */
	public static Result_BlindedForwardDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.BlindedForwardRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedForwardDecodeErrorZ ret_hu_conv = Result_BlindedForwardDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
