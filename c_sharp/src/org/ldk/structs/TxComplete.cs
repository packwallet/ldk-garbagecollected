using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A tx_complete message signalling the conclusion of a peer's transaction contributions during
 * interactive transaction construction.
 */
public class TxComplete : CommonBase {
	internal TxComplete(object _dummy, long ptr) : base(ptr) { }
	~TxComplete() {
		if (ptr != 0) { Bindings.TxCompleteFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.TxCompleteGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.TxCompleteSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new TxComplete given each field
	 */
	public static TxComplete of(byte[] channel_id_arg) {
		long ret = Bindings.TxCompleteNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)));
		GC.KeepAlive(channel_id_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxComplete ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxComplete(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.TxCompleteClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxComplete
	 */
	public TxComplete clone() {
		long ret = Bindings.TxCompleteClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxComplete ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxComplete(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxComplete.
	 */
	public long hash() {
		long ret = Bindings.TxCompleteHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxCompletes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.TxComplete b) {
		bool ret = Bindings.TxCompleteEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is TxComplete)) return false;
		return this.eq((TxComplete)o);
	}
	/**
	 * Serialize the TxComplete object into a byte array which can be read by TxComplete_read
	 */
	public byte[] write() {
		long ret = Bindings.TxCompleteWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a TxComplete from a byte array, created by TxComplete_write
	 */
	public static Result_TxCompleteDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.TxCompleteRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxCompleteDecodeErrorZ ret_hu_conv = Result_TxCompleteDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
