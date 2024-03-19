
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of KVStore */
public interface IKVStore {
	/**Returns the data stored for the given `primary_namespace`, `secondary_namespace`, and
	 * `key`.
	 * 
	 * Returns an [`ErrorKind::NotFound`] if the given `key` could not be found in the given
	 * `primary_namespace` and `secondary_namespace`.
	 * 
	 * [`ErrorKind::NotFound`]: io::ErrorKind::NotFound
	 */
	Result_CVec_u8ZIOErrorZ read(string primary_namespace, string secondary_namespace, string key);
	/**Persists the given data under the given `key`.
	 * 
	 * Will create the given `primary_namespace` and `secondary_namespace` if not already present
	 * in the store.
	 */
	Result_NoneIOErrorZ write(string primary_namespace, string secondary_namespace, string key, byte[] buf);
	/**Removes any data that had previously been persisted under the given `key`.
	 * 
	 * If the `lazy` flag is set to `true`, the backend implementation might choose to lazily
	 * remove the given `key` at some point in time after the method returns, e.g., as part of an
	 * eventual batch deletion of multiple keys. As a consequence, subsequent calls to
	 * [`KVStore::list`] might include the removed key until the changes are actually persisted.
	 * 
	 * Note that while setting the `lazy` flag reduces the I/O burden of multiple subsequent
	 * `remove` calls, it also influences the atomicity guarantees as lazy `remove`s could
	 * potentially get lost on crash after the method returns. Therefore, this flag should only be
	 * set for `remove` operations that can be safely replayed at a later time.
	 * 
	 * Returns successfully if no data will be stored for the given `primary_namespace`,
	 * `secondary_namespace`, and `key`, independently of whether it was present before its
	 * invokation or not.
	 */
	Result_NoneIOErrorZ remove(string primary_namespace, string secondary_namespace, string key, bool lazy);
	/**Returns a list of keys that are stored under the given `secondary_namespace` in
	 * `primary_namespace`.
	 * 
	 * Returns the keys in arbitrary order, so users requiring a particular order need to sort the
	 * returned keys. Returns an empty list if `primary_namespace` or `secondary_namespace` is unknown.
	 */
	Result_CVec_StrZIOErrorZ list(string primary_namespace, string secondary_namespace);
}

/**
 * Provides an interface that allows storage and retrieval of persisted values that are associated
 * with given keys.
 * 
 * In order to avoid collisions the key space is segmented based on the given `primary_namespace`s
 * and `secondary_namespace`s. Implementations of this trait are free to handle them in different
 * ways, as long as per-namespace key uniqueness is asserted.
 * 
 * Keys and namespaces are required to be valid ASCII strings in the range of
 * [`KVSTORE_NAMESPACE_KEY_ALPHABET`] and no longer than [`KVSTORE_NAMESPACE_KEY_MAX_LEN`]. Empty
 * primary namespaces and secondary namespaces (`\"\"`) are assumed to be a valid, however, if
 * `primary_namespace` is empty, `secondary_namespace` is required to be empty, too. This means
 * that concerns should always be separated by primary namespace first, before secondary
 * namespaces are used. While the number of primary namespaces will be relatively small and is
 * determined at compile time, there may be many secondary namespaces per primary namespace. Note
 * that per-namespace uniqueness needs to also hold for keys *and* namespaces in any given
 * namespace, i.e., conflicts between keys and equally named
 * primary namespaces/secondary namespaces must be avoided.
 * 
 * Note:** Users migrating custom persistence backends from the pre-v0.0.117 `KVStorePersister`
 * interface can use a concatenation of `[{primary_namespace}/[{secondary_namespace}/]]{key}` to
 * recover a `key` compatible with the data model previously assumed by `KVStorePersister::persist`.
 */
public class KVStore : CommonBase {
	internal Bindings.LDKKVStore bindings_instance;
	internal long instance_idx;

	internal KVStore(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~KVStore() {
		if (ptr != 0) { Bindings.KVStoreFree(ptr); }
	}

	private class LDKKVStoreHolder { internal KVStore held; }
	private class LDKKVStoreImpl : Bindings.LDKKVStore {
		internal LDKKVStoreImpl(IKVStore arg, LDKKVStoreHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IKVStore arg;
		private LDKKVStoreHolder impl_holder;
		public long Read(long _primary_namespace, long _secondary_namespace, long _key) {
			string _primary_namespace_conv = InternalUtils.DecodeString(_primary_namespace);
			string _secondary_namespace_conv = InternalUtils.DecodeString(_secondary_namespace);
			string _key_conv = InternalUtils.DecodeString(_key);
			Result_CVec_u8ZIOErrorZ ret = arg.read(_primary_namespace_conv, _secondary_namespace_conv, _key_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long Write(long _primary_namespace, long _secondary_namespace, long _key, long _buf) {
			string _primary_namespace_conv = InternalUtils.DecodeString(_primary_namespace);
			string _secondary_namespace_conv = InternalUtils.DecodeString(_secondary_namespace);
			string _key_conv = InternalUtils.DecodeString(_key);
			byte[] _buf_conv = InternalUtils.DecodeUint8Array(_buf);
			Result_NoneIOErrorZ ret = arg.write(_primary_namespace_conv, _secondary_namespace_conv, _key_conv, _buf_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long Remove(long _primary_namespace, long _secondary_namespace, long _key, bool _lazy) {
			string _primary_namespace_conv = InternalUtils.DecodeString(_primary_namespace);
			string _secondary_namespace_conv = InternalUtils.DecodeString(_secondary_namespace);
			string _key_conv = InternalUtils.DecodeString(_key);
			Result_NoneIOErrorZ ret = arg.remove(_primary_namespace_conv, _secondary_namespace_conv, _key_conv, _lazy);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long List(long _primary_namespace, long _secondary_namespace) {
			string _primary_namespace_conv = InternalUtils.DecodeString(_primary_namespace);
			string _secondary_namespace_conv = InternalUtils.DecodeString(_secondary_namespace);
			Result_CVec_StrZIOErrorZ ret = arg.list(_primary_namespace_conv, _secondary_namespace_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of KVStore from a given implementation */
	public static KVStore new_impl(IKVStore arg) {
		LDKKVStoreHolder impl_holder = new LDKKVStoreHolder();
		LDKKVStoreImpl impl = new LDKKVStoreImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKKVStoreNew(impl);

		impl_holder.held = new KVStore(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Returns the data stored for the given `primary_namespace`, `secondary_namespace`, and
	 * `key`.
	 * 
	 * Returns an [`ErrorKind::NotFound`] if the given `key` could not be found in the given
	 * `primary_namespace` and `secondary_namespace`.
	 * 
	 * [`ErrorKind::NotFound`]: io::ErrorKind::NotFound
	 */
	public Result_CVec_u8ZIOErrorZ read(string primary_namespace, string secondary_namespace, string key) {
		long ret = Bindings.KVStoreRead(this.ptr, InternalUtils.EncodeString(primary_namespace), InternalUtils.EncodeString(secondary_namespace), InternalUtils.EncodeString(key));
		GC.KeepAlive(this);
		GC.KeepAlive(primary_namespace);
		GC.KeepAlive(secondary_namespace);
		GC.KeepAlive(key);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_u8ZIOErrorZ ret_hu_conv = Result_CVec_u8ZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Persists the given data under the given `key`.
	 * 
	 * Will create the given `primary_namespace` and `secondary_namespace` if not already present
	 * in the store.
	 */
	public Result_NoneIOErrorZ write(string primary_namespace, string secondary_namespace, string key, byte[] buf) {
		long ret = Bindings.KVStoreWrite(this.ptr, InternalUtils.EncodeString(primary_namespace), InternalUtils.EncodeString(secondary_namespace), InternalUtils.EncodeString(key), InternalUtils.EncodeUint8Array(buf));
		GC.KeepAlive(this);
		GC.KeepAlive(primary_namespace);
		GC.KeepAlive(secondary_namespace);
		GC.KeepAlive(key);
		GC.KeepAlive(buf);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneIOErrorZ ret_hu_conv = Result_NoneIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Removes any data that had previously been persisted under the given `key`.
	 * 
	 * If the `lazy` flag is set to `true`, the backend implementation might choose to lazily
	 * remove the given `key` at some point in time after the method returns, e.g., as part of an
	 * eventual batch deletion of multiple keys. As a consequence, subsequent calls to
	 * [`KVStore::list`] might include the removed key until the changes are actually persisted.
	 * 
	 * Note that while setting the `lazy` flag reduces the I/O burden of multiple subsequent
	 * `remove` calls, it also influences the atomicity guarantees as lazy `remove`s could
	 * potentially get lost on crash after the method returns. Therefore, this flag should only be
	 * set for `remove` operations that can be safely replayed at a later time.
	 * 
	 * Returns successfully if no data will be stored for the given `primary_namespace`,
	 * `secondary_namespace`, and `key`, independently of whether it was present before its
	 * invokation or not.
	 */
	public Result_NoneIOErrorZ remove(string primary_namespace, string secondary_namespace, string key, bool lazy) {
		long ret = Bindings.KVStoreRemove(this.ptr, InternalUtils.EncodeString(primary_namespace), InternalUtils.EncodeString(secondary_namespace), InternalUtils.EncodeString(key), lazy);
		GC.KeepAlive(this);
		GC.KeepAlive(primary_namespace);
		GC.KeepAlive(secondary_namespace);
		GC.KeepAlive(key);
		GC.KeepAlive(lazy);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneIOErrorZ ret_hu_conv = Result_NoneIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Returns a list of keys that are stored under the given `secondary_namespace` in
	 * `primary_namespace`.
	 * 
	 * Returns the keys in arbitrary order, so users requiring a particular order need to sort the
	 * returned keys. Returns an empty list if `primary_namespace` or `secondary_namespace` is unknown.
	 */
	public Result_CVec_StrZIOErrorZ list(string primary_namespace, string secondary_namespace) {
		long ret = Bindings.KVStoreList(this.ptr, InternalUtils.EncodeString(primary_namespace), InternalUtils.EncodeString(secondary_namespace));
		GC.KeepAlive(this);
		GC.KeepAlive(primary_namespace);
		GC.KeepAlive(secondary_namespace);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_StrZIOErrorZ ret_hu_conv = Result_CVec_StrZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
