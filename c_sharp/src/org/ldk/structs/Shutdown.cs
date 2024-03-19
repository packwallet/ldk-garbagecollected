using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`shutdown`] message to be sent to or received from a peer.
 * 
 * [`shutdown`]: https://github.com/lightning/bolts/blob/master/02-peer-protocol.md#closing-initiation-shutdown
 */
public class Shutdown : CommonBase {
	internal Shutdown(object _dummy, long ptr) : base(ptr) { }
	~Shutdown() {
		if (ptr != 0) { Bindings.ShutdownFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.ShutdownGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.ShutdownSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The destination of this peer's funds on closing.
	 * 
	 * Must be in one of these forms: P2PKH, P2SH, P2WPKH, P2WSH, P2TR.
	 */
	public byte[] get_scriptpubkey() {
		long ret = Bindings.ShutdownGetScriptpubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The destination of this peer's funds on closing.
	 * 
	 * Must be in one of these forms: P2PKH, P2SH, P2WPKH, P2WSH, P2TR.
	 */
	public void set_scriptpubkey(byte[] val) {
		Bindings.ShutdownSetScriptpubkey(this.ptr, InternalUtils.EncodeUint8Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new Shutdown given each field
	 */
	public static Shutdown of(byte[] channel_id_arg, byte[] scriptpubkey_arg) {
		long ret = Bindings.ShutdownNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeUint8Array(scriptpubkey_arg));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(scriptpubkey_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Shutdown ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Shutdown(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ShutdownClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Shutdown
	 */
	public Shutdown clone() {
		long ret = Bindings.ShutdownClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Shutdown ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Shutdown(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Shutdown.
	 */
	public long hash() {
		long ret = Bindings.ShutdownHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Shutdowns contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.Shutdown b) {
		bool ret = Bindings.ShutdownEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Shutdown)) return false;
		return this.eq((Shutdown)o);
	}
	/**
	 * Serialize the Shutdown object into a byte array which can be read by Shutdown_read
	 */
	public byte[] write() {
		long ret = Bindings.ShutdownWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a Shutdown from a byte array, created by Shutdown_write
	 */
	public static Result_ShutdownDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ShutdownRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ShutdownDecodeErrorZ ret_hu_conv = Result_ShutdownDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
