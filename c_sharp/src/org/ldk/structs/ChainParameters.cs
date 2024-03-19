using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Chain-related parameters used to construct a new `ChannelManager`.
 * 
 * Typically, the block-specific parameters are derived from the best block hash for the network,
 * as a newly constructed `ChannelManager` will not have created any channels yet. These parameters
 * are not needed when deserializing a previously constructed `ChannelManager`.
 */
public class ChainParameters : CommonBase {
	internal ChainParameters(object _dummy, long ptr) : base(ptr) { }
	~ChainParameters() {
		if (ptr != 0) { Bindings.ChainParametersFree(ptr); }
	}

	/**
	 * The network for determining the `chain_hash` in Lightning messages.
	 */
	public Network get_network() {
		Network ret = Bindings.ChainParametersGetNetwork(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The network for determining the `chain_hash` in Lightning messages.
	 */
	public void set_network(Network val) {
		Bindings.ChainParametersSetNetwork(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The hash and height of the latest block successfully connected.
	 * 
	 * Used to track on-chain channel funding outputs and send payments with reliable timelocks.
	 */
	public BestBlock get_best_block() {
		long ret = Bindings.ChainParametersGetBestBlock(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BestBlock ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BestBlock(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The hash and height of the latest block successfully connected.
	 * 
	 * Used to track on-chain channel funding outputs and send payments with reliable timelocks.
	 */
	public void set_best_block(org.ldk.structs.BestBlock val) {
		Bindings.ChainParametersSetBestBlock(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ChainParameters given each field
	 */
	public static ChainParameters of(Network network_arg, org.ldk.structs.BestBlock best_block_arg) {
		long ret = Bindings.ChainParametersNew(network_arg, best_block_arg == null ? 0 : best_block_arg.ptr);
		GC.KeepAlive(network_arg);
		GC.KeepAlive(best_block_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChainParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChainParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(best_block_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ChainParametersClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChainParameters
	 */
	public ChainParameters clone() {
		long ret = Bindings.ChainParametersClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChainParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChainParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
