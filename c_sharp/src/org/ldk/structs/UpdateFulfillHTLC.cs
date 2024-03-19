using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An [`update_fulfill_htlc`] message to be sent to or received from a peer.
 * 
 * [`update_fulfill_htlc`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#removing-an-htlc-update_fulfill_htlc-update_fail_htlc-and-update_fail_malformed_htlc
 */
public class UpdateFulfillHTLC : CommonBase {
	internal UpdateFulfillHTLC(object _dummy, long ptr) : base(ptr) { }
	~UpdateFulfillHTLC() {
		if (ptr != 0) { Bindings.UpdateFulfillHTLCFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.UpdateFulfillHTLCGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.UpdateFulfillHTLCSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The HTLC ID
	 */
	public long get_htlc_id() {
		long ret = Bindings.UpdateFulfillHTLCGetHtlcId(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The HTLC ID
	 */
	public void set_htlc_id(long val) {
		Bindings.UpdateFulfillHTLCSetHtlcId(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The pre-image of the payment hash, allowing HTLC redemption
	 */
	public byte[] get_payment_preimage() {
		long ret = Bindings.UpdateFulfillHTLCGetPaymentPreimage(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The pre-image of the payment hash, allowing HTLC redemption
	 */
	public void set_payment_preimage(byte[] val) {
		Bindings.UpdateFulfillHTLCSetPaymentPreimage(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UpdateFulfillHTLC given each field
	 */
	public static UpdateFulfillHTLC of(byte[] channel_id_arg, long htlc_id_arg, byte[] payment_preimage_arg) {
		long ret = Bindings.UpdateFulfillHTLCNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), htlc_id_arg, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_preimage_arg, 32)));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(htlc_id_arg);
		GC.KeepAlive(payment_preimage_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFulfillHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFulfillHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.UpdateFulfillHTLCClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UpdateFulfillHTLC
	 */
	public UpdateFulfillHTLC clone() {
		long ret = Bindings.UpdateFulfillHTLCClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFulfillHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFulfillHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the UpdateFulfillHTLC.
	 */
	public long hash() {
		long ret = Bindings.UpdateFulfillHTLCHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two UpdateFulfillHTLCs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UpdateFulfillHTLC b) {
		bool ret = Bindings.UpdateFulfillHTLCEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UpdateFulfillHTLC)) return false;
		return this.eq((UpdateFulfillHTLC)o);
	}
	/**
	 * Serialize the UpdateFulfillHTLC object into a byte array which can be read by UpdateFulfillHTLC_read
	 */
	public byte[] write() {
		long ret = Bindings.UpdateFulfillHTLCWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UpdateFulfillHTLC from a byte array, created by UpdateFulfillHTLC_write
	 */
	public static Result_UpdateFulfillHTLCDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.UpdateFulfillHTLCRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFulfillHTLCDecodeErrorZ ret_hu_conv = Result_UpdateFulfillHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
