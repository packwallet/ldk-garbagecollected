
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of BroadcasterInterface */
public interface IBroadcasterInterface {
	/**Sends a list of transactions out to (hopefully) be mined.
	 * This only needs to handle the actual broadcasting of transactions, LDK will automatically
	 * rebroadcast transactions that haven't made it into a block.
	 * 
	 * In some cases LDK may attempt to broadcast a transaction which double-spends another
	 * and this isn't a bug and can be safely ignored.
	 * 
	 * If more than one transaction is given, these transactions should be considered to be a
	 * package and broadcast together. Some of the transactions may or may not depend on each other,
	 * be sure to manage both cases correctly.
	 * 
	 * Bitcoin transaction packages are defined in BIP 331 and here:
	 * <https://github.com/bitcoin/bitcoin/blob/master/doc/policy/packages.md>
	 */
	void broadcast_transactions(byte[][] txs);
}

/**
 * An interface to send a transaction to the Bitcoin network.
 */
public class BroadcasterInterface : CommonBase {
	internal Bindings.LDKBroadcasterInterface bindings_instance;
	internal long instance_idx;

	internal BroadcasterInterface(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~BroadcasterInterface() {
		if (ptr != 0) { Bindings.BroadcasterInterfaceFree(ptr); }
	}

	private class LDKBroadcasterInterfaceHolder { internal BroadcasterInterface held; }
	private class LDKBroadcasterInterfaceImpl : Bindings.LDKBroadcasterInterface {
		internal LDKBroadcasterInterfaceImpl(IBroadcasterInterface arg, LDKBroadcasterInterfaceHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IBroadcasterInterface arg;
		private LDKBroadcasterInterfaceHolder impl_holder;
		public void BroadcastTransactions(long _txs) {
			int _txs_conv_8_len = InternalUtils.GetArrayLength(_txs);
			byte[][] _txs_conv_8_arr = new byte[_txs_conv_8_len][];
			for (int i = 0; i < _txs_conv_8_len; i++) {
				long _txs_conv_8 = InternalUtils.GetU64ArrayElem(_txs, i);
				byte[] _txs_conv_8_conv = InternalUtils.DecodeUint8Array(_txs_conv_8);
				_txs_conv_8_arr[i] = _txs_conv_8_conv;
			}
			Bindings.FreeBuffer(_txs);
			arg.broadcast_transactions(_txs_conv_8_arr);
				GC.KeepAlive(arg);
		}
	}

	/** Creates a new instance of BroadcasterInterface from a given implementation */
	public static BroadcasterInterface new_impl(IBroadcasterInterface arg) {
		LDKBroadcasterInterfaceHolder impl_holder = new LDKBroadcasterInterfaceHolder();
		LDKBroadcasterInterfaceImpl impl = new LDKBroadcasterInterfaceImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKBroadcasterInterfaceNew(impl);

		impl_holder.held = new BroadcasterInterface(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Sends a list of transactions out to (hopefully) be mined.
	 * This only needs to handle the actual broadcasting of transactions, LDK will automatically
	 * rebroadcast transactions that haven't made it into a block.
	 * 
	 * In some cases LDK may attempt to broadcast a transaction which double-spends another
	 * and this isn't a bug and can be safely ignored.
	 * 
	 * If more than one transaction is given, these transactions should be considered to be a
	 * package and broadcast together. Some of the transactions may or may not depend on each other,
	 * be sure to manage both cases correctly.
	 * 
	 * Bitcoin transaction packages are defined in BIP 331 and here:
	 * <https://github.com/bitcoin/bitcoin/blob/master/doc/policy/packages.md>
	 */
	public void broadcast_transactions(byte[][] txs) {
		Bindings.BroadcasterInterfaceBroadcastTransactions(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(txs, txs_conv_8 => InternalUtils.EncodeUint8Array(txs_conv_8))));
		GC.KeepAlive(this);
		GC.KeepAlive(txs);
	}

}
} } }
