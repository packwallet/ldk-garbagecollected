using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A tx_abort message which signals the cancellation of an in-progress transaction negotiation.
 */
public class TxAbort : CommonBase {
	internal TxAbort(object _dummy, long ptr) : base(ptr) { }
	~TxAbort() {
		if (ptr != 0) { Bindings.TxAbortFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.TxAbortGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.TxAbortSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Message data
	 * 
	 * Returns a copy of the field.
	 */
	public byte[] get_data() {
		long ret = Bindings.TxAbortGetData(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Message data
	 */
	public void set_data(byte[] val) {
		Bindings.TxAbortSetData(this.ptr, InternalUtils.EncodeUint8Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new TxAbort given each field
	 */
	public static TxAbort of(byte[] channel_id_arg, byte[] data_arg) {
		long ret = Bindings.TxAbortNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeUint8Array(data_arg));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(data_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxAbort ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxAbort(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.TxAbortClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxAbort
	 */
	public TxAbort clone() {
		long ret = Bindings.TxAbortClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxAbort ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxAbort(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxAbort.
	 */
	public long hash() {
		long ret = Bindings.TxAbortHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxAborts contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.TxAbort b) {
		bool ret = Bindings.TxAbortEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is TxAbort)) return false;
		return this.eq((TxAbort)o);
	}
	/**
	 * Serialize the TxAbort object into a byte array which can be read by TxAbort_read
	 */
	public byte[] write() {
		long ret = Bindings.TxAbortWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a TxAbort from a byte array, created by TxAbort_write
	 */
	public static Result_TxAbortDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.TxAbortRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxAbortDecodeErrorZ ret_hu_conv = Result_TxAbortDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
