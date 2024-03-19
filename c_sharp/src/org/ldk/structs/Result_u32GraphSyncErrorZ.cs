using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_u32GraphSyncErrorZ : CommonBase {
	Result_u32GraphSyncErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_u32GraphSyncErrorZ() {
		if (ptr != 0) { Bindings.CResultU32GraphsyncerrorzFree(ptr); }
	}

	internal static Result_u32GraphSyncErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultU32GraphsyncerrorzIsOk(ptr)) {
			return new Result_u32GraphSyncErrorZ_OK(null, ptr);
		} else {
			return new Result_u32GraphSyncErrorZ_Err(null, ptr);
		}
	}
	public class Result_u32GraphSyncErrorZ_OK : Result_u32GraphSyncErrorZ {
		public readonly int res;
		internal Result_u32GraphSyncErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = Bindings.CResultU32GraphsyncerrorzGetOk(ptr);
		}
	}

	public class Result_u32GraphSyncErrorZ_Err : Result_u32GraphSyncErrorZ {
		public readonly GraphSyncError err;
		internal Result_u32GraphSyncErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultU32GraphsyncerrorzGetErr(ptr);
			org.ldk.structs.GraphSyncError err_hu_conv = org.ldk.structs.GraphSyncError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_u32GraphSyncErrorZ in the success state.
	 */
	public static Result_u32GraphSyncErrorZ ok(int o) {
		long ret = Bindings.CResultU32GraphsyncerrorzOk(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u32GraphSyncErrorZ ret_hu_conv = Result_u32GraphSyncErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_u32GraphSyncErrorZ in the error state.
	 */
	public static Result_u32GraphSyncErrorZ err(org.ldk.structs.GraphSyncError e) {
		long ret = Bindings.CResultU32GraphsyncerrorzErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_u32GraphSyncErrorZ ret_hu_conv = Result_u32GraphSyncErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultU32GraphsyncerrorzIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
