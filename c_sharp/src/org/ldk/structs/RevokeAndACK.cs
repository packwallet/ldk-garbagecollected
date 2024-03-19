using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`revoke_and_ack`] message to be sent to or received from a peer.
 * 
 * [`revoke_and_ack`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#completing-the-transition-to-the-updated-state-revoke_and_ack
 */
public class RevokeAndACK : CommonBase {
	internal RevokeAndACK(object _dummy, long ptr) : base(ptr) { }
	~RevokeAndACK() {
		if (ptr != 0) { Bindings.RevokeAndACKFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.RevokeAndACKGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.RevokeAndACKSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The secret corresponding to the per-commitment point
	 */
	public byte[] get_per_commitment_secret() {
		long ret = Bindings.RevokeAndACKGetPerCommitmentSecret(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The secret corresponding to the per-commitment point
	 */
	public void set_per_commitment_secret(byte[] val) {
		Bindings.RevokeAndACKSetPerCommitmentSecret(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The next sender-broadcast commitment transaction's per-commitment point
	 */
	public byte[] get_next_per_commitment_point() {
		long ret = Bindings.RevokeAndACKGetNextPerCommitmentPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The next sender-broadcast commitment transaction's per-commitment point
	 */
	public void set_next_per_commitment_point(byte[] val) {
		Bindings.RevokeAndACKSetNextPerCommitmentPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new RevokeAndACK given each field
	 */
	public static RevokeAndACK of(byte[] channel_id_arg, byte[] per_commitment_secret_arg, byte[] next_per_commitment_point_arg) {
		long ret = Bindings.RevokeAndACKNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(per_commitment_secret_arg, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(next_per_commitment_point_arg, 33)));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(per_commitment_secret_arg);
		GC.KeepAlive(next_per_commitment_point_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RevokeAndACK ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RevokeAndACK(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.RevokeAndACKClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the RevokeAndACK
	 */
	public RevokeAndACK clone() {
		long ret = Bindings.RevokeAndACKClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RevokeAndACK ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RevokeAndACK(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the RevokeAndACK.
	 */
	public long hash() {
		long ret = Bindings.RevokeAndACKHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two RevokeAndACKs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.RevokeAndACK b) {
		bool ret = Bindings.RevokeAndACKEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is RevokeAndACK)) return false;
		return this.eq((RevokeAndACK)o);
	}
	/**
	 * Serialize the RevokeAndACK object into a byte array which can be read by RevokeAndACK_read
	 */
	public byte[] write() {
		long ret = Bindings.RevokeAndACKWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a RevokeAndACK from a byte array, created by RevokeAndACK_write
	 */
	public static Result_RevokeAndACKDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.RevokeAndACKRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
