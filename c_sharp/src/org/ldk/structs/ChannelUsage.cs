using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Proposed use of a channel passed as a parameter to [`ScoreLookUp::channel_penalty_msat`].
 */
public class ChannelUsage : CommonBase {
	internal ChannelUsage(object _dummy, long ptr) : base(ptr) { }
	~ChannelUsage() {
		if (ptr != 0) { Bindings.ChannelUsageFree(ptr); }
	}

	/**
	 * The amount to send through the channel, denominated in millisatoshis.
	 */
	public long get_amount_msat() {
		long ret = Bindings.ChannelUsageGetAmountMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The amount to send through the channel, denominated in millisatoshis.
	 */
	public void set_amount_msat(long val) {
		Bindings.ChannelUsageSetAmountMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Total amount, denominated in millisatoshis, already allocated to send through the channel
	 * as part of a multi-path payment.
	 */
	public long get_inflight_htlc_msat() {
		long ret = Bindings.ChannelUsageGetInflightHtlcMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Total amount, denominated in millisatoshis, already allocated to send through the channel
	 * as part of a multi-path payment.
	 */
	public void set_inflight_htlc_msat(long val) {
		Bindings.ChannelUsageSetInflightHtlcMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The effective capacity of the channel.
	 */
	public EffectiveCapacity get_effective_capacity() {
		long ret = Bindings.ChannelUsageGetEffectiveCapacity(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.EffectiveCapacity ret_hu_conv = org.ldk.structs.EffectiveCapacity.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The effective capacity of the channel.
	 */
	public void set_effective_capacity(org.ldk.structs.EffectiveCapacity val) {
		Bindings.ChannelUsageSetEffectiveCapacity(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ChannelUsage given each field
	 */
	public static ChannelUsage of(long amount_msat_arg, long inflight_htlc_msat_arg, org.ldk.structs.EffectiveCapacity effective_capacity_arg) {
		long ret = Bindings.ChannelUsageNew(amount_msat_arg, inflight_htlc_msat_arg, effective_capacity_arg.ptr);
		GC.KeepAlive(amount_msat_arg);
		GC.KeepAlive(inflight_htlc_msat_arg);
		GC.KeepAlive(effective_capacity_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUsage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUsage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(effective_capacity_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ChannelUsageClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelUsage
	 */
	public ChannelUsage clone() {
		long ret = Bindings.ChannelUsageClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelUsage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelUsage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
