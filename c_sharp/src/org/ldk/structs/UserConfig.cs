using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Top-level config which holds ChannelHandshakeLimits and ChannelConfig.
 * 
 * Default::default() provides sane defaults for most configurations
 * (but currently with 0 relay fees!)
 */
public class UserConfig : CommonBase {
	internal UserConfig(object _dummy, long ptr) : base(ptr) { }
	~UserConfig() {
		if (ptr != 0) { Bindings.UserConfigFree(ptr); }
	}

	/**
	 * Channel handshake config that we propose to our counterparty.
	 */
	public ChannelHandshakeConfig get_channel_handshake_config() {
		long ret = Bindings.UserConfigGetChannelHandshakeConfig(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelHandshakeConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelHandshakeConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Channel handshake config that we propose to our counterparty.
	 */
	public void set_channel_handshake_config(org.ldk.structs.ChannelHandshakeConfig val) {
		Bindings.UserConfigSetChannelHandshakeConfig(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Limits applied to our counterparty's proposed channel handshake config settings.
	 */
	public ChannelHandshakeLimits get_channel_handshake_limits() {
		long ret = Bindings.UserConfigGetChannelHandshakeLimits(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelHandshakeLimits ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelHandshakeLimits(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Limits applied to our counterparty's proposed channel handshake config settings.
	 */
	public void set_channel_handshake_limits(org.ldk.structs.ChannelHandshakeLimits val) {
		Bindings.UserConfigSetChannelHandshakeLimits(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Channel config which affects behavior during channel lifetime.
	 */
	public ChannelConfig get_channel_config() {
		long ret = Bindings.UserConfigGetChannelConfig(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Channel config which affects behavior during channel lifetime.
	 */
	public void set_channel_config(org.ldk.structs.ChannelConfig val) {
		Bindings.UserConfigSetChannelConfig(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * If this is set to false, we will reject any HTLCs which were to be forwarded over private
	 * channels. This prevents us from taking on HTLC-forwarding risk when we intend to run as a
	 * node which is not online reliably.
	 * 
	 * For nodes which are not online reliably, you should set all channels to *not* be announced
	 * (using [`ChannelHandshakeConfig::announced_channel`] and
	 * [`ChannelHandshakeLimits::force_announced_channel_preference`]) and set this to false to
	 * ensure you are not exposed to any forwarding risk.
	 * 
	 * Note that because you cannot change a channel's announced state after creation, there is no
	 * way to disable forwarding on public channels retroactively. Thus, in order to change a node
	 * from a publicly-announced forwarding node to a private non-forwarding node you must close
	 * all your channels and open new ones. For privacy, you should also change your node_id
	 * (swapping all private and public key material for new ones) at that time.
	 * 
	 * Default value: false.
	 */
	public bool get_accept_forwards_to_priv_channels() {
		bool ret = Bindings.UserConfigGetAcceptForwardsToPrivChannels(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * If this is set to false, we will reject any HTLCs which were to be forwarded over private
	 * channels. This prevents us from taking on HTLC-forwarding risk when we intend to run as a
	 * node which is not online reliably.
	 * 
	 * For nodes which are not online reliably, you should set all channels to *not* be announced
	 * (using [`ChannelHandshakeConfig::announced_channel`] and
	 * [`ChannelHandshakeLimits::force_announced_channel_preference`]) and set this to false to
	 * ensure you are not exposed to any forwarding risk.
	 * 
	 * Note that because you cannot change a channel's announced state after creation, there is no
	 * way to disable forwarding on public channels retroactively. Thus, in order to change a node
	 * from a publicly-announced forwarding node to a private non-forwarding node you must close
	 * all your channels and open new ones. For privacy, you should also change your node_id
	 * (swapping all private and public key material for new ones) at that time.
	 * 
	 * Default value: false.
	 */
	public void set_accept_forwards_to_priv_channels(bool val) {
		Bindings.UserConfigSetAcceptForwardsToPrivChannels(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If this is set to false, we do not accept inbound requests to open a new channel.
	 * Default value: true.
	 */
	public bool get_accept_inbound_channels() {
		bool ret = Bindings.UserConfigGetAcceptInboundChannels(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * If this is set to false, we do not accept inbound requests to open a new channel.
	 * Default value: true.
	 */
	public void set_accept_inbound_channels(bool val) {
		Bindings.UserConfigSetAcceptInboundChannels(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If this is set to true, the user needs to manually accept inbound requests to open a new
	 * channel.
	 * 
	 * When set to true, [`Event::OpenChannelRequest`] will be triggered once a request to open a
	 * new inbound channel is received through a [`msgs::OpenChannel`] message. In that case, a
	 * [`msgs::AcceptChannel`] message will not be sent back to the counterparty node unless the
	 * user explicitly chooses to accept the request.
	 * 
	 * Default value: false.
	 * 
	 * [`Event::OpenChannelRequest`]: crate::events::Event::OpenChannelRequest
	 * [`msgs::OpenChannel`]: crate::ln::msgs::OpenChannel
	 * [`msgs::AcceptChannel`]: crate::ln::msgs::AcceptChannel
	 */
	public bool get_manually_accept_inbound_channels() {
		bool ret = Bindings.UserConfigGetManuallyAcceptInboundChannels(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * If this is set to true, the user needs to manually accept inbound requests to open a new
	 * channel.
	 * 
	 * When set to true, [`Event::OpenChannelRequest`] will be triggered once a request to open a
	 * new inbound channel is received through a [`msgs::OpenChannel`] message. In that case, a
	 * [`msgs::AcceptChannel`] message will not be sent back to the counterparty node unless the
	 * user explicitly chooses to accept the request.
	 * 
	 * Default value: false.
	 * 
	 * [`Event::OpenChannelRequest`]: crate::events::Event::OpenChannelRequest
	 * [`msgs::OpenChannel`]: crate::ln::msgs::OpenChannel
	 * [`msgs::AcceptChannel`]: crate::ln::msgs::AcceptChannel
	 */
	public void set_manually_accept_inbound_channels(bool val) {
		Bindings.UserConfigSetManuallyAcceptInboundChannels(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If this is set to true, LDK will intercept HTLCs that are attempting to be forwarded over
	 * fake short channel ids generated via [`ChannelManager::get_intercept_scid`]. Upon HTLC
	 * intercept, LDK will generate an [`Event::HTLCIntercepted`] which MUST be handled by the user.
	 * 
	 * Setting this to true may break backwards compatibility with LDK versions < 0.0.113.
	 * 
	 * Default value: false.
	 * 
	 * [`ChannelManager::get_intercept_scid`]: crate::ln::channelmanager::ChannelManager::get_intercept_scid
	 * [`Event::HTLCIntercepted`]: crate::events::Event::HTLCIntercepted
	 */
	public bool get_accept_intercept_htlcs() {
		bool ret = Bindings.UserConfigGetAcceptInterceptHtlcs(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * If this is set to true, LDK will intercept HTLCs that are attempting to be forwarded over
	 * fake short channel ids generated via [`ChannelManager::get_intercept_scid`]. Upon HTLC
	 * intercept, LDK will generate an [`Event::HTLCIntercepted`] which MUST be handled by the user.
	 * 
	 * Setting this to true may break backwards compatibility with LDK versions < 0.0.113.
	 * 
	 * Default value: false.
	 * 
	 * [`ChannelManager::get_intercept_scid`]: crate::ln::channelmanager::ChannelManager::get_intercept_scid
	 * [`Event::HTLCIntercepted`]: crate::events::Event::HTLCIntercepted
	 */
	public void set_accept_intercept_htlcs(bool val) {
		Bindings.UserConfigSetAcceptInterceptHtlcs(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If this is set to false, when receiving a keysend payment we'll fail it if it has multiple
	 * parts. If this is set to true, we'll accept the payment.
	 * 
	 * Setting this to true will break backwards compatibility upon downgrading to an LDK
	 * version < 0.0.116 while receiving an MPP keysend. If we have already received an MPP
	 * keysend, downgrading will cause us to fail to deserialize [`ChannelManager`].
	 * 
	 * Default value: false.
	 * 
	 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
	 */
	public bool get_accept_mpp_keysend() {
		bool ret = Bindings.UserConfigGetAcceptMppKeysend(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * If this is set to false, when receiving a keysend payment we'll fail it if it has multiple
	 * parts. If this is set to true, we'll accept the payment.
	 * 
	 * Setting this to true will break backwards compatibility upon downgrading to an LDK
	 * version < 0.0.116 while receiving an MPP keysend. If we have already received an MPP
	 * keysend, downgrading will cause us to fail to deserialize [`ChannelManager`].
	 * 
	 * Default value: false.
	 * 
	 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
	 */
	public void set_accept_mpp_keysend(bool val) {
		Bindings.UserConfigSetAcceptMppKeysend(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UserConfig given each field
	 */
	public static UserConfig of(org.ldk.structs.ChannelHandshakeConfig channel_handshake_config_arg, org.ldk.structs.ChannelHandshakeLimits channel_handshake_limits_arg, org.ldk.structs.ChannelConfig channel_config_arg, bool accept_forwards_to_priv_channels_arg, bool accept_inbound_channels_arg, bool manually_accept_inbound_channels_arg, bool accept_intercept_htlcs_arg, bool accept_mpp_keysend_arg) {
		long ret = Bindings.UserConfigNew(channel_handshake_config_arg == null ? 0 : channel_handshake_config_arg.ptr, channel_handshake_limits_arg == null ? 0 : channel_handshake_limits_arg.ptr, channel_config_arg == null ? 0 : channel_config_arg.ptr, accept_forwards_to_priv_channels_arg, accept_inbound_channels_arg, manually_accept_inbound_channels_arg, accept_intercept_htlcs_arg, accept_mpp_keysend_arg);
		GC.KeepAlive(channel_handshake_config_arg);
		GC.KeepAlive(channel_handshake_limits_arg);
		GC.KeepAlive(channel_config_arg);
		GC.KeepAlive(accept_forwards_to_priv_channels_arg);
		GC.KeepAlive(accept_inbound_channels_arg);
		GC.KeepAlive(manually_accept_inbound_channels_arg);
		GC.KeepAlive(accept_intercept_htlcs_arg);
		GC.KeepAlive(accept_mpp_keysend_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UserConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UserConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_handshake_config_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_handshake_limits_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_config_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.UserConfigClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UserConfig
	 */
	public UserConfig clone() {
		long ret = Bindings.UserConfigClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UserConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UserConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a "default" UserConfig. See struct and individual field documentaiton for details on which values are used.
	 */
	public static UserConfig with_default() {
		long ret = Bindings.UserConfigDefault();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UserConfig ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UserConfig(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
