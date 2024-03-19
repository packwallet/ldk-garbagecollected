using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * [`ScoreLookUp`] implementation that factors in in-flight HTLC liquidity.
 * 
 * Useful for custom [`Router`] implementations to wrap their [`ScoreLookUp`] on-the-fly when calling
 * [`find_route`].
 * 
 * [`ScoreLookUp`]: crate::routing::scoring::ScoreLookUp
 */
public class ScorerAccountingForInFlightHtlcs : CommonBase {
	internal ScorerAccountingForInFlightHtlcs(object _dummy, long ptr) : base(ptr) { }
	~ScorerAccountingForInFlightHtlcs() {
		if (ptr != 0) { Bindings.ScorerAccountingForInFlightHtlcsFree(ptr); }
	}

	/**
	 * Initialize a new `ScorerAccountingForInFlightHtlcs`.
	 */
	public static ScorerAccountingForInFlightHtlcs of(org.ldk.structs.ScoreLookUp scorer, org.ldk.structs.InFlightHtlcs inflight_htlcs) {
		long ret = Bindings.ScorerAccountingForInFlightHtlcsNew(scorer.ptr, inflight_htlcs == null ? 0 : inflight_htlcs.ptr);
		GC.KeepAlive(scorer);
		GC.KeepAlive(inflight_htlcs);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ScorerAccountingForInFlightHtlcs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ScorerAccountingForInFlightHtlcs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(scorer); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(inflight_htlcs); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new ScoreLookUp which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned ScoreLookUp must be freed before this_arg is
	 */
	public ScoreLookUp as_ScoreLookUp() {
		long ret = Bindings.ScorerAccountingForInFlightHtlcsAsScoreLookUp(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ScoreLookUp ret_hu_conv = new ScoreLookUp(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
