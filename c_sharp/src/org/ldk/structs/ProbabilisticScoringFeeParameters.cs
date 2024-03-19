using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Parameters for configuring [`ProbabilisticScorer`].
 * 
 * Used to configure base, liquidity, and amount penalties, the sum of which comprises the channel
 * penalty (i.e., the amount in msats willing to be paid to avoid routing through the channel).
 * 
 * The penalty applied to any channel by the [`ProbabilisticScorer`] is the sum of each of the
 * parameters here.
 */
public class ProbabilisticScoringFeeParameters : CommonBase {
	internal ProbabilisticScoringFeeParameters(object _dummy, long ptr) : base(ptr) { }
	~ProbabilisticScoringFeeParameters() {
		if (ptr != 0) { Bindings.ProbabilisticScoringFeeParametersFree(ptr); }
	}

	/**
	 * A fixed penalty in msats to apply to each channel.
	 * 
	 * Default value: 500 msat
	 */
	public long get_base_penalty_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetBasePenaltyMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A fixed penalty in msats to apply to each channel.
	 * 
	 * Default value: 500 msat
	 */
	public void set_base_penalty_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetBasePenaltyMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A multiplier used with the total amount flowing over a channel to calculate a fixed penalty
	 * applied to each channel, in excess of the [`base_penalty_msat`].
	 * 
	 * The purpose of the amount penalty is to avoid having fees dominate the channel cost (i.e.,
	 * fees plus penalty) for large payments. The penalty is computed as the product of this
	 * multiplier and `2^30`ths of the total amount flowing over a channel (i.e. the payment
	 * amount plus the amount of any other HTLCs flowing we sent over the same channel).
	 * 
	 * ie `base_penalty_amount_multiplier_msat * amount_msat / 2^30`
	 * 
	 * Default value: 8,192 msat
	 * 
	 * [`base_penalty_msat`]: Self::base_penalty_msat
	 */
	public long get_base_penalty_amount_multiplier_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetBasePenaltyAmountMultiplierMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A multiplier used with the total amount flowing over a channel to calculate a fixed penalty
	 * applied to each channel, in excess of the [`base_penalty_msat`].
	 * 
	 * The purpose of the amount penalty is to avoid having fees dominate the channel cost (i.e.,
	 * fees plus penalty) for large payments. The penalty is computed as the product of this
	 * multiplier and `2^30`ths of the total amount flowing over a channel (i.e. the payment
	 * amount plus the amount of any other HTLCs flowing we sent over the same channel).
	 * 
	 * ie `base_penalty_amount_multiplier_msat * amount_msat / 2^30`
	 * 
	 * Default value: 8,192 msat
	 * 
	 * [`base_penalty_msat`]: Self::base_penalty_msat
	 */
	public void set_base_penalty_amount_multiplier_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetBasePenaltyAmountMultiplierMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A multiplier used in conjunction with the negative `log10` of the channel's success
	 * probability for a payment, as determined by our latest estimates of the channel's
	 * liquidity, to determine the liquidity penalty.
	 * 
	 * The penalty is based in part on the knowledge learned from prior successful and unsuccessful
	 * payments. This knowledge is decayed over time based on [`liquidity_offset_half_life`]. The
	 * penalty is effectively limited to `2 * liquidity_penalty_multiplier_msat` (corresponding to
	 * lower bounding the success probability to `0.01`) when the amount falls within the
	 * uncertainty bounds of the channel liquidity balance. Amounts above the upper bound will
	 * result in a `u64::max_value` penalty, however.
	 * 
	 * `-log10(success_probability) * liquidity_penalty_multiplier_msat`
	 * 
	 * Default value: 30,000 msat
	 * 
	 * [`liquidity_offset_half_life`]: ProbabilisticScoringDecayParameters::liquidity_offset_half_life
	 */
	public long get_liquidity_penalty_multiplier_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetLiquidityPenaltyMultiplierMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A multiplier used in conjunction with the negative `log10` of the channel's success
	 * probability for a payment, as determined by our latest estimates of the channel's
	 * liquidity, to determine the liquidity penalty.
	 * 
	 * The penalty is based in part on the knowledge learned from prior successful and unsuccessful
	 * payments. This knowledge is decayed over time based on [`liquidity_offset_half_life`]. The
	 * penalty is effectively limited to `2 * liquidity_penalty_multiplier_msat` (corresponding to
	 * lower bounding the success probability to `0.01`) when the amount falls within the
	 * uncertainty bounds of the channel liquidity balance. Amounts above the upper bound will
	 * result in a `u64::max_value` penalty, however.
	 * 
	 * `-log10(success_probability) * liquidity_penalty_multiplier_msat`
	 * 
	 * Default value: 30,000 msat
	 * 
	 * [`liquidity_offset_half_life`]: ProbabilisticScoringDecayParameters::liquidity_offset_half_life
	 */
	public void set_liquidity_penalty_multiplier_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetLiquidityPenaltyMultiplierMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A multiplier used in conjunction with the total amount flowing over a channel and the
	 * negative `log10` of the channel's success probability for the payment, as determined by our
	 * latest estimates of the channel's liquidity, to determine the amount penalty.
	 * 
	 * The purpose of the amount penalty is to avoid having fees dominate the channel cost (i.e.,
	 * fees plus penalty) for large payments. The penalty is computed as the product of this
	 * multiplier and `2^20`ths of the amount flowing over this channel, weighted by the negative
	 * `log10` of the success probability.
	 * 
	 * `-log10(success_probability) * liquidity_penalty_amount_multiplier_msat * amount_msat / 2^20`
	 * 
	 * In practice, this means for 0.1 success probability (`-log10(0.1) == 1`) each `2^20`th of
	 * the amount will result in a penalty of the multiplier. And, as the success probability
	 * decreases, the negative `log10` weighting will increase dramatically. For higher success
	 * probabilities, the multiplier will have a decreasing effect as the negative `log10` will
	 * fall below `1`.
	 * 
	 * Default value: 192 msat
	 */
	public long get_liquidity_penalty_amount_multiplier_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetLiquidityPenaltyAmountMultiplierMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A multiplier used in conjunction with the total amount flowing over a channel and the
	 * negative `log10` of the channel's success probability for the payment, as determined by our
	 * latest estimates of the channel's liquidity, to determine the amount penalty.
	 * 
	 * The purpose of the amount penalty is to avoid having fees dominate the channel cost (i.e.,
	 * fees plus penalty) for large payments. The penalty is computed as the product of this
	 * multiplier and `2^20`ths of the amount flowing over this channel, weighted by the negative
	 * `log10` of the success probability.
	 * 
	 * `-log10(success_probability) * liquidity_penalty_amount_multiplier_msat * amount_msat / 2^20`
	 * 
	 * In practice, this means for 0.1 success probability (`-log10(0.1) == 1`) each `2^20`th of
	 * the amount will result in a penalty of the multiplier. And, as the success probability
	 * decreases, the negative `log10` weighting will increase dramatically. For higher success
	 * probabilities, the multiplier will have a decreasing effect as the negative `log10` will
	 * fall below `1`.
	 * 
	 * Default value: 192 msat
	 */
	public void set_liquidity_penalty_amount_multiplier_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetLiquidityPenaltyAmountMultiplierMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A multiplier used in conjunction with the negative `log10` of the channel's success
	 * probability for the payment, as determined based on the history of our estimates of the
	 * channel's available liquidity, to determine a penalty.
	 * 
	 * This penalty is similar to [`liquidity_penalty_multiplier_msat`], however, instead of using
	 * only our latest estimate for the current liquidity available in the channel, it estimates
	 * success probability based on the estimated liquidity available in the channel through
	 * history. Specifically, every time we update our liquidity bounds on a given channel, we
	 * track which of several buckets those bounds fall into, exponentially decaying the
	 * probability of each bucket as new samples are added.
	 * 
	 * Default value: 10,000 msat
	 * 
	 * [`liquidity_penalty_multiplier_msat`]: Self::liquidity_penalty_multiplier_msat
	 */
	public long get_historical_liquidity_penalty_multiplier_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetHistoricalLiquidityPenaltyMultiplierMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A multiplier used in conjunction with the negative `log10` of the channel's success
	 * probability for the payment, as determined based on the history of our estimates of the
	 * channel's available liquidity, to determine a penalty.
	 * 
	 * This penalty is similar to [`liquidity_penalty_multiplier_msat`], however, instead of using
	 * only our latest estimate for the current liquidity available in the channel, it estimates
	 * success probability based on the estimated liquidity available in the channel through
	 * history. Specifically, every time we update our liquidity bounds on a given channel, we
	 * track which of several buckets those bounds fall into, exponentially decaying the
	 * probability of each bucket as new samples are added.
	 * 
	 * Default value: 10,000 msat
	 * 
	 * [`liquidity_penalty_multiplier_msat`]: Self::liquidity_penalty_multiplier_msat
	 */
	public void set_historical_liquidity_penalty_multiplier_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetHistoricalLiquidityPenaltyMultiplierMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A multiplier used in conjunction with the total amount flowing over a channel and the
	 * negative `log10` of the channel's success probability for the payment, as determined based
	 * on the history of our estimates of the channel's available liquidity, to determine a
	 * penalty.
	 * 
	 * The purpose of the amount penalty is to avoid having fees dominate the channel cost for
	 * large payments. The penalty is computed as the product of this multiplier and `2^20`ths
	 * of the amount flowing over this channel, weighted by the negative `log10` of the success
	 * probability.
	 * 
	 * This penalty is similar to [`liquidity_penalty_amount_multiplier_msat`], however, instead
	 * of using only our latest estimate for the current liquidity available in the channel, it
	 * estimates success probability based on the estimated liquidity available in the channel
	 * through history. Specifically, every time we update our liquidity bounds on a given
	 * channel, we track which of several buckets those bounds fall into, exponentially decaying
	 * the probability of each bucket as new samples are added.
	 * 
	 * Default value: 64 msat
	 * 
	 * [`liquidity_penalty_amount_multiplier_msat`]: Self::liquidity_penalty_amount_multiplier_msat
	 */
	public long get_historical_liquidity_penalty_amount_multiplier_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetHistoricalLiquidityPenaltyAmountMultiplierMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A multiplier used in conjunction with the total amount flowing over a channel and the
	 * negative `log10` of the channel's success probability for the payment, as determined based
	 * on the history of our estimates of the channel's available liquidity, to determine a
	 * penalty.
	 * 
	 * The purpose of the amount penalty is to avoid having fees dominate the channel cost for
	 * large payments. The penalty is computed as the product of this multiplier and `2^20`ths
	 * of the amount flowing over this channel, weighted by the negative `log10` of the success
	 * probability.
	 * 
	 * This penalty is similar to [`liquidity_penalty_amount_multiplier_msat`], however, instead
	 * of using only our latest estimate for the current liquidity available in the channel, it
	 * estimates success probability based on the estimated liquidity available in the channel
	 * through history. Specifically, every time we update our liquidity bounds on a given
	 * channel, we track which of several buckets those bounds fall into, exponentially decaying
	 * the probability of each bucket as new samples are added.
	 * 
	 * Default value: 64 msat
	 * 
	 * [`liquidity_penalty_amount_multiplier_msat`]: Self::liquidity_penalty_amount_multiplier_msat
	 */
	public void set_historical_liquidity_penalty_amount_multiplier_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetHistoricalLiquidityPenaltyAmountMultiplierMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * This penalty is applied when `htlc_maximum_msat` is equal to or larger than half of the
	 * channel's capacity, (ie. htlc_maximum_msat >= 0.5 * channel_capacity) which makes us
	 * prefer nodes with a smaller `htlc_maximum_msat`. We treat such nodes preferentially
	 * as this makes balance discovery attacks harder to execute, thereby creating an incentive
	 * to restrict `htlc_maximum_msat` and improve privacy.
	 * 
	 * Default value: 250 msat
	 */
	public long get_anti_probing_penalty_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetAntiProbingPenaltyMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * This penalty is applied when `htlc_maximum_msat` is equal to or larger than half of the
	 * channel's capacity, (ie. htlc_maximum_msat >= 0.5 * channel_capacity) which makes us
	 * prefer nodes with a smaller `htlc_maximum_msat`. We treat such nodes preferentially
	 * as this makes balance discovery attacks harder to execute, thereby creating an incentive
	 * to restrict `htlc_maximum_msat` and improve privacy.
	 * 
	 * Default value: 250 msat
	 */
	public void set_anti_probing_penalty_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetAntiProbingPenaltyMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * This penalty is applied when the total amount flowing over a channel exceeds our current
	 * estimate of the channel's available liquidity. The total amount is the amount of the
	 * current HTLC plus any HTLCs which we've sent over the same channel.
	 * 
	 * Note that in this case all other penalties, including the
	 * [`liquidity_penalty_multiplier_msat`] and [`liquidity_penalty_amount_multiplier_msat`]-based
	 * penalties, as well as the [`base_penalty_msat`] and the [`anti_probing_penalty_msat`], if
	 * applicable, are still included in the overall penalty.
	 * 
	 * If you wish to avoid creating paths with such channels entirely, setting this to a value of
	 * `u64::max_value()` will guarantee that.
	 * 
	 * Default value: 1_0000_0000_000 msat (1 Bitcoin)
	 * 
	 * [`liquidity_penalty_multiplier_msat`]: Self::liquidity_penalty_multiplier_msat
	 * [`liquidity_penalty_amount_multiplier_msat`]: Self::liquidity_penalty_amount_multiplier_msat
	 * [`base_penalty_msat`]: Self::base_penalty_msat
	 * [`anti_probing_penalty_msat`]: Self::anti_probing_penalty_msat
	 */
	public long get_considered_impossible_penalty_msat() {
		long ret = Bindings.ProbabilisticScoringFeeParametersGetConsideredImpossiblePenaltyMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * This penalty is applied when the total amount flowing over a channel exceeds our current
	 * estimate of the channel's available liquidity. The total amount is the amount of the
	 * current HTLC plus any HTLCs which we've sent over the same channel.
	 * 
	 * Note that in this case all other penalties, including the
	 * [`liquidity_penalty_multiplier_msat`] and [`liquidity_penalty_amount_multiplier_msat`]-based
	 * penalties, as well as the [`base_penalty_msat`] and the [`anti_probing_penalty_msat`], if
	 * applicable, are still included in the overall penalty.
	 * 
	 * If you wish to avoid creating paths with such channels entirely, setting this to a value of
	 * `u64::max_value()` will guarantee that.
	 * 
	 * Default value: 1_0000_0000_000 msat (1 Bitcoin)
	 * 
	 * [`liquidity_penalty_multiplier_msat`]: Self::liquidity_penalty_multiplier_msat
	 * [`liquidity_penalty_amount_multiplier_msat`]: Self::liquidity_penalty_amount_multiplier_msat
	 * [`base_penalty_msat`]: Self::base_penalty_msat
	 * [`anti_probing_penalty_msat`]: Self::anti_probing_penalty_msat
	 */
	public void set_considered_impossible_penalty_msat(long val) {
		Bindings.ProbabilisticScoringFeeParametersSetConsideredImpossiblePenaltyMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * In order to calculate most of the scores above, we must first convert a lower and upper
	 * bound on the available liquidity in a channel into the probability that we think a payment
	 * will succeed. That probability is derived from a Probability Density Function for where we
	 * think the liquidity in a channel likely lies, given such bounds.
	 * 
	 * If this flag is set, that PDF is simply a constant - we assume that the actual available
	 * liquidity in a channel is just as likely to be at any point between our lower and upper
	 * bounds.
	 * 
	 * If this flag is *not* set, that PDF is `(x - 0.5*capacity) ^ 2`. That is, we use an
	 * exponential curve which expects the liquidity of a channel to lie \"at the edges\". This
	 * matches experimental results - most routing nodes do not aggressively rebalance their
	 * channels and flows in the network are often unbalanced, leaving liquidity usually
	 * unavailable.
	 * 
	 * Thus, for the \"best\" routes, leave this flag `false`. However, the flag does imply a number
	 * of floating-point multiplications in the hottest routing code, which may lead to routing
	 * performance degradation on some machines.
	 * 
	 * Default value: false
	 */
	public bool get_linear_success_probability() {
		bool ret = Bindings.ProbabilisticScoringFeeParametersGetLinearSuccessProbability(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * In order to calculate most of the scores above, we must first convert a lower and upper
	 * bound on the available liquidity in a channel into the probability that we think a payment
	 * will succeed. That probability is derived from a Probability Density Function for where we
	 * think the liquidity in a channel likely lies, given such bounds.
	 * 
	 * If this flag is set, that PDF is simply a constant - we assume that the actual available
	 * liquidity in a channel is just as likely to be at any point between our lower and upper
	 * bounds.
	 * 
	 * If this flag is *not* set, that PDF is `(x - 0.5*capacity) ^ 2`. That is, we use an
	 * exponential curve which expects the liquidity of a channel to lie \"at the edges\". This
	 * matches experimental results - most routing nodes do not aggressively rebalance their
	 * channels and flows in the network are often unbalanced, leaving liquidity usually
	 * unavailable.
	 * 
	 * Thus, for the \"best\" routes, leave this flag `false`. However, the flag does imply a number
	 * of floating-point multiplications in the hottest routing code, which may lead to routing
	 * performance degradation on some machines.
	 * 
	 * Default value: false
	 */
	public void set_linear_success_probability(bool val) {
		Bindings.ProbabilisticScoringFeeParametersSetLinearSuccessProbability(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = Bindings.ProbabilisticScoringFeeParametersClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ProbabilisticScoringFeeParameters
	 */
	public ProbabilisticScoringFeeParameters clone() {
		long ret = Bindings.ProbabilisticScoringFeeParametersClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbabilisticScoringFeeParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ProbabilisticScoringFeeParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a "default" ProbabilisticScoringFeeParameters. See struct and individual field documentaiton for details on which values are used.
	 */
	public static ProbabilisticScoringFeeParameters with_default() {
		long ret = Bindings.ProbabilisticScoringFeeParametersDefault();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ProbabilisticScoringFeeParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ProbabilisticScoringFeeParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Marks the node with the given `node_id` as banned,
	 * i.e it will be avoided during path finding.
	 */
	public void add_banned(org.ldk.structs.NodeId node_id) {
		Bindings.ProbabilisticScoringFeeParametersAddBanned(this.ptr, node_id == null ? 0 : node_id.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(node_id);
		if (this != null) { this.ptrs_to.AddLast(node_id); };
	}

	/**
	 * Marks all nodes in the given list as banned, i.e.,
	 * they will be avoided during path finding.
	 */
	public void add_banned_from_list(NodeId[] node_ids) {
		Bindings.ProbabilisticScoringFeeParametersAddBannedFromList(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(node_ids, node_ids_conv_8 => node_ids_conv_8 == null ? 0 : node_ids_conv_8.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(node_ids);
		foreach (NodeId node_ids_conv_8 in node_ids) { if (this != null) { this.ptrs_to.AddLast(node_ids_conv_8); }; };
	}

	/**
	 * Removes the node with the given `node_id` from the list of nodes to avoid.
	 */
	public void remove_banned(org.ldk.structs.NodeId node_id) {
		Bindings.ProbabilisticScoringFeeParametersRemoveBanned(this.ptr, node_id == null ? 0 : node_id.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(node_id);
		if (this != null) { this.ptrs_to.AddLast(node_id); };
	}

	/**
	 * Sets a manual penalty for the given node.
	 */
	public void set_manual_penalty(org.ldk.structs.NodeId node_id, long penalty) {
		Bindings.ProbabilisticScoringFeeParametersSetManualPenalty(this.ptr, node_id == null ? 0 : node_id.ptr, penalty);
		GC.KeepAlive(this);
		GC.KeepAlive(node_id);
		GC.KeepAlive(penalty);
		if (this != null) { this.ptrs_to.AddLast(node_id); };
	}

	/**
	 * Removes the node with the given `node_id` from the list of manual penalties.
	 */
	public void remove_manual_penalty(org.ldk.structs.NodeId node_id) {
		Bindings.ProbabilisticScoringFeeParametersRemoveManualPenalty(this.ptr, node_id == null ? 0 : node_id.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(node_id);
		if (this != null) { this.ptrs_to.AddLast(node_id); };
	}

	/**
	 * Clears the list of manual penalties that are applied during path finding.
	 */
	public void clear_manual_penalties() {
		Bindings.ProbabilisticScoringFeeParametersClearManualPenalties(this.ptr);
		GC.KeepAlive(this);
	}

}
} } }
