using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A tx_init_rbf message which initiates a replacement of the transaction after it's been
 * completed.
 */
public class TxInitRbf : CommonBase {
	internal TxInitRbf(object _dummy, long ptr) : base(ptr) { }
	~TxInitRbf() {
		if (ptr != 0) { Bindings.TxInitRbfFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.TxInitRbfGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.TxInitRbfSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The locktime of the transaction
	 */
	public int get_locktime() {
		int ret = Bindings.TxInitRbfGetLocktime(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The locktime of the transaction
	 */
	public void set_locktime(int val) {
		Bindings.TxInitRbfSetLocktime(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The feerate of the transaction
	 */
	public int get_feerate_sat_per_1000_weight() {
		int ret = Bindings.TxInitRbfGetFeerateSatPer1000Weight(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The feerate of the transaction
	 */
	public void set_feerate_sat_per_1000_weight(int val) {
		Bindings.TxInitRbfSetFeerateSatPer1000Weight(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The number of satoshis the sender will contribute to or, if negative, remove from
	 * (e.g. splice-out) the funding output of the transaction
	 */
	public Option_i64Z get_funding_output_contribution() {
		long ret = Bindings.TxInitRbfGetFundingOutputContribution(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_i64Z ret_hu_conv = org.ldk.structs.Option_i64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The number of satoshis the sender will contribute to or, if negative, remove from
	 * (e.g. splice-out) the funding output of the transaction
	 */
	public void set_funding_output_contribution(org.ldk.structs.Option_i64Z val) {
		Bindings.TxInitRbfSetFundingOutputContribution(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new TxInitRbf given each field
	 */
	public static TxInitRbf of(byte[] channel_id_arg, int locktime_arg, int feerate_sat_per_1000_weight_arg, org.ldk.structs.Option_i64Z funding_output_contribution_arg) {
		long ret = Bindings.TxInitRbfNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), locktime_arg, feerate_sat_per_1000_weight_arg, funding_output_contribution_arg.ptr);
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(locktime_arg);
		GC.KeepAlive(feerate_sat_per_1000_weight_arg);
		GC.KeepAlive(funding_output_contribution_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxInitRbf ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxInitRbf(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(funding_output_contribution_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.TxInitRbfClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxInitRbf
	 */
	public TxInitRbf clone() {
		long ret = Bindings.TxInitRbfClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxInitRbf ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxInitRbf(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxInitRbf.
	 */
	public long hash() {
		long ret = Bindings.TxInitRbfHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxInitRbfs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.TxInitRbf b) {
		bool ret = Bindings.TxInitRbfEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is TxInitRbf)) return false;
		return this.eq((TxInitRbf)o);
	}
	/**
	 * Serialize the TxInitRbf object into a byte array which can be read by TxInitRbf_read
	 */
	public byte[] write() {
		long ret = Bindings.TxInitRbfWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a TxInitRbf from a byte array, created by TxInitRbf_write
	 */
	public static Result_TxInitRbfDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.TxInitRbfRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxInitRbfDecodeErrorZ ret_hu_conv = Result_TxInitRbfDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
