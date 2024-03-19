using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A read-only view of [`NetworkGraph`].
 */
public class ReadOnlyNetworkGraph : CommonBase, IDisposable {
	internal ReadOnlyNetworkGraph(object _dummy, long ptr) : base(ptr) { }
	public void Dispose() {
		if (ptr != 0) { Bindings.ReadOnlyNetworkGraphFree(ptr); }
	}

	/**
	 * Returns information on a channel with the given id.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public ChannelInfo channel(long short_channel_id) {
		long ret = Bindings.ReadOnlyNetworkGraphChannel(this.ptr, short_channel_id);
		GC.KeepAlive(this);
		GC.KeepAlive(short_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns the list of channels in the graph
	 */
	public long[] list_channels() {
		long ret = Bindings.ReadOnlyNetworkGraphListChannels(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		long[] ret_conv = InternalUtils.DecodeUint64Array(ret);
		return ret_conv;
	}

	/**
	 * Returns information on a node with the given id.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public NodeInfo node(org.ldk.structs.NodeId node_id) {
		long ret = Bindings.ReadOnlyNetworkGraphNode(this.ptr, node_id == null ? 0 : node_id.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		if (this != null) { this.ptrs_to.AddLast(node_id); };
		return ret_hu_conv;
	}

	/**
	 * Returns the list of nodes in the graph
	 */
	public NodeId[] list_nodes() {
		long ret = Bindings.ReadOnlyNetworkGraphListNodes(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_8_len = InternalUtils.GetArrayLength(ret);
		NodeId[] ret_conv_8_arr = new NodeId[ret_conv_8_len];
		for (int i = 0; i < ret_conv_8_len; i++) {
			long ret_conv_8 = InternalUtils.GetU64ArrayElem(ret, i);
			org.ldk.structs.NodeId ret_conv_8_hu_conv = null; if (ret_conv_8 < 0 || ret_conv_8 > 4096) { ret_conv_8_hu_conv = new org.ldk.structs.NodeId(null, ret_conv_8); }
			if (ret_conv_8_hu_conv != null) { ret_conv_8_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_8_arr[i] = ret_conv_8_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_8_arr;
	}

	/**
	 * Get network addresses by node id.
	 * Returns None if the requested node is completely unknown,
	 * or if node announcement for the node was never received.
	 */
	public Option_CVec_SocketAddressZZ get_addresses(byte[] pubkey) {
		long ret = Bindings.ReadOnlyNetworkGraphGetAddresses(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(pubkey, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(pubkey);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_SocketAddressZZ ret_hu_conv = org.ldk.structs.Option_CVec_SocketAddressZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
