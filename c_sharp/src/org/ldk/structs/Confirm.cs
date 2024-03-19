
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of Confirm */
public interface IConfirm {
	/**Notifies LDK of transactions confirmed in a block with a given header and height.
	 * 
	 * Must be called for any transactions registered by [`Filter::register_tx`] or any
	 * transactions spending an output registered by [`Filter::register_output`]. Such transactions
	 * appearing in the same block do not need to be included in the same call; instead, multiple
	 * calls with additional transactions may be made so long as they are made in [chain order].
	 * 
	 * May be called before or after [`best_block_updated`] for the corresponding block. However,
	 * in the event of a chain reorganization, it must not be called with a `header` that is no
	 * longer in the chain as of the last call to [`best_block_updated`].
	 * 
	 * [chain order]: Confirm#order
	 * [`best_block_updated`]: Self::best_block_updated
	 */
	void transactions_confirmed(byte[] header, TwoTuple_usizeTransactionZ[] txdata, int height);
	/**Notifies LDK of a transaction that is no longer confirmed as result of a chain reorganization.
	 * 
	 * Must be called for any transaction returned by [`get_relevant_txids`] if it has been
	 * reorganized out of the best chain or if it is no longer confirmed in the block with the
	 * given block hash. Once called, the given transaction will not be returned
	 * by [`get_relevant_txids`], unless it has been reconfirmed via [`transactions_confirmed`].
	 * 
	 * [`get_relevant_txids`]: Self::get_relevant_txids
	 * [`transactions_confirmed`]: Self::transactions_confirmed
	 */
	void transaction_unconfirmed(byte[] txid);
	/**Notifies LDK of an update to the best header connected at the given height.
	 * 
	 * Must be called whenever a new chain tip becomes available. May be skipped for intermediary
	 * blocks.
	 */
	void best_block_updated(byte[] header, int height);
	/**Returns transactions that must be monitored for reorganization out of the chain along
	 * with the height and the hash of the block as part of which it had been previously confirmed.
	 * 
	 * Note that the returned `Option<BlockHash>` might be `None` for channels created with LDK
	 * 0.0.112 and prior, in which case you need to manually track previous confirmations.
	 * 
	 * Will include any transactions passed to [`transactions_confirmed`] that have insufficient
	 * confirmations to be safe from a chain reorganization. Will not include any transactions
	 * passed to [`transaction_unconfirmed`], unless later reconfirmed.
	 * 
	 * Must be called to determine the subset of transactions that must be monitored for
	 * reorganization. Will be idempotent between calls but may change as a result of calls to the
	 * other interface methods. Thus, this is useful to determine which transactions must be
	 * given to [`transaction_unconfirmed`].
	 * 
	 * If any of the returned transactions are confirmed in a block other than the one with the
	 * given hash at the given height, they need to be unconfirmed and reconfirmed via
	 * [`transaction_unconfirmed`] and [`transactions_confirmed`], respectively.
	 * 
	 * [`transactions_confirmed`]: Self::transactions_confirmed
	 * [`transaction_unconfirmed`]: Self::transaction_unconfirmed
	 */
	ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ[] get_relevant_txids();
}

/**
 * The `Confirm` trait is used to notify LDK when relevant transactions have been confirmed on
 * chain or unconfirmed during a chain reorganization.
 * 
 * Clients sourcing chain data using a transaction-oriented API should prefer this interface over
 * [`Listen`]. For instance, an Electrum-based transaction sync implementation may implement
 * [`Filter`] to subscribe to relevant transactions and unspent outputs it should monitor for
 * on-chain activity. Then, it needs to notify LDK via this interface upon observing any changes
 * with reference to the confirmation status of the monitored objects.
 * 
 * # Use
 * The intended use is as follows:
 * - Call [`transactions_confirmed`] to notify LDK whenever any of the registered transactions or
 * outputs are, respectively, confirmed or spent on chain.
 * - Call [`transaction_unconfirmed`] to notify LDK whenever any transaction returned by
 * [`get_relevant_txids`] is no longer confirmed in the block with the given block hash.
 * - Call [`best_block_updated`] to notify LDK whenever a new chain tip becomes available.
 * 
 * # Order
 * 
 * Clients must call these methods in chain order. Specifically:
 * - Transactions which are confirmed in a particular block must be given before transactions
 * confirmed in a later block.
 * - Dependent transactions within the same block must be given in topological order, possibly in
 * separate calls.
 * - All unconfirmed transactions must be given after the original confirmations and before *any*
 * reconfirmations, i.e., [`transactions_confirmed`] and [`transaction_unconfirmed`] calls should
 * never be interleaved, but always conduced *en bloc*.
 * - Any reconfirmed transactions need to be explicitly unconfirmed before they are reconfirmed
 * in regard to the new block.
 * 
 * See individual method documentation for further details.
 * 
 * [`transactions_confirmed`]: Self::transactions_confirmed
 * [`transaction_unconfirmed`]: Self::transaction_unconfirmed
 * [`best_block_updated`]: Self::best_block_updated
 * [`get_relevant_txids`]: Self::get_relevant_txids
 */
public class Confirm : CommonBase {
	internal Bindings.LDKConfirm bindings_instance;
	internal long instance_idx;

	internal Confirm(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~Confirm() {
		if (ptr != 0) { Bindings.ConfirmFree(ptr); }
	}

	private class LDKConfirmHolder { internal Confirm held; }
	private class LDKConfirmImpl : Bindings.LDKConfirm {
		internal LDKConfirmImpl(IConfirm arg, LDKConfirmHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IConfirm arg;
		private LDKConfirmHolder impl_holder;
		public void TransactionsConfirmed(long _header, long _txdata, int _height) {
			byte[] _header_conv = InternalUtils.DecodeUint8Array(_header);
			int _txdata_conv_28_len = InternalUtils.GetArrayLength(_txdata);
			TwoTuple_usizeTransactionZ[] _txdata_conv_28_arr = new TwoTuple_usizeTransactionZ[_txdata_conv_28_len];
			for (int c = 0; c < _txdata_conv_28_len; c++) {
				long _txdata_conv_28 = InternalUtils.GetU64ArrayElem(_txdata, c);
				TwoTuple_usizeTransactionZ _txdata_conv_28_hu_conv = new TwoTuple_usizeTransactionZ(null, _txdata_conv_28);
				if (_txdata_conv_28_hu_conv != null) { _txdata_conv_28_hu_conv.ptrs_to.AddLast(this); };
				_txdata_conv_28_arr[c] = _txdata_conv_28_hu_conv;
			}
			Bindings.FreeBuffer(_txdata);
			arg.transactions_confirmed(_header_conv, _txdata_conv_28_arr, _height);
				GC.KeepAlive(arg);
		}
		public void TransactionUnconfirmed(long _txid) {
			byte[] _txid_conv = InternalUtils.DecodeUint8Array(_txid);
			arg.transaction_unconfirmed(_txid_conv);
				GC.KeepAlive(arg);
		}
		public void BestBlockUpdated(long _header, int _height) {
			byte[] _header_conv = InternalUtils.DecodeUint8Array(_header);
			arg.best_block_updated(_header_conv, _height);
				GC.KeepAlive(arg);
		}
		public long GetRelevantTxids() {
			ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ[] ret = arg.get_relevant_txids();
				GC.KeepAlive(arg);
			long result = InternalUtils.EncodeUint64Array(InternalUtils.MapArray(ret, ret_conv_54 => ret_conv_54 == null ? 0 : ret_conv_54.clone_ptr()));
			return result;
		}
	}

	/** Creates a new instance of Confirm from a given implementation */
	public static Confirm new_impl(IConfirm arg) {
		LDKConfirmHolder impl_holder = new LDKConfirmHolder();
		LDKConfirmImpl impl = new LDKConfirmImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKConfirmNew(impl);

		impl_holder.held = new Confirm(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Notifies LDK of transactions confirmed in a block with a given header and height.
	 * 
	 * Must be called for any transactions registered by [`Filter::register_tx`] or any
	 * transactions spending an output registered by [`Filter::register_output`]. Such transactions
	 * appearing in the same block do not need to be included in the same call; instead, multiple
	 * calls with additional transactions may be made so long as they are made in [chain order].
	 * 
	 * May be called before or after [`best_block_updated`] for the corresponding block. However,
	 * in the event of a chain reorganization, it must not be called with a `header` that is no
	 * longer in the chain as of the last call to [`best_block_updated`].
	 * 
	 * [chain order]: Confirm#order
	 * [`best_block_updated`]: Self::best_block_updated
	 */
	public void transactions_confirmed(byte[] header, TwoTuple_usizeTransactionZ[] txdata, int height) {
		Bindings.ConfirmTransactionsConfirmed(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(header, 80)), InternalUtils.EncodeUint64Array(InternalUtils.MapArray(txdata, txdata_conv_28 => txdata_conv_28 != null ? txdata_conv_28.ptr : 0)), height);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(txdata);
		GC.KeepAlive(height);
	}

	/**
	 * Notifies LDK of a transaction that is no longer confirmed as result of a chain reorganization.
	 * 
	 * Must be called for any transaction returned by [`get_relevant_txids`] if it has been
	 * reorganized out of the best chain or if it is no longer confirmed in the block with the
	 * given block hash. Once called, the given transaction will not be returned
	 * by [`get_relevant_txids`], unless it has been reconfirmed via [`transactions_confirmed`].
	 * 
	 * [`get_relevant_txids`]: Self::get_relevant_txids
	 * [`transactions_confirmed`]: Self::transactions_confirmed
	 */
	public void transaction_unconfirmed(byte[] txid) {
		Bindings.ConfirmTransactionUnconfirmed(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(txid, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(txid);
	}

	/**
	 * Notifies LDK of an update to the best header connected at the given height.
	 * 
	 * Must be called whenever a new chain tip becomes available. May be skipped for intermediary
	 * blocks.
	 */
	public void best_block_updated(byte[] header, int height) {
		Bindings.ConfirmBestBlockUpdated(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(header, 80)), height);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(height);
	}

	/**
	 * Returns transactions that must be monitored for reorganization out of the chain along
	 * with the height and the hash of the block as part of which it had been previously confirmed.
	 * 
	 * Note that the returned `Option<BlockHash>` might be `None` for channels created with LDK
	 * 0.0.112 and prior, in which case you need to manually track previous confirmations.
	 * 
	 * Will include any transactions passed to [`transactions_confirmed`] that have insufficient
	 * confirmations to be safe from a chain reorganization. Will not include any transactions
	 * passed to [`transaction_unconfirmed`], unless later reconfirmed.
	 * 
	 * Must be called to determine the subset of transactions that must be monitored for
	 * reorganization. Will be idempotent between calls but may change as a result of calls to the
	 * other interface methods. Thus, this is useful to determine which transactions must be
	 * given to [`transaction_unconfirmed`].
	 * 
	 * If any of the returned transactions are confirmed in a block other than the one with the
	 * given hash at the given height, they need to be unconfirmed and reconfirmed via
	 * [`transaction_unconfirmed`] and [`transactions_confirmed`], respectively.
	 * 
	 * [`transactions_confirmed`]: Self::transactions_confirmed
	 * [`transaction_unconfirmed`]: Self::transaction_unconfirmed
	 */
	public ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ[] get_relevant_txids() {
		long ret = Bindings.ConfirmGetRelevantTxids(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_54_len = InternalUtils.GetArrayLength(ret);
		ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ[] ret_conv_54_arr = new ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ[ret_conv_54_len];
		for (int c = 0; c < ret_conv_54_len; c++) {
			long ret_conv_54 = InternalUtils.GetU64ArrayElem(ret, c);
			ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ ret_conv_54_hu_conv = new ThreeTuple_ThirtyTwoBytesu32COption_ThirtyTwoBytesZZ(null, ret_conv_54);
			if (ret_conv_54_hu_conv != null) { ret_conv_54_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_54_arr[c] = ret_conv_54_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_54_arr;
	}

}
} } }
