using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`pong`] message to be sent to or received from a peer.
 * 
 * [`pong`]: https://github.com/lightning/bolts/blob/master/01-messaging.md#the-ping-and-pong-messages
 */
public class Pong : CommonBase {
	internal Pong(object _dummy, long ptr) : base(ptr) { }
	~Pong() {
		if (ptr != 0) { Bindings.PongFree(ptr); }
	}

	/**
	 * The pong packet size.
	 * 
	 * This field is not sent on the wire. byteslen zeros are sent.
	 */
	public short get_byteslen() {
		short ret = Bindings.PongGetByteslen(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The pong packet size.
	 * 
	 * This field is not sent on the wire. byteslen zeros are sent.
	 */
	public void set_byteslen(short val) {
		Bindings.PongSetByteslen(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new Pong given each field
	 */
	public static Pong of(short byteslen_arg) {
		long ret = Bindings.PongNew(byteslen_arg);
		GC.KeepAlive(byteslen_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Pong ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Pong(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.PongClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Pong
	 */
	public Pong clone() {
		long ret = Bindings.PongClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Pong ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Pong(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Pong.
	 */
	public long hash() {
		long ret = Bindings.PongHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Pongs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.Pong b) {
		bool ret = Bindings.PongEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Pong)) return false;
		return this.eq((Pong)o);
	}
	/**
	 * Serialize the Pong object into a byte array which can be read by Pong_read
	 */
	public byte[] write() {
		long ret = Bindings.PongWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a Pong from a byte array, created by Pong_write
	 */
	public static Result_PongDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.PongRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PongDecodeErrorZ ret_hu_conv = Result_PongDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
