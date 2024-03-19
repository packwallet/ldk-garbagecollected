using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`warning`] message to be sent to or received from a peer.
 * 
 * [`warning`]: https://github.com/lightning/bolts/blob/master/01-messaging.md#the-error-and-warning-messages
 */
public class WarningMessage : CommonBase {
	internal WarningMessage(object _dummy, long ptr) : base(ptr) { }
	~WarningMessage() {
		if (ptr != 0) { Bindings.WarningMessageFree(ptr); }
	}

	/**
	 * The channel ID involved in the warning.
	 * 
	 * All-0s indicates a warning unrelated to a specific channel.
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.WarningMessageGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID involved in the warning.
	 * 
	 * All-0s indicates a warning unrelated to a specific channel.
	 */
	public void set_channel_id(byte[] val) {
		Bindings.WarningMessageSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A possibly human-readable warning description.
	 * 
	 * The string should be sanitized before it is used (e.g. emitted to logs or printed to
	 * stdout). Otherwise, a well crafted error message may trigger a security vulnerability in
	 * the terminal emulator or the logging subsystem.
	 */
	public string get_data() {
		long ret = Bindings.WarningMessageGetData(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.DecodeString(ret);
		return ret_conv;
	}

	/**
	 * A possibly human-readable warning description.
	 * 
	 * The string should be sanitized before it is used (e.g. emitted to logs or printed to
	 * stdout). Otherwise, a well crafted error message may trigger a security vulnerability in
	 * the terminal emulator or the logging subsystem.
	 */
	public void set_data(string val) {
		Bindings.WarningMessageSetData(this.ptr, InternalUtils.EncodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new WarningMessage given each field
	 */
	public static WarningMessage of(byte[] channel_id_arg, string data_arg) {
		long ret = Bindings.WarningMessageNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeString(data_arg));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(data_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.WarningMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.WarningMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.WarningMessageClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the WarningMessage
	 */
	public WarningMessage clone() {
		long ret = Bindings.WarningMessageClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.WarningMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.WarningMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the WarningMessage.
	 */
	public long hash() {
		long ret = Bindings.WarningMessageHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two WarningMessages contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.WarningMessage b) {
		bool ret = Bindings.WarningMessageEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is WarningMessage)) return false;
		return this.eq((WarningMessage)o);
	}
	/**
	 * Serialize the WarningMessage object into a byte array which can be read by WarningMessage_read
	 */
	public byte[] write() {
		long ret = Bindings.WarningMessageWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a WarningMessage from a byte array, created by WarningMessage_write
	 */
	public static Result_WarningMessageDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.WarningMessageRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_WarningMessageDecodeErrorZ ret_hu_conv = Result_WarningMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
