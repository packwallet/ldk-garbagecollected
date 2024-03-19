using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Channel parameters which apply to our counterparty. These are split out from [`ChannelDetails`]
 * to better separate parameters.
 */
public class ChannelCounterparty : CommonBase {
	internal ChannelCounterparty(object _dummy, long ptr) : base(ptr) { }
	~ChannelCounterparty() {
		if (ptr != 0) { Bindings.ChannelCounterpartyFree(ptr); }
	}

	/**
	 * The node_id of our counterparty
	 */
	public byte[] get_node_id() {
		long ret = Bindings.ChannelCounterpartyGetNodeId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The node_id of our counterparty
	 */
	public void set_node_id(byte[] val) {
		Bindings.ChannelCounterpartySetNodeId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The Features the channel counterparty provided upon last connection.
	 * Useful for routing as it is the most up-to-date copy of the counterparty's features and
	 * many routing-relevant features are present in the init context.
	 */
	public InitFeatures get_features() {
		long ret = Bindings.ChannelCounterpartyGetFeatures(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InitFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InitFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The Features the channel counterparty provided upon last connection.
	 * Useful for routing as it is the most up-to-date copy of the counterparty's features and
	 * many routing-relevant features are present in the init context.
	 */
	public void set_features(org.ldk.structs.InitFeatures val) {
		Bindings.ChannelCounterpartySetFeatures(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The value, in satoshis, that must always be held in the channel for our counterparty. This
	 * value ensures that if our counterparty broadcasts a revoked state, we can punish them by
	 * claiming at least this value on chain.
	 * 
	 * This value is not included in [`inbound_capacity_msat`] as it can never be spent.
	 * 
	 * [`inbound_capacity_msat`]: ChannelDetails::inbound_capacity_msat
	 */
	public long get_unspendable_punishment_reserve() {
		long ret = Bindings.ChannelCounterpartyGetUnspendablePunishmentReserve(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The value, in satoshis, that must always be held in the channel for our counterparty. This
	 * value ensures that if our counterparty broadcasts a revoked state, we can punish them by
	 * claiming at least this value on chain.
	 * 
	 * This value is not included in [`inbound_capacity_msat`] as it can never be spent.
	 * 
	 * [`inbound_capacity_msat`]: ChannelDetails::inbound_capacity_msat
	 */
	public void set_unspendable_punishment_reserve(long val) {
		Bindings.ChannelCounterpartySetUnspendablePunishmentReserve(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Information on the fees and requirements that the counterparty requires when forwarding
	 * payments to us through this channel.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public CounterpartyForwardingInfo get_forwarding_info() {
		long ret = Bindings.ChannelCounterpartyGetForwardingInfo(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyForwardingInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyForwardingInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Information on the fees and requirements that the counterparty requires when forwarding
	 * payments to us through this channel.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_forwarding_info(org.ldk.structs.CounterpartyForwardingInfo val) {
		Bindings.ChannelCounterpartySetForwardingInfo(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The smallest value HTLC (in msat) the remote peer will accept, for this channel. This field
	 * is only `None` before we have received either the `OpenChannel` or `AcceptChannel` message
	 * from the remote peer, or for `ChannelCounterparty` objects serialized prior to LDK 0.0.107.
	 */
	public Option_u64Z get_outbound_htlc_minimum_msat() {
		long ret = Bindings.ChannelCounterpartyGetOutboundHtlcMinimumMsat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The smallest value HTLC (in msat) the remote peer will accept, for this channel. This field
	 * is only `None` before we have received either the `OpenChannel` or `AcceptChannel` message
	 * from the remote peer, or for `ChannelCounterparty` objects serialized prior to LDK 0.0.107.
	 */
	public void set_outbound_htlc_minimum_msat(org.ldk.structs.Option_u64Z val) {
		Bindings.ChannelCounterpartySetOutboundHtlcMinimumMsat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The largest value HTLC (in msat) the remote peer currently will accept, for this channel.
	 */
	public Option_u64Z get_outbound_htlc_maximum_msat() {
		long ret = Bindings.ChannelCounterpartyGetOutboundHtlcMaximumMsat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The largest value HTLC (in msat) the remote peer currently will accept, for this channel.
	 */
	public void set_outbound_htlc_maximum_msat(org.ldk.structs.Option_u64Z val) {
		Bindings.ChannelCounterpartySetOutboundHtlcMaximumMsat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ChannelCounterparty given each field
	 * 
	 * Note that forwarding_info_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static ChannelCounterparty of(byte[] node_id_arg, org.ldk.structs.InitFeatures features_arg, long unspendable_punishment_reserve_arg, org.ldk.structs.CounterpartyForwardingInfo forwarding_info_arg, org.ldk.structs.Option_u64Z outbound_htlc_minimum_msat_arg, org.ldk.structs.Option_u64Z outbound_htlc_maximum_msat_arg) {
		long ret = Bindings.ChannelCounterpartyNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_id_arg, 33)), features_arg == null ? 0 : features_arg.ptr, unspendable_punishment_reserve_arg, forwarding_info_arg == null ? 0 : forwarding_info_arg.ptr, outbound_htlc_minimum_msat_arg.ptr, outbound_htlc_maximum_msat_arg.ptr);
		GC.KeepAlive(node_id_arg);
		GC.KeepAlive(features_arg);
		GC.KeepAlive(unspendable_punishment_reserve_arg);
		GC.KeepAlive(forwarding_info_arg);
		GC.KeepAlive(outbound_htlc_minimum_msat_arg);
		GC.KeepAlive(outbound_htlc_maximum_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelCounterparty ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelCounterparty(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(features_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(forwarding_info_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(outbound_htlc_minimum_msat_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(outbound_htlc_maximum_msat_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ChannelCounterpartyClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelCounterparty
	 */
	public ChannelCounterparty clone() {
		long ret = Bindings.ChannelCounterpartyClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelCounterparty ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelCounterparty(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelCounterparty object into a byte array which can be read by ChannelCounterparty_read
	 */
	public byte[] write() {
		long ret = Bindings.ChannelCounterpartyWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelCounterparty from a byte array, created by ChannelCounterparty_write
	 */
	public static Result_ChannelCounterpartyDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ChannelCounterpartyRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelCounterpartyDecodeErrorZ ret_hu_conv = Result_ChannelCounterpartyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
