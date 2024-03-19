using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A tx_remove_output message for removing an output during interactive transaction construction.
 */
public class TxRemoveOutput : CommonBase {
	internal TxRemoveOutput(object _dummy, long ptr) : base(ptr) { }
	~TxRemoveOutput() {
		if (ptr != 0) { Bindings.TxRemoveOutputFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.TxRemoveOutputGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.TxRemoveOutputSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The serial ID of the output to be removed
	 */
	public long get_serial_id() {
		long ret = Bindings.TxRemoveOutputGetSerialId(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The serial ID of the output to be removed
	 */
	public void set_serial_id(long val) {
		Bindings.TxRemoveOutputSetSerialId(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new TxRemoveOutput given each field
	 */
	public static TxRemoveOutput of(byte[] channel_id_arg, long serial_id_arg) {
		long ret = Bindings.TxRemoveOutputNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), serial_id_arg);
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(serial_id_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxRemoveOutput ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxRemoveOutput(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.TxRemoveOutputClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxRemoveOutput
	 */
	public TxRemoveOutput clone() {
		long ret = Bindings.TxRemoveOutputClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxRemoveOutput ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxRemoveOutput(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxRemoveOutput.
	 */
	public long hash() {
		long ret = Bindings.TxRemoveOutputHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxRemoveOutputs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.TxRemoveOutput b) {
		bool ret = Bindings.TxRemoveOutputEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is TxRemoveOutput)) return false;
		return this.eq((TxRemoveOutput)o);
	}
	/**
	 * Serialize the TxRemoveOutput object into a byte array which can be read by TxRemoveOutput_read
	 */
	public byte[] write() {
		long ret = Bindings.TxRemoveOutputWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a TxRemoveOutput from a byte array, created by TxRemoveOutput_write
	 */
	public static Result_TxRemoveOutputDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.TxRemoveOutputRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxRemoveOutputDecodeErrorZ ret_hu_conv = Result_TxRemoveOutputDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
