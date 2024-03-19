using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An [`announcement_signatures`] message to be sent to or received from a peer.
 * 
 * [`announcement_signatures`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-announcement_signatures-message
 */
public class AnnouncementSignatures : CommonBase {
	internal AnnouncementSignatures(object _dummy, long ptr) : base(ptr) { }
	~AnnouncementSignatures() {
		if (ptr != 0) { Bindings.AnnouncementSignaturesFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.AnnouncementSignaturesGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.AnnouncementSignaturesSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The short channel ID
	 */
	public long get_short_channel_id() {
		long ret = Bindings.AnnouncementSignaturesGetShortChannelId(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The short channel ID
	 */
	public void set_short_channel_id(long val) {
		Bindings.AnnouncementSignaturesSetShortChannelId(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A signature by the node key
	 */
	public byte[] get_node_signature() {
		long ret = Bindings.AnnouncementSignaturesGetNodeSignature(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * A signature by the node key
	 */
	public void set_node_signature(byte[] val) {
		Bindings.AnnouncementSignaturesSetNodeSignature(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 64)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A signature by the funding key
	 */
	public byte[] get_bitcoin_signature() {
		long ret = Bindings.AnnouncementSignaturesGetBitcoinSignature(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * A signature by the funding key
	 */
	public void set_bitcoin_signature(byte[] val) {
		Bindings.AnnouncementSignaturesSetBitcoinSignature(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 64)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new AnnouncementSignatures given each field
	 */
	public static AnnouncementSignatures of(byte[] channel_id_arg, long short_channel_id_arg, byte[] node_signature_arg, byte[] bitcoin_signature_arg) {
		long ret = Bindings.AnnouncementSignaturesNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), short_channel_id_arg, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_signature_arg, 64)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(bitcoin_signature_arg, 64)));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(short_channel_id_arg);
		GC.KeepAlive(node_signature_arg);
		GC.KeepAlive(bitcoin_signature_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AnnouncementSignatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.AnnouncementSignatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.AnnouncementSignaturesClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the AnnouncementSignatures
	 */
	public AnnouncementSignatures clone() {
		long ret = Bindings.AnnouncementSignaturesClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AnnouncementSignatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.AnnouncementSignatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the AnnouncementSignatures.
	 */
	public long hash() {
		long ret = Bindings.AnnouncementSignaturesHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two AnnouncementSignaturess contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.AnnouncementSignatures b) {
		bool ret = Bindings.AnnouncementSignaturesEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is AnnouncementSignatures)) return false;
		return this.eq((AnnouncementSignatures)o);
	}
	/**
	 * Serialize the AnnouncementSignatures object into a byte array which can be read by AnnouncementSignatures_read
	 */
	public byte[] write() {
		long ret = Bindings.AnnouncementSignaturesWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a AnnouncementSignatures from a byte array, created by AnnouncementSignatures_write
	 */
	public static Result_AnnouncementSignaturesDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.AnnouncementSignaturesRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AnnouncementSignaturesDecodeErrorZ ret_hu_conv = Result_AnnouncementSignaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
