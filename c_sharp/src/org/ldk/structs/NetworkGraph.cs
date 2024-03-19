using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Represents the network as nodes and channels between them
 */
public class NetworkGraph : CommonBase {
	internal NetworkGraph(object _dummy, long ptr) : base(ptr) { }
	~NetworkGraph() {
		if (ptr != 0) { Bindings.NetworkGraphFree(ptr); }
	}

	/**
	 * Handles any network updates originating from [`Event`]s.
	 * Note that this will skip applying any [`NetworkUpdate::ChannelUpdateMessage`] to avoid
	 * leaking possibly identifying information of the sender to the public network.
	 * 
	 * [`Event`]: crate::events::Event
	 */
	public void handle_network_update(org.ldk.structs.NetworkUpdate network_update) {
		Bindings.NetworkGraphHandleNetworkUpdate(this.ptr, network_update == null ? 0 : network_update.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(network_update);
	}

	/**
	 * Gets the chain hash for this network graph.
	 */
	public byte[] get_chain_hash() {
		long ret = Bindings.NetworkGraphGetChainHash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Serialize the NetworkGraph object into a byte array which can be read by NetworkGraph_read
	 */
	public byte[] write() {
		long ret = Bindings.NetworkGraphWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a NetworkGraph from a byte array, created by NetworkGraph_write
	 */
	public static Result_NetworkGraphDecodeErrorZ read(byte[] ser, org.ldk.structs.Logger arg) {
		long ret = Bindings.NetworkGraphRead(InternalUtils.EncodeUint8Array(ser), arg.ptr);
		GC.KeepAlive(ser);
		GC.KeepAlive(arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NetworkGraphDecodeErrorZ ret_hu_conv = Result_NetworkGraphDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(arg); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new, empty, network graph.
	 */
	public static NetworkGraph of(Network network, org.ldk.structs.Logger logger) {
		long ret = Bindings.NetworkGraphNew(network, logger.ptr);
		GC.KeepAlive(network);
		GC.KeepAlive(logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NetworkGraph ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NetworkGraph(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(logger); };
		return ret_hu_conv;
	}

	/**
	 * Returns a read-only view of the network graph.
	 */
	public ReadOnlyNetworkGraph read_only() {
		long ret = Bindings.NetworkGraphReadOnly(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReadOnlyNetworkGraph ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReadOnlyNetworkGraph(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The unix timestamp provided by the most recent rapid gossip sync.
	 * It will be set by the rapid sync process after every sync completion.
	 */
	public Option_u32Z get_last_rapid_gossip_sync_timestamp() {
		long ret = Bindings.NetworkGraphGetLastRapidGossipSyncTimestamp(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Update the unix timestamp provided by the most recent rapid gossip sync.
	 * This should be done automatically by the rapid sync process after every sync completion.
	 */
	public void set_last_rapid_gossip_sync_timestamp(int last_rapid_gossip_sync_timestamp) {
		Bindings.NetworkGraphSetLastRapidGossipSyncTimestamp(this.ptr, last_rapid_gossip_sync_timestamp);
		GC.KeepAlive(this);
		GC.KeepAlive(last_rapid_gossip_sync_timestamp);
	}

	/**
	 * For an already known node (from channel announcements), update its stored properties from a
	 * given node announcement.
	 * 
	 * You probably don't want to call this directly, instead relying on a P2PGossipSync's
	 * RoutingMessageHandler implementation to call it indirectly. This may be useful to accept
	 * routing messages from a source using a protocol other than the lightning P2P protocol.
	 */
	public Result_NoneLightningErrorZ update_node_from_announcement(org.ldk.structs.NodeAnnouncement msg) {
		long ret = Bindings.NetworkGraphUpdateNodeFromAnnouncement(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * For an already known node (from channel announcements), update its stored properties from a
	 * given node announcement without verifying the associated signatures. Because we aren't
	 * given the associated signatures here we cannot relay the node announcement to any of our
	 * peers.
	 */
	public Result_NoneLightningErrorZ update_node_from_unsigned_announcement(org.ldk.structs.UnsignedNodeAnnouncement msg) {
		long ret = Bindings.NetworkGraphUpdateNodeFromUnsignedAnnouncement(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Store or update channel info from a channel announcement.
	 * 
	 * You probably don't want to call this directly, instead relying on a [`P2PGossipSync`]'s
	 * [`RoutingMessageHandler`] implementation to call it indirectly. This may be useful to accept
	 * routing messages from a source using a protocol other than the lightning P2P protocol.
	 * 
	 * If a [`UtxoLookup`] object is provided via `utxo_lookup`, it will be called to verify
	 * the corresponding UTXO exists on chain and is correctly-formatted.
	 */
	public Result_NoneLightningErrorZ update_channel_from_announcement(org.ldk.structs.ChannelAnnouncement msg, org.ldk.structs.Option_UtxoLookupZ utxo_lookup) {
		long ret = Bindings.NetworkGraphUpdateChannelFromAnnouncement(this.ptr, msg == null ? 0 : msg.ptr, utxo_lookup.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		GC.KeepAlive(utxo_lookup);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		if (this != null) { this.ptrs_to.AddLast(utxo_lookup); };
		return ret_hu_conv;
	}

	/**
	 * Store or update channel info from a channel announcement.
	 * 
	 * You probably don't want to call this directly, instead relying on a [`P2PGossipSync`]'s
	 * [`RoutingMessageHandler`] implementation to call it indirectly. This may be useful to accept
	 * routing messages from a source using a protocol other than the lightning P2P protocol.
	 * 
	 * This will skip verification of if the channel is actually on-chain.
	 */
	public Result_NoneLightningErrorZ update_channel_from_announcement_no_lookup(org.ldk.structs.ChannelAnnouncement msg) {
		long ret = Bindings.NetworkGraphUpdateChannelFromAnnouncementNoLookup(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Store or update channel info from a channel announcement without verifying the associated
	 * signatures. Because we aren't given the associated signatures here we cannot relay the
	 * channel announcement to any of our peers.
	 * 
	 * If a [`UtxoLookup`] object is provided via `utxo_lookup`, it will be called to verify
	 * the corresponding UTXO exists on chain and is correctly-formatted.
	 */
	public Result_NoneLightningErrorZ update_channel_from_unsigned_announcement(org.ldk.structs.UnsignedChannelAnnouncement msg, org.ldk.structs.Option_UtxoLookupZ utxo_lookup) {
		long ret = Bindings.NetworkGraphUpdateChannelFromUnsignedAnnouncement(this.ptr, msg == null ? 0 : msg.ptr, utxo_lookup.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		GC.KeepAlive(utxo_lookup);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		if (this != null) { this.ptrs_to.AddLast(utxo_lookup); };
		return ret_hu_conv;
	}

	/**
	 * Update channel from partial announcement data received via rapid gossip sync
	 * 
	 * `timestamp: u64`: Timestamp emulating the backdated original announcement receipt (by the
	 * rapid gossip sync server)
	 * 
	 * All other parameters as used in [`msgs::UnsignedChannelAnnouncement`] fields.
	 */
	public Result_NoneLightningErrorZ add_channel_from_partial_announcement(long short_channel_id, long timestamp, org.ldk.structs.ChannelFeatures features, byte[] node_id_1, byte[] node_id_2) {
		long ret = Bindings.NetworkGraphAddChannelFromPartialAnnouncement(this.ptr, short_channel_id, timestamp, features == null ? 0 : features.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_id_1, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_id_2, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(short_channel_id);
		GC.KeepAlive(timestamp);
		GC.KeepAlive(features);
		GC.KeepAlive(node_id_1);
		GC.KeepAlive(node_id_2);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(features); };
		return ret_hu_conv;
	}

	/**
	 * Marks a channel in the graph as failed permanently.
	 * 
	 * The channel and any node for which this was their last channel are removed from the graph.
	 */
	public void channel_failed_permanent(long short_channel_id) {
		Bindings.NetworkGraphChannelFailedPermanent(this.ptr, short_channel_id);
		GC.KeepAlive(this);
		GC.KeepAlive(short_channel_id);
	}

	/**
	 * Marks a node in the graph as permanently failed, effectively removing it and its channels
	 * from local storage.
	 */
	public void node_failed_permanent(byte[] node_id) {
		Bindings.NetworkGraphNodeFailedPermanent(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_id, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(node_id);
	}

	/**
	 * Removes information about channels that we haven't heard any updates about in some time.
	 * This can be used regularly to prune the network graph of channels that likely no longer
	 * exist.
	 * 
	 * While there is no formal requirement that nodes regularly re-broadcast their channel
	 * updates every two weeks, the non-normative section of BOLT 7 currently suggests that
	 * pruning occur for updates which are at least two weeks old, which we implement here.
	 * 
	 * Note that for users of the `lightning-background-processor` crate this method may be
	 * automatically called regularly for you.
	 * 
	 * This method will also cause us to stop tracking removed nodes and channels if they have been
	 * in the map for a while so that these can be resynced from gossip in the future.
	 * 
	 * This method is only available with the `std` feature. See
	 * [`NetworkGraph::remove_stale_channels_and_tracking_with_time`] for `no-std` use.
	 */
	public void remove_stale_channels_and_tracking() {
		Bindings.NetworkGraphRemoveStaleChannelsAndTracking(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Removes information about channels that we haven't heard any updates about in some time.
	 * This can be used regularly to prune the network graph of channels that likely no longer
	 * exist.
	 * 
	 * While there is no formal requirement that nodes regularly re-broadcast their channel
	 * updates every two weeks, the non-normative section of BOLT 7 currently suggests that
	 * pruning occur for updates which are at least two weeks old, which we implement here.
	 * 
	 * This method will also cause us to stop tracking removed nodes and channels if they have been
	 * in the map for a while so that these can be resynced from gossip in the future.
	 * 
	 * This function takes the current unix time as an argument. For users with the `std` feature
	 * enabled, [`NetworkGraph::remove_stale_channels_and_tracking`] may be preferable.
	 */
	public void remove_stale_channels_and_tracking_with_time(long current_time_unix) {
		Bindings.NetworkGraphRemoveStaleChannelsAndTrackingWithTime(this.ptr, current_time_unix);
		GC.KeepAlive(this);
		GC.KeepAlive(current_time_unix);
	}

	/**
	 * For an already known (from announcement) channel, update info about one of the directions
	 * of the channel.
	 * 
	 * You probably don't want to call this directly, instead relying on a [`P2PGossipSync`]'s
	 * [`RoutingMessageHandler`] implementation to call it indirectly. This may be useful to accept
	 * routing messages from a source using a protocol other than the lightning P2P protocol.
	 * 
	 * If built with `no-std`, any updates with a timestamp more than two weeks in the past or
	 * materially in the future will be rejected.
	 */
	public Result_NoneLightningErrorZ update_channel(org.ldk.structs.ChannelUpdate msg) {
		long ret = Bindings.NetworkGraphUpdateChannel(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * For an already known (from announcement) channel, update info about one of the directions
	 * of the channel without verifying the associated signatures. Because we aren't given the
	 * associated signatures here we cannot relay the channel update to any of our peers.
	 * 
	 * If built with `no-std`, any updates with a timestamp more than two weeks in the past or
	 * materially in the future will be rejected.
	 */
	public Result_NoneLightningErrorZ update_channel_unsigned(org.ldk.structs.UnsignedChannelUpdate msg) {
		long ret = Bindings.NetworkGraphUpdateChannelUnsigned(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * For an already known (from announcement) channel, verify the given [`ChannelUpdate`].
	 * 
	 * This checks whether the update currently is applicable by [`Self::update_channel`].
	 * 
	 * If built with `no-std`, any updates with a timestamp more than two weeks in the past or
	 * materially in the future will be rejected.
	 */
	public Result_NoneLightningErrorZ verify_channel_update(org.ldk.structs.ChannelUpdate msg) {
		long ret = Bindings.NetworkGraphVerifyChannelUpdate(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

}
} } }
