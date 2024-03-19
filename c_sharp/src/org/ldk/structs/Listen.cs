
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of Listen */
public interface IListen {
	/**Notifies the listener that a block was added at the given height, with the transaction data
	 * possibly filtered.
	 */
	void filtered_block_connected(byte[] header, TwoTuple_usizeTransactionZ[] txdata, int height);
	/**Notifies the listener that a block was added at the given height.
	 */
	void block_connected(byte[] block, int height);
	/**Notifies the listener that a block was removed at the given height.
	 */
	void block_disconnected(byte[] header, int height);
}

/**
 * The `Listen` trait is used to notify when blocks have been connected or disconnected from the
 * chain.
 * 
 * Useful when needing to replay chain data upon startup or as new chain events occur. Clients
 * sourcing chain data using a block-oriented API should prefer this interface over [`Confirm`].
 * Such clients fetch the entire header chain whereas clients using [`Confirm`] only fetch headers
 * when needed.
 * 
 * By using [`Listen::filtered_block_connected`] this interface supports clients fetching the
 * entire header chain and only blocks with matching transaction data using BIP 157 filters or
 * other similar filtering.
 */
public class Listen : CommonBase {
	internal Bindings.LDKListen bindings_instance;
	internal long instance_idx;

	internal Listen(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~Listen() {
		if (ptr != 0) { Bindings.ListenFree(ptr); }
	}

	private class LDKListenHolder { internal Listen held; }
	private class LDKListenImpl : Bindings.LDKListen {
		internal LDKListenImpl(IListen arg, LDKListenHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IListen arg;
		private LDKListenHolder impl_holder;
		public void FilteredBlockConnected(long _header, long _txdata, int _height) {
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
			arg.filtered_block_connected(_header_conv, _txdata_conv_28_arr, _height);
				GC.KeepAlive(arg);
		}
		public void BlockConnected(long _block, int _height) {
			byte[] _block_conv = InternalUtils.DecodeUint8Array(_block);
			arg.block_connected(_block_conv, _height);
				GC.KeepAlive(arg);
		}
		public void BlockDisconnected(long _header, int _height) {
			byte[] _header_conv = InternalUtils.DecodeUint8Array(_header);
			arg.block_disconnected(_header_conv, _height);
				GC.KeepAlive(arg);
		}
	}

	/** Creates a new instance of Listen from a given implementation */
	public static Listen new_impl(IListen arg) {
		LDKListenHolder impl_holder = new LDKListenHolder();
		LDKListenImpl impl = new LDKListenImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKListenNew(impl);

		impl_holder.held = new Listen(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Notifies the listener that a block was added at the given height, with the transaction data
	 * possibly filtered.
	 */
	public void filtered_block_connected(byte[] header, TwoTuple_usizeTransactionZ[] txdata, int height) {
		Bindings.ListenFilteredBlockConnected(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(header, 80)), InternalUtils.EncodeUint64Array(InternalUtils.MapArray(txdata, txdata_conv_28 => txdata_conv_28 != null ? txdata_conv_28.ptr : 0)), height);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(txdata);
		GC.KeepAlive(height);
	}

	/**
	 * Notifies the listener that a block was added at the given height.
	 */
	public void block_connected(byte[] block, int height) {
		Bindings.ListenBlockConnected(this.ptr, InternalUtils.EncodeUint8Array(block), height);
		GC.KeepAlive(this);
		GC.KeepAlive(block);
		GC.KeepAlive(height);
	}

	/**
	 * Notifies the listener that a block was removed at the given height.
	 */
	public void block_disconnected(byte[] header, int height) {
		Bindings.ListenBlockDisconnected(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(header, 80)), height);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(height);
	}

}
} } }
