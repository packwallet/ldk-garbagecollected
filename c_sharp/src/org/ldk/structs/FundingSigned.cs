using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`funding_signed`] message to be sent to or received from a peer.
 * 
 * Used in V1 channel establishment
 * 
 * [`funding_signed`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#the-funding_signed-message
 */
public class FundingSigned : CommonBase {
	internal FundingSigned(object _dummy, long ptr) : base(ptr) { }
	~FundingSigned() {
		if (ptr != 0) { Bindings.FundingSignedFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.FundingSignedGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.FundingSignedSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The signature of the channel acceptor (fundee) on the initial commitment transaction
	 */
	public byte[] get_signature() {
		long ret = Bindings.FundingSignedGetSignature(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The signature of the channel acceptor (fundee) on the initial commitment transaction
	 */
	public void set_signature(byte[] val) {
		Bindings.FundingSignedSetSignature(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 64)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new FundingSigned given each field
	 */
	public static FundingSigned of(byte[] channel_id_arg, byte[] signature_arg) {
		long ret = Bindings.FundingSignedNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(signature_arg, 64)));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(signature_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.FundingSignedClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the FundingSigned
	 */
	public FundingSigned clone() {
		long ret = Bindings.FundingSignedClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the FundingSigned.
	 */
	public long hash() {
		long ret = Bindings.FundingSignedHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two FundingSigneds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.FundingSigned b) {
		bool ret = Bindings.FundingSignedEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is FundingSigned)) return false;
		return this.eq((FundingSigned)o);
	}
	/**
	 * Serialize the FundingSigned object into a byte array which can be read by FundingSigned_read
	 */
	public byte[] write() {
		long ret = Bindings.FundingSignedWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a FundingSigned from a byte array, created by FundingSigned_write
	 */
	public static Result_FundingSignedDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.FundingSignedRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingSignedDecodeErrorZ ret_hu_conv = Result_FundingSignedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
