using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The unsigned part of a [`channel_update`] message.
 * 
 * [`channel_update`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-channel_update-message
 */
public class UnsignedChannelUpdate : CommonBase {
	internal UnsignedChannelUpdate(object _dummy, long ptr) : base(ptr) { }
	~UnsignedChannelUpdate() {
		if (ptr != 0) { Bindings.UnsignedChannelUpdateFree(ptr); }
	}

	/**
	 * The genesis hash of the blockchain where the channel is to be opened
	 */
	public byte[] get_chain_hash() {
		long ret = Bindings.UnsignedChannelUpdateGetChainHash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The genesis hash of the blockchain where the channel is to be opened
	 */
	public void set_chain_hash(byte[] val) {
		Bindings.UnsignedChannelUpdateSetChainHash(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The short channel ID
	 */
	public long get_short_channel_id() {
		long ret = Bindings.UnsignedChannelUpdateGetShortChannelId(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The short channel ID
	 */
	public void set_short_channel_id(long val) {
		Bindings.UnsignedChannelUpdateSetShortChannelId(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A strictly monotonic announcement counter, with gaps allowed, specific to this channel
	 */
	public int get_timestamp() {
		int ret = Bindings.UnsignedChannelUpdateGetTimestamp(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A strictly monotonic announcement counter, with gaps allowed, specific to this channel
	 */
	public void set_timestamp(int val) {
		Bindings.UnsignedChannelUpdateSetTimestamp(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Channel flags
	 */
	public byte get_flags() {
		byte ret = Bindings.UnsignedChannelUpdateGetFlags(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Channel flags
	 */
	public void set_flags(byte val) {
		Bindings.UnsignedChannelUpdateSetFlags(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of blocks such that if:
	 * `incoming_htlc.cltv_expiry < outgoing_htlc.cltv_expiry + cltv_expiry_delta`
	 * then we need to fail the HTLC backwards. When forwarding an HTLC, `cltv_expiry_delta` determines
	 * the outgoing HTLC's minimum `cltv_expiry` value -- so, if an incoming HTLC comes in with a
	 * `cltv_expiry` of 100000, and the node we're forwarding to has a `cltv_expiry_delta` value of 10,
	 * then we'll check that the outgoing HTLC's `cltv_expiry` value is at least 100010 before
	 * forwarding. Note that the HTLC sender is the one who originally sets this value when
	 * constructing the route.
	 */
	public short get_cltv_expiry_delta() {
		short ret = Bindings.UnsignedChannelUpdateGetCltvExpiryDelta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The number of blocks such that if:
	 * `incoming_htlc.cltv_expiry < outgoing_htlc.cltv_expiry + cltv_expiry_delta`
	 * then we need to fail the HTLC backwards. When forwarding an HTLC, `cltv_expiry_delta` determines
	 * the outgoing HTLC's minimum `cltv_expiry` value -- so, if an incoming HTLC comes in with a
	 * `cltv_expiry` of 100000, and the node we're forwarding to has a `cltv_expiry_delta` value of 10,
	 * then we'll check that the outgoing HTLC's `cltv_expiry` value is at least 100010 before
	 * forwarding. Note that the HTLC sender is the one who originally sets this value when
	 * constructing the route.
	 */
	public void set_cltv_expiry_delta(short val) {
		Bindings.UnsignedChannelUpdateSetCltvExpiryDelta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum HTLC size incoming to sender, in milli-satoshi
	 */
	public long get_htlc_minimum_msat() {
		long ret = Bindings.UnsignedChannelUpdateGetHtlcMinimumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum HTLC size incoming to sender, in milli-satoshi
	 */
	public void set_htlc_minimum_msat(long val) {
		Bindings.UnsignedChannelUpdateSetHtlcMinimumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum HTLC value incoming to sender, in milli-satoshi.
	 * 
	 * This used to be optional.
	 */
	public long get_htlc_maximum_msat() {
		long ret = Bindings.UnsignedChannelUpdateGetHtlcMaximumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum HTLC value incoming to sender, in milli-satoshi.
	 * 
	 * This used to be optional.
	 */
	public void set_htlc_maximum_msat(long val) {
		Bindings.UnsignedChannelUpdateSetHtlcMaximumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The base HTLC fee charged by sender, in milli-satoshi
	 */
	public int get_fee_base_msat() {
		int ret = Bindings.UnsignedChannelUpdateGetFeeBaseMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The base HTLC fee charged by sender, in milli-satoshi
	 */
	public void set_fee_base_msat(int val) {
		Bindings.UnsignedChannelUpdateSetFeeBaseMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The amount to fee multiplier, in micro-satoshi
	 */
	public int get_fee_proportional_millionths() {
		int ret = Bindings.UnsignedChannelUpdateGetFeeProportionalMillionths(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The amount to fee multiplier, in micro-satoshi
	 */
	public void set_fee_proportional_millionths(int val) {
		Bindings.UnsignedChannelUpdateSetFeeProportionalMillionths(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Excess data which was signed as a part of the message which we do not (yet) understand how
	 * to decode.
	 * 
	 * This is stored to ensure forward-compatibility as new fields are added to the lightning gossip protocol.
	 * 
	 * Returns a copy of the field.
	 */
	public byte[] get_excess_data() {
		long ret = Bindings.UnsignedChannelUpdateGetExcessData(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Excess data which was signed as a part of the message which we do not (yet) understand how
	 * to decode.
	 * 
	 * This is stored to ensure forward-compatibility as new fields are added to the lightning gossip protocol.
	 */
	public void set_excess_data(byte[] val) {
		Bindings.UnsignedChannelUpdateSetExcessData(this.ptr, InternalUtils.EncodeUint8Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UnsignedChannelUpdate given each field
	 */
	public static UnsignedChannelUpdate of(byte[] chain_hash_arg, long short_channel_id_arg, int timestamp_arg, byte flags_arg, short cltv_expiry_delta_arg, long htlc_minimum_msat_arg, long htlc_maximum_msat_arg, int fee_base_msat_arg, int fee_proportional_millionths_arg, byte[] excess_data_arg) {
		long ret = Bindings.UnsignedChannelUpdateNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(chain_hash_arg, 32)), short_channel_id_arg, timestamp_arg, flags_arg, cltv_expiry_delta_arg, htlc_minimum_msat_arg, htlc_maximum_msat_arg, fee_base_msat_arg, fee_proportional_millionths_arg, InternalUtils.EncodeUint8Array(excess_data_arg));
		GC.KeepAlive(chain_hash_arg);
		GC.KeepAlive(short_channel_id_arg);
		GC.KeepAlive(timestamp_arg);
		GC.KeepAlive(flags_arg);
		GC.KeepAlive(cltv_expiry_delta_arg);
		GC.KeepAlive(htlc_minimum_msat_arg);
		GC.KeepAlive(htlc_maximum_msat_arg);
		GC.KeepAlive(fee_base_msat_arg);
		GC.KeepAlive(fee_proportional_millionths_arg);
		GC.KeepAlive(excess_data_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.UnsignedChannelUpdateClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UnsignedChannelUpdate
	 */
	public UnsignedChannelUpdate clone() {
		long ret = Bindings.UnsignedChannelUpdateClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedChannelUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedChannelUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the UnsignedChannelUpdate.
	 */
	public long hash() {
		long ret = Bindings.UnsignedChannelUpdateHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two UnsignedChannelUpdates contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UnsignedChannelUpdate b) {
		bool ret = Bindings.UnsignedChannelUpdateEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UnsignedChannelUpdate)) return false;
		return this.eq((UnsignedChannelUpdate)o);
	}
	/**
	 * Serialize the UnsignedChannelUpdate object into a byte array which can be read by UnsignedChannelUpdate_read
	 */
	public byte[] write() {
		long ret = Bindings.UnsignedChannelUpdateWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UnsignedChannelUpdate from a byte array, created by UnsignedChannelUpdate_write
	 */
	public static Result_UnsignedChannelUpdateDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.UnsignedChannelUpdateRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UnsignedChannelUpdateDecodeErrorZ ret_hu_conv = Result_UnsignedChannelUpdateDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
