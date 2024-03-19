
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of WriteableScore */
public interface IWriteableScore {
	/**Serialize the object into a byte array
	 */
	byte[] write();
}

/**
 * Refers to a scorer that is accessible under lock and also writeable to disk
 * 
 * We need this trait to be able to pass in a scorer to `lightning-background-processor` that will enable us to
 * use the Persister to persist it.
 */
public class WriteableScore : CommonBase {
	internal Bindings.LDKWriteableScore bindings_instance;
	internal long instance_idx;

	internal WriteableScore(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~WriteableScore() {
		if (ptr != 0) { Bindings.WriteableScoreFree(ptr); }
	}

	private class LDKWriteableScoreHolder { internal WriteableScore held; }
	private class LDKWriteableScoreImpl : Bindings.LDKWriteableScore {
		internal LDKWriteableScoreImpl(IWriteableScore arg, LDKWriteableScoreHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IWriteableScore arg;
		private LDKWriteableScoreHolder impl_holder;
		public long Write() {
			byte[] ret = arg.write();
				GC.KeepAlive(arg);
			long result = InternalUtils.EncodeUint8Array(ret);
			return result;
		}
	}

	/** Creates a new instance of WriteableScore from a given implementation */
	public static WriteableScore new_impl(IWriteableScore arg, ILockableScore lockableScore_impl) {
		LDKWriteableScoreHolder impl_holder = new LDKWriteableScoreHolder();
		LDKWriteableScoreImpl impl = new LDKWriteableScoreImpl(arg, impl_holder);
		LockableScore lockableScore = LockableScore.new_impl(lockableScore_impl);
		long[] ptr_idx = Bindings.LDKWriteableScoreNew(impl, lockableScore.instance_idx);

		impl_holder.held = new WriteableScore(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		impl_holder.held.ptrs_to.AddLast(lockableScore);
		return impl_holder.held;
	}

	/**
	 * Serialize the object into a byte array
	 */
	public byte[] write() {
		long ret = Bindings.WriteableScoreWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
