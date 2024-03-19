using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An accept_channel2 message to be sent by or received from the channel accepter.
 * 
 * Used in V2 channel establishment
 */
public class AcceptChannelV2 : CommonBase {
	internal AcceptChannelV2(object _dummy, long ptr) : base(ptr) { }
	~AcceptChannelV2() {
		if (ptr != 0) { Bindings.AcceptChannelV2Free(ptr); }
	}

	/**
	 * The same `temporary_channel_id` received from the initiator's `open_channel2` message.
	 */
	public byte[] get_temporary_channel_id() {
		long ret = Bindings.AcceptChannelV2GetTemporaryChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The same `temporary_channel_id` received from the initiator's `open_channel2` message.
	 */
	public void set_temporary_channel_id(byte[] val) {
		Bindings.AcceptChannelV2SetTemporaryChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Part of the channel value contributed by the channel acceptor
	 */
	public long get_funding_satoshis() {
		long ret = Bindings.AcceptChannelV2GetFundingSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Part of the channel value contributed by the channel acceptor
	 */
	public void set_funding_satoshis(long val) {
		Bindings.AcceptChannelV2SetFundingSatoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The threshold below which outputs on transactions broadcast by the channel acceptor will be
	 * omitted
	 */
	public long get_dust_limit_satoshis() {
		long ret = Bindings.AcceptChannelV2GetDustLimitSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The threshold below which outputs on transactions broadcast by the channel acceptor will be
	 * omitted
	 */
	public void set_dust_limit_satoshis(long val) {
		Bindings.AcceptChannelV2SetDustLimitSatoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum inbound HTLC value in flight towards channel acceptor, in milli-satoshi
	 */
	public long get_max_htlc_value_in_flight_msat() {
		long ret = Bindings.AcceptChannelV2GetMaxHtlcValueInFlightMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum inbound HTLC value in flight towards channel acceptor, in milli-satoshi
	 */
	public void set_max_htlc_value_in_flight_msat(long val) {
		Bindings.AcceptChannelV2SetMaxHtlcValueInFlightMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum HTLC size incoming to channel acceptor, in milli-satoshi
	 */
	public long get_htlc_minimum_msat() {
		long ret = Bindings.AcceptChannelV2GetHtlcMinimumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum HTLC size incoming to channel acceptor, in milli-satoshi
	 */
	public void set_htlc_minimum_msat(long val) {
		Bindings.AcceptChannelV2SetHtlcMinimumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Minimum depth of the funding transaction before the channel is considered open
	 */
	public int get_minimum_depth() {
		int ret = Bindings.AcceptChannelV2GetMinimumDepth(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Minimum depth of the funding transaction before the channel is considered open
	 */
	public void set_minimum_depth(int val) {
		Bindings.AcceptChannelV2SetMinimumDepth(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of blocks which the counterparty will have to wait to claim on-chain funds if they
	 * broadcast a commitment transaction
	 */
	public short get_to_self_delay() {
		short ret = Bindings.AcceptChannelV2GetToSelfDelay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The number of blocks which the counterparty will have to wait to claim on-chain funds if they
	 * broadcast a commitment transaction
	 */
	public void set_to_self_delay(short val) {
		Bindings.AcceptChannelV2SetToSelfDelay(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of inbound HTLCs towards channel acceptor
	 */
	public short get_max_accepted_htlcs() {
		short ret = Bindings.AcceptChannelV2GetMaxAcceptedHtlcs(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of inbound HTLCs towards channel acceptor
	 */
	public void set_max_accepted_htlcs(short val) {
		Bindings.AcceptChannelV2SetMaxAcceptedHtlcs(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The channel acceptor's key controlling the funding transaction
	 */
	public byte[] get_funding_pubkey() {
		long ret = Bindings.AcceptChannelV2GetFundingPubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel acceptor's key controlling the funding transaction
	 */
	public void set_funding_pubkey(byte[] val) {
		Bindings.AcceptChannelV2SetFundingPubkey(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Used to derive a revocation key for transactions broadcast by counterparty
	 */
	public byte[] get_revocation_basepoint() {
		long ret = Bindings.AcceptChannelV2GetRevocationBasepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used to derive a revocation key for transactions broadcast by counterparty
	 */
	public void set_revocation_basepoint(byte[] val) {
		Bindings.AcceptChannelV2SetRevocationBasepoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A payment key to channel acceptor for transactions broadcast by counterparty
	 */
	public byte[] get_payment_basepoint() {
		long ret = Bindings.AcceptChannelV2GetPaymentBasepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * A payment key to channel acceptor for transactions broadcast by counterparty
	 */
	public void set_payment_basepoint(byte[] val) {
		Bindings.AcceptChannelV2SetPaymentBasepoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Used to derive a payment key to channel acceptor for transactions broadcast by channel
	 * acceptor
	 */
	public byte[] get_delayed_payment_basepoint() {
		long ret = Bindings.AcceptChannelV2GetDelayedPaymentBasepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used to derive a payment key to channel acceptor for transactions broadcast by channel
	 * acceptor
	 */
	public void set_delayed_payment_basepoint(byte[] val) {
		Bindings.AcceptChannelV2SetDelayedPaymentBasepoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Used to derive an HTLC payment key to channel acceptor for transactions broadcast by counterparty
	 */
	public byte[] get_htlc_basepoint() {
		long ret = Bindings.AcceptChannelV2GetHtlcBasepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used to derive an HTLC payment key to channel acceptor for transactions broadcast by counterparty
	 */
	public void set_htlc_basepoint(byte[] val) {
		Bindings.AcceptChannelV2SetHtlcBasepoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The first to-be-broadcast-by-channel-acceptor transaction's per commitment point
	 */
	public byte[] get_first_per_commitment_point() {
		long ret = Bindings.AcceptChannelV2GetFirstPerCommitmentPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The first to-be-broadcast-by-channel-acceptor transaction's per commitment point
	 */
	public void set_first_per_commitment_point(byte[] val) {
		Bindings.AcceptChannelV2SetFirstPerCommitmentPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The second to-be-broadcast-by-channel-acceptor transaction's per commitment point
	 */
	public byte[] get_second_per_commitment_point() {
		long ret = Bindings.AcceptChannelV2GetSecondPerCommitmentPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The second to-be-broadcast-by-channel-acceptor transaction's per commitment point
	 */
	public void set_second_per_commitment_point(byte[] val) {
		Bindings.AcceptChannelV2SetSecondPerCommitmentPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Optionally, a request to pre-set the to-channel-acceptor output's scriptPubkey for when we
	 * collaboratively close
	 */
	public Option_CVec_u8ZZ get_shutdown_scriptpubkey() {
		long ret = Bindings.AcceptChannelV2GetShutdownScriptpubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_u8ZZ ret_hu_conv = org.ldk.structs.Option_CVec_u8ZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Optionally, a request to pre-set the to-channel-acceptor output's scriptPubkey for when we
	 * collaboratively close
	 */
	public void set_shutdown_scriptpubkey(org.ldk.structs.Option_CVec_u8ZZ val) {
		Bindings.AcceptChannelV2SetShutdownScriptpubkey(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The channel type that this channel will represent. If none is set, we derive the channel
	 * type from the intersection of our feature bits with our counterparty's feature bits from
	 * the Init message.
	 * 
	 * This is required to match the equivalent field in [`OpenChannelV2::channel_type`].
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public ChannelTypeFeatures get_channel_type() {
		long ret = Bindings.AcceptChannelV2GetChannelType(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The channel type that this channel will represent. If none is set, we derive the channel
	 * type from the intersection of our feature bits with our counterparty's feature bits from
	 * the Init message.
	 * 
	 * This is required to match the equivalent field in [`OpenChannelV2::channel_type`].
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_channel_type(org.ldk.structs.ChannelTypeFeatures val) {
		Bindings.AcceptChannelV2SetChannelType(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Optionally, a requirement that only confirmed inputs can be added
	 */
	public COption_NoneZ get_require_confirmed_inputs() {
		COption_NoneZ ret = Bindings.AcceptChannelV2GetRequireConfirmedInputs(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Optionally, a requirement that only confirmed inputs can be added
	 */
	public void set_require_confirmed_inputs(COption_NoneZ val) {
		Bindings.AcceptChannelV2SetRequireConfirmedInputs(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new AcceptChannelV2 given each field
	 * 
	 * Note that channel_type_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static AcceptChannelV2 of(byte[] temporary_channel_id_arg, long funding_satoshis_arg, long dust_limit_satoshis_arg, long max_htlc_value_in_flight_msat_arg, long htlc_minimum_msat_arg, int minimum_depth_arg, short to_self_delay_arg, short max_accepted_htlcs_arg, byte[] funding_pubkey_arg, byte[] revocation_basepoint_arg, byte[] payment_basepoint_arg, byte[] delayed_payment_basepoint_arg, byte[] htlc_basepoint_arg, byte[] first_per_commitment_point_arg, byte[] second_per_commitment_point_arg, org.ldk.structs.Option_CVec_u8ZZ shutdown_scriptpubkey_arg, org.ldk.structs.ChannelTypeFeatures channel_type_arg, COption_NoneZ require_confirmed_inputs_arg) {
		long ret = Bindings.AcceptChannelV2New(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(temporary_channel_id_arg, 32)), funding_satoshis_arg, dust_limit_satoshis_arg, max_htlc_value_in_flight_msat_arg, htlc_minimum_msat_arg, minimum_depth_arg, to_self_delay_arg, max_accepted_htlcs_arg, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(funding_pubkey_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(revocation_basepoint_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_basepoint_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(delayed_payment_basepoint_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(htlc_basepoint_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(first_per_commitment_point_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(second_per_commitment_point_arg, 33)), shutdown_scriptpubkey_arg.ptr, channel_type_arg == null ? 0 : channel_type_arg.ptr, require_confirmed_inputs_arg);
		GC.KeepAlive(temporary_channel_id_arg);
		GC.KeepAlive(funding_satoshis_arg);
		GC.KeepAlive(dust_limit_satoshis_arg);
		GC.KeepAlive(max_htlc_value_in_flight_msat_arg);
		GC.KeepAlive(htlc_minimum_msat_arg);
		GC.KeepAlive(minimum_depth_arg);
		GC.KeepAlive(to_self_delay_arg);
		GC.KeepAlive(max_accepted_htlcs_arg);
		GC.KeepAlive(funding_pubkey_arg);
		GC.KeepAlive(revocation_basepoint_arg);
		GC.KeepAlive(payment_basepoint_arg);
		GC.KeepAlive(delayed_payment_basepoint_arg);
		GC.KeepAlive(htlc_basepoint_arg);
		GC.KeepAlive(first_per_commitment_point_arg);
		GC.KeepAlive(second_per_commitment_point_arg);
		GC.KeepAlive(shutdown_scriptpubkey_arg);
		GC.KeepAlive(channel_type_arg);
		GC.KeepAlive(require_confirmed_inputs_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AcceptChannelV2 ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.AcceptChannelV2(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(shutdown_scriptpubkey_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_type_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.AcceptChannelV2ClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the AcceptChannelV2
	 */
	public AcceptChannelV2 clone() {
		long ret = Bindings.AcceptChannelV2Clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.AcceptChannelV2 ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.AcceptChannelV2(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the AcceptChannelV2.
	 */
	public long hash() {
		long ret = Bindings.AcceptChannelV2Hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two AcceptChannelV2s contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.AcceptChannelV2 b) {
		bool ret = Bindings.AcceptChannelV2Eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is AcceptChannelV2)) return false;
		return this.eq((AcceptChannelV2)o);
	}
	/**
	 * Serialize the AcceptChannelV2 object into a byte array which can be read by AcceptChannelV2_read
	 */
	public byte[] write() {
		long ret = Bindings.AcceptChannelV2Write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a AcceptChannelV2 from a byte array, created by AcceptChannelV2_write
	 */
	public static Result_AcceptChannelV2DecodeErrorZ read(byte[] ser) {
		long ret = Bindings.AcceptChannelV2Read(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelV2DecodeErrorZ ret_hu_conv = Result_AcceptChannelV2DecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
