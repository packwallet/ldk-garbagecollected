using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Per-channel data used to build transactions in conjunction with the per-commitment data (CommitmentTransaction).
 * The fields are organized by holder/counterparty.
 * 
 * Normally, this is converted to the broadcaster/countersignatory-organized DirectedChannelTransactionParameters
 * before use, via the as_holder_broadcastable and as_counterparty_broadcastable functions.
 */
public class ChannelTransactionParameters : CommonBase {
	internal ChannelTransactionParameters(object _dummy, long ptr) : base(ptr) { }
	~ChannelTransactionParameters() {
		if (ptr != 0) { Bindings.ChannelTransactionParametersFree(ptr); }
	}

	/**
	 * Holder public keys
	 */
	public ChannelPublicKeys get_holder_pubkeys() {
		long ret = Bindings.ChannelTransactionParametersGetHolderPubkeys(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Holder public keys
	 */
	public void set_holder_pubkeys(org.ldk.structs.ChannelPublicKeys val) {
		Bindings.ChannelTransactionParametersSetHolderPubkeys(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The contest delay selected by the holder, which applies to counterparty-broadcast transactions
	 */
	public short get_holder_selected_contest_delay() {
		short ret = Bindings.ChannelTransactionParametersGetHolderSelectedContestDelay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The contest delay selected by the holder, which applies to counterparty-broadcast transactions
	 */
	public void set_holder_selected_contest_delay(short val) {
		Bindings.ChannelTransactionParametersSetHolderSelectedContestDelay(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Whether the holder is the initiator of this channel.
	 * This is an input to the commitment number obscure factor computation.
	 */
	public bool get_is_outbound_from_holder() {
		bool ret = Bindings.ChannelTransactionParametersGetIsOutboundFromHolder(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Whether the holder is the initiator of this channel.
	 * This is an input to the commitment number obscure factor computation.
	 */
	public void set_is_outbound_from_holder(bool val) {
		Bindings.ChannelTransactionParametersSetIsOutboundFromHolder(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The late-bound counterparty channel transaction parameters.
	 * These parameters are populated at the point in the protocol where the counterparty provides them.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public CounterpartyChannelTransactionParameters get_counterparty_parameters() {
		long ret = Bindings.ChannelTransactionParametersGetCounterpartyParameters(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The late-bound counterparty channel transaction parameters.
	 * These parameters are populated at the point in the protocol where the counterparty provides them.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_counterparty_parameters(org.ldk.structs.CounterpartyChannelTransactionParameters val) {
		Bindings.ChannelTransactionParametersSetCounterpartyParameters(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The late-bound funding outpoint
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public OutPoint get_funding_outpoint() {
		long ret = Bindings.ChannelTransactionParametersGetFundingOutpoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The late-bound funding outpoint
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_funding_outpoint(org.ldk.structs.OutPoint val) {
		Bindings.ChannelTransactionParametersSetFundingOutpoint(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * This channel's type, as negotiated during channel open. For old objects where this field
	 * wasn't serialized, it will default to static_remote_key at deserialization.
	 */
	public ChannelTypeFeatures get_channel_type_features() {
		long ret = Bindings.ChannelTransactionParametersGetChannelTypeFeatures(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * This channel's type, as negotiated during channel open. For old objects where this field
	 * wasn't serialized, it will default to static_remote_key at deserialization.
	 */
	public void set_channel_type_features(org.ldk.structs.ChannelTypeFeatures val) {
		Bindings.ChannelTransactionParametersSetChannelTypeFeatures(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ChannelTransactionParameters given each field
	 * 
	 * Note that counterparty_parameters_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that funding_outpoint_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static ChannelTransactionParameters of(org.ldk.structs.ChannelPublicKeys holder_pubkeys_arg, short holder_selected_contest_delay_arg, bool is_outbound_from_holder_arg, org.ldk.structs.CounterpartyChannelTransactionParameters counterparty_parameters_arg, org.ldk.structs.OutPoint funding_outpoint_arg, org.ldk.structs.ChannelTypeFeatures channel_type_features_arg) {
		long ret = Bindings.ChannelTransactionParametersNew(holder_pubkeys_arg == null ? 0 : holder_pubkeys_arg.ptr, holder_selected_contest_delay_arg, is_outbound_from_holder_arg, counterparty_parameters_arg == null ? 0 : counterparty_parameters_arg.ptr, funding_outpoint_arg == null ? 0 : funding_outpoint_arg.ptr, channel_type_features_arg == null ? 0 : channel_type_features_arg.ptr);
		GC.KeepAlive(holder_pubkeys_arg);
		GC.KeepAlive(holder_selected_contest_delay_arg);
		GC.KeepAlive(is_outbound_from_holder_arg);
		GC.KeepAlive(counterparty_parameters_arg);
		GC.KeepAlive(funding_outpoint_arg);
		GC.KeepAlive(channel_type_features_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(holder_pubkeys_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(counterparty_parameters_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(funding_outpoint_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_type_features_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ChannelTransactionParametersClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelTransactionParameters
	 */
	public ChannelTransactionParameters clone() {
		long ret = Bindings.ChannelTransactionParametersClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelTransactionParameters.
	 */
	public long hash() {
		long ret = Bindings.ChannelTransactionParametersHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelTransactionParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelTransactionParameters b) {
		bool ret = Bindings.ChannelTransactionParametersEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelTransactionParameters)) return false;
		return this.eq((ChannelTransactionParameters)o);
	}
	/**
	 * Whether the late bound parameters are populated.
	 */
	public bool is_populated() {
		bool ret = Bindings.ChannelTransactionParametersIsPopulated(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Convert the holder/counterparty parameters to broadcaster/countersignatory-organized parameters,
	 * given that the holder is the broadcaster.
	 * 
	 * self.is_populated() must be true before calling this function.
	 */
	public DirectedChannelTransactionParameters as_holder_broadcastable() {
		long ret = Bindings.ChannelTransactionParametersAsHolderBroadcastable(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DirectedChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DirectedChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Convert the holder/counterparty parameters to broadcaster/countersignatory-organized parameters,
	 * given that the counterparty is the broadcaster.
	 * 
	 * self.is_populated() must be true before calling this function.
	 */
	public DirectedChannelTransactionParameters as_counterparty_broadcastable() {
		long ret = Bindings.ChannelTransactionParametersAsCounterpartyBroadcastable(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DirectedChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DirectedChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelTransactionParameters object into a byte array which can be read by ChannelTransactionParameters_read
	 */
	public byte[] write() {
		long ret = Bindings.ChannelTransactionParametersWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelTransactionParameters from a byte array, created by ChannelTransactionParameters_write
	 */
	public static Result_ChannelTransactionParametersDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ChannelTransactionParametersRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_ChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
