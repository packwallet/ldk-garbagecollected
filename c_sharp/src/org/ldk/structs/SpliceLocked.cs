using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A splice_locked message to be sent to or received from a peer.
 */
public class SpliceLocked : CommonBase {
	internal SpliceLocked(object _dummy, long ptr) : base(ptr) { }
	~SpliceLocked() {
		if (ptr != 0) { Bindings.SpliceLockedFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.SpliceLockedGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.SpliceLockedSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new SpliceLocked given each field
	 */
	public static SpliceLocked of(byte[] channel_id_arg) {
		long ret = Bindings.SpliceLockedNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)));
		GC.KeepAlive(channel_id_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpliceLocked ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.SpliceLocked(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.SpliceLockedClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the SpliceLocked
	 */
	public SpliceLocked clone() {
		long ret = Bindings.SpliceLockedClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SpliceLocked ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.SpliceLocked(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two SpliceLockeds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.SpliceLocked b) {
		bool ret = Bindings.SpliceLockedEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is SpliceLocked)) return false;
		return this.eq((SpliceLocked)o);
	}
	/**
	 * Serialize the SpliceLocked object into a byte array which can be read by SpliceLocked_read
	 */
	public byte[] write() {
		long ret = Bindings.SpliceLockedWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a SpliceLocked from a byte array, created by SpliceLocked_write
	 */
	public static Result_SpliceLockedDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.SpliceLockedRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceLockedDecodeErrorZ ret_hu_conv = Result_SpliceLockedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
