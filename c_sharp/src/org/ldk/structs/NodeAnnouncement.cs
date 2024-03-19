using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`node_announcement`] message to be sent to or received from a peer.
 * 
 * [`node_announcement`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-node_announcement-message
 */
public class NodeAnnouncement : CommonBase {
	internal NodeAnnouncement(object _dummy, long ptr) : base(ptr) { }
	~NodeAnnouncement() {
		if (ptr != 0) { Bindings.NodeAnnouncementFree(ptr); }
	}

	/**
	 * The signature by the node key
	 */
	public byte[] get_signature() {
		long ret = Bindings.NodeAnnouncementGetSignature(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The signature by the node key
	 */
	public void set_signature(byte[] val) {
		Bindings.NodeAnnouncementSetSignature(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 64)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The actual content of the announcement
	 */
	public UnsignedNodeAnnouncement get_contents() {
		long ret = Bindings.NodeAnnouncementGetContents(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UnsignedNodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UnsignedNodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The actual content of the announcement
	 */
	public void set_contents(org.ldk.structs.UnsignedNodeAnnouncement val) {
		Bindings.NodeAnnouncementSetContents(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new NodeAnnouncement given each field
	 */
	public static NodeAnnouncement of(byte[] signature_arg, org.ldk.structs.UnsignedNodeAnnouncement contents_arg) {
		long ret = Bindings.NodeAnnouncementNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(signature_arg, 64)), contents_arg == null ? 0 : contents_arg.ptr);
		GC.KeepAlive(signature_arg);
		GC.KeepAlive(contents_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(contents_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.NodeAnnouncementClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the NodeAnnouncement
	 */
	public NodeAnnouncement clone() {
		long ret = Bindings.NodeAnnouncementClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the NodeAnnouncement.
	 */
	public long hash() {
		long ret = Bindings.NodeAnnouncementHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two NodeAnnouncements contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.NodeAnnouncement b) {
		bool ret = Bindings.NodeAnnouncementEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is NodeAnnouncement)) return false;
		return this.eq((NodeAnnouncement)o);
	}
	/**
	 * Serialize the NodeAnnouncement object into a byte array which can be read by NodeAnnouncement_read
	 */
	public byte[] write() {
		long ret = Bindings.NodeAnnouncementWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a NodeAnnouncement from a byte array, created by NodeAnnouncement_write
	 */
	public static Result_NodeAnnouncementDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.NodeAnnouncementRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeAnnouncementDecodeErrorZ ret_hu_conv = Result_NodeAnnouncementDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
