using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`channel_ready`] message to be sent to or received from a peer.
 * 
 * [`channel_ready`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#the-channel_ready-message
 */
public class ChannelReady : CommonBase {
	internal ChannelReady(object _dummy, long ptr) : base(ptr) { }
	~ChannelReady() {
		if (ptr != 0) { Bindings.ChannelReadyFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.ChannelReadyGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.ChannelReadySetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The per-commitment point of the second commitment transaction
	 */
	public byte[] get_next_per_commitment_point() {
		long ret = Bindings.ChannelReadyGetNextPerCommitmentPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The per-commitment point of the second commitment transaction
	 */
	public void set_next_per_commitment_point(byte[] val) {
		Bindings.ChannelReadySetNextPerCommitmentPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If set, provides a `short_channel_id` alias for this channel.
	 * 
	 * The sender will accept payments to be forwarded over this SCID and forward them to this
	 * messages' recipient.
	 */
	public Option_u64Z get_short_channel_id_alias() {
		long ret = Bindings.ChannelReadyGetShortChannelIdAlias(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * If set, provides a `short_channel_id` alias for this channel.
	 * 
	 * The sender will accept payments to be forwarded over this SCID and forward them to this
	 * messages' recipient.
	 */
	public void set_short_channel_id_alias(org.ldk.structs.Option_u64Z val) {
		Bindings.ChannelReadySetShortChannelIdAlias(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ChannelReady given each field
	 */
	public static ChannelReady of(byte[] channel_id_arg, byte[] next_per_commitment_point_arg, org.ldk.structs.Option_u64Z short_channel_id_alias_arg) {
		long ret = Bindings.ChannelReadyNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(next_per_commitment_point_arg, 33)), short_channel_id_alias_arg.ptr);
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(next_per_commitment_point_arg);
		GC.KeepAlive(short_channel_id_alias_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelReady ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelReady(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(short_channel_id_alias_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ChannelReadyClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelReady
	 */
	public ChannelReady clone() {
		long ret = Bindings.ChannelReadyClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelReady ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelReady(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelReady.
	 */
	public long hash() {
		long ret = Bindings.ChannelReadyHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelReadys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelReady b) {
		bool ret = Bindings.ChannelReadyEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelReady)) return false;
		return this.eq((ChannelReady)o);
	}
	/**
	 * Serialize the ChannelReady object into a byte array which can be read by ChannelReady_read
	 */
	public byte[] write() {
		long ret = Bindings.ChannelReadyWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelReady from a byte array, created by ChannelReady_write
	 */
	public static Result_ChannelReadyDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ChannelReadyRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelReadyDecodeErrorZ ret_hu_conv = Result_ChannelReadyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
