using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Receives and validates network updates from peers,
 * stores authentic and relevant data as a network graph.
 * This network graph is then used for routing payments.
 * Provides interface to help with initial routing sync by
 * serving historical announcements.
 */
public class P2PGossipSync : CommonBase {
	internal P2PGossipSync(object _dummy, long ptr) : base(ptr) { }
	~P2PGossipSync() {
		if (ptr != 0) { Bindings.P2PGossipSyncFree(ptr); }
	}

	/**
	 * Creates a new tracker of the actual state of the network of channels and nodes,
	 * assuming an existing [`NetworkGraph`].
	 * UTXO lookup is used to make sure announced channels exist on-chain, channel data is
	 * correct, and the announcement is signed with channel owners' keys.
	 */
	public static P2PGossipSync of(org.ldk.structs.NetworkGraph network_graph, org.ldk.structs.Option_UtxoLookupZ utxo_lookup, org.ldk.structs.Logger logger) {
		long ret = Bindings.P2PGossipSyncNew(network_graph == null ? 0 : network_graph.ptr, utxo_lookup.ptr, logger.ptr);
		GC.KeepAlive(network_graph);
		GC.KeepAlive(utxo_lookup);
		GC.KeepAlive(logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.P2PGossipSync ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.P2PGossipSync(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(network_graph); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(utxo_lookup); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(logger); };
		return ret_hu_conv;
	}

	/**
	 * Adds a provider used to check new announcements. Does not affect
	 * existing announcements unless they are updated.
	 * Add, update or remove the provider would replace the current one.
	 */
	public void add_utxo_lookup(org.ldk.structs.Option_UtxoLookupZ utxo_lookup) {
		Bindings.P2PGossipSyncAddUtxoLookup(this.ptr, utxo_lookup.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(utxo_lookup);
		if (this != null) { this.ptrs_to.AddLast(utxo_lookup); };
	}

	/**
	 * Constructs a new RoutingMessageHandler which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned RoutingMessageHandler must be freed before this_arg is
	 */
	public RoutingMessageHandler as_RoutingMessageHandler() {
		long ret = Bindings.P2PGossipSyncAsRoutingMessageHandler(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		RoutingMessageHandler ret_hu_conv = new RoutingMessageHandler(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new MessageSendEventsProvider which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned MessageSendEventsProvider must be freed before this_arg is
	 */
	public MessageSendEventsProvider as_MessageSendEventsProvider() {
		long ret = Bindings.P2PGossipSyncAsMessageSendEventsProvider(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		MessageSendEventsProvider ret_hu_conv = new MessageSendEventsProvider(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
