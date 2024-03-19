using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Details about a node in the network, known from the network announcement.
 */
public class NodeInfo : CommonBase {
	internal NodeInfo(object _dummy, long ptr) : base(ptr) { }
	~NodeInfo() {
		if (ptr != 0) { Bindings.NodeInfoFree(ptr); }
	}

	/**
	 * All valid channels a node has announced
	 * 
	 * Returns a copy of the field.
	 */
	public long[] get_channels() {
		long ret = Bindings.NodeInfoGetChannels(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		long[] ret_conv = InternalUtils.DecodeUint64Array(ret);
		return ret_conv;
	}

	/**
	 * All valid channels a node has announced
	 */
	public void set_channels(long[] val) {
		Bindings.NodeInfoSetChannels(this.ptr, InternalUtils.EncodeUint64Array(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * More information about a node from node_announcement.
	 * Optional because we store a Node entry after learning about it from
	 * a channel announcement, but before receiving a node announcement.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public NodeAnnouncementInfo get_announcement_info() {
		long ret = Bindings.NodeInfoGetAnnouncementInfo(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncementInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncementInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * More information about a node from node_announcement.
	 * Optional because we store a Node entry after learning about it from
	 * a channel announcement, but before receiving a node announcement.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_announcement_info(org.ldk.structs.NodeAnnouncementInfo val) {
		Bindings.NodeInfoSetAnnouncementInfo(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new NodeInfo given each field
	 * 
	 * Note that announcement_info_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static NodeInfo of(long[] channels_arg, org.ldk.structs.NodeAnnouncementInfo announcement_info_arg) {
		long ret = Bindings.NodeInfoNew(InternalUtils.EncodeUint64Array(channels_arg), announcement_info_arg == null ? 0 : announcement_info_arg.ptr);
		GC.KeepAlive(channels_arg);
		GC.KeepAlive(announcement_info_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(announcement_info_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.NodeInfoClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the NodeInfo
	 */
	public NodeInfo clone() {
		long ret = Bindings.NodeInfoClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two NodeInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.NodeInfo b) {
		bool ret = Bindings.NodeInfoEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is NodeInfo)) return false;
		return this.eq((NodeInfo)o);
	}
	/**
	 * Serialize the NodeInfo object into a byte array which can be read by NodeInfo_read
	 */
	public byte[] write() {
		long ret = Bindings.NodeInfoWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a NodeInfo from a byte array, created by NodeInfo_write
	 */
	public static Result_NodeInfoDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.NodeInfoRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeInfoDecodeErrorZ ret_hu_conv = Result_NodeInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
