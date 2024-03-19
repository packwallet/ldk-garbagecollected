using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An encrypted payload and node id corresponding to a hop in a payment or onion message path, to
 * be encoded in the sender's onion packet. These hops cannot be identified by outside observers
 * and thus can be used to hide the identity of the recipient.
 */
public class BlindedHop : CommonBase {
	internal BlindedHop(object _dummy, long ptr) : base(ptr) { }
	~BlindedHop() {
		if (ptr != 0) { Bindings.BlindedHopFree(ptr); }
	}

	/**
	 * The blinded node id of this hop in a [`BlindedPath`].
	 */
	public byte[] get_blinded_node_id() {
		long ret = Bindings.BlindedHopGetBlindedNodeId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The blinded node id of this hop in a [`BlindedPath`].
	 */
	public void set_blinded_node_id(byte[] val) {
		Bindings.BlindedHopSetBlindedNodeId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The encrypted payload intended for this hop in a [`BlindedPath`].
	 * 
	 * Returns a copy of the field.
	 */
	public byte[] get_encrypted_payload() {
		long ret = Bindings.BlindedHopGetEncryptedPayload(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The encrypted payload intended for this hop in a [`BlindedPath`].
	 */
	public void set_encrypted_payload(byte[] val) {
		Bindings.BlindedHopSetEncryptedPayload(this.ptr, InternalUtils.EncodeUint8Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new BlindedHop given each field
	 */
	public static BlindedHop of(byte[] blinded_node_id_arg, byte[] encrypted_payload_arg) {
		long ret = Bindings.BlindedHopNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(blinded_node_id_arg, 33)), InternalUtils.EncodeUint8Array(encrypted_payload_arg));
		GC.KeepAlive(blinded_node_id_arg);
		GC.KeepAlive(encrypted_payload_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.BlindedHopClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BlindedHop
	 */
	public BlindedHop clone() {
		long ret = Bindings.BlindedHopClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the BlindedHop.
	 */
	public long hash() {
		long ret = Bindings.BlindedHopHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two BlindedHops contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.BlindedHop b) {
		bool ret = Bindings.BlindedHopEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BlindedHop)) return false;
		return this.eq((BlindedHop)o);
	}
	/**
	 * Serialize the BlindedHop object into a byte array which can be read by BlindedHop_read
	 */
	public byte[] write() {
		long ret = Bindings.BlindedHopWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a BlindedHop from a byte array, created by BlindedHop_write
	 */
	public static Result_BlindedHopDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.BlindedHopRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedHopDecodeErrorZ ret_hu_conv = Result_BlindedHopDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
